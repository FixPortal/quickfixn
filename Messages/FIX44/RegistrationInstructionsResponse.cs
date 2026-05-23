// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class RegistrationInstructionsResponse : Message
{
    public const string MsgType = "p";

    public RegistrationInstructionsResponse() : base()
    {
        Header.SetField(new MsgType("p"));
    }

    public RegistrationInstructionsResponse(
            RegistID aRegistID,
            RegistTransType aRegistTransType,
            RegistRefID aRegistRefID,
            RegistStatus aRegistStatus
        ) : this()
    {
        RegistID = aRegistID;
        RegistTransType = aRegistTransType;
        RegistRefID = aRegistRefID;
        RegistStatus = aRegistStatus;
    }

    public RegistID RegistID
    {
        get
        {
            RegistID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistID val) { RegistID = val; }
    public RegistID Get(RegistID val) { GetField(val); return val; }
    public bool IsSet(RegistID val) { return IsSetRegistID(); }
    public bool IsSetRegistID() { return IsSetField(Tags.RegistID); }

    public RegistTransType RegistTransType
    {
        get
        {
            RegistTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistTransType val) { RegistTransType = val; }
    public RegistTransType Get(RegistTransType val) { GetField(val); return val; }
    public bool IsSet(RegistTransType val) { return IsSetRegistTransType(); }
    public bool IsSetRegistTransType() { return IsSetField(Tags.RegistTransType); }

    public RegistRefID RegistRefID
    {
        get
        {
            RegistRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistRefID val) { RegistRefID = val; }
    public RegistRefID Get(RegistRefID val) { GetField(val); return val; }
    public bool IsSet(RegistRefID val) { return IsSetRegistRefID(); }
    public bool IsSetRegistRefID() { return IsSetField(Tags.RegistRefID); }

    public ClOrdID ClOrdID
    {
        get
        {
            ClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdID val) { ClOrdID = val; }
    public ClOrdID Get(ClOrdID val) { GetField(val); return val; }
    public bool IsSet(ClOrdID val) { return IsSetClOrdID(); }
    public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

    public NoPartyIDs NoPartyIDs
    {
        get
        {
            NoPartyIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyIDs val) { NoPartyIDs = val; }
    public NoPartyIDs Get(NoPartyIDs val) { GetField(val); return val; }
    public bool IsSet(NoPartyIDs val) { return IsSetNoPartyIDs(); }
    public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

    public Account Account
    {
        get
        {
            Account val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Account val) { Account = val; }
    public Account Get(Account val) { GetField(val); return val; }
    public bool IsSet(Account val) { return IsSetAccount(); }
    public bool IsSetAccount() { return IsSetField(Tags.Account); }

    public AcctIDSource AcctIDSource
    {
        get
        {
            AcctIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AcctIDSource val) { AcctIDSource = val; }
    public AcctIDSource Get(AcctIDSource val) { GetField(val); return val; }
    public bool IsSet(AcctIDSource val) { return IsSetAcctIDSource(); }
    public bool IsSetAcctIDSource() { return IsSetField(Tags.AcctIDSource); }

    public RegistStatus RegistStatus
    {
        get
        {
            RegistStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistStatus val) { RegistStatus = val; }
    public RegistStatus Get(RegistStatus val) { GetField(val); return val; }
    public bool IsSet(RegistStatus val) { return IsSetRegistStatus(); }
    public bool IsSetRegistStatus() { return IsSetField(Tags.RegistStatus); }

    public RegistRejReasonCode RegistRejReasonCode
    {
        get
        {
            RegistRejReasonCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistRejReasonCode val) { RegistRejReasonCode = val; }
    public RegistRejReasonCode Get(RegistRejReasonCode val) { GetField(val); return val; }
    public bool IsSet(RegistRejReasonCode val) { return IsSetRegistRejReasonCode(); }
    public bool IsSetRegistRejReasonCode() { return IsSetField(Tags.RegistRejReasonCode); }

    public RegistRejReasonText RegistRejReasonText
    {
        get
        {
            RegistRejReasonText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistRejReasonText val) { RegistRejReasonText = val; }
    public RegistRejReasonText Get(RegistRejReasonText val) { GetField(val); return val; }
    public bool IsSet(RegistRejReasonText val) { return IsSetRegistRejReasonText(); }
    public bool IsSetRegistRejReasonText() { return IsSetField(Tags.RegistRejReasonText); }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartyRoleQualifier, Tags.NoPartySubIDs, Tags.NoPartyAltIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartyRoleQualifier, Tags.NoPartySubIDs, Tags.NoPartyAltIDs, 0};

        public NoPartyIDsGroup()
          : base(Tags.NoPartyIDs, Tags.PartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyID PartyID
        {
            get
            {
                PartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyID val) { PartyID = val; }
        public PartyID Get(PartyID val) { GetField(val); return val; }
        public bool IsSet(PartyID val) { return IsSetPartyID(); }
        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public PartyIDSource PartyIDSource
        {
            get
            {
                PartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyIDSource val) { PartyIDSource = val; }
        public PartyIDSource Get(PartyIDSource val) { GetField(val); return val; }
        public bool IsSet(PartyIDSource val) { return IsSetPartyIDSource(); }
        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public PartyRole PartyRole
        {
            get
            {
                PartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRole val) { PartyRole = val; }
        public PartyRole Get(PartyRole val) { GetField(val); return val; }
        public bool IsSet(PartyRole val) { return IsSetPartyRole(); }
        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public PartyRoleQualifier PartyRoleQualifier
        {
            get
            {
                PartyRoleQualifier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRoleQualifier val) { PartyRoleQualifier = val; }
        public PartyRoleQualifier Get(PartyRoleQualifier val) { GetField(val); return val; }
        public bool IsSet(PartyRoleQualifier val) { return IsSetPartyRoleQualifier(); }
        public bool IsSetPartyRoleQualifier() { return IsSetField(Tags.PartyRoleQualifier); }

        public NoPartySubIDs NoPartySubIDs
        {
            get
            {
                NoPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoPartySubIDs val) { NoPartySubIDs = val; }
        public NoPartySubIDs Get(NoPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoPartySubIDs val) { return IsSetNoPartySubIDs(); }
        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }

        public NoPartyAltIDs NoPartyAltIDs
        {
            get
            {
                NoPartyAltIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoPartyAltIDs val) { NoPartyAltIDs = val; }
        public NoPartyAltIDs Get(NoPartyAltIDs val) { GetField(val); return val; }
        public bool IsSet(NoPartyAltIDs val) { return IsSetNoPartyAltIDs(); }
        public bool IsSetNoPartyAltIDs() { return IsSetField(Tags.NoPartyAltIDs); }

        public class NoPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartySubID, Tags.PartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup()
              : base(Tags.NoPartySubIDs, Tags.PartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public PartySubID PartySubID
            {
                get
                {
                    PartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubID val) { PartySubID = val; }
            public PartySubID Get(PartySubID val) { GetField(val); return val; }
            public bool IsSet(PartySubID val) { return IsSetPartySubID(); }
            public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }

            public PartySubIDType PartySubIDType
            {
                get
                {
                    PartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubIDType val) { PartySubIDType = val; }
            public PartySubIDType Get(PartySubIDType val) { GetField(val); return val; }
            public bool IsSet(PartySubIDType val) { return IsSetPartySubIDType(); }
            public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }
        }

        public class NoPartyAltIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartyAltID, Tags.PartyAltIDSource, Tags.NoPartyAltSubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartyAltID, Tags.PartyAltIDSource, Tags.NoPartyAltSubIDs, 0};

            public NoPartyAltIDsGroup()
              : base(Tags.NoPartyAltIDs, Tags.PartyAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyAltIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public PartyAltID PartyAltID
            {
                get
                {
                    PartyAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartyAltID val) { PartyAltID = val; }
            public PartyAltID Get(PartyAltID val) { GetField(val); return val; }
            public bool IsSet(PartyAltID val) { return IsSetPartyAltID(); }
            public bool IsSetPartyAltID() { return IsSetField(Tags.PartyAltID); }

            public PartyAltIDSource PartyAltIDSource
            {
                get
                {
                    PartyAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartyAltIDSource val) { PartyAltIDSource = val; }
            public PartyAltIDSource Get(PartyAltIDSource val) { GetField(val); return val; }
            public bool IsSet(PartyAltIDSource val) { return IsSetPartyAltIDSource(); }
            public bool IsSetPartyAltIDSource() { return IsSetField(Tags.PartyAltIDSource); }

            public NoPartyAltSubIDs NoPartyAltSubIDs
            {
                get
                {
                    NoPartyAltSubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoPartyAltSubIDs val) { NoPartyAltSubIDs = val; }
            public NoPartyAltSubIDs Get(NoPartyAltSubIDs val) { GetField(val); return val; }
            public bool IsSet(NoPartyAltSubIDs val) { return IsSetNoPartyAltSubIDs(); }
            public bool IsSetNoPartyAltSubIDs() { return IsSetField(Tags.NoPartyAltSubIDs); }

            public class NoPartyAltSubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.PartyAltSubID, Tags.PartyAltSubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.PartyAltSubID, Tags.PartyAltSubIDType, 0};

                public NoPartyAltSubIDsGroup()
                  : base(Tags.NoPartyAltSubIDs, Tags.PartyAltSubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyAltSubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public PartyAltSubID PartyAltSubID
                {
                    get
                    {
                        PartyAltSubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(PartyAltSubID val) { PartyAltSubID = val; }
                public PartyAltSubID Get(PartyAltSubID val) { GetField(val); return val; }
                public bool IsSet(PartyAltSubID val) { return IsSetPartyAltSubID(); }
                public bool IsSetPartyAltSubID() { return IsSetField(Tags.PartyAltSubID); }

                public PartyAltSubIDType PartyAltSubIDType
                {
                    get
                    {
                        PartyAltSubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(PartyAltSubIDType val) { PartyAltSubIDType = val; }
                public PartyAltSubIDType Get(PartyAltSubIDType val) { GetField(val); return val; }
                public bool IsSet(PartyAltSubIDType val) { return IsSetPartyAltSubIDType(); }
                public bool IsSetPartyAltSubIDType() { return IsSetField(Tags.PartyAltSubIDType); }
            }
        }
    }
}
