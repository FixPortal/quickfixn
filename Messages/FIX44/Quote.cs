// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class Quote : Message
{
    public const string MsgType = "S";

    public Quote() : base()
    {
        Header.SetField(new MsgType("S"));
    }

    public Quote(
            QuoteID aQuoteID,
            Symbol aSymbol
        ) : this()
    {
        QuoteID = aQuoteID;
        Symbol = aSymbol;
    }

    public QuoteReqID QuoteReqID
    {
        get
        {
            QuoteReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteReqID val) { QuoteReqID = val; }
    public QuoteReqID Get(QuoteReqID val) { GetField(val); return val; }
    public bool IsSet(QuoteReqID val) { return IsSetQuoteReqID(); }
    public bool IsSetQuoteReqID() { return IsSetField(Tags.QuoteReqID); }

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

    public QuoteRespID QuoteRespID
    {
        get
        {
            QuoteRespID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteRespID val) { QuoteRespID = val; }
    public QuoteRespID Get(QuoteRespID val) { GetField(val); return val; }
    public bool IsSet(QuoteRespID val) { return IsSetQuoteRespID(); }
    public bool IsSetQuoteRespID() { return IsSetField(Tags.QuoteRespID); }

    public QuoteType QuoteType
    {
        get
        {
            QuoteType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteType val) { QuoteType = val; }
    public QuoteType Get(QuoteType val) { GetField(val); return val; }
    public bool IsSet(QuoteType val) { return IsSetQuoteType(); }
    public bool IsSetQuoteType() { return IsSetField(Tags.QuoteType); }

    public NoQuoteQualifiers NoQuoteQualifiers
    {
        get
        {
            NoQuoteQualifiers val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoQuoteQualifiers val) { NoQuoteQualifiers = val; }
    public NoQuoteQualifiers Get(NoQuoteQualifiers val) { GetField(val); return val; }
    public bool IsSet(NoQuoteQualifiers val) { return IsSetNoQuoteQualifiers(); }
    public bool IsSetNoQuoteQualifiers() { return IsSetField(Tags.NoQuoteQualifiers); }

    public QuoteResponseLevel QuoteResponseLevel
    {
        get
        {
            QuoteResponseLevel val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteResponseLevel val) { QuoteResponseLevel = val; }
    public QuoteResponseLevel Get(QuoteResponseLevel val) { GetField(val); return val; }
    public bool IsSet(QuoteResponseLevel val) { return IsSetQuoteResponseLevel(); }
    public bool IsSetQuoteResponseLevel() { return IsSetField(Tags.QuoteResponseLevel); }

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

    public MktBidPx MktBidPx
    {
        get
        {
            MktBidPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MktBidPx val) { MktBidPx = val; }
    public MktBidPx Get(MktBidPx val) { GetField(val); return val; }
    public bool IsSet(MktBidPx val) { return IsSetMktBidPx(); }
    public bool IsSetMktBidPx() { return IsSetField(Tags.MktBidPx); }

    public MktOfferPx MktOfferPx
    {
        get
        {
            MktOfferPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MktOfferPx val) { MktOfferPx = val; }
    public MktOfferPx Get(MktOfferPx val) { GetField(val); return val; }
    public bool IsSet(MktOfferPx val) { return IsSetMktOfferPx(); }
    public bool IsSetMktOfferPx() { return IsSetField(Tags.MktOfferPx); }

    public MinBidSize MinBidSize
    {
        get
        {
            MinBidSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinBidSize val) { MinBidSize = val; }
    public MinBidSize Get(MinBidSize val) { GetField(val); return val; }
    public bool IsSet(MinBidSize val) { return IsSetMinBidSize(); }
    public bool IsSetMinBidSize() { return IsSetField(Tags.MinBidSize); }

    public BidSize BidSize
    {
        get
        {
            BidSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidSize val) { BidSize = val; }
    public BidSize Get(BidSize val) { GetField(val); return val; }
    public bool IsSet(BidSize val) { return IsSetBidSize(); }
    public bool IsSetBidSize() { return IsSetField(Tags.BidSize); }

    public MinOfferSize MinOfferSize
    {
        get
        {
            MinOfferSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinOfferSize val) { MinOfferSize = val; }
    public MinOfferSize Get(MinOfferSize val) { GetField(val); return val; }
    public bool IsSet(MinOfferSize val) { return IsSetMinOfferSize(); }
    public bool IsSetMinOfferSize() { return IsSetField(Tags.MinOfferSize); }

    public OfferSize OfferSize
    {
        get
        {
            OfferSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferSize val) { OfferSize = val; }
    public OfferSize Get(OfferSize val) { GetField(val); return val; }
    public bool IsSet(OfferSize val) { return IsSetOfferSize(); }
    public bool IsSetOfferSize() { return IsSetField(Tags.OfferSize); }

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

    public BidSpotRate BidSpotRate
    {
        get
        {
            BidSpotRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidSpotRate val) { BidSpotRate = val; }
    public BidSpotRate Get(BidSpotRate val) { GetField(val); return val; }
    public bool IsSet(BidSpotRate val) { return IsSetBidSpotRate(); }
    public bool IsSetBidSpotRate() { return IsSetField(Tags.BidSpotRate); }

    public OfferSpotRate OfferSpotRate
    {
        get
        {
            OfferSpotRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferSpotRate val) { OfferSpotRate = val; }
    public OfferSpotRate Get(OfferSpotRate val) { GetField(val); return val; }
    public bool IsSet(OfferSpotRate val) { return IsSetOfferSpotRate(); }
    public bool IsSetOfferSpotRate() { return IsSetField(Tags.OfferSpotRate); }

    public BidForwardPoints BidForwardPoints
    {
        get
        {
            BidForwardPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidForwardPoints val) { BidForwardPoints = val; }
    public BidForwardPoints Get(BidForwardPoints val) { GetField(val); return val; }
    public bool IsSet(BidForwardPoints val) { return IsSetBidForwardPoints(); }
    public bool IsSetBidForwardPoints() { return IsSetField(Tags.BidForwardPoints); }

    public OfferForwardPoints OfferForwardPoints
    {
        get
        {
            OfferForwardPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferForwardPoints val) { OfferForwardPoints = val; }
    public OfferForwardPoints Get(OfferForwardPoints val) { GetField(val); return val; }
    public bool IsSet(OfferForwardPoints val) { return IsSetOfferForwardPoints(); }
    public bool IsSetOfferForwardPoints() { return IsSetField(Tags.OfferForwardPoints); }

    public MidPx MidPx
    {
        get
        {
            MidPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MidPx val) { MidPx = val; }
    public MidPx Get(MidPx val) { GetField(val); return val; }
    public bool IsSet(MidPx val) { return IsSetMidPx(); }
    public bool IsSetMidPx() { return IsSetField(Tags.MidPx); }

    public BidYield BidYield
    {
        get
        {
            BidYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidYield val) { BidYield = val; }
    public BidYield Get(BidYield val) { GetField(val); return val; }
    public bool IsSet(BidYield val) { return IsSetBidYield(); }
    public bool IsSetBidYield() { return IsSetField(Tags.BidYield); }

    public MidYield MidYield
    {
        get
        {
            MidYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MidYield val) { MidYield = val; }
    public MidYield Get(MidYield val) { GetField(val); return val; }
    public bool IsSet(MidYield val) { return IsSetMidYield(); }
    public bool IsSetMidYield() { return IsSetField(Tags.MidYield); }

    public OfferYield OfferYield
    {
        get
        {
            OfferYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferYield val) { OfferYield = val; }
    public OfferYield Get(OfferYield val) { GetField(val); return val; }
    public bool IsSet(OfferYield val) { return IsSetOfferYield(); }
    public bool IsSetOfferYield() { return IsSetField(Tags.OfferYield); }

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

    public BidForwardPoints2 BidForwardPoints2
    {
        get
        {
            BidForwardPoints2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidForwardPoints2 val) { BidForwardPoints2 = val; }
    public BidForwardPoints2 Get(BidForwardPoints2 val) { GetField(val); return val; }
    public bool IsSet(BidForwardPoints2 val) { return IsSetBidForwardPoints2(); }
    public bool IsSetBidForwardPoints2() { return IsSetField(Tags.BidForwardPoints2); }

    public OfferForwardPoints2 OfferForwardPoints2
    {
        get
        {
            OfferForwardPoints2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferForwardPoints2 val) { OfferForwardPoints2 = val; }
    public OfferForwardPoints2 Get(OfferForwardPoints2 val) { GetField(val); return val; }
    public bool IsSet(OfferForwardPoints2 val) { return IsSetOfferForwardPoints2(); }
    public bool IsSetOfferForwardPoints2() { return IsSetField(Tags.OfferForwardPoints2); }

    public SettlCurrBidFxRate SettlCurrBidFxRate
    {
        get
        {
            SettlCurrBidFxRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrBidFxRate val) { SettlCurrBidFxRate = val; }
    public SettlCurrBidFxRate Get(SettlCurrBidFxRate val) { GetField(val); return val; }
    public bool IsSet(SettlCurrBidFxRate val) { return IsSetSettlCurrBidFxRate(); }
    public bool IsSetSettlCurrBidFxRate() { return IsSetField(Tags.SettlCurrBidFxRate); }

    public SettlCurrOfferFxRate SettlCurrOfferFxRate
    {
        get
        {
            SettlCurrOfferFxRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrOfferFxRate val) { SettlCurrOfferFxRate = val; }
    public SettlCurrOfferFxRate Get(SettlCurrOfferFxRate val) { GetField(val); return val; }
    public bool IsSet(SettlCurrOfferFxRate val) { return IsSetSettlCurrOfferFxRate(); }
    public bool IsSetSettlCurrOfferFxRate() { return IsSetField(Tags.SettlCurrOfferFxRate); }

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

    public class NoQuoteQualifiersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.QuoteQualifier, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.QuoteQualifier, 0};

        public NoQuoteQualifiersGroup()
          : base(Tags.NoQuoteQualifiers, Tags.QuoteQualifier, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoQuoteQualifiersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public QuoteQualifier QuoteQualifier
        {
            get
            {
                QuoteQualifier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteQualifier val) { QuoteQualifier = val; }
        public QuoteQualifier Get(QuoteQualifier val) { GetField(val); return val; }
        public bool IsSet(QuoteQualifier val) { return IsSetQuoteQualifier(); }
        public bool IsSetQuoteQualifier() { return IsSetField(Tags.QuoteQualifier); }
    }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartyRoleQualifier, Tags.NoPartySubIDs, Tags.NoPartyAltIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
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

        public class NoPartyAltIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartyAltID, Tags.PartyAltIDSource, Tags.NoPartyAltSubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
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

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
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
        public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventTimeUnit, Tags.EventTimePeriod, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
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
        public static int[] DefaultFieldOrder = [Tags.ComplexEventType, Tags.ComplexEventPrice, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, Tags.ComplexRebate, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
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
        public static int[] DefaultFieldOrder = [Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityDate, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingIssueDate, Tags.UnderlyingFactor, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.NoUnderlyingStips, Tags.NoUndlyInstrumentParties, Tags.UnderlyingCouponFrequencyPeriod, Tags.UnderlyingCouponFrequencyUnit, Tags.UnderlyingCouponDayCount, Tags.UnderlyingObligationID, Tags.UnderlyingObligationIDSource, Tags.NoUnderlyingEvents, Tags.UnderlyingIndexSeries, Tags.UnderlyingIndexAnnexVersion, Tags.UnderlyingIndexAnnexDate, Tags.UnderlyingIndexAnnexSource, Tags.UnderlyingAssetClass, Tags.UnderlyingAssetSubClass, Tags.NoUnderlyingStreams, Tags.UnderlyingStartAcrdIntAmt, Tags.UnderlyingEndAcrdIntAmt, Tags.UnderlyingPriceType, Tags.UnderlyingCouponDateGenerationMethod, Tags.UnderlyingIndexCurvePeriod, Tags.UnderlyingIndexCurveUnit, Tags.NoUnderlyingReinvCoupon, Tags.UnderlyingSecuritySeries, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityDate, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingIssueDate, Tags.UnderlyingFactor, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.NoUnderlyingStips, Tags.NoUndlyInstrumentParties, Tags.UnderlyingCouponFrequencyPeriod, Tags.UnderlyingCouponFrequencyUnit, Tags.UnderlyingCouponDayCount, Tags.UnderlyingObligationID, Tags.UnderlyingObligationIDSource, Tags.NoUnderlyingEvents, Tags.UnderlyingIndexSeries, Tags.UnderlyingIndexAnnexVersion, Tags.UnderlyingIndexAnnexDate, Tags.UnderlyingIndexAnnexSource, Tags.UnderlyingAssetClass, Tags.UnderlyingAssetSubClass, Tags.NoUnderlyingStreams, Tags.UnderlyingStartAcrdIntAmt, Tags.UnderlyingEndAcrdIntAmt, Tags.UnderlyingPriceType, Tags.UnderlyingCouponDateGenerationMethod, Tags.UnderlyingIndexCurvePeriod, Tags.UnderlyingIndexCurveUnit, Tags.NoUnderlyingReinvCoupon, Tags.UnderlyingSecuritySeries, 0};

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
            public static int[] DefaultFieldOrder = [Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, 0};

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

    public class NoLegsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegMaturityDate, Tags.LegRestructuringType, Tags.LegSeniority, Tags.LegAttachmentPoint, Tags.LegDetachmentPoint, Tags.LegAssetClass, Tags.LegAssetSubClass, Tags.LegCouponFrequencyPeriod, Tags.LegCouponFrequencyUnit, Tags.LegCouponDayCount, Tags.LegIndexSeries, Tags.LegIndexAnnexVersion, Tags.LegIndexAnnexDate, Tags.LegIndexAnnexSource, Tags.LegFactor, Tags.LegCountryOfIssue, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegContractMultiplier, Tags.LegSettlMethod, Tags.LegExerciseStyle, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.LegSecurityDesc, Tags.LegSecurityXMLLen, Tags.LegSecurityXML, Tags.LegSecurityXMLSchema, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegContractSettlMonth, Tags.LegPutOrCall, Tags.LegPrice, Tags.NoLegEvents, Tags.NoLegComplexEvents, Tags.LegBusinessDayConvention, Tags.LegDateRollConvention, Tags.LegOptionExerciseLatestTime, Tags.LegOptionExerciseTimeBusinessCenter, Tags.LegOptionExerciseDeliveryDate, Tags.NoLegStreams, Tags.LegCouponDateGenerationMethod, Tags.LegPutOrCallCurrency, Tags.LegStrategyPosition, Tags.LegCustomizedIndicator, Tags.LegQty, Tags.LegSwapType, Tags.LegSettlType, Tags.LegSettlDate, Tags.NoLegStipulations, Tags.NoNestedPartyIDs, Tags.LegPriceType, Tags.LegBidPx, Tags.LegOfferPx, Tags.LegBenchmarkCurveCurrency, Tags.LegBenchmarkCurveName, Tags.LegBenchmarkCurvePoint, Tags.LegBenchmarkPrice, Tags.LegBenchmarkPriceType, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegMaturityDate, Tags.LegRestructuringType, Tags.LegSeniority, Tags.LegAttachmentPoint, Tags.LegDetachmentPoint, Tags.LegAssetClass, Tags.LegAssetSubClass, Tags.LegCouponFrequencyPeriod, Tags.LegCouponFrequencyUnit, Tags.LegCouponDayCount, Tags.LegIndexSeries, Tags.LegIndexAnnexVersion, Tags.LegIndexAnnexDate, Tags.LegIndexAnnexSource, Tags.LegFactor, Tags.LegCountryOfIssue, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegContractMultiplier, Tags.LegSettlMethod, Tags.LegExerciseStyle, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.LegSecurityDesc, Tags.LegSecurityXMLLen, Tags.LegSecurityXML, Tags.LegSecurityXMLSchema, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegContractSettlMonth, Tags.LegPutOrCall, Tags.LegPrice, Tags.NoLegEvents, Tags.NoLegComplexEvents, Tags.LegBusinessDayConvention, Tags.LegDateRollConvention, Tags.LegOptionExerciseLatestTime, Tags.LegOptionExerciseTimeBusinessCenter, Tags.LegOptionExerciseDeliveryDate, Tags.NoLegStreams, Tags.LegCouponDateGenerationMethod, Tags.LegPutOrCallCurrency, Tags.LegStrategyPosition, Tags.LegCustomizedIndicator, Tags.LegQty, Tags.LegSwapType, Tags.LegSettlType, Tags.LegSettlDate, Tags.NoLegStipulations, Tags.NoNestedPartyIDs, Tags.LegPriceType, Tags.LegBidPx, Tags.LegOfferPx, Tags.LegBenchmarkCurveCurrency, Tags.LegBenchmarkCurveName, Tags.LegBenchmarkCurvePoint, Tags.LegBenchmarkPrice, Tags.LegBenchmarkPriceType, 0};

        public NoLegsGroup()
          : base(Tags.NoLegs, Tags.LegSymbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoLegsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public LegSymbolSfx LegSymbolSfx
        {
            get
            {
                LegSymbolSfx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSymbolSfx val) { LegSymbolSfx = val; }
        public LegSymbolSfx Get(LegSymbolSfx val) { GetField(val); return val; }
        public bool IsSet(LegSymbolSfx val) { return IsSetLegSymbolSfx(); }
        public bool IsSetLegSymbolSfx() { return IsSetField(Tags.LegSymbolSfx); }

        public LegSecurityID LegSecurityID
        {
            get
            {
                LegSecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityID val) { LegSecurityID = val; }
        public LegSecurityID Get(LegSecurityID val) { GetField(val); return val; }
        public bool IsSet(LegSecurityID val) { return IsSetLegSecurityID(); }
        public bool IsSetLegSecurityID() { return IsSetField(Tags.LegSecurityID); }

        public LegSecurityIDSource LegSecurityIDSource
        {
            get
            {
                LegSecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityIDSource val) { LegSecurityIDSource = val; }
        public LegSecurityIDSource Get(LegSecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(LegSecurityIDSource val) { return IsSetLegSecurityIDSource(); }
        public bool IsSetLegSecurityIDSource() { return IsSetField(Tags.LegSecurityIDSource); }

        public NoLegSecurityAltID NoLegSecurityAltID
        {
            get
            {
                NoLegSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegSecurityAltID val) { NoLegSecurityAltID = val; }
        public NoLegSecurityAltID Get(NoLegSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(NoLegSecurityAltID val) { return IsSetNoLegSecurityAltID(); }
        public bool IsSetNoLegSecurityAltID() { return IsSetField(Tags.NoLegSecurityAltID); }

        public LegID LegID
        {
            get
            {
                LegID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegID val) { LegID = val; }
        public LegID Get(LegID val) { GetField(val); return val; }
        public bool IsSet(LegID val) { return IsSetLegID(); }
        public bool IsSetLegID() { return IsSetField(Tags.LegID); }

        public LegProduct LegProduct
        {
            get
            {
                LegProduct val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegProduct val) { LegProduct = val; }
        public LegProduct Get(LegProduct val) { GetField(val); return val; }
        public bool IsSet(LegProduct val) { return IsSetLegProduct(); }
        public bool IsSetLegProduct() { return IsSetField(Tags.LegProduct); }

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

        public LegRestructuringType LegRestructuringType
        {
            get
            {
                LegRestructuringType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRestructuringType val) { LegRestructuringType = val; }
        public LegRestructuringType Get(LegRestructuringType val) { GetField(val); return val; }
        public bool IsSet(LegRestructuringType val) { return IsSetLegRestructuringType(); }
        public bool IsSetLegRestructuringType() { return IsSetField(Tags.LegRestructuringType); }

        public LegSeniority LegSeniority
        {
            get
            {
                LegSeniority val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSeniority val) { LegSeniority = val; }
        public LegSeniority Get(LegSeniority val) { GetField(val); return val; }
        public bool IsSet(LegSeniority val) { return IsSetLegSeniority(); }
        public bool IsSetLegSeniority() { return IsSetField(Tags.LegSeniority); }

        public LegAttachmentPoint LegAttachmentPoint
        {
            get
            {
                LegAttachmentPoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegAttachmentPoint val) { LegAttachmentPoint = val; }
        public LegAttachmentPoint Get(LegAttachmentPoint val) { GetField(val); return val; }
        public bool IsSet(LegAttachmentPoint val) { return IsSetLegAttachmentPoint(); }
        public bool IsSetLegAttachmentPoint() { return IsSetField(Tags.LegAttachmentPoint); }

        public LegDetachmentPoint LegDetachmentPoint
        {
            get
            {
                LegDetachmentPoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegDetachmentPoint val) { LegDetachmentPoint = val; }
        public LegDetachmentPoint Get(LegDetachmentPoint val) { GetField(val); return val; }
        public bool IsSet(LegDetachmentPoint val) { return IsSetLegDetachmentPoint(); }
        public bool IsSetLegDetachmentPoint() { return IsSetField(Tags.LegDetachmentPoint); }

        public LegAssetClass LegAssetClass
        {
            get
            {
                LegAssetClass val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegAssetClass val) { LegAssetClass = val; }
        public LegAssetClass Get(LegAssetClass val) { GetField(val); return val; }
        public bool IsSet(LegAssetClass val) { return IsSetLegAssetClass(); }
        public bool IsSetLegAssetClass() { return IsSetField(Tags.LegAssetClass); }

        public LegAssetSubClass LegAssetSubClass
        {
            get
            {
                LegAssetSubClass val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegAssetSubClass val) { LegAssetSubClass = val; }
        public LegAssetSubClass Get(LegAssetSubClass val) { GetField(val); return val; }
        public bool IsSet(LegAssetSubClass val) { return IsSetLegAssetSubClass(); }
        public bool IsSetLegAssetSubClass() { return IsSetField(Tags.LegAssetSubClass); }

        public LegCouponFrequencyPeriod LegCouponFrequencyPeriod
        {
            get
            {
                LegCouponFrequencyPeriod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponFrequencyPeriod val) { LegCouponFrequencyPeriod = val; }
        public LegCouponFrequencyPeriod Get(LegCouponFrequencyPeriod val) { GetField(val); return val; }
        public bool IsSet(LegCouponFrequencyPeriod val) { return IsSetLegCouponFrequencyPeriod(); }
        public bool IsSetLegCouponFrequencyPeriod() { return IsSetField(Tags.LegCouponFrequencyPeriod); }

        public LegCouponFrequencyUnit LegCouponFrequencyUnit
        {
            get
            {
                LegCouponFrequencyUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponFrequencyUnit val) { LegCouponFrequencyUnit = val; }
        public LegCouponFrequencyUnit Get(LegCouponFrequencyUnit val) { GetField(val); return val; }
        public bool IsSet(LegCouponFrequencyUnit val) { return IsSetLegCouponFrequencyUnit(); }
        public bool IsSetLegCouponFrequencyUnit() { return IsSetField(Tags.LegCouponFrequencyUnit); }

        public LegCouponDayCount LegCouponDayCount
        {
            get
            {
                LegCouponDayCount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponDayCount val) { LegCouponDayCount = val; }
        public LegCouponDayCount Get(LegCouponDayCount val) { GetField(val); return val; }
        public bool IsSet(LegCouponDayCount val) { return IsSetLegCouponDayCount(); }
        public bool IsSetLegCouponDayCount() { return IsSetField(Tags.LegCouponDayCount); }

        public LegIndexSeries LegIndexSeries
        {
            get
            {
                LegIndexSeries val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIndexSeries val) { LegIndexSeries = val; }
        public LegIndexSeries Get(LegIndexSeries val) { GetField(val); return val; }
        public bool IsSet(LegIndexSeries val) { return IsSetLegIndexSeries(); }
        public bool IsSetLegIndexSeries() { return IsSetField(Tags.LegIndexSeries); }

        public LegIndexAnnexVersion LegIndexAnnexVersion
        {
            get
            {
                LegIndexAnnexVersion val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIndexAnnexVersion val) { LegIndexAnnexVersion = val; }
        public LegIndexAnnexVersion Get(LegIndexAnnexVersion val) { GetField(val); return val; }
        public bool IsSet(LegIndexAnnexVersion val) { return IsSetLegIndexAnnexVersion(); }
        public bool IsSetLegIndexAnnexVersion() { return IsSetField(Tags.LegIndexAnnexVersion); }

        public LegIndexAnnexDate LegIndexAnnexDate
        {
            get
            {
                LegIndexAnnexDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIndexAnnexDate val) { LegIndexAnnexDate = val; }
        public LegIndexAnnexDate Get(LegIndexAnnexDate val) { GetField(val); return val; }
        public bool IsSet(LegIndexAnnexDate val) { return IsSetLegIndexAnnexDate(); }
        public bool IsSetLegIndexAnnexDate() { return IsSetField(Tags.LegIndexAnnexDate); }

        public LegIndexAnnexSource LegIndexAnnexSource
        {
            get
            {
                LegIndexAnnexSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIndexAnnexSource val) { LegIndexAnnexSource = val; }
        public LegIndexAnnexSource Get(LegIndexAnnexSource val) { GetField(val); return val; }
        public bool IsSet(LegIndexAnnexSource val) { return IsSetLegIndexAnnexSource(); }
        public bool IsSetLegIndexAnnexSource() { return IsSetField(Tags.LegIndexAnnexSource); }

        public LegFactor LegFactor
        {
            get
            {
                LegFactor val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegFactor val) { LegFactor = val; }
        public LegFactor Get(LegFactor val) { GetField(val); return val; }
        public bool IsSet(LegFactor val) { return IsSetLegFactor(); }
        public bool IsSetLegFactor() { return IsSetField(Tags.LegFactor); }

        public LegCountryOfIssue LegCountryOfIssue
        {
            get
            {
                LegCountryOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCountryOfIssue val) { LegCountryOfIssue = val; }
        public LegCountryOfIssue Get(LegCountryOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegCountryOfIssue val) { return IsSetLegCountryOfIssue(); }
        public bool IsSetLegCountryOfIssue() { return IsSetField(Tags.LegCountryOfIssue); }

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

        public LegStrikeCurrency LegStrikeCurrency
        {
            get
            {
                LegStrikeCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStrikeCurrency val) { LegStrikeCurrency = val; }
        public LegStrikeCurrency Get(LegStrikeCurrency val) { GetField(val); return val; }
        public bool IsSet(LegStrikeCurrency val) { return IsSetLegStrikeCurrency(); }
        public bool IsSetLegStrikeCurrency() { return IsSetField(Tags.LegStrikeCurrency); }

        public LegContractMultiplier LegContractMultiplier
        {
            get
            {
                LegContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegContractMultiplier val) { LegContractMultiplier = val; }
        public LegContractMultiplier Get(LegContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(LegContractMultiplier val) { return IsSetLegContractMultiplier(); }
        public bool IsSetLegContractMultiplier() { return IsSetField(Tags.LegContractMultiplier); }

        public LegSettlMethod LegSettlMethod
        {
            get
            {
                LegSettlMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlMethod val) { LegSettlMethod = val; }
        public LegSettlMethod Get(LegSettlMethod val) { GetField(val); return val; }
        public bool IsSet(LegSettlMethod val) { return IsSetLegSettlMethod(); }
        public bool IsSetLegSettlMethod() { return IsSetField(Tags.LegSettlMethod); }

        public LegExerciseStyle LegExerciseStyle
        {
            get
            {
                LegExerciseStyle val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegExerciseStyle val) { LegExerciseStyle = val; }
        public LegExerciseStyle Get(LegExerciseStyle val) { GetField(val); return val; }
        public bool IsSet(LegExerciseStyle val) { return IsSetLegExerciseStyle(); }
        public bool IsSetLegExerciseStyle() { return IsSetField(Tags.LegExerciseStyle); }

        public LegCouponRate LegCouponRate
        {
            get
            {
                LegCouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponRate val) { LegCouponRate = val; }
        public LegCouponRate Get(LegCouponRate val) { GetField(val); return val; }
        public bool IsSet(LegCouponRate val) { return IsSetLegCouponRate(); }
        public bool IsSetLegCouponRate() { return IsSetField(Tags.LegCouponRate); }

        public LegSecurityExchange LegSecurityExchange
        {
            get
            {
                LegSecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityExchange val) { LegSecurityExchange = val; }
        public LegSecurityExchange Get(LegSecurityExchange val) { GetField(val); return val; }
        public bool IsSet(LegSecurityExchange val) { return IsSetLegSecurityExchange(); }
        public bool IsSetLegSecurityExchange() { return IsSetField(Tags.LegSecurityExchange); }

        public LegIssuer LegIssuer
        {
            get
            {
                LegIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIssuer val) { LegIssuer = val; }
        public LegIssuer Get(LegIssuer val) { GetField(val); return val; }
        public bool IsSet(LegIssuer val) { return IsSetLegIssuer(); }
        public bool IsSetLegIssuer() { return IsSetField(Tags.LegIssuer); }

        public LegSecurityDesc LegSecurityDesc
        {
            get
            {
                LegSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityDesc val) { LegSecurityDesc = val; }
        public LegSecurityDesc Get(LegSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(LegSecurityDesc val) { return IsSetLegSecurityDesc(); }
        public bool IsSetLegSecurityDesc() { return IsSetField(Tags.LegSecurityDesc); }

        public LegSecurityXMLLen LegSecurityXMLLen
        {
            get
            {
                LegSecurityXMLLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityXMLLen val) { LegSecurityXMLLen = val; }
        public LegSecurityXMLLen Get(LegSecurityXMLLen val) { GetField(val); return val; }
        public bool IsSet(LegSecurityXMLLen val) { return IsSetLegSecurityXMLLen(); }
        public bool IsSetLegSecurityXMLLen() { return IsSetField(Tags.LegSecurityXMLLen); }

        public LegSecurityXML LegSecurityXML
        {
            get
            {
                LegSecurityXML val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityXML val) { LegSecurityXML = val; }
        public LegSecurityXML Get(LegSecurityXML val) { GetField(val); return val; }
        public bool IsSet(LegSecurityXML val) { return IsSetLegSecurityXML(); }
        public bool IsSetLegSecurityXML() { return IsSetField(Tags.LegSecurityXML); }

        public LegSecurityXMLSchema LegSecurityXMLSchema
        {
            get
            {
                LegSecurityXMLSchema val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityXMLSchema val) { LegSecurityXMLSchema = val; }
        public LegSecurityXMLSchema Get(LegSecurityXMLSchema val) { GetField(val); return val; }
        public bool IsSet(LegSecurityXMLSchema val) { return IsSetLegSecurityXMLSchema(); }
        public bool IsSetLegSecurityXMLSchema() { return IsSetField(Tags.LegSecurityXMLSchema); }

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

        public LegCurrency LegCurrency
        {
            get
            {
                LegCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCurrency val) { LegCurrency = val; }
        public LegCurrency Get(LegCurrency val) { GetField(val); return val; }
        public bool IsSet(LegCurrency val) { return IsSetLegCurrency(); }
        public bool IsSetLegCurrency() { return IsSetField(Tags.LegCurrency); }

        public LegPool LegPool
        {
            get
            {
                LegPool val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPool val) { LegPool = val; }
        public LegPool Get(LegPool val) { GetField(val); return val; }
        public bool IsSet(LegPool val) { return IsSetLegPool(); }
        public bool IsSetLegPool() { return IsSetField(Tags.LegPool); }

        public LegContractSettlMonth LegContractSettlMonth
        {
            get
            {
                LegContractSettlMonth val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegContractSettlMonth val) { LegContractSettlMonth = val; }
        public LegContractSettlMonth Get(LegContractSettlMonth val) { GetField(val); return val; }
        public bool IsSet(LegContractSettlMonth val) { return IsSetLegContractSettlMonth(); }
        public bool IsSetLegContractSettlMonth() { return IsSetField(Tags.LegContractSettlMonth); }

        public LegPutOrCall LegPutOrCall
        {
            get
            {
                LegPutOrCall val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPutOrCall val) { LegPutOrCall = val; }
        public LegPutOrCall Get(LegPutOrCall val) { GetField(val); return val; }
        public bool IsSet(LegPutOrCall val) { return IsSetLegPutOrCall(); }
        public bool IsSetLegPutOrCall() { return IsSetField(Tags.LegPutOrCall); }

        public LegPrice LegPrice
        {
            get
            {
                LegPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPrice val) { LegPrice = val; }
        public LegPrice Get(LegPrice val) { GetField(val); return val; }
        public bool IsSet(LegPrice val) { return IsSetLegPrice(); }
        public bool IsSetLegPrice() { return IsSetField(Tags.LegPrice); }

        public NoLegEvents NoLegEvents
        {
            get
            {
                NoLegEvents val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegEvents val) { NoLegEvents = val; }
        public NoLegEvents Get(NoLegEvents val) { GetField(val); return val; }
        public bool IsSet(NoLegEvents val) { return IsSetNoLegEvents(); }
        public bool IsSetNoLegEvents() { return IsSetField(Tags.NoLegEvents); }

        public NoLegComplexEvents NoLegComplexEvents
        {
            get
            {
                NoLegComplexEvents val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegComplexEvents val) { NoLegComplexEvents = val; }
        public NoLegComplexEvents Get(NoLegComplexEvents val) { GetField(val); return val; }
        public bool IsSet(NoLegComplexEvents val) { return IsSetNoLegComplexEvents(); }
        public bool IsSetNoLegComplexEvents() { return IsSetField(Tags.NoLegComplexEvents); }

        public LegBusinessDayConvention LegBusinessDayConvention
        {
            get
            {
                LegBusinessDayConvention val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegBusinessDayConvention val) { LegBusinessDayConvention = val; }
        public LegBusinessDayConvention Get(LegBusinessDayConvention val) { GetField(val); return val; }
        public bool IsSet(LegBusinessDayConvention val) { return IsSetLegBusinessDayConvention(); }
        public bool IsSetLegBusinessDayConvention() { return IsSetField(Tags.LegBusinessDayConvention); }

        public LegDateRollConvention LegDateRollConvention
        {
            get
            {
                LegDateRollConvention val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegDateRollConvention val) { LegDateRollConvention = val; }
        public LegDateRollConvention Get(LegDateRollConvention val) { GetField(val); return val; }
        public bool IsSet(LegDateRollConvention val) { return IsSetLegDateRollConvention(); }
        public bool IsSetLegDateRollConvention() { return IsSetField(Tags.LegDateRollConvention); }

        public LegOptionExerciseLatestTime LegOptionExerciseLatestTime
        {
            get
            {
                LegOptionExerciseLatestTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOptionExerciseLatestTime val) { LegOptionExerciseLatestTime = val; }
        public LegOptionExerciseLatestTime Get(LegOptionExerciseLatestTime val) { GetField(val); return val; }
        public bool IsSet(LegOptionExerciseLatestTime val) { return IsSetLegOptionExerciseLatestTime(); }
        public bool IsSetLegOptionExerciseLatestTime() { return IsSetField(Tags.LegOptionExerciseLatestTime); }

        public LegOptionExerciseTimeBusinessCenter LegOptionExerciseTimeBusinessCenter
        {
            get
            {
                LegOptionExerciseTimeBusinessCenter val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOptionExerciseTimeBusinessCenter val) { LegOptionExerciseTimeBusinessCenter = val; }
        public LegOptionExerciseTimeBusinessCenter Get(LegOptionExerciseTimeBusinessCenter val) { GetField(val); return val; }
        public bool IsSet(LegOptionExerciseTimeBusinessCenter val) { return IsSetLegOptionExerciseTimeBusinessCenter(); }
        public bool IsSetLegOptionExerciseTimeBusinessCenter() { return IsSetField(Tags.LegOptionExerciseTimeBusinessCenter); }

        public LegOptionExerciseDeliveryDate LegOptionExerciseDeliveryDate
        {
            get
            {
                LegOptionExerciseDeliveryDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOptionExerciseDeliveryDate val) { LegOptionExerciseDeliveryDate = val; }
        public LegOptionExerciseDeliveryDate Get(LegOptionExerciseDeliveryDate val) { GetField(val); return val; }
        public bool IsSet(LegOptionExerciseDeliveryDate val) { return IsSetLegOptionExerciseDeliveryDate(); }
        public bool IsSetLegOptionExerciseDeliveryDate() { return IsSetField(Tags.LegOptionExerciseDeliveryDate); }

        public NoLegStreams NoLegStreams
        {
            get
            {
                NoLegStreams val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegStreams val) { NoLegStreams = val; }
        public NoLegStreams Get(NoLegStreams val) { GetField(val); return val; }
        public bool IsSet(NoLegStreams val) { return IsSetNoLegStreams(); }
        public bool IsSetNoLegStreams() { return IsSetField(Tags.NoLegStreams); }

        public LegCouponDateGenerationMethod LegCouponDateGenerationMethod
        {
            get
            {
                LegCouponDateGenerationMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponDateGenerationMethod val) { LegCouponDateGenerationMethod = val; }
        public LegCouponDateGenerationMethod Get(LegCouponDateGenerationMethod val) { GetField(val); return val; }
        public bool IsSet(LegCouponDateGenerationMethod val) { return IsSetLegCouponDateGenerationMethod(); }
        public bool IsSetLegCouponDateGenerationMethod() { return IsSetField(Tags.LegCouponDateGenerationMethod); }

        public LegPutOrCallCurrency LegPutOrCallCurrency
        {
            get
            {
                LegPutOrCallCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPutOrCallCurrency val) { LegPutOrCallCurrency = val; }
        public LegPutOrCallCurrency Get(LegPutOrCallCurrency val) { GetField(val); return val; }
        public bool IsSet(LegPutOrCallCurrency val) { return IsSetLegPutOrCallCurrency(); }
        public bool IsSetLegPutOrCallCurrency() { return IsSetField(Tags.LegPutOrCallCurrency); }

        public LegStrategyPosition LegStrategyPosition
        {
            get
            {
                LegStrategyPosition val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStrategyPosition val) { LegStrategyPosition = val; }
        public LegStrategyPosition Get(LegStrategyPosition val) { GetField(val); return val; }
        public bool IsSet(LegStrategyPosition val) { return IsSetLegStrategyPosition(); }
        public bool IsSetLegStrategyPosition() { return IsSetField(Tags.LegStrategyPosition); }

        public LegCustomizedIndicator LegCustomizedIndicator
        {
            get
            {
                LegCustomizedIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCustomizedIndicator val) { LegCustomizedIndicator = val; }
        public LegCustomizedIndicator Get(LegCustomizedIndicator val) { GetField(val); return val; }
        public bool IsSet(LegCustomizedIndicator val) { return IsSetLegCustomizedIndicator(); }
        public bool IsSetLegCustomizedIndicator() { return IsSetField(Tags.LegCustomizedIndicator); }

        public LegQty LegQty
        {
            get
            {
                LegQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegQty val) { LegQty = val; }
        public LegQty Get(LegQty val) { GetField(val); return val; }
        public bool IsSet(LegQty val) { return IsSetLegQty(); }
        public bool IsSetLegQty() { return IsSetField(Tags.LegQty); }

        public LegSwapType LegSwapType
        {
            get
            {
                LegSwapType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSwapType val) { LegSwapType = val; }
        public LegSwapType Get(LegSwapType val) { GetField(val); return val; }
        public bool IsSet(LegSwapType val) { return IsSetLegSwapType(); }
        public bool IsSetLegSwapType() { return IsSetField(Tags.LegSwapType); }

        public LegSettlType LegSettlType
        {
            get
            {
                LegSettlType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlType val) { LegSettlType = val; }
        public LegSettlType Get(LegSettlType val) { GetField(val); return val; }
        public bool IsSet(LegSettlType val) { return IsSetLegSettlType(); }
        public bool IsSetLegSettlType() { return IsSetField(Tags.LegSettlType); }

        public LegSettlDate LegSettlDate
        {
            get
            {
                LegSettlDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlDate val) { LegSettlDate = val; }
        public LegSettlDate Get(LegSettlDate val) { GetField(val); return val; }
        public bool IsSet(LegSettlDate val) { return IsSetLegSettlDate(); }
        public bool IsSetLegSettlDate() { return IsSetField(Tags.LegSettlDate); }

        public NoLegStipulations NoLegStipulations
        {
            get
            {
                NoLegStipulations val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegStipulations val) { NoLegStipulations = val; }
        public NoLegStipulations Get(NoLegStipulations val) { GetField(val); return val; }
        public bool IsSet(NoLegStipulations val) { return IsSetNoLegStipulations(); }
        public bool IsSetNoLegStipulations() { return IsSetField(Tags.NoLegStipulations); }

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

        public LegPriceType LegPriceType
        {
            get
            {
                LegPriceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPriceType val) { LegPriceType = val; }
        public LegPriceType Get(LegPriceType val) { GetField(val); return val; }
        public bool IsSet(LegPriceType val) { return IsSetLegPriceType(); }
        public bool IsSetLegPriceType() { return IsSetField(Tags.LegPriceType); }

        public LegBidPx LegBidPx
        {
            get
            {
                LegBidPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegBidPx val) { LegBidPx = val; }
        public LegBidPx Get(LegBidPx val) { GetField(val); return val; }
        public bool IsSet(LegBidPx val) { return IsSetLegBidPx(); }
        public bool IsSetLegBidPx() { return IsSetField(Tags.LegBidPx); }

        public LegOfferPx LegOfferPx
        {
            get
            {
                LegOfferPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOfferPx val) { LegOfferPx = val; }
        public LegOfferPx Get(LegOfferPx val) { GetField(val); return val; }
        public bool IsSet(LegOfferPx val) { return IsSetLegOfferPx(); }
        public bool IsSetLegOfferPx() { return IsSetField(Tags.LegOfferPx); }

        public LegBenchmarkCurveCurrency LegBenchmarkCurveCurrency
        {
            get
            {
                LegBenchmarkCurveCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegBenchmarkCurveCurrency val) { LegBenchmarkCurveCurrency = val; }
        public LegBenchmarkCurveCurrency Get(LegBenchmarkCurveCurrency val) { GetField(val); return val; }
        public bool IsSet(LegBenchmarkCurveCurrency val) { return IsSetLegBenchmarkCurveCurrency(); }
        public bool IsSetLegBenchmarkCurveCurrency() { return IsSetField(Tags.LegBenchmarkCurveCurrency); }

        public LegBenchmarkCurveName LegBenchmarkCurveName
        {
            get
            {
                LegBenchmarkCurveName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegBenchmarkCurveName val) { LegBenchmarkCurveName = val; }
        public LegBenchmarkCurveName Get(LegBenchmarkCurveName val) { GetField(val); return val; }
        public bool IsSet(LegBenchmarkCurveName val) { return IsSetLegBenchmarkCurveName(); }
        public bool IsSetLegBenchmarkCurveName() { return IsSetField(Tags.LegBenchmarkCurveName); }

        public LegBenchmarkCurvePoint LegBenchmarkCurvePoint
        {
            get
            {
                LegBenchmarkCurvePoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegBenchmarkCurvePoint val) { LegBenchmarkCurvePoint = val; }
        public LegBenchmarkCurvePoint Get(LegBenchmarkCurvePoint val) { GetField(val); return val; }
        public bool IsSet(LegBenchmarkCurvePoint val) { return IsSetLegBenchmarkCurvePoint(); }
        public bool IsSetLegBenchmarkCurvePoint() { return IsSetField(Tags.LegBenchmarkCurvePoint); }

        public LegBenchmarkPrice LegBenchmarkPrice
        {
            get
            {
                LegBenchmarkPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegBenchmarkPrice val) { LegBenchmarkPrice = val; }
        public LegBenchmarkPrice Get(LegBenchmarkPrice val) { GetField(val); return val; }
        public bool IsSet(LegBenchmarkPrice val) { return IsSetLegBenchmarkPrice(); }
        public bool IsSetLegBenchmarkPrice() { return IsSetField(Tags.LegBenchmarkPrice); }

        public LegBenchmarkPriceType LegBenchmarkPriceType
        {
            get
            {
                LegBenchmarkPriceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegBenchmarkPriceType val) { LegBenchmarkPriceType = val; }
        public LegBenchmarkPriceType Get(LegBenchmarkPriceType val) { GetField(val); return val; }
        public bool IsSet(LegBenchmarkPriceType val) { return IsSetLegBenchmarkPriceType(); }
        public bool IsSetLegBenchmarkPriceType() { return IsSetField(Tags.LegBenchmarkPriceType); }

        public class NoLegSecurityAltIDGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};

            public NoLegSecurityAltIDGroup()
              : base(Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegSecurityAltID LegSecurityAltID
            {
                get
                {
                    LegSecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityAltID val) { LegSecurityAltID = val; }
            public LegSecurityAltID Get(LegSecurityAltID val) { GetField(val); return val; }
            public bool IsSet(LegSecurityAltID val) { return IsSetLegSecurityAltID(); }
            public bool IsSetLegSecurityAltID() { return IsSetField(Tags.LegSecurityAltID); }

            public LegSecurityAltIDSource LegSecurityAltIDSource
            {
                get
                {
                    LegSecurityAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityAltIDSource val) { LegSecurityAltIDSource = val; }
            public LegSecurityAltIDSource Get(LegSecurityAltIDSource val) { GetField(val); return val; }
            public bool IsSet(LegSecurityAltIDSource val) { return IsSetLegSecurityAltIDSource(); }
            public bool IsSetLegSecurityAltIDSource() { return IsSetField(Tags.LegSecurityAltIDSource); }
        }

        public class NoLegEventsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegEventType, Tags.LegEventDate, Tags.LegEventTimeUnit, Tags.LegEventTimePeriod, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.LegEventType, Tags.LegEventDate, Tags.LegEventTimeUnit, Tags.LegEventTimePeriod, 0};

            public NoLegEventsGroup()
              : base(Tags.NoLegEvents, Tags.LegEventType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegEventsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegEventType LegEventType
            {
                get
                {
                    LegEventType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegEventType val) { LegEventType = val; }
            public LegEventType Get(LegEventType val) { GetField(val); return val; }
            public bool IsSet(LegEventType val) { return IsSetLegEventType(); }
            public bool IsSetLegEventType() { return IsSetField(Tags.LegEventType); }

            public LegEventDate LegEventDate
            {
                get
                {
                    LegEventDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegEventDate val) { LegEventDate = val; }
            public LegEventDate Get(LegEventDate val) { GetField(val); return val; }
            public bool IsSet(LegEventDate val) { return IsSetLegEventDate(); }
            public bool IsSetLegEventDate() { return IsSetField(Tags.LegEventDate); }

            public LegEventTimeUnit LegEventTimeUnit
            {
                get
                {
                    LegEventTimeUnit val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegEventTimeUnit val) { LegEventTimeUnit = val; }
            public LegEventTimeUnit Get(LegEventTimeUnit val) { GetField(val); return val; }
            public bool IsSet(LegEventTimeUnit val) { return IsSetLegEventTimeUnit(); }
            public bool IsSetLegEventTimeUnit() { return IsSetField(Tags.LegEventTimeUnit); }

            public LegEventTimePeriod LegEventTimePeriod
            {
                get
                {
                    LegEventTimePeriod val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegEventTimePeriod val) { LegEventTimePeriod = val; }
            public LegEventTimePeriod Get(LegEventTimePeriod val) { GetField(val); return val; }
            public bool IsSet(LegEventTimePeriod val) { return IsSetLegEventTimePeriod(); }
            public bool IsSetLegEventTimePeriod() { return IsSetField(Tags.LegEventTimePeriod); }
        }

        public class NoLegComplexEventsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegComplexEventType, Tags.LegComplexEventPrice, Tags.LegComplexEventPriceTimeType, Tags.LegComplexEventCondition, Tags.NoLegComplexEventDates, Tags.LegComplexRebate, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.LegComplexEventType, Tags.LegComplexEventPrice, Tags.LegComplexEventPriceTimeType, Tags.LegComplexEventCondition, Tags.NoLegComplexEventDates, Tags.LegComplexRebate, 0};

            public NoLegComplexEventsGroup()
              : base(Tags.NoLegComplexEvents, Tags.LegComplexEventType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegComplexEventsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegComplexEventType LegComplexEventType
            {
                get
                {
                    LegComplexEventType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegComplexEventType val) { LegComplexEventType = val; }
            public LegComplexEventType Get(LegComplexEventType val) { GetField(val); return val; }
            public bool IsSet(LegComplexEventType val) { return IsSetLegComplexEventType(); }
            public bool IsSetLegComplexEventType() { return IsSetField(Tags.LegComplexEventType); }

            public LegComplexEventPrice LegComplexEventPrice
            {
                get
                {
                    LegComplexEventPrice val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegComplexEventPrice val) { LegComplexEventPrice = val; }
            public LegComplexEventPrice Get(LegComplexEventPrice val) { GetField(val); return val; }
            public bool IsSet(LegComplexEventPrice val) { return IsSetLegComplexEventPrice(); }
            public bool IsSetLegComplexEventPrice() { return IsSetField(Tags.LegComplexEventPrice); }

            public LegComplexEventPriceTimeType LegComplexEventPriceTimeType
            {
                get
                {
                    LegComplexEventPriceTimeType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegComplexEventPriceTimeType val) { LegComplexEventPriceTimeType = val; }
            public LegComplexEventPriceTimeType Get(LegComplexEventPriceTimeType val) { GetField(val); return val; }
            public bool IsSet(LegComplexEventPriceTimeType val) { return IsSetLegComplexEventPriceTimeType(); }
            public bool IsSetLegComplexEventPriceTimeType() { return IsSetField(Tags.LegComplexEventPriceTimeType); }

            public LegComplexEventCondition LegComplexEventCondition
            {
                get
                {
                    LegComplexEventCondition val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegComplexEventCondition val) { LegComplexEventCondition = val; }
            public LegComplexEventCondition Get(LegComplexEventCondition val) { GetField(val); return val; }
            public bool IsSet(LegComplexEventCondition val) { return IsSetLegComplexEventCondition(); }
            public bool IsSetLegComplexEventCondition() { return IsSetField(Tags.LegComplexEventCondition); }

            public NoLegComplexEventDates NoLegComplexEventDates
            {
                get
                {
                    NoLegComplexEventDates val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoLegComplexEventDates val) { NoLegComplexEventDates = val; }
            public NoLegComplexEventDates Get(NoLegComplexEventDates val) { GetField(val); return val; }
            public bool IsSet(NoLegComplexEventDates val) { return IsSetNoLegComplexEventDates(); }
            public bool IsSetNoLegComplexEventDates() { return IsSetField(Tags.NoLegComplexEventDates); }

            public LegComplexRebate LegComplexRebate
            {
                get
                {
                    LegComplexRebate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegComplexRebate val) { LegComplexRebate = val; }
            public LegComplexRebate Get(LegComplexRebate val) { GetField(val); return val; }
            public bool IsSet(LegComplexRebate val) { return IsSetLegComplexRebate(); }
            public bool IsSetLegComplexRebate() { return IsSetField(Tags.LegComplexRebate); }

            public class NoLegComplexEventDatesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.LegComplexEventStartDate, Tags.LegComplexEventEndDate, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
                public static int[] fieldOrder = {Tags.LegComplexEventStartDate, Tags.LegComplexEventEndDate, 0};

                public NoLegComplexEventDatesGroup()
                  : base(Tags.NoLegComplexEventDates, Tags.LegComplexEventStartDate, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoLegComplexEventDatesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public LegComplexEventStartDate LegComplexEventStartDate
                {
                    get
                    {
                        LegComplexEventStartDate val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(LegComplexEventStartDate val) { LegComplexEventStartDate = val; }
                public LegComplexEventStartDate Get(LegComplexEventStartDate val) { GetField(val); return val; }
                public bool IsSet(LegComplexEventStartDate val) { return IsSetLegComplexEventStartDate(); }
                public bool IsSetLegComplexEventStartDate() { return IsSetField(Tags.LegComplexEventStartDate); }

                public LegComplexEventEndDate LegComplexEventEndDate
                {
                    get
                    {
                        LegComplexEventEndDate val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(LegComplexEventEndDate val) { LegComplexEventEndDate = val; }
                public LegComplexEventEndDate Get(LegComplexEventEndDate val) { GetField(val); return val; }
                public bool IsSet(LegComplexEventEndDate val) { return IsSetLegComplexEventEndDate(); }
                public bool IsSetLegComplexEventEndDate() { return IsSetField(Tags.LegComplexEventEndDate); }
            }
        }

        public class NoLegStreamsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegStreamType, Tags.LegStreamDesc, Tags.LegStreamPaySide, Tags.LegStreamReceiveSide, Tags.LegStreamEffectiveDateAdjusted, Tags.LegStreamTerminationDateAdjusted, Tags.LegStreamFirstRegularPeriodStartDateUnadjusted, Tags.LegStreamLastRegularPeriodEndDateUnadjusted, Tags.LegPaymentStreamType, Tags.LegPaymentStreamPaymentFrequencyPeriod, Tags.LegPaymentStreamPaymentFrequencyUnit, Tags.LegPaymentStreamResetFrequencyPeriod, Tags.LegPaymentStreamResetFrequencyUnit, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.LegStreamType, Tags.LegStreamDesc, Tags.LegStreamPaySide, Tags.LegStreamReceiveSide, Tags.LegStreamEffectiveDateAdjusted, Tags.LegStreamTerminationDateAdjusted, Tags.LegStreamFirstRegularPeriodStartDateUnadjusted, Tags.LegStreamLastRegularPeriodEndDateUnadjusted, Tags.LegPaymentStreamType, Tags.LegPaymentStreamPaymentFrequencyPeriod, Tags.LegPaymentStreamPaymentFrequencyUnit, Tags.LegPaymentStreamResetFrequencyPeriod, Tags.LegPaymentStreamResetFrequencyUnit, 0};

            public NoLegStreamsGroup()
              : base(Tags.NoLegStreams, Tags.LegStreamType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegStreamsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegStreamType LegStreamType
            {
                get
                {
                    LegStreamType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStreamType val) { LegStreamType = val; }
            public LegStreamType Get(LegStreamType val) { GetField(val); return val; }
            public bool IsSet(LegStreamType val) { return IsSetLegStreamType(); }
            public bool IsSetLegStreamType() { return IsSetField(Tags.LegStreamType); }

            public LegStreamDesc LegStreamDesc
            {
                get
                {
                    LegStreamDesc val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStreamDesc val) { LegStreamDesc = val; }
            public LegStreamDesc Get(LegStreamDesc val) { GetField(val); return val; }
            public bool IsSet(LegStreamDesc val) { return IsSetLegStreamDesc(); }
            public bool IsSetLegStreamDesc() { return IsSetField(Tags.LegStreamDesc); }

            public LegStreamPaySide LegStreamPaySide
            {
                get
                {
                    LegStreamPaySide val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStreamPaySide val) { LegStreamPaySide = val; }
            public LegStreamPaySide Get(LegStreamPaySide val) { GetField(val); return val; }
            public bool IsSet(LegStreamPaySide val) { return IsSetLegStreamPaySide(); }
            public bool IsSetLegStreamPaySide() { return IsSetField(Tags.LegStreamPaySide); }

            public LegStreamReceiveSide LegStreamReceiveSide
            {
                get
                {
                    LegStreamReceiveSide val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStreamReceiveSide val) { LegStreamReceiveSide = val; }
            public LegStreamReceiveSide Get(LegStreamReceiveSide val) { GetField(val); return val; }
            public bool IsSet(LegStreamReceiveSide val) { return IsSetLegStreamReceiveSide(); }
            public bool IsSetLegStreamReceiveSide() { return IsSetField(Tags.LegStreamReceiveSide); }

            public LegStreamEffectiveDateAdjusted LegStreamEffectiveDateAdjusted
            {
                get
                {
                    LegStreamEffectiveDateAdjusted val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStreamEffectiveDateAdjusted val) { LegStreamEffectiveDateAdjusted = val; }
            public LegStreamEffectiveDateAdjusted Get(LegStreamEffectiveDateAdjusted val) { GetField(val); return val; }
            public bool IsSet(LegStreamEffectiveDateAdjusted val) { return IsSetLegStreamEffectiveDateAdjusted(); }
            public bool IsSetLegStreamEffectiveDateAdjusted() { return IsSetField(Tags.LegStreamEffectiveDateAdjusted); }

            public LegStreamTerminationDateAdjusted LegStreamTerminationDateAdjusted
            {
                get
                {
                    LegStreamTerminationDateAdjusted val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStreamTerminationDateAdjusted val) { LegStreamTerminationDateAdjusted = val; }
            public LegStreamTerminationDateAdjusted Get(LegStreamTerminationDateAdjusted val) { GetField(val); return val; }
            public bool IsSet(LegStreamTerminationDateAdjusted val) { return IsSetLegStreamTerminationDateAdjusted(); }
            public bool IsSetLegStreamTerminationDateAdjusted() { return IsSetField(Tags.LegStreamTerminationDateAdjusted); }

            public LegStreamFirstRegularPeriodStartDateUnadjusted LegStreamFirstRegularPeriodStartDateUnadjusted
            {
                get
                {
                    LegStreamFirstRegularPeriodStartDateUnadjusted val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStreamFirstRegularPeriodStartDateUnadjusted val) { LegStreamFirstRegularPeriodStartDateUnadjusted = val; }
            public LegStreamFirstRegularPeriodStartDateUnadjusted Get(LegStreamFirstRegularPeriodStartDateUnadjusted val) { GetField(val); return val; }
            public bool IsSet(LegStreamFirstRegularPeriodStartDateUnadjusted val) { return IsSetLegStreamFirstRegularPeriodStartDateUnadjusted(); }
            public bool IsSetLegStreamFirstRegularPeriodStartDateUnadjusted() { return IsSetField(Tags.LegStreamFirstRegularPeriodStartDateUnadjusted); }

            public LegStreamLastRegularPeriodEndDateUnadjusted LegStreamLastRegularPeriodEndDateUnadjusted
            {
                get
                {
                    LegStreamLastRegularPeriodEndDateUnadjusted val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStreamLastRegularPeriodEndDateUnadjusted val) { LegStreamLastRegularPeriodEndDateUnadjusted = val; }
            public LegStreamLastRegularPeriodEndDateUnadjusted Get(LegStreamLastRegularPeriodEndDateUnadjusted val) { GetField(val); return val; }
            public bool IsSet(LegStreamLastRegularPeriodEndDateUnadjusted val) { return IsSetLegStreamLastRegularPeriodEndDateUnadjusted(); }
            public bool IsSetLegStreamLastRegularPeriodEndDateUnadjusted() { return IsSetField(Tags.LegStreamLastRegularPeriodEndDateUnadjusted); }

            public LegPaymentStreamType LegPaymentStreamType
            {
                get
                {
                    LegPaymentStreamType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPaymentStreamType val) { LegPaymentStreamType = val; }
            public LegPaymentStreamType Get(LegPaymentStreamType val) { GetField(val); return val; }
            public bool IsSet(LegPaymentStreamType val) { return IsSetLegPaymentStreamType(); }
            public bool IsSetLegPaymentStreamType() { return IsSetField(Tags.LegPaymentStreamType); }

            public LegPaymentStreamPaymentFrequencyPeriod LegPaymentStreamPaymentFrequencyPeriod
            {
                get
                {
                    LegPaymentStreamPaymentFrequencyPeriod val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPaymentStreamPaymentFrequencyPeriod val) { LegPaymentStreamPaymentFrequencyPeriod = val; }
            public LegPaymentStreamPaymentFrequencyPeriod Get(LegPaymentStreamPaymentFrequencyPeriod val) { GetField(val); return val; }
            public bool IsSet(LegPaymentStreamPaymentFrequencyPeriod val) { return IsSetLegPaymentStreamPaymentFrequencyPeriod(); }
            public bool IsSetLegPaymentStreamPaymentFrequencyPeriod() { return IsSetField(Tags.LegPaymentStreamPaymentFrequencyPeriod); }

            public LegPaymentStreamPaymentFrequencyUnit LegPaymentStreamPaymentFrequencyUnit
            {
                get
                {
                    LegPaymentStreamPaymentFrequencyUnit val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPaymentStreamPaymentFrequencyUnit val) { LegPaymentStreamPaymentFrequencyUnit = val; }
            public LegPaymentStreamPaymentFrequencyUnit Get(LegPaymentStreamPaymentFrequencyUnit val) { GetField(val); return val; }
            public bool IsSet(LegPaymentStreamPaymentFrequencyUnit val) { return IsSetLegPaymentStreamPaymentFrequencyUnit(); }
            public bool IsSetLegPaymentStreamPaymentFrequencyUnit() { return IsSetField(Tags.LegPaymentStreamPaymentFrequencyUnit); }

            public LegPaymentStreamResetFrequencyPeriod LegPaymentStreamResetFrequencyPeriod
            {
                get
                {
                    LegPaymentStreamResetFrequencyPeriod val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPaymentStreamResetFrequencyPeriod val) { LegPaymentStreamResetFrequencyPeriod = val; }
            public LegPaymentStreamResetFrequencyPeriod Get(LegPaymentStreamResetFrequencyPeriod val) { GetField(val); return val; }
            public bool IsSet(LegPaymentStreamResetFrequencyPeriod val) { return IsSetLegPaymentStreamResetFrequencyPeriod(); }
            public bool IsSetLegPaymentStreamResetFrequencyPeriod() { return IsSetField(Tags.LegPaymentStreamResetFrequencyPeriod); }

            public LegPaymentStreamResetFrequencyUnit LegPaymentStreamResetFrequencyUnit
            {
                get
                {
                    LegPaymentStreamResetFrequencyUnit val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPaymentStreamResetFrequencyUnit val) { LegPaymentStreamResetFrequencyUnit = val; }
            public LegPaymentStreamResetFrequencyUnit Get(LegPaymentStreamResetFrequencyUnit val) { GetField(val); return val; }
            public bool IsSet(LegPaymentStreamResetFrequencyUnit val) { return IsSetLegPaymentStreamResetFrequencyUnit(); }
            public bool IsSetLegPaymentStreamResetFrequencyUnit() { return IsSetField(Tags.LegPaymentStreamResetFrequencyUnit); }
        }

        public class NoLegStipulationsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegStipulationType, Tags.LegStipulationValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.LegStipulationType, Tags.LegStipulationValue, 0};

            public NoLegStipulationsGroup()
              : base(Tags.NoLegStipulations, Tags.LegStipulationType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegStipulationsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegStipulationType LegStipulationType
            {
                get
                {
                    LegStipulationType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStipulationType val) { LegStipulationType = val; }
            public LegStipulationType Get(LegStipulationType val) { GetField(val); return val; }
            public bool IsSet(LegStipulationType val) { return IsSetLegStipulationType(); }
            public bool IsSetLegStipulationType() { return IsSetField(Tags.LegStipulationType); }

            public LegStipulationValue LegStipulationValue
            {
                get
                {
                    LegStipulationValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStipulationValue val) { LegStipulationValue = val; }
            public LegStipulationValue Get(LegStipulationValue val) { GetField(val); return val; }
            public bool IsSet(LegStipulationValue val) { return IsSetLegStipulationValue(); }
            public bool IsSetLegStipulationValue() { return IsSetField(Tags.LegStipulationValue); }
        }

        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NestedPartyRoleQualifier, Tags.NoNestedPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NestedPartyRoleQualifier, Tags.NoNestedPartySubIDs, 0};

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

            public NestedPartyRoleQualifier NestedPartyRoleQualifier
            {
                get
                {
                    NestedPartyRoleQualifier val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyRoleQualifier val) { NestedPartyRoleQualifier = val; }
            public NestedPartyRoleQualifier Get(NestedPartyRoleQualifier val) { GetField(val); return val; }
            public bool IsSet(NestedPartyRoleQualifier val) { return IsSetNestedPartyRoleQualifier(); }
            public bool IsSetNestedPartyRoleQualifier() { return IsSetField(Tags.NestedPartyRoleQualifier); }

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
}
