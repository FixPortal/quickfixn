// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class NewOrderList : Message
{
    public const string MsgType = "E";

    public NewOrderList() : base()
    {
        Header.SetField(new MsgType("E"));
    }

    public NewOrderList(
            ListID aListID,
            BidType aBidType,
            TotNoOrders aTotNoOrders
        ) : this()
    {
        ListID = aListID;
        BidType = aBidType;
        TotNoOrders = aTotNoOrders;
    }

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

    public BidType BidType
    {
        get
        {
            BidType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidType val) { BidType = val; }
    public BidType Get(BidType val) { GetField(val); return val; }
    public bool IsSet(BidType val) { return IsSetBidType(); }
    public bool IsSetBidType() { return IsSetField(Tags.BidType); }

    public ListExecInst ListExecInst
    {
        get
        {
            ListExecInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListExecInst val) { ListExecInst = val; }
    public ListExecInst Get(ListExecInst val) { GetField(val); return val; }
    public bool IsSet(ListExecInst val) { return IsSetListExecInst(); }
    public bool IsSetListExecInst() { return IsSetField(Tags.ListExecInst); }

    public TotNoOrders TotNoOrders
    {
        get
        {
            TotNoOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNoOrders val) { TotNoOrders = val; }
    public TotNoOrders Get(TotNoOrders val) { GetField(val); return val; }
    public bool IsSet(TotNoOrders val) { return IsSetTotNoOrders(); }
    public bool IsSetTotNoOrders() { return IsSetField(Tags.TotNoOrders); }

    public LastFragment LastFragment
    {
        get
        {
            LastFragment val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastFragment val) { LastFragment = val; }
    public LastFragment Get(LastFragment val) { GetField(val); return val; }
    public bool IsSet(LastFragment val) { return IsSetLastFragment(); }
    public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }

    public NoOrders NoOrders
    {
        get
        {
            NoOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoOrders val) { NoOrders = val; }
    public NoOrders Get(NoOrders val) { GetField(val); return val; }
    public bool IsSet(NoOrders val) { return IsSetNoOrders(); }
    public bool IsSetNoOrders() { return IsSetField(Tags.NoOrders); }

    public ListName ListName
    {
        get
        {
            ListName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListName val) { ListName = val; }
    public ListName Get(ListName val) { GetField(val); return val; }
    public bool IsSet(ListName val) { return IsSetListName(); }
    public bool IsSetListName() { return IsSetField(Tags.ListName); }

    public StrikeTime StrikeTime
    {
        get
        {
            StrikeTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeTime val) { StrikeTime = val; }
    public StrikeTime Get(StrikeTime val) { GetField(val); return val; }
    public bool IsSet(StrikeTime val) { return IsSetStrikeTime(); }
    public bool IsSetStrikeTime() { return IsSetField(Tags.StrikeTime); }

    public SpottingProcess SpottingProcess
    {
        get
        {
            SpottingProcess val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SpottingProcess val) { SpottingProcess = val; }
    public SpottingProcess Get(SpottingProcess val) { GetField(val); return val; }
    public bool IsSet(SpottingProcess val) { return IsSetSpottingProcess(); }
    public bool IsSetSpottingProcess() { return IsSetField(Tags.SpottingProcess); }

    public ValidSeconds ValidSeconds
    {
        get
        {
            ValidSeconds val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ValidSeconds val) { ValidSeconds = val; }
    public ValidSeconds Get(ValidSeconds val) { GetField(val); return val; }
    public bool IsSet(ValidSeconds val) { return IsSetValidSeconds(); }
    public bool IsSetValidSeconds() { return IsSetField(Tags.ValidSeconds); }

    public DueInSeconds DueInSeconds
    {
        get
        {
            DueInSeconds val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DueInSeconds val) { DueInSeconds = val; }
    public DueInSeconds Get(DueInSeconds val) { GetField(val); return val; }
    public bool IsSet(DueInSeconds val) { return IsSetDueInSeconds(); }
    public bool IsSetDueInSeconds() { return IsSetField(Tags.DueInSeconds); }

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

    public AutoConfirm AutoConfirm
    {
        get
        {
            AutoConfirm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AutoConfirm val) { AutoConfirm = val; }
    public AutoConfirm Get(AutoConfirm val) { GetField(val); return val; }
    public bool IsSet(AutoConfirm val) { return IsSetAutoConfirm(); }
    public bool IsSetAutoConfirm() { return IsSetField(Tags.AutoConfirm); }

    public class NoOrdersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClOrdID, Tags.ListSeqNo, Tags.NoPartyIDs, Tags.TradeDate, Tags.LocateBroker, Tags.LocateIdentifier, Tags.Account, Tags.AcctIDSource, Tags.AllocID, Tags.NoAllocs, Tags.SettlType, Tags.SettlDate, Tags.HandlInst, Tags.ExDestination, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.MaturityDate, Tags.RestructuringType, Tags.Seniority, Tags.AttachmentPoint, Tags.DetachmentPoint, Tags.AssetClass, Tags.AssetSubClass, Tags.AssetType, Tags.CouponType, Tags.CouponFrequencyPeriod, Tags.CouponFrequencyUnit, Tags.CouponDayCount, Tags.ConvertibleBondEquityID, Tags.ConvertibleBondEquityIDSource, Tags.IndexSeries, Tags.IndexAnnexVersion, Tags.IndexAnnexDate, Tags.IndexAnnexSource, Tags.IssueDate, Tags.Factor, Tags.CreditRating, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.StrikePrice, Tags.StrikeCurrency, Tags.StrikePriceBoundaryMethod, Tags.UnderlyingPriceDeterminationMethod, Tags.OptAttribute, Tags.ContractMultiplier, Tags.SettlMethod, Tags.ExerciseStyle, Tags.PutOrCall, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.NoInstrumentParties, Tags.NoComplexEvents, Tags.StrategyType, Tags.BusinessDayConvention, Tags.DateRollConvention, Tags.OptionExerciseLatestTime, Tags.OptionExerciseTimeBusinessCenter, Tags.OptionExerciseDeliveryDate, Tags.NoOptionExerciseExpirationDates, Tags.NoStreams, Tags.StrategyPosition, Tags.PutOrCallCurrency, Tags.CreditRatingSource, Tags.CouponDateGenerationMethod, Tags.CustomizedIndicator, Tags.OptionSettlAmtDeterminationMethod, Tags.ConvertibleBondEquityCurrency, Tags.OfferingSize, Tags.CountryOfJurisdiction, Tags.CurrencyOfIssue, Tags.AgreementDesc, Tags.AgreementID, Tags.AgreementDate, Tags.NoContractualDefinitions, Tags.NoContractualMatrices, Tags.TerminationType, Tags.StartDate, Tags.EndDate, Tags.DeliveryType, Tags.MarginRatio, Tags.DaysToTerm, Tags.NoUnderlyings, Tags.Side, Tags.LocateReqd, Tags.TransactTime, Tags.NoStipulations, Tags.QtyType, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderQtyUnits, Tags.ConstantQtyType, Tags.OrdType, Tags.PriceType, Tags.Price, Tags.StopPx, Tags.Spread, Tags.BenchmarkCurveCurrency, Tags.BenchmarkCurveName, Tags.BenchmarkCurvePoint, Tags.BenchmarkPrice, Tags.BenchmarkPriceType, Tags.BenchmarkSecurityID, Tags.BenchmarkSecurityIDSource, Tags.BenchmarkYield, Tags.BenchmarkSecurityDesc, Tags.BenchmarkSecurityType, Tags.Currency, Tags.TimeInForce, Tags.ExpireDate, Tags.ExpireTime, Tags.OrderCapacity, Tags.SettlCurrency, Tags.Text, Tags.PositionEffect, Tags.NoStrategyParameters, Tags.Rule80A, Tags.NumDaysInterest, Tags.CustomerOrFirm, Tags.TrdType, Tags.TrdSubType, Tags.SecondaryTrdType, Tags.MarketSegmentID, Tags.TradeContinuation, Tags.ExDestinationType, Tags.CrossIndicator, Tags.Tenor, Tags.ApplyRestriction, Tags.Ccy1MarketType, Tags.Ccy2MarketType, Tags.AutoOrdType, Tags.NoOrderAttributes, Tags.NoExecRuleNames, Tags.NoNotes, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.ClOrdID, Tags.ListSeqNo, Tags.NoPartyIDs, Tags.TradeDate, Tags.LocateBroker, Tags.LocateIdentifier, Tags.Account, Tags.AcctIDSource, Tags.AllocID, Tags.NoAllocs, Tags.SettlType, Tags.SettlDate, Tags.HandlInst, Tags.ExDestination, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.MaturityDate, Tags.RestructuringType, Tags.Seniority, Tags.AttachmentPoint, Tags.DetachmentPoint, Tags.AssetClass, Tags.AssetSubClass, Tags.AssetType, Tags.CouponType, Tags.CouponFrequencyPeriod, Tags.CouponFrequencyUnit, Tags.CouponDayCount, Tags.ConvertibleBondEquityID, Tags.ConvertibleBondEquityIDSource, Tags.IndexSeries, Tags.IndexAnnexVersion, Tags.IndexAnnexDate, Tags.IndexAnnexSource, Tags.IssueDate, Tags.Factor, Tags.CreditRating, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.StrikePrice, Tags.StrikeCurrency, Tags.StrikePriceBoundaryMethod, Tags.UnderlyingPriceDeterminationMethod, Tags.OptAttribute, Tags.ContractMultiplier, Tags.SettlMethod, Tags.ExerciseStyle, Tags.PutOrCall, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.NoInstrumentParties, Tags.NoComplexEvents, Tags.StrategyType, Tags.BusinessDayConvention, Tags.DateRollConvention, Tags.OptionExerciseLatestTime, Tags.OptionExerciseTimeBusinessCenter, Tags.OptionExerciseDeliveryDate, Tags.NoOptionExerciseExpirationDates, Tags.NoStreams, Tags.StrategyPosition, Tags.PutOrCallCurrency, Tags.CreditRatingSource, Tags.CouponDateGenerationMethod, Tags.CustomizedIndicator, Tags.OptionSettlAmtDeterminationMethod, Tags.ConvertibleBondEquityCurrency, Tags.OfferingSize, Tags.CountryOfJurisdiction, Tags.CurrencyOfIssue, Tags.AgreementDesc, Tags.AgreementID, Tags.AgreementDate, Tags.NoContractualDefinitions, Tags.NoContractualMatrices, Tags.TerminationType, Tags.StartDate, Tags.EndDate, Tags.DeliveryType, Tags.MarginRatio, Tags.DaysToTerm, Tags.NoUnderlyings, Tags.Side, Tags.LocateReqd, Tags.TransactTime, Tags.NoStipulations, Tags.QtyType, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderQtyUnits, Tags.ConstantQtyType, Tags.OrdType, Tags.PriceType, Tags.Price, Tags.StopPx, Tags.Spread, Tags.BenchmarkCurveCurrency, Tags.BenchmarkCurveName, Tags.BenchmarkCurvePoint, Tags.BenchmarkPrice, Tags.BenchmarkPriceType, Tags.BenchmarkSecurityID, Tags.BenchmarkSecurityIDSource, Tags.BenchmarkYield, Tags.BenchmarkSecurityDesc, Tags.BenchmarkSecurityType, Tags.Currency, Tags.TimeInForce, Tags.ExpireDate, Tags.ExpireTime, Tags.OrderCapacity, Tags.SettlCurrency, Tags.Text, Tags.PositionEffect, Tags.NoStrategyParameters, Tags.Rule80A, Tags.NumDaysInterest, Tags.CustomerOrFirm, Tags.TrdType, Tags.TrdSubType, Tags.SecondaryTrdType, Tags.MarketSegmentID, Tags.TradeContinuation, Tags.ExDestinationType, Tags.CrossIndicator, Tags.Tenor, Tags.ApplyRestriction, Tags.Ccy1MarketType, Tags.Ccy2MarketType, Tags.AutoOrdType, Tags.NoOrderAttributes, Tags.NoExecRuleNames, Tags.NoNotes, 0};

        public NoOrdersGroup()
          : base(Tags.NoOrders, Tags.ClOrdID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoOrdersGroup();
            clone.CopyStateFrom(this);
            return clone;
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

        public ListSeqNo ListSeqNo
        {
            get
            {
                ListSeqNo val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ListSeqNo val) { ListSeqNo = val; }
        public ListSeqNo Get(ListSeqNo val) { GetField(val); return val; }
        public bool IsSet(ListSeqNo val) { return IsSetListSeqNo(); }
        public bool IsSetListSeqNo() { return IsSetField(Tags.ListSeqNo); }

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

        public CrossIndicator CrossIndicator
        {
            get
            {
                CrossIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CrossIndicator val) { CrossIndicator = val; }
        public CrossIndicator Get(CrossIndicator val) { GetField(val); return val; }
        public bool IsSet(CrossIndicator val) { return IsSetCrossIndicator(); }
        public bool IsSetCrossIndicator() { return IsSetField(Tags.CrossIndicator); }

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

        public class NoAllocsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, Tags.AllocText, Tags.AllocAgreementDesc, Tags.AllocAgreementDate, Tags.AllocCalcAgentLocation, Tags.AllocMatrixAgreementType, Tags.AllocMCAAnnexDate, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, Tags.AllocText, Tags.AllocAgreementDesc, Tags.AllocAgreementDate, Tags.AllocCalcAgentLocation, Tags.AllocMatrixAgreementType, Tags.AllocMCAAnnexDate, 0};

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

            public AllocText AllocText
            {
                get
                {
                    AllocText val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocText val) { AllocText = val; }
            public AllocText Get(AllocText val) { GetField(val); return val; }
            public bool IsSet(AllocText val) { return IsSetAllocText(); }
            public bool IsSetAllocText() { return IsSetField(Tags.AllocText); }

            public AllocAgreementDesc AllocAgreementDesc
            {
                get
                {
                    AllocAgreementDesc val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocAgreementDesc val) { AllocAgreementDesc = val; }
            public AllocAgreementDesc Get(AllocAgreementDesc val) { GetField(val); return val; }
            public bool IsSet(AllocAgreementDesc val) { return IsSetAllocAgreementDesc(); }
            public bool IsSetAllocAgreementDesc() { return IsSetField(Tags.AllocAgreementDesc); }

            public AllocAgreementDate AllocAgreementDate
            {
                get
                {
                    AllocAgreementDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocAgreementDate val) { AllocAgreementDate = val; }
            public AllocAgreementDate Get(AllocAgreementDate val) { GetField(val); return val; }
            public bool IsSet(AllocAgreementDate val) { return IsSetAllocAgreementDate(); }
            public bool IsSetAllocAgreementDate() { return IsSetField(Tags.AllocAgreementDate); }

            public AllocCalcAgentLocation AllocCalcAgentLocation
            {
                get
                {
                    AllocCalcAgentLocation val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocCalcAgentLocation val) { AllocCalcAgentLocation = val; }
            public AllocCalcAgentLocation Get(AllocCalcAgentLocation val) { GetField(val); return val; }
            public bool IsSet(AllocCalcAgentLocation val) { return IsSetAllocCalcAgentLocation(); }
            public bool IsSetAllocCalcAgentLocation() { return IsSetField(Tags.AllocCalcAgentLocation); }

            public AllocMatrixAgreementType AllocMatrixAgreementType
            {
                get
                {
                    AllocMatrixAgreementType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocMatrixAgreementType val) { AllocMatrixAgreementType = val; }
            public AllocMatrixAgreementType Get(AllocMatrixAgreementType val) { GetField(val); return val; }
            public bool IsSet(AllocMatrixAgreementType val) { return IsSetAllocMatrixAgreementType(); }
            public bool IsSetAllocMatrixAgreementType() { return IsSetField(Tags.AllocMatrixAgreementType); }

            public AllocMCAAnnexDate AllocMCAAnnexDate
            {
                get
                {
                    AllocMCAAnnexDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocMCAAnnexDate val) { AllocMCAAnnexDate = val; }
            public AllocMCAAnnexDate Get(AllocMCAAnnexDate val) { GetField(val); return val; }
            public bool IsSet(AllocMCAAnnexDate val) { return IsSetAllocMCAAnnexDate(); }
            public bool IsSetAllocMCAAnnexDate() { return IsSetField(Tags.AllocMCAAnnexDate); }

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
            public static int[] DefaultFieldOrder = [Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityDate, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingIssueDate, Tags.UnderlyingFactor, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.NoUnderlyingStips, Tags.NoUndlyInstrumentParties, Tags.UnderlyingCouponFrequencyPeriod, Tags.UnderlyingCouponFrequencyUnit, Tags.UnderlyingCouponDayCount, Tags.UnderlyingObligationID, Tags.UnderlyingObligationIDSource, Tags.NoUnderlyingEvents, Tags.UnderlyingIndexSeries, Tags.UnderlyingIndexAnnexVersion, Tags.UnderlyingIndexAnnexDate, Tags.UnderlyingIndexAnnexSource, Tags.UnderlyingAssetClass, Tags.UnderlyingAssetSubClass, Tags.NoUnderlyingStreams, Tags.UnderlyingStartAcrdIntAmt, Tags.UnderlyingEndAcrdIntAmt, Tags.UnderlyingPriceType, Tags.UnderlyingCouponDateGenerationMethod, Tags.UnderlyingIndexCurvePeriod, Tags.UnderlyingIndexCurveUnit, Tags.NoUnderlyingReinvCoupon, Tags.UnderlyingSecuritySeries, Tags.UnderlyingTenor, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityDate, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingIssueDate, Tags.UnderlyingFactor, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.NoUnderlyingStips, Tags.NoUndlyInstrumentParties, Tags.UnderlyingCouponFrequencyPeriod, Tags.UnderlyingCouponFrequencyUnit, Tags.UnderlyingCouponDayCount, Tags.UnderlyingObligationID, Tags.UnderlyingObligationIDSource, Tags.NoUnderlyingEvents, Tags.UnderlyingIndexSeries, Tags.UnderlyingIndexAnnexVersion, Tags.UnderlyingIndexAnnexDate, Tags.UnderlyingIndexAnnexSource, Tags.UnderlyingAssetClass, Tags.UnderlyingAssetSubClass, Tags.NoUnderlyingStreams, Tags.UnderlyingStartAcrdIntAmt, Tags.UnderlyingEndAcrdIntAmt, Tags.UnderlyingPriceType, Tags.UnderlyingCouponDateGenerationMethod, Tags.UnderlyingIndexCurvePeriod, Tags.UnderlyingIndexCurveUnit, Tags.NoUnderlyingReinvCoupon, Tags.UnderlyingSecuritySeries, Tags.UnderlyingTenor, 0};

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

            public UnderlyingTenor UnderlyingTenor
            {
                get
                {
                    UnderlyingTenor val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingTenor val) { UnderlyingTenor = val; }
            public UnderlyingTenor Get(UnderlyingTenor val) { GetField(val); return val; }
            public bool IsSet(UnderlyingTenor val) { return IsSetUnderlyingTenor(); }
            public bool IsSetUnderlyingTenor() { return IsSetField(Tags.UnderlyingTenor); }

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
}
