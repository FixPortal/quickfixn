// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

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
            ExecType aExecType,
            OrdStatus aOrdStatus,
            Side aSide,
            LeavesQty aLeavesQty,
            CumQty aCumQty
        ) : this()
    {
        OrderID = aOrderID;
        ExecID = aExecID;
        ExecType = aExecType;
        OrdStatus = aOrdStatus;
        Side = aSide;
        LeavesQty = aLeavesQty;
        CumQty = aCumQty;
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

    public OrdStatusReqID OrdStatusReqID
    {
        get
        {
            OrdStatusReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdStatusReqID val) { OrdStatusReqID = val; }
    public OrdStatusReqID Get(OrdStatusReqID val) { GetField(val); return val; }
    public bool IsSet(OrdStatusReqID val) { return IsSetOrdStatusReqID(); }
    public bool IsSetOrdStatusReqID() { return IsSetField(Tags.OrdStatusReqID); }

    public MassStatusReqID MassStatusReqID
    {
        get
        {
            MassStatusReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MassStatusReqID val) { MassStatusReqID = val; }
    public MassStatusReqID Get(MassStatusReqID val) { GetField(val); return val; }
    public bool IsSet(MassStatusReqID val) { return IsSetMassStatusReqID(); }
    public bool IsSetMassStatusReqID() { return IsSetField(Tags.MassStatusReqID); }

    public TotNumReports TotNumReports
    {
        get
        {
            TotNumReports val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNumReports val) { TotNumReports = val; }
    public TotNumReports Get(TotNumReports val) { GetField(val); return val; }
    public bool IsSet(TotNumReports val) { return IsSetTotNumReports(); }
    public bool IsSetTotNumReports() { return IsSetField(Tags.TotNumReports); }

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

    public CrossID CrossID
    {
        get
        {
            CrossID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CrossID val) { CrossID = val; }
    public CrossID Get(CrossID val) { GetField(val); return val; }
    public bool IsSet(CrossID val) { return IsSetCrossID(); }
    public bool IsSetCrossID() { return IsSetField(Tags.CrossID); }

    public OrigCrossID OrigCrossID
    {
        get
        {
            OrigCrossID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigCrossID val) { OrigCrossID = val; }
    public OrigCrossID Get(OrigCrossID val) { GetField(val); return val; }
    public bool IsSet(OrigCrossID val) { return IsSetOrigCrossID(); }
    public bool IsSetOrigCrossID() { return IsSetField(Tags.OrigCrossID); }

    public CrossType CrossType
    {
        get
        {
            CrossType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CrossType val) { CrossType = val; }
    public CrossType Get(CrossType val) { GetField(val); return val; }
    public bool IsSet(CrossType val) { return IsSetCrossType(); }
    public bool IsSetCrossType() { return IsSetField(Tags.CrossType); }

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

    public WorkingIndicator WorkingIndicator
    {
        get
        {
            WorkingIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(WorkingIndicator val) { WorkingIndicator = val; }
    public WorkingIndicator Get(WorkingIndicator val) { GetField(val); return val; }
    public bool IsSet(WorkingIndicator val) { return IsSetWorkingIndicator(); }
    public bool IsSetWorkingIndicator() { return IsSetField(Tags.WorkingIndicator); }

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

    public PeggedPrice PeggedPrice
    {
        get
        {
            PeggedPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PeggedPrice val) { PeggedPrice = val; }
    public PeggedPrice Get(PeggedPrice val) { GetField(val); return val; }
    public bool IsSet(PeggedPrice val) { return IsSetPeggedPrice(); }
    public bool IsSetPeggedPrice() { return IsSetField(Tags.PeggedPrice); }

    public DiscretionPrice DiscretionPrice
    {
        get
        {
            DiscretionPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DiscretionPrice val) { DiscretionPrice = val; }
    public DiscretionPrice Get(DiscretionPrice val) { GetField(val); return val; }
    public bool IsSet(DiscretionPrice val) { return IsSetDiscretionPrice(); }
    public bool IsSetDiscretionPrice() { return IsSetField(Tags.DiscretionPrice); }

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

    public TargetStrategyPerformance TargetStrategyPerformance
    {
        get
        {
            TargetStrategyPerformance val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TargetStrategyPerformance val) { TargetStrategyPerformance = val; }
    public TargetStrategyPerformance Get(TargetStrategyPerformance val) { GetField(val); return val; }
    public bool IsSet(TargetStrategyPerformance val) { return IsSetTargetStrategyPerformance(); }
    public bool IsSetTargetStrategyPerformance() { return IsSetField(Tags.TargetStrategyPerformance); }

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

    public UnderlyingLastQty UnderlyingLastQty
    {
        get
        {
            UnderlyingLastQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingLastQty val) { UnderlyingLastQty = val; }
    public UnderlyingLastQty Get(UnderlyingLastQty val) { GetField(val); return val; }
    public bool IsSet(UnderlyingLastQty val) { return IsSetUnderlyingLastQty(); }
    public bool IsSetUnderlyingLastQty() { return IsSetField(Tags.UnderlyingLastQty); }

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

    public UnderlyingLastPx UnderlyingLastPx
    {
        get
        {
            UnderlyingLastPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingLastPx val) { UnderlyingLastPx = val; }
    public UnderlyingLastPx Get(UnderlyingLastPx val) { GetField(val); return val; }
    public bool IsSet(UnderlyingLastPx val) { return IsSetUnderlyingLastPx(); }
    public bool IsSetUnderlyingLastPx() { return IsSetField(Tags.UnderlyingLastPx); }

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

    public TradedFlatSwitch TradedFlatSwitch
    {
        get
        {
            TradedFlatSwitch val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradedFlatSwitch val) { TradedFlatSwitch = val; }
    public TradedFlatSwitch Get(TradedFlatSwitch val) { GetField(val); return val; }
    public bool IsSet(TradedFlatSwitch val) { return IsSetTradedFlatSwitch(); }
    public bool IsSetTradedFlatSwitch() { return IsSetField(Tags.TradedFlatSwitch); }

    public BasisFeatureDate BasisFeatureDate
    {
        get
        {
            BasisFeatureDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BasisFeatureDate val) { BasisFeatureDate = val; }
    public BasisFeatureDate Get(BasisFeatureDate val) { GetField(val); return val; }
    public bool IsSet(BasisFeatureDate val) { return IsSetBasisFeatureDate(); }
    public bool IsSetBasisFeatureDate() { return IsSetField(Tags.BasisFeatureDate); }

    public BasisFeaturePrice BasisFeaturePrice
    {
        get
        {
            BasisFeaturePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BasisFeaturePrice val) { BasisFeaturePrice = val; }
    public BasisFeaturePrice Get(BasisFeaturePrice val) { GetField(val); return val; }
    public bool IsSet(BasisFeaturePrice val) { return IsSetBasisFeaturePrice(); }
    public bool IsSetBasisFeaturePrice() { return IsSetField(Tags.BasisFeaturePrice); }

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

    public LastForwardPoints2 LastForwardPoints2
    {
        get
        {
            LastForwardPoints2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastForwardPoints2 val) { LastForwardPoints2 = val; }
    public LastForwardPoints2 Get(LastForwardPoints2 val) { GetField(val); return val; }
    public bool IsSet(LastForwardPoints2 val) { return IsSetLastForwardPoints2(); }
    public bool IsSetLastForwardPoints2() { return IsSetField(Tags.LastForwardPoints2); }

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

    public ExecValuationPoint ExecValuationPoint
    {
        get
        {
            ExecValuationPoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecValuationPoint val) { ExecValuationPoint = val; }
    public ExecValuationPoint Get(ExecValuationPoint val) { GetField(val); return val; }
    public bool IsSet(ExecValuationPoint val) { return IsSetExecValuationPoint(); }
    public bool IsSetExecValuationPoint() { return IsSetField(Tags.ExecValuationPoint); }

    public ExecPriceType ExecPriceType
    {
        get
        {
            ExecPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecPriceType val) { ExecPriceType = val; }
    public ExecPriceType Get(ExecPriceType val) { GetField(val); return val; }
    public bool IsSet(ExecPriceType val) { return IsSetExecPriceType(); }
    public bool IsSetExecPriceType() { return IsSetField(Tags.ExecPriceType); }

    public ExecPriceAdjustment ExecPriceAdjustment
    {
        get
        {
            ExecPriceAdjustment val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecPriceAdjustment val) { ExecPriceAdjustment = val; }
    public ExecPriceAdjustment Get(ExecPriceAdjustment val) { GetField(val); return val; }
    public bool IsSet(ExecPriceAdjustment val) { return IsSetExecPriceAdjustment(); }
    public bool IsSetExecPriceAdjustment() { return IsSetField(Tags.ExecPriceAdjustment); }

    public PriorityIndicator PriorityIndicator
    {
        get
        {
            PriorityIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriorityIndicator val) { PriorityIndicator = val; }
    public PriorityIndicator Get(PriorityIndicator val) { GetField(val); return val; }
    public bool IsSet(PriorityIndicator val) { return IsSetPriorityIndicator(); }
    public bool IsSetPriorityIndicator() { return IsSetField(Tags.PriorityIndicator); }

    public PriceImprovement PriceImprovement
    {
        get
        {
            PriceImprovement val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceImprovement val) { PriceImprovement = val; }
    public PriceImprovement Get(PriceImprovement val) { GetField(val); return val; }
    public bool IsSet(PriceImprovement val) { return IsSetPriceImprovement(); }
    public bool IsSetPriceImprovement() { return IsSetField(Tags.PriceImprovement); }

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

    public HostCrossID HostCrossID
    {
        get
        {
            HostCrossID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HostCrossID val) { HostCrossID = val; }
    public HostCrossID Get(HostCrossID val) { GetField(val); return val; }
    public bool IsSet(HostCrossID val) { return IsSetHostCrossID(); }
    public bool IsSetHostCrossID() { return IsSetField(Tags.HostCrossID); }

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

    public AggressorIndicator AggressorIndicator
    {
        get
        {
            AggressorIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AggressorIndicator val) { AggressorIndicator = val; }
    public AggressorIndicator Get(AggressorIndicator val) { GetField(val); return val; }
    public bool IsSet(AggressorIndicator val) { return IsSetAggressorIndicator(); }
    public bool IsSetAggressorIndicator() { return IsSetField(Tags.AggressorIndicator); }

    public CalculatedCcyLastQty CalculatedCcyLastQty
    {
        get
        {
            CalculatedCcyLastQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CalculatedCcyLastQty val) { CalculatedCcyLastQty = val; }
    public CalculatedCcyLastQty Get(CalculatedCcyLastQty val) { GetField(val); return val; }
    public bool IsSet(CalculatedCcyLastQty val) { return IsSetCalculatedCcyLastQty(); }
    public bool IsSetCalculatedCcyLastQty() { return IsSetField(Tags.CalculatedCcyLastQty); }

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

    public OrderCategory OrderCategory
    {
        get
        {
            OrderCategory val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderCategory val) { OrderCategory = val; }
    public OrderCategory Get(OrderCategory val) { GetField(val); return val; }
    public bool IsSet(OrderCategory val) { return IsSetOrderCategory(); }
    public bool IsSetOrderCategory() { return IsSetField(Tags.OrderCategory); }

    public LotType LotType
    {
        get
        {
            LotType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LotType val) { LotType = val; }
    public LotType Get(LotType val) { GetField(val); return val; }
    public bool IsSet(LotType val) { return IsSetLotType(); }
    public bool IsSetLotType() { return IsSetField(Tags.LotType); }

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

    public PeggedRefPrice PeggedRefPrice
    {
        get
        {
            PeggedRefPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PeggedRefPrice val) { PeggedRefPrice = val; }
    public PeggedRefPrice Get(PeggedRefPrice val) { GetField(val); return val; }
    public bool IsSet(PeggedRefPrice val) { return IsSetPeggedRefPrice(); }
    public bool IsSetPeggedRefPrice() { return IsSetField(Tags.PeggedRefPrice); }

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

    public Volatility Volatility
    {
        get
        {
            Volatility val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Volatility val) { Volatility = val; }
    public Volatility Get(Volatility val) { GetField(val); return val; }
    public bool IsSet(Volatility val) { return IsSetVolatility(); }
    public bool IsSetVolatility() { return IsSetField(Tags.Volatility); }

    public TimeToExpiration TimeToExpiration
    {
        get
        {
            TimeToExpiration val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TimeToExpiration val) { TimeToExpiration = val; }
    public TimeToExpiration Get(TimeToExpiration val) { GetField(val); return val; }
    public bool IsSet(TimeToExpiration val) { return IsSetTimeToExpiration(); }
    public bool IsSetTimeToExpiration() { return IsSetField(Tags.TimeToExpiration); }

    public RiskFreeRate RiskFreeRate
    {
        get
        {
            RiskFreeRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RiskFreeRate val) { RiskFreeRate = val; }
    public RiskFreeRate Get(RiskFreeRate val) { GetField(val); return val; }
    public bool IsSet(RiskFreeRate val) { return IsSetRiskFreeRate(); }
    public bool IsSetRiskFreeRate() { return IsSetField(Tags.RiskFreeRate); }

    public PriceDelta PriceDelta
    {
        get
        {
            PriceDelta val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceDelta val) { PriceDelta = val; }
    public PriceDelta Get(PriceDelta val) { GetField(val); return val; }
    public bool IsSet(PriceDelta val) { return IsSetPriceDelta(); }
    public bool IsSetPriceDelta() { return IsSetField(Tags.PriceDelta); }

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

    public TotNoFills TotNoFills
    {
        get
        {
            TotNoFills val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNoFills val) { TotNoFills = val; }
    public TotNoFills Get(TotNoFills val) { GetField(val); return val; }
    public bool IsSet(TotNoFills val) { return IsSetTotNoFills(); }
    public bool IsSetTotNoFills() { return IsSetField(Tags.TotNoFills); }

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

    public NoFills NoFills
    {
        get
        {
            NoFills val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoFills val) { NoFills = val; }
    public NoFills Get(NoFills val) { GetField(val); return val; }
    public bool IsSet(NoFills val) { return IsSetNoFills(); }
    public bool IsSetNoFills() { return IsSetField(Tags.NoFills); }

    public DividendYield DividendYield
    {
        get
        {
            DividendYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DividendYield val) { DividendYield = val; }
    public DividendYield Get(DividendYield val) { GetField(val); return val; }
    public bool IsSet(DividendYield val) { return IsSetDividendYield(); }
    public bool IsSetDividendYield() { return IsSetField(Tags.DividendYield); }

    public ApplID ApplID
    {
        get
        {
            ApplID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplID val) { ApplID = val; }
    public ApplID Get(ApplID val) { GetField(val); return val; }
    public bool IsSet(ApplID val) { return IsSetApplID(); }
    public bool IsSetApplID() { return IsSetField(Tags.ApplID); }

    public ApplSeqNum ApplSeqNum
    {
        get
        {
            ApplSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplSeqNum val) { ApplSeqNum = val; }
    public ApplSeqNum Get(ApplSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplSeqNum val) { return IsSetApplSeqNum(); }
    public bool IsSetApplSeqNum() { return IsSetField(Tags.ApplSeqNum); }

    public ApplLastSeqNum ApplLastSeqNum
    {
        get
        {
            ApplLastSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplLastSeqNum val) { ApplLastSeqNum = val; }
    public ApplLastSeqNum Get(ApplLastSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplLastSeqNum val) { return IsSetApplLastSeqNum(); }
    public bool IsSetApplLastSeqNum() { return IsSetField(Tags.ApplLastSeqNum); }

    public ApplResendFlag ApplResendFlag
    {
        get
        {
            ApplResendFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResendFlag val) { ApplResendFlag = val; }
    public ApplResendFlag Get(ApplResendFlag val) { GetField(val); return val; }
    public bool IsSet(ApplResendFlag val) { return IsSetApplResendFlag(); }
    public bool IsSetApplResendFlag() { return IsSetField(Tags.ApplResendFlag); }

    public NoRateSources NoRateSources
    {
        get
        {
            NoRateSources val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRateSources val) { NoRateSources = val; }
    public NoRateSources Get(NoRateSources val) { GetField(val); return val; }
    public bool IsSet(NoRateSources val) { return IsSetNoRateSources(); }
    public bool IsSetNoRateSources() { return IsSetField(Tags.NoRateSources); }

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

    public ExecTypeReason ExecTypeReason
    {
        get
        {
            ExecTypeReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecTypeReason val) { ExecTypeReason = val; }
    public ExecTypeReason Get(ExecTypeReason val) { GetField(val); return val; }
    public bool IsSet(ExecTypeReason val) { return IsSetExecTypeReason(); }
    public bool IsSetExecTypeReason() { return IsSetField(Tags.ExecTypeReason); }

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

    public RegulatoryTransactionType RegulatoryTransactionType
    {
        get
        {
            RegulatoryTransactionType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegulatoryTransactionType val) { RegulatoryTransactionType = val; }
    public RegulatoryTransactionType Get(RegulatoryTransactionType val) { GetField(val); return val; }
    public bool IsSet(RegulatoryTransactionType val) { return IsSetRegulatoryTransactionType(); }
    public bool IsSetRegulatoryTransactionType() { return IsSetField(Tags.RegulatoryTransactionType); }

    public NoRegulatoryTradeIDs NoRegulatoryTradeIDs
    {
        get
        {
            NoRegulatoryTradeIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRegulatoryTradeIDs val) { NoRegulatoryTradeIDs = val; }
    public NoRegulatoryTradeIDs Get(NoRegulatoryTradeIDs val) { GetField(val); return val; }
    public bool IsSet(NoRegulatoryTradeIDs val) { return IsSetNoRegulatoryTradeIDs(); }
    public bool IsSetNoRegulatoryTradeIDs() { return IsSetField(Tags.NoRegulatoryTradeIDs); }

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

    public DeliveryForm DeliveryForm
    {
        get
        {
            DeliveryForm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DeliveryForm val) { DeliveryForm = val; }
    public DeliveryForm Get(DeliveryForm val) { GetField(val); return val; }
    public bool IsSet(DeliveryForm val) { return IsSetDeliveryForm(); }
    public bool IsSetDeliveryForm() { return IsSetField(Tags.DeliveryForm); }

    public PctAtRisk PctAtRisk
    {
        get
        {
            PctAtRisk val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PctAtRisk val) { PctAtRisk = val; }
    public PctAtRisk Get(PctAtRisk val) { GetField(val); return val; }
    public bool IsSet(PctAtRisk val) { return IsSetPctAtRisk(); }
    public bool IsSetPctAtRisk() { return IsSetField(Tags.PctAtRisk); }

    public NoInstrAttrib NoInstrAttrib
    {
        get
        {
            NoInstrAttrib val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoInstrAttrib val) { NoInstrAttrib = val; }
    public NoInstrAttrib Get(NoInstrAttrib val) { GetField(val); return val; }
    public bool IsSet(NoInstrAttrib val) { return IsSetNoInstrAttrib(); }
    public bool IsSetNoInstrAttrib() { return IsSetField(Tags.NoInstrAttrib); }

    public FloatingRateIndex FloatingRateIndex
    {
        get
        {
            FloatingRateIndex val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FloatingRateIndex val) { FloatingRateIndex = val; }
    public FloatingRateIndex Get(FloatingRateIndex val) { GetField(val); return val; }
    public bool IsSet(FloatingRateIndex val) { return IsSetFloatingRateIndex(); }
    public bool IsSetFloatingRateIndex() { return IsSetField(Tags.FloatingRateIndex); }

    public FloatingRateIndexCurvePeriod FloatingRateIndexCurvePeriod
    {
        get
        {
            FloatingRateIndexCurvePeriod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FloatingRateIndexCurvePeriod val) { FloatingRateIndexCurvePeriod = val; }
    public FloatingRateIndexCurvePeriod Get(FloatingRateIndexCurvePeriod val) { GetField(val); return val; }
    public bool IsSet(FloatingRateIndexCurvePeriod val) { return IsSetFloatingRateIndexCurvePeriod(); }
    public bool IsSetFloatingRateIndexCurvePeriod() { return IsSetField(Tags.FloatingRateIndexCurvePeriod); }

    public FloatingRateIndexCurveUnit FloatingRateIndexCurveUnit
    {
        get
        {
            FloatingRateIndexCurveUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FloatingRateIndexCurveUnit val) { FloatingRateIndexCurveUnit = val; }
    public FloatingRateIndexCurveUnit Get(FloatingRateIndexCurveUnit val) { GetField(val); return val; }
    public bool IsSet(FloatingRateIndexCurveUnit val) { return IsSetFloatingRateIndexCurveUnit(); }
    public bool IsSetFloatingRateIndexCurveUnit() { return IsSetField(Tags.FloatingRateIndexCurveUnit); }

    public FloatingRateIndexCurveSpread FloatingRateIndexCurveSpread
    {
        get
        {
            FloatingRateIndexCurveSpread val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FloatingRateIndexCurveSpread val) { FloatingRateIndexCurveSpread = val; }
    public FloatingRateIndexCurveSpread Get(FloatingRateIndexCurveSpread val) { GetField(val); return val; }
    public bool IsSet(FloatingRateIndexCurveSpread val) { return IsSetFloatingRateIndexCurveSpread(); }
    public bool IsSetFloatingRateIndexCurveSpread() { return IsSetField(Tags.FloatingRateIndexCurveSpread); }

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

    public LastQtyVariance LastQtyVariance
    {
        get
        {
            LastQtyVariance val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastQtyVariance val) { LastQtyVariance = val; }
    public LastQtyVariance Get(LastQtyVariance val) { GetField(val); return val; }
    public bool IsSet(LastQtyVariance val) { return IsSetLastQtyVariance(); }
    public bool IsSetLastQtyVariance() { return IsSetField(Tags.LastQtyVariance); }

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

    public VenueType VenueType
    {
        get
        {
            VenueType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(VenueType val) { VenueType = val; }
    public VenueType Get(VenueType val) { GetField(val); return val; }
    public bool IsSet(VenueType val) { return IsSetVenueType(); }
    public bool IsSetVenueType() { return IsSetField(Tags.VenueType); }

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

    public NoRelativeValues NoRelativeValues
    {
        get
        {
            NoRelativeValues val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRelativeValues val) { NoRelativeValues = val; }
    public NoRelativeValues Get(NoRelativeValues val) { GetField(val); return val; }
    public bool IsSet(NoRelativeValues val) { return IsSetNoRelativeValues(); }
    public bool IsSetNoRelativeValues() { return IsSetField(Tags.NoRelativeValues); }

    public OrderOrigination OrderOrigination
    {
        get
        {
            OrderOrigination val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderOrigination val) { OrderOrigination = val; }
    public OrderOrigination Get(OrderOrigination val) { GetField(val); return val; }
    public bool IsSet(OrderOrigination val) { return IsSetOrderOrigination(); }
    public bool IsSetOrderOrigination() { return IsSetField(Tags.OrderOrigination); }

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

    public NoTradePriceConditions NoTradePriceConditions
    {
        get
        {
            NoTradePriceConditions val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTradePriceConditions val) { NoTradePriceConditions = val; }
    public NoTradePriceConditions Get(NoTradePriceConditions val) { GetField(val); return val; }
    public bool IsSet(NoTradePriceConditions val) { return IsSetNoTradePriceConditions(); }
    public bool IsSetNoTradePriceConditions() { return IsSetField(Tags.NoTradePriceConditions); }

    public CoverPrice CoverPrice
    {
        get
        {
            CoverPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CoverPrice val) { CoverPrice = val; }
    public CoverPrice Get(CoverPrice val) { GetField(val); return val; }
    public bool IsSet(CoverPrice val) { return IsSetCoverPrice(); }
    public bool IsSetCoverPrice() { return IsSetField(Tags.CoverPrice); }

    public AuctionType AuctionType
    {
        get
        {
            AuctionType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AuctionType val) { AuctionType = val; }
    public AuctionType Get(AuctionType val) { GetField(val); return val; }
    public bool IsSet(AuctionType val) { return IsSetAuctionType(); }
    public bool IsSetAuctionType() { return IsSetField(Tags.AuctionType); }

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

    public SettlDeliveryType SettlDeliveryType
    {
        get
        {
            SettlDeliveryType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlDeliveryType val) { SettlDeliveryType = val; }
    public SettlDeliveryType Get(SettlDeliveryType val) { GetField(val); return val; }
    public bool IsSet(SettlDeliveryType val) { return IsSetSettlDeliveryType(); }
    public bool IsSetSettlDeliveryType() { return IsSetField(Tags.SettlDeliveryType); }

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

    public TradeCondition TradeCondition
    {
        get
        {
            TradeCondition val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeCondition val) { TradeCondition = val; }
    public TradeCondition Get(TradeCondition val) { GetField(val); return val; }
    public bool IsSet(TradeCondition val) { return IsSetTradeCondition(); }
    public bool IsSetTradeCondition() { return IsSetField(Tags.TradeCondition); }

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

    public AsOfIndicator AsOfIndicator
    {
        get
        {
            AsOfIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AsOfIndicator val) { AsOfIndicator = val; }
    public AsOfIndicator Get(AsOfIndicator val) { GetField(val); return val; }
    public bool IsSet(AsOfIndicator val) { return IsSetAsOfIndicator(); }
    public bool IsSetAsOfIndicator() { return IsSetField(Tags.AsOfIndicator); }

    public SecondaryTradeID SecondaryTradeID
    {
        get
        {
            SecondaryTradeID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryTradeID val) { SecondaryTradeID = val; }
    public SecondaryTradeID Get(SecondaryTradeID val) { GetField(val); return val; }
    public bool IsSet(SecondaryTradeID val) { return IsSetSecondaryTradeID(); }
    public bool IsSetSecondaryTradeID() { return IsSetField(Tags.SecondaryTradeID); }

    public TZTransactTime TZTransactTime
    {
        get
        {
            TZTransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TZTransactTime val) { TZTransactTime = val; }
    public TZTransactTime Get(TZTransactTime val) { GetField(val); return val; }
    public bool IsSet(TZTransactTime val) { return IsSetTZTransactTime(); }
    public bool IsSetTZTransactTime() { return IsSetField(Tags.TZTransactTime); }

    public ClearedIndicator ClearedIndicator
    {
        get
        {
            ClearedIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClearedIndicator val) { ClearedIndicator = val; }
    public ClearedIndicator Get(ClearedIndicator val) { GetField(val); return val; }
    public bool IsSet(ClearedIndicator val) { return IsSetClearedIndicator(); }
    public bool IsSetClearedIndicator() { return IsSetField(Tags.ClearedIndicator); }

    public NumOfCompetitors NumOfCompetitors
    {
        get
        {
            NumOfCompetitors val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NumOfCompetitors val) { NumOfCompetitors = val; }
    public NumOfCompetitors Get(NumOfCompetitors val) { GetField(val); return val; }
    public bool IsSet(NumOfCompetitors val) { return IsSetNumOfCompetitors(); }
    public bool IsSetNumOfCompetitors() { return IsSetField(Tags.NumOfCompetitors); }

    public MandatoryClearingIndicator MandatoryClearingIndicator
    {
        get
        {
            MandatoryClearingIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MandatoryClearingIndicator val) { MandatoryClearingIndicator = val; }
    public MandatoryClearingIndicator Get(MandatoryClearingIndicator val) { GetField(val); return val; }
    public bool IsSet(MandatoryClearingIndicator val) { return IsSetMandatoryClearingIndicator(); }
    public bool IsSetMandatoryClearingIndicator() { return IsSetField(Tags.MandatoryClearingIndicator); }

    public RegulatoryReportType RegulatoryReportType
    {
        get
        {
            RegulatoryReportType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegulatoryReportType val) { RegulatoryReportType = val; }
    public RegulatoryReportType Get(RegulatoryReportType val) { GetField(val); return val; }
    public bool IsSet(RegulatoryReportType val) { return IsSetRegulatoryReportType(); }
    public bool IsSetRegulatoryReportType() { return IsSetField(Tags.RegulatoryReportType); }

    public TradeCollateralization TradeCollateralization
    {
        get
        {
            TradeCollateralization val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeCollateralization val) { TradeCollateralization = val; }
    public TradeCollateralization Get(TradeCollateralization val) { GetField(val); return val; }
    public bool IsSet(TradeCollateralization val) { return IsSetTradeCollateralization(); }
    public bool IsSetTradeCollateralization() { return IsSetField(Tags.TradeCollateralization); }

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

    public BlockTrdAllocIndicator BlockTrdAllocIndicator
    {
        get
        {
            BlockTrdAllocIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BlockTrdAllocIndicator val) { BlockTrdAllocIndicator = val; }
    public BlockTrdAllocIndicator Get(BlockTrdAllocIndicator val) { GetField(val); return val; }
    public bool IsSet(BlockTrdAllocIndicator val) { return IsSetBlockTrdAllocIndicator(); }
    public bool IsSetBlockTrdAllocIndicator() { return IsSetField(Tags.BlockTrdAllocIndicator); }

    public RiskLimitCheckStatus RiskLimitCheckStatus
    {
        get
        {
            RiskLimitCheckStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RiskLimitCheckStatus val) { RiskLimitCheckStatus = val; }
    public RiskLimitCheckStatus Get(RiskLimitCheckStatus val) { GetField(val); return val; }
    public bool IsSet(RiskLimitCheckStatus val) { return IsSetRiskLimitCheckStatus(); }
    public bool IsSetRiskLimitCheckStatus() { return IsSetField(Tags.RiskLimitCheckStatus); }

    public PricePrecision PricePrecision
    {
        get
        {
            PricePrecision val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PricePrecision val) { PricePrecision = val; }
    public PricePrecision Get(PricePrecision val) { GetField(val); return val; }
    public bool IsSet(PricePrecision val) { return IsSetPricePrecision(); }
    public bool IsSetPricePrecision() { return IsSetField(Tags.PricePrecision); }

    public ExecMethod ExecMethod
    {
        get
        {
            ExecMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecMethod val) { ExecMethod = val; }
    public ExecMethod Get(ExecMethod val) { GetField(val); return val; }
    public bool IsSet(ExecMethod val) { return IsSetExecMethod(); }
    public bool IsSetExecMethod() { return IsSetField(Tags.ExecMethod); }

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

    public NoRelatedInstruments NoRelatedInstruments
    {
        get
        {
            NoRelatedInstruments val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRelatedInstruments val) { NoRelatedInstruments = val; }
    public NoRelatedInstruments Get(NoRelatedInstruments val) { GetField(val); return val; }
    public bool IsSet(NoRelatedInstruments val) { return IsSetNoRelatedInstruments(); }
    public bool IsSetNoRelatedInstruments() { return IsSetField(Tags.NoRelatedInstruments); }

    public PremiumDeliveryDate PremiumDeliveryDate
    {
        get
        {
            PremiumDeliveryDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PremiumDeliveryDate val) { PremiumDeliveryDate = val; }
    public PremiumDeliveryDate Get(PremiumDeliveryDate val) { GetField(val); return val; }
    public bool IsSet(PremiumDeliveryDate val) { return IsSetPremiumDeliveryDate(); }
    public bool IsSetPremiumDeliveryDate() { return IsSetField(Tags.PremiumDeliveryDate); }

    public CircleInd CircleInd
    {
        get
        {
            CircleInd val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CircleInd val) { CircleInd = val; }
    public CircleInd Get(CircleInd val) { GetField(val); return val; }
    public bool IsSet(CircleInd val) { return IsSetCircleInd(); }
    public bool IsSetCircleInd() { return IsSetField(Tags.CircleInd); }

    public OriginalQty OriginalQty
    {
        get
        {
            OriginalQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OriginalQty val) { OriginalQty = val; }
    public OriginalQty Get(OriginalQty val) { GetField(val); return val; }
    public bool IsSet(OriginalQty val) { return IsSetOriginalQty(); }
    public bool IsSetOriginalQty() { return IsSetField(Tags.OriginalQty); }

    public BasketID BasketID
    {
        get
        {
            BasketID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BasketID val) { BasketID = val; }
    public BasketID Get(BasketID val) { GetField(val); return val; }
    public bool IsSet(BasketID val) { return IsSetBasketID(); }
    public bool IsSetBasketID() { return IsSetField(Tags.BasketID); }

    public TradingModelType TradingModelType
    {
        get
        {
            TradingModelType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingModelType val) { TradingModelType = val; }
    public TradingModelType Get(TradingModelType val) { GetField(val); return val; }
    public bool IsSet(TradingModelType val) { return IsSetTradingModelType(); }
    public bool IsSetTradingModelType() { return IsSetField(Tags.TradingModelType); }

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

    public AllocationIndicator AllocationIndicator
    {
        get
        {
            AllocationIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocationIndicator val) { AllocationIndicator = val; }
    public AllocationIndicator Get(AllocationIndicator val) { GetField(val); return val; }
    public bool IsSet(AllocationIndicator val) { return IsSetAllocationIndicator(); }
    public bool IsSetAllocationIndicator() { return IsSetField(Tags.AllocationIndicator); }

    public SalesBook SalesBook
    {
        get
        {
            SalesBook val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SalesBook val) { SalesBook = val; }
    public SalesBook Get(SalesBook val) { GetField(val); return val; }
    public bool IsSet(SalesBook val) { return IsSetSalesBook(); }
    public bool IsSetSalesBook() { return IsSetField(Tags.SalesBook); }

    public TradeCorrectType TradeCorrectType
    {
        get
        {
            TradeCorrectType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeCorrectType val) { TradeCorrectType = val; }
    public TradeCorrectType Get(TradeCorrectType val) { GetField(val); return val; }
    public bool IsSet(TradeCorrectType val) { return IsSetTradeCorrectType(); }
    public bool IsSetTradeCorrectType() { return IsSetField(Tags.TradeCorrectType); }

    public CurrentFace CurrentFace
    {
        get
        {
            CurrentFace val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CurrentFace val) { CurrentFace = val; }
    public CurrentFace Get(CurrentFace val) { GetField(val); return val; }
    public bool IsSet(CurrentFace val) { return IsSetCurrentFace(); }
    public bool IsSetCurrentFace() { return IsSetField(Tags.CurrentFace); }

    public SettlCurrAccruedInterestAmt SettlCurrAccruedInterestAmt
    {
        get
        {
            SettlCurrAccruedInterestAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrAccruedInterestAmt val) { SettlCurrAccruedInterestAmt = val; }
    public SettlCurrAccruedInterestAmt Get(SettlCurrAccruedInterestAmt val) { GetField(val); return val; }
    public bool IsSet(SettlCurrAccruedInterestAmt val) { return IsSetSettlCurrAccruedInterestAmt(); }
    public bool IsSetSettlCurrAccruedInterestAmt() { return IsSetField(Tags.SettlCurrAccruedInterestAmt); }

    public SettlCurrNetMoney SettlCurrNetMoney
    {
        get
        {
            SettlCurrNetMoney val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrNetMoney val) { SettlCurrNetMoney = val; }
    public SettlCurrNetMoney Get(SettlCurrNetMoney val) { GetField(val); return val; }
    public bool IsSet(SettlCurrNetMoney val) { return IsSetSettlCurrNetMoney(); }
    public bool IsSetSettlCurrNetMoney() { return IsSetField(Tags.SettlCurrNetMoney); }

    public PremiumCurrency PremiumCurrency
    {
        get
        {
            PremiumCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PremiumCurrency val) { PremiumCurrency = val; }
    public PremiumCurrency Get(PremiumCurrency val) { GetField(val); return val; }
    public bool IsSet(PremiumCurrency val) { return IsSetPremiumCurrency(); }
    public bool IsSetPremiumCurrency() { return IsSetField(Tags.PremiumCurrency); }

    public NetPremiumAmount NetPremiumAmount
    {
        get
        {
            NetPremiumAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NetPremiumAmount val) { NetPremiumAmount = val; }
    public NetPremiumAmount Get(NetPremiumAmount val) { GetField(val); return val; }
    public bool IsSet(NetPremiumAmount val) { return IsSetNetPremiumAmount(); }
    public bool IsSetNetPremiumAmount() { return IsSetField(Tags.NetPremiumAmount); }

    public OrderLinkID OrderLinkID
    {
        get
        {
            OrderLinkID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderLinkID val) { OrderLinkID = val; }
    public OrderLinkID Get(OrderLinkID val) { GetField(val); return val; }
    public bool IsSet(OrderLinkID val) { return IsSetOrderLinkID(); }
    public bool IsSetOrderLinkID() { return IsSetField(Tags.OrderLinkID); }

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

    public AdjustedEndCash AdjustedEndCash
    {
        get
        {
            AdjustedEndCash val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AdjustedEndCash val) { AdjustedEndCash = val; }
    public AdjustedEndCash Get(AdjustedEndCash val) { GetField(val); return val; }
    public bool IsSet(AdjustedEndCash val) { return IsSetAdjustedEndCash(); }
    public bool IsSetAdjustedEndCash() { return IsSetField(Tags.AdjustedEndCash); }

    public HedgeDirection HedgeDirection
    {
        get
        {
            HedgeDirection val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeDirection val) { HedgeDirection = val; }
    public HedgeDirection Get(HedgeDirection val) { GetField(val); return val; }
    public bool IsSet(HedgeDirection val) { return IsSetHedgeDirection(); }
    public bool IsSetHedgeDirection() { return IsSetField(Tags.HedgeDirection); }

    public MultilegPartNum MultilegPartNum
    {
        get
        {
            MultilegPartNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MultilegPartNum val) { MultilegPartNum = val; }
    public MultilegPartNum Get(MultilegPartNum val) { GetField(val); return val; }
    public bool IsSet(MultilegPartNum val) { return IsSetMultilegPartNum(); }
    public bool IsSetMultilegPartNum() { return IsSetField(Tags.MultilegPartNum); }

    public ActionType ActionType
    {
        get
        {
            ActionType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ActionType val) { ActionType = val; }
    public ActionType Get(ActionType val) { GetField(val); return val; }
    public bool IsSet(ActionType val) { return IsSetActionType(); }
    public bool IsSetActionType() { return IsSetField(Tags.ActionType); }

    public RecipientRole RecipientRole
    {
        get
        {
            RecipientRole val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RecipientRole val) { RecipientRole = val; }
    public RecipientRole Get(RecipientRole val) { GetField(val); return val; }
    public bool IsSet(RecipientRole val) { return IsSetRecipientRole(); }
    public bool IsSetRecipientRole() { return IsSetField(Tags.RecipientRole); }

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

    public HedgeRate HedgeRate
    {
        get
        {
            HedgeRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeRate val) { HedgeRate = val; }
    public HedgeRate Get(HedgeRate val) { GetField(val); return val; }
    public bool IsSet(HedgeRate val) { return IsSetHedgeRate(); }
    public bool IsSetHedgeRate() { return IsSetField(Tags.HedgeRate); }

    public ExecDeltaHedge ExecDeltaHedge
    {
        get
        {
            ExecDeltaHedge val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecDeltaHedge val) { ExecDeltaHedge = val; }
    public ExecDeltaHedge Get(ExecDeltaHedge val) { GetField(val); return val; }
    public bool IsSet(ExecDeltaHedge val) { return IsSetExecDeltaHedge(); }
    public bool IsSetExecDeltaHedge() { return IsSetField(Tags.ExecDeltaHedge); }

    public HedgeTradeType HedgeTradeType
    {
        get
        {
            HedgeTradeType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeTradeType val) { HedgeTradeType = val; }
    public HedgeTradeType Get(HedgeTradeType val) { GetField(val); return val; }
    public bool IsSet(HedgeTradeType val) { return IsSetHedgeTradeType(); }
    public bool IsSetHedgeTradeType() { return IsSetField(Tags.HedgeTradeType); }

    public MarketType MarketType
    {
        get
        {
            MarketType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketType val) { MarketType = val; }
    public MarketType Get(MarketType val) { GetField(val); return val; }
    public bool IsSet(MarketType val) { return IsSetMarketType(); }
    public bool IsSetMarketType() { return IsSetField(Tags.MarketType); }

    public HedgeDate HedgeDate
    {
        get
        {
            HedgeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeDate val) { HedgeDate = val; }
    public HedgeDate Get(HedgeDate val) { GetField(val); return val; }
    public bool IsSet(HedgeDate val) { return IsSetHedgeDate(); }
    public bool IsSetHedgeDate() { return IsSetField(Tags.HedgeDate); }

    public HedgeAmount HedgeAmount
    {
        get
        {
            HedgeAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeAmount val) { HedgeAmount = val; }
    public HedgeAmount Get(HedgeAmount val) { GetField(val); return val; }
    public bool IsSet(HedgeAmount val) { return IsSetHedgeAmount(); }
    public bool IsSetHedgeAmount() { return IsSetField(Tags.HedgeAmount); }

    public FlatFlag FlatFlag
    {
        get
        {
            FlatFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FlatFlag val) { FlatFlag = val; }
    public FlatFlag Get(FlatFlag val) { GetField(val); return val; }
    public bool IsSet(FlatFlag val) { return IsSetFlatFlag(); }
    public bool IsSetFlatFlag() { return IsSetField(Tags.FlatFlag); }

    public TraderBook TraderBook
    {
        get
        {
            TraderBook val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TraderBook val) { TraderBook = val; }
    public TraderBook Get(TraderBook val) { GetField(val); return val; }
    public bool IsSet(TraderBook val) { return IsSetTraderBook(); }
    public bool IsSetTraderBook() { return IsSetField(Tags.TraderBook); }

    public SwapTradeType SwapTradeType
    {
        get
        {
            SwapTradeType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SwapTradeType val) { SwapTradeType = val; }
    public SwapTradeType Get(SwapTradeType val) { GetField(val); return val; }
    public bool IsSet(SwapTradeType val) { return IsSetSwapTradeType(); }
    public bool IsSetSwapTradeType() { return IsSetField(Tags.SwapTradeType); }

    public PricingNo PricingNo
    {
        get
        {
            PricingNo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PricingNo val) { PricingNo = val; }
    public PricingNo Get(PricingNo val) { GetField(val); return val; }
    public bool IsSet(PricingNo val) { return IsSetPricingNo(); }
    public bool IsSetPricingNo() { return IsSetField(Tags.PricingNo); }

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

    public Application Application
    {
        get
        {
            Application val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Application val) { Application = val; }
    public Application Get(Application val) { GetField(val); return val; }
    public bool IsSet(Application val) { return IsSetApplication(); }
    public bool IsSetApplication() { return IsSetField(Tags.Application); }

    public HedgeCalcType HedgeCalcType
    {
        get
        {
            HedgeCalcType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeCalcType val) { HedgeCalcType = val; }
    public HedgeCalcType Get(HedgeCalcType val) { GetField(val); return val; }
    public bool IsSet(HedgeCalcType val) { return IsSetHedgeCalcType(); }
    public bool IsSetHedgeCalcType() { return IsSetField(Tags.HedgeCalcType); }

    public DV01 DV01
    {
        get
        {
            DV01 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DV01 val) { DV01 = val; }
    public DV01 Get(DV01 val) { GetField(val); return val; }
    public bool IsSet(DV01 val) { return IsSetDV01(); }
    public bool IsSetDV01() { return IsSetField(Tags.DV01); }

    public LastMidPrice LastMidPrice
    {
        get
        {
            LastMidPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastMidPrice val) { LastMidPrice = val; }
    public LastMidPrice Get(LastMidPrice val) { GetField(val); return val; }
    public bool IsSet(LastMidPrice val) { return IsSetLastMidPrice(); }
    public bool IsSetLastMidPrice() { return IsSetField(Tags.LastMidPrice); }

    public MidPriceType MidPriceType
    {
        get
        {
            MidPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MidPriceType val) { MidPriceType = val; }
    public MidPriceType Get(MidPriceType val) { GetField(val); return val; }
    public bool IsSet(MidPriceType val) { return IsSetMidPriceType(); }
    public bool IsSetMidPriceType() { return IsSetField(Tags.MidPriceType); }

    public SalesCredit SalesCredit
    {
        get
        {
            SalesCredit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SalesCredit val) { SalesCredit = val; }
    public SalesCredit Get(SalesCredit val) { GetField(val); return val; }
    public bool IsSet(SalesCredit val) { return IsSetSalesCredit(); }
    public bool IsSetSalesCredit() { return IsSetField(Tags.SalesCredit); }

    public SettlCurrGrossTradeAmt SettlCurrGrossTradeAmt
    {
        get
        {
            SettlCurrGrossTradeAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrGrossTradeAmt val) { SettlCurrGrossTradeAmt = val; }
    public SettlCurrGrossTradeAmt Get(SettlCurrGrossTradeAmt val) { GetField(val); return val; }
    public bool IsSet(SettlCurrGrossTradeAmt val) { return IsSetSettlCurrGrossTradeAmt(); }
    public bool IsSetSettlCurrGrossTradeAmt() { return IsSetField(Tags.SettlCurrGrossTradeAmt); }

    public SettlCurrAccruedInterestAmount SettlCurrAccruedInterestAmount
    {
        get
        {
            SettlCurrAccruedInterestAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrAccruedInterestAmount val) { SettlCurrAccruedInterestAmount = val; }
    public SettlCurrAccruedInterestAmount Get(SettlCurrAccruedInterestAmount val) { GetField(val); return val; }
    public bool IsSet(SettlCurrAccruedInterestAmount val) { return IsSetSettlCurrAccruedInterestAmount(); }
    public bool IsSetSettlCurrAccruedInterestAmount() { return IsSetField(Tags.SettlCurrAccruedInterestAmount); }

    public MadeAvailableForTradingIndicator MadeAvailableForTradingIndicator
    {
        get
        {
            MadeAvailableForTradingIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MadeAvailableForTradingIndicator val) { MadeAvailableForTradingIndicator = val; }
    public MadeAvailableForTradingIndicator Get(MadeAvailableForTradingIndicator val) { GetField(val); return val; }
    public bool IsSet(MadeAvailableForTradingIndicator val) { return IsSetMadeAvailableForTradingIndicator(); }
    public bool IsSetMadeAvailableForTradingIndicator() { return IsSetField(Tags.MadeAvailableForTradingIndicator); }

    public PreFactoredPrice PreFactoredPrice
    {
        get
        {
            PreFactoredPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PreFactoredPrice val) { PreFactoredPrice = val; }
    public PreFactoredPrice Get(PreFactoredPrice val) { GetField(val); return val; }
    public bool IsSet(PreFactoredPrice val) { return IsSetPreFactoredPrice(); }
    public bool IsSetPreFactoredPrice() { return IsSetField(Tags.PreFactoredPrice); }

    public CoverQuantity CoverQuantity
    {
        get
        {
            CoverQuantity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CoverQuantity val) { CoverQuantity = val; }
    public CoverQuantity Get(CoverQuantity val) { GetField(val); return val; }
    public bool IsSet(CoverQuantity val) { return IsSetCoverQuantity(); }
    public bool IsSetCoverQuantity() { return IsSetField(Tags.CoverQuantity); }

    public TypeOfPrice TypeOfPrice
    {
        get
        {
            TypeOfPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TypeOfPrice val) { TypeOfPrice = val; }
    public TypeOfPrice Get(TypeOfPrice val) { GetField(val); return val; }
    public bool IsSet(TypeOfPrice val) { return IsSetTypeOfPrice(); }
    public bool IsSetTypeOfPrice() { return IsSetField(Tags.TypeOfPrice); }

    public MarkitWireEligble MarkitWireEligble
    {
        get
        {
            MarkitWireEligble val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarkitWireEligble val) { MarkitWireEligble = val; }
    public MarkitWireEligble Get(MarkitWireEligble val) { GetField(val); return val; }
    public bool IsSet(MarkitWireEligble val) { return IsSetMarkitWireEligble(); }
    public bool IsSetMarkitWireEligble() { return IsSetField(Tags.MarkitWireEligble); }

    public MandatoryToClearDF MandatoryToClearDF
    {
        get
        {
            MandatoryToClearDF val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MandatoryToClearDF val) { MandatoryToClearDF = val; }
    public MandatoryToClearDF Get(MandatoryToClearDF val) { GetField(val); return val; }
    public bool IsSet(MandatoryToClearDF val) { return IsSetMandatoryToClearDF(); }
    public bool IsSetMandatoryToClearDF() { return IsSetField(Tags.MandatoryToClearDF); }

    public AvgQuotedSpread AvgQuotedSpread
    {
        get
        {
            AvgQuotedSpread val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgQuotedSpread val) { AvgQuotedSpread = val; }
    public AvgQuotedSpread Get(AvgQuotedSpread val) { GetField(val); return val; }
    public bool IsSet(AvgQuotedSpread val) { return IsSetAvgQuotedSpread(); }
    public bool IsSetAvgQuotedSpread() { return IsSetField(Tags.AvgQuotedSpread); }

    public AuctionMethod AuctionMethod
    {
        get
        {
            AuctionMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AuctionMethod val) { AuctionMethod = val; }
    public AuctionMethod Get(AuctionMethod val) { GetField(val); return val; }
    public bool IsSet(AuctionMethod val) { return IsSetAuctionMethod(); }
    public bool IsSetAuctionMethod() { return IsSetField(Tags.AuctionMethod); }

    public AuctionName AuctionName
    {
        get
        {
            AuctionName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AuctionName val) { AuctionName = val; }
    public AuctionName Get(AuctionName val) { GetField(val); return val; }
    public bool IsSet(AuctionName val) { return IsSetAuctionName(); }
    public bool IsSetAuctionName() { return IsSetField(Tags.AuctionName); }

    public OfferingType OfferingType
    {
        get
        {
            OfferingType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferingType val) { OfferingType = val; }
    public OfferingType Get(OfferingType val) { GetField(val); return val; }
    public bool IsSet(OfferingType val) { return IsSetOfferingType(); }
    public bool IsSetOfferingType() { return IsSetField(Tags.OfferingType); }

    public SEFReported SEFReported
    {
        get
        {
            SEFReported val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SEFReported val) { SEFReported = val; }
    public SEFReported Get(SEFReported val) { GetField(val); return val; }
    public bool IsSet(SEFReported val) { return IsSetSEFReported(); }
    public bool IsSetSEFReported() { return IsSetField(Tags.SEFReported); }

    public PreAllocStrategyName PreAllocStrategyName
    {
        get
        {
            PreAllocStrategyName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PreAllocStrategyName val) { PreAllocStrategyName = val; }
    public PreAllocStrategyName Get(PreAllocStrategyName val) { GetField(val); return val; }
    public bool IsSet(PreAllocStrategyName val) { return IsSetPreAllocStrategyName(); }
    public bool IsSetPreAllocStrategyName() { return IsSetField(Tags.PreAllocStrategyName); }

    public IRSBasketPriceIndicator IRSBasketPriceIndicator
    {
        get
        {
            IRSBasketPriceIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IRSBasketPriceIndicator val) { IRSBasketPriceIndicator = val; }
    public IRSBasketPriceIndicator Get(IRSBasketPriceIndicator val) { GetField(val); return val; }
    public bool IsSet(IRSBasketPriceIndicator val) { return IsSetIRSBasketPriceIndicator(); }
    public bool IsSetIRSBasketPriceIndicator() { return IsSetField(Tags.IRSBasketPriceIndicator); }

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

    public RFQMinDealerExceptionReason RFQMinDealerExceptionReason
    {
        get
        {
            RFQMinDealerExceptionReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RFQMinDealerExceptionReason val) { RFQMinDealerExceptionReason = val; }
    public RFQMinDealerExceptionReason Get(RFQMinDealerExceptionReason val) { GetField(val); return val; }
    public bool IsSet(RFQMinDealerExceptionReason val) { return IsSetRFQMinDealerExceptionReason(); }
    public bool IsSetRFQMinDealerExceptionReason() { return IsSetField(Tags.RFQMinDealerExceptionReason); }

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

    public RepositoryReportingIndicator RepositoryReportingIndicator
    {
        get
        {
            RepositoryReportingIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepositoryReportingIndicator val) { RepositoryReportingIndicator = val; }
    public RepositoryReportingIndicator Get(RepositoryReportingIndicator val) { GetField(val); return val; }
    public bool IsSet(RepositoryReportingIndicator val) { return IsSetRepositoryReportingIndicator(); }
    public bool IsSetRepositoryReportingIndicator() { return IsSetField(Tags.RepositoryReportingIndicator); }

    public ConvertibleBondEquityPrice ConvertibleBondEquityPrice
    {
        get
        {
            ConvertibleBondEquityPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConvertibleBondEquityPrice val) { ConvertibleBondEquityPrice = val; }
    public ConvertibleBondEquityPrice Get(ConvertibleBondEquityPrice val) { GetField(val); return val; }
    public bool IsSet(ConvertibleBondEquityPrice val) { return IsSetConvertibleBondEquityPrice(); }
    public bool IsSetConvertibleBondEquityPrice() { return IsSetField(Tags.ConvertibleBondEquityPrice); }

    public WorkingStockIndicator WorkingStockIndicator
    {
        get
        {
            WorkingStockIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(WorkingStockIndicator val) { WorkingStockIndicator = val; }
    public WorkingStockIndicator Get(WorkingStockIndicator val) { GetField(val); return val; }
    public bool IsSet(WorkingStockIndicator val) { return IsSetWorkingStockIndicator(); }
    public bool IsSetWorkingStockIndicator() { return IsSetField(Tags.WorkingStockIndicator); }

    public RegulatoryTradeRule RegulatoryTradeRule
    {
        get
        {
            RegulatoryTradeRule val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegulatoryTradeRule val) { RegulatoryTradeRule = val; }
    public RegulatoryTradeRule Get(RegulatoryTradeRule val) { GetField(val); return val; }
    public bool IsSet(RegulatoryTradeRule val) { return IsSetRegulatoryTradeRule(); }
    public bool IsSetRegulatoryTradeRule() { return IsSetField(Tags.RegulatoryTradeRule); }

    public OptionHashID OptionHashID
    {
        get
        {
            OptionHashID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptionHashID val) { OptionHashID = val; }
    public OptionHashID Get(OptionHashID val) { GetField(val); return val; }
    public bool IsSet(OptionHashID val) { return IsSetOptionHashID(); }
    public bool IsSetOptionHashID() { return IsSetField(Tags.OptionHashID); }

    public MarkitWireBetaTradeID MarkitWireBetaTradeID
    {
        get
        {
            MarkitWireBetaTradeID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarkitWireBetaTradeID val) { MarkitWireBetaTradeID = val; }
    public MarkitWireBetaTradeID Get(MarkitWireBetaTradeID val) { GetField(val); return val; }
    public bool IsSet(MarkitWireBetaTradeID val) { return IsSetMarkitWireBetaTradeID(); }
    public bool IsSetMarkitWireBetaTradeID() { return IsSetField(Tags.MarkitWireBetaTradeID); }

    public PricedToClearCCP PricedToClearCCP
    {
        get
        {
            PricedToClearCCP val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PricedToClearCCP val) { PricedToClearCCP = val; }
    public PricedToClearCCP Get(PricedToClearCCP val) { GetField(val); return val; }
    public bool IsSet(PricedToClearCCP val) { return IsSetPricedToClearCCP(); }
    public bool IsSetPricedToClearCCP() { return IsSetField(Tags.PricedToClearCCP); }

    public MandatoryToClearEMIR MandatoryToClearEMIR
    {
        get
        {
            MandatoryToClearEMIR val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MandatoryToClearEMIR val) { MandatoryToClearEMIR = val; }
    public MandatoryToClearEMIR Get(MandatoryToClearEMIR val) { GetField(val); return val; }
    public bool IsSet(MandatoryToClearEMIR val) { return IsSetMandatoryToClearEMIR(); }
    public bool IsSetMandatoryToClearEMIR() { return IsSetField(Tags.MandatoryToClearEMIR); }

    public MarkitWireBookID MarkitWireBookID
    {
        get
        {
            MarkitWireBookID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarkitWireBookID val) { MarkitWireBookID = val; }
    public MarkitWireBookID Get(MarkitWireBookID val) { GetField(val); return val; }
    public bool IsSet(MarkitWireBookID val) { return IsSetMarkitWireBookID(); }
    public bool IsSetMarkitWireBookID() { return IsSetField(Tags.MarkitWireBookID); }

    public CalculatedCurrency CalculatedCurrency
    {
        get
        {
            CalculatedCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CalculatedCurrency val) { CalculatedCurrency = val; }
    public CalculatedCurrency Get(CalculatedCurrency val) { GetField(val); return val; }
    public bool IsSet(CalculatedCurrency val) { return IsSetCalculatedCurrency(); }
    public bool IsSetCalculatedCurrency() { return IsSetField(Tags.CalculatedCurrency); }

    public HedgeCurrency HedgeCurrency
    {
        get
        {
            HedgeCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeCurrency val) { HedgeCurrency = val; }
    public HedgeCurrency Get(HedgeCurrency val) { GetField(val); return val; }
    public bool IsSet(HedgeCurrency val) { return IsSetHedgeCurrency(); }
    public bool IsSetHedgeCurrency() { return IsSetField(Tags.HedgeCurrency); }

    public ClientConvertibleBondEquityPrice ClientConvertibleBondEquityPrice
    {
        get
        {
            ClientConvertibleBondEquityPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientConvertibleBondEquityPrice val) { ClientConvertibleBondEquityPrice = val; }
    public ClientConvertibleBondEquityPrice Get(ClientConvertibleBondEquityPrice val) { GetField(val); return val; }
    public bool IsSet(ClientConvertibleBondEquityPrice val) { return IsSetClientConvertibleBondEquityPrice(); }
    public bool IsSetClientConvertibleBondEquityPrice() { return IsSetField(Tags.ClientConvertibleBondEquityPrice); }

    public ConvertibleBondNukeBidPrice ConvertibleBondNukeBidPrice
    {
        get
        {
            ConvertibleBondNukeBidPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConvertibleBondNukeBidPrice val) { ConvertibleBondNukeBidPrice = val; }
    public ConvertibleBondNukeBidPrice Get(ConvertibleBondNukeBidPrice val) { GetField(val); return val; }
    public bool IsSet(ConvertibleBondNukeBidPrice val) { return IsSetConvertibleBondNukeBidPrice(); }
    public bool IsSetConvertibleBondNukeBidPrice() { return IsSetField(Tags.ConvertibleBondNukeBidPrice); }

    public ConvertibleBondNukeOfferPrice ConvertibleBondNukeOfferPrice
    {
        get
        {
            ConvertibleBondNukeOfferPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConvertibleBondNukeOfferPrice val) { ConvertibleBondNukeOfferPrice = val; }
    public ConvertibleBondNukeOfferPrice Get(ConvertibleBondNukeOfferPrice val) { GetField(val); return val; }
    public bool IsSet(ConvertibleBondNukeOfferPrice val) { return IsSetConvertibleBondNukeOfferPrice(); }
    public bool IsSetConvertibleBondNukeOfferPrice() { return IsSetField(Tags.ConvertibleBondNukeOfferPrice); }

    public PriceOffset PriceOffset
    {
        get
        {
            PriceOffset val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceOffset val) { PriceOffset = val; }
    public PriceOffset Get(PriceOffset val) { GetField(val); return val; }
    public bool IsSet(PriceOffset val) { return IsSetPriceOffset(); }
    public bool IsSetPriceOffset() { return IsSetField(Tags.PriceOffset); }

    public AllocationCount AllocationCount
    {
        get
        {
            AllocationCount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocationCount val) { AllocationCount = val; }
    public AllocationCount Get(AllocationCount val) { GetField(val); return val; }
    public bool IsSet(AllocationCount val) { return IsSetAllocationCount(); }
    public bool IsSetAllocationCount() { return IsSetField(Tags.AllocationCount); }

    public TradeNotes TradeNotes
    {
        get
        {
            TradeNotes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeNotes val) { TradeNotes = val; }
    public TradeNotes Get(TradeNotes val) { GetField(val); return val; }
    public bool IsSet(TradeNotes val) { return IsSetTradeNotes(); }
    public bool IsSetTradeNotes() { return IsSetField(Tags.TradeNotes); }

    public ClientBidPx ClientBidPx
    {
        get
        {
            ClientBidPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientBidPx val) { ClientBidPx = val; }
    public ClientBidPx Get(ClientBidPx val) { GetField(val); return val; }
    public bool IsSet(ClientBidPx val) { return IsSetClientBidPx(); }
    public bool IsSetClientBidPx() { return IsSetField(Tags.ClientBidPx); }

    public ClientOfferPx ClientOfferPx
    {
        get
        {
            ClientOfferPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientOfferPx val) { ClientOfferPx = val; }
    public ClientOfferPx Get(ClientOfferPx val) { GetField(val); return val; }
    public bool IsSet(ClientOfferPx val) { return IsSetClientOfferPx(); }
    public bool IsSetClientOfferPx() { return IsSetField(Tags.ClientOfferPx); }

    public DealerSide DealerSide
    {
        get
        {
            DealerSide val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DealerSide val) { DealerSide = val; }
    public DealerSide Get(DealerSide val) { GetField(val); return val; }
    public bool IsSet(DealerSide val) { return IsSetDealerSide(); }
    public bool IsSetDealerSide() { return IsSetField(Tags.DealerSide); }

    public BasketItemCount BasketItemCount
    {
        get
        {
            BasketItemCount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BasketItemCount val) { BasketItemCount = val; }
    public BasketItemCount Get(BasketItemCount val) { GetField(val); return val; }
    public bool IsSet(BasketItemCount val) { return IsSetBasketItemCount(); }
    public bool IsSetBasketItemCount() { return IsSetField(Tags.BasketItemCount); }

    public BasketItemNumber BasketItemNumber
    {
        get
        {
            BasketItemNumber val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BasketItemNumber val) { BasketItemNumber = val; }
    public BasketItemNumber Get(BasketItemNumber val) { GetField(val); return val; }
    public bool IsSet(BasketItemNumber val) { return IsSetBasketItemNumber(); }
    public bool IsSetBasketItemNumber() { return IsSetField(Tags.BasketItemNumber); }

    public HedgeDelta HedgeDelta
    {
        get
        {
            HedgeDelta val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeDelta val) { HedgeDelta = val; }
    public HedgeDelta Get(HedgeDelta val) { GetField(val); return val; }
    public bool IsSet(HedgeDelta val) { return IsSetHedgeDelta(); }
    public bool IsSetHedgeDelta() { return IsSetField(Tags.HedgeDelta); }

    public TRACEModifier TRACEModifier
    {
        get
        {
            TRACEModifier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TRACEModifier val) { TRACEModifier = val; }
    public TRACEModifier Get(TRACEModifier val) { GetField(val); return val; }
    public bool IsSet(TRACEModifier val) { return IsSetTRACEModifier(); }
    public bool IsSetTRACEModifier() { return IsSetField(Tags.TRACEModifier); }

    public SecLendReason SecLendReason
    {
        get
        {
            SecLendReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecLendReason val) { SecLendReason = val; }
    public SecLendReason Get(SecLendReason val) { GetField(val); return val; }
    public bool IsSet(SecLendReason val) { return IsSetSecLendReason(); }
    public bool IsSetSecLendReason() { return IsSetField(Tags.SecLendReason); }

    public LastQtyUnits LastQtyUnits
    {
        get
        {
            LastQtyUnits val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastQtyUnits val) { LastQtyUnits = val; }
    public LastQtyUnits Get(LastQtyUnits val) { GetField(val); return val; }
    public bool IsSet(LastQtyUnits val) { return IsSetLastQtyUnits(); }
    public bool IsSetLastQtyUnits() { return IsSetField(Tags.LastQtyUnits); }

    public CancelReason CancelReason
    {
        get
        {
            CancelReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CancelReason val) { CancelReason = val; }
    public CancelReason Get(CancelReason val) { GetField(val); return val; }
    public bool IsSet(CancelReason val) { return IsSetCancelReason(); }
    public bool IsSetCancelReason() { return IsSetField(Tags.CancelReason); }

    public PremiumSettlCurrAmt PremiumSettlCurrAmt
    {
        get
        {
            PremiumSettlCurrAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PremiumSettlCurrAmt val) { PremiumSettlCurrAmt = val; }
    public PremiumSettlCurrAmt Get(PremiumSettlCurrAmt val) { GetField(val); return val; }
    public bool IsSet(PremiumSettlCurrAmt val) { return IsSetPremiumSettlCurrAmt(); }
    public bool IsSetPremiumSettlCurrAmt() { return IsSetField(Tags.PremiumSettlCurrAmt); }

    public PremiumSettlCurrency PremiumSettlCurrency
    {
        get
        {
            PremiumSettlCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PremiumSettlCurrency val) { PremiumSettlCurrency = val; }
    public PremiumSettlCurrency Get(PremiumSettlCurrency val) { GetField(val); return val; }
    public bool IsSet(PremiumSettlCurrency val) { return IsSetPremiumSettlCurrency(); }
    public bool IsSetPremiumSettlCurrency() { return IsSetField(Tags.PremiumSettlCurrency); }

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

    public NoClientCustomData NoClientCustomData
    {
        get
        {
            NoClientCustomData val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoClientCustomData val) { NoClientCustomData = val; }
    public NoClientCustomData Get(NoClientCustomData val) { GetField(val); return val; }
    public bool IsSet(NoClientCustomData val) { return IsSetNoClientCustomData(); }
    public bool IsSetNoClientCustomData() { return IsSetField(Tags.NoClientCustomData); }

    public NoCompDealerQuotes NoCompDealerQuotes
    {
        get
        {
            NoCompDealerQuotes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoCompDealerQuotes val) { NoCompDealerQuotes = val; }
    public NoCompDealerQuotes Get(NoCompDealerQuotes val) { GetField(val); return val; }
    public bool IsSet(NoCompDealerQuotes val) { return IsSetNoCompDealerQuotes(); }
    public bool IsSetNoCompDealerQuotes() { return IsSetField(Tags.NoCompDealerQuotes); }

    public HedgeSpread HedgeSpread
    {
        get
        {
            HedgeSpread val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeSpread val) { HedgeSpread = val; }
    public HedgeSpread Get(HedgeSpread val) { GetField(val); return val; }
    public bool IsSet(HedgeSpread val) { return IsSetHedgeSpread(); }
    public bool IsSetHedgeSpread() { return IsSetField(Tags.HedgeSpread); }

    public HedgeSecurityID HedgeSecurityID
    {
        get
        {
            HedgeSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeSecurityID val) { HedgeSecurityID = val; }
    public HedgeSecurityID Get(HedgeSecurityID val) { GetField(val); return val; }
    public bool IsSet(HedgeSecurityID val) { return IsSetHedgeSecurityID(); }
    public bool IsSetHedgeSecurityID() { return IsSetField(Tags.HedgeSecurityID); }

    public HedgeSecurityIDSource HedgeSecurityIDSource
    {
        get
        {
            HedgeSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeSecurityIDSource val) { HedgeSecurityIDSource = val; }
    public HedgeSecurityIDSource Get(HedgeSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(HedgeSecurityIDSource val) { return IsSetHedgeSecurityIDSource(); }
    public bool IsSetHedgeSecurityIDSource() { return IsSetField(Tags.HedgeSecurityIDSource); }

    public HedgePrice HedgePrice
    {
        get
        {
            HedgePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgePrice val) { HedgePrice = val; }
    public HedgePrice Get(HedgePrice val) { GetField(val); return val; }
    public bool IsSet(HedgePrice val) { return IsSetHedgePrice(); }
    public bool IsSetHedgePrice() { return IsSetField(Tags.HedgePrice); }

    public HedgePriceType HedgePriceType
    {
        get
        {
            HedgePriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgePriceType val) { HedgePriceType = val; }
    public HedgePriceType Get(HedgePriceType val) { GetField(val); return val; }
    public bool IsSet(HedgePriceType val) { return IsSetHedgePriceType(); }
    public bool IsSetHedgePriceType() { return IsSetField(Tags.HedgePriceType); }

    public HedgeQty HedgeQty
    {
        get
        {
            HedgeQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeQty val) { HedgeQty = val; }
    public HedgeQty Get(HedgeQty val) { GetField(val); return val; }
    public bool IsSet(HedgeQty val) { return IsSetHedgeQty(); }
    public bool IsSetHedgeQty() { return IsSetField(Tags.HedgeQty); }

    public HedgeQtyType HedgeQtyType
    {
        get
        {
            HedgeQtyType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HedgeQtyType val) { HedgeQtyType = val; }
    public HedgeQtyType Get(HedgeQtyType val) { GetField(val); return val; }
    public bool IsSet(HedgeQtyType val) { return IsSetHedgeQtyType(); }
    public bool IsSetHedgeQtyType() { return IsSetField(Tags.HedgeQtyType); }

    public NoRefPrices NoRefPrices
    {
        get
        {
            NoRefPrices val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRefPrices val) { NoRefPrices = val; }
    public NoRefPrices Get(NoRefPrices val) { GetField(val); return val; }
    public bool IsSet(NoRefPrices val) { return IsSetNoRefPrices(); }
    public bool IsSetNoRefPrices() { return IsSetField(Tags.NoRefPrices); }

    public NoReferenceIds NoReferenceIds
    {
        get
        {
            NoReferenceIds val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoReferenceIds val) { NoReferenceIds = val; }
    public NoReferenceIds Get(NoReferenceIds val) { GetField(val); return val; }
    public bool IsSet(NoReferenceIds val) { return IsSetNoReferenceIds(); }
    public bool IsSetNoReferenceIds() { return IsSetField(Tags.NoReferenceIds); }

    public NoPriceQualifiers NoPriceQualifiers
    {
        get
        {
            NoPriceQualifiers val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPriceQualifiers val) { NoPriceQualifiers = val; }
    public NoPriceQualifiers Get(NoPriceQualifiers val) { GetField(val); return val; }
    public bool IsSet(NoPriceQualifiers val) { return IsSetNoPriceQualifiers(); }
    public bool IsSetNoPriceQualifiers() { return IsSetField(Tags.NoPriceQualifiers); }

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

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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
    }

    public class NoContraBrokersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ContraBroker, Tags.ContraTrader, Tags.ContraTradeQty, Tags.ContraTradeTime, Tags.ContraLegRefID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ContraBroker, Tags.ContraTrader, Tags.ContraTradeQty, Tags.ContraTradeTime, Tags.ContraLegRefID, 0};

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

        public ContraLegRefID ContraLegRefID
        {
            get
            {
                ContraLegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContraLegRefID val) { ContraLegRefID = val; }
        public ContraLegRefID Get(ContraLegRefID val) { GetField(val); return val; }
        public bool IsSet(ContraLegRefID val) { return IsSetContraLegRefID(); }
        public bool IsSetContraLegRefID() { return IsSetField(Tags.ContraLegRefID); }
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
        public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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
        public static int[] DefaultFieldOrder = [Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoContractualDefinitionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ContractualDefinition, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoContAmtsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoLegsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, Tags.LegContractMultiplierUnit, Tags.LegFlowScheduleType, Tags.LegID, Tags.LegRestructuringType, Tags.LegSeniority, Tags.LegAttachmentPoint, Tags.LegDetachmentPoint, Tags.LegAssetClass, Tags.LegAssetSubClass, Tags.LegCouponFrequencyPeriod, Tags.LegCouponFrequencyUnit, Tags.LegCouponDayCount, Tags.LegIndexSeries, Tags.LegIndexAnnexVersion, Tags.LegIndexAnnexDate, Tags.LegIndexAnnexSource, Tags.LegSettlMethod, Tags.LegSecurityXMLLen, Tags.LegSecurityXML, Tags.LegSecurityXMLSchema, Tags.NoLegEvents, Tags.NoLegComplexEvents, Tags.LegBusinessDayConvention, Tags.LegDateRollConvention, Tags.LegOptionExerciseLatestTime, Tags.LegOptionExerciseTimeBusinessCenter, Tags.LegOptionExerciseDeliveryDate, Tags.NoLegStreams, Tags.LegCouponDateGenerationMethod, Tags.LegPutOrCallCurrency, Tags.LegStrategyPosition, Tags.LegCustomizedIndicator, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.LegRefID, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegOrderQty, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, Tags.NoNested3PartyIDs, Tags.LegAllocID, Tags.NoLegAllocs, Tags.LegVolatility, Tags.LegDividendYield, Tags.LegCurrencyRatio, Tags.LegExecInst, Tags.LegLastQty, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, Tags.LegContractMultiplierUnit, Tags.LegFlowScheduleType, Tags.LegID, Tags.LegRestructuringType, Tags.LegSeniority, Tags.LegAttachmentPoint, Tags.LegDetachmentPoint, Tags.LegAssetClass, Tags.LegAssetSubClass, Tags.LegCouponFrequencyPeriod, Tags.LegCouponFrequencyUnit, Tags.LegCouponDayCount, Tags.LegIndexSeries, Tags.LegIndexAnnexVersion, Tags.LegIndexAnnexDate, Tags.LegIndexAnnexSource, Tags.LegSettlMethod, Tags.LegSecurityXMLLen, Tags.LegSecurityXML, Tags.LegSecurityXMLSchema, Tags.NoLegEvents, Tags.NoLegComplexEvents, Tags.LegBusinessDayConvention, Tags.LegDateRollConvention, Tags.LegOptionExerciseLatestTime, Tags.LegOptionExerciseTimeBusinessCenter, Tags.LegOptionExerciseDeliveryDate, Tags.NoLegStreams, Tags.LegCouponDateGenerationMethod, Tags.LegPutOrCallCurrency, Tags.LegStrategyPosition, Tags.LegCustomizedIndicator, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.LegRefID, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegOrderQty, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, Tags.NoNested3PartyIDs, Tags.LegAllocID, Tags.NoLegAllocs, Tags.LegVolatility, Tags.LegDividendYield, Tags.LegCurrencyRatio, Tags.LegExecInst, Tags.LegLastQty, 0};

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

        public LegSecuritySubType LegSecuritySubType
        {
            get
            {
                LegSecuritySubType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecuritySubType val) { LegSecuritySubType = val; }
        public LegSecuritySubType Get(LegSecuritySubType val) { GetField(val); return val; }
        public bool IsSet(LegSecuritySubType val) { return IsSetLegSecuritySubType(); }
        public bool IsSetLegSecuritySubType() { return IsSetField(Tags.LegSecuritySubType); }

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

        public LegCouponPaymentDate LegCouponPaymentDate
        {
            get
            {
                LegCouponPaymentDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponPaymentDate val) { LegCouponPaymentDate = val; }
        public LegCouponPaymentDate Get(LegCouponPaymentDate val) { GetField(val); return val; }
        public bool IsSet(LegCouponPaymentDate val) { return IsSetLegCouponPaymentDate(); }
        public bool IsSetLegCouponPaymentDate() { return IsSetField(Tags.LegCouponPaymentDate); }

        public LegIssueDate LegIssueDate
        {
            get
            {
                LegIssueDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIssueDate val) { LegIssueDate = val; }
        public LegIssueDate Get(LegIssueDate val) { GetField(val); return val; }
        public bool IsSet(LegIssueDate val) { return IsSetLegIssueDate(); }
        public bool IsSetLegIssueDate() { return IsSetField(Tags.LegIssueDate); }

        public LegRepoCollateralSecurityType LegRepoCollateralSecurityType
        {
            get
            {
                LegRepoCollateralSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepoCollateralSecurityType val) { LegRepoCollateralSecurityType = val; }
        public LegRepoCollateralSecurityType Get(LegRepoCollateralSecurityType val) { GetField(val); return val; }
        public bool IsSet(LegRepoCollateralSecurityType val) { return IsSetLegRepoCollateralSecurityType(); }
        public bool IsSetLegRepoCollateralSecurityType() { return IsSetField(Tags.LegRepoCollateralSecurityType); }

        public LegRepurchaseTerm LegRepurchaseTerm
        {
            get
            {
                LegRepurchaseTerm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepurchaseTerm val) { LegRepurchaseTerm = val; }
        public LegRepurchaseTerm Get(LegRepurchaseTerm val) { GetField(val); return val; }
        public bool IsSet(LegRepurchaseTerm val) { return IsSetLegRepurchaseTerm(); }
        public bool IsSetLegRepurchaseTerm() { return IsSetField(Tags.LegRepurchaseTerm); }

        public LegRepurchaseRate LegRepurchaseRate
        {
            get
            {
                LegRepurchaseRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepurchaseRate val) { LegRepurchaseRate = val; }
        public LegRepurchaseRate Get(LegRepurchaseRate val) { GetField(val); return val; }
        public bool IsSet(LegRepurchaseRate val) { return IsSetLegRepurchaseRate(); }
        public bool IsSetLegRepurchaseRate() { return IsSetField(Tags.LegRepurchaseRate); }

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

        public LegCreditRating LegCreditRating
        {
            get
            {
                LegCreditRating val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCreditRating val) { LegCreditRating = val; }
        public LegCreditRating Get(LegCreditRating val) { GetField(val); return val; }
        public bool IsSet(LegCreditRating val) { return IsSetLegCreditRating(); }
        public bool IsSetLegCreditRating() { return IsSetField(Tags.LegCreditRating); }

        public LegInstrRegistry LegInstrRegistry
        {
            get
            {
                LegInstrRegistry val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegInstrRegistry val) { LegInstrRegistry = val; }
        public LegInstrRegistry Get(LegInstrRegistry val) { GetField(val); return val; }
        public bool IsSet(LegInstrRegistry val) { return IsSetLegInstrRegistry(); }
        public bool IsSetLegInstrRegistry() { return IsSetField(Tags.LegInstrRegistry); }

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

        public LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
        {
            get
            {
                LegStateOrProvinceOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStateOrProvinceOfIssue val) { LegStateOrProvinceOfIssue = val; }
        public LegStateOrProvinceOfIssue Get(LegStateOrProvinceOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegStateOrProvinceOfIssue val) { return IsSetLegStateOrProvinceOfIssue(); }
        public bool IsSetLegStateOrProvinceOfIssue() { return IsSetField(Tags.LegStateOrProvinceOfIssue); }

        public LegLocaleOfIssue LegLocaleOfIssue
        {
            get
            {
                LegLocaleOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLocaleOfIssue val) { LegLocaleOfIssue = val; }
        public LegLocaleOfIssue Get(LegLocaleOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegLocaleOfIssue val) { return IsSetLegLocaleOfIssue(); }
        public bool IsSetLegLocaleOfIssue() { return IsSetField(Tags.LegLocaleOfIssue); }

        public LegRedemptionDate LegRedemptionDate
        {
            get
            {
                LegRedemptionDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRedemptionDate val) { LegRedemptionDate = val; }
        public LegRedemptionDate Get(LegRedemptionDate val) { GetField(val); return val; }
        public bool IsSet(LegRedemptionDate val) { return IsSetLegRedemptionDate(); }
        public bool IsSetLegRedemptionDate() { return IsSetField(Tags.LegRedemptionDate); }

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

        public LegOptAttribute LegOptAttribute
        {
            get
            {
                LegOptAttribute val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOptAttribute val) { LegOptAttribute = val; }
        public LegOptAttribute Get(LegOptAttribute val) { GetField(val); return val; }
        public bool IsSet(LegOptAttribute val) { return IsSetLegOptAttribute(); }
        public bool IsSetLegOptAttribute() { return IsSetField(Tags.LegOptAttribute); }

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

        public EncodedLegIssuerLen EncodedLegIssuerLen
        {
            get
            {
                EncodedLegIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegIssuerLen val) { EncodedLegIssuerLen = val; }
        public EncodedLegIssuerLen Get(EncodedLegIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedLegIssuerLen val) { return IsSetEncodedLegIssuerLen(); }
        public bool IsSetEncodedLegIssuerLen() { return IsSetField(Tags.EncodedLegIssuerLen); }

        public EncodedLegIssuer EncodedLegIssuer
        {
            get
            {
                EncodedLegIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegIssuer val) { EncodedLegIssuer = val; }
        public EncodedLegIssuer Get(EncodedLegIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedLegIssuer val) { return IsSetEncodedLegIssuer(); }
        public bool IsSetEncodedLegIssuer() { return IsSetField(Tags.EncodedLegIssuer); }

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

        public EncodedLegSecurityDescLen EncodedLegSecurityDescLen
        {
            get
            {
                EncodedLegSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegSecurityDescLen val) { EncodedLegSecurityDescLen = val; }
        public EncodedLegSecurityDescLen Get(EncodedLegSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedLegSecurityDescLen val) { return IsSetEncodedLegSecurityDescLen(); }
        public bool IsSetEncodedLegSecurityDescLen() { return IsSetField(Tags.EncodedLegSecurityDescLen); }

        public EncodedLegSecurityDesc EncodedLegSecurityDesc
        {
            get
            {
                EncodedLegSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegSecurityDesc val) { EncodedLegSecurityDesc = val; }
        public EncodedLegSecurityDesc Get(EncodedLegSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedLegSecurityDesc val) { return IsSetEncodedLegSecurityDesc(); }
        public bool IsSetEncodedLegSecurityDesc() { return IsSetField(Tags.EncodedLegSecurityDesc); }

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

        public LegDatedDate LegDatedDate
        {
            get
            {
                LegDatedDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegDatedDate val) { LegDatedDate = val; }
        public LegDatedDate Get(LegDatedDate val) { GetField(val); return val; }
        public bool IsSet(LegDatedDate val) { return IsSetLegDatedDate(); }
        public bool IsSetLegDatedDate() { return IsSetField(Tags.LegDatedDate); }

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

        public LegInterestAccrualDate LegInterestAccrualDate
        {
            get
            {
                LegInterestAccrualDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegInterestAccrualDate val) { LegInterestAccrualDate = val; }
        public LegInterestAccrualDate Get(LegInterestAccrualDate val) { GetField(val); return val; }
        public bool IsSet(LegInterestAccrualDate val) { return IsSetLegInterestAccrualDate(); }
        public bool IsSetLegInterestAccrualDate() { return IsSetField(Tags.LegInterestAccrualDate); }

        public LegUnitOfMeasure LegUnitOfMeasure
        {
            get
            {
                LegUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegUnitOfMeasure val) { LegUnitOfMeasure = val; }
        public LegUnitOfMeasure Get(LegUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(LegUnitOfMeasure val) { return IsSetLegUnitOfMeasure(); }
        public bool IsSetLegUnitOfMeasure() { return IsSetField(Tags.LegUnitOfMeasure); }

        public LegTimeUnit LegTimeUnit
        {
            get
            {
                LegTimeUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegTimeUnit val) { LegTimeUnit = val; }
        public LegTimeUnit Get(LegTimeUnit val) { GetField(val); return val; }
        public bool IsSet(LegTimeUnit val) { return IsSetLegTimeUnit(); }
        public bool IsSetLegTimeUnit() { return IsSetField(Tags.LegTimeUnit); }

        public LegOptionRatio LegOptionRatio
        {
            get
            {
                LegOptionRatio val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOptionRatio val) { LegOptionRatio = val; }
        public LegOptionRatio Get(LegOptionRatio val) { GetField(val); return val; }
        public bool IsSet(LegOptionRatio val) { return IsSetLegOptionRatio(); }
        public bool IsSetLegOptionRatio() { return IsSetField(Tags.LegOptionRatio); }

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

        public LegMaturityTime LegMaturityTime
        {
            get
            {
                LegMaturityTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegMaturityTime val) { LegMaturityTime = val; }
        public LegMaturityTime Get(LegMaturityTime val) { GetField(val); return val; }
        public bool IsSet(LegMaturityTime val) { return IsSetLegMaturityTime(); }
        public bool IsSetLegMaturityTime() { return IsSetField(Tags.LegMaturityTime); }

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

        public LegUnitOfMeasureQty LegUnitOfMeasureQty
        {
            get
            {
                LegUnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegUnitOfMeasureQty val) { LegUnitOfMeasureQty = val; }
        public LegUnitOfMeasureQty Get(LegUnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(LegUnitOfMeasureQty val) { return IsSetLegUnitOfMeasureQty(); }
        public bool IsSetLegUnitOfMeasureQty() { return IsSetField(Tags.LegUnitOfMeasureQty); }

        public LegPriceUnitOfMeasure LegPriceUnitOfMeasure
        {
            get
            {
                LegPriceUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPriceUnitOfMeasure val) { LegPriceUnitOfMeasure = val; }
        public LegPriceUnitOfMeasure Get(LegPriceUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(LegPriceUnitOfMeasure val) { return IsSetLegPriceUnitOfMeasure(); }
        public bool IsSetLegPriceUnitOfMeasure() { return IsSetField(Tags.LegPriceUnitOfMeasure); }

        public LegPriceUnitOfMeasureQty LegPriceUnitOfMeasureQty
        {
            get
            {
                LegPriceUnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPriceUnitOfMeasureQty val) { LegPriceUnitOfMeasureQty = val; }
        public LegPriceUnitOfMeasureQty Get(LegPriceUnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(LegPriceUnitOfMeasureQty val) { return IsSetLegPriceUnitOfMeasureQty(); }
        public bool IsSetLegPriceUnitOfMeasureQty() { return IsSetField(Tags.LegPriceUnitOfMeasureQty); }

        public LegContractMultiplierUnit LegContractMultiplierUnit
        {
            get
            {
                LegContractMultiplierUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegContractMultiplierUnit val) { LegContractMultiplierUnit = val; }
        public LegContractMultiplierUnit Get(LegContractMultiplierUnit val) { GetField(val); return val; }
        public bool IsSet(LegContractMultiplierUnit val) { return IsSetLegContractMultiplierUnit(); }
        public bool IsSetLegContractMultiplierUnit() { return IsSetField(Tags.LegContractMultiplierUnit); }

        public LegFlowScheduleType LegFlowScheduleType
        {
            get
            {
                LegFlowScheduleType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegFlowScheduleType val) { LegFlowScheduleType = val; }
        public LegFlowScheduleType Get(LegFlowScheduleType val) { GetField(val); return val; }
        public bool IsSet(LegFlowScheduleType val) { return IsSetLegFlowScheduleType(); }
        public bool IsSetLegFlowScheduleType() { return IsSetField(Tags.LegFlowScheduleType); }

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

        public LegOrderQty LegOrderQty
        {
            get
            {
                LegOrderQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOrderQty val) { LegOrderQty = val; }
        public LegOrderQty Get(LegOrderQty val) { GetField(val); return val; }
        public bool IsSet(LegOrderQty val) { return IsSetLegOrderQty(); }
        public bool IsSetLegOrderQty() { return IsSetField(Tags.LegOrderQty); }

        public LegSettlCurrency LegSettlCurrency
        {
            get
            {
                LegSettlCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlCurrency val) { LegSettlCurrency = val; }
        public LegSettlCurrency Get(LegSettlCurrency val) { GetField(val); return val; }
        public bool IsSet(LegSettlCurrency val) { return IsSetLegSettlCurrency(); }
        public bool IsSetLegSettlCurrency() { return IsSetField(Tags.LegSettlCurrency); }

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

        public LegGrossTradeAmt LegGrossTradeAmt
        {
            get
            {
                LegGrossTradeAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegGrossTradeAmt val) { LegGrossTradeAmt = val; }
        public LegGrossTradeAmt Get(LegGrossTradeAmt val) { GetField(val); return val; }
        public bool IsSet(LegGrossTradeAmt val) { return IsSetLegGrossTradeAmt(); }
        public bool IsSetLegGrossTradeAmt() { return IsSetField(Tags.LegGrossTradeAmt); }

        public NoNested3PartyIDs NoNested3PartyIDs
        {
            get
            {
                NoNested3PartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNested3PartyIDs val) { NoNested3PartyIDs = val; }
        public NoNested3PartyIDs Get(NoNested3PartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNested3PartyIDs val) { return IsSetNoNested3PartyIDs(); }
        public bool IsSetNoNested3PartyIDs() { return IsSetField(Tags.NoNested3PartyIDs); }

        public LegAllocID LegAllocID
        {
            get
            {
                LegAllocID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegAllocID val) { LegAllocID = val; }
        public LegAllocID Get(LegAllocID val) { GetField(val); return val; }
        public bool IsSet(LegAllocID val) { return IsSetLegAllocID(); }
        public bool IsSetLegAllocID() { return IsSetField(Tags.LegAllocID); }

        public NoLegAllocs NoLegAllocs
        {
            get
            {
                NoLegAllocs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegAllocs val) { NoLegAllocs = val; }
        public NoLegAllocs Get(NoLegAllocs val) { GetField(val); return val; }
        public bool IsSet(NoLegAllocs val) { return IsSetNoLegAllocs(); }
        public bool IsSetNoLegAllocs() { return IsSetField(Tags.NoLegAllocs); }

        public LegVolatility LegVolatility
        {
            get
            {
                LegVolatility val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegVolatility val) { LegVolatility = val; }
        public LegVolatility Get(LegVolatility val) { GetField(val); return val; }
        public bool IsSet(LegVolatility val) { return IsSetLegVolatility(); }
        public bool IsSetLegVolatility() { return IsSetField(Tags.LegVolatility); }

        public LegDividendYield LegDividendYield
        {
            get
            {
                LegDividendYield val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegDividendYield val) { LegDividendYield = val; }
        public LegDividendYield Get(LegDividendYield val) { GetField(val); return val; }
        public bool IsSet(LegDividendYield val) { return IsSetLegDividendYield(); }
        public bool IsSetLegDividendYield() { return IsSetField(Tags.LegDividendYield); }

        public LegCurrencyRatio LegCurrencyRatio
        {
            get
            {
                LegCurrencyRatio val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCurrencyRatio val) { LegCurrencyRatio = val; }
        public LegCurrencyRatio Get(LegCurrencyRatio val) { GetField(val); return val; }
        public bool IsSet(LegCurrencyRatio val) { return IsSetLegCurrencyRatio(); }
        public bool IsSetLegCurrencyRatio() { return IsSetField(Tags.LegCurrencyRatio); }

        public LegExecInst LegExecInst
        {
            get
            {
                LegExecInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegExecInst val) { LegExecInst = val; }
        public LegExecInst Get(LegExecInst val) { GetField(val); return val; }
        public bool IsSet(LegExecInst val) { return IsSetLegExecInst(); }
        public bool IsSetLegExecInst() { return IsSetField(Tags.LegExecInst); }

        public LegLastQty LegLastQty
        {
            get
            {
                LegLastQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLastQty val) { LegLastQty = val; }
        public LegLastQty Get(LegLastQty val) { GetField(val); return val; }
        public bool IsSet(LegLastQty val) { return IsSetLegLastQty(); }
        public bool IsSetLegLastQty() { return IsSetField(Tags.LegLastQty); }

        public class NoLegSecurityAltIDGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

        public class NoNested3PartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.Nested3PartyID, Tags.Nested3PartyIDSource, Tags.Nested3PartyRole, Tags.NoNested3PartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.Nested3PartyID, Tags.Nested3PartyIDSource, Tags.Nested3PartyRole, Tags.NoNested3PartySubIDs, 0};

            public NoNested3PartyIDsGroup()
              : base(Tags.NoNested3PartyIDs, Tags.Nested3PartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNested3PartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public Nested3PartyID Nested3PartyID
            {
                get
                {
                    Nested3PartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested3PartyID val) { Nested3PartyID = val; }
            public Nested3PartyID Get(Nested3PartyID val) { GetField(val); return val; }
            public bool IsSet(Nested3PartyID val) { return IsSetNested3PartyID(); }
            public bool IsSetNested3PartyID() { return IsSetField(Tags.Nested3PartyID); }

            public Nested3PartyIDSource Nested3PartyIDSource
            {
                get
                {
                    Nested3PartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested3PartyIDSource val) { Nested3PartyIDSource = val; }
            public Nested3PartyIDSource Get(Nested3PartyIDSource val) { GetField(val); return val; }
            public bool IsSet(Nested3PartyIDSource val) { return IsSetNested3PartyIDSource(); }
            public bool IsSetNested3PartyIDSource() { return IsSetField(Tags.Nested3PartyIDSource); }

            public Nested3PartyRole Nested3PartyRole
            {
                get
                {
                    Nested3PartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested3PartyRole val) { Nested3PartyRole = val; }
            public Nested3PartyRole Get(Nested3PartyRole val) { GetField(val); return val; }
            public bool IsSet(Nested3PartyRole val) { return IsSetNested3PartyRole(); }
            public bool IsSetNested3PartyRole() { return IsSetField(Tags.Nested3PartyRole); }

            public NoNested3PartySubIDs NoNested3PartySubIDs
            {
                get
                {
                    NoNested3PartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNested3PartySubIDs val) { NoNested3PartySubIDs = val; }
            public NoNested3PartySubIDs Get(NoNested3PartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNested3PartySubIDs val) { return IsSetNoNested3PartySubIDs(); }
            public bool IsSetNoNested3PartySubIDs() { return IsSetField(Tags.NoNested3PartySubIDs); }

            public class NoNested3PartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.Nested3PartySubID, Tags.Nested3PartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.Nested3PartySubID, Tags.Nested3PartySubIDType, 0};

                public NoNested3PartySubIDsGroup()
                  : base(Tags.NoNested3PartySubIDs, Tags.Nested3PartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNested3PartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public Nested3PartySubID Nested3PartySubID
                {
                    get
                    {
                        Nested3PartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested3PartySubID val) { Nested3PartySubID = val; }
                public Nested3PartySubID Get(Nested3PartySubID val) { GetField(val); return val; }
                public bool IsSet(Nested3PartySubID val) { return IsSetNested3PartySubID(); }
                public bool IsSetNested3PartySubID() { return IsSetField(Tags.Nested3PartySubID); }

                public Nested3PartySubIDType Nested3PartySubIDType
                {
                    get
                    {
                        Nested3PartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested3PartySubIDType val) { Nested3PartySubIDType = val; }
                public Nested3PartySubIDType Get(Nested3PartySubIDType val) { GetField(val); return val; }
                public bool IsSet(Nested3PartySubIDType val) { return IsSetNested3PartySubIDType(); }
                public bool IsSetNested3PartySubIDType() { return IsSetField(Tags.Nested3PartySubIDType); }
            }
        }

        public class NoLegAllocsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegAllocAccount, Tags.LegIndividualAllocID, Tags.LegAllocQty, Tags.LegAllocAcctIDSource, Tags.LegAllocSettlCurrency, Tags.NoNested2PartyIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.LegAllocAccount, Tags.LegIndividualAllocID, Tags.LegAllocQty, Tags.LegAllocAcctIDSource, Tags.LegAllocSettlCurrency, Tags.NoNested2PartyIDs, 0};

            public NoLegAllocsGroup()
              : base(Tags.NoLegAllocs, Tags.LegAllocAccount, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegAllocsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegAllocAccount LegAllocAccount
            {
                get
                {
                    LegAllocAccount val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegAllocAccount val) { LegAllocAccount = val; }
            public LegAllocAccount Get(LegAllocAccount val) { GetField(val); return val; }
            public bool IsSet(LegAllocAccount val) { return IsSetLegAllocAccount(); }
            public bool IsSetLegAllocAccount() { return IsSetField(Tags.LegAllocAccount); }

            public LegIndividualAllocID LegIndividualAllocID
            {
                get
                {
                    LegIndividualAllocID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegIndividualAllocID val) { LegIndividualAllocID = val; }
            public LegIndividualAllocID Get(LegIndividualAllocID val) { GetField(val); return val; }
            public bool IsSet(LegIndividualAllocID val) { return IsSetLegIndividualAllocID(); }
            public bool IsSetLegIndividualAllocID() { return IsSetField(Tags.LegIndividualAllocID); }

            public LegAllocQty LegAllocQty
            {
                get
                {
                    LegAllocQty val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegAllocQty val) { LegAllocQty = val; }
            public LegAllocQty Get(LegAllocQty val) { GetField(val); return val; }
            public bool IsSet(LegAllocQty val) { return IsSetLegAllocQty(); }
            public bool IsSetLegAllocQty() { return IsSetField(Tags.LegAllocQty); }

            public LegAllocAcctIDSource LegAllocAcctIDSource
            {
                get
                {
                    LegAllocAcctIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegAllocAcctIDSource val) { LegAllocAcctIDSource = val; }
            public LegAllocAcctIDSource Get(LegAllocAcctIDSource val) { GetField(val); return val; }
            public bool IsSet(LegAllocAcctIDSource val) { return IsSetLegAllocAcctIDSource(); }
            public bool IsSetLegAllocAcctIDSource() { return IsSetField(Tags.LegAllocAcctIDSource); }

            public LegAllocSettlCurrency LegAllocSettlCurrency
            {
                get
                {
                    LegAllocSettlCurrency val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegAllocSettlCurrency val) { LegAllocSettlCurrency = val; }
            public LegAllocSettlCurrency Get(LegAllocSettlCurrency val) { GetField(val); return val; }
            public bool IsSet(LegAllocSettlCurrency val) { return IsSetLegAllocSettlCurrency(); }
            public bool IsSetLegAllocSettlCurrency() { return IsSetField(Tags.LegAllocSettlCurrency); }

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

            public class NoNested2PartyIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoMiscFeesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoStrategyParametersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StrategyParameterName, Tags.StrategyParameterType, Tags.StrategyParameterValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoAllocsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoFillsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.FillExecID, Tags.FillPx, Tags.FillQty, Tags.NoNested4PartyIDs, Tags.FillLiquidityInd, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.FillExecID, Tags.FillPx, Tags.FillQty, Tags.NoNested4PartyIDs, Tags.FillLiquidityInd, 0};

        public NoFillsGroup()
          : base(Tags.NoFills, Tags.FillExecID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoFillsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public FillExecID FillExecID
        {
            get
            {
                FillExecID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FillExecID val) { FillExecID = val; }
        public FillExecID Get(FillExecID val) { GetField(val); return val; }
        public bool IsSet(FillExecID val) { return IsSetFillExecID(); }
        public bool IsSetFillExecID() { return IsSetField(Tags.FillExecID); }

        public FillPx FillPx
        {
            get
            {
                FillPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FillPx val) { FillPx = val; }
        public FillPx Get(FillPx val) { GetField(val); return val; }
        public bool IsSet(FillPx val) { return IsSetFillPx(); }
        public bool IsSetFillPx() { return IsSetField(Tags.FillPx); }

        public FillQty FillQty
        {
            get
            {
                FillQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FillQty val) { FillQty = val; }
        public FillQty Get(FillQty val) { GetField(val); return val; }
        public bool IsSet(FillQty val) { return IsSetFillQty(); }
        public bool IsSetFillQty() { return IsSetField(Tags.FillQty); }

        public NoNested4PartyIDs NoNested4PartyIDs
        {
            get
            {
                NoNested4PartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNested4PartyIDs val) { NoNested4PartyIDs = val; }
        public NoNested4PartyIDs Get(NoNested4PartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNested4PartyIDs val) { return IsSetNoNested4PartyIDs(); }
        public bool IsSetNoNested4PartyIDs() { return IsSetField(Tags.NoNested4PartyIDs); }

        public FillLiquidityInd FillLiquidityInd
        {
            get
            {
                FillLiquidityInd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FillLiquidityInd val) { FillLiquidityInd = val; }
        public FillLiquidityInd Get(FillLiquidityInd val) { GetField(val); return val; }
        public bool IsSet(FillLiquidityInd val) { return IsSetFillLiquidityInd(); }
        public bool IsSetFillLiquidityInd() { return IsSetField(Tags.FillLiquidityInd); }

        public class NoNested4PartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.Nested4PartyID, Tags.Nested4PartyIDSource, Tags.Nested4PartyRole, Tags.NoNested4PartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.Nested4PartyID, Tags.Nested4PartyIDSource, Tags.Nested4PartyRole, Tags.NoNested4PartySubIDs, 0};

            public NoNested4PartyIDsGroup()
              : base(Tags.NoNested4PartyIDs, Tags.Nested4PartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNested4PartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public Nested4PartyID Nested4PartyID
            {
                get
                {
                    Nested4PartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested4PartyID val) { Nested4PartyID = val; }
            public Nested4PartyID Get(Nested4PartyID val) { GetField(val); return val; }
            public bool IsSet(Nested4PartyID val) { return IsSetNested4PartyID(); }
            public bool IsSetNested4PartyID() { return IsSetField(Tags.Nested4PartyID); }

            public Nested4PartyIDSource Nested4PartyIDSource
            {
                get
                {
                    Nested4PartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested4PartyIDSource val) { Nested4PartyIDSource = val; }
            public Nested4PartyIDSource Get(Nested4PartyIDSource val) { GetField(val); return val; }
            public bool IsSet(Nested4PartyIDSource val) { return IsSetNested4PartyIDSource(); }
            public bool IsSetNested4PartyIDSource() { return IsSetField(Tags.Nested4PartyIDSource); }

            public Nested4PartyRole Nested4PartyRole
            {
                get
                {
                    Nested4PartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested4PartyRole val) { Nested4PartyRole = val; }
            public Nested4PartyRole Get(Nested4PartyRole val) { GetField(val); return val; }
            public bool IsSet(Nested4PartyRole val) { return IsSetNested4PartyRole(); }
            public bool IsSetNested4PartyRole() { return IsSetField(Tags.Nested4PartyRole); }

            public NoNested4PartySubIDs NoNested4PartySubIDs
            {
                get
                {
                    NoNested4PartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNested4PartySubIDs val) { NoNested4PartySubIDs = val; }
            public NoNested4PartySubIDs Get(NoNested4PartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNested4PartySubIDs val) { return IsSetNoNested4PartySubIDs(); }
            public bool IsSetNoNested4PartySubIDs() { return IsSetField(Tags.NoNested4PartySubIDs); }

            public class NoNested4PartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.Nested4PartySubID, Tags.Nested4PartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.Nested4PartySubID, Tags.Nested4PartySubIDType, 0};

                public NoNested4PartySubIDsGroup()
                  : base(Tags.NoNested4PartySubIDs, Tags.Nested4PartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNested4PartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public Nested4PartySubID Nested4PartySubID
                {
                    get
                    {
                        Nested4PartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested4PartySubID val) { Nested4PartySubID = val; }
                public Nested4PartySubID Get(Nested4PartySubID val) { GetField(val); return val; }
                public bool IsSet(Nested4PartySubID val) { return IsSetNested4PartySubID(); }
                public bool IsSetNested4PartySubID() { return IsSetField(Tags.Nested4PartySubID); }

                public Nested4PartySubIDType Nested4PartySubIDType
                {
                    get
                    {
                        Nested4PartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested4PartySubIDType val) { Nested4PartySubIDType = val; }
                public Nested4PartySubIDType Get(Nested4PartySubIDType val) { GetField(val); return val; }
                public bool IsSet(Nested4PartySubIDType val) { return IsSetNested4PartySubIDType(); }
                public bool IsSetNested4PartySubIDType() { return IsSetField(Tags.Nested4PartySubIDType); }
            }
        }
    }

    public class NoRateSourcesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RateSource, Tags.RateSourceType, Tags.ReferencePage, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RateSource, Tags.RateSourceType, Tags.ReferencePage, 0};

        public NoRateSourcesGroup()
          : base(Tags.NoRateSources, Tags.RateSource, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRateSourcesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RateSource RateSource
        {
            get
            {
                RateSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RateSource val) { RateSource = val; }
        public RateSource Get(RateSource val) { GetField(val); return val; }
        public bool IsSet(RateSource val) { return IsSetRateSource(); }
        public bool IsSetRateSource() { return IsSetField(Tags.RateSource); }

        public RateSourceType RateSourceType
        {
            get
            {
                RateSourceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RateSourceType val) { RateSourceType = val; }
        public RateSourceType Get(RateSourceType val) { GetField(val); return val; }
        public bool IsSet(RateSourceType val) { return IsSetRateSourceType(); }
        public bool IsSetRateSourceType() { return IsSetField(Tags.RateSourceType); }

        public ReferencePage ReferencePage
        {
            get
            {
                ReferencePage val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ReferencePage val) { ReferencePage = val; }
        public ReferencePage Get(ReferencePage val) { GetField(val); return val; }
        public bool IsSet(ReferencePage val) { return IsSetReferencePage(); }
        public bool IsSetReferencePage() { return IsSetField(Tags.ReferencePage); }
    }

    public class NoRegulatoryTradeIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RegulatoryTradeID, Tags.RegulatoryTradeIDSource, Tags.RegulatoryTradeIDEvent, Tags.RegulatoryTradeIDType, Tags.RegulatoryLegRefID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RegulatoryTradeID, Tags.RegulatoryTradeIDSource, Tags.RegulatoryTradeIDEvent, Tags.RegulatoryTradeIDType, Tags.RegulatoryLegRefID, 0};

        public NoRegulatoryTradeIDsGroup()
          : base(Tags.NoRegulatoryTradeIDs, Tags.RegulatoryTradeID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRegulatoryTradeIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RegulatoryTradeID RegulatoryTradeID
        {
            get
            {
                RegulatoryTradeID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RegulatoryTradeID val) { RegulatoryTradeID = val; }
        public RegulatoryTradeID Get(RegulatoryTradeID val) { GetField(val); return val; }
        public bool IsSet(RegulatoryTradeID val) { return IsSetRegulatoryTradeID(); }
        public bool IsSetRegulatoryTradeID() { return IsSetField(Tags.RegulatoryTradeID); }

        public RegulatoryTradeIDSource RegulatoryTradeIDSource
        {
            get
            {
                RegulatoryTradeIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RegulatoryTradeIDSource val) { RegulatoryTradeIDSource = val; }
        public RegulatoryTradeIDSource Get(RegulatoryTradeIDSource val) { GetField(val); return val; }
        public bool IsSet(RegulatoryTradeIDSource val) { return IsSetRegulatoryTradeIDSource(); }
        public bool IsSetRegulatoryTradeIDSource() { return IsSetField(Tags.RegulatoryTradeIDSource); }

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

        public RegulatoryLegRefID RegulatoryLegRefID
        {
            get
            {
                RegulatoryLegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RegulatoryLegRefID val) { RegulatoryLegRefID = val; }
        public RegulatoryLegRefID Get(RegulatoryLegRefID val) { GetField(val); return val; }
        public bool IsSet(RegulatoryLegRefID val) { return IsSetRegulatoryLegRefID(); }
        public bool IsSetRegulatoryLegRefID() { return IsSetField(Tags.RegulatoryLegRefID); }
    }

    public class NoInstrAttribGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.InstrAttribType, Tags.InstrAttribValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.InstrAttribType, Tags.InstrAttribValue, 0};

        public NoInstrAttribGroup()
          : base(Tags.NoInstrAttrib, Tags.InstrAttribType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoInstrAttribGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public InstrAttribType InstrAttribType
        {
            get
            {
                InstrAttribType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrAttribType val) { InstrAttribType = val; }
        public InstrAttribType Get(InstrAttribType val) { GetField(val); return val; }
        public bool IsSet(InstrAttribType val) { return IsSetInstrAttribType(); }
        public bool IsSetInstrAttribType() { return IsSetField(Tags.InstrAttribType); }

        public InstrAttribValue InstrAttribValue
        {
            get
            {
                InstrAttribValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrAttribValue val) { InstrAttribValue = val; }
        public InstrAttribValue Get(InstrAttribValue val) { GetField(val); return val; }
        public bool IsSet(InstrAttribValue val) { return IsSetInstrAttribValue(); }
        public bool IsSetInstrAttribValue() { return IsSetField(Tags.InstrAttribValue); }
    }

    public class NoPaymentsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PaymentType, Tags.PaymentPaySide, Tags.PaymentReceiveSide, Tags.PaymentDesc, Tags.PaymentCurrency, Tags.PaymentAmount, Tags.PaymentDateAdjusted, Tags.PaymentLegRefID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PaymentType, Tags.PaymentPaySide, Tags.PaymentReceiveSide, Tags.PaymentDesc, Tags.PaymentCurrency, Tags.PaymentAmount, Tags.PaymentDateAdjusted, Tags.PaymentLegRefID, 0};

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

        public PaymentPaySide PaymentPaySide
        {
            get
            {
                PaymentPaySide val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentPaySide val) { PaymentPaySide = val; }
        public PaymentPaySide Get(PaymentPaySide val) { GetField(val); return val; }
        public bool IsSet(PaymentPaySide val) { return IsSetPaymentPaySide(); }
        public bool IsSetPaymentPaySide() { return IsSetField(Tags.PaymentPaySide); }

        public PaymentReceiveSide PaymentReceiveSide
        {
            get
            {
                PaymentReceiveSide val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentReceiveSide val) { PaymentReceiveSide = val; }
        public PaymentReceiveSide Get(PaymentReceiveSide val) { GetField(val); return val; }
        public bool IsSet(PaymentReceiveSide val) { return IsSetPaymentReceiveSide(); }
        public bool IsSetPaymentReceiveSide() { return IsSetField(Tags.PaymentReceiveSide); }

        public PaymentDesc PaymentDesc
        {
            get
            {
                PaymentDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentDesc val) { PaymentDesc = val; }
        public PaymentDesc Get(PaymentDesc val) { GetField(val); return val; }
        public bool IsSet(PaymentDesc val) { return IsSetPaymentDesc(); }
        public bool IsSetPaymentDesc() { return IsSetField(Tags.PaymentDesc); }

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

        public PaymentLegRefID PaymentLegRefID
        {
            get
            {
                PaymentLegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PaymentLegRefID val) { PaymentLegRefID = val; }
        public PaymentLegRefID Get(PaymentLegRefID val) { GetField(val); return val; }
        public bool IsSet(PaymentLegRefID val) { return IsSetPaymentLegRefID(); }
        public bool IsSetPaymentLegRefID() { return IsSetField(Tags.PaymentLegRefID); }
    }

    public class NoOrderAttributesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.OrderAttributeType, Tags.OrderAttributeValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoRelativeValuesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RelativeValueType, Tags.RelativeValue, Tags.RelativeValueLegRefID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RelativeValueType, Tags.RelativeValue, Tags.RelativeValueLegRefID, 0};

        public NoRelativeValuesGroup()
          : base(Tags.NoRelativeValues, Tags.RelativeValueType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRelativeValuesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RelativeValueType RelativeValueType
        {
            get
            {
                RelativeValueType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelativeValueType val) { RelativeValueType = val; }
        public RelativeValueType Get(RelativeValueType val) { GetField(val); return val; }
        public bool IsSet(RelativeValueType val) { return IsSetRelativeValueType(); }
        public bool IsSetRelativeValueType() { return IsSetField(Tags.RelativeValueType); }

        public RelativeValue RelativeValue
        {
            get
            {
                RelativeValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelativeValue val) { RelativeValue = val; }
        public RelativeValue Get(RelativeValue val) { GetField(val); return val; }
        public bool IsSet(RelativeValue val) { return IsSetRelativeValue(); }
        public bool IsSetRelativeValue() { return IsSetField(Tags.RelativeValue); }

        public RelativeValueLegRefID RelativeValueLegRefID
        {
            get
            {
                RelativeValueLegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelativeValueLegRefID val) { RelativeValueLegRefID = val; }
        public RelativeValueLegRefID Get(RelativeValueLegRefID val) { GetField(val); return val; }
        public bool IsSet(RelativeValueLegRefID val) { return IsSetRelativeValueLegRefID(); }
        public bool IsSetRelativeValueLegRefID() { return IsSetField(Tags.RelativeValueLegRefID); }
    }

    public class NoTrdRegPublicationsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TrdRegPublicationType, Tags.TrdRegPublicationReason, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoTradePriceConditionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TradePriceCondition, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.TradePriceCondition, 0};

        public NoTradePriceConditionsGroup()
          : base(Tags.NoTradePriceConditions, Tags.TradePriceCondition, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTradePriceConditionsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public TradePriceCondition TradePriceCondition
        {
            get
            {
                TradePriceCondition val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradePriceCondition val) { TradePriceCondition = val; }
        public TradePriceCondition Get(TradePriceCondition val) { GetField(val); return val; }
        public bool IsSet(TradePriceCondition val) { return IsSetTradePriceCondition(); }
        public bool IsSetTradePriceCondition() { return IsSetField(Tags.TradePriceCondition); }
    }

    public class NoClearingInstructionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClearingInstruction, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoPosAmtGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PosAmtType, Tags.PosAmt, Tags.PositionCurrency, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PosAmtType, Tags.PosAmt, Tags.PositionCurrency, 0};

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

        public PositionCurrency PositionCurrency
        {
            get
            {
                PositionCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PositionCurrency val) { PositionCurrency = val; }
        public PositionCurrency Get(PositionCurrency val) { GetField(val); return val; }
        public bool IsSet(PositionCurrency val) { return IsSetPositionCurrency(); }
        public bool IsSetPositionCurrency() { return IsSetField(Tags.PositionCurrency); }
    }

    public class NoQuoteQualifiersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.QuoteQualifier, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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

    public class NoRelatedInstrumentsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RelatedInstrumentType, Tags.RelatedSecurityID, Tags.RelatedSecurityIDSource, Tags.RelatedToSecurityID, Tags.RelatedToSecurityIDSource, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RelatedInstrumentType, Tags.RelatedSecurityID, Tags.RelatedSecurityIDSource, Tags.RelatedToSecurityID, Tags.RelatedToSecurityIDSource, 0};

        public NoRelatedInstrumentsGroup()
          : base(Tags.NoRelatedInstruments, Tags.RelatedInstrumentType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRelatedInstrumentsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RelatedInstrumentType RelatedInstrumentType
        {
            get
            {
                RelatedInstrumentType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelatedInstrumentType val) { RelatedInstrumentType = val; }
        public RelatedInstrumentType Get(RelatedInstrumentType val) { GetField(val); return val; }
        public bool IsSet(RelatedInstrumentType val) { return IsSetRelatedInstrumentType(); }
        public bool IsSetRelatedInstrumentType() { return IsSetField(Tags.RelatedInstrumentType); }

        public RelatedSecurityID RelatedSecurityID
        {
            get
            {
                RelatedSecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelatedSecurityID val) { RelatedSecurityID = val; }
        public RelatedSecurityID Get(RelatedSecurityID val) { GetField(val); return val; }
        public bool IsSet(RelatedSecurityID val) { return IsSetRelatedSecurityID(); }
        public bool IsSetRelatedSecurityID() { return IsSetField(Tags.RelatedSecurityID); }

        public RelatedSecurityIDSource RelatedSecurityIDSource
        {
            get
            {
                RelatedSecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelatedSecurityIDSource val) { RelatedSecurityIDSource = val; }
        public RelatedSecurityIDSource Get(RelatedSecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(RelatedSecurityIDSource val) { return IsSetRelatedSecurityIDSource(); }
        public bool IsSetRelatedSecurityIDSource() { return IsSetField(Tags.RelatedSecurityIDSource); }

        public RelatedToSecurityID RelatedToSecurityID
        {
            get
            {
                RelatedToSecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelatedToSecurityID val) { RelatedToSecurityID = val; }
        public RelatedToSecurityID Get(RelatedToSecurityID val) { GetField(val); return val; }
        public bool IsSet(RelatedToSecurityID val) { return IsSetRelatedToSecurityID(); }
        public bool IsSetRelatedToSecurityID() { return IsSetField(Tags.RelatedToSecurityID); }

        public RelatedToSecurityIDSource RelatedToSecurityIDSource
        {
            get
            {
                RelatedToSecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RelatedToSecurityIDSource val) { RelatedToSecurityIDSource = val; }
        public RelatedToSecurityIDSource Get(RelatedToSecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(RelatedToSecurityIDSource val) { return IsSetRelatedToSecurityIDSource(); }
        public bool IsSetRelatedToSecurityIDSource() { return IsSetField(Tags.RelatedToSecurityIDSource); }
    }

    public class NoClientCustomDataGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClientCustomDataName, Tags.ClientCustomDataValue, Tags.ClientCustomDataType, Tags.ClientCustomDataStreamDesc, Tags.ClientCustomDataPrecision, Tags.ClientCustomDataLegRefID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ClientCustomDataName, Tags.ClientCustomDataValue, Tags.ClientCustomDataType, Tags.ClientCustomDataStreamDesc, Tags.ClientCustomDataPrecision, Tags.ClientCustomDataLegRefID, 0};

        public NoClientCustomDataGroup()
          : base(Tags.NoClientCustomData, Tags.ClientCustomDataName, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoClientCustomDataGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ClientCustomDataName ClientCustomDataName
        {
            get
            {
                ClientCustomDataName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClientCustomDataName val) { ClientCustomDataName = val; }
        public ClientCustomDataName Get(ClientCustomDataName val) { GetField(val); return val; }
        public bool IsSet(ClientCustomDataName val) { return IsSetClientCustomDataName(); }
        public bool IsSetClientCustomDataName() { return IsSetField(Tags.ClientCustomDataName); }

        public ClientCustomDataValue ClientCustomDataValue
        {
            get
            {
                ClientCustomDataValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClientCustomDataValue val) { ClientCustomDataValue = val; }
        public ClientCustomDataValue Get(ClientCustomDataValue val) { GetField(val); return val; }
        public bool IsSet(ClientCustomDataValue val) { return IsSetClientCustomDataValue(); }
        public bool IsSetClientCustomDataValue() { return IsSetField(Tags.ClientCustomDataValue); }

        public ClientCustomDataType ClientCustomDataType
        {
            get
            {
                ClientCustomDataType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClientCustomDataType val) { ClientCustomDataType = val; }
        public ClientCustomDataType Get(ClientCustomDataType val) { GetField(val); return val; }
        public bool IsSet(ClientCustomDataType val) { return IsSetClientCustomDataType(); }
        public bool IsSetClientCustomDataType() { return IsSetField(Tags.ClientCustomDataType); }

        public ClientCustomDataStreamDesc ClientCustomDataStreamDesc
        {
            get
            {
                ClientCustomDataStreamDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClientCustomDataStreamDesc val) { ClientCustomDataStreamDesc = val; }
        public ClientCustomDataStreamDesc Get(ClientCustomDataStreamDesc val) { GetField(val); return val; }
        public bool IsSet(ClientCustomDataStreamDesc val) { return IsSetClientCustomDataStreamDesc(); }
        public bool IsSetClientCustomDataStreamDesc() { return IsSetField(Tags.ClientCustomDataStreamDesc); }

        public ClientCustomDataPrecision ClientCustomDataPrecision
        {
            get
            {
                ClientCustomDataPrecision val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClientCustomDataPrecision val) { ClientCustomDataPrecision = val; }
        public ClientCustomDataPrecision Get(ClientCustomDataPrecision val) { GetField(val); return val; }
        public bool IsSet(ClientCustomDataPrecision val) { return IsSetClientCustomDataPrecision(); }
        public bool IsSetClientCustomDataPrecision() { return IsSetField(Tags.ClientCustomDataPrecision); }

        public ClientCustomDataLegRefID ClientCustomDataLegRefID
        {
            get
            {
                ClientCustomDataLegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClientCustomDataLegRefID val) { ClientCustomDataLegRefID = val; }
        public ClientCustomDataLegRefID Get(ClientCustomDataLegRefID val) { GetField(val); return val; }
        public bool IsSet(ClientCustomDataLegRefID val) { return IsSetClientCustomDataLegRefID(); }
        public bool IsSetClientCustomDataLegRefID() { return IsSetField(Tags.ClientCustomDataLegRefID); }
    }

    public class NoCompDealerQuotesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.CompDealerID, Tags.CompDealerQuotePrice, Tags.CompDealerQuotePriceType, Tags.CompDealerParQuote, Tags.DealerNetMoney, Tags.CompDealerQuotePriceLeg2, Tags.CompDealerQuoteForwardPoints, Tags.CompDealerQuoteSwapPoints, Tags.CompDealerQuoteOrdQty, Tags.CompDealerRollSpread, Tags.CompDealerQuoteType, Tags.CompDealerQuoteLegRefID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.CompDealerID, Tags.CompDealerQuotePrice, Tags.CompDealerQuotePriceType, Tags.CompDealerParQuote, Tags.DealerNetMoney, Tags.CompDealerQuotePriceLeg2, Tags.CompDealerQuoteForwardPoints, Tags.CompDealerQuoteSwapPoints, Tags.CompDealerQuoteOrdQty, Tags.CompDealerRollSpread, Tags.CompDealerQuoteType, Tags.CompDealerQuoteLegRefID, 0};

        public NoCompDealerQuotesGroup()
          : base(Tags.NoCompDealerQuotes, Tags.CompDealerID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoCompDealerQuotesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public CompDealerID CompDealerID
        {
            get
            {
                CompDealerID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerID val) { CompDealerID = val; }
        public CompDealerID Get(CompDealerID val) { GetField(val); return val; }
        public bool IsSet(CompDealerID val) { return IsSetCompDealerID(); }
        public bool IsSetCompDealerID() { return IsSetField(Tags.CompDealerID); }

        public CompDealerQuotePrice CompDealerQuotePrice
        {
            get
            {
                CompDealerQuotePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerQuotePrice val) { CompDealerQuotePrice = val; }
        public CompDealerQuotePrice Get(CompDealerQuotePrice val) { GetField(val); return val; }
        public bool IsSet(CompDealerQuotePrice val) { return IsSetCompDealerQuotePrice(); }
        public bool IsSetCompDealerQuotePrice() { return IsSetField(Tags.CompDealerQuotePrice); }

        public CompDealerQuotePriceType CompDealerQuotePriceType
        {
            get
            {
                CompDealerQuotePriceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerQuotePriceType val) { CompDealerQuotePriceType = val; }
        public CompDealerQuotePriceType Get(CompDealerQuotePriceType val) { GetField(val); return val; }
        public bool IsSet(CompDealerQuotePriceType val) { return IsSetCompDealerQuotePriceType(); }
        public bool IsSetCompDealerQuotePriceType() { return IsSetField(Tags.CompDealerQuotePriceType); }

        public CompDealerParQuote CompDealerParQuote
        {
            get
            {
                CompDealerParQuote val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerParQuote val) { CompDealerParQuote = val; }
        public CompDealerParQuote Get(CompDealerParQuote val) { GetField(val); return val; }
        public bool IsSet(CompDealerParQuote val) { return IsSetCompDealerParQuote(); }
        public bool IsSetCompDealerParQuote() { return IsSetField(Tags.CompDealerParQuote); }

        public DealerNetMoney DealerNetMoney
        {
            get
            {
                DealerNetMoney val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DealerNetMoney val) { DealerNetMoney = val; }
        public DealerNetMoney Get(DealerNetMoney val) { GetField(val); return val; }
        public bool IsSet(DealerNetMoney val) { return IsSetDealerNetMoney(); }
        public bool IsSetDealerNetMoney() { return IsSetField(Tags.DealerNetMoney); }

        public CompDealerQuotePriceLeg2 CompDealerQuotePriceLeg2
        {
            get
            {
                CompDealerQuotePriceLeg2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerQuotePriceLeg2 val) { CompDealerQuotePriceLeg2 = val; }
        public CompDealerQuotePriceLeg2 Get(CompDealerQuotePriceLeg2 val) { GetField(val); return val; }
        public bool IsSet(CompDealerQuotePriceLeg2 val) { return IsSetCompDealerQuotePriceLeg2(); }
        public bool IsSetCompDealerQuotePriceLeg2() { return IsSetField(Tags.CompDealerQuotePriceLeg2); }

        public CompDealerQuoteForwardPoints CompDealerQuoteForwardPoints
        {
            get
            {
                CompDealerQuoteForwardPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerQuoteForwardPoints val) { CompDealerQuoteForwardPoints = val; }
        public CompDealerQuoteForwardPoints Get(CompDealerQuoteForwardPoints val) { GetField(val); return val; }
        public bool IsSet(CompDealerQuoteForwardPoints val) { return IsSetCompDealerQuoteForwardPoints(); }
        public bool IsSetCompDealerQuoteForwardPoints() { return IsSetField(Tags.CompDealerQuoteForwardPoints); }

        public CompDealerQuoteSwapPoints CompDealerQuoteSwapPoints
        {
            get
            {
                CompDealerQuoteSwapPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerQuoteSwapPoints val) { CompDealerQuoteSwapPoints = val; }
        public CompDealerQuoteSwapPoints Get(CompDealerQuoteSwapPoints val) { GetField(val); return val; }
        public bool IsSet(CompDealerQuoteSwapPoints val) { return IsSetCompDealerQuoteSwapPoints(); }
        public bool IsSetCompDealerQuoteSwapPoints() { return IsSetField(Tags.CompDealerQuoteSwapPoints); }

        public CompDealerQuoteOrdQty CompDealerQuoteOrdQty
        {
            get
            {
                CompDealerQuoteOrdQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerQuoteOrdQty val) { CompDealerQuoteOrdQty = val; }
        public CompDealerQuoteOrdQty Get(CompDealerQuoteOrdQty val) { GetField(val); return val; }
        public bool IsSet(CompDealerQuoteOrdQty val) { return IsSetCompDealerQuoteOrdQty(); }
        public bool IsSetCompDealerQuoteOrdQty() { return IsSetField(Tags.CompDealerQuoteOrdQty); }

        public CompDealerRollSpread CompDealerRollSpread
        {
            get
            {
                CompDealerRollSpread val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerRollSpread val) { CompDealerRollSpread = val; }
        public CompDealerRollSpread Get(CompDealerRollSpread val) { GetField(val); return val; }
        public bool IsSet(CompDealerRollSpread val) { return IsSetCompDealerRollSpread(); }
        public bool IsSetCompDealerRollSpread() { return IsSetField(Tags.CompDealerRollSpread); }

        public CompDealerQuoteType CompDealerQuoteType
        {
            get
            {
                CompDealerQuoteType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerQuoteType val) { CompDealerQuoteType = val; }
        public CompDealerQuoteType Get(CompDealerQuoteType val) { GetField(val); return val; }
        public bool IsSet(CompDealerQuoteType val) { return IsSetCompDealerQuoteType(); }
        public bool IsSetCompDealerQuoteType() { return IsSetField(Tags.CompDealerQuoteType); }

        public CompDealerQuoteLegRefID CompDealerQuoteLegRefID
        {
            get
            {
                CompDealerQuoteLegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CompDealerQuoteLegRefID val) { CompDealerQuoteLegRefID = val; }
        public CompDealerQuoteLegRefID Get(CompDealerQuoteLegRefID val) { GetField(val); return val; }
        public bool IsSet(CompDealerQuoteLegRefID val) { return IsSetCompDealerQuoteLegRefID(); }
        public bool IsSetCompDealerQuoteLegRefID() { return IsSetField(Tags.CompDealerQuoteLegRefID); }
    }

    public class NoRefPricesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RefPrice, Tags.RefPriceType, Tags.RefPriceSource, Tags.RefPriceFirmIndicator, Tags.RefPriceInventoryIndicator, Tags.RefQuoteID, Tags.RefPriceSide, Tags.RefPriceText, Tags.RefPriceleg2, Tags.RefPriceForwardPoints, Tags.RefPriceSwapPoints, Tags.RefPriceSize, Tags.RefPriceTime, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RefPrice, Tags.RefPriceType, Tags.RefPriceSource, Tags.RefPriceFirmIndicator, Tags.RefPriceInventoryIndicator, Tags.RefQuoteID, Tags.RefPriceSide, Tags.RefPriceText, Tags.RefPriceleg2, Tags.RefPriceForwardPoints, Tags.RefPriceSwapPoints, Tags.RefPriceSize, Tags.RefPriceTime, 0};

        public NoRefPricesGroup()
          : base(Tags.NoRefPrices, Tags.RefPrice, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRefPricesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RefPrice RefPrice
        {
            get
            {
                RefPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPrice val) { RefPrice = val; }
        public RefPrice Get(RefPrice val) { GetField(val); return val; }
        public bool IsSet(RefPrice val) { return IsSetRefPrice(); }
        public bool IsSetRefPrice() { return IsSetField(Tags.RefPrice); }

        public RefPriceType RefPriceType
        {
            get
            {
                RefPriceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceType val) { RefPriceType = val; }
        public RefPriceType Get(RefPriceType val) { GetField(val); return val; }
        public bool IsSet(RefPriceType val) { return IsSetRefPriceType(); }
        public bool IsSetRefPriceType() { return IsSetField(Tags.RefPriceType); }

        public RefPriceSource RefPriceSource
        {
            get
            {
                RefPriceSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceSource val) { RefPriceSource = val; }
        public RefPriceSource Get(RefPriceSource val) { GetField(val); return val; }
        public bool IsSet(RefPriceSource val) { return IsSetRefPriceSource(); }
        public bool IsSetRefPriceSource() { return IsSetField(Tags.RefPriceSource); }

        public RefPriceFirmIndicator RefPriceFirmIndicator
        {
            get
            {
                RefPriceFirmIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceFirmIndicator val) { RefPriceFirmIndicator = val; }
        public RefPriceFirmIndicator Get(RefPriceFirmIndicator val) { GetField(val); return val; }
        public bool IsSet(RefPriceFirmIndicator val) { return IsSetRefPriceFirmIndicator(); }
        public bool IsSetRefPriceFirmIndicator() { return IsSetField(Tags.RefPriceFirmIndicator); }

        public RefPriceInventoryIndicator RefPriceInventoryIndicator
        {
            get
            {
                RefPriceInventoryIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceInventoryIndicator val) { RefPriceInventoryIndicator = val; }
        public RefPriceInventoryIndicator Get(RefPriceInventoryIndicator val) { GetField(val); return val; }
        public bool IsSet(RefPriceInventoryIndicator val) { return IsSetRefPriceInventoryIndicator(); }
        public bool IsSetRefPriceInventoryIndicator() { return IsSetField(Tags.RefPriceInventoryIndicator); }

        public RefQuoteID RefQuoteID
        {
            get
            {
                RefQuoteID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefQuoteID val) { RefQuoteID = val; }
        public RefQuoteID Get(RefQuoteID val) { GetField(val); return val; }
        public bool IsSet(RefQuoteID val) { return IsSetRefQuoteID(); }
        public bool IsSetRefQuoteID() { return IsSetField(Tags.RefQuoteID); }

        public RefPriceSide RefPriceSide
        {
            get
            {
                RefPriceSide val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceSide val) { RefPriceSide = val; }
        public RefPriceSide Get(RefPriceSide val) { GetField(val); return val; }
        public bool IsSet(RefPriceSide val) { return IsSetRefPriceSide(); }
        public bool IsSetRefPriceSide() { return IsSetField(Tags.RefPriceSide); }

        public RefPriceText RefPriceText
        {
            get
            {
                RefPriceText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceText val) { RefPriceText = val; }
        public RefPriceText Get(RefPriceText val) { GetField(val); return val; }
        public bool IsSet(RefPriceText val) { return IsSetRefPriceText(); }
        public bool IsSetRefPriceText() { return IsSetField(Tags.RefPriceText); }

        public RefPriceleg2 RefPriceleg2
        {
            get
            {
                RefPriceleg2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceleg2 val) { RefPriceleg2 = val; }
        public RefPriceleg2 Get(RefPriceleg2 val) { GetField(val); return val; }
        public bool IsSet(RefPriceleg2 val) { return IsSetRefPriceleg2(); }
        public bool IsSetRefPriceleg2() { return IsSetField(Tags.RefPriceleg2); }

        public RefPriceForwardPoints RefPriceForwardPoints
        {
            get
            {
                RefPriceForwardPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceForwardPoints val) { RefPriceForwardPoints = val; }
        public RefPriceForwardPoints Get(RefPriceForwardPoints val) { GetField(val); return val; }
        public bool IsSet(RefPriceForwardPoints val) { return IsSetRefPriceForwardPoints(); }
        public bool IsSetRefPriceForwardPoints() { return IsSetField(Tags.RefPriceForwardPoints); }

        public RefPriceSwapPoints RefPriceSwapPoints
        {
            get
            {
                RefPriceSwapPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceSwapPoints val) { RefPriceSwapPoints = val; }
        public RefPriceSwapPoints Get(RefPriceSwapPoints val) { GetField(val); return val; }
        public bool IsSet(RefPriceSwapPoints val) { return IsSetRefPriceSwapPoints(); }
        public bool IsSetRefPriceSwapPoints() { return IsSetField(Tags.RefPriceSwapPoints); }

        public RefPriceSize RefPriceSize
        {
            get
            {
                RefPriceSize val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceSize val) { RefPriceSize = val; }
        public RefPriceSize Get(RefPriceSize val) { GetField(val); return val; }
        public bool IsSet(RefPriceSize val) { return IsSetRefPriceSize(); }
        public bool IsSetRefPriceSize() { return IsSetField(Tags.RefPriceSize); }

        public RefPriceTime RefPriceTime
        {
            get
            {
                RefPriceTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefPriceTime val) { RefPriceTime = val; }
        public RefPriceTime Get(RefPriceTime val) { GetField(val); return val; }
        public bool IsSet(RefPriceTime val) { return IsSetRefPriceTime(); }
        public bool IsSetRefPriceTime() { return IsSetField(Tags.RefPriceTime); }
    }

    public class NoReferenceIdsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ReferenceIDType, Tags.ReferenceID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ReferenceIDType, Tags.ReferenceID, 0};

        public NoReferenceIdsGroup()
          : base(Tags.NoReferenceIds, Tags.ReferenceIDType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoReferenceIdsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ReferenceIDType ReferenceIDType
        {
            get
            {
                ReferenceIDType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ReferenceIDType val) { ReferenceIDType = val; }
        public ReferenceIDType Get(ReferenceIDType val) { GetField(val); return val; }
        public bool IsSet(ReferenceIDType val) { return IsSetReferenceIDType(); }
        public bool IsSetReferenceIDType() { return IsSetField(Tags.ReferenceIDType); }

        public ReferenceID ReferenceID
        {
            get
            {
                ReferenceID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ReferenceID val) { ReferenceID = val; }
        public ReferenceID Get(ReferenceID val) { GetField(val); return val; }
        public bool IsSet(ReferenceID val) { return IsSetReferenceID(); }
        public bool IsSetReferenceID() { return IsSetField(Tags.ReferenceID); }
    }

    public class NoPriceQualifiersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PriceQualifier, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PriceQualifier, 0};

        public NoPriceQualifiersGroup()
          : base(Tags.NoPriceQualifiers, Tags.PriceQualifier, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPriceQualifiersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PriceQualifier PriceQualifier
        {
            get
            {
                PriceQualifier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceQualifier val) { PriceQualifier = val; }
        public PriceQualifier Get(PriceQualifier val) { GetField(val); return val; }
        public bool IsSet(PriceQualifier val) { return IsSetPriceQualifier(); }
        public bool IsSetPriceQualifier() { return IsSetField(Tags.PriceQualifier); }
    }

    public class NoNotesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.NoteType, Tags.NoteLabel, Tags.NoteText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
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
