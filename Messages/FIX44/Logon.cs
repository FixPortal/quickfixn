// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class Logon : Message
{
    public const string MsgType = "A";

    public Logon() : base()
    {
        Header.SetField(new MsgType("A"));
    }

    public Logon(
            EncryptMethod aEncryptMethod,
            HeartBtInt aHeartBtInt
        ) : this()
    {
        EncryptMethod = aEncryptMethod;
        HeartBtInt = aHeartBtInt;
    }

    public EncryptMethod EncryptMethod
    {
        get
        {
            EncryptMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncryptMethod val) { EncryptMethod = val; }
    public EncryptMethod Get(EncryptMethod val) { GetField(val); return val; }
    public bool IsSet(EncryptMethod val) { return IsSetEncryptMethod(); }
    public bool IsSetEncryptMethod() { return IsSetField(Tags.EncryptMethod); }

    public HeartBtInt HeartBtInt
    {
        get
        {
            HeartBtInt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HeartBtInt val) { HeartBtInt = val; }
    public HeartBtInt Get(HeartBtInt val) { GetField(val); return val; }
    public bool IsSet(HeartBtInt val) { return IsSetHeartBtInt(); }
    public bool IsSetHeartBtInt() { return IsSetField(Tags.HeartBtInt); }

    public RawDataLength RawDataLength
    {
        get
        {
            RawDataLength val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RawDataLength val) { RawDataLength = val; }
    public RawDataLength Get(RawDataLength val) { GetField(val); return val; }
    public bool IsSet(RawDataLength val) { return IsSetRawDataLength(); }
    public bool IsSetRawDataLength() { return IsSetField(Tags.RawDataLength); }

    public RawData RawData
    {
        get
        {
            RawData val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RawData val) { RawData = val; }
    public RawData Get(RawData val) { GetField(val); return val; }
    public bool IsSet(RawData val) { return IsSetRawData(); }
    public bool IsSetRawData() { return IsSetField(Tags.RawData); }

    public ResetSeqNumFlag ResetSeqNumFlag
    {
        get
        {
            ResetSeqNumFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ResetSeqNumFlag val) { ResetSeqNumFlag = val; }
    public ResetSeqNumFlag Get(ResetSeqNumFlag val) { GetField(val); return val; }
    public bool IsSet(ResetSeqNumFlag val) { return IsSetResetSeqNumFlag(); }
    public bool IsSetResetSeqNumFlag() { return IsSetField(Tags.ResetSeqNumFlag); }

    public NextExpectedMsgSeqNum NextExpectedMsgSeqNum
    {
        get
        {
            NextExpectedMsgSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NextExpectedMsgSeqNum val) { NextExpectedMsgSeqNum = val; }
    public NextExpectedMsgSeqNum Get(NextExpectedMsgSeqNum val) { GetField(val); return val; }
    public bool IsSet(NextExpectedMsgSeqNum val) { return IsSetNextExpectedMsgSeqNum(); }
    public bool IsSetNextExpectedMsgSeqNum() { return IsSetField(Tags.NextExpectedMsgSeqNum); }

    public MaxMessageSize MaxMessageSize
    {
        get
        {
            MaxMessageSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxMessageSize val) { MaxMessageSize = val; }
    public MaxMessageSize Get(MaxMessageSize val) { GetField(val); return val; }
    public bool IsSet(MaxMessageSize val) { return IsSetMaxMessageSize(); }
    public bool IsSetMaxMessageSize() { return IsSetField(Tags.MaxMessageSize); }

    public NoMsgTypes NoMsgTypes
    {
        get
        {
            NoMsgTypes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoMsgTypes val) { NoMsgTypes = val; }
    public NoMsgTypes Get(NoMsgTypes val) { GetField(val); return val; }
    public bool IsSet(NoMsgTypes val) { return IsSetNoMsgTypes(); }
    public bool IsSetNoMsgTypes() { return IsSetField(Tags.NoMsgTypes); }

    public TestMessageIndicator TestMessageIndicator
    {
        get
        {
            TestMessageIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TestMessageIndicator val) { TestMessageIndicator = val; }
    public TestMessageIndicator Get(TestMessageIndicator val) { GetField(val); return val; }
    public bool IsSet(TestMessageIndicator val) { return IsSetTestMessageIndicator(); }
    public bool IsSetTestMessageIndicator() { return IsSetField(Tags.TestMessageIndicator); }

    public Username Username
    {
        get
        {
            Username val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Username val) { Username = val; }
    public Username Get(Username val) { GetField(val); return val; }
    public bool IsSet(Username val) { return IsSetUsername(); }
    public bool IsSetUsername() { return IsSetField(Tags.Username); }

    public Password Password
    {
        get
        {
            Password val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Password val) { Password = val; }
    public Password Get(Password val) { GetField(val); return val; }
    public bool IsSet(Password val) { return IsSetPassword(); }
    public bool IsSetPassword() { return IsSetField(Tags.Password); }

    public FIXEngineName FIXEngineName
    {
        get
        {
            FIXEngineName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FIXEngineName val) { FIXEngineName = val; }
    public FIXEngineName Get(FIXEngineName val) { GetField(val); return val; }
    public bool IsSet(FIXEngineName val) { return IsSetFIXEngineName(); }
    public bool IsSetFIXEngineName() { return IsSetField(Tags.FIXEngineName); }

    public FIXEngineVersion FIXEngineVersion
    {
        get
        {
            FIXEngineVersion val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FIXEngineVersion val) { FIXEngineVersion = val; }
    public FIXEngineVersion Get(FIXEngineVersion val) { GetField(val); return val; }
    public bool IsSet(FIXEngineVersion val) { return IsSetFIXEngineVersion(); }
    public bool IsSetFIXEngineVersion() { return IsSetField(Tags.FIXEngineVersion); }

    public FIXEngineVendor FIXEngineVendor
    {
        get
        {
            FIXEngineVendor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FIXEngineVendor val) { FIXEngineVendor = val; }
    public FIXEngineVendor Get(FIXEngineVendor val) { GetField(val); return val; }
    public bool IsSet(FIXEngineVendor val) { return IsSetFIXEngineVendor(); }
    public bool IsSetFIXEngineVendor() { return IsSetField(Tags.FIXEngineVendor); }

    public ApplicationSystemName ApplicationSystemName
    {
        get
        {
            ApplicationSystemName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplicationSystemName val) { ApplicationSystemName = val; }
    public ApplicationSystemName Get(ApplicationSystemName val) { GetField(val); return val; }
    public bool IsSet(ApplicationSystemName val) { return IsSetApplicationSystemName(); }
    public bool IsSetApplicationSystemName() { return IsSetField(Tags.ApplicationSystemName); }

    public ApplicationSystemVersion ApplicationSystemVersion
    {
        get
        {
            ApplicationSystemVersion val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplicationSystemVersion val) { ApplicationSystemVersion = val; }
    public ApplicationSystemVersion Get(ApplicationSystemVersion val) { GetField(val); return val; }
    public bool IsSet(ApplicationSystemVersion val) { return IsSetApplicationSystemVersion(); }
    public bool IsSetApplicationSystemVersion() { return IsSetField(Tags.ApplicationSystemVersion); }

    public ApplicationSystemVendor ApplicationSystemVendor
    {
        get
        {
            ApplicationSystemVendor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplicationSystemVendor val) { ApplicationSystemVendor = val; }
    public ApplicationSystemVendor Get(ApplicationSystemVendor val) { GetField(val); return val; }
    public bool IsSet(ApplicationSystemVendor val) { return IsSetApplicationSystemVendor(); }
    public bool IsSetApplicationSystemVendor() { return IsSetField(Tags.ApplicationSystemVendor); }

    public class NoMsgTypesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RefMsgType, Tags.MsgDirection, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.RefMsgType, Tags.MsgDirection, 0};

        public NoMsgTypesGroup()
          : base(Tags.NoMsgTypes, Tags.RefMsgType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoMsgTypesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public MsgDirection MsgDirection
        {
            get
            {
                MsgDirection val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MsgDirection val) { MsgDirection = val; }
        public MsgDirection Get(MsgDirection val) { GetField(val); return val; }
        public bool IsSet(MsgDirection val) { return IsSetMsgDirection(); }
        public bool IsSetMsgDirection() { return IsSetField(Tags.MsgDirection); }
    }
}
