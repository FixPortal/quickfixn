// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class Reject : Message
{
    public const string MsgType = "3";

    public Reject() : base()
    {
        Header.SetField(new MsgType("3"));
    }

    public Reject(
            RefSeqNum aRefSeqNum
        ) : this()
    {
        RefSeqNum = aRefSeqNum;
    }

    public RefSeqNum RefSeqNum
    {
        get
        {
            RefSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefSeqNum val) { RefSeqNum = val; }
    public RefSeqNum Get(RefSeqNum val) { GetField(val); return val; }
    public bool IsSet(RefSeqNum val) { return IsSetRefSeqNum(); }
    public bool IsSetRefSeqNum() { return IsSetField(Tags.RefSeqNum); }

    public RefTagID RefTagID
    {
        get
        {
            RefTagID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefTagID val) { RefTagID = val; }
    public RefTagID Get(RefTagID val) { GetField(val); return val; }
    public bool IsSet(RefTagID val) { return IsSetRefTagID(); }
    public bool IsSetRefTagID() { return IsSetField(Tags.RefTagID); }

    public RefMsgType RefMsgType
    {
        get
        {
            RefMsgType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefMsgType val) { RefMsgType = val; }
    public RefMsgType Get(RefMsgType val) { GetField(val); return val; }
    public bool IsSet(RefMsgType val) { return IsSetRefMsgType(); }
    public bool IsSetRefMsgType() { return IsSetField(Tags.RefMsgType); }

    public RefApplVerID RefApplVerID
    {
        get
        {
            RefApplVerID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefApplVerID val) { RefApplVerID = val; }
    public RefApplVerID Get(RefApplVerID val) { GetField(val); return val; }
    public bool IsSet(RefApplVerID val) { return IsSetRefApplVerID(); }
    public bool IsSetRefApplVerID() { return IsSetField(Tags.RefApplVerID); }

    public RefApplExtID RefApplExtID
    {
        get
        {
            RefApplExtID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefApplExtID val) { RefApplExtID = val; }
    public RefApplExtID Get(RefApplExtID val) { GetField(val); return val; }
    public bool IsSet(RefApplExtID val) { return IsSetRefApplExtID(); }
    public bool IsSetRefApplExtID() { return IsSetField(Tags.RefApplExtID); }

    public RefCstmApplVerID RefCstmApplVerID
    {
        get
        {
            RefCstmApplVerID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefCstmApplVerID val) { RefCstmApplVerID = val; }
    public RefCstmApplVerID Get(RefCstmApplVerID val) { GetField(val); return val; }
    public bool IsSet(RefCstmApplVerID val) { return IsSetRefCstmApplVerID(); }
    public bool IsSetRefCstmApplVerID() { return IsSetField(Tags.RefCstmApplVerID); }

    public SessionRejectReason SessionRejectReason
    {
        get
        {
            SessionRejectReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SessionRejectReason val) { SessionRejectReason = val; }
    public SessionRejectReason Get(SessionRejectReason val) { GetField(val); return val; }
    public bool IsSet(SessionRejectReason val) { return IsSetSessionRejectReason(); }
    public bool IsSetSessionRejectReason() { return IsSetField(Tags.SessionRejectReason); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }
}
