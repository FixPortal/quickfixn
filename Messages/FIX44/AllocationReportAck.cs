// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class AllocationReportAck : Message
{
    public const string MsgType = "AT";

    public AllocationReportAck() : base()
    {
        Header.SetField(new MsgType("AT"));
    }

    public AllocationReportAck(
            AllocReportID aAllocReportID,
            AllocID aAllocID,
            TransactTime aTransactTime,
            AllocStatus aAllocStatus
        ) : this()
    {
        AllocReportID = aAllocReportID;
        AllocID = aAllocID;
        TransactTime = aTransactTime;
        AllocStatus = aAllocStatus;
    }

    public AllocReportID AllocReportID
    {
        get
        {
            AllocReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocReportID val) { AllocReportID = val; }
    public AllocReportID Get(AllocReportID val) { GetField(val); return val; }
    public bool IsSet(AllocReportID val) { return IsSetAllocReportID(); }
    public bool IsSetAllocReportID() { return IsSetField(Tags.AllocReportID); }

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
