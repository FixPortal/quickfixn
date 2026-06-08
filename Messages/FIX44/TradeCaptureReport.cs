// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class TradeCaptureReport : Message
{
    public const string MsgType = "AE";

    public TradeCaptureReport() : base()
    {
        Header.SetField(new MsgType("AE"));
    }

    public TradeCaptureReport(
            TradeReportID aTradeReportID,
            PreviouslyReported aPreviouslyReported,
            Symbol aSymbol,
            LastQty aLastQty,
            LastPx aLastPx,
            TradeDate aTradeDate,
            TransactTime aTransactTime
        ) : this()
    {
        TradeReportID = aTradeReportID;
        PreviouslyReported = aPreviouslyReported;
        Symbol = aSymbol;
        LastQty = aLastQty;
        LastPx = aLastPx;
        TradeDate = aTradeDate;
        TransactTime = aTransactTime;
    }

    public TradeReportID TradeReportID
    {
        get
        {
            TradeReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportID val) { TradeReportID = val; }
    public TradeReportID Get(TradeReportID val) { GetField(val); return val; }
    public bool IsSet(TradeReportID val) { return IsSetTradeReportID(); }
    public bool IsSetTradeReportID() { return IsSetField(Tags.TradeReportID); }

    public PackageID PackageID
    {
        get
        {
            PackageID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PackageID val) { PackageID = val; }
    public PackageID Get(PackageID val) { GetField(val); return val; }
    public bool IsSet(PackageID val) { return IsSetPackageID(); }
    public bool IsSetPackageID() { return IsSetField(Tags.PackageID); }

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

    public TradeID TradeID
    {
        get
        {
            TradeID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeID val) { TradeID = val; }
    public TradeID Get(TradeID val) { GetField(val); return val; }
    public bool IsSet(TradeID val) { return IsSetTradeID(); }
    public bool IsSetTradeID() { return IsSetField(Tags.TradeID); }

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

    public TradeReportTransType TradeReportTransType
    {
        get
        {
            TradeReportTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportTransType val) { TradeReportTransType = val; }
    public TradeReportTransType Get(TradeReportTransType val) { GetField(val); return val; }
    public bool IsSet(TradeReportTransType val) { return IsSetTradeReportTransType(); }
    public bool IsSetTradeReportTransType() { return IsSetField(Tags.TradeReportTransType); }

    public TradeReportType TradeReportType
    {
        get
        {
            TradeReportType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportType val) { TradeReportType = val; }
    public TradeReportType Get(TradeReportType val) { GetField(val); return val; }
    public bool IsSet(TradeReportType val) { return IsSetTradeReportType(); }
    public bool IsSetTradeReportType() { return IsSetField(Tags.TradeReportType); }

    public TradeRequestID TradeRequestID
    {
        get
        {
            TradeRequestID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeRequestID val) { TradeRequestID = val; }
    public TradeRequestID Get(TradeRequestID val) { GetField(val); return val; }
    public bool IsSet(TradeRequestID val) { return IsSetTradeRequestID(); }
    public bool IsSetTradeRequestID() { return IsSetField(Tags.TradeRequestID); }

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

    public TransferReason TransferReason
    {
        get
        {
            TransferReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransferReason val) { TransferReason = val; }
    public TransferReason Get(TransferReason val) { GetField(val); return val; }
    public bool IsSet(TransferReason val) { return IsSetTransferReason(); }
    public bool IsSetTransferReason() { return IsSetField(Tags.TransferReason); }

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

    public TotNumTradeReports TotNumTradeReports
    {
        get
        {
            TotNumTradeReports val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNumTradeReports val) { TotNumTradeReports = val; }
    public TotNumTradeReports Get(TotNumTradeReports val) { GetField(val); return val; }
    public bool IsSet(TotNumTradeReports val) { return IsSetTotNumTradeReports(); }
    public bool IsSetTotNumTradeReports() { return IsSetField(Tags.TotNumTradeReports); }

    public LastRptRequested LastRptRequested
    {
        get
        {
            LastRptRequested val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastRptRequested val) { LastRptRequested = val; }
    public LastRptRequested Get(LastRptRequested val) { GetField(val); return val; }
    public bool IsSet(LastRptRequested val) { return IsSetLastRptRequested(); }
    public bool IsSetLastRptRequested() { return IsSetField(Tags.LastRptRequested); }

    public UnsolicitedIndicator UnsolicitedIndicator
    {
        get
        {
            UnsolicitedIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnsolicitedIndicator val) { UnsolicitedIndicator = val; }
    public UnsolicitedIndicator Get(UnsolicitedIndicator val) { GetField(val); return val; }
    public bool IsSet(UnsolicitedIndicator val) { return IsSetUnsolicitedIndicator(); }
    public bool IsSetUnsolicitedIndicator() { return IsSetField(Tags.UnsolicitedIndicator); }

    public SubscriptionRequestType SubscriptionRequestType
    {
        get
        {
            SubscriptionRequestType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SubscriptionRequestType val) { SubscriptionRequestType = val; }
    public SubscriptionRequestType Get(SubscriptionRequestType val) { GetField(val); return val; }
    public bool IsSet(SubscriptionRequestType val) { return IsSetSubscriptionRequestType(); }
    public bool IsSetSubscriptionRequestType() { return IsSetField(Tags.SubscriptionRequestType); }

    public TradeReportRefID TradeReportRefID
    {
        get
        {
            TradeReportRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportRefID val) { TradeReportRefID = val; }
    public TradeReportRefID Get(TradeReportRefID val) { GetField(val); return val; }
    public bool IsSet(TradeReportRefID val) { return IsSetTradeReportRefID(); }
    public bool IsSetTradeReportRefID() { return IsSetField(Tags.TradeReportRefID); }

    public SecondaryTradeReportRefID SecondaryTradeReportRefID
    {
        get
        {
            SecondaryTradeReportRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryTradeReportRefID val) { SecondaryTradeReportRefID = val; }
    public SecondaryTradeReportRefID Get(SecondaryTradeReportRefID val) { GetField(val); return val; }
    public bool IsSet(SecondaryTradeReportRefID val) { return IsSetSecondaryTradeReportRefID(); }
    public bool IsSetSecondaryTradeReportRefID() { return IsSetField(Tags.SecondaryTradeReportRefID); }

    public SecondaryTradeReportID SecondaryTradeReportID
    {
        get
        {
            SecondaryTradeReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryTradeReportID val) { SecondaryTradeReportID = val; }
    public SecondaryTradeReportID Get(SecondaryTradeReportID val) { GetField(val); return val; }
    public bool IsSet(SecondaryTradeReportID val) { return IsSetSecondaryTradeReportID(); }
    public bool IsSetSecondaryTradeReportID() { return IsSetField(Tags.SecondaryTradeReportID); }

    public TradeLinkID TradeLinkID
    {
        get
        {
            TradeLinkID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeLinkID val) { TradeLinkID = val; }
    public TradeLinkID Get(TradeLinkID val) { GetField(val); return val; }
    public bool IsSet(TradeLinkID val) { return IsSetTradeLinkID(); }
    public bool IsSetTradeLinkID() { return IsSetField(Tags.TradeLinkID); }

    public TrdMatchID TrdMatchID
    {
        get
        {
            TrdMatchID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TrdMatchID val) { TrdMatchID = val; }
    public TrdMatchID Get(TrdMatchID val) { GetField(val); return val; }
    public bool IsSet(TrdMatchID val) { return IsSetTrdMatchID(); }
    public bool IsSetTrdMatchID() { return IsSetField(Tags.TrdMatchID); }

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

    public PreviouslyReported PreviouslyReported
    {
        get
        {
            PreviouslyReported val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PreviouslyReported val) { PreviouslyReported = val; }
    public PreviouslyReported Get(PreviouslyReported val) { GetField(val); return val; }
    public bool IsSet(PreviouslyReported val) { return IsSetPreviouslyReported(); }
    public bool IsSetPreviouslyReported() { return IsSetField(Tags.PreviouslyReported); }

    public BLPTicketType BLPTicketType
    {
        get
        {
            BLPTicketType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BLPTicketType val) { BLPTicketType = val; }
    public BLPTicketType Get(BLPTicketType val) { GetField(val); return val; }
    public bool IsSet(BLPTicketType val) { return IsSetBLPTicketType(); }
    public bool IsSetBLPTicketType() { return IsSetField(Tags.BLPTicketType); }

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

    public SettlFixingDate SettlFixingDate
    {
        get
        {
            SettlFixingDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlFixingDate val) { SettlFixingDate = val; }
    public SettlFixingDate Get(SettlFixingDate val) { GetField(val); return val; }
    public bool IsSet(SettlFixingDate val) { return IsSetSettlFixingDate(); }
    public bool IsSetSettlFixingDate() { return IsSetField(Tags.SettlFixingDate); }

    public SettlCurrency2 SettlCurrency2
    {
        get
        {
            SettlCurrency2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrency2 val) { SettlCurrency2 = val; }
    public SettlCurrency2 Get(SettlCurrency2 val) { GetField(val); return val; }
    public bool IsSet(SettlCurrency2 val) { return IsSetSettlCurrency2(); }
    public bool IsSetSettlCurrency2() { return IsSetField(Tags.SettlCurrency2); }

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

    public UnderlyingTradingSessionID UnderlyingTradingSessionID
    {
        get
        {
            UnderlyingTradingSessionID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingTradingSessionID val) { UnderlyingTradingSessionID = val; }
    public UnderlyingTradingSessionID Get(UnderlyingTradingSessionID val) { GetField(val); return val; }
    public bool IsSet(UnderlyingTradingSessionID val) { return IsSetUnderlyingTradingSessionID(); }
    public bool IsSetUnderlyingTradingSessionID() { return IsSetField(Tags.UnderlyingTradingSessionID); }

    public UnderlyingTradingSessionSubID UnderlyingTradingSessionSubID
    {
        get
        {
            UnderlyingTradingSessionSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingTradingSessionSubID val) { UnderlyingTradingSessionSubID = val; }
    public UnderlyingTradingSessionSubID Get(UnderlyingTradingSessionSubID val) { GetField(val); return val; }
    public bool IsSet(UnderlyingTradingSessionSubID val) { return IsSetUnderlyingTradingSessionSubID(); }
    public bool IsSetUnderlyingTradingSessionSubID() { return IsSetField(Tags.UnderlyingTradingSessionSubID); }

    public LastQty LastQty
    {
        get
        {
            LastQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastQty val) { LastQty = val; }
    public LastQty Get(LastQty val) { GetField(val); return val; }
    public bool IsSet(LastQty val) { return IsSetLastQty(); }
    public bool IsSetLastQty() { return IsSetField(Tags.LastQty); }

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

    public LastParPx LastParPx
    {
        get
        {
            LastParPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastParPx val) { LastParPx = val; }
    public LastParPx Get(LastParPx val) { GetField(val); return val; }
    public bool IsSet(LastParPx val) { return IsSetLastParPx(); }
    public bool IsSetLastParPx() { return IsSetField(Tags.LastParPx); }

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

    public LastSwapPoints LastSwapPoints
    {
        get
        {
            LastSwapPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastSwapPoints val) { LastSwapPoints = val; }
    public LastSwapPoints Get(LastSwapPoints val) { GetField(val); return val; }
    public bool IsSet(LastSwapPoints val) { return IsSetLastSwapPoints(); }
    public bool IsSetLastSwapPoints() { return IsSetField(Tags.LastSwapPoints); }

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

    public ClearingBusinessDate ClearingBusinessDate
    {
        get
        {
            ClearingBusinessDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClearingBusinessDate val) { ClearingBusinessDate = val; }
    public ClearingBusinessDate Get(ClearingBusinessDate val) { GetField(val); return val; }
    public bool IsSet(ClearingBusinessDate val) { return IsSetClearingBusinessDate(); }
    public bool IsSetClearingBusinessDate() { return IsSetField(Tags.ClearingBusinessDate); }

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

    public AvgPxIndicator AvgPxIndicator
    {
        get
        {
            AvgPxIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgPxIndicator val) { AvgPxIndicator = val; }
    public AvgPxIndicator Get(AvgPxIndicator val) { GetField(val); return val; }
    public bool IsSet(AvgPxIndicator val) { return IsSetAvgPxIndicator(); }
    public bool IsSetAvgPxIndicator() { return IsSetField(Tags.AvgPxIndicator); }

    public NoPosAmt NoPosAmt
    {
        get
        {
            NoPosAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPosAmt val) { NoPosAmt = val; }
    public NoPosAmt Get(NoPosAmt val) { GetField(val); return val; }
    public bool IsSet(NoPosAmt val) { return IsSetNoPosAmt(); }
    public bool IsSetNoPosAmt() { return IsSetField(Tags.NoPosAmt); }

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

    public TradeLegRefID TradeLegRefID
    {
        get
        {
            TradeLegRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeLegRefID val) { TradeLegRefID = val; }
    public TradeLegRefID Get(TradeLegRefID val) { GetField(val); return val; }
    public bool IsSet(TradeLegRefID val) { return IsSetTradeLegRefID(); }
    public bool IsSetTradeLegRefID() { return IsSetField(Tags.TradeLegRefID); }

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

    public MatchStatus MatchStatus
    {
        get
        {
            MatchStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MatchStatus val) { MatchStatus = val; }
    public MatchStatus Get(MatchStatus val) { GetField(val); return val; }
    public bool IsSet(MatchStatus val) { return IsSetMatchStatus(); }
    public bool IsSetMatchStatus() { return IsSetField(Tags.MatchStatus); }

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

    public NoSides NoSides
    {
        get
        {
            NoSides val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSides val) { NoSides = val; }
    public NoSides Get(NoSides val) { GetField(val); return val; }
    public bool IsSet(NoSides val) { return IsSetNoSides(); }
    public bool IsSetNoSides() { return IsSetField(Tags.NoSides); }

    public CopyMsgIndicator CopyMsgIndicator
    {
        get
        {
            CopyMsgIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CopyMsgIndicator val) { CopyMsgIndicator = val; }
    public CopyMsgIndicator Get(CopyMsgIndicator val) { GetField(val); return val; }
    public bool IsSet(CopyMsgIndicator val) { return IsSetCopyMsgIndicator(); }
    public bool IsSetCopyMsgIndicator() { return IsSetField(Tags.CopyMsgIndicator); }

    public PublishTrdIndicator PublishTrdIndicator
    {
        get
        {
            PublishTrdIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PublishTrdIndicator val) { PublishTrdIndicator = val; }
    public PublishTrdIndicator Get(PublishTrdIndicator val) { GetField(val); return val; }
    public bool IsSet(PublishTrdIndicator val) { return IsSetPublishTrdIndicator(); }
    public bool IsSetPublishTrdIndicator() { return IsSetField(Tags.PublishTrdIndicator); }

    public ShortSaleReason ShortSaleReason
    {
        get
        {
            ShortSaleReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ShortSaleReason val) { ShortSaleReason = val; }
    public ShortSaleReason Get(ShortSaleReason val) { GetField(val); return val; }
    public bool IsSet(ShortSaleReason val) { return IsSetShortSaleReason(); }
    public bool IsSetShortSaleReason() { return IsSetField(Tags.ShortSaleReason); }

    public NoCompetingQuotes NoCompetingQuotes
    {
        get
        {
            NoCompetingQuotes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoCompetingQuotes val) { NoCompetingQuotes = val; }
    public NoCompetingQuotes Get(NoCompetingQuotes val) { GetField(val); return val; }
    public bool IsSet(NoCompetingQuotes val) { return IsSetNoCompetingQuotes(); }
    public bool IsSetNoCompetingQuotes() { return IsSetField(Tags.NoCompetingQuotes); }

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

    public NoRegulatorTradeIDs NoRegulatorTradeIDs
    {
        get
        {
            NoRegulatorTradeIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRegulatorTradeIDs val) { NoRegulatorTradeIDs = val; }
    public NoRegulatorTradeIDs Get(NoRegulatorTradeIDs val) { GetField(val); return val; }
    public bool IsSet(NoRegulatorTradeIDs val) { return IsSetNoRegulatorTradeIDs(); }
    public bool IsSetNoRegulatorTradeIDs() { return IsSetField(Tags.NoRegulatorTradeIDs); }

    public LiquidityTakerLEI LiquidityTakerLEI
    {
        get
        {
            LiquidityTakerLEI val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LiquidityTakerLEI val) { LiquidityTakerLEI = val; }
    public LiquidityTakerLEI Get(LiquidityTakerLEI val) { GetField(val); return val; }
    public bool IsSet(LiquidityTakerLEI val) { return IsSetLiquidityTakerLEI(); }
    public bool IsSetLiquidityTakerLEI() { return IsSetField(Tags.LiquidityTakerLEI); }

    public LiquidityTakerIsUSPerson LiquidityTakerIsUSPerson
    {
        get
        {
            LiquidityTakerIsUSPerson val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LiquidityTakerIsUSPerson val) { LiquidityTakerIsUSPerson = val; }
    public LiquidityTakerIsUSPerson Get(LiquidityTakerIsUSPerson val) { GetField(val); return val; }
    public bool IsSet(LiquidityTakerIsUSPerson val) { return IsSetLiquidityTakerIsUSPerson(); }
    public bool IsSetLiquidityTakerIsUSPerson() { return IsSetField(Tags.LiquidityTakerIsUSPerson); }

    public LiquidityMakerLEI LiquidityMakerLEI
    {
        get
        {
            LiquidityMakerLEI val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LiquidityMakerLEI val) { LiquidityMakerLEI = val; }
    public LiquidityMakerLEI Get(LiquidityMakerLEI val) { GetField(val); return val; }
    public bool IsSet(LiquidityMakerLEI val) { return IsSetLiquidityMakerLEI(); }
    public bool IsSetLiquidityMakerLEI() { return IsSetField(Tags.LiquidityMakerLEI); }

    public LiquidityMakerIsUSPerson LiquidityMakerIsUSPerson
    {
        get
        {
            LiquidityMakerIsUSPerson val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LiquidityMakerIsUSPerson val) { LiquidityMakerIsUSPerson = val; }
    public LiquidityMakerIsUSPerson Get(LiquidityMakerIsUSPerson val) { GetField(val); return val; }
    public bool IsSet(LiquidityMakerIsUSPerson val) { return IsSetLiquidityMakerIsUSPerson(); }
    public bool IsSetLiquidityMakerIsUSPerson() { return IsSetField(Tags.LiquidityMakerIsUSPerson); }

    public IsSEFTrade IsSEFTrade
    {
        get
        {
            IsSEFTrade val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IsSEFTrade val) { IsSEFTrade = val; }
    public IsSEFTrade Get(IsSEFTrade val) { GetField(val); return val; }
    public bool IsSet(IsSEFTrade val) { return IsSetIsSEFTrade(); }
    public bool IsSetIsSEFTrade() { return IsSetField(Tags.IsSEFTrade); }

    public SwapReportingAgency SwapReportingAgency
    {
        get
        {
            SwapReportingAgency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SwapReportingAgency val) { SwapReportingAgency = val; }
    public SwapReportingAgency Get(SwapReportingAgency val) { GetField(val); return val; }
    public bool IsSet(SwapReportingAgency val) { return IsSetSwapReportingAgency(); }
    public bool IsSetSwapReportingAgency() { return IsSetField(Tags.SwapReportingAgency); }

    public BloombergSEFID BloombergSEFID
    {
        get
        {
            BloombergSEFID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BloombergSEFID val) { BloombergSEFID = val; }
    public BloombergSEFID Get(BloombergSEFID val) { GetField(val); return val; }
    public bool IsSet(BloombergSEFID val) { return IsSetBloombergSEFID(); }
    public bool IsSetBloombergSEFID() { return IsSetField(Tags.BloombergSEFID); }

    public ReportingParty ReportingParty
    {
        get
        {
            ReportingParty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ReportingParty val) { ReportingParty = val; }
    public ReportingParty Get(ReportingParty val) { GetField(val); return val; }
    public bool IsSet(ReportingParty val) { return IsSetReportingParty(); }
    public bool IsSetReportingParty() { return IsSetField(Tags.ReportingParty); }

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

    public PortfolioName PortfolioName
    {
        get
        {
            PortfolioName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PortfolioName val) { PortfolioName = val; }
    public PortfolioName Get(PortfolioName val) { GetField(val); return val; }
    public bool IsSet(PortfolioName val) { return IsSetPortfolioName(); }
    public bool IsSetPortfolioName() { return IsSetField(Tags.PortfolioName); }

    public ChatID ChatID
    {
        get
        {
            ChatID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ChatID val) { ChatID = val; }
    public ChatID Get(ChatID val) { GetField(val); return val; }
    public bool IsSet(ChatID val) { return IsSetChatID(); }
    public bool IsSetChatID() { return IsSetField(Tags.ChatID); }

    public MakerTaker MakerTaker
    {
        get
        {
            MakerTaker val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MakerTaker val) { MakerTaker = val; }
    public MakerTaker Get(MakerTaker val) { GetField(val); return val; }
    public bool IsSet(MakerTaker val) { return IsSetMakerTaker(); }
    public bool IsSetMakerTaker() { return IsSetField(Tags.MakerTaker); }

    public ProductType ProductType
    {
        get
        {
            ProductType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ProductType val) { ProductType = val; }
    public ProductType Get(ProductType val) { GetField(val); return val; }
    public bool IsSet(ProductType val) { return IsSetProductType(); }
    public bool IsSetProductType() { return IsSetField(Tags.ProductType); }

    public AlgoStrategyName AlgoStrategyName
    {
        get
        {
            AlgoStrategyName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AlgoStrategyName val) { AlgoStrategyName = val; }
    public AlgoStrategyName Get(AlgoStrategyName val) { GetField(val); return val; }
    public bool IsSet(AlgoStrategyName val) { return IsSetAlgoStrategyName(); }
    public bool IsSetAlgoStrategyName() { return IsSetField(Tags.AlgoStrategyName); }

    public FixingSource FixingSource
    {
        get
        {
            FixingSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FixingSource val) { FixingSource = val; }
    public FixingSource Get(FixingSource val) { GetField(val); return val; }
    public bool IsSet(FixingSource val) { return IsSetFixingSource(); }
    public bool IsSetFixingSource() { return IsSetField(Tags.FixingSource); }

    public NoPayments NoPayments
    {
        get
        {
            NoPayments val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPayments val) { NoPayments = val; }
    public NoPayments Get(NoPayments val) { GetField(val); return val; }
    public bool IsSet(NoPayments val) { return IsSetNoPayments(); }
    public bool IsSetNoPayments() { return IsSetField(Tags.NoPayments); }

    public BrokerName BrokerName
    {
        get
        {
            BrokerName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BrokerName val) { BrokerName = val; }
    public BrokerName Get(BrokerName val) { GetField(val); return val; }
    public bool IsSet(BrokerName val) { return IsSetBrokerName(); }
    public bool IsSetBrokerName() { return IsSetField(Tags.BrokerName); }

    public BrokerID BrokerID
    {
        get
        {
            BrokerID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BrokerID val) { BrokerID = val; }
    public BrokerID Get(BrokerID val) { GetField(val); return val; }
    public bool IsSet(BrokerID val) { return IsSetBrokerID(); }
    public bool IsSetBrokerID() { return IsSetField(Tags.BrokerID); }

    public BrokerFirmName BrokerFirmName
    {
        get
        {
            BrokerFirmName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BrokerFirmName val) { BrokerFirmName = val; }
    public BrokerFirmName Get(BrokerFirmName val) { GetField(val); return val; }
    public bool IsSet(BrokerFirmName val) { return IsSetBrokerFirmName(); }
    public bool IsSetBrokerFirmName() { return IsSetField(Tags.BrokerFirmName); }

    public BrokerDealcode BrokerDealcode
    {
        get
        {
            BrokerDealcode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BrokerDealcode val) { BrokerDealcode = val; }
    public BrokerDealcode Get(BrokerDealcode val) { GetField(val); return val; }
    public bool IsSet(BrokerDealcode val) { return IsSetBrokerDealcode(); }
    public bool IsSetBrokerDealcode() { return IsSetField(Tags.BrokerDealcode); }

    public TradePublishIndicator TradePublishIndicator
    {
        get
        {
            TradePublishIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradePublishIndicator val) { TradePublishIndicator = val; }
    public TradePublishIndicator Get(TradePublishIndicator val) { GetField(val); return val; }
    public bool IsSet(TradePublishIndicator val) { return IsSetTradePublishIndicator(); }
    public bool IsSetTradePublishIndicator() { return IsSetField(Tags.TradePublishIndicator); }

    public NoTrdRegPublications NoTrdRegPublications
    {
        get
        {
            NoTrdRegPublications val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTrdRegPublications val) { NoTrdRegPublications = val; }
    public NoTrdRegPublications Get(NoTrdRegPublications val) { GetField(val); return val; }
    public bool IsSet(NoTrdRegPublications val) { return IsSetNoTrdRegPublications(); }
    public bool IsSetNoTrdRegPublications() { return IsSetField(Tags.NoTrdRegPublications); }

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

    public class NoPosAmtGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PosAmtType, Tags.PosAmt, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.PosAmtType, Tags.PosAmt, 0};

        public NoPosAmtGroup()
          : base(Tags.NoPosAmt, Tags.PosAmtType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPosAmtGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PosAmtType PosAmtType
        {
            get
            {
                PosAmtType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PosAmtType val) { PosAmtType = val; }
        public PosAmtType Get(PosAmtType val) { GetField(val); return val; }
        public bool IsSet(PosAmtType val) { return IsSetPosAmtType(); }
        public bool IsSetPosAmtType() { return IsSetField(Tags.PosAmtType); }

        public PosAmt PosAmt
        {
            get
            {
                PosAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PosAmt val) { PosAmt = val; }
        public PosAmt Get(PosAmt val) { GetField(val); return val; }
        public bool IsSet(PosAmt val) { return IsSetPosAmt(); }
        public bool IsSetPosAmt() { return IsSetField(Tags.PosAmt); }
    }

    public class NoLegsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegMaturityDate, Tags.LegRestructuringType, Tags.LegSeniority, Tags.LegAttachmentPoint, Tags.LegDetachmentPoint, Tags.LegAssetClass, Tags.LegAssetSubClass, Tags.LegCouponFrequencyPeriod, Tags.LegCouponFrequencyUnit, Tags.LegCouponDayCount, Tags.LegIndexSeries, Tags.LegIndexAnnexVersion, Tags.LegIndexAnnexDate, Tags.LegIndexAnnexSource, Tags.LegFactor, Tags.LegCountryOfIssue, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegContractMultiplier, Tags.LegSettlMethod, Tags.LegExerciseStyle, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.LegSecurityDesc, Tags.LegSecurityXMLLen, Tags.LegSecurityXML, Tags.LegSecurityXMLSchema, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegContractSettlMonth, Tags.LegPutOrCall, Tags.LegPrice, Tags.NoLegEvents, Tags.NoLegComplexEvents, Tags.LegBusinessDayConvention, Tags.LegDateRollConvention, Tags.LegOptionExerciseLatestTime, Tags.LegOptionExerciseTimeBusinessCenter, Tags.LegOptionExerciseDeliveryDate, Tags.NoLegStreams, Tags.LegCouponDateGenerationMethod, Tags.LegPutOrCallCurrency, Tags.LegStrategyPosition, Tags.LegCustomizedIndicator, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegMaturityDate, Tags.LegRestructuringType, Tags.LegSeniority, Tags.LegAttachmentPoint, Tags.LegDetachmentPoint, Tags.LegAssetClass, Tags.LegAssetSubClass, Tags.LegCouponFrequencyPeriod, Tags.LegCouponFrequencyUnit, Tags.LegCouponDayCount, Tags.LegIndexSeries, Tags.LegIndexAnnexVersion, Tags.LegIndexAnnexDate, Tags.LegIndexAnnexSource, Tags.LegFactor, Tags.LegCountryOfIssue, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegContractMultiplier, Tags.LegSettlMethod, Tags.LegExerciseStyle, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.LegSecurityDesc, Tags.LegSecurityXMLLen, Tags.LegSecurityXML, Tags.LegSecurityXMLSchema, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegContractSettlMonth, Tags.LegPutOrCall, Tags.LegPrice, Tags.NoLegEvents, Tags.NoLegComplexEvents, Tags.LegBusinessDayConvention, Tags.LegDateRollConvention, Tags.LegOptionExerciseLatestTime, Tags.LegOptionExerciseTimeBusinessCenter, Tags.LegOptionExerciseDeliveryDate, Tags.NoLegStreams, Tags.LegCouponDateGenerationMethod, Tags.LegPutOrCallCurrency, Tags.LegStrategyPosition, Tags.LegCustomizedIndicator, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, 0};

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

        public LegCoveredOrUncovered LegCoveredOrUncovered
        {
            get
            {
                LegCoveredOrUncovered val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCoveredOrUncovered val) { LegCoveredOrUncovered = val; }
        public LegCoveredOrUncovered Get(LegCoveredOrUncovered val) { GetField(val); return val; }
        public bool IsSet(LegCoveredOrUncovered val) { return IsSetLegCoveredOrUncovered(); }
        public bool IsSetLegCoveredOrUncovered() { return IsSetField(Tags.LegCoveredOrUncovered); }

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

        public LegLastForwardPoints LegLastForwardPoints
        {
            get
            {
                LegLastForwardPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLastForwardPoints val) { LegLastForwardPoints = val; }
        public LegLastForwardPoints Get(LegLastForwardPoints val) { GetField(val); return val; }
        public bool IsSet(LegLastForwardPoints val) { return IsSetLegLastForwardPoints(); }
        public bool IsSetLegLastForwardPoints() { return IsSetField(Tags.LegLastForwardPoints); }

        public LegCalculatedCcyLastQty LegCalculatedCcyLastQty
        {
            get
            {
                LegCalculatedCcyLastQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCalculatedCcyLastQty val) { LegCalculatedCcyLastQty = val; }
        public LegCalculatedCcyLastQty Get(LegCalculatedCcyLastQty val) { GetField(val); return val; }
        public bool IsSet(LegCalculatedCcyLastQty val) { return IsSetLegCalculatedCcyLastQty(); }
        public bool IsSetLegCalculatedCcyLastQty() { return IsSetField(Tags.LegCalculatedCcyLastQty); }

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

        public LegLastPx LegLastPx
        {
            get
            {
                LegLastPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLastPx val) { LegLastPx = val; }
        public LegLastPx Get(LegLastPx val) { GetField(val); return val; }
        public bool IsSet(LegLastPx val) { return IsSetLegLastPx(); }
        public bool IsSetLegLastPx() { return IsSetField(Tags.LegLastPx); }

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

    public class NoTrdRegTimestampsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, 0};

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
    }

    public class NoSidesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Side, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoPartyIDs, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.ClearingFeeIndicator, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.OrderInputDevice, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.OrdType, Tags.ExecInst, Tags.TransBkdTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TimeBracket, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.CommissionRate, Tags.CommissionValueType, Tags.CommissionMode, Tags.GrossTradeAmt, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.InterestAtMaturity, Tags.EndAccruedInterestAmt, Tags.StartCash, Tags.EndCash, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SideMultiLegReportingType, Tags.NoContAmts, Tags.NoStipulations, Tags.NoMiscFees, Tags.ExchangeRule, Tags.TradeAllocIndicator, Tags.PreallocMethod, Tags.AllocID, Tags.NoAllocs, Tags.ClientRegulatoryTradeID, Tags.AgencyRegulatoryTradeID, Tags.LastCapacity, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.Side, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoPartyIDs, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.ClearingFeeIndicator, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.OrderInputDevice, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.OrdType, Tags.ExecInst, Tags.TransBkdTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TimeBracket, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.CommissionRate, Tags.CommissionValueType, Tags.CommissionMode, Tags.GrossTradeAmt, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.InterestAtMaturity, Tags.EndAccruedInterestAmt, Tags.StartCash, Tags.EndCash, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SideMultiLegReportingType, Tags.NoContAmts, Tags.NoStipulations, Tags.NoMiscFees, Tags.ExchangeRule, Tags.TradeAllocIndicator, Tags.PreallocMethod, Tags.AllocID, Tags.NoAllocs, Tags.ClientRegulatoryTradeID, Tags.AgencyRegulatoryTradeID, Tags.LastCapacity, 0};

        public NoSidesGroup()
          : base(Tags.NoSides, Tags.Side, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSidesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public OddLot OddLot
        {
            get
            {
                OddLot val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OddLot val) { OddLot = val; }
        public OddLot Get(OddLot val) { GetField(val); return val; }
        public bool IsSet(OddLot val) { return IsSetOddLot(); }
        public bool IsSetOddLot() { return IsSetField(Tags.OddLot); }

        public NoClearingInstructions NoClearingInstructions
        {
            get
            {
                NoClearingInstructions val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoClearingInstructions val) { NoClearingInstructions = val; }
        public NoClearingInstructions Get(NoClearingInstructions val) { GetField(val); return val; }
        public bool IsSet(NoClearingInstructions val) { return IsSetNoClearingInstructions(); }
        public bool IsSetNoClearingInstructions() { return IsSetField(Tags.NoClearingInstructions); }

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

        public TradeInputSource TradeInputSource
        {
            get
            {
                TradeInputSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeInputSource val) { TradeInputSource = val; }
        public TradeInputSource Get(TradeInputSource val) { GetField(val); return val; }
        public bool IsSet(TradeInputSource val) { return IsSetTradeInputSource(); }
        public bool IsSetTradeInputSource() { return IsSetField(Tags.TradeInputSource); }

        public TradeInputDevice TradeInputDevice
        {
            get
            {
                TradeInputDevice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeInputDevice val) { TradeInputDevice = val; }
        public TradeInputDevice Get(TradeInputDevice val) { GetField(val); return val; }
        public bool IsSet(TradeInputDevice val) { return IsSetTradeInputDevice(); }
        public bool IsSetTradeInputDevice() { return IsSetField(Tags.TradeInputDevice); }

        public OrderInputDevice OrderInputDevice
        {
            get
            {
                OrderInputDevice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderInputDevice val) { OrderInputDevice = val; }
        public OrderInputDevice Get(OrderInputDevice val) { GetField(val); return val; }
        public bool IsSet(OrderInputDevice val) { return IsSetOrderInputDevice(); }
        public bool IsSetOrderInputDevice() { return IsSetField(Tags.OrderInputDevice); }

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

        public TransBkdTime TransBkdTime
        {
            get
            {
                TransBkdTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TransBkdTime val) { TransBkdTime = val; }
        public TransBkdTime Get(TransBkdTime val) { GetField(val); return val; }
        public bool IsSet(TransBkdTime val) { return IsSetTransBkdTime(); }
        public bool IsSetTransBkdTime() { return IsSetField(Tags.TransBkdTime); }

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

        public TimeBracket TimeBracket
        {
            get
            {
                TimeBracket val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TimeBracket val) { TimeBracket = val; }
        public TimeBracket Get(TimeBracket val) { GetField(val); return val; }
        public bool IsSet(TimeBracket val) { return IsSetTimeBracket(); }
        public bool IsSetTimeBracket() { return IsSetField(Tags.TimeBracket); }

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

        public ExDate ExDate
        {
            get
            {
                ExDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExDate val) { ExDate = val; }
        public ExDate Get(ExDate val) { GetField(val); return val; }
        public bool IsSet(ExDate val) { return IsSetExDate(); }
        public bool IsSetExDate() { return IsSetField(Tags.ExDate); }

        public AccruedInterestRate AccruedInterestRate
        {
            get
            {
                AccruedInterestRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AccruedInterestRate val) { AccruedInterestRate = val; }
        public AccruedInterestRate Get(AccruedInterestRate val) { GetField(val); return val; }
        public bool IsSet(AccruedInterestRate val) { return IsSetAccruedInterestRate(); }
        public bool IsSetAccruedInterestRate() { return IsSetField(Tags.AccruedInterestRate); }

        public AccruedInterestAmt AccruedInterestAmt
        {
            get
            {
                AccruedInterestAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AccruedInterestAmt val) { AccruedInterestAmt = val; }
        public AccruedInterestAmt Get(AccruedInterestAmt val) { GetField(val); return val; }
        public bool IsSet(AccruedInterestAmt val) { return IsSetAccruedInterestAmt(); }
        public bool IsSetAccruedInterestAmt() { return IsSetField(Tags.AccruedInterestAmt); }

        public InterestAtMaturity InterestAtMaturity
        {
            get
            {
                InterestAtMaturity val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InterestAtMaturity val) { InterestAtMaturity = val; }
        public InterestAtMaturity Get(InterestAtMaturity val) { GetField(val); return val; }
        public bool IsSet(InterestAtMaturity val) { return IsSetInterestAtMaturity(); }
        public bool IsSetInterestAtMaturity() { return IsSetField(Tags.InterestAtMaturity); }

        public EndAccruedInterestAmt EndAccruedInterestAmt
        {
            get
            {
                EndAccruedInterestAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EndAccruedInterestAmt val) { EndAccruedInterestAmt = val; }
        public EndAccruedInterestAmt Get(EndAccruedInterestAmt val) { GetField(val); return val; }
        public bool IsSet(EndAccruedInterestAmt val) { return IsSetEndAccruedInterestAmt(); }
        public bool IsSetEndAccruedInterestAmt() { return IsSetField(Tags.EndAccruedInterestAmt); }

        public StartCash StartCash
        {
            get
            {
                StartCash val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StartCash val) { StartCash = val; }
        public StartCash Get(StartCash val) { GetField(val); return val; }
        public bool IsSet(StartCash val) { return IsSetStartCash(); }
        public bool IsSetStartCash() { return IsSetField(Tags.StartCash); }

        public EndCash EndCash
        {
            get
            {
                EndCash val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EndCash val) { EndCash = val; }
        public EndCash Get(EndCash val) { GetField(val); return val; }
        public bool IsSet(EndCash val) { return IsSetEndCash(); }
        public bool IsSetEndCash() { return IsSetField(Tags.EndCash); }

        public Concession Concession
        {
            get
            {
                Concession val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Concession val) { Concession = val; }
        public Concession Get(Concession val) { GetField(val); return val; }
        public bool IsSet(Concession val) { return IsSetConcession(); }
        public bool IsSetConcession() { return IsSetField(Tags.Concession); }

        public TotalTakedown TotalTakedown
        {
            get
            {
                TotalTakedown val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TotalTakedown val) { TotalTakedown = val; }
        public TotalTakedown Get(TotalTakedown val) { GetField(val); return val; }
        public bool IsSet(TotalTakedown val) { return IsSetTotalTakedown(); }
        public bool IsSetTotalTakedown() { return IsSetField(Tags.TotalTakedown); }

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

        public SideMultiLegReportingType SideMultiLegReportingType
        {
            get
            {
                SideMultiLegReportingType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideMultiLegReportingType val) { SideMultiLegReportingType = val; }
        public SideMultiLegReportingType Get(SideMultiLegReportingType val) { GetField(val); return val; }
        public bool IsSet(SideMultiLegReportingType val) { return IsSetSideMultiLegReportingType(); }
        public bool IsSetSideMultiLegReportingType() { return IsSetField(Tags.SideMultiLegReportingType); }

        public NoContAmts NoContAmts
        {
            get
            {
                NoContAmts val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoContAmts val) { NoContAmts = val; }
        public NoContAmts Get(NoContAmts val) { GetField(val); return val; }
        public bool IsSet(NoContAmts val) { return IsSetNoContAmts(); }
        public bool IsSetNoContAmts() { return IsSetField(Tags.NoContAmts); }

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

        public NoMiscFees NoMiscFees
        {
            get
            {
                NoMiscFees val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoMiscFees val) { NoMiscFees = val; }
        public NoMiscFees Get(NoMiscFees val) { GetField(val); return val; }
        public bool IsSet(NoMiscFees val) { return IsSetNoMiscFees(); }
        public bool IsSetNoMiscFees() { return IsSetField(Tags.NoMiscFees); }

        public ExchangeRule ExchangeRule
        {
            get
            {
                ExchangeRule val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExchangeRule val) { ExchangeRule = val; }
        public ExchangeRule Get(ExchangeRule val) { GetField(val); return val; }
        public bool IsSet(ExchangeRule val) { return IsSetExchangeRule(); }
        public bool IsSetExchangeRule() { return IsSetField(Tags.ExchangeRule); }

        public TradeAllocIndicator TradeAllocIndicator
        {
            get
            {
                TradeAllocIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeAllocIndicator val) { TradeAllocIndicator = val; }
        public TradeAllocIndicator Get(TradeAllocIndicator val) { GetField(val); return val; }
        public bool IsSet(TradeAllocIndicator val) { return IsSetTradeAllocIndicator(); }
        public bool IsSetTradeAllocIndicator() { return IsSetField(Tags.TradeAllocIndicator); }

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

        public ClientRegulatoryTradeID ClientRegulatoryTradeID
        {
            get
            {
                ClientRegulatoryTradeID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClientRegulatoryTradeID val) { ClientRegulatoryTradeID = val; }
        public ClientRegulatoryTradeID Get(ClientRegulatoryTradeID val) { GetField(val); return val; }
        public bool IsSet(ClientRegulatoryTradeID val) { return IsSetClientRegulatoryTradeID(); }
        public bool IsSetClientRegulatoryTradeID() { return IsSetField(Tags.ClientRegulatoryTradeID); }

        public AgencyRegulatoryTradeID AgencyRegulatoryTradeID
        {
            get
            {
                AgencyRegulatoryTradeID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AgencyRegulatoryTradeID val) { AgencyRegulatoryTradeID = val; }
        public AgencyRegulatoryTradeID Get(AgencyRegulatoryTradeID val) { GetField(val); return val; }
        public bool IsSet(AgencyRegulatoryTradeID val) { return IsSetAgencyRegulatoryTradeID(); }
        public bool IsSetAgencyRegulatoryTradeID() { return IsSetField(Tags.AgencyRegulatoryTradeID); }

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

        public class NoClearingInstructionsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ClearingInstruction, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.ClearingInstruction, 0};

            public NoClearingInstructionsGroup()
              : base(Tags.NoClearingInstructions, Tags.ClearingInstruction, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoClearingInstructionsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ClearingInstruction ClearingInstruction
            {
                get
                {
                    ClearingInstruction val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ClearingInstruction val) { ClearingInstruction = val; }
            public ClearingInstruction Get(ClearingInstruction val) { GetField(val); return val; }
            public bool IsSet(ClearingInstruction val) { return IsSetClearingInstruction(); }
            public bool IsSetClearingInstruction() { return IsSetField(Tags.ClearingInstruction); }
        }

        public class NoContAmtsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0};

            public NoContAmtsGroup()
              : base(Tags.NoContAmts, Tags.ContAmtType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoContAmtsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ContAmtType ContAmtType
            {
                get
                {
                    ContAmtType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContAmtType val) { ContAmtType = val; }
            public ContAmtType Get(ContAmtType val) { GetField(val); return val; }
            public bool IsSet(ContAmtType val) { return IsSetContAmtType(); }
            public bool IsSetContAmtType() { return IsSetField(Tags.ContAmtType); }

            public ContAmtValue ContAmtValue
            {
                get
                {
                    ContAmtValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContAmtValue val) { ContAmtValue = val; }
            public ContAmtValue Get(ContAmtValue val) { GetField(val); return val; }
            public bool IsSet(ContAmtValue val) { return IsSetContAmtValue(); }
            public bool IsSetContAmtValue() { return IsSetField(Tags.ContAmtValue); }

            public ContAmtCurr ContAmtCurr
            {
                get
                {
                    ContAmtCurr val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContAmtCurr val) { ContAmtCurr = val; }
            public ContAmtCurr Get(ContAmtCurr val) { GetField(val); return val; }
            public bool IsSet(ContAmtCurr val) { return IsSetContAmtCurr(); }
            public bool IsSetContAmtCurr() { return IsSetField(Tags.ContAmtCurr); }
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

        public class NoMiscFeesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0};

            public NoMiscFeesGroup()
              : base(Tags.NoMiscFees, Tags.MiscFeeAmt, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoMiscFeesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public MiscFeeAmt MiscFeeAmt
            {
                get
                {
                    MiscFeeAmt val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MiscFeeAmt val) { MiscFeeAmt = val; }
            public MiscFeeAmt Get(MiscFeeAmt val) { GetField(val); return val; }
            public bool IsSet(MiscFeeAmt val) { return IsSetMiscFeeAmt(); }
            public bool IsSetMiscFeeAmt() { return IsSetField(Tags.MiscFeeAmt); }

            public MiscFeeCurr MiscFeeCurr
            {
                get
                {
                    MiscFeeCurr val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MiscFeeCurr val) { MiscFeeCurr = val; }
            public MiscFeeCurr Get(MiscFeeCurr val) { GetField(val); return val; }
            public bool IsSet(MiscFeeCurr val) { return IsSetMiscFeeCurr(); }
            public bool IsSetMiscFeeCurr() { return IsSetField(Tags.MiscFeeCurr); }

            public MiscFeeType MiscFeeType
            {
                get
                {
                    MiscFeeType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MiscFeeType val) { MiscFeeType = val; }
            public MiscFeeType Get(MiscFeeType val) { GetField(val); return val; }
            public bool IsSet(MiscFeeType val) { return IsSetMiscFeeType(); }
            public bool IsSetMiscFeeType() { return IsSetField(Tags.MiscFeeType); }

            public MiscFeeBasis MiscFeeBasis
            {
                get
                {
                    MiscFeeBasis val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MiscFeeBasis val) { MiscFeeBasis = val; }
            public MiscFeeBasis Get(MiscFeeBasis val) { GetField(val); return val; }
            public bool IsSet(MiscFeeBasis val) { return IsSetMiscFeeBasis(); }
            public bool IsSetMiscFeeBasis() { return IsSetField(Tags.MiscFeeBasis); }
        }

        public class NoAllocsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocQty, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.AllocSettlCurrAmt, Tags.IndividualAllocID, Tags.NoNested2PartyIDs, Tags.AllocLegNo, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
            public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocQty, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.AllocSettlCurrAmt, Tags.IndividualAllocID, Tags.NoNested2PartyIDs, Tags.AllocLegNo, 0};

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

            public AllocSettlCurrAmt AllocSettlCurrAmt
            {
                get
                {
                    AllocSettlCurrAmt val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocSettlCurrAmt val) { AllocSettlCurrAmt = val; }
            public AllocSettlCurrAmt Get(AllocSettlCurrAmt val) { GetField(val); return val; }
            public bool IsSet(AllocSettlCurrAmt val) { return IsSetAllocSettlCurrAmt(); }
            public bool IsSetAllocSettlCurrAmt() { return IsSetField(Tags.AllocSettlCurrAmt); }

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

            public NoNested2PartyIDs NoNested2PartyIDs
            {
                get
                {
                    NoNested2PartyIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNested2PartyIDs val) { NoNested2PartyIDs = val; }
            public NoNested2PartyIDs Get(NoNested2PartyIDs val) { GetField(val); return val; }
            public bool IsSet(NoNested2PartyIDs val) { return IsSetNoNested2PartyIDs(); }
            public bool IsSetNoNested2PartyIDs() { return IsSetField(Tags.NoNested2PartyIDs); }

            public AllocLegNo AllocLegNo
            {
                get
                {
                    AllocLegNo val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocLegNo val) { AllocLegNo = val; }
            public AllocLegNo Get(AllocLegNo val) { GetField(val); return val; }
            public bool IsSet(AllocLegNo val) { return IsSetAllocLegNo(); }
            public bool IsSetAllocLegNo() { return IsSetField(Tags.AllocLegNo); }

            public class NoNested2PartyIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
                public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};

                public NoNested2PartyIDsGroup()
                  : base(Tags.NoNested2PartyIDs, Tags.Nested2PartyID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNested2PartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public Nested2PartyID Nested2PartyID
                {
                    get
                    {
                        Nested2PartyID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested2PartyID val) { Nested2PartyID = val; }
                public Nested2PartyID Get(Nested2PartyID val) { GetField(val); return val; }
                public bool IsSet(Nested2PartyID val) { return IsSetNested2PartyID(); }
                public bool IsSetNested2PartyID() { return IsSetField(Tags.Nested2PartyID); }

                public Nested2PartyIDSource Nested2PartyIDSource
                {
                    get
                    {
                        Nested2PartyIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested2PartyIDSource val) { Nested2PartyIDSource = val; }
                public Nested2PartyIDSource Get(Nested2PartyIDSource val) { GetField(val); return val; }
                public bool IsSet(Nested2PartyIDSource val) { return IsSetNested2PartyIDSource(); }
                public bool IsSetNested2PartyIDSource() { return IsSetField(Tags.Nested2PartyIDSource); }

                public Nested2PartyRole Nested2PartyRole
                {
                    get
                    {
                        Nested2PartyRole val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested2PartyRole val) { Nested2PartyRole = val; }
                public Nested2PartyRole Get(Nested2PartyRole val) { GetField(val); return val; }
                public bool IsSet(Nested2PartyRole val) { return IsSetNested2PartyRole(); }
                public bool IsSetNested2PartyRole() { return IsSetField(Tags.Nested2PartyRole); }

                public NoNested2PartySubIDs NoNested2PartySubIDs
                {
                    get
                    {
                        NoNested2PartySubIDs val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoNested2PartySubIDs val) { NoNested2PartySubIDs = val; }
                public NoNested2PartySubIDs Get(NoNested2PartySubIDs val) { GetField(val); return val; }
                public bool IsSet(NoNested2PartySubIDs val) { return IsSetNoNested2PartySubIDs(); }
                public bool IsSetNoNested2PartySubIDs() { return IsSetField(Tags.NoNested2PartySubIDs); }

                public class NoNested2PartySubIDsGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
                    public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};

                    public NoNested2PartySubIDsGroup()
                      : base(Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoNested2PartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public Nested2PartySubID Nested2PartySubID
                    {
                        get
                        {
                            Nested2PartySubID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(Nested2PartySubID val) { Nested2PartySubID = val; }
                    public Nested2PartySubID Get(Nested2PartySubID val) { GetField(val); return val; }
                    public bool IsSet(Nested2PartySubID val) { return IsSetNested2PartySubID(); }
                    public bool IsSetNested2PartySubID() { return IsSetField(Tags.Nested2PartySubID); }

                    public Nested2PartySubIDType Nested2PartySubIDType
                    {
                        get
                        {
                            Nested2PartySubIDType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(Nested2PartySubIDType val) { Nested2PartySubIDType = val; }
                    public Nested2PartySubIDType Get(Nested2PartySubIDType val) { GetField(val); return val; }
                    public bool IsSet(Nested2PartySubIDType val) { return IsSetNested2PartySubIDType(); }
                    public bool IsSetNested2PartySubIDType() { return IsSetField(Tags.Nested2PartySubIDType); }
                }
            }
        }
    }

    public class NoCompetingQuotesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.CompetingQuoteDealer, Tags.CompetingQuote, Tags.CompetingQuoteLeg2, Tags.CompetingQuoteFwdPoints, Tags.CompetingQuoteType, Tags.NonTradedSideQuote, Tags.NonTradedSideQuoteLeg2, Tags.NonTradedSideFwdPoints, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.CompetingQuoteDealer, Tags.CompetingQuote, Tags.CompetingQuoteLeg2, Tags.CompetingQuoteFwdPoints, Tags.CompetingQuoteType, Tags.NonTradedSideQuote, Tags.NonTradedSideQuoteLeg2, Tags.NonTradedSideFwdPoints, 0};

        public NoCompetingQuotesGroup()
          : base(Tags.NoCompetingQuotes, Tags.CompetingQuoteDealer, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoCompetingQuotesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public CompetingQuoteDealer CompetingQuoteDealer
        {
            get
            {
                CompetingQuoteDealer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompetingQuoteDealer val) { CompetingQuoteDealer = val; }
        public CompetingQuoteDealer Get(CompetingQuoteDealer val) { GetField(val); return val; }
        public bool IsSet(CompetingQuoteDealer val) { return IsSetCompetingQuoteDealer(); }
        public bool IsSetCompetingQuoteDealer() { return IsSetField(Tags.CompetingQuoteDealer); }

        public CompetingQuote CompetingQuote
        {
            get
            {
                CompetingQuote val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompetingQuote val) { CompetingQuote = val; }
        public CompetingQuote Get(CompetingQuote val) { GetField(val); return val; }
        public bool IsSet(CompetingQuote val) { return IsSetCompetingQuote(); }
        public bool IsSetCompetingQuote() { return IsSetField(Tags.CompetingQuote); }

        public CompetingQuoteLeg2 CompetingQuoteLeg2
        {
            get
            {
                CompetingQuoteLeg2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompetingQuoteLeg2 val) { CompetingQuoteLeg2 = val; }
        public CompetingQuoteLeg2 Get(CompetingQuoteLeg2 val) { GetField(val); return val; }
        public bool IsSet(CompetingQuoteLeg2 val) { return IsSetCompetingQuoteLeg2(); }
        public bool IsSetCompetingQuoteLeg2() { return IsSetField(Tags.CompetingQuoteLeg2); }

        public CompetingQuoteFwdPoints CompetingQuoteFwdPoints
        {
            get
            {
                CompetingQuoteFwdPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompetingQuoteFwdPoints val) { CompetingQuoteFwdPoints = val; }
        public CompetingQuoteFwdPoints Get(CompetingQuoteFwdPoints val) { GetField(val); return val; }
        public bool IsSet(CompetingQuoteFwdPoints val) { return IsSetCompetingQuoteFwdPoints(); }
        public bool IsSetCompetingQuoteFwdPoints() { return IsSetField(Tags.CompetingQuoteFwdPoints); }

        public CompetingQuoteType CompetingQuoteType
        {
            get
            {
                CompetingQuoteType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompetingQuoteType val) { CompetingQuoteType = val; }
        public CompetingQuoteType Get(CompetingQuoteType val) { GetField(val); return val; }
        public bool IsSet(CompetingQuoteType val) { return IsSetCompetingQuoteType(); }
        public bool IsSetCompetingQuoteType() { return IsSetField(Tags.CompetingQuoteType); }

        public NonTradedSideQuote NonTradedSideQuote
        {
            get
            {
                NonTradedSideQuote val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NonTradedSideQuote val) { NonTradedSideQuote = val; }
        public NonTradedSideQuote Get(NonTradedSideQuote val) { GetField(val); return val; }
        public bool IsSet(NonTradedSideQuote val) { return IsSetNonTradedSideQuote(); }
        public bool IsSetNonTradedSideQuote() { return IsSetField(Tags.NonTradedSideQuote); }

        public NonTradedSideQuoteLeg2 NonTradedSideQuoteLeg2
        {
            get
            {
                NonTradedSideQuoteLeg2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NonTradedSideQuoteLeg2 val) { NonTradedSideQuoteLeg2 = val; }
        public NonTradedSideQuoteLeg2 Get(NonTradedSideQuoteLeg2 val) { GetField(val); return val; }
        public bool IsSet(NonTradedSideQuoteLeg2 val) { return IsSetNonTradedSideQuoteLeg2(); }
        public bool IsSetNonTradedSideQuoteLeg2() { return IsSetField(Tags.NonTradedSideQuoteLeg2); }

        public NonTradedSideFwdPoints NonTradedSideFwdPoints
        {
            get
            {
                NonTradedSideFwdPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NonTradedSideFwdPoints val) { NonTradedSideFwdPoints = val; }
        public NonTradedSideFwdPoints Get(NonTradedSideFwdPoints val) { GetField(val); return val; }
        public bool IsSet(NonTradedSideFwdPoints val) { return IsSetNonTradedSideFwdPoints(); }
        public bool IsSetNonTradedSideFwdPoints() { return IsSetField(Tags.NonTradedSideFwdPoints); }
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

    public class NoRegulatorTradeIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClientRegulatoryTradeID, Tags.AgencyRegulatoryTradeID, Tags.RegulatoryTradeIDEvent, Tags.RegulatoryTradeIDType, Tags.USINearLegValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.ClientRegulatoryTradeID, Tags.AgencyRegulatoryTradeID, Tags.RegulatoryTradeIDEvent, Tags.RegulatoryTradeIDType, Tags.USINearLegValue, 0};

        public NoRegulatorTradeIDsGroup()
          : base(Tags.NoRegulatorTradeIDs, Tags.ClientRegulatoryTradeID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRegulatorTradeIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ClientRegulatoryTradeID ClientRegulatoryTradeID
        {
            get
            {
                ClientRegulatoryTradeID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClientRegulatoryTradeID val) { ClientRegulatoryTradeID = val; }
        public ClientRegulatoryTradeID Get(ClientRegulatoryTradeID val) { GetField(val); return val; }
        public bool IsSet(ClientRegulatoryTradeID val) { return IsSetClientRegulatoryTradeID(); }
        public bool IsSetClientRegulatoryTradeID() { return IsSetField(Tags.ClientRegulatoryTradeID); }

        public AgencyRegulatoryTradeID AgencyRegulatoryTradeID
        {
            get
            {
                AgencyRegulatoryTradeID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AgencyRegulatoryTradeID val) { AgencyRegulatoryTradeID = val; }
        public AgencyRegulatoryTradeID Get(AgencyRegulatoryTradeID val) { GetField(val); return val; }
        public bool IsSet(AgencyRegulatoryTradeID val) { return IsSetAgencyRegulatoryTradeID(); }
        public bool IsSetAgencyRegulatoryTradeID() { return IsSetField(Tags.AgencyRegulatoryTradeID); }

        public RegulatoryTradeIDEvent RegulatoryTradeIDEvent
        {
            get
            {
                RegulatoryTradeIDEvent val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RegulatoryTradeIDEvent val) { RegulatoryTradeIDEvent = val; }
        public RegulatoryTradeIDEvent Get(RegulatoryTradeIDEvent val) { GetField(val); return val; }
        public bool IsSet(RegulatoryTradeIDEvent val) { return IsSetRegulatoryTradeIDEvent(); }
        public bool IsSetRegulatoryTradeIDEvent() { return IsSetField(Tags.RegulatoryTradeIDEvent); }

        public RegulatoryTradeIDType RegulatoryTradeIDType
        {
            get
            {
                RegulatoryTradeIDType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RegulatoryTradeIDType val) { RegulatoryTradeIDType = val; }
        public RegulatoryTradeIDType Get(RegulatoryTradeIDType val) { GetField(val); return val; }
        public bool IsSet(RegulatoryTradeIDType val) { return IsSetRegulatoryTradeIDType(); }
        public bool IsSetRegulatoryTradeIDType() { return IsSetField(Tags.RegulatoryTradeIDType); }

        public USINearLegValue USINearLegValue
        {
            get
            {
                USINearLegValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(USINearLegValue val) { USINearLegValue = val; }
        public USINearLegValue Get(USINearLegValue val) { GetField(val); return val; }
        public bool IsSet(USINearLegValue val) { return IsSetUSINearLegValue(); }
        public bool IsSetUSINearLegValue() { return IsSetField(Tags.USINearLegValue); }
    }

    public class NoPaymentsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PaymentType, Tags.PaymentCurrency, Tags.PaymentAmount, Tags.PaymentDateAdjusted, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.PaymentType, Tags.PaymentCurrency, Tags.PaymentAmount, Tags.PaymentDateAdjusted, 0};

        public NoPaymentsGroup()
          : base(Tags.NoPayments, Tags.PaymentType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPaymentsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PaymentType PaymentType
        {
            get
            {
                PaymentType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentType val) { PaymentType = val; }
        public PaymentType Get(PaymentType val) { GetField(val); return val; }
        public bool IsSet(PaymentType val) { return IsSetPaymentType(); }
        public bool IsSetPaymentType() { return IsSetField(Tags.PaymentType); }

        public PaymentCurrency PaymentCurrency
        {
            get
            {
                PaymentCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentCurrency val) { PaymentCurrency = val; }
        public PaymentCurrency Get(PaymentCurrency val) { GetField(val); return val; }
        public bool IsSet(PaymentCurrency val) { return IsSetPaymentCurrency(); }
        public bool IsSetPaymentCurrency() { return IsSetField(Tags.PaymentCurrency); }

        public PaymentAmount PaymentAmount
        {
            get
            {
                PaymentAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentAmount val) { PaymentAmount = val; }
        public PaymentAmount Get(PaymentAmount val) { GetField(val); return val; }
        public bool IsSet(PaymentAmount val) { return IsSetPaymentAmount(); }
        public bool IsSetPaymentAmount() { return IsSetField(Tags.PaymentAmount); }

        public PaymentDateAdjusted PaymentDateAdjusted
        {
            get
            {
                PaymentDateAdjusted val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentDateAdjusted val) { PaymentDateAdjusted = val; }
        public PaymentDateAdjusted Get(PaymentDateAdjusted val) { GetField(val); return val; }
        public bool IsSet(PaymentDateAdjusted val) { return IsSetPaymentDateAdjusted(); }
        public bool IsSetPaymentDateAdjusted() { return IsSetField(Tags.PaymentDateAdjusted); }
    }

    public class NoTrdRegPublicationsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TrdRegPublicationType, Tags.TrdRegPublicationReason, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in 1.16.")]
        public static int[] fieldOrder = {Tags.TrdRegPublicationType, Tags.TrdRegPublicationReason, 0};

        public NoTrdRegPublicationsGroup()
          : base(Tags.NoTrdRegPublications, Tags.TrdRegPublicationType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTrdRegPublicationsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public TrdRegPublicationType TrdRegPublicationType
        {
            get
            {
                TrdRegPublicationType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegPublicationType val) { TrdRegPublicationType = val; }
        public TrdRegPublicationType Get(TrdRegPublicationType val) { GetField(val); return val; }
        public bool IsSet(TrdRegPublicationType val) { return IsSetTrdRegPublicationType(); }
        public bool IsSetTrdRegPublicationType() { return IsSetField(Tags.TrdRegPublicationType); }

        public TrdRegPublicationReason TrdRegPublicationReason
        {
            get
            {
                TrdRegPublicationReason val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegPublicationReason val) { TrdRegPublicationReason = val; }
        public TrdRegPublicationReason Get(TrdRegPublicationReason val) { GetField(val); return val; }
        public bool IsSet(TrdRegPublicationReason val) { return IsSetTrdRegPublicationReason(); }
        public bool IsSetTrdRegPublicationReason() { return IsSetField(Tags.TrdRegPublicationReason); }
    }
}
