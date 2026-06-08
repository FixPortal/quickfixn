// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class ExecutionReport : Message
{
    public const string MsgType = "8";

    public ExecutionReport() : base()
    {
        Header.SetField(new MsgType("8"));
    }

    public ExecutionReport(
            OrderID aOrderID,
            ExecID aExecID,
            ExecTransType aExecTransType,
            ExecType aExecType,
            OrdStatus aOrdStatus,
            Symbol aSymbol,
            Side aSide,
            LeavesQty aLeavesQty,
            CumQty aCumQty,
            AvgPx aAvgPx
        ) : this()
    {
        OrderID = aOrderID;
        ExecID = aExecID;
        ExecTransType = aExecTransType;
        ExecType = aExecType;
        OrdStatus = aOrdStatus;
        Symbol = aSymbol;
        Side = aSide;
        LeavesQty = aLeavesQty;
        CumQty = aCumQty;
        AvgPx = aAvgPx;
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

    public SecondaryExecID SecondaryExecID
    {
        get
        {
            SecondaryExecID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryExecID val) { SecondaryExecID = val; }
    public SecondaryExecID Get(SecondaryExecID val) { GetField(val); return val; }
    public bool IsSet(SecondaryExecID val) { return IsSetSecondaryExecID(); }
    public bool IsSetSecondaryExecID() { return IsSetField(Tags.SecondaryExecID); }

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

    public NoContraBrokers NoContraBrokers
    {
        get
        {
            NoContraBrokers val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoContraBrokers val) { NoContraBrokers = val; }
    public NoContraBrokers Get(NoContraBrokers val) { GetField(val); return val; }
    public bool IsSet(NoContraBrokers val) { return IsSetNoContraBrokers(); }
    public bool IsSetNoContraBrokers() { return IsSetField(Tags.NoContraBrokers); }

    public NoLegs NoLegs
    {
        get
        {
            NoLegs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoLegs val) { NoLegs = val; }
    public NoLegs Get(NoLegs val) { GetField(val); return val; }
    public bool IsSet(NoLegs val) { return IsSetNoLegs(); }
    public bool IsSetNoLegs() { return IsSetField(Tags.NoLegs); }

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

    public ExecTransType ExecTransType
    {
        get
        {
            ExecTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecTransType val) { ExecTransType = val; }
    public ExecTransType Get(ExecTransType val) { GetField(val); return val; }
    public bool IsSet(ExecTransType val) { return IsSetExecTransType(); }
    public bool IsSetExecTransType() { return IsSetField(Tags.ExecTransType); }

    public ExecRefID ExecRefID
    {
        get
        {
            ExecRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecRefID val) { ExecRefID = val; }
    public ExecRefID Get(ExecRefID val) { GetField(val); return val; }
    public bool IsSet(ExecRefID val) { return IsSetExecRefID(); }
    public bool IsSetExecRefID() { return IsSetField(Tags.ExecRefID); }

    public ExecType ExecType
    {
        get
        {
            ExecType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecType val) { ExecType = val; }
    public ExecType Get(ExecType val) { GetField(val); return val; }
    public bool IsSet(ExecType val) { return IsSetExecType(); }
    public bool IsSetExecType() { return IsSetField(Tags.ExecType); }

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

    public OrdRejReason OrdRejReason
    {
        get
        {
            OrdRejReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdRejReason val) { OrdRejReason = val; }
    public OrdRejReason Get(OrdRejReason val) { GetField(val); return val; }
    public bool IsSet(OrdRejReason val) { return IsSetOrdRejReason(); }
    public bool IsSetOrdRejReason() { return IsSetField(Tags.OrdRejReason); }

    public ExecRestatementReason ExecRestatementReason
    {
        get
        {
            ExecRestatementReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecRestatementReason val) { ExecRestatementReason = val; }
    public ExecRestatementReason Get(ExecRestatementReason val) { GetField(val); return val; }
    public bool IsSet(ExecRestatementReason val) { return IsSetExecRestatementReason(); }
    public bool IsSetExecRestatementReason() { return IsSetField(Tags.ExecRestatementReason); }

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

    public Symbol Symbol
    {
        get
        {
            Symbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Symbol val) { Symbol = val; }
    public Symbol Get(Symbol val) { GetField(val); return val; }
    public bool IsSet(Symbol val) { return IsSetSymbol(); }
    public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

    public SymbolSfx SymbolSfx
    {
        get
        {
            SymbolSfx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SymbolSfx val) { SymbolSfx = val; }
    public SymbolSfx Get(SymbolSfx val) { GetField(val); return val; }
    public bool IsSet(SymbolSfx val) { return IsSetSymbolSfx(); }
    public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

    public SecurityID SecurityID
    {
        get
        {
            SecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityID val) { SecurityID = val; }
    public SecurityID Get(SecurityID val) { GetField(val); return val; }
    public bool IsSet(SecurityID val) { return IsSetSecurityID(); }
    public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

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

    public MaturityMonthYear MaturityMonthYear
    {
        get
        {
            MaturityMonthYear val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityMonthYear val) { MaturityMonthYear = val; }
    public MaturityMonthYear Get(MaturityMonthYear val) { GetField(val); return val; }
    public bool IsSet(MaturityMonthYear val) { return IsSetMaturityMonthYear(); }
    public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

    public MaturityDay MaturityDay
    {
        get
        {
            MaturityDay val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityDay val) { MaturityDay = val; }
    public MaturityDay Get(MaturityDay val) { GetField(val); return val; }
    public bool IsSet(MaturityDay val) { return IsSetMaturityDay(); }
    public bool IsSetMaturityDay() { return IsSetField(Tags.MaturityDay); }

    public PutOrCall PutOrCall
    {
        get
        {
            PutOrCall val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PutOrCall val) { PutOrCall = val; }
    public PutOrCall Get(PutOrCall val) { GetField(val); return val; }
    public bool IsSet(PutOrCall val) { return IsSetPutOrCall(); }
    public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }

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

    public OptAttribute OptAttribute
    {
        get
        {
            OptAttribute val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptAttribute val) { OptAttribute = val; }
    public OptAttribute Get(OptAttribute val) { GetField(val); return val; }
    public bool IsSet(OptAttribute val) { return IsSetOptAttribute(); }
    public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

    public ContractMultiplier ContractMultiplier
    {
        get
        {
            ContractMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ContractMultiplier val) { ContractMultiplier = val; }
    public ContractMultiplier Get(ContractMultiplier val) { GetField(val); return val; }
    public bool IsSet(ContractMultiplier val) { return IsSetContractMultiplier(); }
    public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }

    public CouponRate CouponRate
    {
        get
        {
            CouponRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponRate val) { CouponRate = val; }
    public CouponRate Get(CouponRate val) { GetField(val); return val; }
    public bool IsSet(CouponRate val) { return IsSetCouponRate(); }
    public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }

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

    public Issuer Issuer
    {
        get
        {
            Issuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Issuer val) { Issuer = val; }
    public Issuer Get(Issuer val) { GetField(val); return val; }
    public bool IsSet(Issuer val) { return IsSetIssuer(); }
    public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

    public EncodedIssuerLen EncodedIssuerLen
    {
        get
        {
            EncodedIssuerLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedIssuerLen val) { EncodedIssuerLen = val; }
    public EncodedIssuerLen Get(EncodedIssuerLen val) { GetField(val); return val; }
    public bool IsSet(EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }
    public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }

    public EncodedIssuer EncodedIssuer
    {
        get
        {
            EncodedIssuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedIssuer val) { EncodedIssuer = val; }
    public EncodedIssuer Get(EncodedIssuer val) { GetField(val); return val; }
    public bool IsSet(EncodedIssuer val) { return IsSetEncodedIssuer(); }
    public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }

    public SecurityDesc SecurityDesc
    {
        get
        {
            SecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityDesc val) { SecurityDesc = val; }
    public SecurityDesc Get(SecurityDesc val) { GetField(val); return val; }
    public bool IsSet(SecurityDesc val) { return IsSetSecurityDesc(); }
    public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

    public EncodedSecurityDescLen EncodedSecurityDescLen
    {
        get
        {
            EncodedSecurityDescLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedSecurityDescLen val) { EncodedSecurityDescLen = val; }
    public EncodedSecurityDescLen Get(EncodedSecurityDescLen val) { GetField(val); return val; }
    public bool IsSet(EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }
    public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }

    public EncodedSecurityDesc EncodedSecurityDesc
    {
        get
        {
            EncodedSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedSecurityDesc val) { EncodedSecurityDesc = val; }
    public EncodedSecurityDesc Get(EncodedSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }
    public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }

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

    public CashOrderQty CashOrderQty
    {
        get
        {
            CashOrderQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashOrderQty val) { CashOrderQty = val; }
    public CashOrderQty Get(CashOrderQty val) { GetField(val); return val; }
    public bool IsSet(CashOrderQty val) { return IsSetCashOrderQty(); }
    public bool IsSetCashOrderQty() { return IsSetField(Tags.CashOrderQty); }

    public OrdType OrdType
    {
        get
        {
            OrdType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdType val) { OrdType = val; }
    public OrdType Get(OrdType val) { GetField(val); return val; }
    public bool IsSet(OrdType val) { return IsSetOrdType(); }
    public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }

    public Price Price
    {
        get
        {
            Price val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Price val) { Price = val; }
    public Price Get(Price val) { GetField(val); return val; }
    public bool IsSet(Price val) { return IsSetPrice(); }
    public bool IsSetPrice() { return IsSetField(Tags.Price); }

    public StopPx StopPx
    {
        get
        {
            StopPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StopPx val) { StopPx = val; }
    public StopPx Get(StopPx val) { GetField(val); return val; }
    public bool IsSet(StopPx val) { return IsSetStopPx(); }
    public bool IsSetStopPx() { return IsSetField(Tags.StopPx); }

    public PegDifference PegDifference
    {
        get
        {
            PegDifference val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegDifference val) { PegDifference = val; }
    public PegDifference Get(PegDifference val) { GetField(val); return val; }
    public bool IsSet(PegDifference val) { return IsSetPegDifference(); }
    public bool IsSetPegDifference() { return IsSetField(Tags.PegDifference); }

    public DiscretionInst DiscretionInst
    {
        get
        {
            DiscretionInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionInst val) { DiscretionInst = val; }
    public DiscretionInst Get(DiscretionInst val) { GetField(val); return val; }
    public bool IsSet(DiscretionInst val) { return IsSetDiscretionInst(); }
    public bool IsSetDiscretionInst() { return IsSetField(Tags.DiscretionInst); }

    public DiscretionOffset DiscretionOffset
    {
        get
        {
            DiscretionOffset val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionOffset val) { DiscretionOffset = val; }
    public DiscretionOffset Get(DiscretionOffset val) { GetField(val); return val; }
    public bool IsSet(DiscretionOffset val) { return IsSetDiscretionOffset(); }
    public bool IsSetDiscretionOffset() { return IsSetField(Tags.DiscretionOffset); }

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

    public ComplianceID ComplianceID
    {
        get
        {
            ComplianceID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ComplianceID val) { ComplianceID = val; }
    public ComplianceID Get(ComplianceID val) { GetField(val); return val; }
    public bool IsSet(ComplianceID val) { return IsSetComplianceID(); }
    public bool IsSetComplianceID() { return IsSetField(Tags.ComplianceID); }

    public SolicitedFlag SolicitedFlag
    {
        get
        {
            SolicitedFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SolicitedFlag val) { SolicitedFlag = val; }
    public SolicitedFlag Get(SolicitedFlag val) { GetField(val); return val; }
    public bool IsSet(SolicitedFlag val) { return IsSetSolicitedFlag(); }
    public bool IsSetSolicitedFlag() { return IsSetField(Tags.SolicitedFlag); }

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

    public EffectiveTime EffectiveTime
    {
        get
        {
            EffectiveTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EffectiveTime val) { EffectiveTime = val; }
    public EffectiveTime Get(EffectiveTime val) { GetField(val); return val; }
    public bool IsSet(EffectiveTime val) { return IsSetEffectiveTime(); }
    public bool IsSetEffectiveTime() { return IsSetField(Tags.EffectiveTime); }

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

    public ExecInst ExecInst
    {
        get
        {
            ExecInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecInst val) { ExecInst = val; }
    public ExecInst Get(ExecInst val) { GetField(val); return val; }
    public bool IsSet(ExecInst val) { return IsSetExecInst(); }
    public bool IsSetExecInst() { return IsSetField(Tags.ExecInst); }

    public Rule80A Rule80A
    {
        get
        {
            Rule80A val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Rule80A val) { Rule80A = val; }
    public Rule80A Get(Rule80A val) { GetField(val); return val; }
    public bool IsSet(Rule80A val) { return IsSetRule80A(); }
    public bool IsSetRule80A() { return IsSetField(Tags.Rule80A); }

    public LastShares LastShares
    {
        get
        {
            LastShares val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastShares val) { LastShares = val; }
    public LastShares Get(LastShares val) { GetField(val); return val; }
    public bool IsSet(LastShares val) { return IsSetLastShares(); }
    public bool IsSetLastShares() { return IsSetField(Tags.LastShares); }

    public LastPx LastPx
    {
        get
        {
            LastPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastPx val) { LastPx = val; }
    public LastPx Get(LastPx val) { GetField(val); return val; }
    public bool IsSet(LastPx val) { return IsSetLastPx(); }
    public bool IsSetLastPx() { return IsSetField(Tags.LastPx); }

    public LastSpotRate LastSpotRate
    {
        get
        {
            LastSpotRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastSpotRate val) { LastSpotRate = val; }
    public LastSpotRate Get(LastSpotRate val) { GetField(val); return val; }
    public bool IsSet(LastSpotRate val) { return IsSetLastSpotRate(); }
    public bool IsSetLastSpotRate() { return IsSetField(Tags.LastSpotRate); }

    public LastForwardPoints LastForwardPoints
    {
        get
        {
            LastForwardPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastForwardPoints val) { LastForwardPoints = val; }
    public LastForwardPoints Get(LastForwardPoints val) { GetField(val); return val; }
    public bool IsSet(LastForwardPoints val) { return IsSetLastForwardPoints(); }
    public bool IsSetLastForwardPoints() { return IsSetField(Tags.LastForwardPoints); }

    public LastMkt LastMkt
    {
        get
        {
            LastMkt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastMkt val) { LastMkt = val; }
    public LastMkt Get(LastMkt val) { GetField(val); return val; }
    public bool IsSet(LastMkt val) { return IsSetLastMkt(); }
    public bool IsSetLastMkt() { return IsSetField(Tags.LastMkt); }

    public TradingSessionID TradingSessionID
    {
        get
        {
            TradingSessionID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSessionID val) { TradingSessionID = val; }
    public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
    public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
    public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

    public LastCapacity LastCapacity
    {
        get
        {
            LastCapacity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastCapacity val) { LastCapacity = val; }
    public LastCapacity Get(LastCapacity val) { GetField(val); return val; }
    public bool IsSet(LastCapacity val) { return IsSetLastCapacity(); }
    public bool IsSetLastCapacity() { return IsSetField(Tags.LastCapacity); }

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

    public AvgPx AvgPx
    {
        get
        {
            AvgPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgPx val) { AvgPx = val; }
    public AvgPx Get(AvgPx val) { GetField(val); return val; }
    public bool IsSet(AvgPx val) { return IsSetAvgPx(); }
    public bool IsSetAvgPx() { return IsSetField(Tags.AvgPx); }

    public DayOrderQty DayOrderQty
    {
        get
        {
            DayOrderQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayOrderQty val) { DayOrderQty = val; }
    public DayOrderQty Get(DayOrderQty val) { GetField(val); return val; }
    public bool IsSet(DayOrderQty val) { return IsSetDayOrderQty(); }
    public bool IsSetDayOrderQty() { return IsSetField(Tags.DayOrderQty); }

    public DayCumQty DayCumQty
    {
        get
        {
            DayCumQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayCumQty val) { DayCumQty = val; }
    public DayCumQty Get(DayCumQty val) { GetField(val); return val; }
    public bool IsSet(DayCumQty val) { return IsSetDayCumQty(); }
    public bool IsSetDayCumQty() { return IsSetField(Tags.DayCumQty); }

    public DayAvgPx DayAvgPx
    {
        get
        {
            DayAvgPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayAvgPx val) { DayAvgPx = val; }
    public DayAvgPx Get(DayAvgPx val) { GetField(val); return val; }
    public bool IsSet(DayAvgPx val) { return IsSetDayAvgPx(); }
    public bool IsSetDayAvgPx() { return IsSetField(Tags.DayAvgPx); }

    public GTBookingInst GTBookingInst
    {
        get
        {
            GTBookingInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(GTBookingInst val) { GTBookingInst = val; }
    public GTBookingInst Get(GTBookingInst val) { GetField(val); return val; }
    public bool IsSet(GTBookingInst val) { return IsSetGTBookingInst(); }
    public bool IsSetGTBookingInst() { return IsSetField(Tags.GTBookingInst); }

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

    public ValidUntilTime ValidUntilTime
    {
        get
        {
            ValidUntilTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ValidUntilTime val) { ValidUntilTime = val; }
    public ValidUntilTime Get(ValidUntilTime val) { GetField(val); return val; }
    public bool IsSet(ValidUntilTime val) { return IsSetValidUntilTime(); }
    public bool IsSetValidUntilTime() { return IsSetField(Tags.ValidUntilTime); }

    public ReportToExch ReportToExch
    {
        get
        {
            ReportToExch val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ReportToExch val) { ReportToExch = val; }
    public ReportToExch Get(ReportToExch val) { GetField(val); return val; }
    public bool IsSet(ReportToExch val) { return IsSetReportToExch(); }
    public bool IsSetReportToExch() { return IsSetField(Tags.ReportToExch); }

    public Commission Commission
    {
        get
        {
            Commission val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Commission val) { Commission = val; }
    public Commission Get(Commission val) { GetField(val); return val; }
    public bool IsSet(Commission val) { return IsSetCommission(); }
    public bool IsSetCommission() { return IsSetField(Tags.Commission); }

    public CommType CommType
    {
        get
        {
            CommType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CommType val) { CommType = val; }
    public CommType Get(CommType val) { GetField(val); return val; }
    public bool IsSet(CommType val) { return IsSetCommType(); }
    public bool IsSetCommType() { return IsSetField(Tags.CommType); }

    public GrossTradeAmt GrossTradeAmt
    {
        get
        {
            GrossTradeAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(GrossTradeAmt val) { GrossTradeAmt = val; }
    public GrossTradeAmt Get(GrossTradeAmt val) { GetField(val); return val; }
    public bool IsSet(GrossTradeAmt val) { return IsSetGrossTradeAmt(); }
    public bool IsSetGrossTradeAmt() { return IsSetField(Tags.GrossTradeAmt); }

    public SettlCurrAmt SettlCurrAmt
    {
        get
        {
            SettlCurrAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrAmt val) { SettlCurrAmt = val; }
    public SettlCurrAmt Get(SettlCurrAmt val) { GetField(val); return val; }
    public bool IsSet(SettlCurrAmt val) { return IsSetSettlCurrAmt(); }
    public bool IsSetSettlCurrAmt() { return IsSetField(Tags.SettlCurrAmt); }

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

    public SettlCurrFxRate SettlCurrFxRate
    {
        get
        {
            SettlCurrFxRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrFxRate val) { SettlCurrFxRate = val; }
    public SettlCurrFxRate Get(SettlCurrFxRate val) { GetField(val); return val; }
    public bool IsSet(SettlCurrFxRate val) { return IsSetSettlCurrFxRate(); }
    public bool IsSetSettlCurrFxRate() { return IsSetField(Tags.SettlCurrFxRate); }

    public SettlCurrFxRateCalc SettlCurrFxRateCalc
    {
        get
        {
            SettlCurrFxRateCalc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrFxRateCalc val) { SettlCurrFxRateCalc = val; }
    public SettlCurrFxRateCalc Get(SettlCurrFxRateCalc val) { GetField(val); return val; }
    public bool IsSet(SettlCurrFxRateCalc val) { return IsSetSettlCurrFxRateCalc(); }
    public bool IsSetSettlCurrFxRateCalc() { return IsSetField(Tags.SettlCurrFxRateCalc); }

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

    public MinQty MinQty
    {
        get
        {
            MinQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinQty val) { MinQty = val; }
    public MinQty Get(MinQty val) { GetField(val); return val; }
    public bool IsSet(MinQty val) { return IsSetMinQty(); }
    public bool IsSetMinQty() { return IsSetField(Tags.MinQty); }

    public MaxFloor MaxFloor
    {
        get
        {
            MaxFloor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxFloor val) { MaxFloor = val; }
    public MaxFloor Get(MaxFloor val) { GetField(val); return val; }
    public bool IsSet(MaxFloor val) { return IsSetMaxFloor(); }
    public bool IsSetMaxFloor() { return IsSetField(Tags.MaxFloor); }

    public OpenClose OpenClose
    {
        get
        {
            OpenClose val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OpenClose val) { OpenClose = val; }
    public OpenClose Get(OpenClose val) { GetField(val); return val; }
    public bool IsSet(OpenClose val) { return IsSetOpenClose(); }
    public bool IsSetOpenClose() { return IsSetField(Tags.OpenClose); }

    public MaxShow MaxShow
    {
        get
        {
            MaxShow val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxShow val) { MaxShow = val; }
    public MaxShow Get(MaxShow val) { GetField(val); return val; }
    public bool IsSet(MaxShow val) { return IsSetMaxShow(); }
    public bool IsSetMaxShow() { return IsSetField(Tags.MaxShow); }

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

    public FutSettDate2 FutSettDate2
    {
        get
        {
            FutSettDate2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FutSettDate2 val) { FutSettDate2 = val; }
    public FutSettDate2 Get(FutSettDate2 val) { GetField(val); return val; }
    public bool IsSet(FutSettDate2 val) { return IsSetFutSettDate2(); }
    public bool IsSetFutSettDate2() { return IsSetField(Tags.FutSettDate2); }

    public OrderQty2 OrderQty2
    {
        get
        {
            OrderQty2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderQty2 val) { OrderQty2 = val; }
    public OrderQty2 Get(OrderQty2 val) { GetField(val); return val; }
    public bool IsSet(OrderQty2 val) { return IsSetOrderQty2(); }
    public bool IsSetOrderQty2() { return IsSetField(Tags.OrderQty2); }

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

    public ClearingAccount ClearingAccount
    {
        get
        {
            ClearingAccount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClearingAccount val) { ClearingAccount = val; }
    public ClearingAccount Get(ClearingAccount val) { GetField(val); return val; }
    public bool IsSet(ClearingAccount val) { return IsSetClearingAccount(); }
    public bool IsSetClearingAccount() { return IsSetField(Tags.ClearingAccount); }

    public MultiLegReportingType MultiLegReportingType
    {
        get
        {
            MultiLegReportingType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MultiLegReportingType val) { MultiLegReportingType = val; }
    public MultiLegReportingType Get(MultiLegReportingType val) { GetField(val); return val; }
    public bool IsSet(MultiLegReportingType val) { return IsSetMultiLegReportingType(); }
    public bool IsSetMultiLegReportingType() { return IsSetField(Tags.MultiLegReportingType); }

    public BookingType BookingType
    {
        get
        {
            BookingType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BookingType val) { BookingType = val; }
    public BookingType Get(BookingType val) { GetField(val); return val; }
    public bool IsSet(BookingType val) { return IsSetBookingType(); }
    public bool IsSetBookingType() { return IsSetField(Tags.BookingType); }

    public PriceBid PriceBid
    {
        get
        {
            PriceBid val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceBid val) { PriceBid = val; }
    public PriceBid Get(PriceBid val) { GetField(val); return val; }
    public bool IsSet(PriceBid val) { return IsSetPriceBid(); }
    public bool IsSetPriceBid() { return IsSetField(Tags.PriceBid); }

    public PriceAsk PriceAsk
    {
        get
        {
            PriceAsk val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceAsk val) { PriceAsk = val; }
    public PriceAsk Get(PriceAsk val) { GetField(val); return val; }
    public bool IsSet(PriceAsk val) { return IsSetPriceAsk(); }
    public bool IsSetPriceAsk() { return IsSetField(Tags.PriceAsk); }

    public PriceTrade PriceTrade
    {
        get
        {
            PriceTrade val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceTrade val) { PriceTrade = val; }
    public PriceTrade Get(PriceTrade val) { GetField(val); return val; }
    public bool IsSet(PriceTrade val) { return IsSetPriceTrade(); }
    public bool IsSetPriceTrade() { return IsSetField(Tags.PriceTrade); }

    public SweepStyle SweepStyle
    {
        get
        {
            SweepStyle val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SweepStyle val) { SweepStyle = val; }
    public SweepStyle Get(SweepStyle val) { GetField(val); return val; }
    public bool IsSet(SweepStyle val) { return IsSetSweepStyle(); }
    public bool IsSetSweepStyle() { return IsSetField(Tags.SweepStyle); }

    public QuoteQty QuoteQty
    {
        get
        {
            QuoteQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteQty val) { QuoteQty = val; }
    public QuoteQty Get(QuoteQty val) { GetField(val); return val; }
    public bool IsSet(QuoteQty val) { return IsSetQuoteQty(); }
    public bool IsSetQuoteQty() { return IsSetField(Tags.QuoteQty); }

    public Paused Paused
    {
        get
        {
            Paused val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Paused val) { Paused = val; }
    public Paused Get(Paused val) { GetField(val); return val; }
    public bool IsSet(Paused val) { return IsSetPaused(); }
    public bool IsSetPaused() { return IsSetField(Tags.Paused); }

    public BTOrderInst BTOrderInst
    {
        get
        {
            BTOrderInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BTOrderInst val) { BTOrderInst = val; }
    public BTOrderInst Get(BTOrderInst val) { GetField(val); return val; }
    public bool IsSet(BTOrderInst val) { return IsSetBTOrderInst(); }
    public bool IsSetBTOrderInst() { return IsSetField(Tags.BTOrderInst); }

    public BTReportInst BTReportInst
    {
        get
        {
            BTReportInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BTReportInst val) { BTReportInst = val; }
    public BTReportInst Get(BTReportInst val) { GetField(val); return val; }
    public bool IsSet(BTReportInst val) { return IsSetBTReportInst(); }
    public bool IsSetBTReportInst() { return IsSetField(Tags.BTReportInst); }

    public DealNumber DealNumber
    {
        get
        {
            DealNumber val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DealNumber val) { DealNumber = val; }
    public DealNumber Get(DealNumber val) { GetField(val); return val; }
    public bool IsSet(DealNumber val) { return IsSetDealNumber(); }
    public bool IsSetDealNumber() { return IsSetField(Tags.DealNumber); }

    public BangFlag BangFlag
    {
        get
        {
            BangFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BangFlag val) { BangFlag = val; }
    public BangFlag Get(BangFlag val) { GetField(val); return val; }
    public bool IsSet(BangFlag val) { return IsSetBangFlag(); }
    public bool IsSetBangFlag() { return IsSetField(Tags.BangFlag); }

    public BangCounterParty BangCounterParty
    {
        get
        {
            BangCounterParty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BangCounterParty val) { BangCounterParty = val; }
    public BangCounterParty Get(BangCounterParty val) { GetField(val); return val; }
    public bool IsSet(BangCounterParty val) { return IsSetBangCounterParty(); }
    public bool IsSetBangCounterParty() { return IsSetField(Tags.BangCounterParty); }

    public BangSDP BangSDP
    {
        get
        {
            BangSDP val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BangSDP val) { BangSDP = val; }
    public BangSDP Get(BangSDP val) { GetField(val); return val; }
    public bool IsSet(BangSDP val) { return IsSetBangSDP(); }
    public bool IsSetBangSDP() { return IsSetField(Tags.BangSDP); }

    public SysadminID SysadminID
    {
        get
        {
            SysadminID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SysadminID val) { SysadminID = val; }
    public SysadminID Get(SysadminID val) { GetField(val); return val; }
    public bool IsSet(SysadminID val) { return IsSetSysadminID(); }
    public bool IsSetSysadminID() { return IsSetField(Tags.SysadminID); }

    public TradeStyle TradeStyle
    {
        get
        {
            TradeStyle val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeStyle val) { TradeStyle = val; }
    public TradeStyle Get(TradeStyle val) { GetField(val); return val; }
    public bool IsSet(TradeStyle val) { return IsSetTradeStyle(); }
    public bool IsSetTradeStyle() { return IsSetField(Tags.TradeStyle); }

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

    public BidPx BidPx
    {
        get
        {
            BidPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidPx val) { BidPx = val; }
    public BidPx Get(BidPx val) { GetField(val); return val; }
    public bool IsSet(BidPx val) { return IsSetBidPx(); }
    public bool IsSetBidPx() { return IsSetField(Tags.BidPx); }

    public OfferPx OfferPx
    {
        get
        {
            OfferPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferPx val) { OfferPx = val; }
    public OfferPx Get(OfferPx val) { GetField(val); return val; }
    public bool IsSet(OfferPx val) { return IsSetOfferPx(); }
    public bool IsSetOfferPx() { return IsSetField(Tags.OfferPx); }

    public Product Product
    {
        get
        {
            Product val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Product val) { Product = val; }
    public Product Get(Product val) { GetField(val); return val; }
    public bool IsSet(Product val) { return IsSetProduct(); }
    public bool IsSetProduct() { return IsSetField(Tags.Product); }

    public UnderlyingProduct UnderlyingProduct
    {
        get
        {
            UnderlyingProduct val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingProduct val) { UnderlyingProduct = val; }
    public UnderlyingProduct Get(UnderlyingProduct val) { GetField(val); return val; }
    public bool IsSet(UnderlyingProduct val) { return IsSetUnderlyingProduct(); }
    public bool IsSetUnderlyingProduct() { return IsSetField(Tags.UnderlyingProduct); }

    public LegSecurityType LegSecurityType
    {
        get
        {
            LegSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LegSecurityType val) { LegSecurityType = val; }
    public LegSecurityType Get(LegSecurityType val) { GetField(val); return val; }
    public bool IsSet(LegSecurityType val) { return IsSetLegSecurityType(); }
    public bool IsSetLegSecurityType() { return IsSetField(Tags.LegSecurityType); }

    public ExDestination ExDestination
    {
        get
        {
            ExDestination val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExDestination val) { ExDestination = val; }
    public ExDestination Get(ExDestination val) { GetField(val); return val; }
    public bool IsSet(ExDestination val) { return IsSetExDestination(); }
    public bool IsSetExDestination() { return IsSetField(Tags.ExDestination); }

    public TriggerQuantity TriggerQuantity
    {
        get
        {
            TriggerQuantity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerQuantity val) { TriggerQuantity = val; }
    public TriggerQuantity Get(TriggerQuantity val) { GetField(val); return val; }
    public bool IsSet(TriggerQuantity val) { return IsSetTriggerQuantity(); }
    public bool IsSetTriggerQuantity() { return IsSetField(Tags.TriggerQuantity); }

    public CustomerOrFirm CustomerOrFirm
    {
        get
        {
            CustomerOrFirm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustomerOrFirm val) { CustomerOrFirm = val; }
    public CustomerOrFirm Get(CustomerOrFirm val) { GetField(val); return val; }
    public bool IsSet(CustomerOrFirm val) { return IsSetCustomerOrFirm(); }
    public bool IsSetCustomerOrFirm() { return IsSetField(Tags.CustomerOrFirm); }

    public LastLiquidityInd LastLiquidityInd
    {
        get
        {
            LastLiquidityInd val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastLiquidityInd val) { LastLiquidityInd = val; }
    public LastLiquidityInd Get(LastLiquidityInd val) { GetField(val); return val; }
    public bool IsSet(LastLiquidityInd val) { return IsSetLastLiquidityInd(); }
    public bool IsSetLastLiquidityInd() { return IsSetField(Tags.LastLiquidityInd); }

    public ExchangeReserve ExchangeReserve
    {
        get
        {
            ExchangeReserve val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExchangeReserve val) { ExchangeReserve = val; }
    public ExchangeReserve Get(ExchangeReserve val) { GetField(val); return val; }
    public bool IsSet(ExchangeReserve val) { return IsSetExchangeReserve(); }
    public bool IsSetExchangeReserve() { return IsSetField(Tags.ExchangeReserve); }

    public CxlQty CxlQty
    {
        get
        {
            CxlQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CxlQty val) { CxlQty = val; }
    public CxlQty Get(CxlQty val) { GetField(val); return val; }
    public bool IsSet(CxlQty val) { return IsSetCxlQty(); }
    public bool IsSetCxlQty() { return IsSetField(Tags.CxlQty); }

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

    public NetMoney NetMoney
    {
        get
        {
            NetMoney val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NetMoney val) { NetMoney = val; }
    public NetMoney Get(NetMoney val) { GetField(val); return val; }
    public bool IsSet(NetMoney val) { return IsSetNetMoney(); }
    public bool IsSetNetMoney() { return IsSetField(Tags.NetMoney); }

    public UnderlyingSymbol UnderlyingSymbol
    {
        get
        {
            UnderlyingSymbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSymbol val) { UnderlyingSymbol = val; }
    public UnderlyingSymbol Get(UnderlyingSymbol val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSymbol val) { return IsSetUnderlyingSymbol(); }
    public bool IsSetUnderlyingSymbol() { return IsSetField(Tags.UnderlyingSymbol); }

    public UnderlyingSecurityType UnderlyingSecurityType
    {
        get
        {
            UnderlyingSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityType val) { UnderlyingSecurityType = val; }
    public UnderlyingSecurityType Get(UnderlyingSecurityType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityType val) { return IsSetUnderlyingSecurityType(); }
    public bool IsSetUnderlyingSecurityType() { return IsSetField(Tags.UnderlyingSecurityType); }

    public SecondaryTrdType SecondaryTrdType
    {
        get
        {
            SecondaryTrdType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryTrdType val) { SecondaryTrdType = val; }
    public SecondaryTrdType Get(SecondaryTrdType val) { GetField(val); return val; }
    public bool IsSet(SecondaryTrdType val) { return IsSetSecondaryTrdType(); }
    public bool IsSetSecondaryTrdType() { return IsSetField(Tags.SecondaryTrdType); }

    public TrdSubType TrdSubType
    {
        get
        {
            TrdSubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TrdSubType val) { TrdSubType = val; }
    public TrdSubType Get(TrdSubType val) { GetField(val); return val; }
    public bool IsSet(TrdSubType val) { return IsSetTrdSubType(); }
    public bool IsSetTrdSubType() { return IsSetField(Tags.TrdSubType); }

    public QueueOptimisationFlag QueueOptimisationFlag
    {
        get
        {
            QueueOptimisationFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QueueOptimisationFlag val) { QueueOptimisationFlag = val; }
    public QueueOptimisationFlag Get(QueueOptimisationFlag val) { GetField(val); return val; }
    public bool IsSet(QueueOptimisationFlag val) { return IsSetQueueOptimisationFlag(); }
    public bool IsSetQueueOptimisationFlag() { return IsSetField(Tags.QueueOptimisationFlag); }

    public PartyIDExecutingFirm PartyIDExecutingFirm
    {
        get
        {
            PartyIDExecutingFirm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PartyIDExecutingFirm val) { PartyIDExecutingFirm = val; }
    public PartyIDExecutingFirm Get(PartyIDExecutingFirm val) { GetField(val); return val; }
    public bool IsSet(PartyIDExecutingFirm val) { return IsSetPartyIDExecutingFirm(); }
    public bool IsSetPartyIDExecutingFirm() { return IsSetField(Tags.PartyIDExecutingFirm); }

    public MatchType MatchType
    {
        get
        {
            MatchType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MatchType val) { MatchType = val; }
    public MatchType Get(MatchType val) { GetField(val); return val; }
    public bool IsSet(MatchType val) { return IsSetMatchType(); }
    public bool IsSetMatchType() { return IsSetField(Tags.MatchType); }

    public AlgorithmicTradeIndicator AlgorithmicTradeIndicator
    {
        get
        {
            AlgorithmicTradeIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AlgorithmicTradeIndicator val) { AlgorithmicTradeIndicator = val; }
    public AlgorithmicTradeIndicator Get(AlgorithmicTradeIndicator val) { GetField(val); return val; }
    public bool IsSet(AlgorithmicTradeIndicator val) { return IsSetAlgorithmicTradeIndicator(); }
    public bool IsSetAlgorithmicTradeIndicator() { return IsSetField(Tags.AlgorithmicTradeIndicator); }

    public TradeReportingIndicator TradeReportingIndicator
    {
        get
        {
            TradeReportingIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportingIndicator val) { TradeReportingIndicator = val; }
    public TradeReportingIndicator Get(TradeReportingIndicator val) { GetField(val); return val; }
    public bool IsSet(TradeReportingIndicator val) { return IsSetTradeReportingIndicator(); }
    public bool IsSetTradeReportingIndicator() { return IsSetField(Tags.TradeReportingIndicator); }

    public PartyIDReportingIntermediary PartyIDReportingIntermediary
    {
        get
        {
            PartyIDReportingIntermediary val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PartyIDReportingIntermediary val) { PartyIDReportingIntermediary = val; }
    public PartyIDReportingIntermediary Get(PartyIDReportingIntermediary val) { GetField(val); return val; }
    public bool IsSet(PartyIDReportingIntermediary val) { return IsSetPartyIDReportingIntermediary(); }
    public bool IsSetPartyIDReportingIntermediary() { return IsSetField(Tags.PartyIDReportingIntermediary); }

    public PartyIDExecutionVenue PartyIDExecutionVenue
    {
        get
        {
            PartyIDExecutionVenue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PartyIDExecutionVenue val) { PartyIDExecutionVenue = val; }
    public PartyIDExecutionVenue Get(PartyIDExecutionVenue val) { GetField(val); return val; }
    public bool IsSet(PartyIDExecutionVenue val) { return IsSetPartyIDExecutionVenue(); }
    public bool IsSetPartyIDExecutionVenue() { return IsSetField(Tags.PartyIDExecutionVenue); }

    public TrdRegPublicationReasonFlat TrdRegPublicationReasonFlat
    {
        get
        {
            TrdRegPublicationReasonFlat val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TrdRegPublicationReasonFlat val) { TrdRegPublicationReasonFlat = val; }
    public TrdRegPublicationReasonFlat Get(TrdRegPublicationReasonFlat val) { GetField(val); return val; }
    public bool IsSet(TrdRegPublicationReasonFlat val) { return IsSetTrdRegPublicationReasonFlat(); }
    public bool IsSetTrdRegPublicationReasonFlat() { return IsSetField(Tags.TrdRegPublicationReasonFlat); }

    public TradePriceConditionFlat TradePriceConditionFlat
    {
        get
        {
            TradePriceConditionFlat val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradePriceConditionFlat val) { TradePriceConditionFlat = val; }
    public TradePriceConditionFlat Get(TradePriceConditionFlat val) { GetField(val); return val; }
    public bool IsSet(TradePriceConditionFlat val) { return IsSetTradePriceConditionFlat(); }
    public bool IsSetTradePriceConditionFlat() { return IsSetField(Tags.TradePriceConditionFlat); }

    public VenueTransactionIdentificationCode VenueTransactionIdentificationCode
    {
        get
        {
            VenueTransactionIdentificationCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(VenueTransactionIdentificationCode val) { VenueTransactionIdentificationCode = val; }
    public VenueTransactionIdentificationCode Get(VenueTransactionIdentificationCode val) { GetField(val); return val; }
    public bool IsSet(VenueTransactionIdentificationCode val) { return IsSetVenueTransactionIdentificationCode(); }
    public bool IsSetVenueTransactionIdentificationCode() { return IsSetField(Tags.VenueTransactionIdentificationCode); }

    public InterlistedListingMic InterlistedListingMic
    {
        get
        {
            InterlistedListingMic val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterlistedListingMic val) { InterlistedListingMic = val; }
    public InterlistedListingMic Get(InterlistedListingMic val) { GetField(val); return val; }
    public bool IsSet(InterlistedListingMic val) { return IsSetInterlistedListingMic(); }
    public bool IsSetInterlistedListingMic() { return IsSetField(Tags.InterlistedListingMic); }

    public InterlistedTradeFxRate InterlistedTradeFxRate
    {
        get
        {
            InterlistedTradeFxRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterlistedTradeFxRate val) { InterlistedTradeFxRate = val; }
    public InterlistedTradeFxRate Get(InterlistedTradeFxRate val) { GetField(val); return val; }
    public bool IsSet(InterlistedTradeFxRate val) { return IsSetInterlistedTradeFxRate(); }
    public bool IsSetInterlistedTradeFxRate() { return IsSetField(Tags.InterlistedTradeFxRate); }

    public InterlistedParentCurrency InterlistedParentCurrency
    {
        get
        {
            InterlistedParentCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterlistedParentCurrency val) { InterlistedParentCurrency = val; }
    public InterlistedParentCurrency Get(InterlistedParentCurrency val) { GetField(val); return val; }
    public bool IsSet(InterlistedParentCurrency val) { return IsSetInterlistedParentCurrency(); }
    public bool IsSetInterlistedParentCurrency() { return IsSetField(Tags.InterlistedParentCurrency); }

    public InterlistedSecurityID InterlistedSecurityID
    {
        get
        {
            InterlistedSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterlistedSecurityID val) { InterlistedSecurityID = val; }
    public InterlistedSecurityID Get(InterlistedSecurityID val) { GetField(val); return val; }
    public bool IsSet(InterlistedSecurityID val) { return IsSetInterlistedSecurityID(); }
    public bool IsSetInterlistedSecurityID() { return IsSetField(Tags.InterlistedSecurityID); }

    public InterlistedSettlementCurrency InterlistedSettlementCurrency
    {
        get
        {
            InterlistedSettlementCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterlistedSettlementCurrency val) { InterlistedSettlementCurrency = val; }
    public InterlistedSettlementCurrency Get(InterlistedSettlementCurrency val) { GetField(val); return val; }
    public bool IsSet(InterlistedSettlementCurrency val) { return IsSetInterlistedSettlementCurrency(); }
    public bool IsSetInterlistedSettlementCurrency() { return IsSetField(Tags.InterlistedSettlementCurrency); }

    public InterlistedFillPrice InterlistedFillPrice
    {
        get
        {
            InterlistedFillPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterlistedFillPrice val) { InterlistedFillPrice = val; }
    public InterlistedFillPrice Get(InterlistedFillPrice val) { GetField(val); return val; }
    public bool IsSet(InterlistedFillPrice val) { return IsSetInterlistedFillPrice(); }
    public bool IsSetInterlistedFillPrice() { return IsSetField(Tags.InterlistedFillPrice); }

    public InterlistedTradeSize InterlistedTradeSize
    {
        get
        {
            InterlistedTradeSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterlistedTradeSize val) { InterlistedTradeSize = val; }
    public InterlistedTradeSize Get(InterlistedTradeSize val) { GetField(val); return val; }
    public bool IsSet(InterlistedTradeSize val) { return IsSetInterlistedTradeSize(); }
    public bool IsSetInterlistedTradeSize() { return IsSetField(Tags.InterlistedTradeSize); }

    public class NoContraBrokersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ContraBroker, Tags.ContraTrader, Tags.ContraTradeQty, Tags.ContraTradeTime, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.ContraBroker, Tags.ContraTrader, Tags.ContraTradeQty, Tags.ContraTradeTime, 0};

        public NoContraBrokersGroup()
          : base(Tags.NoContraBrokers, Tags.ContraBroker, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoContraBrokersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ContraBroker ContraBroker
        {
            get
            {
                ContraBroker val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraBroker val) { ContraBroker = val; }
        public ContraBroker Get(ContraBroker val) { GetField(val); return val; }
        public bool IsSet(ContraBroker val) { return IsSetContraBroker(); }
        public bool IsSetContraBroker() { return IsSetField(Tags.ContraBroker); }

        public ContraTrader ContraTrader
        {
            get
            {
                ContraTrader val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraTrader val) { ContraTrader = val; }
        public ContraTrader Get(ContraTrader val) { GetField(val); return val; }
        public bool IsSet(ContraTrader val) { return IsSetContraTrader(); }
        public bool IsSetContraTrader() { return IsSetField(Tags.ContraTrader); }

        public ContraTradeQty ContraTradeQty
        {
            get
            {
                ContraTradeQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraTradeQty val) { ContraTradeQty = val; }
        public ContraTradeQty Get(ContraTradeQty val) { GetField(val); return val; }
        public bool IsSet(ContraTradeQty val) { return IsSetContraTradeQty(); }
        public bool IsSetContraTradeQty() { return IsSetField(Tags.ContraTradeQty); }

        public ContraTradeTime ContraTradeTime
        {
            get
            {
                ContraTradeTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraTradeTime val) { ContraTradeTime = val; }
        public ContraTradeTime Get(ContraTradeTime val) { GetField(val); return val; }
        public bool IsSet(ContraTradeTime val) { return IsSetContraTradeTime(); }
        public bool IsSetContraTradeTime() { return IsSetField(Tags.ContraTradeTime); }
    }

    public class NoLegsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LegSecurityType, Tags.LegSymbol, Tags.LegPositionEffect, Tags.LegCFICode, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegStrikePrice, Tags.LegRatioQty, Tags.LegSide, Tags.LegRefID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.LegSecurityType, Tags.LegSymbol, Tags.LegPositionEffect, Tags.LegCFICode, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegStrikePrice, Tags.LegRatioQty, Tags.LegSide, Tags.LegRefID, 0};

        public NoLegsGroup()
          : base(Tags.NoLegs, Tags.LegSecurityType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoLegsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public LegSecurityType LegSecurityType
        {
            get
            {
                LegSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityType val) { LegSecurityType = val; }
        public LegSecurityType Get(LegSecurityType val) { GetField(val); return val; }
        public bool IsSet(LegSecurityType val) { return IsSetLegSecurityType(); }
        public bool IsSetLegSecurityType() { return IsSetField(Tags.LegSecurityType); }

        public LegSymbol LegSymbol
        {
            get
            {
                LegSymbol val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSymbol val) { LegSymbol = val; }
        public LegSymbol Get(LegSymbol val) { GetField(val); return val; }
        public bool IsSet(LegSymbol val) { return IsSetLegSymbol(); }
        public bool IsSetLegSymbol() { return IsSetField(Tags.LegSymbol); }

        public LegPositionEffect LegPositionEffect
        {
            get
            {
                LegPositionEffect val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPositionEffect val) { LegPositionEffect = val; }
        public LegPositionEffect Get(LegPositionEffect val) { GetField(val); return val; }
        public bool IsSet(LegPositionEffect val) { return IsSetLegPositionEffect(); }
        public bool IsSetLegPositionEffect() { return IsSetField(Tags.LegPositionEffect); }

        public LegCFICode LegCFICode
        {
            get
            {
                LegCFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCFICode val) { LegCFICode = val; }
        public LegCFICode Get(LegCFICode val) { GetField(val); return val; }
        public bool IsSet(LegCFICode val) { return IsSetLegCFICode(); }
        public bool IsSetLegCFICode() { return IsSetField(Tags.LegCFICode); }

        public LegMaturityMonthYear LegMaturityMonthYear
        {
            get
            {
                LegMaturityMonthYear val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegMaturityMonthYear val) { LegMaturityMonthYear = val; }
        public LegMaturityMonthYear Get(LegMaturityMonthYear val) { GetField(val); return val; }
        public bool IsSet(LegMaturityMonthYear val) { return IsSetLegMaturityMonthYear(); }
        public bool IsSetLegMaturityMonthYear() { return IsSetField(Tags.LegMaturityMonthYear); }

        public LegMaturityDate LegMaturityDate
        {
            get
            {
                LegMaturityDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegMaturityDate val) { LegMaturityDate = val; }
        public LegMaturityDate Get(LegMaturityDate val) { GetField(val); return val; }
        public bool IsSet(LegMaturityDate val) { return IsSetLegMaturityDate(); }
        public bool IsSetLegMaturityDate() { return IsSetField(Tags.LegMaturityDate); }

        public LegStrikePrice LegStrikePrice
        {
            get
            {
                LegStrikePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStrikePrice val) { LegStrikePrice = val; }
        public LegStrikePrice Get(LegStrikePrice val) { GetField(val); return val; }
        public bool IsSet(LegStrikePrice val) { return IsSetLegStrikePrice(); }
        public bool IsSetLegStrikePrice() { return IsSetField(Tags.LegStrikePrice); }

        public LegRatioQty LegRatioQty
        {
            get
            {
                LegRatioQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRatioQty val) { LegRatioQty = val; }
        public LegRatioQty Get(LegRatioQty val) { GetField(val); return val; }
        public bool IsSet(LegRatioQty val) { return IsSetLegRatioQty(); }
        public bool IsSetLegRatioQty() { return IsSetField(Tags.LegRatioQty); }

        public LegSide LegSide
        {
            get
            {
                LegSide val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSide val) { LegSide = val; }
        public LegSide Get(LegSide val) { GetField(val); return val; }
        public bool IsSet(LegSide val) { return IsSetLegSide(); }
        public bool IsSetLegSide() { return IsSetField(Tags.LegSide); }

        public LegRefID LegRefID
        {
            get
            {
                LegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRefID val) { LegRefID = val; }
        public LegRefID Get(LegRefID val) { GetField(val); return val; }
        public bool IsSet(LegRefID val) { return IsSetLegRefID(); }
        public bool IsSetLegRefID() { return IsSetField(Tags.LegRefID); }
    }
}
