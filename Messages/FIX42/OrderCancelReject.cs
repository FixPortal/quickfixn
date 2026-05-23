// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class OrderCancelReject : Message
{
    public const string MsgType = "9";

    public OrderCancelReject() : base()
    {
        Header.SetField(new MsgType("9"));
    }

    public OrderCancelReject(
            OrderID aOrderID,
            ClOrdID aClOrdID,
            OrigClOrdID aOrigClOrdID,
            OrdStatus aOrdStatus,
            CxlRejResponseTo aCxlRejResponseTo
        ) : this()
    {
        OrderID = aOrderID;
        ClOrdID = aClOrdID;
        OrigClOrdID = aOrigClOrdID;
        OrdStatus = aOrdStatus;
        CxlRejResponseTo = aCxlRejResponseTo;
    }

    public OrderID OrderID
    {
        get
        {
            OrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderID val) { OrderID = val; }
    public OrderID Get(OrderID val) { GetField(val); return val; }
    public bool IsSet(OrderID val) { return IsSetOrderID(); }
    public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

    public SecondaryOrderID SecondaryOrderID
    {
        get
        {
            SecondaryOrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryOrderID val) { SecondaryOrderID = val; }
    public SecondaryOrderID Get(SecondaryOrderID val) { GetField(val); return val; }
    public bool IsSet(SecondaryOrderID val) { return IsSetSecondaryOrderID(); }
    public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }

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

    public OrigClOrdID OrigClOrdID
    {
        get
        {
            OrigClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigClOrdID val) { OrigClOrdID = val; }
    public OrigClOrdID Get(OrigClOrdID val) { GetField(val); return val; }
    public bool IsSet(OrigClOrdID val) { return IsSetOrigClOrdID(); }
    public bool IsSetOrigClOrdID() { return IsSetField(Tags.OrigClOrdID); }

    public OrdStatus OrdStatus
    {
        get
        {
            OrdStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdStatus val) { OrdStatus = val; }
    public OrdStatus Get(OrdStatus val) { GetField(val); return val; }
    public bool IsSet(OrdStatus val) { return IsSetOrdStatus(); }
    public bool IsSetOrdStatus() { return IsSetField(Tags.OrdStatus); }

    public ClientID ClientID
    {
        get
        {
            ClientID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientID val) { ClientID = val; }
    public ClientID Get(ClientID val) { GetField(val); return val; }
    public bool IsSet(ClientID val) { return IsSetClientID(); }
    public bool IsSetClientID() { return IsSetField(Tags.ClientID); }

    public ExecBroker ExecBroker
    {
        get
        {
            ExecBroker val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecBroker val) { ExecBroker = val; }
    public ExecBroker Get(ExecBroker val) { GetField(val); return val; }
    public bool IsSet(ExecBroker val) { return IsSetExecBroker(); }
    public bool IsSetExecBroker() { return IsSetField(Tags.ExecBroker); }

    public LocateBroker LocateBroker
    {
        get
        {
            LocateBroker val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LocateBroker val) { LocateBroker = val; }
    public LocateBroker Get(LocateBroker val) { GetField(val); return val; }
    public bool IsSet(LocateBroker val) { return IsSetLocateBroker(); }
    public bool IsSetLocateBroker() { return IsSetField(Tags.LocateBroker); }

    public LocateIdentifier LocateIdentifier
    {
        get
        {
            LocateIdentifier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LocateIdentifier val) { LocateIdentifier = val; }
    public LocateIdentifier Get(LocateIdentifier val) { GetField(val); return val; }
    public bool IsSet(LocateIdentifier val) { return IsSetLocateIdentifier(); }
    public bool IsSetLocateIdentifier() { return IsSetField(Tags.LocateIdentifier); }

    public ListID ListID
    {
        get
        {
            ListID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListID val) { ListID = val; }
    public ListID Get(ListID val) { GetField(val); return val; }
    public bool IsSet(ListID val) { return IsSetListID(); }
    public bool IsSetListID() { return IsSetField(Tags.ListID); }

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

    public CxlRejResponseTo CxlRejResponseTo
    {
        get
        {
            CxlRejResponseTo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CxlRejResponseTo val) { CxlRejResponseTo = val; }
    public CxlRejResponseTo Get(CxlRejResponseTo val) { GetField(val); return val; }
    public bool IsSet(CxlRejResponseTo val) { return IsSetCxlRejResponseTo(); }
    public bool IsSetCxlRejResponseTo() { return IsSetField(Tags.CxlRejResponseTo); }

    public CxlRejReason CxlRejReason
    {
        get
        {
            CxlRejReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CxlRejReason val) { CxlRejReason = val; }
    public CxlRejReason Get(CxlRejReason val) { GetField(val); return val; }
    public bool IsSet(CxlRejReason val) { return IsSetCxlRejReason(); }
    public bool IsSetCxlRejReason() { return IsSetField(Tags.CxlRejReason); }

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

    public CumQty CumQty
    {
        get
        {
            CumQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CumQty val) { CumQty = val; }
    public CumQty Get(CumQty val) { GetField(val); return val; }
    public bool IsSet(CumQty val) { return IsSetCumQty(); }
    public bool IsSetCumQty() { return IsSetField(Tags.CumQty); }

    public ExecID ExecID
    {
        get
        {
            ExecID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecID val) { ExecID = val; }
    public ExecID Get(ExecID val) { GetField(val); return val; }
    public bool IsSet(ExecID val) { return IsSetExecID(); }
    public bool IsSetExecID() { return IsSetField(Tags.ExecID); }

    public Currency Currency
    {
        get
        {
            Currency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Currency val) { Currency = val; }
    public Currency Get(Currency val) { GetField(val); return val; }
    public bool IsSet(Currency val) { return IsSetCurrency(); }
    public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

    public HandlInst HandlInst
    {
        get
        {
            HandlInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HandlInst val) { HandlInst = val; }
    public HandlInst Get(HandlInst val) { GetField(val); return val; }
    public bool IsSet(HandlInst val) { return IsSetHandlInst(); }
    public bool IsSetHandlInst() { return IsSetField(Tags.HandlInst); }

    public IDSource IDSource
    {
        get
        {
            IDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IDSource val) { IDSource = val; }
    public IDSource Get(IDSource val) { GetField(val); return val; }
    public bool IsSet(IDSource val) { return IsSetIDSource(); }
    public bool IsSetIDSource() { return IsSetField(Tags.IDSource); }

    public Side Side
    {
        get
        {
            Side val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Side val) { Side = val; }
    public Side Get(Side val) { GetField(val); return val; }
    public bool IsSet(Side val) { return IsSetSide(); }
    public bool IsSetSide() { return IsSetField(Tags.Side); }

    public TimeInForce TimeInForce
    {
        get
        {
            TimeInForce val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TimeInForce val) { TimeInForce = val; }
    public TimeInForce Get(TimeInForce val) { GetField(val); return val; }
    public bool IsSet(TimeInForce val) { return IsSetTimeInForce(); }
    public bool IsSetTimeInForce() { return IsSetField(Tags.TimeInForce); }

    public SettlmntTyp SettlmntTyp
    {
        get
        {
            SettlmntTyp val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlmntTyp val) { SettlmntTyp = val; }
    public SettlmntTyp Get(SettlmntTyp val) { GetField(val); return val; }
    public bool IsSet(SettlmntTyp val) { return IsSetSettlmntTyp(); }
    public bool IsSetSettlmntTyp() { return IsSetField(Tags.SettlmntTyp); }

    public FutSettDate FutSettDate
    {
        get
        {
            FutSettDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FutSettDate val) { FutSettDate = val; }
    public FutSettDate Get(FutSettDate val) { GetField(val); return val; }
    public bool IsSet(FutSettDate val) { return IsSetFutSettDate(); }
    public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

    public SecurityExchange SecurityExchange
    {
        get
        {
            SecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityExchange val) { SecurityExchange = val; }
    public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
    public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
    public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

    public NOE NOE
    {
        get
        {
            NOE val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NOE val) { NOE = val; }
    public NOE Get(NOE val) { GetField(val); return val; }
    public bool IsSet(NOE val) { return IsSetNOE(); }
    public bool IsSetNOE() { return IsSetField(Tags.NOE); }

    public ClearingFirm ClearingFirm
    {
        get
        {
            ClearingFirm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClearingFirm val) { ClearingFirm = val; }
    public ClearingFirm Get(ClearingFirm val) { GetField(val); return val; }
    public bool IsSet(ClearingFirm val) { return IsSetClearingFirm(); }
    public bool IsSetClearingFirm() { return IsSetField(Tags.ClearingFirm); }

    public SettlCurrency SettlCurrency
    {
        get
        {
            SettlCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrency val) { SettlCurrency = val; }
    public SettlCurrency Get(SettlCurrency val) { GetField(val); return val; }
    public bool IsSet(SettlCurrency val) { return IsSetSettlCurrency(); }
    public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }

    public LeavesQty LeavesQty
    {
        get
        {
            LeavesQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LeavesQty val) { LeavesQty = val; }
    public LeavesQty Get(LeavesQty val) { GetField(val); return val; }
    public bool IsSet(LeavesQty val) { return IsSetLeavesQty(); }
    public bool IsSetLeavesQty() { return IsSetField(Tags.LeavesQty); }

    public SecurityType SecurityType
    {
        get
        {
            SecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityType val) { SecurityType = val; }
    public SecurityType Get(SecurityType val) { GetField(val); return val; }
    public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
    public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

    public StrikePrice StrikePrice
    {
        get
        {
            StrikePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePrice val) { StrikePrice = val; }
    public StrikePrice Get(StrikePrice val) { GetField(val); return val; }
    public bool IsSet(StrikePrice val) { return IsSetStrikePrice(); }
    public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

    public ExpireDate ExpireDate
    {
        get
        {
            ExpireDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExpireDate val) { ExpireDate = val; }
    public ExpireDate Get(ExpireDate val) { GetField(val); return val; }
    public bool IsSet(ExpireDate val) { return IsSetExpireDate(); }
    public bool IsSetExpireDate() { return IsSetField(Tags.ExpireDate); }

    public ExpireTime ExpireTime
    {
        get
        {
            ExpireTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExpireTime val) { ExpireTime = val; }
    public ExpireTime Get(ExpireTime val) { GetField(val); return val; }
    public bool IsSet(ExpireTime val) { return IsSetExpireTime(); }
    public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

    public OrderQty OrderQty
    {
        get
        {
            OrderQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderQty val) { OrderQty = val; }
    public OrderQty Get(OrderQty val) { GetField(val); return val; }
    public bool IsSet(OrderQty val) { return IsSetOrderQty(); }
    public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }
}
