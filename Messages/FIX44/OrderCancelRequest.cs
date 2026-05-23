// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class OrderCancelRequest : Message
{
    public const string MsgType = "F";

    public OrderCancelRequest() : base()
    {
        Header.SetField(new MsgType("F"));
    }

    public OrderCancelRequest(
            OrigClOrdID aOrigClOrdID,
            ClOrdID aClOrdID,
            Symbol aSymbol,
            Side aSide,
            TransactTime aTransactTime
        ) : this()
    {
        OrigClOrdID = aOrigClOrdID;
        ClOrdID = aClOrdID;
        Symbol = aSymbol;
        Side = aSide;
        TransactTime = aTransactTime;
    }

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

    public class NoSecurityAltIDGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.SecurityAltID, Tags.SecurityAltIDSource, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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
        public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventTimeUnit, Tags.EventTimePeriod, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventTimeUnit, Tags.EventTimePeriod, 0};

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

        public EventTimeUnit EventTimeUnit
        {
            get
            {
                EventTimeUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventTimeUnit val) { EventTimeUnit = val; }
        public EventTimeUnit Get(EventTimeUnit val) { GetField(val); return val; }
        public bool IsSet(EventTimeUnit val) { return IsSetEventTimeUnit(); }
        public bool IsSetEventTimeUnit() { return IsSetField(Tags.EventTimeUnit); }

        public EventTimePeriod EventTimePeriod
        {
            get
            {
                EventTimePeriod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventTimePeriod val) { EventTimePeriod = val; }
        public EventTimePeriod Get(EventTimePeriod val) { GetField(val); return val; }
        public bool IsSet(EventTimePeriod val) { return IsSetEventTimePeriod(); }
        public bool IsSetEventTimePeriod() { return IsSetField(Tags.EventTimePeriod); }
    }

    public class NoInstrumentPartiesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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
        public static int[] DefaultFieldOrder = [Tags.ComplexEventType, Tags.ComplexEventPrice, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, Tags.ComplexRebate, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexEventPrice, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, Tags.ComplexRebate, 0};

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

        public ComplexRebate ComplexRebate
        {
            get
            {
                ComplexRebate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexRebate val) { ComplexRebate = val; }
        public ComplexRebate Get(ComplexRebate val) { GetField(val); return val; }
        public bool IsSet(ComplexRebate val) { return IsSetComplexRebate(); }
        public bool IsSetComplexRebate() { return IsSetField(Tags.ComplexRebate); }

        public class NoComplexEventDatesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, 0};

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
        }
    }

    public class NoOptionExerciseExpirationDatesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.OptionExerciseExpirationDate, Tags.OptionExerciseExpirationDateType, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoStipulationsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StipulationType, Tags.StipulationValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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
}
