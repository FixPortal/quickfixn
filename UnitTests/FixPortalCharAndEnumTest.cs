using NUnit.Framework;
using QuickFix;
using QuickFix.DataDictionary;
using QuickFix.Fields;
using UnitTests.TestHelpers;

namespace UnitTests;

// Coverage for FixPortal validation enhancements that previously had no tests:
//  - Lenient char-field parsing honoured at the FieldMap read site (FieldMap.cs:453-454),
//    opt-in via AllowStringTruncationForCharFields (the per-session flag threaded from config).
//  - Strict per-value enum validation that surfaces the offending value(s) in
//    IncorrectTagValue (DataDictionary.cs:364-378); upstream reported a generic failure.

[TestFixture]
public class FixPortalLenientCharFieldTest
{
    [Test]
    public void GetChar_MultiCharValue_TruncatesWhenFlagEnabled()
    {
        var m = new Message { AllowStringTruncationForCharFields = true };
        m.SetField(new StringField(7000, "AB"));
        Assert.That(m.GetChar(7000), Is.EqualTo('A'));
    }

    [Test]
    public void GetChar_MultiCharValue_ThrowsWhenFlagDisabled()
    {
        var m = new Message(); // flag defaults to false — strict upstream behaviour
        m.SetField(new StringField(7000, "AB"));
        Assert.Throws<FieldConvertError>(() => m.GetChar(7000));
    }

    [Test]
    public void FromString_SetsAllowStringTruncationFromDictionaries()
    {
        var dd = new DataDictionary();
        dd.AllowStringTruncationForCharFields = true;

        var m = new Message();
        string msgStr = "8=FIX.4.2\x01" + "9=12\x01" + "35=B\x01" + "4=AB\x01" + "10=114\x01";

        m.FromString(msgStr, validate: false, transportDict: null, appDict: dd);

        Assert.That(m.AllowStringTruncationForCharFields, Is.True);
        Assert.That(m.GetChar(4), Is.EqualTo('A'));
    }
}

[TestFixture]
public class FixPortalEnumValueRejectionTest
{
    private DataDictionary _dd = null!;

    [OneTimeSetUp]
    public void LoadSpec()
    {
        _dd = new DataDictionary();
        _dd.LoadFIXSpec("FIX44");
    }

    [Test]
    public void CheckValue_SingleValueEnum_BadValue_CarriesOffendingValue()
    {
        // Side (54) is a single-value enum field; "Z" is not a member.
        var ex = Assert.Throws<IncorrectTagValue>(() => _dd.CheckValue(new StringField(54, "Z")));
        Assert.That(ex!.Field, Is.EqualTo(54));
        Assert.That(ex.Value, Is.EqualTo("Z"));
    }

    [Test]
    public void CheckValue_MultiValueEnum_NamesOnlyTheOffendingTokens()
    {
        // ExecInst (18) is a multiple-value enum field. "1" is valid (NOT_HELD); "ZZ" is not.
        // The FP enhancement collects only the invalid token(s) rather than failing generically.
        var ex = Assert.Throws<IncorrectTagValue>(() => _dd.CheckValue(new StringField(18, "1 ZZ")));
        Assert.That(ex!.Field, Is.EqualTo(18));
        Assert.That(ex.Value, Does.Contain("ZZ"));
        Assert.That(ex.Value, Does.Not.Contain("1"));
    }
}
