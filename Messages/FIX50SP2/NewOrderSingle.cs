// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class NewOrderSingle : Message
{
    public const string MsgType = "D";

    public NewOrderSingle() : base()
    {
        Header.SetField(new MsgType("D"));
    }

    public NewOrderSingle(
            ClOrdID aClOrdID,
            Side aSide,
            TransactTime aTransactTime,
            OrdType aOrdType
        ) : this()
    {
        ClOrdID = aClOrdID;
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

    public SecondaryClOrdID SecondaryClOrdID
    {
        get
        {
            SecondaryClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryClOrdID val) { SecondaryClOrdID = val; }
    public SecondaryClOrdID Get(SecondaryClOrdID val) { GetField(val); return val; }
    public bool IsSet(SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }
    public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

    public ClOrdLinkID ClOrdLinkID
    {
        get
        {
            ClOrdLinkID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdLinkID val) { ClOrdLinkID = val; }
    public ClOrdLinkID Get(ClOrdLinkID val) { GetField(val); return val; }
    public bool IsSet(ClOrdLinkID val) { return IsSetClOrdLinkID(); }
    public bool IsSetClOrdLinkID() { return IsSetField(Tags.ClOrdLinkID); }

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

    public TradeOriginationDate TradeOriginationDate
    {
        get
        {
            TradeOriginationDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeOriginationDate val) { TradeOriginationDate = val; }
    public TradeOriginationDate Get(TradeOriginationDate val) { GetField(val); return val; }
    public bool IsSet(TradeOriginationDate val) { return IsSetTradeOriginationDate(); }
    public bool IsSetTradeOriginationDate() { return IsSetField(Tags.TradeOriginationDate); }

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

    public AccountType AccountType
    {
        get
        {
            AccountType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AccountType val) { AccountType = val; }
    public AccountType Get(AccountType val) { GetField(val); return val; }
    public bool IsSet(AccountType val) { return IsSetAccountType(); }
    public bool IsSetAccountType() { return IsSetField(Tags.AccountType); }

    public DayBookingInst DayBookingInst
    {
        get
        {
            DayBookingInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayBookingInst val) { DayBookingInst = val; }
    public DayBookingInst Get(DayBookingInst val) { GetField(val); return val; }
    public bool IsSet(DayBookingInst val) { return IsSetDayBookingInst(); }
    public bool IsSetDayBookingInst() { return IsSetField(Tags.DayBookingInst); }

    public BookingUnit BookingUnit
    {
        get
        {
            BookingUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BookingUnit val) { BookingUnit = val; }
    public BookingUnit Get(BookingUnit val) { GetField(val); return val; }
    public bool IsSet(BookingUnit val) { return IsSetBookingUnit(); }
    public bool IsSetBookingUnit() { return IsSetField(Tags.BookingUnit); }

    public PreallocMethod PreallocMethod
    {
        get
        {
            PreallocMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PreallocMethod val) { PreallocMethod = val; }
    public PreallocMethod Get(PreallocMethod val) { GetField(val); return val; }
    public bool IsSet(PreallocMethod val) { return IsSetPreallocMethod(); }
    public bool IsSetPreallocMethod() { return IsSetField(Tags.PreallocMethod); }

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

    public SettlType SettlType
    {
        get
        {
            SettlType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlType val) { SettlType = val; }
    public SettlType Get(SettlType val) { GetField(val); return val; }
    public bool IsSet(SettlType val) { return IsSetSettlType(); }
    public bool IsSetSettlType() { return IsSetField(Tags.SettlType); }

    public SettlDate SettlDate
    {
        get
        {
            SettlDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlDate val) { SettlDate = val; }
    public SettlDate Get(SettlDate val) { GetField(val); return val; }
    public bool IsSet(SettlDate val) { return IsSetSettlDate(); }
    public bool IsSetSettlDate() { return IsSetField(Tags.SettlDate); }

    public CashMargin CashMargin
    {
        get
        {
            CashMargin val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashMargin val) { CashMargin = val; }
    public CashMargin Get(CashMargin val) { GetField(val); return val; }
    public bool IsSet(CashMargin val) { return IsSetCashMargin(); }
    public bool IsSetCashMargin() { return IsSetField(Tags.CashMargin); }

    public ClearingFeeIndicator ClearingFeeIndicator
    {
        get
        {
            ClearingFeeIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClearingFeeIndicator val) { ClearingFeeIndicator = val; }
    public ClearingFeeIndicator Get(ClearingFeeIndicator val) { GetField(val); return val; }
    public bool IsSet(ClearingFeeIndicator val) { return IsSetClearingFeeIndicator(); }
    public bool IsSetClearingFeeIndicator() { return IsSetField(Tags.ClearingFeeIndicator); }

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

    public SecurityIDSource SecurityIDSource
    {
        get
        {
            SecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityIDSource val) { SecurityIDSource = val; }
    public SecurityIDSource Get(SecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(SecurityIDSource val) { return IsSetSecurityIDSource(); }
    public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }

    public NoSecurityAltID NoSecurityAltID
    {
        get
        {
            NoSecurityAltID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSecurityAltID val) { NoSecurityAltID = val; }
    public NoSecurityAltID Get(NoSecurityAltID val) { GetField(val); return val; }
    public bool IsSet(NoSecurityAltID val) { return IsSetNoSecurityAltID(); }
    public bool IsSetNoSecurityAltID() { return IsSetField(Tags.NoSecurityAltID); }

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

    public CFICode CFICode
    {
        get
        {
            CFICode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CFICode val) { CFICode = val; }
    public CFICode Get(CFICode val) { GetField(val); return val; }
    public bool IsSet(CFICode val) { return IsSetCFICode(); }
    public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

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

    public SecuritySubType SecuritySubType
    {
        get
        {
            SecuritySubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySubType val) { SecuritySubType = val; }
    public SecuritySubType Get(SecuritySubType val) { GetField(val); return val; }
    public bool IsSet(SecuritySubType val) { return IsSetSecuritySubType(); }
    public bool IsSetSecuritySubType() { return IsSetField(Tags.SecuritySubType); }

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

    public MaturityDate MaturityDate
    {
        get
        {
            MaturityDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityDate val) { MaturityDate = val; }
    public MaturityDate Get(MaturityDate val) { GetField(val); return val; }
    public bool IsSet(MaturityDate val) { return IsSetMaturityDate(); }
    public bool IsSetMaturityDate() { return IsSetField(Tags.MaturityDate); }

    public CouponPaymentDate CouponPaymentDate
    {
        get
        {
            CouponPaymentDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponPaymentDate val) { CouponPaymentDate = val; }
    public CouponPaymentDate Get(CouponPaymentDate val) { GetField(val); return val; }
    public bool IsSet(CouponPaymentDate val) { return IsSetCouponPaymentDate(); }
    public bool IsSetCouponPaymentDate() { return IsSetField(Tags.CouponPaymentDate); }

    public IssueDate IssueDate
    {
        get
        {
            IssueDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IssueDate val) { IssueDate = val; }
    public IssueDate Get(IssueDate val) { GetField(val); return val; }
    public bool IsSet(IssueDate val) { return IsSetIssueDate(); }
    public bool IsSetIssueDate() { return IsSetField(Tags.IssueDate); }

    public RepoCollateralSecurityType RepoCollateralSecurityType
    {
        get
        {
            RepoCollateralSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepoCollateralSecurityType val) { RepoCollateralSecurityType = val; }
    public RepoCollateralSecurityType Get(RepoCollateralSecurityType val) { GetField(val); return val; }
    public bool IsSet(RepoCollateralSecurityType val) { return IsSetRepoCollateralSecurityType(); }
    public bool IsSetRepoCollateralSecurityType() { return IsSetField(Tags.RepoCollateralSecurityType); }

    public RepurchaseTerm RepurchaseTerm
    {
        get
        {
            RepurchaseTerm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepurchaseTerm val) { RepurchaseTerm = val; }
    public RepurchaseTerm Get(RepurchaseTerm val) { GetField(val); return val; }
    public bool IsSet(RepurchaseTerm val) { return IsSetRepurchaseTerm(); }
    public bool IsSetRepurchaseTerm() { return IsSetField(Tags.RepurchaseTerm); }

    public RepurchaseRate RepurchaseRate
    {
        get
        {
            RepurchaseRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepurchaseRate val) { RepurchaseRate = val; }
    public RepurchaseRate Get(RepurchaseRate val) { GetField(val); return val; }
    public bool IsSet(RepurchaseRate val) { return IsSetRepurchaseRate(); }
    public bool IsSetRepurchaseRate() { return IsSetField(Tags.RepurchaseRate); }

    public Factor Factor
    {
        get
        {
            Factor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Factor val) { Factor = val; }
    public Factor Get(Factor val) { GetField(val); return val; }
    public bool IsSet(Factor val) { return IsSetFactor(); }
    public bool IsSetFactor() { return IsSetField(Tags.Factor); }

    public CreditRating CreditRating
    {
        get
        {
            CreditRating val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CreditRating val) { CreditRating = val; }
    public CreditRating Get(CreditRating val) { GetField(val); return val; }
    public bool IsSet(CreditRating val) { return IsSetCreditRating(); }
    public bool IsSetCreditRating() { return IsSetField(Tags.CreditRating); }

    public InstrRegistry InstrRegistry
    {
        get
        {
            InstrRegistry val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InstrRegistry val) { InstrRegistry = val; }
    public InstrRegistry Get(InstrRegistry val) { GetField(val); return val; }
    public bool IsSet(InstrRegistry val) { return IsSetInstrRegistry(); }
    public bool IsSetInstrRegistry() { return IsSetField(Tags.InstrRegistry); }

    public CountryOfIssue CountryOfIssue
    {
        get
        {
            CountryOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CountryOfIssue val) { CountryOfIssue = val; }
    public CountryOfIssue Get(CountryOfIssue val) { GetField(val); return val; }
    public bool IsSet(CountryOfIssue val) { return IsSetCountryOfIssue(); }
    public bool IsSetCountryOfIssue() { return IsSetField(Tags.CountryOfIssue); }

    public StateOrProvinceOfIssue StateOrProvinceOfIssue
    {
        get
        {
            StateOrProvinceOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StateOrProvinceOfIssue val) { StateOrProvinceOfIssue = val; }
    public StateOrProvinceOfIssue Get(StateOrProvinceOfIssue val) { GetField(val); return val; }
    public bool IsSet(StateOrProvinceOfIssue val) { return IsSetStateOrProvinceOfIssue(); }
    public bool IsSetStateOrProvinceOfIssue() { return IsSetField(Tags.StateOrProvinceOfIssue); }

    public LocaleOfIssue LocaleOfIssue
    {
        get
        {
            LocaleOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LocaleOfIssue val) { LocaleOfIssue = val; }
    public LocaleOfIssue Get(LocaleOfIssue val) { GetField(val); return val; }
    public bool IsSet(LocaleOfIssue val) { return IsSetLocaleOfIssue(); }
    public bool IsSetLocaleOfIssue() { return IsSetField(Tags.LocaleOfIssue); }

    public RedemptionDate RedemptionDate
    {
        get
        {
            RedemptionDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RedemptionDate val) { RedemptionDate = val; }
    public RedemptionDate Get(RedemptionDate val) { GetField(val); return val; }
    public bool IsSet(RedemptionDate val) { return IsSetRedemptionDate(); }
    public bool IsSetRedemptionDate() { return IsSetField(Tags.RedemptionDate); }

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

    public StrikeCurrency StrikeCurrency
    {
        get
        {
            StrikeCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeCurrency val) { StrikeCurrency = val; }
    public StrikeCurrency Get(StrikeCurrency val) { GetField(val); return val; }
    public bool IsSet(StrikeCurrency val) { return IsSetStrikeCurrency(); }
    public bool IsSetStrikeCurrency() { return IsSetField(Tags.StrikeCurrency); }

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

    public Pool Pool
    {
        get
        {
            Pool val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Pool val) { Pool = val; }
    public Pool Get(Pool val) { GetField(val); return val; }
    public bool IsSet(Pool val) { return IsSetPool(); }
    public bool IsSetPool() { return IsSetField(Tags.Pool); }

    public ContractSettlMonth ContractSettlMonth
    {
        get
        {
            ContractSettlMonth val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ContractSettlMonth val) { ContractSettlMonth = val; }
    public ContractSettlMonth Get(ContractSettlMonth val) { GetField(val); return val; }
    public bool IsSet(ContractSettlMonth val) { return IsSetContractSettlMonth(); }
    public bool IsSetContractSettlMonth() { return IsSetField(Tags.ContractSettlMonth); }

    public CPProgram CPProgram
    {
        get
        {
            CPProgram val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CPProgram val) { CPProgram = val; }
    public CPProgram Get(CPProgram val) { GetField(val); return val; }
    public bool IsSet(CPProgram val) { return IsSetCPProgram(); }
    public bool IsSetCPProgram() { return IsSetField(Tags.CPProgram); }

    public CPRegType CPRegType
    {
        get
        {
            CPRegType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CPRegType val) { CPRegType = val; }
    public CPRegType Get(CPRegType val) { GetField(val); return val; }
    public bool IsSet(CPRegType val) { return IsSetCPRegType(); }
    public bool IsSetCPRegType() { return IsSetField(Tags.CPRegType); }

    public NoEvents NoEvents
    {
        get
        {
            NoEvents val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoEvents val) { NoEvents = val; }
    public NoEvents Get(NoEvents val) { GetField(val); return val; }
    public bool IsSet(NoEvents val) { return IsSetNoEvents(); }
    public bool IsSetNoEvents() { return IsSetField(Tags.NoEvents); }

    public DatedDate DatedDate
    {
        get
        {
            DatedDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DatedDate val) { DatedDate = val; }
    public DatedDate Get(DatedDate val) { GetField(val); return val; }
    public bool IsSet(DatedDate val) { return IsSetDatedDate(); }
    public bool IsSetDatedDate() { return IsSetField(Tags.DatedDate); }

    public InterestAccrualDate InterestAccrualDate
    {
        get
        {
            InterestAccrualDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterestAccrualDate val) { InterestAccrualDate = val; }
    public InterestAccrualDate Get(InterestAccrualDate val) { GetField(val); return val; }
    public bool IsSet(InterestAccrualDate val) { return IsSetInterestAccrualDate(); }
    public bool IsSetInterestAccrualDate() { return IsSetField(Tags.InterestAccrualDate); }

    public Fields.SecurityStatus SecurityStatus
    {
        get
        {
            Fields.SecurityStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Fields.SecurityStatus val) { SecurityStatus = val; }
    public Fields.SecurityStatus Get(Fields.SecurityStatus val) { GetField(val); return val; }
    public bool IsSet(Fields.SecurityStatus val) { return IsSetSecurityStatus(); }
    public bool IsSetSecurityStatus() { return IsSetField(Tags.SecurityStatus); }

    public SettleOnOpenFlag SettleOnOpenFlag
    {
        get
        {
            SettleOnOpenFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettleOnOpenFlag val) { SettleOnOpenFlag = val; }
    public SettleOnOpenFlag Get(SettleOnOpenFlag val) { GetField(val); return val; }
    public bool IsSet(SettleOnOpenFlag val) { return IsSetSettleOnOpenFlag(); }
    public bool IsSetSettleOnOpenFlag() { return IsSetField(Tags.SettleOnOpenFlag); }

    public InstrmtAssignmentMethod InstrmtAssignmentMethod
    {
        get
        {
            InstrmtAssignmentMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InstrmtAssignmentMethod val) { InstrmtAssignmentMethod = val; }
    public InstrmtAssignmentMethod Get(InstrmtAssignmentMethod val) { GetField(val); return val; }
    public bool IsSet(InstrmtAssignmentMethod val) { return IsSetInstrmtAssignmentMethod(); }
    public bool IsSetInstrmtAssignmentMethod() { return IsSetField(Tags.InstrmtAssignmentMethod); }

    public StrikeMultiplier StrikeMultiplier
    {
        get
        {
            StrikeMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeMultiplier val) { StrikeMultiplier = val; }
    public StrikeMultiplier Get(StrikeMultiplier val) { GetField(val); return val; }
    public bool IsSet(StrikeMultiplier val) { return IsSetStrikeMultiplier(); }
    public bool IsSetStrikeMultiplier() { return IsSetField(Tags.StrikeMultiplier); }

    public StrikeValue StrikeValue
    {
        get
        {
            StrikeValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeValue val) { StrikeValue = val; }
    public StrikeValue Get(StrikeValue val) { GetField(val); return val; }
    public bool IsSet(StrikeValue val) { return IsSetStrikeValue(); }
    public bool IsSetStrikeValue() { return IsSetField(Tags.StrikeValue); }

    public MinPriceIncrement MinPriceIncrement
    {
        get
        {
            MinPriceIncrement val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinPriceIncrement val) { MinPriceIncrement = val; }
    public MinPriceIncrement Get(MinPriceIncrement val) { GetField(val); return val; }
    public bool IsSet(MinPriceIncrement val) { return IsSetMinPriceIncrement(); }
    public bool IsSetMinPriceIncrement() { return IsSetField(Tags.MinPriceIncrement); }

    public PositionLimit PositionLimit
    {
        get
        {
            PositionLimit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PositionLimit val) { PositionLimit = val; }
    public PositionLimit Get(PositionLimit val) { GetField(val); return val; }
    public bool IsSet(PositionLimit val) { return IsSetPositionLimit(); }
    public bool IsSetPositionLimit() { return IsSetField(Tags.PositionLimit); }

    public NTPositionLimit NTPositionLimit
    {
        get
        {
            NTPositionLimit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NTPositionLimit val) { NTPositionLimit = val; }
    public NTPositionLimit Get(NTPositionLimit val) { GetField(val); return val; }
    public bool IsSet(NTPositionLimit val) { return IsSetNTPositionLimit(); }
    public bool IsSetNTPositionLimit() { return IsSetField(Tags.NTPositionLimit); }

    public NoInstrumentParties NoInstrumentParties
    {
        get
        {
            NoInstrumentParties val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoInstrumentParties val) { NoInstrumentParties = val; }
    public NoInstrumentParties Get(NoInstrumentParties val) { GetField(val); return val; }
    public bool IsSet(NoInstrumentParties val) { return IsSetNoInstrumentParties(); }
    public bool IsSetNoInstrumentParties() { return IsSetField(Tags.NoInstrumentParties); }

    public UnitOfMeasure UnitOfMeasure
    {
        get
        {
            UnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnitOfMeasure val) { UnitOfMeasure = val; }
    public UnitOfMeasure Get(UnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(UnitOfMeasure val) { return IsSetUnitOfMeasure(); }
    public bool IsSetUnitOfMeasure() { return IsSetField(Tags.UnitOfMeasure); }

    public TimeUnit TimeUnit
    {
        get
        {
            TimeUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TimeUnit val) { TimeUnit = val; }
    public TimeUnit Get(TimeUnit val) { GetField(val); return val; }
    public bool IsSet(TimeUnit val) { return IsSetTimeUnit(); }
    public bool IsSetTimeUnit() { return IsSetField(Tags.TimeUnit); }

    public MaturityTime MaturityTime
    {
        get
        {
            MaturityTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityTime val) { MaturityTime = val; }
    public MaturityTime Get(MaturityTime val) { GetField(val); return val; }
    public bool IsSet(MaturityTime val) { return IsSetMaturityTime(); }
    public bool IsSetMaturityTime() { return IsSetField(Tags.MaturityTime); }

    public SecurityGroup SecurityGroup
    {
        get
        {
            SecurityGroup val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityGroup val) { SecurityGroup = val; }
    public SecurityGroup Get(SecurityGroup val) { GetField(val); return val; }
    public bool IsSet(SecurityGroup val) { return IsSetSecurityGroup(); }
    public bool IsSetSecurityGroup() { return IsSetField(Tags.SecurityGroup); }

    public MinPriceIncrementAmount MinPriceIncrementAmount
    {
        get
        {
            MinPriceIncrementAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinPriceIncrementAmount val) { MinPriceIncrementAmount = val; }
    public MinPriceIncrementAmount Get(MinPriceIncrementAmount val) { GetField(val); return val; }
    public bool IsSet(MinPriceIncrementAmount val) { return IsSetMinPriceIncrementAmount(); }
    public bool IsSetMinPriceIncrementAmount() { return IsSetField(Tags.MinPriceIncrementAmount); }

    public UnitOfMeasureQty UnitOfMeasureQty
    {
        get
        {
            UnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnitOfMeasureQty val) { UnitOfMeasureQty = val; }
    public UnitOfMeasureQty Get(UnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(UnitOfMeasureQty val) { return IsSetUnitOfMeasureQty(); }
    public bool IsSetUnitOfMeasureQty() { return IsSetField(Tags.UnitOfMeasureQty); }

    public SecurityXMLLen SecurityXMLLen
    {
        get
        {
            SecurityXMLLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityXMLLen val) { SecurityXMLLen = val; }
    public SecurityXMLLen Get(SecurityXMLLen val) { GetField(val); return val; }
    public bool IsSet(SecurityXMLLen val) { return IsSetSecurityXMLLen(); }
    public bool IsSetSecurityXMLLen() { return IsSetField(Tags.SecurityXMLLen); }

    public SecurityXML SecurityXML
    {
        get
        {
            SecurityXML val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityXML val) { SecurityXML = val; }
    public SecurityXML Get(SecurityXML val) { GetField(val); return val; }
    public bool IsSet(SecurityXML val) { return IsSetSecurityXML(); }
    public bool IsSetSecurityXML() { return IsSetField(Tags.SecurityXML); }

    public SecurityXMLSchema SecurityXMLSchema
    {
        get
        {
            SecurityXMLSchema val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityXMLSchema val) { SecurityXMLSchema = val; }
    public SecurityXMLSchema Get(SecurityXMLSchema val) { GetField(val); return val; }
    public bool IsSet(SecurityXMLSchema val) { return IsSetSecurityXMLSchema(); }
    public bool IsSetSecurityXMLSchema() { return IsSetField(Tags.SecurityXMLSchema); }

    public ProductComplex ProductComplex
    {
        get
        {
            ProductComplex val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ProductComplex val) { ProductComplex = val; }
    public ProductComplex Get(ProductComplex val) { GetField(val); return val; }
    public bool IsSet(ProductComplex val) { return IsSetProductComplex(); }
    public bool IsSetProductComplex() { return IsSetField(Tags.ProductComplex); }

    public PriceUnitOfMeasure PriceUnitOfMeasure
    {
        get
        {
            PriceUnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceUnitOfMeasure val) { PriceUnitOfMeasure = val; }
    public PriceUnitOfMeasure Get(PriceUnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(PriceUnitOfMeasure val) { return IsSetPriceUnitOfMeasure(); }
    public bool IsSetPriceUnitOfMeasure() { return IsSetField(Tags.PriceUnitOfMeasure); }

    public PriceUnitOfMeasureQty PriceUnitOfMeasureQty
    {
        get
        {
            PriceUnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceUnitOfMeasureQty val) { PriceUnitOfMeasureQty = val; }
    public PriceUnitOfMeasureQty Get(PriceUnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(PriceUnitOfMeasureQty val) { return IsSetPriceUnitOfMeasureQty(); }
    public bool IsSetPriceUnitOfMeasureQty() { return IsSetField(Tags.PriceUnitOfMeasureQty); }

    public SettlMethod SettlMethod
    {
        get
        {
            SettlMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlMethod val) { SettlMethod = val; }
    public SettlMethod Get(SettlMethod val) { GetField(val); return val; }
    public bool IsSet(SettlMethod val) { return IsSetSettlMethod(); }
    public bool IsSetSettlMethod() { return IsSetField(Tags.SettlMethod); }

    public ExerciseStyle ExerciseStyle
    {
        get
        {
            ExerciseStyle val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExerciseStyle val) { ExerciseStyle = val; }
    public ExerciseStyle Get(ExerciseStyle val) { GetField(val); return val; }
    public bool IsSet(ExerciseStyle val) { return IsSetExerciseStyle(); }
    public bool IsSetExerciseStyle() { return IsSetField(Tags.ExerciseStyle); }

    public OptPayoutAmount OptPayoutAmount
    {
        get
        {
            OptPayoutAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptPayoutAmount val) { OptPayoutAmount = val; }
    public OptPayoutAmount Get(OptPayoutAmount val) { GetField(val); return val; }
    public bool IsSet(OptPayoutAmount val) { return IsSetOptPayoutAmount(); }
    public bool IsSetOptPayoutAmount() { return IsSetField(Tags.OptPayoutAmount); }

    public PriceQuoteMethod PriceQuoteMethod
    {
        get
        {
            PriceQuoteMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceQuoteMethod val) { PriceQuoteMethod = val; }
    public PriceQuoteMethod Get(PriceQuoteMethod val) { GetField(val); return val; }
    public bool IsSet(PriceQuoteMethod val) { return IsSetPriceQuoteMethod(); }
    public bool IsSetPriceQuoteMethod() { return IsSetField(Tags.PriceQuoteMethod); }

    public ListMethod ListMethod
    {
        get
        {
            ListMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListMethod val) { ListMethod = val; }
    public ListMethod Get(ListMethod val) { GetField(val); return val; }
    public bool IsSet(ListMethod val) { return IsSetListMethod(); }
    public bool IsSetListMethod() { return IsSetField(Tags.ListMethod); }

    public CapPrice CapPrice
    {
        get
        {
            CapPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CapPrice val) { CapPrice = val; }
    public CapPrice Get(CapPrice val) { GetField(val); return val; }
    public bool IsSet(CapPrice val) { return IsSetCapPrice(); }
    public bool IsSetCapPrice() { return IsSetField(Tags.CapPrice); }

    public FloorPrice FloorPrice
    {
        get
        {
            FloorPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FloorPrice val) { FloorPrice = val; }
    public FloorPrice Get(FloorPrice val) { GetField(val); return val; }
    public bool IsSet(FloorPrice val) { return IsSetFloorPrice(); }
    public bool IsSetFloorPrice() { return IsSetField(Tags.FloorPrice); }

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

    public FlexibleIndicator FlexibleIndicator
    {
        get
        {
            FlexibleIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FlexibleIndicator val) { FlexibleIndicator = val; }
    public FlexibleIndicator Get(FlexibleIndicator val) { GetField(val); return val; }
    public bool IsSet(FlexibleIndicator val) { return IsSetFlexibleIndicator(); }
    public bool IsSetFlexibleIndicator() { return IsSetField(Tags.FlexibleIndicator); }

    public FlexProductEligibilityIndicator FlexProductEligibilityIndicator
    {
        get
        {
            FlexProductEligibilityIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FlexProductEligibilityIndicator val) { FlexProductEligibilityIndicator = val; }
    public FlexProductEligibilityIndicator Get(FlexProductEligibilityIndicator val) { GetField(val); return val; }
    public bool IsSet(FlexProductEligibilityIndicator val) { return IsSetFlexProductEligibilityIndicator(); }
    public bool IsSetFlexProductEligibilityIndicator() { return IsSetField(Tags.FlexProductEligibilityIndicator); }

    public ValuationMethod ValuationMethod
    {
        get
        {
            ValuationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ValuationMethod val) { ValuationMethod = val; }
    public ValuationMethod Get(ValuationMethod val) { GetField(val); return val; }
    public bool IsSet(ValuationMethod val) { return IsSetValuationMethod(); }
    public bool IsSetValuationMethod() { return IsSetField(Tags.ValuationMethod); }

    public ContractMultiplierUnit ContractMultiplierUnit
    {
        get
        {
            ContractMultiplierUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ContractMultiplierUnit val) { ContractMultiplierUnit = val; }
    public ContractMultiplierUnit Get(ContractMultiplierUnit val) { GetField(val); return val; }
    public bool IsSet(ContractMultiplierUnit val) { return IsSetContractMultiplierUnit(); }
    public bool IsSetContractMultiplierUnit() { return IsSetField(Tags.ContractMultiplierUnit); }

    public FlowScheduleType FlowScheduleType
    {
        get
        {
            FlowScheduleType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FlowScheduleType val) { FlowScheduleType = val; }
    public FlowScheduleType Get(FlowScheduleType val) { GetField(val); return val; }
    public bool IsSet(FlowScheduleType val) { return IsSetFlowScheduleType(); }
    public bool IsSetFlowScheduleType() { return IsSetField(Tags.FlowScheduleType); }

    public RestructuringType RestructuringType
    {
        get
        {
            RestructuringType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RestructuringType val) { RestructuringType = val; }
    public RestructuringType Get(RestructuringType val) { GetField(val); return val; }
    public bool IsSet(RestructuringType val) { return IsSetRestructuringType(); }
    public bool IsSetRestructuringType() { return IsSetField(Tags.RestructuringType); }

    public Seniority Seniority
    {
        get
        {
            Seniority val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Seniority val) { Seniority = val; }
    public Seniority Get(Seniority val) { GetField(val); return val; }
    public bool IsSet(Seniority val) { return IsSetSeniority(); }
    public bool IsSetSeniority() { return IsSetField(Tags.Seniority); }

    public NotionalPercentageOutstanding NotionalPercentageOutstanding
    {
        get
        {
            NotionalPercentageOutstanding val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NotionalPercentageOutstanding val) { NotionalPercentageOutstanding = val; }
    public NotionalPercentageOutstanding Get(NotionalPercentageOutstanding val) { GetField(val); return val; }
    public bool IsSet(NotionalPercentageOutstanding val) { return IsSetNotionalPercentageOutstanding(); }
    public bool IsSetNotionalPercentageOutstanding() { return IsSetField(Tags.NotionalPercentageOutstanding); }

    public OriginalNotionalPercentageOutstanding OriginalNotionalPercentageOutstanding
    {
        get
        {
            OriginalNotionalPercentageOutstanding val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OriginalNotionalPercentageOutstanding val) { OriginalNotionalPercentageOutstanding = val; }
    public OriginalNotionalPercentageOutstanding Get(OriginalNotionalPercentageOutstanding val) { GetField(val); return val; }
    public bool IsSet(OriginalNotionalPercentageOutstanding val) { return IsSetOriginalNotionalPercentageOutstanding(); }
    public bool IsSetOriginalNotionalPercentageOutstanding() { return IsSetField(Tags.OriginalNotionalPercentageOutstanding); }

    public AttachmentPoint AttachmentPoint
    {
        get
        {
            AttachmentPoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AttachmentPoint val) { AttachmentPoint = val; }
    public AttachmentPoint Get(AttachmentPoint val) { GetField(val); return val; }
    public bool IsSet(AttachmentPoint val) { return IsSetAttachmentPoint(); }
    public bool IsSetAttachmentPoint() { return IsSetField(Tags.AttachmentPoint); }

    public DetachmentPoint DetachmentPoint
    {
        get
        {
            DetachmentPoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DetachmentPoint val) { DetachmentPoint = val; }
    public DetachmentPoint Get(DetachmentPoint val) { GetField(val); return val; }
    public bool IsSet(DetachmentPoint val) { return IsSetDetachmentPoint(); }
    public bool IsSetDetachmentPoint() { return IsSetField(Tags.DetachmentPoint); }

    public StrikePriceDeterminationMethod StrikePriceDeterminationMethod
    {
        get
        {
            StrikePriceDeterminationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePriceDeterminationMethod val) { StrikePriceDeterminationMethod = val; }
    public StrikePriceDeterminationMethod Get(StrikePriceDeterminationMethod val) { GetField(val); return val; }
    public bool IsSet(StrikePriceDeterminationMethod val) { return IsSetStrikePriceDeterminationMethod(); }
    public bool IsSetStrikePriceDeterminationMethod() { return IsSetField(Tags.StrikePriceDeterminationMethod); }

    public StrikePriceBoundaryMethod StrikePriceBoundaryMethod
    {
        get
        {
            StrikePriceBoundaryMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePriceBoundaryMethod val) { StrikePriceBoundaryMethod = val; }
    public StrikePriceBoundaryMethod Get(StrikePriceBoundaryMethod val) { GetField(val); return val; }
    public bool IsSet(StrikePriceBoundaryMethod val) { return IsSetStrikePriceBoundaryMethod(); }
    public bool IsSetStrikePriceBoundaryMethod() { return IsSetField(Tags.StrikePriceBoundaryMethod); }

    public StrikePriceBoundaryPrecision StrikePriceBoundaryPrecision
    {
        get
        {
            StrikePriceBoundaryPrecision val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePriceBoundaryPrecision val) { StrikePriceBoundaryPrecision = val; }
    public StrikePriceBoundaryPrecision Get(StrikePriceBoundaryPrecision val) { GetField(val); return val; }
    public bool IsSet(StrikePriceBoundaryPrecision val) { return IsSetStrikePriceBoundaryPrecision(); }
    public bool IsSetStrikePriceBoundaryPrecision() { return IsSetField(Tags.StrikePriceBoundaryPrecision); }

    public UnderlyingPriceDeterminationMethod UnderlyingPriceDeterminationMethod
    {
        get
        {
            UnderlyingPriceDeterminationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPriceDeterminationMethod val) { UnderlyingPriceDeterminationMethod = val; }
    public UnderlyingPriceDeterminationMethod Get(UnderlyingPriceDeterminationMethod val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPriceDeterminationMethod val) { return IsSetUnderlyingPriceDeterminationMethod(); }
    public bool IsSetUnderlyingPriceDeterminationMethod() { return IsSetField(Tags.UnderlyingPriceDeterminationMethod); }

    public OptPayoutType OptPayoutType
    {
        get
        {
            OptPayoutType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptPayoutType val) { OptPayoutType = val; }
    public OptPayoutType Get(OptPayoutType val) { GetField(val); return val; }
    public bool IsSet(OptPayoutType val) { return IsSetOptPayoutType(); }
    public bool IsSetOptPayoutType() { return IsSetField(Tags.OptPayoutType); }

    public NoComplexEvents NoComplexEvents
    {
        get
        {
            NoComplexEvents val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoComplexEvents val) { NoComplexEvents = val; }
    public NoComplexEvents Get(NoComplexEvents val) { GetField(val); return val; }
    public bool IsSet(NoComplexEvents val) { return IsSetNoComplexEvents(); }
    public bool IsSetNoComplexEvents() { return IsSetField(Tags.NoComplexEvents); }

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

    public AssetClass AssetClass
    {
        get
        {
            AssetClass val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AssetClass val) { AssetClass = val; }
    public AssetClass Get(AssetClass val) { GetField(val); return val; }
    public bool IsSet(AssetClass val) { return IsSetAssetClass(); }
    public bool IsSetAssetClass() { return IsSetField(Tags.AssetClass); }

    public AssetSubClass AssetSubClass
    {
        get
        {
            AssetSubClass val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AssetSubClass val) { AssetSubClass = val; }
    public AssetSubClass Get(AssetSubClass val) { GetField(val); return val; }
    public bool IsSet(AssetSubClass val) { return IsSetAssetSubClass(); }
    public bool IsSetAssetSubClass() { return IsSetField(Tags.AssetSubClass); }

    public AssetType AssetType
    {
        get
        {
            AssetType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AssetType val) { AssetType = val; }
    public AssetType Get(AssetType val) { GetField(val); return val; }
    public bool IsSet(AssetType val) { return IsSetAssetType(); }
    public bool IsSetAssetType() { return IsSetField(Tags.AssetType); }

    public CouponType CouponType
    {
        get
        {
            CouponType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponType val) { CouponType = val; }
    public CouponType Get(CouponType val) { GetField(val); return val; }
    public bool IsSet(CouponType val) { return IsSetCouponType(); }
    public bool IsSetCouponType() { return IsSetField(Tags.CouponType); }

    public CouponFrequencyPeriod CouponFrequencyPeriod
    {
        get
        {
            CouponFrequencyPeriod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponFrequencyPeriod val) { CouponFrequencyPeriod = val; }
    public CouponFrequencyPeriod Get(CouponFrequencyPeriod val) { GetField(val); return val; }
    public bool IsSet(CouponFrequencyPeriod val) { return IsSetCouponFrequencyPeriod(); }
    public bool IsSetCouponFrequencyPeriod() { return IsSetField(Tags.CouponFrequencyPeriod); }

    public CouponFrequencyUnit CouponFrequencyUnit
    {
        get
        {
            CouponFrequencyUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponFrequencyUnit val) { CouponFrequencyUnit = val; }
    public CouponFrequencyUnit Get(CouponFrequencyUnit val) { GetField(val); return val; }
    public bool IsSet(CouponFrequencyUnit val) { return IsSetCouponFrequencyUnit(); }
    public bool IsSetCouponFrequencyUnit() { return IsSetField(Tags.CouponFrequencyUnit); }

    public CouponDayCount CouponDayCount
    {
        get
        {
            CouponDayCount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponDayCount val) { CouponDayCount = val; }
    public CouponDayCount Get(CouponDayCount val) { GetField(val); return val; }
    public bool IsSet(CouponDayCount val) { return IsSetCouponDayCount(); }
    public bool IsSetCouponDayCount() { return IsSetField(Tags.CouponDayCount); }

    public ConvertibleBondEquityID ConvertibleBondEquityID
    {
        get
        {
            ConvertibleBondEquityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConvertibleBondEquityID val) { ConvertibleBondEquityID = val; }
    public ConvertibleBondEquityID Get(ConvertibleBondEquityID val) { GetField(val); return val; }
    public bool IsSet(ConvertibleBondEquityID val) { return IsSetConvertibleBondEquityID(); }
    public bool IsSetConvertibleBondEquityID() { return IsSetField(Tags.ConvertibleBondEquityID); }

    public ConvertibleBondEquityIDSource ConvertibleBondEquityIDSource
    {
        get
        {
            ConvertibleBondEquityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConvertibleBondEquityIDSource val) { ConvertibleBondEquityIDSource = val; }
    public ConvertibleBondEquityIDSource Get(ConvertibleBondEquityIDSource val) { GetField(val); return val; }
    public bool IsSet(ConvertibleBondEquityIDSource val) { return IsSetConvertibleBondEquityIDSource(); }
    public bool IsSetConvertibleBondEquityIDSource() { return IsSetField(Tags.ConvertibleBondEquityIDSource); }

    public IndexSeries IndexSeries
    {
        get
        {
            IndexSeries val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IndexSeries val) { IndexSeries = val; }
    public IndexSeries Get(IndexSeries val) { GetField(val); return val; }
    public bool IsSet(IndexSeries val) { return IsSetIndexSeries(); }
    public bool IsSetIndexSeries() { return IsSetField(Tags.IndexSeries); }

    public IndexAnnexVersion IndexAnnexVersion
    {
        get
        {
            IndexAnnexVersion val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IndexAnnexVersion val) { IndexAnnexVersion = val; }
    public IndexAnnexVersion Get(IndexAnnexVersion val) { GetField(val); return val; }
    public bool IsSet(IndexAnnexVersion val) { return IsSetIndexAnnexVersion(); }
    public bool IsSetIndexAnnexVersion() { return IsSetField(Tags.IndexAnnexVersion); }

    public IndexAnnexDate IndexAnnexDate
    {
        get
        {
            IndexAnnexDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IndexAnnexDate val) { IndexAnnexDate = val; }
    public IndexAnnexDate Get(IndexAnnexDate val) { GetField(val); return val; }
    public bool IsSet(IndexAnnexDate val) { return IsSetIndexAnnexDate(); }
    public bool IsSetIndexAnnexDate() { return IsSetField(Tags.IndexAnnexDate); }

    public IndexAnnexSource IndexAnnexSource
    {
        get
        {
            IndexAnnexSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IndexAnnexSource val) { IndexAnnexSource = val; }
    public IndexAnnexSource Get(IndexAnnexSource val) { GetField(val); return val; }
    public bool IsSet(IndexAnnexSource val) { return IsSetIndexAnnexSource(); }
    public bool IsSetIndexAnnexSource() { return IsSetField(Tags.IndexAnnexSource); }

    public StrategyType StrategyType
    {
        get
        {
            StrategyType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrategyType val) { StrategyType = val; }
    public StrategyType Get(StrategyType val) { GetField(val); return val; }
    public bool IsSet(StrategyType val) { return IsSetStrategyType(); }
    public bool IsSetStrategyType() { return IsSetField(Tags.StrategyType); }

    public BusinessDayConvention BusinessDayConvention
    {
        get
        {
            BusinessDayConvention val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BusinessDayConvention val) { BusinessDayConvention = val; }
    public BusinessDayConvention Get(BusinessDayConvention val) { GetField(val); return val; }
    public bool IsSet(BusinessDayConvention val) { return IsSetBusinessDayConvention(); }
    public bool IsSetBusinessDayConvention() { return IsSetField(Tags.BusinessDayConvention); }

    public DateRollConvention DateRollConvention
    {
        get
        {
            DateRollConvention val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DateRollConvention val) { DateRollConvention = val; }
    public DateRollConvention Get(DateRollConvention val) { GetField(val); return val; }
    public bool IsSet(DateRollConvention val) { return IsSetDateRollConvention(); }
    public bool IsSetDateRollConvention() { return IsSetField(Tags.DateRollConvention); }

    public OptionExerciseLatestTime OptionExerciseLatestTime
    {
        get
        {
            OptionExerciseLatestTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptionExerciseLatestTime val) { OptionExerciseLatestTime = val; }
    public OptionExerciseLatestTime Get(OptionExerciseLatestTime val) { GetField(val); return val; }
    public bool IsSet(OptionExerciseLatestTime val) { return IsSetOptionExerciseLatestTime(); }
    public bool IsSetOptionExerciseLatestTime() { return IsSetField(Tags.OptionExerciseLatestTime); }

    public OptionExerciseTimeBusinessCenter OptionExerciseTimeBusinessCenter
    {
        get
        {
            OptionExerciseTimeBusinessCenter val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptionExerciseTimeBusinessCenter val) { OptionExerciseTimeBusinessCenter = val; }
    public OptionExerciseTimeBusinessCenter Get(OptionExerciseTimeBusinessCenter val) { GetField(val); return val; }
    public bool IsSet(OptionExerciseTimeBusinessCenter val) { return IsSetOptionExerciseTimeBusinessCenter(); }
    public bool IsSetOptionExerciseTimeBusinessCenter() { return IsSetField(Tags.OptionExerciseTimeBusinessCenter); }

    public OptionExerciseDeliveryDate OptionExerciseDeliveryDate
    {
        get
        {
            OptionExerciseDeliveryDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptionExerciseDeliveryDate val) { OptionExerciseDeliveryDate = val; }
    public OptionExerciseDeliveryDate Get(OptionExerciseDeliveryDate val) { GetField(val); return val; }
    public bool IsSet(OptionExerciseDeliveryDate val) { return IsSetOptionExerciseDeliveryDate(); }
    public bool IsSetOptionExerciseDeliveryDate() { return IsSetField(Tags.OptionExerciseDeliveryDate); }

    public NoOptionExerciseExpirationDates NoOptionExerciseExpirationDates
    {
        get
        {
            NoOptionExerciseExpirationDates val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoOptionExerciseExpirationDates val) { NoOptionExerciseExpirationDates = val; }
    public NoOptionExerciseExpirationDates Get(NoOptionExerciseExpirationDates val) { GetField(val); return val; }
    public bool IsSet(NoOptionExerciseExpirationDates val) { return IsSetNoOptionExerciseExpirationDates(); }
    public bool IsSetNoOptionExerciseExpirationDates() { return IsSetField(Tags.NoOptionExerciseExpirationDates); }

    public NoStreams NoStreams
    {
        get
        {
            NoStreams val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoStreams val) { NoStreams = val; }
    public NoStreams Get(NoStreams val) { GetField(val); return val; }
    public bool IsSet(NoStreams val) { return IsSetNoStreams(); }
    public bool IsSetNoStreams() { return IsSetField(Tags.NoStreams); }

    public StrategyPosition StrategyPosition
    {
        get
        {
            StrategyPosition val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrategyPosition val) { StrategyPosition = val; }
    public StrategyPosition Get(StrategyPosition val) { GetField(val); return val; }
    public bool IsSet(StrategyPosition val) { return IsSetStrategyPosition(); }
    public bool IsSetStrategyPosition() { return IsSetField(Tags.StrategyPosition); }

    public PutOrCallCurrency PutOrCallCurrency
    {
        get
        {
            PutOrCallCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PutOrCallCurrency val) { PutOrCallCurrency = val; }
    public PutOrCallCurrency Get(PutOrCallCurrency val) { GetField(val); return val; }
    public bool IsSet(PutOrCallCurrency val) { return IsSetPutOrCallCurrency(); }
    public bool IsSetPutOrCallCurrency() { return IsSetField(Tags.PutOrCallCurrency); }

    public CreditRatingSource CreditRatingSource
    {
        get
        {
            CreditRatingSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CreditRatingSource val) { CreditRatingSource = val; }
    public CreditRatingSource Get(CreditRatingSource val) { GetField(val); return val; }
    public bool IsSet(CreditRatingSource val) { return IsSetCreditRatingSource(); }
    public bool IsSetCreditRatingSource() { return IsSetField(Tags.CreditRatingSource); }

    public CouponDateGenerationMethod CouponDateGenerationMethod
    {
        get
        {
            CouponDateGenerationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponDateGenerationMethod val) { CouponDateGenerationMethod = val; }
    public CouponDateGenerationMethod Get(CouponDateGenerationMethod val) { GetField(val); return val; }
    public bool IsSet(CouponDateGenerationMethod val) { return IsSetCouponDateGenerationMethod(); }
    public bool IsSetCouponDateGenerationMethod() { return IsSetField(Tags.CouponDateGenerationMethod); }

    public CustomizedIndicator CustomizedIndicator
    {
        get
        {
            CustomizedIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustomizedIndicator val) { CustomizedIndicator = val; }
    public CustomizedIndicator Get(CustomizedIndicator val) { GetField(val); return val; }
    public bool IsSet(CustomizedIndicator val) { return IsSetCustomizedIndicator(); }
    public bool IsSetCustomizedIndicator() { return IsSetField(Tags.CustomizedIndicator); }

    public OptionSettlAmtDeterminationMethod OptionSettlAmtDeterminationMethod
    {
        get
        {
            OptionSettlAmtDeterminationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptionSettlAmtDeterminationMethod val) { OptionSettlAmtDeterminationMethod = val; }
    public OptionSettlAmtDeterminationMethod Get(OptionSettlAmtDeterminationMethod val) { GetField(val); return val; }
    public bool IsSet(OptionSettlAmtDeterminationMethod val) { return IsSetOptionSettlAmtDeterminationMethod(); }
    public bool IsSetOptionSettlAmtDeterminationMethod() { return IsSetField(Tags.OptionSettlAmtDeterminationMethod); }

    public ConvertibleBondEquityCurrency ConvertibleBondEquityCurrency
    {
        get
        {
            ConvertibleBondEquityCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConvertibleBondEquityCurrency val) { ConvertibleBondEquityCurrency = val; }
    public ConvertibleBondEquityCurrency Get(ConvertibleBondEquityCurrency val) { GetField(val); return val; }
    public bool IsSet(ConvertibleBondEquityCurrency val) { return IsSetConvertibleBondEquityCurrency(); }
    public bool IsSetConvertibleBondEquityCurrency() { return IsSetField(Tags.ConvertibleBondEquityCurrency); }

    public OfferingSize OfferingSize
    {
        get
        {
            OfferingSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferingSize val) { OfferingSize = val; }
    public OfferingSize Get(OfferingSize val) { GetField(val); return val; }
    public bool IsSet(OfferingSize val) { return IsSetOfferingSize(); }
    public bool IsSetOfferingSize() { return IsSetField(Tags.OfferingSize); }

    public CountryOfJurisdiction CountryOfJurisdiction
    {
        get
        {
            CountryOfJurisdiction val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CountryOfJurisdiction val) { CountryOfJurisdiction = val; }
    public CountryOfJurisdiction Get(CountryOfJurisdiction val) { GetField(val); return val; }
    public bool IsSet(CountryOfJurisdiction val) { return IsSetCountryOfJurisdiction(); }
    public bool IsSetCountryOfJurisdiction() { return IsSetField(Tags.CountryOfJurisdiction); }

    public CurrencyOfIssue CurrencyOfIssue
    {
        get
        {
            CurrencyOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CurrencyOfIssue val) { CurrencyOfIssue = val; }
    public CurrencyOfIssue Get(CurrencyOfIssue val) { GetField(val); return val; }
    public bool IsSet(CurrencyOfIssue val) { return IsSetCurrencyOfIssue(); }
    public bool IsSetCurrencyOfIssue() { return IsSetField(Tags.CurrencyOfIssue); }

    public AgreementDesc AgreementDesc
    {
        get
        {
            AgreementDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementDesc val) { AgreementDesc = val; }
    public AgreementDesc Get(AgreementDesc val) { GetField(val); return val; }
    public bool IsSet(AgreementDesc val) { return IsSetAgreementDesc(); }
    public bool IsSetAgreementDesc() { return IsSetField(Tags.AgreementDesc); }

    public AgreementID AgreementID
    {
        get
        {
            AgreementID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementID val) { AgreementID = val; }
    public AgreementID Get(AgreementID val) { GetField(val); return val; }
    public bool IsSet(AgreementID val) { return IsSetAgreementID(); }
    public bool IsSetAgreementID() { return IsSetField(Tags.AgreementID); }

    public AgreementDate AgreementDate
    {
        get
        {
            AgreementDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementDate val) { AgreementDate = val; }
    public AgreementDate Get(AgreementDate val) { GetField(val); return val; }
    public bool IsSet(AgreementDate val) { return IsSetAgreementDate(); }
    public bool IsSetAgreementDate() { return IsSetField(Tags.AgreementDate); }

    public AgreementCurrency AgreementCurrency
    {
        get
        {
            AgreementCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementCurrency val) { AgreementCurrency = val; }
    public AgreementCurrency Get(AgreementCurrency val) { GetField(val); return val; }
    public bool IsSet(AgreementCurrency val) { return IsSetAgreementCurrency(); }
    public bool IsSetAgreementCurrency() { return IsSetField(Tags.AgreementCurrency); }

    public TerminationType TerminationType
    {
        get
        {
            TerminationType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TerminationType val) { TerminationType = val; }
    public TerminationType Get(TerminationType val) { GetField(val); return val; }
    public bool IsSet(TerminationType val) { return IsSetTerminationType(); }
    public bool IsSetTerminationType() { return IsSetField(Tags.TerminationType); }

    public StartDate StartDate
    {
        get
        {
            StartDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StartDate val) { StartDate = val; }
    public StartDate Get(StartDate val) { GetField(val); return val; }
    public bool IsSet(StartDate val) { return IsSetStartDate(); }
    public bool IsSetStartDate() { return IsSetField(Tags.StartDate); }

    public EndDate EndDate
    {
        get
        {
            EndDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndDate val) { EndDate = val; }
    public EndDate Get(EndDate val) { GetField(val); return val; }
    public bool IsSet(EndDate val) { return IsSetEndDate(); }
    public bool IsSetEndDate() { return IsSetField(Tags.EndDate); }

    public DeliveryType DeliveryType
    {
        get
        {
            DeliveryType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DeliveryType val) { DeliveryType = val; }
    public DeliveryType Get(DeliveryType val) { GetField(val); return val; }
    public bool IsSet(DeliveryType val) { return IsSetDeliveryType(); }
    public bool IsSetDeliveryType() { return IsSetField(Tags.DeliveryType); }

    public MarginRatio MarginRatio
    {
        get
        {
            MarginRatio val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarginRatio val) { MarginRatio = val; }
    public MarginRatio Get(MarginRatio val) { GetField(val); return val; }
    public bool IsSet(MarginRatio val) { return IsSetMarginRatio(); }
    public bool IsSetMarginRatio() { return IsSetField(Tags.MarginRatio); }

    public NoContractualDefinitions NoContractualDefinitions
    {
        get
        {
            NoContractualDefinitions val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoContractualDefinitions val) { NoContractualDefinitions = val; }
    public NoContractualDefinitions Get(NoContractualDefinitions val) { GetField(val); return val; }
    public bool IsSet(NoContractualDefinitions val) { return IsSetNoContractualDefinitions(); }
    public bool IsSetNoContractualDefinitions() { return IsSetField(Tags.NoContractualDefinitions); }

    public NoContractualMatrices NoContractualMatrices
    {
        get
        {
            NoContractualMatrices val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoContractualMatrices val) { NoContractualMatrices = val; }
    public NoContractualMatrices Get(NoContractualMatrices val) { GetField(val); return val; }
    public bool IsSet(NoContractualMatrices val) { return IsSetNoContractualMatrices(); }
    public bool IsSetNoContractualMatrices() { return IsSetField(Tags.NoContractualMatrices); }

    public DaysToTerm DaysToTerm
    {
        get
        {
            DaysToTerm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DaysToTerm val) { DaysToTerm = val; }
    public DaysToTerm Get(DaysToTerm val) { GetField(val); return val; }
    public bool IsSet(DaysToTerm val) { return IsSetDaysToTerm(); }
    public bool IsSetDaysToTerm() { return IsSetField(Tags.DaysToTerm); }

    public NoUnderlyings NoUnderlyings
    {
        get
        {
            NoUnderlyings val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUnderlyings val) { NoUnderlyings = val; }
    public NoUnderlyings Get(NoUnderlyings val) { GetField(val); return val; }
    public bool IsSet(NoUnderlyings val) { return IsSetNoUnderlyings(); }
    public bool IsSetNoUnderlyings() { return IsSetField(Tags.NoUnderlyings); }

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

    public NoStipulations NoStipulations
    {
        get
        {
            NoStipulations val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoStipulations val) { NoStipulations = val; }
    public NoStipulations Get(NoStipulations val) { GetField(val); return val; }
    public bool IsSet(NoStipulations val) { return IsSetNoStipulations(); }
    public bool IsSetNoStipulations() { return IsSetField(Tags.NoStipulations); }

    public QtyType QtyType
    {
        get
        {
            QtyType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QtyType val) { QtyType = val; }
    public QtyType Get(QtyType val) { GetField(val); return val; }
    public bool IsSet(QtyType val) { return IsSetQtyType(); }
    public bool IsSetQtyType() { return IsSetField(Tags.QtyType); }

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

    public OrderPercent OrderPercent
    {
        get
        {
            OrderPercent val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderPercent val) { OrderPercent = val; }
    public OrderPercent Get(OrderPercent val) { GetField(val); return val; }
    public bool IsSet(OrderPercent val) { return IsSetOrderPercent(); }
    public bool IsSetOrderPercent() { return IsSetField(Tags.OrderPercent); }

    public RoundingDirection RoundingDirection
    {
        get
        {
            RoundingDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RoundingDirection val) { RoundingDirection = val; }
    public RoundingDirection Get(RoundingDirection val) { GetField(val); return val; }
    public bool IsSet(RoundingDirection val) { return IsSetRoundingDirection(); }
    public bool IsSetRoundingDirection() { return IsSetField(Tags.RoundingDirection); }

    public RoundingModulus RoundingModulus
    {
        get
        {
            RoundingModulus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RoundingModulus val) { RoundingModulus = val; }
    public RoundingModulus Get(RoundingModulus val) { GetField(val); return val; }
    public bool IsSet(RoundingModulus val) { return IsSetRoundingModulus(); }
    public bool IsSetRoundingModulus() { return IsSetField(Tags.RoundingModulus); }

    public OrderQtyUnits OrderQtyUnits
    {
        get
        {
            OrderQtyUnits val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderQtyUnits val) { OrderQtyUnits = val; }
    public OrderQtyUnits Get(OrderQtyUnits val) { GetField(val); return val; }
    public bool IsSet(OrderQtyUnits val) { return IsSetOrderQtyUnits(); }
    public bool IsSetOrderQtyUnits() { return IsSetField(Tags.OrderQtyUnits); }

    public ConstantQtyType ConstantQtyType
    {
        get
        {
            ConstantQtyType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConstantQtyType val) { ConstantQtyType = val; }
    public ConstantQtyType Get(ConstantQtyType val) { GetField(val); return val; }
    public bool IsSet(ConstantQtyType val) { return IsSetConstantQtyType(); }
    public bool IsSetConstantQtyType() { return IsSetField(Tags.ConstantQtyType); }

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

    public PriceType PriceType
    {
        get
        {
            PriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceType val) { PriceType = val; }
    public PriceType Get(PriceType val) { GetField(val); return val; }
    public bool IsSet(PriceType val) { return IsSetPriceType(); }
    public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

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

    public Spread Spread
    {
        get
        {
            Spread val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Spread val) { Spread = val; }
    public Spread Get(Spread val) { GetField(val); return val; }
    public bool IsSet(Spread val) { return IsSetSpread(); }
    public bool IsSetSpread() { return IsSetField(Tags.Spread); }

    public BenchmarkCurveCurrency BenchmarkCurveCurrency
    {
        get
        {
            BenchmarkCurveCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurveCurrency val) { BenchmarkCurveCurrency = val; }
    public BenchmarkCurveCurrency Get(BenchmarkCurveCurrency val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurveCurrency val) { return IsSetBenchmarkCurveCurrency(); }
    public bool IsSetBenchmarkCurveCurrency() { return IsSetField(Tags.BenchmarkCurveCurrency); }

    public BenchmarkCurveName BenchmarkCurveName
    {
        get
        {
            BenchmarkCurveName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurveName val) { BenchmarkCurveName = val; }
    public BenchmarkCurveName Get(BenchmarkCurveName val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurveName val) { return IsSetBenchmarkCurveName(); }
    public bool IsSetBenchmarkCurveName() { return IsSetField(Tags.BenchmarkCurveName); }

    public BenchmarkCurvePoint BenchmarkCurvePoint
    {
        get
        {
            BenchmarkCurvePoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurvePoint val) { BenchmarkCurvePoint = val; }
    public BenchmarkCurvePoint Get(BenchmarkCurvePoint val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurvePoint val) { return IsSetBenchmarkCurvePoint(); }
    public bool IsSetBenchmarkCurvePoint() { return IsSetField(Tags.BenchmarkCurvePoint); }

    public BenchmarkPrice BenchmarkPrice
    {
        get
        {
            BenchmarkPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkPrice val) { BenchmarkPrice = val; }
    public BenchmarkPrice Get(BenchmarkPrice val) { GetField(val); return val; }
    public bool IsSet(BenchmarkPrice val) { return IsSetBenchmarkPrice(); }
    public bool IsSetBenchmarkPrice() { return IsSetField(Tags.BenchmarkPrice); }

    public BenchmarkPriceType BenchmarkPriceType
    {
        get
        {
            BenchmarkPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkPriceType val) { BenchmarkPriceType = val; }
    public BenchmarkPriceType Get(BenchmarkPriceType val) { GetField(val); return val; }
    public bool IsSet(BenchmarkPriceType val) { return IsSetBenchmarkPriceType(); }
    public bool IsSetBenchmarkPriceType() { return IsSetField(Tags.BenchmarkPriceType); }

    public BenchmarkSecurityID BenchmarkSecurityID
    {
        get
        {
            BenchmarkSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkSecurityID val) { BenchmarkSecurityID = val; }
    public BenchmarkSecurityID Get(BenchmarkSecurityID val) { GetField(val); return val; }
    public bool IsSet(BenchmarkSecurityID val) { return IsSetBenchmarkSecurityID(); }
    public bool IsSetBenchmarkSecurityID() { return IsSetField(Tags.BenchmarkSecurityID); }

    public BenchmarkSecurityIDSource BenchmarkSecurityIDSource
    {
        get
        {
            BenchmarkSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkSecurityIDSource val) { BenchmarkSecurityIDSource = val; }
    public BenchmarkSecurityIDSource Get(BenchmarkSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(BenchmarkSecurityIDSource val) { return IsSetBenchmarkSecurityIDSource(); }
    public bool IsSetBenchmarkSecurityIDSource() { return IsSetField(Tags.BenchmarkSecurityIDSource); }

    public BenchmarkYield BenchmarkYield
    {
        get
        {
            BenchmarkYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkYield val) { BenchmarkYield = val; }
    public BenchmarkYield Get(BenchmarkYield val) { GetField(val); return val; }
    public bool IsSet(BenchmarkYield val) { return IsSetBenchmarkYield(); }
    public bool IsSetBenchmarkYield() { return IsSetField(Tags.BenchmarkYield); }

    public BenchmarkSecurityDesc BenchmarkSecurityDesc
    {
        get
        {
            BenchmarkSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkSecurityDesc val) { BenchmarkSecurityDesc = val; }
    public BenchmarkSecurityDesc Get(BenchmarkSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(BenchmarkSecurityDesc val) { return IsSetBenchmarkSecurityDesc(); }
    public bool IsSetBenchmarkSecurityDesc() { return IsSetField(Tags.BenchmarkSecurityDesc); }

    public BenchmarkSecurityType BenchmarkSecurityType
    {
        get
        {
            BenchmarkSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkSecurityType val) { BenchmarkSecurityType = val; }
    public BenchmarkSecurityType Get(BenchmarkSecurityType val) { GetField(val); return val; }
    public bool IsSet(BenchmarkSecurityType val) { return IsSetBenchmarkSecurityType(); }
    public bool IsSetBenchmarkSecurityType() { return IsSetField(Tags.BenchmarkSecurityType); }

    public YieldType YieldType
    {
        get
        {
            YieldType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldType val) { YieldType = val; }
    public YieldType Get(YieldType val) { GetField(val); return val; }
    public bool IsSet(YieldType val) { return IsSetYieldType(); }
    public bool IsSetYieldType() { return IsSetField(Tags.YieldType); }

    public Yield Yield
    {
        get
        {
            Yield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Yield val) { Yield = val; }
    public Yield Get(Yield val) { GetField(val); return val; }
    public bool IsSet(Yield val) { return IsSetYield(); }
    public bool IsSetYield() { return IsSetField(Tags.Yield); }

    public YieldCalcDate YieldCalcDate
    {
        get
        {
            YieldCalcDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldCalcDate val) { YieldCalcDate = val; }
    public YieldCalcDate Get(YieldCalcDate val) { GetField(val); return val; }
    public bool IsSet(YieldCalcDate val) { return IsSetYieldCalcDate(); }
    public bool IsSetYieldCalcDate() { return IsSetField(Tags.YieldCalcDate); }

    public YieldRedemptionDate YieldRedemptionDate
    {
        get
        {
            YieldRedemptionDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionDate val) { YieldRedemptionDate = val; }
    public YieldRedemptionDate Get(YieldRedemptionDate val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionDate val) { return IsSetYieldRedemptionDate(); }
    public bool IsSetYieldRedemptionDate() { return IsSetField(Tags.YieldRedemptionDate); }

    public YieldRedemptionPrice YieldRedemptionPrice
    {
        get
        {
            YieldRedemptionPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionPrice val) { YieldRedemptionPrice = val; }
    public YieldRedemptionPrice Get(YieldRedemptionPrice val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionPrice val) { return IsSetYieldRedemptionPrice(); }
    public bool IsSetYieldRedemptionPrice() { return IsSetField(Tags.YieldRedemptionPrice); }

    public YieldRedemptionPriceType YieldRedemptionPriceType
    {
        get
        {
            YieldRedemptionPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionPriceType val) { YieldRedemptionPriceType = val; }
    public YieldRedemptionPriceType Get(YieldRedemptionPriceType val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionPriceType val) { return IsSetYieldRedemptionPriceType(); }
    public bool IsSetYieldRedemptionPriceType() { return IsSetField(Tags.YieldRedemptionPriceType); }

    public GrossYield GrossYield
    {
        get
        {
            GrossYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(GrossYield val) { GrossYield = val; }
    public GrossYield Get(GrossYield val) { GetField(val); return val; }
    public bool IsSet(GrossYield val) { return IsSetGrossYield(); }
    public bool IsSetGrossYield() { return IsSetField(Tags.GrossYield); }

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

    public IOIID IOIID
    {
        get
        {
            IOIID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOIID val) { IOIID = val; }
    public IOIID Get(IOIID val) { GetField(val); return val; }
    public bool IsSet(IOIID val) { return IsSetIOIID(); }
    public bool IsSetIOIID() { return IsSetField(Tags.IOIID); }

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

    public CommCurrency CommCurrency
    {
        get
        {
            CommCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CommCurrency val) { CommCurrency = val; }
    public CommCurrency Get(CommCurrency val) { GetField(val); return val; }
    public bool IsSet(CommCurrency val) { return IsSetCommCurrency(); }
    public bool IsSetCommCurrency() { return IsSetField(Tags.CommCurrency); }

    public FundRenewWaiv FundRenewWaiv
    {
        get
        {
            FundRenewWaiv val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FundRenewWaiv val) { FundRenewWaiv = val; }
    public FundRenewWaiv Get(FundRenewWaiv val) { GetField(val); return val; }
    public bool IsSet(FundRenewWaiv val) { return IsSetFundRenewWaiv(); }
    public bool IsSetFundRenewWaiv() { return IsSetField(Tags.FundRenewWaiv); }

    public CommissionRate CommissionRate
    {
        get
        {
            CommissionRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CommissionRate val) { CommissionRate = val; }
    public CommissionRate Get(CommissionRate val) { GetField(val); return val; }
    public bool IsSet(CommissionRate val) { return IsSetCommissionRate(); }
    public bool IsSetCommissionRate() { return IsSetField(Tags.CommissionRate); }

    public CommissionValueType CommissionValueType
    {
        get
        {
            CommissionValueType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CommissionValueType val) { CommissionValueType = val; }
    public CommissionValueType Get(CommissionValueType val) { GetField(val); return val; }
    public bool IsSet(CommissionValueType val) { return IsSetCommissionValueType(); }
    public bool IsSetCommissionValueType() { return IsSetField(Tags.CommissionValueType); }

    public CommissionMode CommissionMode
    {
        get
        {
            CommissionMode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CommissionMode val) { CommissionMode = val; }
    public CommissionMode Get(CommissionMode val) { GetField(val); return val; }
    public bool IsSet(CommissionMode val) { return IsSetCommissionMode(); }
    public bool IsSetCommissionMode() { return IsSetField(Tags.CommissionMode); }

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

    public OrderRestrictions OrderRestrictions
    {
        get
        {
            OrderRestrictions val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderRestrictions val) { OrderRestrictions = val; }
    public OrderRestrictions Get(OrderRestrictions val) { GetField(val); return val; }
    public bool IsSet(OrderRestrictions val) { return IsSetOrderRestrictions(); }
    public bool IsSetOrderRestrictions() { return IsSetField(Tags.OrderRestrictions); }

    public CustOrderCapacity CustOrderCapacity
    {
        get
        {
            CustOrderCapacity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustOrderCapacity val) { CustOrderCapacity = val; }
    public CustOrderCapacity Get(CustOrderCapacity val) { GetField(val); return val; }
    public bool IsSet(CustOrderCapacity val) { return IsSetCustOrderCapacity(); }
    public bool IsSetCustOrderCapacity() { return IsSetField(Tags.CustOrderCapacity); }

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

    public SettlDate2 SettlDate2
    {
        get
        {
            SettlDate2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlDate2 val) { SettlDate2 = val; }
    public SettlDate2 Get(SettlDate2 val) { GetField(val); return val; }
    public bool IsSet(SettlDate2 val) { return IsSetSettlDate2(); }
    public bool IsSetSettlDate2() { return IsSetField(Tags.SettlDate2); }

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

    public Price2 Price2
    {
        get
        {
            Price2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Price2 val) { Price2 = val; }
    public Price2 Get(Price2 val) { GetField(val); return val; }
    public bool IsSet(Price2 val) { return IsSetPrice2(); }
    public bool IsSetPrice2() { return IsSetField(Tags.Price2); }

    public PositionEffect PositionEffect
    {
        get
        {
            PositionEffect val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PositionEffect val) { PositionEffect = val; }
    public PositionEffect Get(PositionEffect val) { GetField(val); return val; }
    public bool IsSet(PositionEffect val) { return IsSetPositionEffect(); }
    public bool IsSetPositionEffect() { return IsSetField(Tags.PositionEffect); }

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

    public PegOffsetValue PegOffsetValue
    {
        get
        {
            PegOffsetValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegOffsetValue val) { PegOffsetValue = val; }
    public PegOffsetValue Get(PegOffsetValue val) { GetField(val); return val; }
    public bool IsSet(PegOffsetValue val) { return IsSetPegOffsetValue(); }
    public bool IsSetPegOffsetValue() { return IsSetField(Tags.PegOffsetValue); }

    public PegMoveType PegMoveType
    {
        get
        {
            PegMoveType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegMoveType val) { PegMoveType = val; }
    public PegMoveType Get(PegMoveType val) { GetField(val); return val; }
    public bool IsSet(PegMoveType val) { return IsSetPegMoveType(); }
    public bool IsSetPegMoveType() { return IsSetField(Tags.PegMoveType); }

    public PegOffsetType PegOffsetType
    {
        get
        {
            PegOffsetType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegOffsetType val) { PegOffsetType = val; }
    public PegOffsetType Get(PegOffsetType val) { GetField(val); return val; }
    public bool IsSet(PegOffsetType val) { return IsSetPegOffsetType(); }
    public bool IsSetPegOffsetType() { return IsSetField(Tags.PegOffsetType); }

    public PegLimitType PegLimitType
    {
        get
        {
            PegLimitType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegLimitType val) { PegLimitType = val; }
    public PegLimitType Get(PegLimitType val) { GetField(val); return val; }
    public bool IsSet(PegLimitType val) { return IsSetPegLimitType(); }
    public bool IsSetPegLimitType() { return IsSetField(Tags.PegLimitType); }

    public PegRoundDirection PegRoundDirection
    {
        get
        {
            PegRoundDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegRoundDirection val) { PegRoundDirection = val; }
    public PegRoundDirection Get(PegRoundDirection val) { GetField(val); return val; }
    public bool IsSet(PegRoundDirection val) { return IsSetPegRoundDirection(); }
    public bool IsSetPegRoundDirection() { return IsSetField(Tags.PegRoundDirection); }

    public PegScope PegScope
    {
        get
        {
            PegScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegScope val) { PegScope = val; }
    public PegScope Get(PegScope val) { GetField(val); return val; }
    public bool IsSet(PegScope val) { return IsSetPegScope(); }
    public bool IsSetPegScope() { return IsSetField(Tags.PegScope); }

    public PegPriceType PegPriceType
    {
        get
        {
            PegPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegPriceType val) { PegPriceType = val; }
    public PegPriceType Get(PegPriceType val) { GetField(val); return val; }
    public bool IsSet(PegPriceType val) { return IsSetPegPriceType(); }
    public bool IsSetPegPriceType() { return IsSetField(Tags.PegPriceType); }

    public PegSecurityIDSource PegSecurityIDSource
    {
        get
        {
            PegSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegSecurityIDSource val) { PegSecurityIDSource = val; }
    public PegSecurityIDSource Get(PegSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(PegSecurityIDSource val) { return IsSetPegSecurityIDSource(); }
    public bool IsSetPegSecurityIDSource() { return IsSetField(Tags.PegSecurityIDSource); }

    public PegSecurityID PegSecurityID
    {
        get
        {
            PegSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegSecurityID val) { PegSecurityID = val; }
    public PegSecurityID Get(PegSecurityID val) { GetField(val); return val; }
    public bool IsSet(PegSecurityID val) { return IsSetPegSecurityID(); }
    public bool IsSetPegSecurityID() { return IsSetField(Tags.PegSecurityID); }

    public PegSymbol PegSymbol
    {
        get
        {
            PegSymbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegSymbol val) { PegSymbol = val; }
    public PegSymbol Get(PegSymbol val) { GetField(val); return val; }
    public bool IsSet(PegSymbol val) { return IsSetPegSymbol(); }
    public bool IsSetPegSymbol() { return IsSetField(Tags.PegSymbol); }

    public PegSecurityDesc PegSecurityDesc
    {
        get
        {
            PegSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PegSecurityDesc val) { PegSecurityDesc = val; }
    public PegSecurityDesc Get(PegSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(PegSecurityDesc val) { return IsSetPegSecurityDesc(); }
    public bool IsSetPegSecurityDesc() { return IsSetField(Tags.PegSecurityDesc); }

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

    public DiscretionOffsetValue DiscretionOffsetValue
    {
        get
        {
            DiscretionOffsetValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionOffsetValue val) { DiscretionOffsetValue = val; }
    public DiscretionOffsetValue Get(DiscretionOffsetValue val) { GetField(val); return val; }
    public bool IsSet(DiscretionOffsetValue val) { return IsSetDiscretionOffsetValue(); }
    public bool IsSetDiscretionOffsetValue() { return IsSetField(Tags.DiscretionOffsetValue); }

    public DiscretionMoveType DiscretionMoveType
    {
        get
        {
            DiscretionMoveType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionMoveType val) { DiscretionMoveType = val; }
    public DiscretionMoveType Get(DiscretionMoveType val) { GetField(val); return val; }
    public bool IsSet(DiscretionMoveType val) { return IsSetDiscretionMoveType(); }
    public bool IsSetDiscretionMoveType() { return IsSetField(Tags.DiscretionMoveType); }

    public DiscretionOffsetType DiscretionOffsetType
    {
        get
        {
            DiscretionOffsetType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionOffsetType val) { DiscretionOffsetType = val; }
    public DiscretionOffsetType Get(DiscretionOffsetType val) { GetField(val); return val; }
    public bool IsSet(DiscretionOffsetType val) { return IsSetDiscretionOffsetType(); }
    public bool IsSetDiscretionOffsetType() { return IsSetField(Tags.DiscretionOffsetType); }

    public DiscretionLimitType DiscretionLimitType
    {
        get
        {
            DiscretionLimitType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionLimitType val) { DiscretionLimitType = val; }
    public DiscretionLimitType Get(DiscretionLimitType val) { GetField(val); return val; }
    public bool IsSet(DiscretionLimitType val) { return IsSetDiscretionLimitType(); }
    public bool IsSetDiscretionLimitType() { return IsSetField(Tags.DiscretionLimitType); }

    public DiscretionRoundDirection DiscretionRoundDirection
    {
        get
        {
            DiscretionRoundDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionRoundDirection val) { DiscretionRoundDirection = val; }
    public DiscretionRoundDirection Get(DiscretionRoundDirection val) { GetField(val); return val; }
    public bool IsSet(DiscretionRoundDirection val) { return IsSetDiscretionRoundDirection(); }
    public bool IsSetDiscretionRoundDirection() { return IsSetField(Tags.DiscretionRoundDirection); }

    public DiscretionScope DiscretionScope
    {
        get
        {
            DiscretionScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionScope val) { DiscretionScope = val; }
    public DiscretionScope Get(DiscretionScope val) { GetField(val); return val; }
    public bool IsSet(DiscretionScope val) { return IsSetDiscretionScope(); }
    public bool IsSetDiscretionScope() { return IsSetField(Tags.DiscretionScope); }

    public TargetStrategy TargetStrategy
    {
        get
        {
            TargetStrategy val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TargetStrategy val) { TargetStrategy = val; }
    public TargetStrategy Get(TargetStrategy val) { GetField(val); return val; }
    public bool IsSet(TargetStrategy val) { return IsSetTargetStrategy(); }
    public bool IsSetTargetStrategy() { return IsSetField(Tags.TargetStrategy); }

    public TargetStrategyParameters TargetStrategyParameters
    {
        get
        {
            TargetStrategyParameters val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TargetStrategyParameters val) { TargetStrategyParameters = val; }
    public TargetStrategyParameters Get(TargetStrategyParameters val) { GetField(val); return val; }
    public bool IsSet(TargetStrategyParameters val) { return IsSetTargetStrategyParameters(); }
    public bool IsSetTargetStrategyParameters() { return IsSetField(Tags.TargetStrategyParameters); }

    public ParticipationRate ParticipationRate
    {
        get
        {
            ParticipationRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ParticipationRate val) { ParticipationRate = val; }
    public ParticipationRate Get(ParticipationRate val) { GetField(val); return val; }
    public bool IsSet(ParticipationRate val) { return IsSetParticipationRate(); }
    public bool IsSetParticipationRate() { return IsSetField(Tags.ParticipationRate); }

    public CancellationRights CancellationRights
    {
        get
        {
            CancellationRights val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CancellationRights val) { CancellationRights = val; }
    public CancellationRights Get(CancellationRights val) { GetField(val); return val; }
    public bool IsSet(CancellationRights val) { return IsSetCancellationRights(); }
    public bool IsSetCancellationRights() { return IsSetField(Tags.CancellationRights); }

    public MoneyLaunderingStatus MoneyLaunderingStatus
    {
        get
        {
            MoneyLaunderingStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MoneyLaunderingStatus val) { MoneyLaunderingStatus = val; }
    public MoneyLaunderingStatus Get(MoneyLaunderingStatus val) { GetField(val); return val; }
    public bool IsSet(MoneyLaunderingStatus val) { return IsSetMoneyLaunderingStatus(); }
    public bool IsSetMoneyLaunderingStatus() { return IsSetField(Tags.MoneyLaunderingStatus); }

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

    public Designation Designation
    {
        get
        {
            Designation val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Designation val) { Designation = val; }
    public Designation Get(Designation val) { GetField(val); return val; }
    public bool IsSet(Designation val) { return IsSetDesignation(); }
    public bool IsSetDesignation() { return IsSetField(Tags.Designation); }

    public NoStrategyParameters NoStrategyParameters
    {
        get
        {
            NoStrategyParameters val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoStrategyParameters val) { NoStrategyParameters = val; }
    public NoStrategyParameters Get(NoStrategyParameters val) { GetField(val); return val; }
    public bool IsSet(NoStrategyParameters val) { return IsSetNoStrategyParameters(); }
    public bool IsSetNoStrategyParameters() { return IsSetField(Tags.NoStrategyParameters); }

    public ManualOrderIndicator ManualOrderIndicator
    {
        get
        {
            ManualOrderIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ManualOrderIndicator val) { ManualOrderIndicator = val; }
    public ManualOrderIndicator Get(ManualOrderIndicator val) { GetField(val); return val; }
    public bool IsSet(ManualOrderIndicator val) { return IsSetManualOrderIndicator(); }
    public bool IsSetManualOrderIndicator() { return IsSetField(Tags.ManualOrderIndicator); }

    public CustDirectedOrder CustDirectedOrder
    {
        get
        {
            CustDirectedOrder val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustDirectedOrder val) { CustDirectedOrder = val; }
    public CustDirectedOrder Get(CustDirectedOrder val) { GetField(val); return val; }
    public bool IsSet(CustDirectedOrder val) { return IsSetCustDirectedOrder(); }
    public bool IsSetCustDirectedOrder() { return IsSetField(Tags.CustDirectedOrder); }

    public ReceivedDeptID ReceivedDeptID
    {
        get
        {
            ReceivedDeptID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ReceivedDeptID val) { ReceivedDeptID = val; }
    public ReceivedDeptID Get(ReceivedDeptID val) { GetField(val); return val; }
    public bool IsSet(ReceivedDeptID val) { return IsSetReceivedDeptID(); }
    public bool IsSetReceivedDeptID() { return IsSetField(Tags.ReceivedDeptID); }

    public CustOrderHandlingInst CustOrderHandlingInst
    {
        get
        {
            CustOrderHandlingInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustOrderHandlingInst val) { CustOrderHandlingInst = val; }
    public CustOrderHandlingInst Get(CustOrderHandlingInst val) { GetField(val); return val; }
    public bool IsSet(CustOrderHandlingInst val) { return IsSetCustOrderHandlingInst(); }
    public bool IsSetCustOrderHandlingInst() { return IsSetField(Tags.CustOrderHandlingInst); }

    public OrderHandlingInstSource OrderHandlingInstSource
    {
        get
        {
            OrderHandlingInstSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderHandlingInstSource val) { OrderHandlingInstSource = val; }
    public OrderHandlingInstSource Get(OrderHandlingInstSource val) { GetField(val); return val; }
    public bool IsSet(OrderHandlingInstSource val) { return IsSetOrderHandlingInstSource(); }
    public bool IsSetOrderHandlingInstSource() { return IsSetField(Tags.OrderHandlingInstSource); }

    public NoTrdRegTimestamps NoTrdRegTimestamps
    {
        get
        {
            NoTrdRegTimestamps val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTrdRegTimestamps val) { NoTrdRegTimestamps = val; }
    public NoTrdRegTimestamps Get(NoTrdRegTimestamps val) { GetField(val); return val; }
    public bool IsSet(NoTrdRegTimestamps val) { return IsSetNoTrdRegTimestamps(); }
    public bool IsSetNoTrdRegTimestamps() { return IsSetField(Tags.NoTrdRegTimestamps); }

    public MatchIncrement MatchIncrement
    {
        get
        {
            MatchIncrement val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MatchIncrement val) { MatchIncrement = val; }
    public MatchIncrement Get(MatchIncrement val) { GetField(val); return val; }
    public bool IsSet(MatchIncrement val) { return IsSetMatchIncrement(); }
    public bool IsSetMatchIncrement() { return IsSetField(Tags.MatchIncrement); }

    public MaxPriceLevels MaxPriceLevels
    {
        get
        {
            MaxPriceLevels val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxPriceLevels val) { MaxPriceLevels = val; }
    public MaxPriceLevels Get(MaxPriceLevels val) { GetField(val); return val; }
    public bool IsSet(MaxPriceLevels val) { return IsSetMaxPriceLevels(); }
    public bool IsSetMaxPriceLevels() { return IsSetField(Tags.MaxPriceLevels); }

    public SecondaryDisplayQty SecondaryDisplayQty
    {
        get
        {
            SecondaryDisplayQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryDisplayQty val) { SecondaryDisplayQty = val; }
    public SecondaryDisplayQty Get(SecondaryDisplayQty val) { GetField(val); return val; }
    public bool IsSet(SecondaryDisplayQty val) { return IsSetSecondaryDisplayQty(); }
    public bool IsSetSecondaryDisplayQty() { return IsSetField(Tags.SecondaryDisplayQty); }

    public DisplayWhen DisplayWhen
    {
        get
        {
            DisplayWhen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayWhen val) { DisplayWhen = val; }
    public DisplayWhen Get(DisplayWhen val) { GetField(val); return val; }
    public bool IsSet(DisplayWhen val) { return IsSetDisplayWhen(); }
    public bool IsSetDisplayWhen() { return IsSetField(Tags.DisplayWhen); }

    public DisplayMethod DisplayMethod
    {
        get
        {
            DisplayMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayMethod val) { DisplayMethod = val; }
    public DisplayMethod Get(DisplayMethod val) { GetField(val); return val; }
    public bool IsSet(DisplayMethod val) { return IsSetDisplayMethod(); }
    public bool IsSetDisplayMethod() { return IsSetField(Tags.DisplayMethod); }

    public DisplayLowQty DisplayLowQty
    {
        get
        {
            DisplayLowQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayLowQty val) { DisplayLowQty = val; }
    public DisplayLowQty Get(DisplayLowQty val) { GetField(val); return val; }
    public bool IsSet(DisplayLowQty val) { return IsSetDisplayLowQty(); }
    public bool IsSetDisplayLowQty() { return IsSetField(Tags.DisplayLowQty); }

    public DisplayHighQty DisplayHighQty
    {
        get
        {
            DisplayHighQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayHighQty val) { DisplayHighQty = val; }
    public DisplayHighQty Get(DisplayHighQty val) { GetField(val); return val; }
    public bool IsSet(DisplayHighQty val) { return IsSetDisplayHighQty(); }
    public bool IsSetDisplayHighQty() { return IsSetField(Tags.DisplayHighQty); }

    public DisplayMinIncr DisplayMinIncr
    {
        get
        {
            DisplayMinIncr val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayMinIncr val) { DisplayMinIncr = val; }
    public DisplayMinIncr Get(DisplayMinIncr val) { GetField(val); return val; }
    public bool IsSet(DisplayMinIncr val) { return IsSetDisplayMinIncr(); }
    public bool IsSetDisplayMinIncr() { return IsSetField(Tags.DisplayMinIncr); }

    public RefreshQty RefreshQty
    {
        get
        {
            RefreshQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefreshQty val) { RefreshQty = val; }
    public RefreshQty Get(RefreshQty val) { GetField(val); return val; }
    public bool IsSet(RefreshQty val) { return IsSetRefreshQty(); }
    public bool IsSetRefreshQty() { return IsSetField(Tags.RefreshQty); }

    public DisplayQty DisplayQty
    {
        get
        {
            DisplayQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DisplayQty val) { DisplayQty = val; }
    public DisplayQty Get(DisplayQty val) { GetField(val); return val; }
    public bool IsSet(DisplayQty val) { return IsSetDisplayQty(); }
    public bool IsSetDisplayQty() { return IsSetField(Tags.DisplayQty); }

    public PriceProtectionScope PriceProtectionScope
    {
        get
        {
            PriceProtectionScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceProtectionScope val) { PriceProtectionScope = val; }
    public PriceProtectionScope Get(PriceProtectionScope val) { GetField(val); return val; }
    public bool IsSet(PriceProtectionScope val) { return IsSetPriceProtectionScope(); }
    public bool IsSetPriceProtectionScope() { return IsSetField(Tags.PriceProtectionScope); }

    public TriggerType TriggerType
    {
        get
        {
            TriggerType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerType val) { TriggerType = val; }
    public TriggerType Get(TriggerType val) { GetField(val); return val; }
    public bool IsSet(TriggerType val) { return IsSetTriggerType(); }
    public bool IsSetTriggerType() { return IsSetField(Tags.TriggerType); }

    public TriggerAction TriggerAction
    {
        get
        {
            TriggerAction val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerAction val) { TriggerAction = val; }
    public TriggerAction Get(TriggerAction val) { GetField(val); return val; }
    public bool IsSet(TriggerAction val) { return IsSetTriggerAction(); }
    public bool IsSetTriggerAction() { return IsSetField(Tags.TriggerAction); }

    public TriggerPrice TriggerPrice
    {
        get
        {
            TriggerPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerPrice val) { TriggerPrice = val; }
    public TriggerPrice Get(TriggerPrice val) { GetField(val); return val; }
    public bool IsSet(TriggerPrice val) { return IsSetTriggerPrice(); }
    public bool IsSetTriggerPrice() { return IsSetField(Tags.TriggerPrice); }

    public TriggerSymbol TriggerSymbol
    {
        get
        {
            TriggerSymbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerSymbol val) { TriggerSymbol = val; }
    public TriggerSymbol Get(TriggerSymbol val) { GetField(val); return val; }
    public bool IsSet(TriggerSymbol val) { return IsSetTriggerSymbol(); }
    public bool IsSetTriggerSymbol() { return IsSetField(Tags.TriggerSymbol); }

    public TriggerSecurityID TriggerSecurityID
    {
        get
        {
            TriggerSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerSecurityID val) { TriggerSecurityID = val; }
    public TriggerSecurityID Get(TriggerSecurityID val) { GetField(val); return val; }
    public bool IsSet(TriggerSecurityID val) { return IsSetTriggerSecurityID(); }
    public bool IsSetTriggerSecurityID() { return IsSetField(Tags.TriggerSecurityID); }

    public TriggerSecurityIDSource TriggerSecurityIDSource
    {
        get
        {
            TriggerSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerSecurityIDSource val) { TriggerSecurityIDSource = val; }
    public TriggerSecurityIDSource Get(TriggerSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(TriggerSecurityIDSource val) { return IsSetTriggerSecurityIDSource(); }
    public bool IsSetTriggerSecurityIDSource() { return IsSetField(Tags.TriggerSecurityIDSource); }

    public TriggerSecurityDesc TriggerSecurityDesc
    {
        get
        {
            TriggerSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerSecurityDesc val) { TriggerSecurityDesc = val; }
    public TriggerSecurityDesc Get(TriggerSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(TriggerSecurityDesc val) { return IsSetTriggerSecurityDesc(); }
    public bool IsSetTriggerSecurityDesc() { return IsSetField(Tags.TriggerSecurityDesc); }

    public TriggerPriceType TriggerPriceType
    {
        get
        {
            TriggerPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerPriceType val) { TriggerPriceType = val; }
    public TriggerPriceType Get(TriggerPriceType val) { GetField(val); return val; }
    public bool IsSet(TriggerPriceType val) { return IsSetTriggerPriceType(); }
    public bool IsSetTriggerPriceType() { return IsSetField(Tags.TriggerPriceType); }

    public TriggerPriceTypeScope TriggerPriceTypeScope
    {
        get
        {
            TriggerPriceTypeScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerPriceTypeScope val) { TriggerPriceTypeScope = val; }
    public TriggerPriceTypeScope Get(TriggerPriceTypeScope val) { GetField(val); return val; }
    public bool IsSet(TriggerPriceTypeScope val) { return IsSetTriggerPriceTypeScope(); }
    public bool IsSetTriggerPriceTypeScope() { return IsSetField(Tags.TriggerPriceTypeScope); }

    public TriggerPriceDirection TriggerPriceDirection
    {
        get
        {
            TriggerPriceDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerPriceDirection val) { TriggerPriceDirection = val; }
    public TriggerPriceDirection Get(TriggerPriceDirection val) { GetField(val); return val; }
    public bool IsSet(TriggerPriceDirection val) { return IsSetTriggerPriceDirection(); }
    public bool IsSetTriggerPriceDirection() { return IsSetField(Tags.TriggerPriceDirection); }

    public TriggerNewPrice TriggerNewPrice
    {
        get
        {
            TriggerNewPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerNewPrice val) { TriggerNewPrice = val; }
    public TriggerNewPrice Get(TriggerNewPrice val) { GetField(val); return val; }
    public bool IsSet(TriggerNewPrice val) { return IsSetTriggerNewPrice(); }
    public bool IsSetTriggerNewPrice() { return IsSetField(Tags.TriggerNewPrice); }

    public TriggerOrderType TriggerOrderType
    {
        get
        {
            TriggerOrderType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerOrderType val) { TriggerOrderType = val; }
    public TriggerOrderType Get(TriggerOrderType val) { GetField(val); return val; }
    public bool IsSet(TriggerOrderType val) { return IsSetTriggerOrderType(); }
    public bool IsSetTriggerOrderType() { return IsSetField(Tags.TriggerOrderType); }

    public TriggerNewQty TriggerNewQty
    {
        get
        {
            TriggerNewQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerNewQty val) { TriggerNewQty = val; }
    public TriggerNewQty Get(TriggerNewQty val) { GetField(val); return val; }
    public bool IsSet(TriggerNewQty val) { return IsSetTriggerNewQty(); }
    public bool IsSetTriggerNewQty() { return IsSetField(Tags.TriggerNewQty); }

    public TriggerTradingSessionID TriggerTradingSessionID
    {
        get
        {
            TriggerTradingSessionID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerTradingSessionID val) { TriggerTradingSessionID = val; }
    public TriggerTradingSessionID Get(TriggerTradingSessionID val) { GetField(val); return val; }
    public bool IsSet(TriggerTradingSessionID val) { return IsSetTriggerTradingSessionID(); }
    public bool IsSetTriggerTradingSessionID() { return IsSetField(Tags.TriggerTradingSessionID); }

    public TriggerTradingSessionSubID TriggerTradingSessionSubID
    {
        get
        {
            TriggerTradingSessionSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TriggerTradingSessionSubID val) { TriggerTradingSessionSubID = val; }
    public TriggerTradingSessionSubID Get(TriggerTradingSessionSubID val) { GetField(val); return val; }
    public bool IsSet(TriggerTradingSessionSubID val) { return IsSetTriggerTradingSessionSubID(); }
    public bool IsSetTriggerTradingSessionSubID() { return IsSetField(Tags.TriggerTradingSessionSubID); }

    public PreTradeAnonymity PreTradeAnonymity
    {
        get
        {
            PreTradeAnonymity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PreTradeAnonymity val) { PreTradeAnonymity = val; }
    public PreTradeAnonymity Get(PreTradeAnonymity val) { GetField(val); return val; }
    public bool IsSet(PreTradeAnonymity val) { return IsSetPreTradeAnonymity(); }
    public bool IsSetPreTradeAnonymity() { return IsSetField(Tags.PreTradeAnonymity); }

    public RefOrderID RefOrderID
    {
        get
        {
            RefOrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefOrderID val) { RefOrderID = val; }
    public RefOrderID Get(RefOrderID val) { GetField(val); return val; }
    public bool IsSet(RefOrderID val) { return IsSetRefOrderID(); }
    public bool IsSetRefOrderID() { return IsSetField(Tags.RefOrderID); }

    public RefOrderIDSource RefOrderIDSource
    {
        get
        {
            RefOrderIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefOrderIDSource val) { RefOrderIDSource = val; }
    public RefOrderIDSource Get(RefOrderIDSource val) { GetField(val); return val; }
    public bool IsSet(RefOrderIDSource val) { return IsSetRefOrderIDSource(); }
    public bool IsSetRefOrderIDSource() { return IsSetField(Tags.RefOrderIDSource); }

    public ExDestinationIDSource ExDestinationIDSource
    {
        get
        {
            ExDestinationIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExDestinationIDSource val) { ExDestinationIDSource = val; }
    public ExDestinationIDSource Get(ExDestinationIDSource val) { GetField(val); return val; }
    public bool IsSet(ExDestinationIDSource val) { return IsSetExDestinationIDSource(); }
    public bool IsSetExDestinationIDSource() { return IsSetField(Tags.ExDestinationIDSource); }

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

    public MarketSegmentID MarketSegmentID
    {
        get
        {
            MarketSegmentID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketSegmentID val) { MarketSegmentID = val; }
    public MarketSegmentID Get(MarketSegmentID val) { GetField(val); return val; }
    public bool IsSet(MarketSegmentID val) { return IsSetMarketSegmentID(); }
    public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

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

    public NoOrderAttributes NoOrderAttributes
    {
        get
        {
            NoOrderAttributes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoOrderAttributes val) { NoOrderAttributes = val; }
    public NoOrderAttributes Get(NoOrderAttributes val) { GetField(val); return val; }
    public bool IsSet(NoOrderAttributes val) { return IsSetNoOrderAttributes(); }
    public bool IsSetNoOrderAttributes() { return IsSetField(Tags.NoOrderAttributes); }

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

    public NumDaysInterest NumDaysInterest
    {
        get
        {
            NumDaysInterest val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NumDaysInterest val) { NumDaysInterest = val; }
    public NumDaysInterest Get(NumDaysInterest val) { GetField(val); return val; }
    public bool IsSet(NumDaysInterest val) { return IsSetNumDaysInterest(); }
    public bool IsSetNumDaysInterest() { return IsSetField(Tags.NumDaysInterest); }

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

    public TrdType TrdType
    {
        get
        {
            TrdType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TrdType val) { TrdType = val; }
    public TrdType Get(TrdType val) { GetField(val); return val; }
    public bool IsSet(TrdType val) { return IsSetTrdType(); }
    public bool IsSetTrdType() { return IsSetField(Tags.TrdType); }

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

    public TradeContinuation TradeContinuation
    {
        get
        {
            TradeContinuation val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeContinuation val) { TradeContinuation = val; }
    public TradeContinuation Get(TradeContinuation val) { GetField(val); return val; }
    public bool IsSet(TradeContinuation val) { return IsSetTradeContinuation(); }
    public bool IsSetTradeContinuation() { return IsSetField(Tags.TradeContinuation); }

    public Tenor Tenor
    {
        get
        {
            Tenor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Tenor val) { Tenor = val; }
    public Tenor Get(Tenor val) { GetField(val); return val; }
    public bool IsSet(Tenor val) { return IsSetTenor(); }
    public bool IsSetTenor() { return IsSetField(Tags.Tenor); }

    public ApplyRestriction ApplyRestriction
    {
        get
        {
            ApplyRestriction val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplyRestriction val) { ApplyRestriction = val; }
    public ApplyRestriction Get(ApplyRestriction val) { GetField(val); return val; }
    public bool IsSet(ApplyRestriction val) { return IsSetApplyRestriction(); }
    public bool IsSetApplyRestriction() { return IsSetField(Tags.ApplyRestriction); }

    public StagedOrderIsInquiry StagedOrderIsInquiry
    {
        get
        {
            StagedOrderIsInquiry val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StagedOrderIsInquiry val) { StagedOrderIsInquiry = val; }
    public StagedOrderIsInquiry Get(StagedOrderIsInquiry val) { GetField(val); return val; }
    public bool IsSet(StagedOrderIsInquiry val) { return IsSetStagedOrderIsInquiry(); }
    public bool IsSetStagedOrderIsInquiry() { return IsSetField(Tags.StagedOrderIsInquiry); }

    public Ccy1MarketType Ccy1MarketType
    {
        get
        {
            Ccy1MarketType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Ccy1MarketType val) { Ccy1MarketType = val; }
    public Ccy1MarketType Get(Ccy1MarketType val) { GetField(val); return val; }
    public bool IsSet(Ccy1MarketType val) { return IsSetCcy1MarketType(); }
    public bool IsSetCcy1MarketType() { return IsSetField(Tags.Ccy1MarketType); }

    public Ccy2MarketType Ccy2MarketType
    {
        get
        {
            Ccy2MarketType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Ccy2MarketType val) { Ccy2MarketType = val; }
    public Ccy2MarketType Get(Ccy2MarketType val) { GetField(val); return val; }
    public bool IsSet(Ccy2MarketType val) { return IsSetCcy2MarketType(); }
    public bool IsSetCcy2MarketType() { return IsSetField(Tags.Ccy2MarketType); }

    public AutoOrdType AutoOrdType
    {
        get
        {
            AutoOrdType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AutoOrdType val) { AutoOrdType = val; }
    public AutoOrdType Get(AutoOrdType val) { GetField(val); return val; }
    public bool IsSet(AutoOrdType val) { return IsSetAutoOrdType(); }
    public bool IsSetAutoOrdType() { return IsSetField(Tags.AutoOrdType); }

    public AllocationType AllocationType
    {
        get
        {
            AllocationType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocationType val) { AllocationType = val; }
    public AllocationType Get(AllocationType val) { GetField(val); return val; }
    public bool IsSet(AllocationType val) { return IsSetAllocationType(); }
    public bool IsSetAllocationType() { return IsSetField(Tags.AllocationType); }

    public FixingDate FixingDate
    {
        get
        {
            FixingDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FixingDate val) { FixingDate = val; }
    public FixingDate Get(FixingDate val) { GetField(val); return val; }
    public bool IsSet(FixingDate val) { return IsSetFixingDate(); }
    public bool IsSetFixingDate() { return IsSetField(Tags.FixingDate); }

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

    public NoExecRuleNames NoExecRuleNames
    {
        get
        {
            NoExecRuleNames val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoExecRuleNames val) { NoExecRuleNames = val; }
    public NoExecRuleNames Get(NoExecRuleNames val) { GetField(val); return val; }
    public bool IsSet(NoExecRuleNames val) { return IsSetNoExecRuleNames(); }
    public bool IsSetNoExecRuleNames() { return IsSetField(Tags.NoExecRuleNames); }

    public NoNotes NoNotes
    {
        get
        {
            NoNotes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoNotes val) { NoNotes = val; }
    public NoNotes Get(NoNotes val) { GetField(val); return val; }
    public bool IsSet(NoNotes val) { return IsSetNoNotes(); }
    public bool IsSetNoNotes() { return IsSetField(Tags.NoNotes); }

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

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

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

        public class NoPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartySubID, Tags.PartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
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
    }

    public class NoAllocsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, 0};

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

        public AllocAcctIDSource AllocAcctIDSource
        {
            get
            {
                AllocAcctIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocAcctIDSource val) { AllocAcctIDSource = val; }
        public AllocAcctIDSource Get(AllocAcctIDSource val) { GetField(val); return val; }
        public bool IsSet(AllocAcctIDSource val) { return IsSetAllocAcctIDSource(); }
        public bool IsSetAllocAcctIDSource() { return IsSetField(Tags.AllocAcctIDSource); }

        public AllocSettlCurrency AllocSettlCurrency
        {
            get
            {
                AllocSettlCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocSettlCurrency val) { AllocSettlCurrency = val; }
        public AllocSettlCurrency Get(AllocSettlCurrency val) { GetField(val); return val; }
        public bool IsSet(AllocSettlCurrency val) { return IsSetAllocSettlCurrency(); }
        public bool IsSetAllocSettlCurrency() { return IsSetField(Tags.AllocSettlCurrency); }

        public IndividualAllocID IndividualAllocID
        {
            get
            {
                IndividualAllocID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IndividualAllocID val) { IndividualAllocID = val; }
        public IndividualAllocID Get(IndividualAllocID val) { GetField(val); return val; }
        public bool IsSet(IndividualAllocID val) { return IsSetIndividualAllocID(); }
        public bool IsSetIndividualAllocID() { return IsSetField(Tags.IndividualAllocID); }

        public NoNestedPartyIDs NoNestedPartyIDs
        {
            get
            {
                NoNestedPartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNestedPartyIDs val) { NoNestedPartyIDs = val; }
        public NoNestedPartyIDs Get(NoNestedPartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNestedPartyIDs val) { return IsSetNoNestedPartyIDs(); }
        public bool IsSetNoNestedPartyIDs() { return IsSetField(Tags.NoNestedPartyIDs); }

        public AllocQty AllocQty
        {
            get
            {
                AllocQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocQty val) { AllocQty = val; }
        public AllocQty Get(AllocQty val) { GetField(val); return val; }
        public bool IsSet(AllocQty val) { return IsSetAllocQty(); }
        public bool IsSetAllocQty() { return IsSetField(Tags.AllocQty); }

        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};

            public NoNestedPartyIDsGroup()
              : base(Tags.NoNestedPartyIDs, Tags.NestedPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public NestedPartyID NestedPartyID
            {
                get
                {
                    NestedPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyID val) { NestedPartyID = val; }
            public NestedPartyID Get(NestedPartyID val) { GetField(val); return val; }
            public bool IsSet(NestedPartyID val) { return IsSetNestedPartyID(); }
            public bool IsSetNestedPartyID() { return IsSetField(Tags.NestedPartyID); }

            public NestedPartyIDSource NestedPartyIDSource
            {
                get
                {
                    NestedPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyIDSource val) { NestedPartyIDSource = val; }
            public NestedPartyIDSource Get(NestedPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(NestedPartyIDSource val) { return IsSetNestedPartyIDSource(); }
            public bool IsSetNestedPartyIDSource() { return IsSetField(Tags.NestedPartyIDSource); }

            public NestedPartyRole NestedPartyRole
            {
                get
                {
                    NestedPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyRole val) { NestedPartyRole = val; }
            public NestedPartyRole Get(NestedPartyRole val) { GetField(val); return val; }
            public bool IsSet(NestedPartyRole val) { return IsSetNestedPartyRole(); }
            public bool IsSetNestedPartyRole() { return IsSetField(Tags.NestedPartyRole); }

            public NoNestedPartySubIDs NoNestedPartySubIDs
            {
                get
                {
                    NoNestedPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNestedPartySubIDs val) { NoNestedPartySubIDs = val; }
            public NoNestedPartySubIDs Get(NoNestedPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNestedPartySubIDs val) { return IsSetNoNestedPartySubIDs(); }
            public bool IsSetNoNestedPartySubIDs() { return IsSetField(Tags.NoNestedPartySubIDs); }

            public class NoNestedPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
                public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};

                public NoNestedPartySubIDsGroup()
                  : base(Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNestedPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public NestedPartySubID NestedPartySubID
                {
                    get
                    {
                        NestedPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubID val) { NestedPartySubID = val; }
                public NestedPartySubID Get(NestedPartySubID val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubID val) { return IsSetNestedPartySubID(); }
                public bool IsSetNestedPartySubID() { return IsSetField(Tags.NestedPartySubID); }

                public NestedPartySubIDType NestedPartySubIDType
                {
                    get
                    {
                        NestedPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubIDType val) { NestedPartySubIDType = val; }
                public NestedPartySubIDType Get(NestedPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubIDType val) { return IsSetNestedPartySubIDType(); }
                public bool IsSetNestedPartySubIDType() { return IsSetField(Tags.NestedPartySubIDType); }
            }
        }
    }

    public class NoTradingSessionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TradingSessionID, Tags.TradingSessionSubID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, 0};

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

        public TradingSessionSubID TradingSessionSubID
        {
            get
            {
                TradingSessionSubID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionSubID val) { TradingSessionSubID = val; }
        public TradingSessionSubID Get(TradingSessionSubID val) { GetField(val); return val; }
        public bool IsSet(TradingSessionSubID val) { return IsSetTradingSessionSubID(); }
        public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }
    }

    public class NoSecurityAltIDGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.SecurityAltID, Tags.SecurityAltIDSource, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

        public NoSecurityAltIDGroup()
          : base(Tags.NoSecurityAltID, Tags.SecurityAltID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSecurityAltIDGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public SecurityAltID SecurityAltID
        {
            get
            {
                SecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityAltID val) { SecurityAltID = val; }
        public SecurityAltID Get(SecurityAltID val) { GetField(val); return val; }
        public bool IsSet(SecurityAltID val) { return IsSetSecurityAltID(); }
        public bool IsSetSecurityAltID() { return IsSetField(Tags.SecurityAltID); }

        public SecurityAltIDSource SecurityAltIDSource
        {
            get
            {
                SecurityAltIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityAltIDSource val) { SecurityAltIDSource = val; }
        public SecurityAltIDSource Get(SecurityAltIDSource val) { GetField(val); return val; }
        public bool IsSet(SecurityAltIDSource val) { return IsSetSecurityAltIDSource(); }
        public bool IsSetSecurityAltIDSource() { return IsSetField(Tags.SecurityAltIDSource); }
    }

    public class NoEventsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};

        public NoEventsGroup()
          : base(Tags.NoEvents, Tags.EventType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoEventsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public EventType EventType
        {
            get
            {
                EventType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventType val) { EventType = val; }
        public EventType Get(EventType val) { GetField(val); return val; }
        public bool IsSet(EventType val) { return IsSetEventType(); }
        public bool IsSetEventType() { return IsSetField(Tags.EventType); }

        public EventDate EventDate
        {
            get
            {
                EventDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventDate val) { EventDate = val; }
        public EventDate Get(EventDate val) { GetField(val); return val; }
        public bool IsSet(EventDate val) { return IsSetEventDate(); }
        public bool IsSetEventDate() { return IsSetField(Tags.EventDate); }

        public EventPx EventPx
        {
            get
            {
                EventPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventPx val) { EventPx = val; }
        public EventPx Get(EventPx val) { GetField(val); return val; }
        public bool IsSet(EventPx val) { return IsSetEventPx(); }
        public bool IsSetEventPx() { return IsSetField(Tags.EventPx); }

        public EventText EventText
        {
            get
            {
                EventText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventText val) { EventText = val; }
        public EventText Get(EventText val) { GetField(val); return val; }
        public bool IsSet(EventText val) { return IsSetEventText(); }
        public bool IsSetEventText() { return IsSetField(Tags.EventText); }

        public EventTime EventTime
        {
            get
            {
                EventTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventTime val) { EventTime = val; }
        public EventTime Get(EventTime val) { GetField(val); return val; }
        public bool IsSet(EventTime val) { return IsSetEventTime(); }
        public bool IsSetEventTime() { return IsSetField(Tags.EventTime); }
    }

    public class NoInstrumentPartiesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};

        public NoInstrumentPartiesGroup()
          : base(Tags.NoInstrumentParties, Tags.InstrumentPartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoInstrumentPartiesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public InstrumentPartyID InstrumentPartyID
        {
            get
            {
                InstrumentPartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyID val) { InstrumentPartyID = val; }
        public InstrumentPartyID Get(InstrumentPartyID val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyID val) { return IsSetInstrumentPartyID(); }
        public bool IsSetInstrumentPartyID() { return IsSetField(Tags.InstrumentPartyID); }

        public InstrumentPartyIDSource InstrumentPartyIDSource
        {
            get
            {
                InstrumentPartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyIDSource val) { InstrumentPartyIDSource = val; }
        public InstrumentPartyIDSource Get(InstrumentPartyIDSource val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyIDSource val) { return IsSetInstrumentPartyIDSource(); }
        public bool IsSetInstrumentPartyIDSource() { return IsSetField(Tags.InstrumentPartyIDSource); }

        public InstrumentPartyRole InstrumentPartyRole
        {
            get
            {
                InstrumentPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyRole val) { InstrumentPartyRole = val; }
        public InstrumentPartyRole Get(InstrumentPartyRole val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyRole val) { return IsSetInstrumentPartyRole(); }
        public bool IsSetInstrumentPartyRole() { return IsSetField(Tags.InstrumentPartyRole); }

        public NoInstrumentPartySubIDs NoInstrumentPartySubIDs
        {
            get
            {
                NoInstrumentPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoInstrumentPartySubIDs val) { NoInstrumentPartySubIDs = val; }
        public NoInstrumentPartySubIDs Get(NoInstrumentPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoInstrumentPartySubIDs val) { return IsSetNoInstrumentPartySubIDs(); }
        public bool IsSetNoInstrumentPartySubIDs() { return IsSetField(Tags.NoInstrumentPartySubIDs); }

        public class NoInstrumentPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};

            public NoInstrumentPartySubIDsGroup()
              : base(Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public InstrumentPartySubID InstrumentPartySubID
            {
                get
                {
                    InstrumentPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartySubID val) { InstrumentPartySubID = val; }
            public InstrumentPartySubID Get(InstrumentPartySubID val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartySubID val) { return IsSetInstrumentPartySubID(); }
            public bool IsSetInstrumentPartySubID() { return IsSetField(Tags.InstrumentPartySubID); }

            public InstrumentPartySubIDType InstrumentPartySubIDType
            {
                get
                {
                    InstrumentPartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartySubIDType val) { InstrumentPartySubIDType = val; }
            public InstrumentPartySubIDType Get(InstrumentPartySubIDType val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartySubIDType val) { return IsSetInstrumentPartySubIDType(); }
            public bool IsSetInstrumentPartySubIDType() { return IsSetField(Tags.InstrumentPartySubIDType); }
        }
    }

    public class NoComplexEventsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};

        public NoComplexEventsGroup()
          : base(Tags.NoComplexEvents, Tags.ComplexEventType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoComplexEventsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ComplexEventType ComplexEventType
        {
            get
            {
                ComplexEventType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventType val) { ComplexEventType = val; }
        public ComplexEventType Get(ComplexEventType val) { GetField(val); return val; }
        public bool IsSet(ComplexEventType val) { return IsSetComplexEventType(); }
        public bool IsSetComplexEventType() { return IsSetField(Tags.ComplexEventType); }

        public ComplexOptPayoutAmount ComplexOptPayoutAmount
        {
            get
            {
                ComplexOptPayoutAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexOptPayoutAmount val) { ComplexOptPayoutAmount = val; }
        public ComplexOptPayoutAmount Get(ComplexOptPayoutAmount val) { GetField(val); return val; }
        public bool IsSet(ComplexOptPayoutAmount val) { return IsSetComplexOptPayoutAmount(); }
        public bool IsSetComplexOptPayoutAmount() { return IsSetField(Tags.ComplexOptPayoutAmount); }

        public ComplexEventPrice ComplexEventPrice
        {
            get
            {
                ComplexEventPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventPrice val) { ComplexEventPrice = val; }
        public ComplexEventPrice Get(ComplexEventPrice val) { GetField(val); return val; }
        public bool IsSet(ComplexEventPrice val) { return IsSetComplexEventPrice(); }
        public bool IsSetComplexEventPrice() { return IsSetField(Tags.ComplexEventPrice); }

        public ComplexEventPriceBoundaryMethod ComplexEventPriceBoundaryMethod
        {
            get
            {
                ComplexEventPriceBoundaryMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventPriceBoundaryMethod val) { ComplexEventPriceBoundaryMethod = val; }
        public ComplexEventPriceBoundaryMethod Get(ComplexEventPriceBoundaryMethod val) { GetField(val); return val; }
        public bool IsSet(ComplexEventPriceBoundaryMethod val) { return IsSetComplexEventPriceBoundaryMethod(); }
        public bool IsSetComplexEventPriceBoundaryMethod() { return IsSetField(Tags.ComplexEventPriceBoundaryMethod); }

        public ComplexEventPriceBoundaryPrecision ComplexEventPriceBoundaryPrecision
        {
            get
            {
                ComplexEventPriceBoundaryPrecision val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventPriceBoundaryPrecision val) { ComplexEventPriceBoundaryPrecision = val; }
        public ComplexEventPriceBoundaryPrecision Get(ComplexEventPriceBoundaryPrecision val) { GetField(val); return val; }
        public bool IsSet(ComplexEventPriceBoundaryPrecision val) { return IsSetComplexEventPriceBoundaryPrecision(); }
        public bool IsSetComplexEventPriceBoundaryPrecision() { return IsSetField(Tags.ComplexEventPriceBoundaryPrecision); }

        public ComplexEventPriceTimeType ComplexEventPriceTimeType
        {
            get
            {
                ComplexEventPriceTimeType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventPriceTimeType val) { ComplexEventPriceTimeType = val; }
        public ComplexEventPriceTimeType Get(ComplexEventPriceTimeType val) { GetField(val); return val; }
        public bool IsSet(ComplexEventPriceTimeType val) { return IsSetComplexEventPriceTimeType(); }
        public bool IsSetComplexEventPriceTimeType() { return IsSetField(Tags.ComplexEventPriceTimeType); }

        public ComplexEventCondition ComplexEventCondition
        {
            get
            {
                ComplexEventCondition val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventCondition val) { ComplexEventCondition = val; }
        public ComplexEventCondition Get(ComplexEventCondition val) { GetField(val); return val; }
        public bool IsSet(ComplexEventCondition val) { return IsSetComplexEventCondition(); }
        public bool IsSetComplexEventCondition() { return IsSetField(Tags.ComplexEventCondition); }

        public NoComplexEventDates NoComplexEventDates
        {
            get
            {
                NoComplexEventDates val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoComplexEventDates val) { NoComplexEventDates = val; }
        public NoComplexEventDates Get(NoComplexEventDates val) { GetField(val); return val; }
        public bool IsSet(NoComplexEventDates val) { return IsSetNoComplexEventDates(); }
        public bool IsSetNoComplexEventDates() { return IsSetField(Tags.NoComplexEventDates); }

        public class NoComplexEventDatesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};

            public NoComplexEventDatesGroup()
              : base(Tags.NoComplexEventDates, Tags.ComplexEventStartDate, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoComplexEventDatesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ComplexEventStartDate ComplexEventStartDate
            {
                get
                {
                    ComplexEventStartDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventStartDate val) { ComplexEventStartDate = val; }
            public ComplexEventStartDate Get(ComplexEventStartDate val) { GetField(val); return val; }
            public bool IsSet(ComplexEventStartDate val) { return IsSetComplexEventStartDate(); }
            public bool IsSetComplexEventStartDate() { return IsSetField(Tags.ComplexEventStartDate); }

            public ComplexEventEndDate ComplexEventEndDate
            {
                get
                {
                    ComplexEventEndDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventEndDate val) { ComplexEventEndDate = val; }
            public ComplexEventEndDate Get(ComplexEventEndDate val) { GetField(val); return val; }
            public bool IsSet(ComplexEventEndDate val) { return IsSetComplexEventEndDate(); }
            public bool IsSetComplexEventEndDate() { return IsSetField(Tags.ComplexEventEndDate); }

            public NoComplexEventTimes NoComplexEventTimes
            {
                get
                {
                    NoComplexEventTimes val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoComplexEventTimes val) { NoComplexEventTimes = val; }
            public NoComplexEventTimes Get(NoComplexEventTimes val) { GetField(val); return val; }
            public bool IsSet(NoComplexEventTimes val) { return IsSetNoComplexEventTimes(); }
            public bool IsSetNoComplexEventTimes() { return IsSetField(Tags.NoComplexEventTimes); }

            public class NoComplexEventTimesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
                public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};

                public NoComplexEventTimesGroup()
                  : base(Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoComplexEventTimesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public ComplexEventStartTime ComplexEventStartTime
                {
                    get
                    {
                        ComplexEventStartTime val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ComplexEventStartTime val) { ComplexEventStartTime = val; }
                public ComplexEventStartTime Get(ComplexEventStartTime val) { GetField(val); return val; }
                public bool IsSet(ComplexEventStartTime val) { return IsSetComplexEventStartTime(); }
                public bool IsSetComplexEventStartTime() { return IsSetField(Tags.ComplexEventStartTime); }

                public ComplexEventEndTime ComplexEventEndTime
                {
                    get
                    {
                        ComplexEventEndTime val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ComplexEventEndTime val) { ComplexEventEndTime = val; }
                public ComplexEventEndTime Get(ComplexEventEndTime val) { GetField(val); return val; }
                public bool IsSet(ComplexEventEndTime val) { return IsSetComplexEventEndTime(); }
                public bool IsSetComplexEventEndTime() { return IsSetField(Tags.ComplexEventEndTime); }
            }
        }
    }

    public class NoOptionExerciseExpirationDatesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.OptionExerciseExpirationDate, Tags.OptionExerciseExpirationDateType, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.OptionExerciseExpirationDate, Tags.OptionExerciseExpirationDateType, 0};

        public NoOptionExerciseExpirationDatesGroup()
          : base(Tags.NoOptionExerciseExpirationDates, Tags.OptionExerciseExpirationDate, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoOptionExerciseExpirationDatesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public OptionExerciseExpirationDate OptionExerciseExpirationDate
        {
            get
            {
                OptionExerciseExpirationDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptionExerciseExpirationDate val) { OptionExerciseExpirationDate = val; }
        public OptionExerciseExpirationDate Get(OptionExerciseExpirationDate val) { GetField(val); return val; }
        public bool IsSet(OptionExerciseExpirationDate val) { return IsSetOptionExerciseExpirationDate(); }
        public bool IsSetOptionExerciseExpirationDate() { return IsSetField(Tags.OptionExerciseExpirationDate); }

        public OptionExerciseExpirationDateType OptionExerciseExpirationDateType
        {
            get
            {
                OptionExerciseExpirationDateType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptionExerciseExpirationDateType val) { OptionExerciseExpirationDateType = val; }
        public OptionExerciseExpirationDateType Get(OptionExerciseExpirationDateType val) { GetField(val); return val; }
        public bool IsSet(OptionExerciseExpirationDateType val) { return IsSetOptionExerciseExpirationDateType(); }
        public bool IsSetOptionExerciseExpirationDateType() { return IsSetField(Tags.OptionExerciseExpirationDateType); }
    }

    public class NoStreamsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StreamType, Tags.StreamDesc, Tags.StreamPaySide, Tags.StreamReceiveSide, Tags.StreamEffectiveDateAdjusted, Tags.StreamTerminationDateAdjusted, Tags.StreamFirstRegularPeriodStartDateUnadjusted, Tags.StreamLastRegularPeriodEndDateUnadjusted, Tags.PaymentStreamType, Tags.PaymentStreamPaymentFrequencyPeriod, Tags.PaymentStreamPaymentFrequencyUnit, Tags.PaymentStreamResetFrequencyPeriod, Tags.PaymentStreamResetFrequencyUnit, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.StreamType, Tags.StreamDesc, Tags.StreamPaySide, Tags.StreamReceiveSide, Tags.StreamEffectiveDateAdjusted, Tags.StreamTerminationDateAdjusted, Tags.StreamFirstRegularPeriodStartDateUnadjusted, Tags.StreamLastRegularPeriodEndDateUnadjusted, Tags.PaymentStreamType, Tags.PaymentStreamPaymentFrequencyPeriod, Tags.PaymentStreamPaymentFrequencyUnit, Tags.PaymentStreamResetFrequencyPeriod, Tags.PaymentStreamResetFrequencyUnit, 0};

        public NoStreamsGroup()
          : base(Tags.NoStreams, Tags.StreamType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoStreamsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public StreamType StreamType
        {
            get
            {
                StreamType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StreamType val) { StreamType = val; }
        public StreamType Get(StreamType val) { GetField(val); return val; }
        public bool IsSet(StreamType val) { return IsSetStreamType(); }
        public bool IsSetStreamType() { return IsSetField(Tags.StreamType); }

        public StreamDesc StreamDesc
        {
            get
            {
                StreamDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StreamDesc val) { StreamDesc = val; }
        public StreamDesc Get(StreamDesc val) { GetField(val); return val; }
        public bool IsSet(StreamDesc val) { return IsSetStreamDesc(); }
        public bool IsSetStreamDesc() { return IsSetField(Tags.StreamDesc); }

        public StreamPaySide StreamPaySide
        {
            get
            {
                StreamPaySide val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StreamPaySide val) { StreamPaySide = val; }
        public StreamPaySide Get(StreamPaySide val) { GetField(val); return val; }
        public bool IsSet(StreamPaySide val) { return IsSetStreamPaySide(); }
        public bool IsSetStreamPaySide() { return IsSetField(Tags.StreamPaySide); }

        public StreamReceiveSide StreamReceiveSide
        {
            get
            {
                StreamReceiveSide val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StreamReceiveSide val) { StreamReceiveSide = val; }
        public StreamReceiveSide Get(StreamReceiveSide val) { GetField(val); return val; }
        public bool IsSet(StreamReceiveSide val) { return IsSetStreamReceiveSide(); }
        public bool IsSetStreamReceiveSide() { return IsSetField(Tags.StreamReceiveSide); }

        public StreamEffectiveDateAdjusted StreamEffectiveDateAdjusted
        {
            get
            {
                StreamEffectiveDateAdjusted val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StreamEffectiveDateAdjusted val) { StreamEffectiveDateAdjusted = val; }
        public StreamEffectiveDateAdjusted Get(StreamEffectiveDateAdjusted val) { GetField(val); return val; }
        public bool IsSet(StreamEffectiveDateAdjusted val) { return IsSetStreamEffectiveDateAdjusted(); }
        public bool IsSetStreamEffectiveDateAdjusted() { return IsSetField(Tags.StreamEffectiveDateAdjusted); }

        public StreamTerminationDateAdjusted StreamTerminationDateAdjusted
        {
            get
            {
                StreamTerminationDateAdjusted val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StreamTerminationDateAdjusted val) { StreamTerminationDateAdjusted = val; }
        public StreamTerminationDateAdjusted Get(StreamTerminationDateAdjusted val) { GetField(val); return val; }
        public bool IsSet(StreamTerminationDateAdjusted val) { return IsSetStreamTerminationDateAdjusted(); }
        public bool IsSetStreamTerminationDateAdjusted() { return IsSetField(Tags.StreamTerminationDateAdjusted); }

        public StreamFirstRegularPeriodStartDateUnadjusted StreamFirstRegularPeriodStartDateUnadjusted
        {
            get
            {
                StreamFirstRegularPeriodStartDateUnadjusted val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StreamFirstRegularPeriodStartDateUnadjusted val) { StreamFirstRegularPeriodStartDateUnadjusted = val; }
        public StreamFirstRegularPeriodStartDateUnadjusted Get(StreamFirstRegularPeriodStartDateUnadjusted val) { GetField(val); return val; }
        public bool IsSet(StreamFirstRegularPeriodStartDateUnadjusted val) { return IsSetStreamFirstRegularPeriodStartDateUnadjusted(); }
        public bool IsSetStreamFirstRegularPeriodStartDateUnadjusted() { return IsSetField(Tags.StreamFirstRegularPeriodStartDateUnadjusted); }

        public StreamLastRegularPeriodEndDateUnadjusted StreamLastRegularPeriodEndDateUnadjusted
        {
            get
            {
                StreamLastRegularPeriodEndDateUnadjusted val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StreamLastRegularPeriodEndDateUnadjusted val) { StreamLastRegularPeriodEndDateUnadjusted = val; }
        public StreamLastRegularPeriodEndDateUnadjusted Get(StreamLastRegularPeriodEndDateUnadjusted val) { GetField(val); return val; }
        public bool IsSet(StreamLastRegularPeriodEndDateUnadjusted val) { return IsSetStreamLastRegularPeriodEndDateUnadjusted(); }
        public bool IsSetStreamLastRegularPeriodEndDateUnadjusted() { return IsSetField(Tags.StreamLastRegularPeriodEndDateUnadjusted); }

        public PaymentStreamType PaymentStreamType
        {
            get
            {
                PaymentStreamType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentStreamType val) { PaymentStreamType = val; }
        public PaymentStreamType Get(PaymentStreamType val) { GetField(val); return val; }
        public bool IsSet(PaymentStreamType val) { return IsSetPaymentStreamType(); }
        public bool IsSetPaymentStreamType() { return IsSetField(Tags.PaymentStreamType); }

        public PaymentStreamPaymentFrequencyPeriod PaymentStreamPaymentFrequencyPeriod
        {
            get
            {
                PaymentStreamPaymentFrequencyPeriod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentStreamPaymentFrequencyPeriod val) { PaymentStreamPaymentFrequencyPeriod = val; }
        public PaymentStreamPaymentFrequencyPeriod Get(PaymentStreamPaymentFrequencyPeriod val) { GetField(val); return val; }
        public bool IsSet(PaymentStreamPaymentFrequencyPeriod val) { return IsSetPaymentStreamPaymentFrequencyPeriod(); }
        public bool IsSetPaymentStreamPaymentFrequencyPeriod() { return IsSetField(Tags.PaymentStreamPaymentFrequencyPeriod); }

        public PaymentStreamPaymentFrequencyUnit PaymentStreamPaymentFrequencyUnit
        {
            get
            {
                PaymentStreamPaymentFrequencyUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentStreamPaymentFrequencyUnit val) { PaymentStreamPaymentFrequencyUnit = val; }
        public PaymentStreamPaymentFrequencyUnit Get(PaymentStreamPaymentFrequencyUnit val) { GetField(val); return val; }
        public bool IsSet(PaymentStreamPaymentFrequencyUnit val) { return IsSetPaymentStreamPaymentFrequencyUnit(); }
        public bool IsSetPaymentStreamPaymentFrequencyUnit() { return IsSetField(Tags.PaymentStreamPaymentFrequencyUnit); }

        public PaymentStreamResetFrequencyPeriod PaymentStreamResetFrequencyPeriod
        {
            get
            {
                PaymentStreamResetFrequencyPeriod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentStreamResetFrequencyPeriod val) { PaymentStreamResetFrequencyPeriod = val; }
        public PaymentStreamResetFrequencyPeriod Get(PaymentStreamResetFrequencyPeriod val) { GetField(val); return val; }
        public bool IsSet(PaymentStreamResetFrequencyPeriod val) { return IsSetPaymentStreamResetFrequencyPeriod(); }
        public bool IsSetPaymentStreamResetFrequencyPeriod() { return IsSetField(Tags.PaymentStreamResetFrequencyPeriod); }

        public PaymentStreamResetFrequencyUnit PaymentStreamResetFrequencyUnit
        {
            get
            {
                PaymentStreamResetFrequencyUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentStreamResetFrequencyUnit val) { PaymentStreamResetFrequencyUnit = val; }
        public PaymentStreamResetFrequencyUnit Get(PaymentStreamResetFrequencyUnit val) { GetField(val); return val; }
        public bool IsSet(PaymentStreamResetFrequencyUnit val) { return IsSetPaymentStreamResetFrequencyUnit(); }
        public bool IsSetPaymentStreamResetFrequencyUnit() { return IsSetField(Tags.PaymentStreamResetFrequencyUnit); }
    }

    public class NoContractualDefinitionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ContractualDefinition, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.ContractualDefinition, 0};

        public NoContractualDefinitionsGroup()
          : base(Tags.NoContractualDefinitions, Tags.ContractualDefinition, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoContractualDefinitionsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ContractualDefinition ContractualDefinition
        {
            get
            {
                ContractualDefinition val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractualDefinition val) { ContractualDefinition = val; }
        public ContractualDefinition Get(ContractualDefinition val) { GetField(val); return val; }
        public bool IsSet(ContractualDefinition val) { return IsSetContractualDefinition(); }
        public bool IsSetContractualDefinition() { return IsSetField(Tags.ContractualDefinition); }
    }

    public class NoContractualMatricesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ContractualMatrixSource, Tags.ContractualMatrixDate, Tags.ContractualMatrixTerm, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.ContractualMatrixSource, Tags.ContractualMatrixDate, Tags.ContractualMatrixTerm, 0};

        public NoContractualMatricesGroup()
          : base(Tags.NoContractualMatrices, Tags.ContractualMatrixSource, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoContractualMatricesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ContractualMatrixSource ContractualMatrixSource
        {
            get
            {
                ContractualMatrixSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractualMatrixSource val) { ContractualMatrixSource = val; }
        public ContractualMatrixSource Get(ContractualMatrixSource val) { GetField(val); return val; }
        public bool IsSet(ContractualMatrixSource val) { return IsSetContractualMatrixSource(); }
        public bool IsSetContractualMatrixSource() { return IsSetField(Tags.ContractualMatrixSource); }

        public ContractualMatrixDate ContractualMatrixDate
        {
            get
            {
                ContractualMatrixDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractualMatrixDate val) { ContractualMatrixDate = val; }
        public ContractualMatrixDate Get(ContractualMatrixDate val) { GetField(val); return val; }
        public bool IsSet(ContractualMatrixDate val) { return IsSetContractualMatrixDate(); }
        public bool IsSetContractualMatrixDate() { return IsSetField(Tags.ContractualMatrixDate); }

        public ContractualMatrixTerm ContractualMatrixTerm
        {
            get
            {
                ContractualMatrixTerm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractualMatrixTerm val) { ContractualMatrixTerm = val; }
        public ContractualMatrixTerm Get(ContractualMatrixTerm val) { GetField(val); return val; }
        public bool IsSet(ContractualMatrixTerm val) { return IsSetContractualMatrixTerm(); }
        public bool IsSetContractualMatrixTerm() { return IsSetField(Tags.ContractualMatrixTerm); }
    }

    public class NoUnderlyingsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.UnderlyingContractMultiplierUnit, Tags.UnderlyingFlowScheduleType, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingNotionalPercentageOutstanding, Tags.UnderlyingOriginalNotionalPercentageOutstanding, Tags.UnderlyingAttachmentPoint, Tags.UnderlyingDetachmentPoint, Tags.UnderlyingCouponFrequencyPeriod, Tags.UnderlyingCouponFrequencyUnit, Tags.UnderlyingCouponDayCount, Tags.UnderlyingObligationID, Tags.UnderlyingObligationIDSource, Tags.NoUnderlyingEvents, Tags.UnderlyingIndexSeries, Tags.UnderlyingIndexAnnexVersion, Tags.UnderlyingIndexAnnexDate, Tags.UnderlyingIndexAnnexSource, Tags.UnderlyingAssetClass, Tags.UnderlyingAssetSubClass, Tags.NoUnderlyingStreams, Tags.UnderlyingStartAcrdIntAmt, Tags.UnderlyingEndAcrdIntAmt, Tags.UnderlyingPriceType, Tags.UnderlyingCouponDateGenerationMethod, Tags.UnderlyingIndexCurvePeriod, Tags.UnderlyingIndexCurveUnit, Tags.NoUnderlyingReinvCoupon, Tags.UnderlyingSecuritySeries, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.UnderlyingContractMultiplierUnit, Tags.UnderlyingFlowScheduleType, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingNotionalPercentageOutstanding, Tags.UnderlyingOriginalNotionalPercentageOutstanding, Tags.UnderlyingAttachmentPoint, Tags.UnderlyingDetachmentPoint, Tags.UnderlyingCouponFrequencyPeriod, Tags.UnderlyingCouponFrequencyUnit, Tags.UnderlyingCouponDayCount, Tags.UnderlyingObligationID, Tags.UnderlyingObligationIDSource, Tags.NoUnderlyingEvents, Tags.UnderlyingIndexSeries, Tags.UnderlyingIndexAnnexVersion, Tags.UnderlyingIndexAnnexDate, Tags.UnderlyingIndexAnnexSource, Tags.UnderlyingAssetClass, Tags.UnderlyingAssetSubClass, Tags.NoUnderlyingStreams, Tags.UnderlyingStartAcrdIntAmt, Tags.UnderlyingEndAcrdIntAmt, Tags.UnderlyingPriceType, Tags.UnderlyingCouponDateGenerationMethod, Tags.UnderlyingIndexCurvePeriod, Tags.UnderlyingIndexCurveUnit, Tags.NoUnderlyingReinvCoupon, Tags.UnderlyingSecuritySeries, 0};

        public NoUnderlyingsGroup()
          : base(Tags.NoUnderlyings, Tags.UnderlyingSymbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUnderlyingsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public UnderlyingSymbolSfx UnderlyingSymbolSfx
        {
            get
            {
                UnderlyingSymbolSfx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSymbolSfx val) { UnderlyingSymbolSfx = val; }
        public UnderlyingSymbolSfx Get(UnderlyingSymbolSfx val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSymbolSfx val) { return IsSetUnderlyingSymbolSfx(); }
        public bool IsSetUnderlyingSymbolSfx() { return IsSetField(Tags.UnderlyingSymbolSfx); }

        public UnderlyingSecurityID UnderlyingSecurityID
        {
            get
            {
                UnderlyingSecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityID val) { UnderlyingSecurityID = val; }
        public UnderlyingSecurityID Get(UnderlyingSecurityID val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityID val) { return IsSetUnderlyingSecurityID(); }
        public bool IsSetUnderlyingSecurityID() { return IsSetField(Tags.UnderlyingSecurityID); }

        public UnderlyingSecurityIDSource UnderlyingSecurityIDSource
        {
            get
            {
                UnderlyingSecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityIDSource val) { UnderlyingSecurityIDSource = val; }
        public UnderlyingSecurityIDSource Get(UnderlyingSecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityIDSource val) { return IsSetUnderlyingSecurityIDSource(); }
        public bool IsSetUnderlyingSecurityIDSource() { return IsSetField(Tags.UnderlyingSecurityIDSource); }

        public NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
        {
            get
            {
                NoUnderlyingSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUnderlyingSecurityAltID val) { NoUnderlyingSecurityAltID = val; }
        public NoUnderlyingSecurityAltID Get(NoUnderlyingSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(NoUnderlyingSecurityAltID val) { return IsSetNoUnderlyingSecurityAltID(); }
        public bool IsSetNoUnderlyingSecurityAltID() { return IsSetField(Tags.NoUnderlyingSecurityAltID); }

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

        public UnderlyingCFICode UnderlyingCFICode
        {
            get
            {
                UnderlyingCFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCFICode val) { UnderlyingCFICode = val; }
        public UnderlyingCFICode Get(UnderlyingCFICode val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCFICode val) { return IsSetUnderlyingCFICode(); }
        public bool IsSetUnderlyingCFICode() { return IsSetField(Tags.UnderlyingCFICode); }

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

        public UnderlyingSecuritySubType UnderlyingSecuritySubType
        {
            get
            {
                UnderlyingSecuritySubType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecuritySubType val) { UnderlyingSecuritySubType = val; }
        public UnderlyingSecuritySubType Get(UnderlyingSecuritySubType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecuritySubType val) { return IsSetUnderlyingSecuritySubType(); }
        public bool IsSetUnderlyingSecuritySubType() { return IsSetField(Tags.UnderlyingSecuritySubType); }

        public UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
        {
            get
            {
                UnderlyingMaturityMonthYear val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingMaturityMonthYear val) { UnderlyingMaturityMonthYear = val; }
        public UnderlyingMaturityMonthYear Get(UnderlyingMaturityMonthYear val) { GetField(val); return val; }
        public bool IsSet(UnderlyingMaturityMonthYear val) { return IsSetUnderlyingMaturityMonthYear(); }
        public bool IsSetUnderlyingMaturityMonthYear() { return IsSetField(Tags.UnderlyingMaturityMonthYear); }

        public UnderlyingMaturityDate UnderlyingMaturityDate
        {
            get
            {
                UnderlyingMaturityDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingMaturityDate val) { UnderlyingMaturityDate = val; }
        public UnderlyingMaturityDate Get(UnderlyingMaturityDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingMaturityDate val) { return IsSetUnderlyingMaturityDate(); }
        public bool IsSetUnderlyingMaturityDate() { return IsSetField(Tags.UnderlyingMaturityDate); }

        public UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
        {
            get
            {
                UnderlyingCouponPaymentDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCouponPaymentDate val) { UnderlyingCouponPaymentDate = val; }
        public UnderlyingCouponPaymentDate Get(UnderlyingCouponPaymentDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCouponPaymentDate val) { return IsSetUnderlyingCouponPaymentDate(); }
        public bool IsSetUnderlyingCouponPaymentDate() { return IsSetField(Tags.UnderlyingCouponPaymentDate); }

        public UnderlyingIssueDate UnderlyingIssueDate
        {
            get
            {
                UnderlyingIssueDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIssueDate val) { UnderlyingIssueDate = val; }
        public UnderlyingIssueDate Get(UnderlyingIssueDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIssueDate val) { return IsSetUnderlyingIssueDate(); }
        public bool IsSetUnderlyingIssueDate() { return IsSetField(Tags.UnderlyingIssueDate); }

        public UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
        {
            get
            {
                UnderlyingRepoCollateralSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRepoCollateralSecurityType val) { UnderlyingRepoCollateralSecurityType = val; }
        public UnderlyingRepoCollateralSecurityType Get(UnderlyingRepoCollateralSecurityType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRepoCollateralSecurityType val) { return IsSetUnderlyingRepoCollateralSecurityType(); }
        public bool IsSetUnderlyingRepoCollateralSecurityType() { return IsSetField(Tags.UnderlyingRepoCollateralSecurityType); }

        public UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
        {
            get
            {
                UnderlyingRepurchaseTerm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRepurchaseTerm val) { UnderlyingRepurchaseTerm = val; }
        public UnderlyingRepurchaseTerm Get(UnderlyingRepurchaseTerm val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRepurchaseTerm val) { return IsSetUnderlyingRepurchaseTerm(); }
        public bool IsSetUnderlyingRepurchaseTerm() { return IsSetField(Tags.UnderlyingRepurchaseTerm); }

        public UnderlyingRepurchaseRate UnderlyingRepurchaseRate
        {
            get
            {
                UnderlyingRepurchaseRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRepurchaseRate val) { UnderlyingRepurchaseRate = val; }
        public UnderlyingRepurchaseRate Get(UnderlyingRepurchaseRate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRepurchaseRate val) { return IsSetUnderlyingRepurchaseRate(); }
        public bool IsSetUnderlyingRepurchaseRate() { return IsSetField(Tags.UnderlyingRepurchaseRate); }

        public UnderlyingFactor UnderlyingFactor
        {
            get
            {
                UnderlyingFactor val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingFactor val) { UnderlyingFactor = val; }
        public UnderlyingFactor Get(UnderlyingFactor val) { GetField(val); return val; }
        public bool IsSet(UnderlyingFactor val) { return IsSetUnderlyingFactor(); }
        public bool IsSetUnderlyingFactor() { return IsSetField(Tags.UnderlyingFactor); }

        public UnderlyingCreditRating UnderlyingCreditRating
        {
            get
            {
                UnderlyingCreditRating val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCreditRating val) { UnderlyingCreditRating = val; }
        public UnderlyingCreditRating Get(UnderlyingCreditRating val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCreditRating val) { return IsSetUnderlyingCreditRating(); }
        public bool IsSetUnderlyingCreditRating() { return IsSetField(Tags.UnderlyingCreditRating); }

        public UnderlyingInstrRegistry UnderlyingInstrRegistry
        {
            get
            {
                UnderlyingInstrRegistry val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingInstrRegistry val) { UnderlyingInstrRegistry = val; }
        public UnderlyingInstrRegistry Get(UnderlyingInstrRegistry val) { GetField(val); return val; }
        public bool IsSet(UnderlyingInstrRegistry val) { return IsSetUnderlyingInstrRegistry(); }
        public bool IsSetUnderlyingInstrRegistry() { return IsSetField(Tags.UnderlyingInstrRegistry); }

        public UnderlyingCountryOfIssue UnderlyingCountryOfIssue
        {
            get
            {
                UnderlyingCountryOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCountryOfIssue val) { UnderlyingCountryOfIssue = val; }
        public UnderlyingCountryOfIssue Get(UnderlyingCountryOfIssue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCountryOfIssue val) { return IsSetUnderlyingCountryOfIssue(); }
        public bool IsSetUnderlyingCountryOfIssue() { return IsSetField(Tags.UnderlyingCountryOfIssue); }

        public UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
        {
            get
            {
                UnderlyingStateOrProvinceOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStateOrProvinceOfIssue val) { UnderlyingStateOrProvinceOfIssue = val; }
        public UnderlyingStateOrProvinceOfIssue Get(UnderlyingStateOrProvinceOfIssue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStateOrProvinceOfIssue val) { return IsSetUnderlyingStateOrProvinceOfIssue(); }
        public bool IsSetUnderlyingStateOrProvinceOfIssue() { return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue); }

        public UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
        {
            get
            {
                UnderlyingLocaleOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingLocaleOfIssue val) { UnderlyingLocaleOfIssue = val; }
        public UnderlyingLocaleOfIssue Get(UnderlyingLocaleOfIssue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingLocaleOfIssue val) { return IsSetUnderlyingLocaleOfIssue(); }
        public bool IsSetUnderlyingLocaleOfIssue() { return IsSetField(Tags.UnderlyingLocaleOfIssue); }

        public UnderlyingRedemptionDate UnderlyingRedemptionDate
        {
            get
            {
                UnderlyingRedemptionDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRedemptionDate val) { UnderlyingRedemptionDate = val; }
        public UnderlyingRedemptionDate Get(UnderlyingRedemptionDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRedemptionDate val) { return IsSetUnderlyingRedemptionDate(); }
        public bool IsSetUnderlyingRedemptionDate() { return IsSetField(Tags.UnderlyingRedemptionDate); }

        public UnderlyingStrikePrice UnderlyingStrikePrice
        {
            get
            {
                UnderlyingStrikePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStrikePrice val) { UnderlyingStrikePrice = val; }
        public UnderlyingStrikePrice Get(UnderlyingStrikePrice val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStrikePrice val) { return IsSetUnderlyingStrikePrice(); }
        public bool IsSetUnderlyingStrikePrice() { return IsSetField(Tags.UnderlyingStrikePrice); }

        public UnderlyingStrikeCurrency UnderlyingStrikeCurrency
        {
            get
            {
                UnderlyingStrikeCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStrikeCurrency val) { UnderlyingStrikeCurrency = val; }
        public UnderlyingStrikeCurrency Get(UnderlyingStrikeCurrency val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStrikeCurrency val) { return IsSetUnderlyingStrikeCurrency(); }
        public bool IsSetUnderlyingStrikeCurrency() { return IsSetField(Tags.UnderlyingStrikeCurrency); }

        public UnderlyingOptAttribute UnderlyingOptAttribute
        {
            get
            {
                UnderlyingOptAttribute val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingOptAttribute val) { UnderlyingOptAttribute = val; }
        public UnderlyingOptAttribute Get(UnderlyingOptAttribute val) { GetField(val); return val; }
        public bool IsSet(UnderlyingOptAttribute val) { return IsSetUnderlyingOptAttribute(); }
        public bool IsSetUnderlyingOptAttribute() { return IsSetField(Tags.UnderlyingOptAttribute); }

        public UnderlyingContractMultiplier UnderlyingContractMultiplier
        {
            get
            {
                UnderlyingContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingContractMultiplier val) { UnderlyingContractMultiplier = val; }
        public UnderlyingContractMultiplier Get(UnderlyingContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(UnderlyingContractMultiplier val) { return IsSetUnderlyingContractMultiplier(); }
        public bool IsSetUnderlyingContractMultiplier() { return IsSetField(Tags.UnderlyingContractMultiplier); }

        public UnderlyingCouponRate UnderlyingCouponRate
        {
            get
            {
                UnderlyingCouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCouponRate val) { UnderlyingCouponRate = val; }
        public UnderlyingCouponRate Get(UnderlyingCouponRate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCouponRate val) { return IsSetUnderlyingCouponRate(); }
        public bool IsSetUnderlyingCouponRate() { return IsSetField(Tags.UnderlyingCouponRate); }

        public UnderlyingSecurityExchange UnderlyingSecurityExchange
        {
            get
            {
                UnderlyingSecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityExchange val) { UnderlyingSecurityExchange = val; }
        public UnderlyingSecurityExchange Get(UnderlyingSecurityExchange val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityExchange val) { return IsSetUnderlyingSecurityExchange(); }
        public bool IsSetUnderlyingSecurityExchange() { return IsSetField(Tags.UnderlyingSecurityExchange); }

        public UnderlyingIssuer UnderlyingIssuer
        {
            get
            {
                UnderlyingIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIssuer val) { UnderlyingIssuer = val; }
        public UnderlyingIssuer Get(UnderlyingIssuer val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIssuer val) { return IsSetUnderlyingIssuer(); }
        public bool IsSetUnderlyingIssuer() { return IsSetField(Tags.UnderlyingIssuer); }

        public EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
        {
            get
            {
                EncodedUnderlyingIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedUnderlyingIssuerLen val) { EncodedUnderlyingIssuerLen = val; }
        public EncodedUnderlyingIssuerLen Get(EncodedUnderlyingIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedUnderlyingIssuerLen val) { return IsSetEncodedUnderlyingIssuerLen(); }
        public bool IsSetEncodedUnderlyingIssuerLen() { return IsSetField(Tags.EncodedUnderlyingIssuerLen); }

        public EncodedUnderlyingIssuer EncodedUnderlyingIssuer
        {
            get
            {
                EncodedUnderlyingIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedUnderlyingIssuer val) { EncodedUnderlyingIssuer = val; }
        public EncodedUnderlyingIssuer Get(EncodedUnderlyingIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedUnderlyingIssuer val) { return IsSetEncodedUnderlyingIssuer(); }
        public bool IsSetEncodedUnderlyingIssuer() { return IsSetField(Tags.EncodedUnderlyingIssuer); }

        public UnderlyingSecurityDesc UnderlyingSecurityDesc
        {
            get
            {
                UnderlyingSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityDesc val) { UnderlyingSecurityDesc = val; }
        public UnderlyingSecurityDesc Get(UnderlyingSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityDesc val) { return IsSetUnderlyingSecurityDesc(); }
        public bool IsSetUnderlyingSecurityDesc() { return IsSetField(Tags.UnderlyingSecurityDesc); }

        public EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
        {
            get
            {
                EncodedUnderlyingSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedUnderlyingSecurityDescLen val) { EncodedUnderlyingSecurityDescLen = val; }
        public EncodedUnderlyingSecurityDescLen Get(EncodedUnderlyingSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedUnderlyingSecurityDescLen val) { return IsSetEncodedUnderlyingSecurityDescLen(); }
        public bool IsSetEncodedUnderlyingSecurityDescLen() { return IsSetField(Tags.EncodedUnderlyingSecurityDescLen); }

        public EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
        {
            get
            {
                EncodedUnderlyingSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedUnderlyingSecurityDesc val) { EncodedUnderlyingSecurityDesc = val; }
        public EncodedUnderlyingSecurityDesc Get(EncodedUnderlyingSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedUnderlyingSecurityDesc val) { return IsSetEncodedUnderlyingSecurityDesc(); }
        public bool IsSetEncodedUnderlyingSecurityDesc() { return IsSetField(Tags.EncodedUnderlyingSecurityDesc); }

        public UnderlyingCPProgram UnderlyingCPProgram
        {
            get
            {
                UnderlyingCPProgram val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCPProgram val) { UnderlyingCPProgram = val; }
        public UnderlyingCPProgram Get(UnderlyingCPProgram val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCPProgram val) { return IsSetUnderlyingCPProgram(); }
        public bool IsSetUnderlyingCPProgram() { return IsSetField(Tags.UnderlyingCPProgram); }

        public UnderlyingCPRegType UnderlyingCPRegType
        {
            get
            {
                UnderlyingCPRegType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCPRegType val) { UnderlyingCPRegType = val; }
        public UnderlyingCPRegType Get(UnderlyingCPRegType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCPRegType val) { return IsSetUnderlyingCPRegType(); }
        public bool IsSetUnderlyingCPRegType() { return IsSetField(Tags.UnderlyingCPRegType); }

        public UnderlyingCurrency UnderlyingCurrency
        {
            get
            {
                UnderlyingCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCurrency val) { UnderlyingCurrency = val; }
        public UnderlyingCurrency Get(UnderlyingCurrency val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCurrency val) { return IsSetUnderlyingCurrency(); }
        public bool IsSetUnderlyingCurrency() { return IsSetField(Tags.UnderlyingCurrency); }

        public UnderlyingQty UnderlyingQty
        {
            get
            {
                UnderlyingQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingQty val) { UnderlyingQty = val; }
        public UnderlyingQty Get(UnderlyingQty val) { GetField(val); return val; }
        public bool IsSet(UnderlyingQty val) { return IsSetUnderlyingQty(); }
        public bool IsSetUnderlyingQty() { return IsSetField(Tags.UnderlyingQty); }

        public UnderlyingPx UnderlyingPx
        {
            get
            {
                UnderlyingPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingPx val) { UnderlyingPx = val; }
        public UnderlyingPx Get(UnderlyingPx val) { GetField(val); return val; }
        public bool IsSet(UnderlyingPx val) { return IsSetUnderlyingPx(); }
        public bool IsSetUnderlyingPx() { return IsSetField(Tags.UnderlyingPx); }

        public UnderlyingDirtyPrice UnderlyingDirtyPrice
        {
            get
            {
                UnderlyingDirtyPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingDirtyPrice val) { UnderlyingDirtyPrice = val; }
        public UnderlyingDirtyPrice Get(UnderlyingDirtyPrice val) { GetField(val); return val; }
        public bool IsSet(UnderlyingDirtyPrice val) { return IsSetUnderlyingDirtyPrice(); }
        public bool IsSetUnderlyingDirtyPrice() { return IsSetField(Tags.UnderlyingDirtyPrice); }

        public UnderlyingEndPrice UnderlyingEndPrice
        {
            get
            {
                UnderlyingEndPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingEndPrice val) { UnderlyingEndPrice = val; }
        public UnderlyingEndPrice Get(UnderlyingEndPrice val) { GetField(val); return val; }
        public bool IsSet(UnderlyingEndPrice val) { return IsSetUnderlyingEndPrice(); }
        public bool IsSetUnderlyingEndPrice() { return IsSetField(Tags.UnderlyingEndPrice); }

        public UnderlyingStartValue UnderlyingStartValue
        {
            get
            {
                UnderlyingStartValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStartValue val) { UnderlyingStartValue = val; }
        public UnderlyingStartValue Get(UnderlyingStartValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStartValue val) { return IsSetUnderlyingStartValue(); }
        public bool IsSetUnderlyingStartValue() { return IsSetField(Tags.UnderlyingStartValue); }

        public UnderlyingCurrentValue UnderlyingCurrentValue
        {
            get
            {
                UnderlyingCurrentValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCurrentValue val) { UnderlyingCurrentValue = val; }
        public UnderlyingCurrentValue Get(UnderlyingCurrentValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCurrentValue val) { return IsSetUnderlyingCurrentValue(); }
        public bool IsSetUnderlyingCurrentValue() { return IsSetField(Tags.UnderlyingCurrentValue); }

        public UnderlyingEndValue UnderlyingEndValue
        {
            get
            {
                UnderlyingEndValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingEndValue val) { UnderlyingEndValue = val; }
        public UnderlyingEndValue Get(UnderlyingEndValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingEndValue val) { return IsSetUnderlyingEndValue(); }
        public bool IsSetUnderlyingEndValue() { return IsSetField(Tags.UnderlyingEndValue); }

        public NoUnderlyingStips NoUnderlyingStips
        {
            get
            {
                NoUnderlyingStips val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUnderlyingStips val) { NoUnderlyingStips = val; }
        public NoUnderlyingStips Get(NoUnderlyingStips val) { GetField(val); return val; }
        public bool IsSet(NoUnderlyingStips val) { return IsSetNoUnderlyingStips(); }
        public bool IsSetNoUnderlyingStips() { return IsSetField(Tags.NoUnderlyingStips); }

        public UnderlyingAllocationPercent UnderlyingAllocationPercent
        {
            get
            {
                UnderlyingAllocationPercent val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingAllocationPercent val) { UnderlyingAllocationPercent = val; }
        public UnderlyingAllocationPercent Get(UnderlyingAllocationPercent val) { GetField(val); return val; }
        public bool IsSet(UnderlyingAllocationPercent val) { return IsSetUnderlyingAllocationPercent(); }
        public bool IsSetUnderlyingAllocationPercent() { return IsSetField(Tags.UnderlyingAllocationPercent); }

        public UnderlyingSettlementType UnderlyingSettlementType
        {
            get
            {
                UnderlyingSettlementType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSettlementType val) { UnderlyingSettlementType = val; }
        public UnderlyingSettlementType Get(UnderlyingSettlementType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSettlementType val) { return IsSetUnderlyingSettlementType(); }
        public bool IsSetUnderlyingSettlementType() { return IsSetField(Tags.UnderlyingSettlementType); }

        public UnderlyingCashAmount UnderlyingCashAmount
        {
            get
            {
                UnderlyingCashAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCashAmount val) { UnderlyingCashAmount = val; }
        public UnderlyingCashAmount Get(UnderlyingCashAmount val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCashAmount val) { return IsSetUnderlyingCashAmount(); }
        public bool IsSetUnderlyingCashAmount() { return IsSetField(Tags.UnderlyingCashAmount); }

        public UnderlyingCashType UnderlyingCashType
        {
            get
            {
                UnderlyingCashType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCashType val) { UnderlyingCashType = val; }
        public UnderlyingCashType Get(UnderlyingCashType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCashType val) { return IsSetUnderlyingCashType(); }
        public bool IsSetUnderlyingCashType() { return IsSetField(Tags.UnderlyingCashType); }

        public UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
        {
            get
            {
                UnderlyingUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingUnitOfMeasure val) { UnderlyingUnitOfMeasure = val; }
        public UnderlyingUnitOfMeasure Get(UnderlyingUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(UnderlyingUnitOfMeasure val) { return IsSetUnderlyingUnitOfMeasure(); }
        public bool IsSetUnderlyingUnitOfMeasure() { return IsSetField(Tags.UnderlyingUnitOfMeasure); }

        public UnderlyingTimeUnit UnderlyingTimeUnit
        {
            get
            {
                UnderlyingTimeUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingTimeUnit val) { UnderlyingTimeUnit = val; }
        public UnderlyingTimeUnit Get(UnderlyingTimeUnit val) { GetField(val); return val; }
        public bool IsSet(UnderlyingTimeUnit val) { return IsSetUnderlyingTimeUnit(); }
        public bool IsSetUnderlyingTimeUnit() { return IsSetField(Tags.UnderlyingTimeUnit); }

        public UnderlyingCapValue UnderlyingCapValue
        {
            get
            {
                UnderlyingCapValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCapValue val) { UnderlyingCapValue = val; }
        public UnderlyingCapValue Get(UnderlyingCapValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCapValue val) { return IsSetUnderlyingCapValue(); }
        public bool IsSetUnderlyingCapValue() { return IsSetField(Tags.UnderlyingCapValue); }

        public NoUndlyInstrumentParties NoUndlyInstrumentParties
        {
            get
            {
                NoUndlyInstrumentParties val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUndlyInstrumentParties val) { NoUndlyInstrumentParties = val; }
        public NoUndlyInstrumentParties Get(NoUndlyInstrumentParties val) { GetField(val); return val; }
        public bool IsSet(NoUndlyInstrumentParties val) { return IsSetNoUndlyInstrumentParties(); }
        public bool IsSetNoUndlyInstrumentParties() { return IsSetField(Tags.NoUndlyInstrumentParties); }

        public UnderlyingSettlMethod UnderlyingSettlMethod
        {
            get
            {
                UnderlyingSettlMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSettlMethod val) { UnderlyingSettlMethod = val; }
        public UnderlyingSettlMethod Get(UnderlyingSettlMethod val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSettlMethod val) { return IsSetUnderlyingSettlMethod(); }
        public bool IsSetUnderlyingSettlMethod() { return IsSetField(Tags.UnderlyingSettlMethod); }

        public UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
        {
            get
            {
                UnderlyingAdjustedQuantity val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingAdjustedQuantity val) { UnderlyingAdjustedQuantity = val; }
        public UnderlyingAdjustedQuantity Get(UnderlyingAdjustedQuantity val) { GetField(val); return val; }
        public bool IsSet(UnderlyingAdjustedQuantity val) { return IsSetUnderlyingAdjustedQuantity(); }
        public bool IsSetUnderlyingAdjustedQuantity() { return IsSetField(Tags.UnderlyingAdjustedQuantity); }

        public UnderlyingFXRate UnderlyingFXRate
        {
            get
            {
                UnderlyingFXRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingFXRate val) { UnderlyingFXRate = val; }
        public UnderlyingFXRate Get(UnderlyingFXRate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingFXRate val) { return IsSetUnderlyingFXRate(); }
        public bool IsSetUnderlyingFXRate() { return IsSetField(Tags.UnderlyingFXRate); }

        public UnderlyingFXRateCalc UnderlyingFXRateCalc
        {
            get
            {
                UnderlyingFXRateCalc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingFXRateCalc val) { UnderlyingFXRateCalc = val; }
        public UnderlyingFXRateCalc Get(UnderlyingFXRateCalc val) { GetField(val); return val; }
        public bool IsSet(UnderlyingFXRateCalc val) { return IsSetUnderlyingFXRateCalc(); }
        public bool IsSetUnderlyingFXRateCalc() { return IsSetField(Tags.UnderlyingFXRateCalc); }

        public UnderlyingMaturityTime UnderlyingMaturityTime
        {
            get
            {
                UnderlyingMaturityTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingMaturityTime val) { UnderlyingMaturityTime = val; }
        public UnderlyingMaturityTime Get(UnderlyingMaturityTime val) { GetField(val); return val; }
        public bool IsSet(UnderlyingMaturityTime val) { return IsSetUnderlyingMaturityTime(); }
        public bool IsSetUnderlyingMaturityTime() { return IsSetField(Tags.UnderlyingMaturityTime); }

        public UnderlyingPutOrCall UnderlyingPutOrCall
        {
            get
            {
                UnderlyingPutOrCall val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingPutOrCall val) { UnderlyingPutOrCall = val; }
        public UnderlyingPutOrCall Get(UnderlyingPutOrCall val) { GetField(val); return val; }
        public bool IsSet(UnderlyingPutOrCall val) { return IsSetUnderlyingPutOrCall(); }
        public bool IsSetUnderlyingPutOrCall() { return IsSetField(Tags.UnderlyingPutOrCall); }

        public UnderlyingExerciseStyle UnderlyingExerciseStyle
        {
            get
            {
                UnderlyingExerciseStyle val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingExerciseStyle val) { UnderlyingExerciseStyle = val; }
        public UnderlyingExerciseStyle Get(UnderlyingExerciseStyle val) { GetField(val); return val; }
        public bool IsSet(UnderlyingExerciseStyle val) { return IsSetUnderlyingExerciseStyle(); }
        public bool IsSetUnderlyingExerciseStyle() { return IsSetField(Tags.UnderlyingExerciseStyle); }

        public UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
        {
            get
            {
                UnderlyingUnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingUnitOfMeasureQty val) { UnderlyingUnitOfMeasureQty = val; }
        public UnderlyingUnitOfMeasureQty Get(UnderlyingUnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(UnderlyingUnitOfMeasureQty val) { return IsSetUnderlyingUnitOfMeasureQty(); }
        public bool IsSetUnderlyingUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingUnitOfMeasureQty); }

        public UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
        {
            get
            {
                UnderlyingPriceUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingPriceUnitOfMeasure val) { UnderlyingPriceUnitOfMeasure = val; }
        public UnderlyingPriceUnitOfMeasure Get(UnderlyingPriceUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(UnderlyingPriceUnitOfMeasure val) { return IsSetUnderlyingPriceUnitOfMeasure(); }
        public bool IsSetUnderlyingPriceUnitOfMeasure() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasure); }

        public UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
        {
            get
            {
                UnderlyingPriceUnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingPriceUnitOfMeasureQty val) { UnderlyingPriceUnitOfMeasureQty = val; }
        public UnderlyingPriceUnitOfMeasureQty Get(UnderlyingPriceUnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(UnderlyingPriceUnitOfMeasureQty val) { return IsSetUnderlyingPriceUnitOfMeasureQty(); }
        public bool IsSetUnderlyingPriceUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasureQty); }

        public UnderlyingContractMultiplierUnit UnderlyingContractMultiplierUnit
        {
            get
            {
                UnderlyingContractMultiplierUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingContractMultiplierUnit val) { UnderlyingContractMultiplierUnit = val; }
        public UnderlyingContractMultiplierUnit Get(UnderlyingContractMultiplierUnit val) { GetField(val); return val; }
        public bool IsSet(UnderlyingContractMultiplierUnit val) { return IsSetUnderlyingContractMultiplierUnit(); }
        public bool IsSetUnderlyingContractMultiplierUnit() { return IsSetField(Tags.UnderlyingContractMultiplierUnit); }

        public UnderlyingFlowScheduleType UnderlyingFlowScheduleType
        {
            get
            {
                UnderlyingFlowScheduleType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingFlowScheduleType val) { UnderlyingFlowScheduleType = val; }
        public UnderlyingFlowScheduleType Get(UnderlyingFlowScheduleType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingFlowScheduleType val) { return IsSetUnderlyingFlowScheduleType(); }
        public bool IsSetUnderlyingFlowScheduleType() { return IsSetField(Tags.UnderlyingFlowScheduleType); }

        public UnderlyingRestructuringType UnderlyingRestructuringType
        {
            get
            {
                UnderlyingRestructuringType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRestructuringType val) { UnderlyingRestructuringType = val; }
        public UnderlyingRestructuringType Get(UnderlyingRestructuringType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRestructuringType val) { return IsSetUnderlyingRestructuringType(); }
        public bool IsSetUnderlyingRestructuringType() { return IsSetField(Tags.UnderlyingRestructuringType); }

        public UnderlyingSeniority UnderlyingSeniority
        {
            get
            {
                UnderlyingSeniority val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSeniority val) { UnderlyingSeniority = val; }
        public UnderlyingSeniority Get(UnderlyingSeniority val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSeniority val) { return IsSetUnderlyingSeniority(); }
        public bool IsSetUnderlyingSeniority() { return IsSetField(Tags.UnderlyingSeniority); }

        public UnderlyingNotionalPercentageOutstanding UnderlyingNotionalPercentageOutstanding
        {
            get
            {
                UnderlyingNotionalPercentageOutstanding val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingNotionalPercentageOutstanding val) { UnderlyingNotionalPercentageOutstanding = val; }
        public UnderlyingNotionalPercentageOutstanding Get(UnderlyingNotionalPercentageOutstanding val) { GetField(val); return val; }
        public bool IsSet(UnderlyingNotionalPercentageOutstanding val) { return IsSetUnderlyingNotionalPercentageOutstanding(); }
        public bool IsSetUnderlyingNotionalPercentageOutstanding() { return IsSetField(Tags.UnderlyingNotionalPercentageOutstanding); }

        public UnderlyingOriginalNotionalPercentageOutstanding UnderlyingOriginalNotionalPercentageOutstanding
        {
            get
            {
                UnderlyingOriginalNotionalPercentageOutstanding val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingOriginalNotionalPercentageOutstanding val) { UnderlyingOriginalNotionalPercentageOutstanding = val; }
        public UnderlyingOriginalNotionalPercentageOutstanding Get(UnderlyingOriginalNotionalPercentageOutstanding val) { GetField(val); return val; }
        public bool IsSet(UnderlyingOriginalNotionalPercentageOutstanding val) { return IsSetUnderlyingOriginalNotionalPercentageOutstanding(); }
        public bool IsSetUnderlyingOriginalNotionalPercentageOutstanding() { return IsSetField(Tags.UnderlyingOriginalNotionalPercentageOutstanding); }

        public UnderlyingAttachmentPoint UnderlyingAttachmentPoint
        {
            get
            {
                UnderlyingAttachmentPoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingAttachmentPoint val) { UnderlyingAttachmentPoint = val; }
        public UnderlyingAttachmentPoint Get(UnderlyingAttachmentPoint val) { GetField(val); return val; }
        public bool IsSet(UnderlyingAttachmentPoint val) { return IsSetUnderlyingAttachmentPoint(); }
        public bool IsSetUnderlyingAttachmentPoint() { return IsSetField(Tags.UnderlyingAttachmentPoint); }

        public UnderlyingDetachmentPoint UnderlyingDetachmentPoint
        {
            get
            {
                UnderlyingDetachmentPoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingDetachmentPoint val) { UnderlyingDetachmentPoint = val; }
        public UnderlyingDetachmentPoint Get(UnderlyingDetachmentPoint val) { GetField(val); return val; }
        public bool IsSet(UnderlyingDetachmentPoint val) { return IsSetUnderlyingDetachmentPoint(); }
        public bool IsSetUnderlyingDetachmentPoint() { return IsSetField(Tags.UnderlyingDetachmentPoint); }

        public UnderlyingCouponFrequencyPeriod UnderlyingCouponFrequencyPeriod
        {
            get
            {
                UnderlyingCouponFrequencyPeriod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCouponFrequencyPeriod val) { UnderlyingCouponFrequencyPeriod = val; }
        public UnderlyingCouponFrequencyPeriod Get(UnderlyingCouponFrequencyPeriod val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCouponFrequencyPeriod val) { return IsSetUnderlyingCouponFrequencyPeriod(); }
        public bool IsSetUnderlyingCouponFrequencyPeriod() { return IsSetField(Tags.UnderlyingCouponFrequencyPeriod); }

        public UnderlyingCouponFrequencyUnit UnderlyingCouponFrequencyUnit
        {
            get
            {
                UnderlyingCouponFrequencyUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCouponFrequencyUnit val) { UnderlyingCouponFrequencyUnit = val; }
        public UnderlyingCouponFrequencyUnit Get(UnderlyingCouponFrequencyUnit val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCouponFrequencyUnit val) { return IsSetUnderlyingCouponFrequencyUnit(); }
        public bool IsSetUnderlyingCouponFrequencyUnit() { return IsSetField(Tags.UnderlyingCouponFrequencyUnit); }

        public UnderlyingCouponDayCount UnderlyingCouponDayCount
        {
            get
            {
                UnderlyingCouponDayCount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCouponDayCount val) { UnderlyingCouponDayCount = val; }
        public UnderlyingCouponDayCount Get(UnderlyingCouponDayCount val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCouponDayCount val) { return IsSetUnderlyingCouponDayCount(); }
        public bool IsSetUnderlyingCouponDayCount() { return IsSetField(Tags.UnderlyingCouponDayCount); }

        public UnderlyingObligationID UnderlyingObligationID
        {
            get
            {
                UnderlyingObligationID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingObligationID val) { UnderlyingObligationID = val; }
        public UnderlyingObligationID Get(UnderlyingObligationID val) { GetField(val); return val; }
        public bool IsSet(UnderlyingObligationID val) { return IsSetUnderlyingObligationID(); }
        public bool IsSetUnderlyingObligationID() { return IsSetField(Tags.UnderlyingObligationID); }

        public UnderlyingObligationIDSource UnderlyingObligationIDSource
        {
            get
            {
                UnderlyingObligationIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingObligationIDSource val) { UnderlyingObligationIDSource = val; }
        public UnderlyingObligationIDSource Get(UnderlyingObligationIDSource val) { GetField(val); return val; }
        public bool IsSet(UnderlyingObligationIDSource val) { return IsSetUnderlyingObligationIDSource(); }
        public bool IsSetUnderlyingObligationIDSource() { return IsSetField(Tags.UnderlyingObligationIDSource); }

        public NoUnderlyingEvents NoUnderlyingEvents
        {
            get
            {
                NoUnderlyingEvents val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUnderlyingEvents val) { NoUnderlyingEvents = val; }
        public NoUnderlyingEvents Get(NoUnderlyingEvents val) { GetField(val); return val; }
        public bool IsSet(NoUnderlyingEvents val) { return IsSetNoUnderlyingEvents(); }
        public bool IsSetNoUnderlyingEvents() { return IsSetField(Tags.NoUnderlyingEvents); }

        public UnderlyingIndexSeries UnderlyingIndexSeries
        {
            get
            {
                UnderlyingIndexSeries val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIndexSeries val) { UnderlyingIndexSeries = val; }
        public UnderlyingIndexSeries Get(UnderlyingIndexSeries val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIndexSeries val) { return IsSetUnderlyingIndexSeries(); }
        public bool IsSetUnderlyingIndexSeries() { return IsSetField(Tags.UnderlyingIndexSeries); }

        public UnderlyingIndexAnnexVersion UnderlyingIndexAnnexVersion
        {
            get
            {
                UnderlyingIndexAnnexVersion val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIndexAnnexVersion val) { UnderlyingIndexAnnexVersion = val; }
        public UnderlyingIndexAnnexVersion Get(UnderlyingIndexAnnexVersion val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIndexAnnexVersion val) { return IsSetUnderlyingIndexAnnexVersion(); }
        public bool IsSetUnderlyingIndexAnnexVersion() { return IsSetField(Tags.UnderlyingIndexAnnexVersion); }

        public UnderlyingIndexAnnexDate UnderlyingIndexAnnexDate
        {
            get
            {
                UnderlyingIndexAnnexDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIndexAnnexDate val) { UnderlyingIndexAnnexDate = val; }
        public UnderlyingIndexAnnexDate Get(UnderlyingIndexAnnexDate val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIndexAnnexDate val) { return IsSetUnderlyingIndexAnnexDate(); }
        public bool IsSetUnderlyingIndexAnnexDate() { return IsSetField(Tags.UnderlyingIndexAnnexDate); }

        public UnderlyingIndexAnnexSource UnderlyingIndexAnnexSource
        {
            get
            {
                UnderlyingIndexAnnexSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIndexAnnexSource val) { UnderlyingIndexAnnexSource = val; }
        public UnderlyingIndexAnnexSource Get(UnderlyingIndexAnnexSource val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIndexAnnexSource val) { return IsSetUnderlyingIndexAnnexSource(); }
        public bool IsSetUnderlyingIndexAnnexSource() { return IsSetField(Tags.UnderlyingIndexAnnexSource); }

        public UnderlyingAssetClass UnderlyingAssetClass
        {
            get
            {
                UnderlyingAssetClass val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingAssetClass val) { UnderlyingAssetClass = val; }
        public UnderlyingAssetClass Get(UnderlyingAssetClass val) { GetField(val); return val; }
        public bool IsSet(UnderlyingAssetClass val) { return IsSetUnderlyingAssetClass(); }
        public bool IsSetUnderlyingAssetClass() { return IsSetField(Tags.UnderlyingAssetClass); }

        public UnderlyingAssetSubClass UnderlyingAssetSubClass
        {
            get
            {
                UnderlyingAssetSubClass val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingAssetSubClass val) { UnderlyingAssetSubClass = val; }
        public UnderlyingAssetSubClass Get(UnderlyingAssetSubClass val) { GetField(val); return val; }
        public bool IsSet(UnderlyingAssetSubClass val) { return IsSetUnderlyingAssetSubClass(); }
        public bool IsSetUnderlyingAssetSubClass() { return IsSetField(Tags.UnderlyingAssetSubClass); }

        public NoUnderlyingStreams NoUnderlyingStreams
        {
            get
            {
                NoUnderlyingStreams val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUnderlyingStreams val) { NoUnderlyingStreams = val; }
        public NoUnderlyingStreams Get(NoUnderlyingStreams val) { GetField(val); return val; }
        public bool IsSet(NoUnderlyingStreams val) { return IsSetNoUnderlyingStreams(); }
        public bool IsSetNoUnderlyingStreams() { return IsSetField(Tags.NoUnderlyingStreams); }

        public UnderlyingStartAcrdIntAmt UnderlyingStartAcrdIntAmt
        {
            get
            {
                UnderlyingStartAcrdIntAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStartAcrdIntAmt val) { UnderlyingStartAcrdIntAmt = val; }
        public UnderlyingStartAcrdIntAmt Get(UnderlyingStartAcrdIntAmt val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStartAcrdIntAmt val) { return IsSetUnderlyingStartAcrdIntAmt(); }
        public bool IsSetUnderlyingStartAcrdIntAmt() { return IsSetField(Tags.UnderlyingStartAcrdIntAmt); }

        public UnderlyingEndAcrdIntAmt UnderlyingEndAcrdIntAmt
        {
            get
            {
                UnderlyingEndAcrdIntAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingEndAcrdIntAmt val) { UnderlyingEndAcrdIntAmt = val; }
        public UnderlyingEndAcrdIntAmt Get(UnderlyingEndAcrdIntAmt val) { GetField(val); return val; }
        public bool IsSet(UnderlyingEndAcrdIntAmt val) { return IsSetUnderlyingEndAcrdIntAmt(); }
        public bool IsSetUnderlyingEndAcrdIntAmt() { return IsSetField(Tags.UnderlyingEndAcrdIntAmt); }

        public UnderlyingPriceType UnderlyingPriceType
        {
            get
            {
                UnderlyingPriceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingPriceType val) { UnderlyingPriceType = val; }
        public UnderlyingPriceType Get(UnderlyingPriceType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingPriceType val) { return IsSetUnderlyingPriceType(); }
        public bool IsSetUnderlyingPriceType() { return IsSetField(Tags.UnderlyingPriceType); }

        public UnderlyingCouponDateGenerationMethod UnderlyingCouponDateGenerationMethod
        {
            get
            {
                UnderlyingCouponDateGenerationMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingCouponDateGenerationMethod val) { UnderlyingCouponDateGenerationMethod = val; }
        public UnderlyingCouponDateGenerationMethod Get(UnderlyingCouponDateGenerationMethod val) { GetField(val); return val; }
        public bool IsSet(UnderlyingCouponDateGenerationMethod val) { return IsSetUnderlyingCouponDateGenerationMethod(); }
        public bool IsSetUnderlyingCouponDateGenerationMethod() { return IsSetField(Tags.UnderlyingCouponDateGenerationMethod); }

        public UnderlyingIndexCurvePeriod UnderlyingIndexCurvePeriod
        {
            get
            {
                UnderlyingIndexCurvePeriod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIndexCurvePeriod val) { UnderlyingIndexCurvePeriod = val; }
        public UnderlyingIndexCurvePeriod Get(UnderlyingIndexCurvePeriod val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIndexCurvePeriod val) { return IsSetUnderlyingIndexCurvePeriod(); }
        public bool IsSetUnderlyingIndexCurvePeriod() { return IsSetField(Tags.UnderlyingIndexCurvePeriod); }

        public UnderlyingIndexCurveUnit UnderlyingIndexCurveUnit
        {
            get
            {
                UnderlyingIndexCurveUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingIndexCurveUnit val) { UnderlyingIndexCurveUnit = val; }
        public UnderlyingIndexCurveUnit Get(UnderlyingIndexCurveUnit val) { GetField(val); return val; }
        public bool IsSet(UnderlyingIndexCurveUnit val) { return IsSetUnderlyingIndexCurveUnit(); }
        public bool IsSetUnderlyingIndexCurveUnit() { return IsSetField(Tags.UnderlyingIndexCurveUnit); }

        public NoUnderlyingReinvCoupon NoUnderlyingReinvCoupon
        {
            get
            {
                NoUnderlyingReinvCoupon val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUnderlyingReinvCoupon val) { NoUnderlyingReinvCoupon = val; }
        public NoUnderlyingReinvCoupon Get(NoUnderlyingReinvCoupon val) { GetField(val); return val; }
        public bool IsSet(NoUnderlyingReinvCoupon val) { return IsSetNoUnderlyingReinvCoupon(); }
        public bool IsSetNoUnderlyingReinvCoupon() { return IsSetField(Tags.NoUnderlyingReinvCoupon); }

        public UnderlyingSecuritySeries UnderlyingSecuritySeries
        {
            get
            {
                UnderlyingSecuritySeries val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecuritySeries val) { UnderlyingSecuritySeries = val; }
        public UnderlyingSecuritySeries Get(UnderlyingSecuritySeries val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecuritySeries val) { return IsSetUnderlyingSecuritySeries(); }
        public bool IsSetUnderlyingSecuritySeries() { return IsSetField(Tags.UnderlyingSecuritySeries); }

        public class NoUnderlyingSecurityAltIDGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};

            public NoUnderlyingSecurityAltIDGroup()
              : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingSecurityAltID UnderlyingSecurityAltID
            {
                get
                {
                    UnderlyingSecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingSecurityAltID val) { UnderlyingSecurityAltID = val; }
            public UnderlyingSecurityAltID Get(UnderlyingSecurityAltID val) { GetField(val); return val; }
            public bool IsSet(UnderlyingSecurityAltID val) { return IsSetUnderlyingSecurityAltID(); }
            public bool IsSetUnderlyingSecurityAltID() { return IsSetField(Tags.UnderlyingSecurityAltID); }

            public UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
            {
                get
                {
                    UnderlyingSecurityAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingSecurityAltIDSource val) { UnderlyingSecurityAltIDSource = val; }
            public UnderlyingSecurityAltIDSource Get(UnderlyingSecurityAltIDSource val) { GetField(val); return val; }
            public bool IsSet(UnderlyingSecurityAltIDSource val) { return IsSetUnderlyingSecurityAltIDSource(); }
            public bool IsSetUnderlyingSecurityAltIDSource() { return IsSetField(Tags.UnderlyingSecurityAltIDSource); }
        }

        public class NoUnderlyingStipsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};

            public NoUnderlyingStipsGroup()
              : base(Tags.NoUnderlyingStips, Tags.UnderlyingStipType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingStipsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingStipType UnderlyingStipType
            {
                get
                {
                    UnderlyingStipType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingStipType val) { UnderlyingStipType = val; }
            public UnderlyingStipType Get(UnderlyingStipType val) { GetField(val); return val; }
            public bool IsSet(UnderlyingStipType val) { return IsSetUnderlyingStipType(); }
            public bool IsSetUnderlyingStipType() { return IsSetField(Tags.UnderlyingStipType); }

            public UnderlyingStipValue UnderlyingStipValue
            {
                get
                {
                    UnderlyingStipValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingStipValue val) { UnderlyingStipValue = val; }
            public UnderlyingStipValue Get(UnderlyingStipValue val) { GetField(val); return val; }
            public bool IsSet(UnderlyingStipValue val) { return IsSetUnderlyingStipValue(); }
            public bool IsSetUnderlyingStipValue() { return IsSetField(Tags.UnderlyingStipValue); }
        }

        public class NoUndlyInstrumentPartiesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

            public NoUndlyInstrumentPartiesGroup()
              : base(Tags.NoUndlyInstrumentParties, Tags.UnderlyingInstrumentPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingInstrumentPartyID UnderlyingInstrumentPartyID
            {
                get
                {
                    UnderlyingInstrumentPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingInstrumentPartyID val) { UnderlyingInstrumentPartyID = val; }
            public UnderlyingInstrumentPartyID Get(UnderlyingInstrumentPartyID val) { GetField(val); return val; }
            public bool IsSet(UnderlyingInstrumentPartyID val) { return IsSetUnderlyingInstrumentPartyID(); }
            public bool IsSetUnderlyingInstrumentPartyID() { return IsSetField(Tags.UnderlyingInstrumentPartyID); }

            public UnderlyingInstrumentPartyIDSource UnderlyingInstrumentPartyIDSource
            {
                get
                {
                    UnderlyingInstrumentPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingInstrumentPartyIDSource val) { UnderlyingInstrumentPartyIDSource = val; }
            public UnderlyingInstrumentPartyIDSource Get(UnderlyingInstrumentPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(UnderlyingInstrumentPartyIDSource val) { return IsSetUnderlyingInstrumentPartyIDSource(); }
            public bool IsSetUnderlyingInstrumentPartyIDSource() { return IsSetField(Tags.UnderlyingInstrumentPartyIDSource); }

            public UnderlyingInstrumentPartyRole UnderlyingInstrumentPartyRole
            {
                get
                {
                    UnderlyingInstrumentPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingInstrumentPartyRole val) { UnderlyingInstrumentPartyRole = val; }
            public UnderlyingInstrumentPartyRole Get(UnderlyingInstrumentPartyRole val) { GetField(val); return val; }
            public bool IsSet(UnderlyingInstrumentPartyRole val) { return IsSetUnderlyingInstrumentPartyRole(); }
            public bool IsSetUnderlyingInstrumentPartyRole() { return IsSetField(Tags.UnderlyingInstrumentPartyRole); }

            public NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
            {
                get
                {
                    NoUndlyInstrumentPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoUndlyInstrumentPartySubIDs val) { NoUndlyInstrumentPartySubIDs = val; }
            public NoUndlyInstrumentPartySubIDs Get(NoUndlyInstrumentPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoUndlyInstrumentPartySubIDs val) { return IsSetNoUndlyInstrumentPartySubIDs(); }
            public bool IsSetNoUndlyInstrumentPartySubIDs() { return IsSetField(Tags.NoUndlyInstrumentPartySubIDs); }

            public class NoUndlyInstrumentPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
                public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0};

                public NoUndlyInstrumentPartySubIDsGroup()
                  : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UnderlyingInstrumentPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoUndlyInstrumentPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public UnderlyingInstrumentPartySubID UnderlyingInstrumentPartySubID
                {
                    get
                    {
                        UnderlyingInstrumentPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(UnderlyingInstrumentPartySubID val) { UnderlyingInstrumentPartySubID = val; }
                public UnderlyingInstrumentPartySubID Get(UnderlyingInstrumentPartySubID val) { GetField(val); return val; }
                public bool IsSet(UnderlyingInstrumentPartySubID val) { return IsSetUnderlyingInstrumentPartySubID(); }
                public bool IsSetUnderlyingInstrumentPartySubID() { return IsSetField(Tags.UnderlyingInstrumentPartySubID); }

                public UnderlyingInstrumentPartySubIDType UnderlyingInstrumentPartySubIDType
                {
                    get
                    {
                        UnderlyingInstrumentPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(UnderlyingInstrumentPartySubIDType val) { UnderlyingInstrumentPartySubIDType = val; }
                public UnderlyingInstrumentPartySubIDType Get(UnderlyingInstrumentPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(UnderlyingInstrumentPartySubIDType val) { return IsSetUnderlyingInstrumentPartySubIDType(); }
                public bool IsSetUnderlyingInstrumentPartySubIDType() { return IsSetField(Tags.UnderlyingInstrumentPartySubIDType); }
            }
        }

        public class NoUnderlyingEventsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingEventType, Tags.UnderlyingEventDate, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.UnderlyingEventType, Tags.UnderlyingEventDate, 0};

            public NoUnderlyingEventsGroup()
              : base(Tags.NoUnderlyingEvents, Tags.UnderlyingEventType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingEventsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingEventType UnderlyingEventType
            {
                get
                {
                    UnderlyingEventType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingEventType val) { UnderlyingEventType = val; }
            public UnderlyingEventType Get(UnderlyingEventType val) { GetField(val); return val; }
            public bool IsSet(UnderlyingEventType val) { return IsSetUnderlyingEventType(); }
            public bool IsSetUnderlyingEventType() { return IsSetField(Tags.UnderlyingEventType); }

            public UnderlyingEventDate UnderlyingEventDate
            {
                get
                {
                    UnderlyingEventDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingEventDate val) { UnderlyingEventDate = val; }
            public UnderlyingEventDate Get(UnderlyingEventDate val) { GetField(val); return val; }
            public bool IsSet(UnderlyingEventDate val) { return IsSetUnderlyingEventDate(); }
            public bool IsSetUnderlyingEventDate() { return IsSetField(Tags.UnderlyingEventDate); }
        }

        public class NoUnderlyingStreamsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingStreamType, Tags.UnderlyingStreamDesc, Tags.UnderlyingStreamPaySide, Tags.UnderlyingStreamReceiveSide, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.UnderlyingStreamType, Tags.UnderlyingStreamDesc, Tags.UnderlyingStreamPaySide, Tags.UnderlyingStreamReceiveSide, 0};

            public NoUnderlyingStreamsGroup()
              : base(Tags.NoUnderlyingStreams, Tags.UnderlyingStreamType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingStreamsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingStreamType UnderlyingStreamType
            {
                get
                {
                    UnderlyingStreamType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingStreamType val) { UnderlyingStreamType = val; }
            public UnderlyingStreamType Get(UnderlyingStreamType val) { GetField(val); return val; }
            public bool IsSet(UnderlyingStreamType val) { return IsSetUnderlyingStreamType(); }
            public bool IsSetUnderlyingStreamType() { return IsSetField(Tags.UnderlyingStreamType); }

            public UnderlyingStreamDesc UnderlyingStreamDesc
            {
                get
                {
                    UnderlyingStreamDesc val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingStreamDesc val) { UnderlyingStreamDesc = val; }
            public UnderlyingStreamDesc Get(UnderlyingStreamDesc val) { GetField(val); return val; }
            public bool IsSet(UnderlyingStreamDesc val) { return IsSetUnderlyingStreamDesc(); }
            public bool IsSetUnderlyingStreamDesc() { return IsSetField(Tags.UnderlyingStreamDesc); }

            public UnderlyingStreamPaySide UnderlyingStreamPaySide
            {
                get
                {
                    UnderlyingStreamPaySide val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingStreamPaySide val) { UnderlyingStreamPaySide = val; }
            public UnderlyingStreamPaySide Get(UnderlyingStreamPaySide val) { GetField(val); return val; }
            public bool IsSet(UnderlyingStreamPaySide val) { return IsSetUnderlyingStreamPaySide(); }
            public bool IsSetUnderlyingStreamPaySide() { return IsSetField(Tags.UnderlyingStreamPaySide); }

            public UnderlyingStreamReceiveSide UnderlyingStreamReceiveSide
            {
                get
                {
                    UnderlyingStreamReceiveSide val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingStreamReceiveSide val) { UnderlyingStreamReceiveSide = val; }
            public UnderlyingStreamReceiveSide Get(UnderlyingStreamReceiveSide val) { GetField(val); return val; }
            public bool IsSet(UnderlyingStreamReceiveSide val) { return IsSetUnderlyingStreamReceiveSide(); }
            public bool IsSetUnderlyingStreamReceiveSide() { return IsSetField(Tags.UnderlyingStreamReceiveSide); }
        }

        public class NoUnderlyingReinvCouponGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingReinvCouponDate, Tags.UnderlyingReinvCouponRate, Tags.UnderlyingReinvCouponAmt, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.UnderlyingReinvCouponDate, Tags.UnderlyingReinvCouponRate, Tags.UnderlyingReinvCouponAmt, 0};

            public NoUnderlyingReinvCouponGroup()
              : base(Tags.NoUnderlyingReinvCoupon, Tags.UnderlyingReinvCouponDate, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingReinvCouponGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingReinvCouponDate UnderlyingReinvCouponDate
            {
                get
                {
                    UnderlyingReinvCouponDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingReinvCouponDate val) { UnderlyingReinvCouponDate = val; }
            public UnderlyingReinvCouponDate Get(UnderlyingReinvCouponDate val) { GetField(val); return val; }
            public bool IsSet(UnderlyingReinvCouponDate val) { return IsSetUnderlyingReinvCouponDate(); }
            public bool IsSetUnderlyingReinvCouponDate() { return IsSetField(Tags.UnderlyingReinvCouponDate); }

            public UnderlyingReinvCouponRate UnderlyingReinvCouponRate
            {
                get
                {
                    UnderlyingReinvCouponRate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingReinvCouponRate val) { UnderlyingReinvCouponRate = val; }
            public UnderlyingReinvCouponRate Get(UnderlyingReinvCouponRate val) { GetField(val); return val; }
            public bool IsSet(UnderlyingReinvCouponRate val) { return IsSetUnderlyingReinvCouponRate(); }
            public bool IsSetUnderlyingReinvCouponRate() { return IsSetField(Tags.UnderlyingReinvCouponRate); }

            public UnderlyingReinvCouponAmt UnderlyingReinvCouponAmt
            {
                get
                {
                    UnderlyingReinvCouponAmt val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingReinvCouponAmt val) { UnderlyingReinvCouponAmt = val; }
            public UnderlyingReinvCouponAmt Get(UnderlyingReinvCouponAmt val) { GetField(val); return val; }
            public bool IsSet(UnderlyingReinvCouponAmt val) { return IsSetUnderlyingReinvCouponAmt(); }
            public bool IsSetUnderlyingReinvCouponAmt() { return IsSetField(Tags.UnderlyingReinvCouponAmt); }
        }
    }

    public class NoStipulationsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StipulationType, Tags.StipulationValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};

        public NoStipulationsGroup()
          : base(Tags.NoStipulations, Tags.StipulationType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoStipulationsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public StipulationType StipulationType
        {
            get
            {
                StipulationType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StipulationType val) { StipulationType = val; }
        public StipulationType Get(StipulationType val) { GetField(val); return val; }
        public bool IsSet(StipulationType val) { return IsSetStipulationType(); }
        public bool IsSetStipulationType() { return IsSetField(Tags.StipulationType); }

        public StipulationValue StipulationValue
        {
            get
            {
                StipulationValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StipulationValue val) { StipulationValue = val; }
        public StipulationValue Get(StipulationValue val) { GetField(val); return val; }
        public bool IsSet(StipulationValue val) { return IsSetStipulationValue(); }
        public bool IsSetStipulationValue() { return IsSetField(Tags.StipulationValue); }
    }

    public class NoStrategyParametersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StrategyParameterName, Tags.StrategyParameterType, Tags.StrategyParameterValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.StrategyParameterName, Tags.StrategyParameterType, Tags.StrategyParameterValue, 0};

        public NoStrategyParametersGroup()
          : base(Tags.NoStrategyParameters, Tags.StrategyParameterName, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoStrategyParametersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public StrategyParameterName StrategyParameterName
        {
            get
            {
                StrategyParameterName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrategyParameterName val) { StrategyParameterName = val; }
        public StrategyParameterName Get(StrategyParameterName val) { GetField(val); return val; }
        public bool IsSet(StrategyParameterName val) { return IsSetStrategyParameterName(); }
        public bool IsSetStrategyParameterName() { return IsSetField(Tags.StrategyParameterName); }

        public StrategyParameterType StrategyParameterType
        {
            get
            {
                StrategyParameterType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrategyParameterType val) { StrategyParameterType = val; }
        public StrategyParameterType Get(StrategyParameterType val) { GetField(val); return val; }
        public bool IsSet(StrategyParameterType val) { return IsSetStrategyParameterType(); }
        public bool IsSetStrategyParameterType() { return IsSetField(Tags.StrategyParameterType); }

        public StrategyParameterValue StrategyParameterValue
        {
            get
            {
                StrategyParameterValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrategyParameterValue val) { StrategyParameterValue = val; }
        public StrategyParameterValue Get(StrategyParameterValue val) { GetField(val); return val; }
        public bool IsSet(StrategyParameterValue val) { return IsSetStrategyParameterValue(); }
        public bool IsSetStrategyParameterValue() { return IsSetField(Tags.StrategyParameterValue); }
    }

    public class NoTrdRegTimestampsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0};

        public NoTrdRegTimestampsGroup()
          : base(Tags.NoTrdRegTimestamps, Tags.TrdRegTimestamp, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTrdRegTimestampsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public TrdRegTimestamp TrdRegTimestamp
        {
            get
            {
                TrdRegTimestamp val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestamp val) { TrdRegTimestamp = val; }
        public TrdRegTimestamp Get(TrdRegTimestamp val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestamp val) { return IsSetTrdRegTimestamp(); }
        public bool IsSetTrdRegTimestamp() { return IsSetField(Tags.TrdRegTimestamp); }

        public TrdRegTimestampType TrdRegTimestampType
        {
            get
            {
                TrdRegTimestampType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestampType val) { TrdRegTimestampType = val; }
        public TrdRegTimestampType Get(TrdRegTimestampType val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestampType val) { return IsSetTrdRegTimestampType(); }
        public bool IsSetTrdRegTimestampType() { return IsSetField(Tags.TrdRegTimestampType); }

        public TrdRegTimestampOrigin TrdRegTimestampOrigin
        {
            get
            {
                TrdRegTimestampOrigin val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestampOrigin val) { TrdRegTimestampOrigin = val; }
        public TrdRegTimestampOrigin Get(TrdRegTimestampOrigin val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestampOrigin val) { return IsSetTrdRegTimestampOrigin(); }
        public bool IsSetTrdRegTimestampOrigin() { return IsSetField(Tags.TrdRegTimestampOrigin); }

        public DeskType DeskType
        {
            get
            {
                DeskType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskType val) { DeskType = val; }
        public DeskType Get(DeskType val) { GetField(val); return val; }
        public bool IsSet(DeskType val) { return IsSetDeskType(); }
        public bool IsSetDeskType() { return IsSetField(Tags.DeskType); }

        public DeskTypeSource DeskTypeSource
        {
            get
            {
                DeskTypeSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskTypeSource val) { DeskTypeSource = val; }
        public DeskTypeSource Get(DeskTypeSource val) { GetField(val); return val; }
        public bool IsSet(DeskTypeSource val) { return IsSetDeskTypeSource(); }
        public bool IsSetDeskTypeSource() { return IsSetField(Tags.DeskTypeSource); }

        public DeskOrderHandlingInst DeskOrderHandlingInst
        {
            get
            {
                DeskOrderHandlingInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskOrderHandlingInst val) { DeskOrderHandlingInst = val; }
        public DeskOrderHandlingInst Get(DeskOrderHandlingInst val) { GetField(val); return val; }
        public bool IsSet(DeskOrderHandlingInst val) { return IsSetDeskOrderHandlingInst(); }
        public bool IsSetDeskOrderHandlingInst() { return IsSetField(Tags.DeskOrderHandlingInst); }
    }

    public class NoOrderAttributesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.OrderAttributeType, Tags.OrderAttributeValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.OrderAttributeType, Tags.OrderAttributeValue, 0};

        public NoOrderAttributesGroup()
          : base(Tags.NoOrderAttributes, Tags.OrderAttributeType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoOrderAttributesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public OrderAttributeType OrderAttributeType
        {
            get
            {
                OrderAttributeType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderAttributeType val) { OrderAttributeType = val; }
        public OrderAttributeType Get(OrderAttributeType val) { GetField(val); return val; }
        public bool IsSet(OrderAttributeType val) { return IsSetOrderAttributeType(); }
        public bool IsSetOrderAttributeType() { return IsSetField(Tags.OrderAttributeType); }

        public OrderAttributeValue OrderAttributeValue
        {
            get
            {
                OrderAttributeValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderAttributeValue val) { OrderAttributeValue = val; }
        public OrderAttributeValue Get(OrderAttributeValue val) { GetField(val); return val; }
        public bool IsSet(OrderAttributeValue val) { return IsSetOrderAttributeValue(); }
        public bool IsSetOrderAttributeValue() { return IsSetField(Tags.OrderAttributeValue); }
    }

    public class NoExecRuleNamesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ExecRuleName, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.ExecRuleName, 0};

        public NoExecRuleNamesGroup()
          : base(Tags.NoExecRuleNames, Tags.ExecRuleName, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoExecRuleNamesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ExecRuleName ExecRuleName
        {
            get
            {
                ExecRuleName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExecRuleName val) { ExecRuleName = val; }
        public ExecRuleName Get(ExecRuleName val) { GetField(val); return val; }
        public bool IsSet(ExecRuleName val) { return IsSetExecRuleName(); }
        public bool IsSetExecRuleName() { return IsSetField(Tags.ExecRuleName); }
    }

    public class NoNotesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.NoteType, Tags.NoteLabel, Tags.NoteText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.NoteType, Tags.NoteLabel, Tags.NoteText, 0};

        public NoNotesGroup()
          : base(Tags.NoNotes, Tags.NoteType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoNotesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public NoteType NoteType
        {
            get
            {
                NoteType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoteType val) { NoteType = val; }
        public NoteType Get(NoteType val) { GetField(val); return val; }
        public bool IsSet(NoteType val) { return IsSetNoteType(); }
        public bool IsSetNoteType() { return IsSetField(Tags.NoteType); }

        public NoteLabel NoteLabel
        {
            get
            {
                NoteLabel val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoteLabel val) { NoteLabel = val; }
        public NoteLabel Get(NoteLabel val) { GetField(val); return val; }
        public bool IsSet(NoteLabel val) { return IsSetNoteLabel(); }
        public bool IsSetNoteLabel() { return IsSetField(Tags.NoteLabel); }

        public NoteText NoteText
        {
            get
            {
                NoteText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoteText val) { NoteText = val; }
        public NoteText Get(NoteText val) { GetField(val); return val; }
        public bool IsSet(NoteText val) { return IsSetNoteText(); }
        public bool IsSetNoteText() { return IsSetField(Tags.NoteText); }
    }
}
