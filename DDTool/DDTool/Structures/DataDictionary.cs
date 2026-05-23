using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DDTool.Exceptions;

namespace DDTool.Structures;

public class DataDictionary
{
    /// <summary>
    /// This is purely informative.  You can set it to nonsense if you want.
    /// </summary>
    /// <value></value>
    public string SourceFile { get; }

    /// <summary>
    /// Optional "customname" attribute on root fix tag
    /// </summary>
    public string? CustomName { get; set; }

    public int? MajorVersion { get; set; }
    public int? MinorVersion { get; set; }
    public int? ServicePack { get; set; }
    public bool IsFIXT { get; set; }

    public Dictionary<int, DDField> FieldsByTag { get; } = new();
    public Dictionary<string, DDField> FieldsByName { get; } = new();
    public Dictionary<string, DDMessage> Messages { get; } = new();

    public DataDictionary(string sourceFile)
    {
        SourceFile = sourceFile;
    }

    /// <summary>
    /// A combination of type/Major/Minor/SP.
    /// This is NOT the FIX BeginString.
    /// </summary>
    /// <value>e.g. "FIX.4.2", "FIXT.1.1", "FIX.5.0.SP2"</value>
    public string Identifier
    {
        get
        {
            var prefix = IsFIXT ? "FIXT" : "FIX";
            var svcPack = ServicePack is null ? "" : $"SP{ServicePack}";
            var defaultIdentifier =  $"{prefix}.{MajorVersion}.{MinorVersion}{svcPack}";
            // FixPortal Enhancement
            return _centerpriseDesiredOrder.TryGetValue(defaultIdentifier, out var value) ? $"{value}_{defaultIdentifier}" : defaultIdentifier;
        }
    }

    private readonly Dictionary<string, int> _centerpriseDesiredOrder = new()
    {
        { "FIX.4.0", 1 },
        { "FIX.4.1", 2 },
        { "FIX.4.3", 3 },
        { "FIX.5.0", 4 },
        { "FIX.5.0SP1", 5 },
        { "FIX.5.0SP2", 6 },
        { "FIXT.1.1", 7 },
        { "FIX.4.2", 8 },
        { "FIX.4.4", 8 },
    };

    /// <summary>
    /// Returns e.g. "FIX42", "FIXT11", "FIX50SP2"
    /// </summary>
    public string IdentifierNoDots
    {
        // FixPortal Enhancement
        get
        {
            Regex regex = new(@"(?:1_)?(FIXT?\.\d\.\d(?:SP\d+)?)");

            Match match = regex.Match(Identifier);

            return match.Success ?
                match.Groups[1].Value.Replace(".", "") :
                Identifier.Replace(".", "");
        }
    }

    /// <summary>
    /// Name to use for dir and project
    /// </summary>
    public string Name => CustomName ?? IdentifierNoDots;

    public void AddField(DDField fld) {
        if (FieldsByTag.ContainsKey(fld.Tag))
            throw new ParsingException($"Field tag is defined twice: {fld.Tag}");
        FieldsByTag[fld.Tag] = fld;

        if (FieldsByName.ContainsKey(fld.Name))
            throw new ParsingException($"Field name is defined twice: {fld.Tag}");
        FieldsByName[fld.Name] = fld;
    }

    public void AddMessage(DDMessage msg) {
        if (Messages.ContainsKey(msg.MsgType))
            throw new ParsingException($"Message type is defined twice: {msg.MsgType}");
        Messages[msg.MsgType] = msg;
    }

    /// <summary>
    /// Lookup the field by name.  Throw ParsingException if not found.
    /// </summary>
    /// <param name="fieldName"></param>
    public DDField LookupField(string fieldName) {
        if (!FieldsByName.ContainsKey(fieldName))
            throw new ParsingException($"Field '{fieldName}' is not defined in <fields> section.");
        return FieldsByName[fieldName];
    }
}
