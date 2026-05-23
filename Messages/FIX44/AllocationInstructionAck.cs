// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class AllocationInstructionAck : Message
{
    public const string MsgType = "P";

    public AllocationInstructionAck() : base()
    {
        Header.SetField(new MsgType("P"));
    }

    public AllocationInstructionAck(
            AllocID aAllocID,
            TransactTime aTransactTime,
            AllocStatus aAllocStatus
        ) : this()
    {
        AllocID = aAllocID;
        TransactTime = aTransactTime;
        AllocStatus = aAllocStatus;
    }

    public AllocID AllocID
    {
        get
        {
            AllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocID val) { AllocID = val; }
    public AllocID Get(AllocID val) { GetField(val); return val; }
    public bool IsSet(AllocID val) { return IsSetAllocID(); }
    public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

    public SecondaryAllocID SecondaryAllocID
    {
        get
        {
            SecondaryAllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryAllocID val) { SecondaryAllocID = val; }
    public SecondaryAllocID Get(SecondaryAllocID val) { GetField(val); return val; }
    public bool IsSet(SecondaryAllocID val) { return IsSetSecondaryAllocID(); }
    public bool IsSetSecondaryAllocID() { return IsSetField(Tags.SecondaryAllocID); }

    public TradeDate TradeDate
    {
        get
        {
            TradeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeDate val) { TradeDate = val; }
    public TradeDate Get(TradeDate val) { GetField(val); return val; }
    public bool IsSet(TradeDate val) { return IsSetTradeDate(); }
    public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public AllocStatus AllocStatus
    {
        get
        {
            AllocStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocStatus val) { AllocStatus = val; }
    public AllocStatus Get(AllocStatus val) { GetField(val); return val; }
    public bool IsSet(AllocStatus val) { return IsSetAllocStatus(); }
    public bool IsSetAllocStatus() { return IsSetField(Tags.AllocStatus); }

    public AllocRejCode AllocRejCode
    {
        get
        {
            AllocRejCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocRejCode val) { AllocRejCode = val; }
    public AllocRejCode Get(AllocRejCode val) { GetField(val); return val; }
    public bool IsSet(AllocRejCode val) { return IsSetAllocRejCode(); }
    public bool IsSetAllocRejCode() { return IsSetField(Tags.AllocRejCode); }

    public AllocType AllocType
    {
        get
        {
            AllocType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocType val) { AllocType = val; }
    public AllocType Get(AllocType val) { GetField(val); return val; }
    public bool IsSet(AllocType val) { return IsSetAllocType(); }
    public bool IsSetAllocType() { return IsSetField(Tags.AllocType); }

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

    public TradingSystemTicketNumber TradingSystemTicketNumber
    {
        get
        {
            TradingSystemTicketNumber val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSystemTicketNumber val) { TradingSystemTicketNumber = val; }
    public TradingSystemTicketNumber Get(TradingSystemTicketNumber val) { GetField(val); return val; }
    public bool IsSet(TradingSystemTicketNumber val) { return IsSetTradingSystemTicketNumber(); }
    public bool IsSetTradingSystemTicketNumber() { return IsSetField(Tags.TradingSystemTicketNumber); }

    public ContactEmailAddress ContactEmailAddress
    {
        get
        {
            ContactEmailAddress val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ContactEmailAddress val) { ContactEmailAddress = val; }
    public ContactEmailAddress Get(ContactEmailAddress val) { GetField(val); return val; }
    public bool IsSet(ContactEmailAddress val) { return IsSetContactEmailAddress(); }
    public bool IsSetContactEmailAddress() { return IsSetField(Tags.ContactEmailAddress); }

    public BLOTSequenceNumber BLOTSequenceNumber
    {
        get
        {
            BLOTSequenceNumber val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BLOTSequenceNumber val) { BLOTSequenceNumber = val; }
    public BLOTSequenceNumber Get(BLOTSequenceNumber val) { GetField(val); return val; }
    public bool IsSet(BLOTSequenceNumber val) { return IsSetBLOTSequenceNumber(); }
    public bool IsSetBLOTSequenceNumber() { return IsSetField(Tags.BLOTSequenceNumber); }
}
