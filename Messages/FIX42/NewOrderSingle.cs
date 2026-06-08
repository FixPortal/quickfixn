// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class NewOrderSingle : Message
{
    public const string MsgType = "D";

    public NewOrderSingle() : base()
    {
        Header.SetField(new MsgType("D"));
    }

    public NewOrderSingle(
            ClOrdID aClOrdID,
            HandlInst aHandlInst,
            Symbol aSymbol,
            Side aSide,
            TransactTime aTransactTime,
            OrdType aOrdType
        ) : this()
    {
        ClOrdID = aClOrdID;
        HandlInst = aHandlInst;
        Symbol = aSymbol;
        Side = aSide;
        TransactTime = aTransactTime;
        OrdType = aOrdType;
    }

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

    public NoAllocs NoAllocs
    {
        get
        {
            NoAllocs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoAllocs val) { NoAllocs = val; }
    public NoAllocs Get(NoAllocs val) { GetField(val); return val; }
    public bool IsSet(NoAllocs val) { return IsSetNoAllocs(); }
    public bool IsSetNoAllocs() { return IsSetField(Tags.NoAllocs); }

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

    public NoTradingSessions NoTradingSessions
    {
        get
        {
            NoTradingSessions val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTradingSessions val) { NoTradingSessions = val; }
    public NoTradingSessions Get(NoTradingSessions val) { GetField(val); return val; }
    public bool IsSet(NoTradingSessions val) { return IsSetNoTradingSessions(); }
    public bool IsSetNoTradingSessions() { return IsSetField(Tags.NoTradingSessions); }

    public ProcessCode ProcessCode
    {
        get
        {
            ProcessCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ProcessCode val) { ProcessCode = val; }
    public ProcessCode Get(ProcessCode val) { GetField(val); return val; }
    public bool IsSet(ProcessCode val) { return IsSetProcessCode(); }
    public bool IsSetProcessCode() { return IsSetField(Tags.ProcessCode); }

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

    public PrevClosePx PrevClosePx
    {
        get
        {
            PrevClosePx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PrevClosePx val) { PrevClosePx = val; }
    public PrevClosePx Get(PrevClosePx val) { GetField(val); return val; }
    public bool IsSet(PrevClosePx val) { return IsSetPrevClosePx(); }
    public bool IsSetPrevClosePx() { return IsSetField(Tags.PrevClosePx); }

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

    public LocateReqd LocateReqd
    {
        get
        {
            LocateReqd val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LocateReqd val) { LocateReqd = val; }
    public LocateReqd Get(LocateReqd val) { GetField(val); return val; }
    public bool IsSet(LocateReqd val) { return IsSetLocateReqd(); }
    public bool IsSetLocateReqd() { return IsSetField(Tags.LocateReqd); }

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

    public IOIid IOIid
    {
        get
        {
            IOIid val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOIid val) { IOIid = val; }
    public IOIid Get(IOIid val) { GetField(val); return val; }
    public bool IsSet(IOIid val) { return IsSetIOIid(); }
    public bool IsSetIOIid() { return IsSetField(Tags.IOIid); }

    public QuoteID QuoteID
    {
        get
        {
            QuoteID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteID val) { QuoteID = val; }
    public QuoteID Get(QuoteID val) { GetField(val); return val; }
    public bool IsSet(QuoteID val) { return IsSetQuoteID(); }
    public bool IsSetQuoteID() { return IsSetField(Tags.QuoteID); }

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

    public ForexReq ForexReq
    {
        get
        {
            ForexReq val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ForexReq val) { ForexReq = val; }
    public ForexReq Get(ForexReq val) { GetField(val); return val; }
    public bool IsSet(ForexReq val) { return IsSetForexReq(); }
    public bool IsSetForexReq() { return IsSetField(Tags.ForexReq); }

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

    public CoveredOrUncovered CoveredOrUncovered
    {
        get
        {
            CoveredOrUncovered val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CoveredOrUncovered val) { CoveredOrUncovered = val; }
    public CoveredOrUncovered Get(CoveredOrUncovered val) { GetField(val); return val; }
    public bool IsSet(CoveredOrUncovered val) { return IsSetCoveredOrUncovered(); }
    public bool IsSetCoveredOrUncovered() { return IsSetField(Tags.CoveredOrUncovered); }

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

    public RegulationID RegulationID
    {
        get
        {
            RegulationID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegulationID val) { RegulationID = val; }
    public RegulationID Get(RegulationID val) { GetField(val); return val; }
    public bool IsSet(RegulationID val) { return IsSetRegulationID(); }
    public bool IsSetRegulationID() { return IsSetField(Tags.RegulationID); }

    public RetailOrder RetailOrder
    {
        get
        {
            RetailOrder val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RetailOrder val) { RetailOrder = val; }
    public RetailOrder Get(RetailOrder val) { GetField(val); return val; }
    public bool IsSet(RetailOrder val) { return IsSetRetailOrder(); }
    public bool IsSetRetailOrder() { return IsSetField(Tags.RetailOrder); }

    public DisplayInst DisplayInst
    {
        get
        {
            DisplayInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayInst val) { DisplayInst = val; }
    public DisplayInst Get(DisplayInst val) { GetField(val); return val; }
    public bool IsSet(DisplayInst val) { return IsSetDisplayInst(); }
    public bool IsSetDisplayInst() { return IsSetField(Tags.DisplayInst); }

    public Account_BMO Account_BMO
    {
        get
        {
            Account_BMO val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Account_BMO val) { Account_BMO = val; }
    public Account_BMO Get(Account_BMO val) { GetField(val); return val; }
    public bool IsSet(Account_BMO val) { return IsSetAccount_BMO(); }
    public bool IsSetAccount_BMO() { return IsSetField(Tags.Account_BMO); }

    public Routable Routable
    {
        get
        {
            Routable val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Routable val) { Routable = val; }
    public Routable Get(Routable val) { GetField(val); return val; }
    public bool IsSet(Routable val) { return IsSetRoutable(); }
    public bool IsSetRoutable() { return IsSetField(Tags.Routable); }

    public EndClientOrderID EndClientOrderID
    {
        get
        {
            EndClientOrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndClientOrderID val) { EndClientOrderID = val; }
    public EndClientOrderID Get(EndClientOrderID val) { GetField(val); return val; }
    public bool IsSet(EndClientOrderID val) { return IsSetEndClientOrderID(); }
    public bool IsSetEndClientOrderID() { return IsSetField(Tags.EndClientOrderID); }

    public BuysideTrader BuysideTrader
    {
        get
        {
            BuysideTrader val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BuysideTrader val) { BuysideTrader = val; }
    public BuysideTrader Get(BuysideTrader val) { GetField(val); return val; }
    public bool IsSet(BuysideTrader val) { return IsSetBuysideTrader(); }
    public bool IsSetBuysideTrader() { return IsSetField(Tags.BuysideTrader); }

    public Algo_Auction_Berenberg Algo_Auction_Berenberg
    {
        get
        {
            Algo_Auction_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Auction_Berenberg val) { Algo_Auction_Berenberg = val; }
    public Algo_Auction_Berenberg Get(Algo_Auction_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Auction_Berenberg val) { return IsSetAlgo_Auction_Berenberg(); }
    public bool IsSetAlgo_Auction_Berenberg() { return IsSetField(Tags.Algo_Auction_Berenberg); }

    public Algo_AuctionMaxPct_Berenberg Algo_AuctionMaxPct_Berenberg
    {
        get
        {
            Algo_AuctionMaxPct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_AuctionMaxPct_Berenberg val) { Algo_AuctionMaxPct_Berenberg = val; }
    public Algo_AuctionMaxPct_Berenberg Get(Algo_AuctionMaxPct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_AuctionMaxPct_Berenberg val) { return IsSetAlgo_AuctionMaxPct_Berenberg(); }
    public bool IsSetAlgo_AuctionMaxPct_Berenberg() { return IsSetField(Tags.Algo_AuctionMaxPct_Berenberg); }

    public Algo_AuctionOnly_Berenberg Algo_AuctionOnly_Berenberg
    {
        get
        {
            Algo_AuctionOnly_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_AuctionOnly_Berenberg val) { Algo_AuctionOnly_Berenberg = val; }
    public Algo_AuctionOnly_Berenberg Get(Algo_AuctionOnly_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_AuctionOnly_Berenberg val) { return IsSetAlgo_AuctionOnly_Berenberg(); }
    public bool IsSetAlgo_AuctionOnly_Berenberg() { return IsSetField(Tags.Algo_AuctionOnly_Berenberg); }

    public Algo_BeatX_Berenberg Algo_BeatX_Berenberg
    {
        get
        {
            Algo_BeatX_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_BeatX_Berenberg val) { Algo_BeatX_Berenberg = val; }
    public Algo_BeatX_Berenberg Get(Algo_BeatX_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_BeatX_Berenberg val) { return IsSetAlgo_BeatX_Berenberg(); }
    public bool IsSetAlgo_BeatX_Berenberg() { return IsSetField(Tags.Algo_BeatX_Berenberg); }

    public Algo_Benchmark_Berenberg Algo_Benchmark_Berenberg
    {
        get
        {
            Algo_Benchmark_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Benchmark_Berenberg val) { Algo_Benchmark_Berenberg = val; }
    public Algo_Benchmark_Berenberg Get(Algo_Benchmark_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Benchmark_Berenberg val) { return IsSetAlgo_Benchmark_Berenberg(); }
    public bool IsSetAlgo_Benchmark_Berenberg() { return IsSetField(Tags.Algo_Benchmark_Berenberg); }

    public Algo_Block_Berenberg Algo_Block_Berenberg
    {
        get
        {
            Algo_Block_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Block_Berenberg val) { Algo_Block_Berenberg = val; }
    public Algo_Block_Berenberg Get(Algo_Block_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Block_Berenberg val) { return IsSetAlgo_Block_Berenberg(); }
    public bool IsSetAlgo_Block_Berenberg() { return IsSetField(Tags.Algo_Block_Berenberg); }

    public Algo_ContMaxPct_Berenberg Algo_ContMaxPct_Berenberg
    {
        get
        {
            Algo_ContMaxPct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_ContMaxPct_Berenberg val) { Algo_ContMaxPct_Berenberg = val; }
    public Algo_ContMaxPct_Berenberg Get(Algo_ContMaxPct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_ContMaxPct_Berenberg val) { return IsSetAlgo_ContMaxPct_Berenberg(); }
    public bool IsSetAlgo_ContMaxPct_Berenberg() { return IsSetField(Tags.Algo_ContMaxPct_Berenberg); }

    public Algo_Custom1_Berenberg Algo_Custom1_Berenberg
    {
        get
        {
            Algo_Custom1_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Custom1_Berenberg val) { Algo_Custom1_Berenberg = val; }
    public Algo_Custom1_Berenberg Get(Algo_Custom1_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Custom1_Berenberg val) { return IsSetAlgo_Custom1_Berenberg(); }
    public bool IsSetAlgo_Custom1_Berenberg() { return IsSetField(Tags.Algo_Custom1_Berenberg); }

    public Algo_Custom2_Berenberg Algo_Custom2_Berenberg
    {
        get
        {
            Algo_Custom2_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Custom2_Berenberg val) { Algo_Custom2_Berenberg = val; }
    public Algo_Custom2_Berenberg Get(Algo_Custom2_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Custom2_Berenberg val) { return IsSetAlgo_Custom2_Berenberg(); }
    public bool IsSetAlgo_Custom2_Berenberg() { return IsSetField(Tags.Algo_Custom2_Berenberg); }

    public Algo_DisplaySize_Berenberg Algo_DisplaySize_Berenberg
    {
        get
        {
            Algo_DisplaySize_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_DisplaySize_Berenberg val) { Algo_DisplaySize_Berenberg = val; }
    public Algo_DisplaySize_Berenberg Get(Algo_DisplaySize_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_DisplaySize_Berenberg val) { return IsSetAlgo_DisplaySize_Berenberg(); }
    public bool IsSetAlgo_DisplaySize_Berenberg() { return IsSetField(Tags.Algo_DisplaySize_Berenberg); }

    public Algo_EndTime_Berenberg Algo_EndTime_Berenberg
    {
        get
        {
            Algo_EndTime_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_EndTime_Berenberg val) { Algo_EndTime_Berenberg = val; }
    public Algo_EndTime_Berenberg Get(Algo_EndTime_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_EndTime_Berenberg val) { return IsSetAlgo_EndTime_Berenberg(); }
    public bool IsSetAlgo_EndTime_Berenberg() { return IsSetField(Tags.Algo_EndTime_Berenberg); }

    public Algo_IWLitBench_Berenberg Algo_IWLitBench_Berenberg
    {
        get
        {
            Algo_IWLitBench_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWLitBench_Berenberg val) { Algo_IWLitBench_Berenberg = val; }
    public Algo_IWLitBench_Berenberg Get(Algo_IWLitBench_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_IWLitBench_Berenberg val) { return IsSetAlgo_IWLitBench_Berenberg(); }
    public bool IsSetAlgo_IWLitBench_Berenberg() { return IsSetField(Tags.Algo_IWLitBench_Berenberg); }

    public Algo_IWPhase_Berenberg Algo_IWPhase_Berenberg
    {
        get
        {
            Algo_IWPhase_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWPhase_Berenberg val) { Algo_IWPhase_Berenberg = val; }
    public Algo_IWPhase_Berenberg Get(Algo_IWPhase_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_IWPhase_Berenberg val) { return IsSetAlgo_IWPhase_Berenberg(); }
    public bool IsSetAlgo_IWPhase_Berenberg() { return IsSetField(Tags.Algo_IWPhase_Berenberg); }

    public Algo_L1Pct_Berenberg Algo_L1Pct_Berenberg
    {
        get
        {
            Algo_L1Pct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_L1Pct_Berenberg val) { Algo_L1Pct_Berenberg = val; }
    public Algo_L1Pct_Berenberg Get(Algo_L1Pct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_L1Pct_Berenberg val) { return IsSetAlgo_L1Pct_Berenberg(); }
    public bool IsSetAlgo_L1Pct_Berenberg() { return IsSetField(Tags.Algo_L1Pct_Berenberg); }

    public Algo_L2Pct_Berenberg Algo_L2Pct_Berenberg
    {
        get
        {
            Algo_L2Pct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_L2Pct_Berenberg val) { Algo_L2Pct_Berenberg = val; }
    public Algo_L2Pct_Berenberg Get(Algo_L2Pct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_L2Pct_Berenberg val) { return IsSetAlgo_L2Pct_Berenberg(); }
    public bool IsSetAlgo_L2Pct_Berenberg() { return IsSetField(Tags.Algo_L2Pct_Berenberg); }

    public Algo_L2Px_Berenberg Algo_L2Px_Berenberg
    {
        get
        {
            Algo_L2Px_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_L2Px_Berenberg val) { Algo_L2Px_Berenberg = val; }
    public Algo_L2Px_Berenberg Get(Algo_L2Px_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_L2Px_Berenberg val) { return IsSetAlgo_L2Px_Berenberg(); }
    public bool IsSetAlgo_L2Px_Berenberg() { return IsSetField(Tags.Algo_L2Px_Berenberg); }

    public Algo_L3Pct_Berenberg Algo_L3Pct_Berenberg
    {
        get
        {
            Algo_L3Pct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_L3Pct_Berenberg val) { Algo_L3Pct_Berenberg = val; }
    public Algo_L3Pct_Berenberg Get(Algo_L3Pct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_L3Pct_Berenberg val) { return IsSetAlgo_L3Pct_Berenberg(); }
    public bool IsSetAlgo_L3Pct_Berenberg() { return IsSetField(Tags.Algo_L3Pct_Berenberg); }

    public Algo_L3Px_Berenberg Algo_L3Px_Berenberg
    {
        get
        {
            Algo_L3Px_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_L3Px_Berenberg val) { Algo_L3Px_Berenberg = val; }
    public Algo_L3Px_Berenberg Get(Algo_L3Px_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_L3Px_Berenberg val) { return IsSetAlgo_L3Px_Berenberg(); }
    public bool IsSetAlgo_L3Px_Berenberg() { return IsSetField(Tags.Algo_L3Px_Berenberg); }

    public Algo_L4Pct_Berenberg Algo_L4Pct_Berenberg
    {
        get
        {
            Algo_L4Pct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_L4Pct_Berenberg val) { Algo_L4Pct_Berenberg = val; }
    public Algo_L4Pct_Berenberg Get(Algo_L4Pct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_L4Pct_Berenberg val) { return IsSetAlgo_L4Pct_Berenberg(); }
    public bool IsSetAlgo_L4Pct_Berenberg() { return IsSetField(Tags.Algo_L4Pct_Berenberg); }

    public Algo_L4Px_Berenberg Algo_L4Px_Berenberg
    {
        get
        {
            Algo_L4Px_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_L4Px_Berenberg val) { Algo_L4Px_Berenberg = val; }
    public Algo_L4Px_Berenberg Get(Algo_L4Px_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_L4Px_Berenberg val) { return IsSetAlgo_L4Px_Berenberg(); }
    public bool IsSetAlgo_L4Px_Berenberg() { return IsSetField(Tags.Algo_L4Px_Berenberg); }

    public Algo_MarketDirection_Berenberg Algo_MarketDirection_Berenberg
    {
        get
        {
            Algo_MarketDirection_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_MarketDirection_Berenberg val) { Algo_MarketDirection_Berenberg = val; }
    public Algo_MarketDirection_Berenberg Get(Algo_MarketDirection_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_MarketDirection_Berenberg val) { return IsSetAlgo_MarketDirection_Berenberg(); }
    public bool IsSetAlgo_MarketDirection_Berenberg() { return IsSetField(Tags.Algo_MarketDirection_Berenberg); }

    public Algo_MinDarkFill_Berenberg Algo_MinDarkFill_Berenberg
    {
        get
        {
            Algo_MinDarkFill_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_MinDarkFill_Berenberg val) { Algo_MinDarkFill_Berenberg = val; }
    public Algo_MinDarkFill_Berenberg Get(Algo_MinDarkFill_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_MinDarkFill_Berenberg val) { return IsSetAlgo_MinDarkFill_Berenberg(); }
    public bool IsSetAlgo_MinDarkFill_Berenberg() { return IsSetField(Tags.Algo_MinDarkFill_Berenberg); }

    public Algo_MinDarkType_Berenberg Algo_MinDarkType_Berenberg
    {
        get
        {
            Algo_MinDarkType_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_MinDarkType_Berenberg val) { Algo_MinDarkType_Berenberg = val; }
    public Algo_MinDarkType_Berenberg Get(Algo_MinDarkType_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_MinDarkType_Berenberg val) { return IsSetAlgo_MinDarkType_Berenberg(); }
    public bool IsSetAlgo_MinDarkType_Berenberg() { return IsSetField(Tags.Algo_MinDarkType_Berenberg); }

    public Algo_MinTakeAQxShares_Berenberg Algo_MinTakeAQxShares_Berenberg
    {
        get
        {
            Algo_MinTakeAQxShares_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_MinTakeAQxShares_Berenberg val) { Algo_MinTakeAQxShares_Berenberg = val; }
    public Algo_MinTakeAQxShares_Berenberg Get(Algo_MinTakeAQxShares_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_MinTakeAQxShares_Berenberg val) { return IsSetAlgo_MinTakeAQxShares_Berenberg(); }
    public bool IsSetAlgo_MinTakeAQxShares_Berenberg() { return IsSetField(Tags.Algo_MinTakeAQxShares_Berenberg); }

    public Algo_MinTakeShares_Berenberg Algo_MinTakeShares_Berenberg
    {
        get
        {
            Algo_MinTakeShares_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_MinTakeShares_Berenberg val) { Algo_MinTakeShares_Berenberg = val; }
    public Algo_MinTakeShares_Berenberg Get(Algo_MinTakeShares_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_MinTakeShares_Berenberg val) { return IsSetAlgo_MinTakeShares_Berenberg(); }
    public bool IsSetAlgo_MinTakeShares_Berenberg() { return IsSetField(Tags.Algo_MinTakeShares_Berenberg); }

    public Algo_Offset_Berenberg Algo_Offset_Berenberg
    {
        get
        {
            Algo_Offset_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Offset_Berenberg val) { Algo_Offset_Berenberg = val; }
    public Algo_Offset_Berenberg Get(Algo_Offset_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Offset_Berenberg val) { return IsSetAlgo_Offset_Berenberg(); }
    public bool IsSetAlgo_Offset_Berenberg() { return IsSetField(Tags.Algo_Offset_Berenberg); }

    public Algo_PegOffset_Berenberg Algo_PegOffset_Berenberg
    {
        get
        {
            Algo_PegOffset_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_PegOffset_Berenberg val) { Algo_PegOffset_Berenberg = val; }
    public Algo_PegOffset_Berenberg Get(Algo_PegOffset_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_PegOffset_Berenberg val) { return IsSetAlgo_PegOffset_Berenberg(); }
    public bool IsSetAlgo_PegOffset_Berenberg() { return IsSetField(Tags.Algo_PegOffset_Berenberg); }

    public Algo_RefPx_Berenberg Algo_RefPx_Berenberg
    {
        get
        {
            Algo_RefPx_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RefPx_Berenberg val) { Algo_RefPx_Berenberg = val; }
    public Algo_RefPx_Berenberg Get(Algo_RefPx_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_RefPx_Berenberg val) { return IsSetAlgo_RefPx_Berenberg(); }
    public bool IsSetAlgo_RefPx_Berenberg() { return IsSetField(Tags.Algo_RefPx_Berenberg); }

    public Algo_RelLimitTicker_Berenberg Algo_RelLimitTicker_Berenberg
    {
        get
        {
            Algo_RelLimitTicker_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RelLimitTicker_Berenberg val) { Algo_RelLimitTicker_Berenberg = val; }
    public Algo_RelLimitTicker_Berenberg Get(Algo_RelLimitTicker_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_RelLimitTicker_Berenberg val) { return IsSetAlgo_RelLimitTicker_Berenberg(); }
    public bool IsSetAlgo_RelLimitTicker_Berenberg() { return IsSetField(Tags.Algo_RelLimitTicker_Berenberg); }

    public Algo_RelPxOffset_Berenberg Algo_RelPxOffset_Berenberg
    {
        get
        {
            Algo_RelPxOffset_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RelPxOffset_Berenberg val) { Algo_RelPxOffset_Berenberg = val; }
    public Algo_RelPxOffset_Berenberg Get(Algo_RelPxOffset_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_RelPxOffset_Berenberg val) { return IsSetAlgo_RelPxOffset_Berenberg(); }
    public bool IsSetAlgo_RelPxOffset_Berenberg() { return IsSetField(Tags.Algo_RelPxOffset_Berenberg); }

    public Algo_RelPxRef_Berenberg Algo_RelPxRef_Berenberg
    {
        get
        {
            Algo_RelPxRef_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RelPxRef_Berenberg val) { Algo_RelPxRef_Berenberg = val; }
    public Algo_RelPxRef_Berenberg Get(Algo_RelPxRef_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_RelPxRef_Berenberg val) { return IsSetAlgo_RelPxRef_Berenberg(); }
    public bool IsSetAlgo_RelPxRef_Berenberg() { return IsSetField(Tags.Algo_RelPxRef_Berenberg); }

    public Algo_StartTime_Berenberg Algo_StartTime_Berenberg
    {
        get
        {
            Algo_StartTime_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_StartTime_Berenberg val) { Algo_StartTime_Berenberg = val; }
    public Algo_StartTime_Berenberg Get(Algo_StartTime_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_StartTime_Berenberg val) { return IsSetAlgo_StartTime_Berenberg(); }
    public bool IsSetAlgo_StartTime_Berenberg() { return IsSetField(Tags.Algo_StartTime_Berenberg); }

    public Algo_Strat1_Berenberg Algo_Strat1_Berenberg
    {
        get
        {
            Algo_Strat1_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Strat1_Berenberg val) { Algo_Strat1_Berenberg = val; }
    public Algo_Strat1_Berenberg Get(Algo_Strat1_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Strat1_Berenberg val) { return IsSetAlgo_Strat1_Berenberg(); }
    public bool IsSetAlgo_Strat1_Berenberg() { return IsSetField(Tags.Algo_Strat1_Berenberg); }

    public Algo_Strat2_Berenberg Algo_Strat2_Berenberg
    {
        get
        {
            Algo_Strat2_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Strat2_Berenberg val) { Algo_Strat2_Berenberg = val; }
    public Algo_Strat2_Berenberg Get(Algo_Strat2_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Strat2_Berenberg val) { return IsSetAlgo_Strat2_Berenberg(); }
    public bool IsSetAlgo_Strat2_Berenberg() { return IsSetField(Tags.Algo_Strat2_Berenberg); }

    public Algo_StrategyIdentifierTag_Berenberg Algo_StrategyIdentifierTag_Berenberg
    {
        get
        {
            Algo_StrategyIdentifierTag_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_StrategyIdentifierTag_Berenberg val) { Algo_StrategyIdentifierTag_Berenberg = val; }
    public Algo_StrategyIdentifierTag_Berenberg Get(Algo_StrategyIdentifierTag_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_StrategyIdentifierTag_Berenberg val) { return IsSetAlgo_StrategyIdentifierTag_Berenberg(); }
    public bool IsSetAlgo_StrategyIdentifierTag_Berenberg() { return IsSetField(Tags.Algo_StrategyIdentifierTag_Berenberg); }

    public Algo_Style_Berenberg Algo_Style_Berenberg
    {
        get
        {
            Algo_Style_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Style_Berenberg val) { Algo_Style_Berenberg = val; }
    public Algo_Style_Berenberg Get(Algo_Style_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Style_Berenberg val) { return IsSetAlgo_Style_Berenberg(); }
    public bool IsSetAlgo_Style_Berenberg() { return IsSetField(Tags.Algo_Style_Berenberg); }

    public Algo_SwitchRemainPct_Berenberg Algo_SwitchRemainPct_Berenberg
    {
        get
        {
            Algo_SwitchRemainPct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_SwitchRemainPct_Berenberg val) { Algo_SwitchRemainPct_Berenberg = val; }
    public Algo_SwitchRemainPct_Berenberg Get(Algo_SwitchRemainPct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_SwitchRemainPct_Berenberg val) { return IsSetAlgo_SwitchRemainPct_Berenberg(); }
    public bool IsSetAlgo_SwitchRemainPct_Berenberg() { return IsSetField(Tags.Algo_SwitchRemainPct_Berenberg); }

    public Algo_SwitchTime_Berenberg Algo_SwitchTime_Berenberg
    {
        get
        {
            Algo_SwitchTime_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_SwitchTime_Berenberg val) { Algo_SwitchTime_Berenberg = val; }
    public Algo_SwitchTime_Berenberg Get(Algo_SwitchTime_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_SwitchTime_Berenberg val) { return IsSetAlgo_SwitchTime_Berenberg(); }
    public bool IsSetAlgo_SwitchTime_Berenberg() { return IsSetField(Tags.Algo_SwitchTime_Berenberg); }

    public Algo_Target_Berenberg Algo_Target_Berenberg
    {
        get
        {
            Algo_Target_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Target_Berenberg val) { Algo_Target_Berenberg = val; }
    public Algo_Target_Berenberg Get(Algo_Target_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Target_Berenberg val) { return IsSetAlgo_Target_Berenberg(); }
    public bool IsSetAlgo_Target_Berenberg() { return IsSetField(Tags.Algo_Target_Berenberg); }

    public Algo_Target_Type_Berenberg Algo_Target_Type_Berenberg
    {
        get
        {
            Algo_Target_Type_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Target_Type_Berenberg val) { Algo_Target_Type_Berenberg = val; }
    public Algo_Target_Type_Berenberg Get(Algo_Target_Type_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Target_Type_Berenberg val) { return IsSetAlgo_Target_Type_Berenberg(); }
    public bool IsSetAlgo_Target_Type_Berenberg() { return IsSetField(Tags.Algo_Target_Type_Berenberg); }

    public Algo_TargetPct_Berenberg Algo_TargetPct_Berenberg
    {
        get
        {
            Algo_TargetPct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_TargetPct_Berenberg val) { Algo_TargetPct_Berenberg = val; }
    public Algo_TargetPct_Berenberg Get(Algo_TargetPct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_TargetPct_Berenberg val) { return IsSetAlgo_TargetPct_Berenberg(); }
    public bool IsSetAlgo_TargetPct_Berenberg() { return IsSetField(Tags.Algo_TargetPct_Berenberg); }

    public Algo_Tilt_Berenberg Algo_Tilt_Berenberg
    {
        get
        {
            Algo_Tilt_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Tilt_Berenberg val) { Algo_Tilt_Berenberg = val; }
    public Algo_Tilt_Berenberg Get(Algo_Tilt_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Tilt_Berenberg val) { return IsSetAlgo_Tilt_Berenberg(); }
    public bool IsSetAlgo_Tilt_Berenberg() { return IsSetField(Tags.Algo_Tilt_Berenberg); }

    public Algo_Unit_Berenberg Algo_Unit_Berenberg
    {
        get
        {
            Algo_Unit_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Unit_Berenberg val) { Algo_Unit_Berenberg = val; }
    public Algo_Unit_Berenberg Get(Algo_Unit_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Unit_Berenberg val) { return IsSetAlgo_Unit_Berenberg(); }
    public bool IsSetAlgo_Unit_Berenberg() { return IsSetField(Tags.Algo_Unit_Berenberg); }

    public Algo_Urgency_Berenberg Algo_Urgency_Berenberg
    {
        get
        {
            Algo_Urgency_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Urgency_Berenberg val) { Algo_Urgency_Berenberg = val; }
    public Algo_Urgency_Berenberg Get(Algo_Urgency_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_Urgency_Berenberg val) { return IsSetAlgo_Urgency_Berenberg(); }
    public bool IsSetAlgo_Urgency_Berenberg() { return IsSetField(Tags.Algo_Urgency_Berenberg); }

    public Algo_VolMaxPct_Berenberg Algo_VolMaxPct_Berenberg
    {
        get
        {
            Algo_VolMaxPct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_VolMaxPct_Berenberg val) { Algo_VolMaxPct_Berenberg = val; }
    public Algo_VolMaxPct_Berenberg Get(Algo_VolMaxPct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_VolMaxPct_Berenberg val) { return IsSetAlgo_VolMaxPct_Berenberg(); }
    public bool IsSetAlgo_VolMaxPct_Berenberg() { return IsSetField(Tags.Algo_VolMaxPct_Berenberg); }

    public Algo_WouldDarkPct_Berenberg Algo_WouldDarkPct_Berenberg
    {
        get
        {
            Algo_WouldDarkPct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_WouldDarkPct_Berenberg val) { Algo_WouldDarkPct_Berenberg = val; }
    public Algo_WouldDarkPct_Berenberg Get(Algo_WouldDarkPct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_WouldDarkPct_Berenberg val) { return IsSetAlgo_WouldDarkPct_Berenberg(); }
    public bool IsSetAlgo_WouldDarkPct_Berenberg() { return IsSetField(Tags.Algo_WouldDarkPct_Berenberg); }

    public Algo_WouldDarkPx_Berenberg Algo_WouldDarkPx_Berenberg
    {
        get
        {
            Algo_WouldDarkPx_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_WouldDarkPx_Berenberg val) { Algo_WouldDarkPx_Berenberg = val; }
    public Algo_WouldDarkPx_Berenberg Get(Algo_WouldDarkPx_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_WouldDarkPx_Berenberg val) { return IsSetAlgo_WouldDarkPx_Berenberg(); }
    public bool IsSetAlgo_WouldDarkPx_Berenberg() { return IsSetField(Tags.Algo_WouldDarkPx_Berenberg); }

    public Algo_WouldLitPct_Berenberg Algo_WouldLitPct_Berenberg
    {
        get
        {
            Algo_WouldLitPct_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_WouldLitPct_Berenberg val) { Algo_WouldLitPct_Berenberg = val; }
    public Algo_WouldLitPct_Berenberg Get(Algo_WouldLitPct_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_WouldLitPct_Berenberg val) { return IsSetAlgo_WouldLitPct_Berenberg(); }
    public bool IsSetAlgo_WouldLitPct_Berenberg() { return IsSetField(Tags.Algo_WouldLitPct_Berenberg); }

    public Algo_WouldLitPx_Berenberg Algo_WouldLitPx_Berenberg
    {
        get
        {
            Algo_WouldLitPx_Berenberg val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_WouldLitPx_Berenberg val) { Algo_WouldLitPx_Berenberg = val; }
    public Algo_WouldLitPx_Berenberg Get(Algo_WouldLitPx_Berenberg val) { GetField(val); return val; }
    public bool IsSet(Algo_WouldLitPx_Berenberg val) { return IsSetAlgo_WouldLitPx_Berenberg(); }
    public bool IsSetAlgo_WouldLitPx_Berenberg() { return IsSetField(Tags.Algo_WouldLitPx_Berenberg); }

    public Anonymous Anonymous
    {
        get
        {
            Anonymous val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Anonymous val) { Anonymous = val; }
    public Anonymous Get(Anonymous val) { GetField(val); return val; }
    public bool IsSet(Anonymous val) { return IsSetAnonymous(); }
    public bool IsSetAnonymous() { return IsSetField(Tags.Anonymous); }

    public Algo_AuctionMode_BMOA Algo_AuctionMode_BMOA
    {
        get
        {
            Algo_AuctionMode_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_AuctionMode_BMOA val) { Algo_AuctionMode_BMOA = val; }
    public Algo_AuctionMode_BMOA Get(Algo_AuctionMode_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_AuctionMode_BMOA val) { return IsSetAlgo_AuctionMode_BMOA(); }
    public bool IsSetAlgo_AuctionMode_BMOA() { return IsSetField(Tags.Algo_AuctionMode_BMOA); }

    public Algo_AuctionSliceType_BMOA Algo_AuctionSliceType_BMOA
    {
        get
        {
            Algo_AuctionSliceType_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_AuctionSliceType_BMOA val) { Algo_AuctionSliceType_BMOA = val; }
    public Algo_AuctionSliceType_BMOA Get(Algo_AuctionSliceType_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_AuctionSliceType_BMOA val) { return IsSetAlgo_AuctionSliceType_BMOA(); }
    public bool IsSetAlgo_AuctionSliceType_BMOA() { return IsSetField(Tags.Algo_AuctionSliceType_BMOA); }

    public Algo_ClosingAuctionParticipation_BMOA Algo_ClosingAuctionParticipation_BMOA
    {
        get
        {
            Algo_ClosingAuctionParticipation_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_ClosingAuctionParticipation_BMOA val) { Algo_ClosingAuctionParticipation_BMOA = val; }
    public Algo_ClosingAuctionParticipation_BMOA Get(Algo_ClosingAuctionParticipation_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_ClosingAuctionParticipation_BMOA val) { return IsSetAlgo_ClosingAuctionParticipation_BMOA(); }
    public bool IsSetAlgo_ClosingAuctionParticipation_BMOA() { return IsSetField(Tags.Algo_ClosingAuctionParticipation_BMOA); }

    public Algo_CompletionRequired_BMOA Algo_CompletionRequired_BMOA
    {
        get
        {
            Algo_CompletionRequired_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_CompletionRequired_BMOA val) { Algo_CompletionRequired_BMOA = val; }
    public Algo_CompletionRequired_BMOA Get(Algo_CompletionRequired_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_CompletionRequired_BMOA val) { return IsSetAlgo_CompletionRequired_BMOA(); }
    public bool IsSetAlgo_CompletionRequired_BMOA() { return IsSetField(Tags.Algo_CompletionRequired_BMOA); }

    public Algo_ConditionalMode_BMOA Algo_ConditionalMode_BMOA
    {
        get
        {
            Algo_ConditionalMode_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_ConditionalMode_BMOA val) { Algo_ConditionalMode_BMOA = val; }
    public Algo_ConditionalMode_BMOA Get(Algo_ConditionalMode_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_ConditionalMode_BMOA val) { return IsSetAlgo_ConditionalMode_BMOA(); }
    public bool IsSetAlgo_ConditionalMode_BMOA() { return IsSetField(Tags.Algo_ConditionalMode_BMOA); }

    public Algo_CorporateBuyback_BMOA Algo_CorporateBuyback_BMOA
    {
        get
        {
            Algo_CorporateBuyback_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_CorporateBuyback_BMOA val) { Algo_CorporateBuyback_BMOA = val; }
    public Algo_CorporateBuyback_BMOA Get(Algo_CorporateBuyback_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_CorporateBuyback_BMOA val) { return IsSetAlgo_CorporateBuyback_BMOA(); }
    public bool IsSetAlgo_CorporateBuyback_BMOA() { return IsSetField(Tags.Algo_CorporateBuyback_BMOA); }

    public Algo_EndTime_BMOA Algo_EndTime_BMOA
    {
        get
        {
            Algo_EndTime_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_EndTime_BMOA val) { Algo_EndTime_BMOA = val; }
    public Algo_EndTime_BMOA Get(Algo_EndTime_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_EndTime_BMOA val) { return IsSetAlgo_EndTime_BMOA(); }
    public bool IsSetAlgo_EndTime_BMOA() { return IsSetField(Tags.Algo_EndTime_BMOA); }

    public Algo_InterlistedRouting_BMOA Algo_InterlistedRouting_BMOA
    {
        get
        {
            Algo_InterlistedRouting_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_InterlistedRouting_BMOA val) { Algo_InterlistedRouting_BMOA = val; }
    public Algo_InterlistedRouting_BMOA Get(Algo_InterlistedRouting_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_InterlistedRouting_BMOA val) { return IsSetAlgo_InterlistedRouting_BMOA(); }
    public bool IsSetAlgo_InterlistedRouting_BMOA() { return IsSetField(Tags.Algo_InterlistedRouting_BMOA); }

    public Algo_IWouldDarkMinExecQty_BMOA Algo_IWouldDarkMinExecQty_BMOA
    {
        get
        {
            Algo_IWouldDarkMinExecQty_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWouldDarkMinExecQty_BMOA val) { Algo_IWouldDarkMinExecQty_BMOA = val; }
    public Algo_IWouldDarkMinExecQty_BMOA Get(Algo_IWouldDarkMinExecQty_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_IWouldDarkMinExecQty_BMOA val) { return IsSetAlgo_IWouldDarkMinExecQty_BMOA(); }
    public bool IsSetAlgo_IWouldDarkMinExecQty_BMOA() { return IsSetField(Tags.Algo_IWouldDarkMinExecQty_BMOA); }

    public Algo_IWouldDarkPct_BMOA Algo_IWouldDarkPct_BMOA
    {
        get
        {
            Algo_IWouldDarkPct_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWouldDarkPct_BMOA val) { Algo_IWouldDarkPct_BMOA = val; }
    public Algo_IWouldDarkPct_BMOA Get(Algo_IWouldDarkPct_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_IWouldDarkPct_BMOA val) { return IsSetAlgo_IWouldDarkPct_BMOA(); }
    public bool IsSetAlgo_IWouldDarkPct_BMOA() { return IsSetField(Tags.Algo_IWouldDarkPct_BMOA); }

    public Algo_IWouldDarkPrice_BMOA Algo_IWouldDarkPrice_BMOA
    {
        get
        {
            Algo_IWouldDarkPrice_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWouldDarkPrice_BMOA val) { Algo_IWouldDarkPrice_BMOA = val; }
    public Algo_IWouldDarkPrice_BMOA Get(Algo_IWouldDarkPrice_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_IWouldDarkPrice_BMOA val) { return IsSetAlgo_IWouldDarkPrice_BMOA(); }
    public bool IsSetAlgo_IWouldDarkPrice_BMOA() { return IsSetField(Tags.Algo_IWouldDarkPrice_BMOA); }

    public Algo_IWouldPrice_BMOA Algo_IWouldPrice_BMOA
    {
        get
        {
            Algo_IWouldPrice_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWouldPrice_BMOA val) { Algo_IWouldPrice_BMOA = val; }
    public Algo_IWouldPrice_BMOA Get(Algo_IWouldPrice_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_IWouldPrice_BMOA val) { return IsSetAlgo_IWouldPrice_BMOA(); }
    public bool IsSetAlgo_IWouldPrice_BMOA() { return IsSetField(Tags.Algo_IWouldPrice_BMOA); }

    public Algo_IWouldPriceType_BMOA Algo_IWouldPriceType_BMOA
    {
        get
        {
            Algo_IWouldPriceType_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWouldPriceType_BMOA val) { Algo_IWouldPriceType_BMOA = val; }
    public Algo_IWouldPriceType_BMOA Get(Algo_IWouldPriceType_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_IWouldPriceType_BMOA val) { return IsSetAlgo_IWouldPriceType_BMOA(); }
    public bool IsSetAlgo_IWouldPriceType_BMOA() { return IsSetField(Tags.Algo_IWouldPriceType_BMOA); }

    public Algo_IWouldSize_BMOA Algo_IWouldSize_BMOA
    {
        get
        {
            Algo_IWouldSize_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWouldSize_BMOA val) { Algo_IWouldSize_BMOA = val; }
    public Algo_IWouldSize_BMOA Get(Algo_IWouldSize_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_IWouldSize_BMOA val) { return IsSetAlgo_IWouldSize_BMOA(); }
    public bool IsSetAlgo_IWouldSize_BMOA() { return IsSetField(Tags.Algo_IWouldSize_BMOA); }

    public Algo_IWouldSizeType_BMOA Algo_IWouldSizeType_BMOA
    {
        get
        {
            Algo_IWouldSizeType_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_IWouldSizeType_BMOA val) { Algo_IWouldSizeType_BMOA = val; }
    public Algo_IWouldSizeType_BMOA Get(Algo_IWouldSizeType_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_IWouldSizeType_BMOA val) { return IsSetAlgo_IWouldSizeType_BMOA(); }
    public bool IsSetAlgo_IWouldSizeType_BMOA() { return IsSetField(Tags.Algo_IWouldSizeType_BMOA); }

    public Algo_LowerBandPrice_BMOA Algo_LowerBandPrice_BMOA
    {
        get
        {
            Algo_LowerBandPrice_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_LowerBandPrice_BMOA val) { Algo_LowerBandPrice_BMOA = val; }
    public Algo_LowerBandPrice_BMOA Get(Algo_LowerBandPrice_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_LowerBandPrice_BMOA val) { return IsSetAlgo_LowerBandPrice_BMOA(); }
    public bool IsSetAlgo_LowerBandPrice_BMOA() { return IsSetField(Tags.Algo_LowerBandPrice_BMOA); }

    public Algo_LowerBandTargetPercentVolume_BMOA Algo_LowerBandTargetPercentVolume_BMOA
    {
        get
        {
            Algo_LowerBandTargetPercentVolume_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_LowerBandTargetPercentVolume_BMOA val) { Algo_LowerBandTargetPercentVolume_BMOA = val; }
    public Algo_LowerBandTargetPercentVolume_BMOA Get(Algo_LowerBandTargetPercentVolume_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_LowerBandTargetPercentVolume_BMOA val) { return IsSetAlgo_LowerBandTargetPercentVolume_BMOA(); }
    public bool IsSetAlgo_LowerBandTargetPercentVolume_BMOA() { return IsSetField(Tags.Algo_LowerBandTargetPercentVolume_BMOA); }

    public Algo_MaxPercentageVolume_BMOA Algo_MaxPercentageVolume_BMOA
    {
        get
        {
            Algo_MaxPercentageVolume_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_MaxPercentageVolume_BMOA val) { Algo_MaxPercentageVolume_BMOA = val; }
    public Algo_MaxPercentageVolume_BMOA Get(Algo_MaxPercentageVolume_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_MaxPercentageVolume_BMOA val) { return IsSetAlgo_MaxPercentageVolume_BMOA(); }
    public bool IsSetAlgo_MaxPercentageVolume_BMOA() { return IsSetField(Tags.Algo_MaxPercentageVolume_BMOA); }

    public Algo_MinPercentageVolume_BMOA Algo_MinPercentageVolume_BMOA
    {
        get
        {
            Algo_MinPercentageVolume_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_MinPercentageVolume_BMOA val) { Algo_MinPercentageVolume_BMOA = val; }
    public Algo_MinPercentageVolume_BMOA Get(Algo_MinPercentageVolume_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_MinPercentageVolume_BMOA val) { return IsSetAlgo_MinPercentageVolume_BMOA(); }
    public bool IsSetAlgo_MinPercentageVolume_BMOA() { return IsSetField(Tags.Algo_MinPercentageVolume_BMOA); }

    public Algo_OpeningAuctionParticipation_BMOA Algo_OpeningAuctionParticipation_BMOA
    {
        get
        {
            Algo_OpeningAuctionParticipation_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_OpeningAuctionParticipation_BMOA val) { Algo_OpeningAuctionParticipation_BMOA = val; }
    public Algo_OpeningAuctionParticipation_BMOA Get(Algo_OpeningAuctionParticipation_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_OpeningAuctionParticipation_BMOA val) { return IsSetAlgo_OpeningAuctionParticipation_BMOA(); }
    public bool IsSetAlgo_OpeningAuctionParticipation_BMOA() { return IsSetField(Tags.Algo_OpeningAuctionParticipation_BMOA); }

    public Algo_RelativeBenchmark_BMOA Algo_RelativeBenchmark_BMOA
    {
        get
        {
            Algo_RelativeBenchmark_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RelativeBenchmark_BMOA val) { Algo_RelativeBenchmark_BMOA = val; }
    public Algo_RelativeBenchmark_BMOA Get(Algo_RelativeBenchmark_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_RelativeBenchmark_BMOA val) { return IsSetAlgo_RelativeBenchmark_BMOA(); }
    public bool IsSetAlgo_RelativeBenchmark_BMOA() { return IsSetField(Tags.Algo_RelativeBenchmark_BMOA); }

    public Algo_RelativeLimitPct_BMOA Algo_RelativeLimitPct_BMOA
    {
        get
        {
            Algo_RelativeLimitPct_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RelativeLimitPct_BMOA val) { Algo_RelativeLimitPct_BMOA = val; }
    public Algo_RelativeLimitPct_BMOA Get(Algo_RelativeLimitPct_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_RelativeLimitPct_BMOA val) { return IsSetAlgo_RelativeLimitPct_BMOA(); }
    public bool IsSetAlgo_RelativeLimitPct_BMOA() { return IsSetField(Tags.Algo_RelativeLimitPct_BMOA); }

    public Algo_RelativePriceType_BMOA Algo_RelativePriceType_BMOA
    {
        get
        {
            Algo_RelativePriceType_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RelativePriceType_BMOA val) { Algo_RelativePriceType_BMOA = val; }
    public Algo_RelativePriceType_BMOA Get(Algo_RelativePriceType_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_RelativePriceType_BMOA val) { return IsSetAlgo_RelativePriceType_BMOA(); }
    public bool IsSetAlgo_RelativePriceType_BMOA() { return IsSetField(Tags.Algo_RelativePriceType_BMOA); }

    public Algo_RestingPegDifference_BMOA Algo_RestingPegDifference_BMOA
    {
        get
        {
            Algo_RestingPegDifference_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RestingPegDifference_BMOA val) { Algo_RestingPegDifference_BMOA = val; }
    public Algo_RestingPegDifference_BMOA Get(Algo_RestingPegDifference_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_RestingPegDifference_BMOA val) { return IsSetAlgo_RestingPegDifference_BMOA(); }
    public bool IsSetAlgo_RestingPegDifference_BMOA() { return IsSetField(Tags.Algo_RestingPegDifference_BMOA); }

    public Algo_RestingPegInstruction_BMOA Algo_RestingPegInstruction_BMOA
    {
        get
        {
            Algo_RestingPegInstruction_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_RestingPegInstruction_BMOA val) { Algo_RestingPegInstruction_BMOA = val; }
    public Algo_RestingPegInstruction_BMOA Get(Algo_RestingPegInstruction_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_RestingPegInstruction_BMOA val) { return IsSetAlgo_RestingPegInstruction_BMOA(); }
    public bool IsSetAlgo_RestingPegInstruction_BMOA() { return IsSetField(Tags.Algo_RestingPegInstruction_BMOA); }

    public Algo_StartTime_BMOA Algo_StartTime_BMOA
    {
        get
        {
            Algo_StartTime_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_StartTime_BMOA val) { Algo_StartTime_BMOA = val; }
    public Algo_StartTime_BMOA Get(Algo_StartTime_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_StartTime_BMOA val) { return IsSetAlgo_StartTime_BMOA(); }
    public bool IsSetAlgo_StartTime_BMOA() { return IsSetField(Tags.Algo_StartTime_BMOA); }

    public Algo_Strategy_BMOA Algo_Strategy_BMOA
    {
        get
        {
            Algo_Strategy_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Strategy_BMOA val) { Algo_Strategy_BMOA = val; }
    public Algo_Strategy_BMOA Get(Algo_Strategy_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_Strategy_BMOA val) { return IsSetAlgo_Strategy_BMOA(); }
    public bool IsSetAlgo_Strategy_BMOA() { return IsSetField(Tags.Algo_Strategy_BMOA); }

    public Algo_StrategyConfig_BMOA Algo_StrategyConfig_BMOA
    {
        get
        {
            Algo_StrategyConfig_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_StrategyConfig_BMOA val) { Algo_StrategyConfig_BMOA = val; }
    public Algo_StrategyConfig_BMOA Get(Algo_StrategyConfig_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_StrategyConfig_BMOA val) { return IsSetAlgo_StrategyConfig_BMOA(); }
    public bool IsSetAlgo_StrategyConfig_BMOA() { return IsSetField(Tags.Algo_StrategyConfig_BMOA); }

    public Algo_StrategyIdentifierTag_BMOA Algo_StrategyIdentifierTag_BMOA
    {
        get
        {
            Algo_StrategyIdentifierTag_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_StrategyIdentifierTag_BMOA val) { Algo_StrategyIdentifierTag_BMOA = val; }
    public Algo_StrategyIdentifierTag_BMOA Get(Algo_StrategyIdentifierTag_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_StrategyIdentifierTag_BMOA val) { return IsSetAlgo_StrategyIdentifierTag_BMOA(); }
    public bool IsSetAlgo_StrategyIdentifierTag_BMOA() { return IsSetField(Tags.Algo_StrategyIdentifierTag_BMOA); }

    public Algo_SweepBehaviour_BMOA Algo_SweepBehaviour_BMOA
    {
        get
        {
            Algo_SweepBehaviour_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_SweepBehaviour_BMOA val) { Algo_SweepBehaviour_BMOA = val; }
    public Algo_SweepBehaviour_BMOA Get(Algo_SweepBehaviour_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_SweepBehaviour_BMOA val) { return IsSetAlgo_SweepBehaviour_BMOA(); }
    public bool IsSetAlgo_SweepBehaviour_BMOA() { return IsSetField(Tags.Algo_SweepBehaviour_BMOA); }

    public Algo_SweepTriggerSize_BMOA Algo_SweepTriggerSize_BMOA
    {
        get
        {
            Algo_SweepTriggerSize_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_SweepTriggerSize_BMOA val) { Algo_SweepTriggerSize_BMOA = val; }
    public Algo_SweepTriggerSize_BMOA Get(Algo_SweepTriggerSize_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_SweepTriggerSize_BMOA val) { return IsSetAlgo_SweepTriggerSize_BMOA(); }
    public bool IsSetAlgo_SweepTriggerSize_BMOA() { return IsSetField(Tags.Algo_SweepTriggerSize_BMOA); }

    public Algo_TargetPercentForAuction_BMOA Algo_TargetPercentForAuction_BMOA
    {
        get
        {
            Algo_TargetPercentForAuction_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_TargetPercentForAuction_BMOA val) { Algo_TargetPercentForAuction_BMOA = val; }
    public Algo_TargetPercentForAuction_BMOA Get(Algo_TargetPercentForAuction_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_TargetPercentForAuction_BMOA val) { return IsSetAlgo_TargetPercentForAuction_BMOA(); }
    public bool IsSetAlgo_TargetPercentForAuction_BMOA() { return IsSetField(Tags.Algo_TargetPercentForAuction_BMOA); }

    public Algo_TargetPercentVolume_BMOA Algo_TargetPercentVolume_BMOA
    {
        get
        {
            Algo_TargetPercentVolume_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_TargetPercentVolume_BMOA val) { Algo_TargetPercentVolume_BMOA = val; }
    public Algo_TargetPercentVolume_BMOA Get(Algo_TargetPercentVolume_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_TargetPercentVolume_BMOA val) { return IsSetAlgo_TargetPercentVolume_BMOA(); }
    public bool IsSetAlgo_TargetPercentVolume_BMOA() { return IsSetField(Tags.Algo_TargetPercentVolume_BMOA); }

    public Algo_TrackInterlistedVolume_BMOA Algo_TrackInterlistedVolume_BMOA
    {
        get
        {
            Algo_TrackInterlistedVolume_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_TrackInterlistedVolume_BMOA val) { Algo_TrackInterlistedVolume_BMOA = val; }
    public Algo_TrackInterlistedVolume_BMOA Get(Algo_TrackInterlistedVolume_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_TrackInterlistedVolume_BMOA val) { return IsSetAlgo_TrackInterlistedVolume_BMOA(); }
    public bool IsSetAlgo_TrackInterlistedVolume_BMOA() { return IsSetField(Tags.Algo_TrackInterlistedVolume_BMOA); }

    public Algo_UpperBandPrice_BMOA Algo_UpperBandPrice_BMOA
    {
        get
        {
            Algo_UpperBandPrice_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_UpperBandPrice_BMOA val) { Algo_UpperBandPrice_BMOA = val; }
    public Algo_UpperBandPrice_BMOA Get(Algo_UpperBandPrice_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_UpperBandPrice_BMOA val) { return IsSetAlgo_UpperBandPrice_BMOA(); }
    public bool IsSetAlgo_UpperBandPrice_BMOA() { return IsSetField(Tags.Algo_UpperBandPrice_BMOA); }

    public Algo_UpperBandTargetPercentVolume_BMOA Algo_UpperBandTargetPercentVolume_BMOA
    {
        get
        {
            Algo_UpperBandTargetPercentVolume_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_UpperBandTargetPercentVolume_BMOA val) { Algo_UpperBandTargetPercentVolume_BMOA = val; }
    public Algo_UpperBandTargetPercentVolume_BMOA Get(Algo_UpperBandTargetPercentVolume_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_UpperBandTargetPercentVolume_BMOA val) { return IsSetAlgo_UpperBandTargetPercentVolume_BMOA(); }
    public bool IsSetAlgo_UpperBandTargetPercentVolume_BMOA() { return IsSetField(Tags.Algo_UpperBandTargetPercentVolume_BMOA); }

    public Algo_Urgency_BMOA Algo_Urgency_BMOA
    {
        get
        {
            Algo_Urgency_BMOA val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Algo_Urgency_BMOA val) { Algo_Urgency_BMOA = val; }
    public Algo_Urgency_BMOA Get(Algo_Urgency_BMOA val) { GetField(val); return val; }
    public bool IsSet(Algo_Urgency_BMOA val) { return IsSetAlgo_Urgency_BMOA(); }
    public bool IsSetAlgo_Urgency_BMOA() { return IsSetField(Tags.Algo_Urgency_BMOA); }

    public PartyIDOrderOriginationFirm PartyIDOrderOriginationFirm
    {
        get
        {
            PartyIDOrderOriginationFirm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PartyIDOrderOriginationFirm val) { PartyIDOrderOriginationFirm = val; }
    public PartyIDOrderOriginationFirm Get(PartyIDOrderOriginationFirm val) { GetField(val); return val; }
    public bool IsSet(PartyIDOrderOriginationFirm val) { return IsSetPartyIDOrderOriginationFirm(); }
    public bool IsSetPartyIDOrderOriginationFirm() { return IsSetField(Tags.PartyIDOrderOriginationFirm); }

    public OrderAttributeTypes OrderAttributeTypes
    {
        get
        {
            OrderAttributeTypes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderAttributeTypes val) { OrderAttributeTypes = val; }
    public OrderAttributeTypes Get(OrderAttributeTypes val) { GetField(val); return val; }
    public bool IsSet(OrderAttributeTypes val) { return IsSetOrderAttributeTypes(); }
    public bool IsSetOrderAttributeTypes() { return IsSetField(Tags.OrderAttributeTypes); }

    public OrderCapacity OrderCapacity
    {
        get
        {
            OrderCapacity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderCapacity val) { OrderCapacity = val; }
    public OrderCapacity Get(OrderCapacity val) { GetField(val); return val; }
    public bool IsSet(OrderCapacity val) { return IsSetOrderCapacity(); }
    public bool IsSetOrderCapacity() { return IsSetField(Tags.OrderCapacity); }

    public ExDestinationType ExDestinationType
    {
        get
        {
            ExDestinationType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExDestinationType val) { ExDestinationType = val; }
    public ExDestinationType Get(ExDestinationType val) { GetField(val); return val; }
    public bool IsSet(ExDestinationType val) { return IsSetExDestinationType(); }
    public bool IsSetExDestinationType() { return IsSetField(Tags.ExDestinationType); }

    public class NoAllocsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocShares, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocShares, 0};

        public NoAllocsGroup()
          : base(Tags.NoAllocs, Tags.AllocAccount, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoAllocsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public AllocAccount AllocAccount
        {
            get
            {
                AllocAccount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocAccount val) { AllocAccount = val; }
        public AllocAccount Get(AllocAccount val) { GetField(val); return val; }
        public bool IsSet(AllocAccount val) { return IsSetAllocAccount(); }
        public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }

        public AllocShares AllocShares
        {
            get
            {
                AllocShares val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocShares val) { AllocShares = val; }
        public AllocShares Get(AllocShares val) { GetField(val); return val; }
        public bool IsSet(AllocShares val) { return IsSetAllocShares(); }
        public bool IsSetAllocShares() { return IsSetField(Tags.AllocShares); }
    }

    public class NoTradingSessionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TradingSessionID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.TradingSessionID, 0};

        public NoTradingSessionsGroup()
          : base(Tags.NoTradingSessions, Tags.TradingSessionID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTradingSessionsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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
    }
}
