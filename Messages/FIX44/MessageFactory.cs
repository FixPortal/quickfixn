// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix.FIX44;

public class MessageFactory : IMessageFactory
{
    public ICollection<string> GetSupportedBeginStrings()
    {
       return new [] { BeginString.FIX44 };
    }

    public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
    {
        return Create(beginString, msgType);
    }

    public QuickFix.Message Create(string beginString, string msgType)
    {
        return msgType switch
        {
            QuickFix.FIX44.TestRequest.MsgType => new QuickFix.FIX44.TestRequest(),
            QuickFix.FIX44.ResendRequest.MsgType => new QuickFix.FIX44.ResendRequest(),
            QuickFix.FIX44.Reject.MsgType => new QuickFix.FIX44.Reject(),
            QuickFix.FIX44.SequenceReset.MsgType => new QuickFix.FIX44.SequenceReset(),
            QuickFix.FIX44.IndicationOfInterest.MsgType => new QuickFix.FIX44.IndicationOfInterest(),
            QuickFix.FIX44.Logon.MsgType => new QuickFix.FIX44.Logon(),
            QuickFix.FIX44.Email.MsgType => new QuickFix.FIX44.Email(),
            QuickFix.FIX44.QuoteRequest.MsgType => new QuickFix.FIX44.QuoteRequest(),
            QuickFix.FIX44.QuoteResponse.MsgType => new QuickFix.FIX44.QuoteResponse(),
            QuickFix.FIX44.News.MsgType => new QuickFix.FIX44.News(),
            QuickFix.FIX44.UserRequest.MsgType => new QuickFix.FIX44.UserRequest(),
            QuickFix.FIX44.UserResponse.MsgType => new QuickFix.FIX44.UserResponse(),
            QuickFix.FIX44.Logout.MsgType => new QuickFix.FIX44.Logout(),
            QuickFix.FIX44.Heartbeat.MsgType => new QuickFix.FIX44.Heartbeat(),
            QuickFix.FIX44.BusinessMessageReject.MsgType => new QuickFix.FIX44.BusinessMessageReject(),
            QuickFix.FIX44.ExecutionReport.MsgType => new QuickFix.FIX44.ExecutionReport(),
            QuickFix.FIX44.OrderCancelReject.MsgType => new QuickFix.FIX44.OrderCancelReject(),
            QuickFix.FIX44.OrderStatusRequest.MsgType => new QuickFix.FIX44.OrderStatusRequest(),
            QuickFix.FIX44.OrderMassCancelRequest.MsgType => new QuickFix.FIX44.OrderMassCancelRequest(),
            QuickFix.FIX44.NewOrderCross.MsgType => new QuickFix.FIX44.NewOrderCross(),
            QuickFix.FIX44.CrossOrderCancelReplaceRequest.MsgType => new QuickFix.FIX44.CrossOrderCancelReplaceRequest(),
            QuickFix.FIX44.CrossOrderCancelRequest.MsgType => new QuickFix.FIX44.CrossOrderCancelRequest(),
            QuickFix.FIX44.OrderMassCancelReport.MsgType => new QuickFix.FIX44.OrderMassCancelReport(),
            QuickFix.FIX44.OrderMassStatusRequest.MsgType => new QuickFix.FIX44.OrderMassStatusRequest(),
            QuickFix.FIX44.NewOrderSingle.MsgType => new QuickFix.FIX44.NewOrderSingle(),
            QuickFix.FIX44.ListStrikePrice.MsgType => new QuickFix.FIX44.ListStrikePrice(),
            QuickFix.FIX44.ListStatus.MsgType => new QuickFix.FIX44.ListStatus(),
            QuickFix.FIX44.ListExecute.MsgType => new QuickFix.FIX44.ListExecute(),
            QuickFix.FIX44.ListCancelRequest.MsgType => new QuickFix.FIX44.ListCancelRequest(),
            QuickFix.FIX44.ListStatusRequest.MsgType => new QuickFix.FIX44.ListStatusRequest(),
            QuickFix.FIX44.NewOrderList.MsgType => new QuickFix.FIX44.NewOrderList(),
            QuickFix.FIX44.OrderCancelRequest.MsgType => new QuickFix.FIX44.OrderCancelRequest(),
            QuickFix.FIX44.OrderCancelReplaceRequest.MsgType => new QuickFix.FIX44.OrderCancelReplaceRequest(),
            QuickFix.FIX44.AllocationInstruction.MsgType => new QuickFix.FIX44.AllocationInstruction(),
            QuickFix.FIX44.AllocationInstructionAck.MsgType => new QuickFix.FIX44.AllocationInstructionAck(),
            QuickFix.FIX44.XMLnonFIX.MsgType => new QuickFix.FIX44.XMLnonFIX(),
            QuickFix.FIX44.NewOrderMultileg.MsgType => new QuickFix.FIX44.NewOrderMultileg(),
            QuickFix.FIX44.BidRequest.MsgType => new QuickFix.FIX44.BidRequest(),
            QuickFix.FIX44.BidResponse.MsgType => new QuickFix.FIX44.BidResponse(),
            QuickFix.FIX44.MultilegOrderCancelReplace.MsgType => new QuickFix.FIX44.MultilegOrderCancelReplace(),
            QuickFix.FIX44.TradeCaptureReportRequestAck.MsgType => new QuickFix.FIX44.TradeCaptureReportRequestAck(),
            QuickFix.FIX44.TradeCaptureReportRequest.MsgType => new QuickFix.FIX44.TradeCaptureReportRequest(),
            QuickFix.FIX44.TradeCaptureReport.MsgType => new QuickFix.FIX44.TradeCaptureReport(),
            QuickFix.FIX44.SettlementInstructions.MsgType => new QuickFix.FIX44.SettlementInstructions(),
            QuickFix.FIX44.SettlementInstructionRequest.MsgType => new QuickFix.FIX44.SettlementInstructionRequest(),
            QuickFix.FIX44.ConfirmationAck.MsgType => new QuickFix.FIX44.ConfirmationAck(),
            QuickFix.FIX44.ConfirmationRequest.MsgType => new QuickFix.FIX44.ConfirmationRequest(),
            QuickFix.FIX44.Confirmation.MsgType => new QuickFix.FIX44.Confirmation(),
            QuickFix.FIX44.PositionMaintenanceRequest.MsgType => new QuickFix.FIX44.PositionMaintenanceRequest(),
            QuickFix.FIX44.PositionMaintenanceReport.MsgType => new QuickFix.FIX44.PositionMaintenanceReport(),
            QuickFix.FIX44.RequestForPositions.MsgType => new QuickFix.FIX44.RequestForPositions(),
            QuickFix.FIX44.RequestForPositionsAck.MsgType => new QuickFix.FIX44.RequestForPositionsAck(),
            QuickFix.FIX44.PositionReport.MsgType => new QuickFix.FIX44.PositionReport(),
            QuickFix.FIX44.AssignmentReport.MsgType => new QuickFix.FIX44.AssignmentReport(),
            QuickFix.FIX44.CollateralRequest.MsgType => new QuickFix.FIX44.CollateralRequest(),
            QuickFix.FIX44.CollateralAssignment.MsgType => new QuickFix.FIX44.CollateralAssignment(),
            QuickFix.FIX44.CollateralResponse.MsgType => new QuickFix.FIX44.CollateralResponse(),
            QuickFix.FIX44.CollateralReport.MsgType => new QuickFix.FIX44.CollateralReport(),
            QuickFix.FIX44.NetworkStatusRequest.MsgType => new QuickFix.FIX44.NetworkStatusRequest(),
            QuickFix.FIX44.NetworkStatusResponse.MsgType => new QuickFix.FIX44.NetworkStatusResponse(),
            QuickFix.FIX44.CollateralInquiryAck.MsgType => new QuickFix.FIX44.CollateralInquiryAck(),
            QuickFix.FIX44.CollateralInquiry.MsgType => new QuickFix.FIX44.CollateralInquiry(),
            QuickFix.FIX44.RegistrationInstructions.MsgType => new QuickFix.FIX44.RegistrationInstructions(),
            QuickFix.FIX44.RegistrationInstructionsResponse.MsgType => new QuickFix.FIX44.RegistrationInstructionsResponse(),
            QuickFix.FIX44.TradeCaptureReportAck.MsgType => new QuickFix.FIX44.TradeCaptureReportAck(),
            QuickFix.FIX44.AllocationReport.MsgType => new QuickFix.FIX44.AllocationReport(),
            QuickFix.FIX44.AllocationReportAck.MsgType => new QuickFix.FIX44.AllocationReportAck(),
            QuickFix.FIX44.Advertisement.MsgType => new QuickFix.FIX44.Advertisement(),
            QuickFix.FIX44.MarketDataRequest.MsgType => new QuickFix.FIX44.MarketDataRequest(),
            QuickFix.FIX44.MarketDataSnapshotFullRefresh.MsgType => new QuickFix.FIX44.MarketDataSnapshotFullRefresh(),
            QuickFix.FIX44.MarketDataIncrementalRefresh.MsgType => new QuickFix.FIX44.MarketDataIncrementalRefresh(),
            QuickFix.FIX44.MarketDataRequestReject.MsgType => new QuickFix.FIX44.MarketDataRequestReject(),
            QuickFix.FIX44.SecurityDefinitionRequest.MsgType => new QuickFix.FIX44.SecurityDefinitionRequest(),
            QuickFix.FIX44.SecurityDefinition.MsgType => new QuickFix.FIX44.SecurityDefinition(),
            QuickFix.FIX44.SecurityTypeRequest.MsgType => new QuickFix.FIX44.SecurityTypeRequest(),
            QuickFix.FIX44.SecurityTypes.MsgType => new QuickFix.FIX44.SecurityTypes(),
            QuickFix.FIX44.SecurityListRequest.MsgType => new QuickFix.FIX44.SecurityListRequest(),
            QuickFix.FIX44.SecurityList.MsgType => new QuickFix.FIX44.SecurityList(),
            QuickFix.FIX44.DerivativeSecurityListRequest.MsgType => new QuickFix.FIX44.DerivativeSecurityListRequest(),
            QuickFix.FIX44.DerivativeSecurityList.MsgType => new QuickFix.FIX44.DerivativeSecurityList(),
            QuickFix.FIX44.SecurityStatusRequest.MsgType => new QuickFix.FIX44.SecurityStatusRequest(),
            QuickFix.FIX44.TradingSessionStatusRequest.MsgType => new QuickFix.FIX44.TradingSessionStatusRequest(),
            QuickFix.FIX44.DontKnowTrade.MsgType => new QuickFix.FIX44.DontKnowTrade(),
            QuickFix.FIX44.TradingSessionStatus.MsgType => new QuickFix.FIX44.TradingSessionStatus(),
            QuickFix.FIX44.SecurityStatus.MsgType => new QuickFix.FIX44.SecurityStatus(),
            QuickFix.FIX44.QuoteStatusRequest.MsgType => new QuickFix.FIX44.QuoteStatusRequest(),
            QuickFix.FIX44.QuoteRequestReject.MsgType => new QuickFix.FIX44.QuoteRequestReject(),
            QuickFix.FIX44.RFQRequest.MsgType => new QuickFix.FIX44.RFQRequest(),
            QuickFix.FIX44.Quote.MsgType => new QuickFix.FIX44.Quote(),
            QuickFix.FIX44.QuoteCancel.MsgType => new QuickFix.FIX44.QuoteCancel(),
            QuickFix.FIX44.QuoteStatusReport.MsgType => new QuickFix.FIX44.QuoteStatusReport(),
            QuickFix.FIX44.MassQuote.MsgType => new QuickFix.FIX44.MassQuote(),
            QuickFix.FIX44.MassQuoteAcknowledgement.MsgType => new QuickFix.FIX44.MassQuoteAcknowledgement(),
            _ => new QuickFix.Message()
        };
    }

    public Group? Create(string beginString, string msgType, int correspondingFieldId)
    {
        if (QuickFix.FIX44.IndicationOfInterest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.IndicationOfInterest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.IndicationOfInterest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.IndicationOfInterest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.IndicationOfInterest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.IndicationOfInterest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.IndicationOfInterest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.IndicationOfInterest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.IndicationOfInterest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.IndicationOfInterest.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.IndicationOfInterest.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.IndicationOfInterest.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX44.IndicationOfInterest.NoIOIQualifiersGroup();
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.IndicationOfInterest.NoRoutingIDsGroup();
            }
        }

        if (QuickFix.FIX44.Logon.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX44.Logon.NoMsgTypesGroup();
            }
        }

        if (QuickFix.FIX44.Email.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.Email.NoRoutingIDsGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.Email.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Email.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.Email.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.Email.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.Email.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.Email.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.Email.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.Email.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Email.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.Email.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.Email.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.Email.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.Email.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.Email.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.Email.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX44.QuoteRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoQuoteQualifiersGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
            }
        }

        if (QuickFix.FIX44.QuoteResponse.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteResponse.NoQuoteQualifiersGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteResponse.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.QuoteResponse.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.QuoteResponse.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteResponse.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteResponse.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.QuoteResponse.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.QuoteResponse.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.QuoteResponse.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.QuoteResponse.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.QuoteResponse.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.QuoteResponse.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.QuoteResponse.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.QuoteResponse.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteResponse.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.News.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.News.NoRoutingIDsGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.News.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.News.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.News.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.News.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.News.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.News.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.News.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.News.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.News.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.News.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.News.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.News.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.News.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.News.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.News.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX44.ExecutionReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoRegulatoryTradeIDs: return new QuickFix.FIX44.ExecutionReport.NoRegulatoryTradeIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.ExecutionReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.ExecutionReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.ExecutionReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.ExecutionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.ExecutionReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.ExecutionReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.ExecutionReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.ExecutionReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.ExecutionReport.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.ExecutionReport.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.ExecutionReport.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoPayments: return new QuickFix.FIX44.ExecutionReport.NoPaymentsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.ExecutionReport.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX44.ExecutionReport.NoStrategyParametersGroup();
                case QuickFix.Fields.Tags.NoOrderAttributes: return new QuickFix.FIX44.ExecutionReport.NoOrderAttributesGroup();
                case QuickFix.Fields.Tags.NoRelativeValues: return new QuickFix.FIX44.ExecutionReport.NoRelativeValuesGroup();
                case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX44.ExecutionReport.NoRateSourcesGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoNested3PartyIDsGroup();
                case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
                case QuickFix.Fields.Tags.NoLegContractualDefinitions: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoLegContractualMatrices: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegPosAmt: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegPosAmtGroup();
                case QuickFix.Fields.Tags.NoLegRefPrices: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegRefPricesGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.ExecutionReport.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.ExecutionReport.NoTrdRegTimestampsGroup();
                case QuickFix.Fields.Tags.NoTrdRegPublications: return new QuickFix.FIX44.ExecutionReport.NoTrdRegPublicationsGroup();
                case QuickFix.Fields.Tags.NoTradePriceConditions: return new QuickFix.FIX44.ExecutionReport.NoTradePriceConditionsGroup();
                case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX44.ExecutionReport.NoClearingInstructionsGroup();
                case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.ExecutionReport.NoPosAmtGroup();
                case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.ExecutionReport.NoQuoteQualifiersGroup();
                case QuickFix.Fields.Tags.NoRelatedInstruments: return new QuickFix.FIX44.ExecutionReport.NoRelatedInstrumentsGroup();
                case QuickFix.Fields.Tags.NoClientCustomData: return new QuickFix.FIX44.ExecutionReport.NoClientCustomDataGroup();
                case QuickFix.Fields.Tags.NoCompDealerQuotes: return new QuickFix.FIX44.ExecutionReport.NoCompDealerQuotesGroup();
                case QuickFix.Fields.Tags.NoRefPrices: return new QuickFix.FIX44.ExecutionReport.NoRefPricesGroup();
                case QuickFix.Fields.Tags.NoReferenceIds: return new QuickFix.FIX44.ExecutionReport.NoReferenceIdsGroup();
                case QuickFix.Fields.Tags.NoPriceQualifiers: return new QuickFix.FIX44.ExecutionReport.NoPriceQualifiersGroup();
                case QuickFix.Fields.Tags.NoNotes: return new QuickFix.FIX44.ExecutionReport.NoNotesGroup();
            }
        }

        if (QuickFix.FIX44.OrderStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderStatusRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.OrderStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.OrderStatusRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.OrderStatusRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderStatusRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderStatusRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.OrderStatusRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.OrderStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.OrderStatusRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.OrderStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.OrderStatusRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.OrderStatusRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.OrderStatusRequest.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.OrderStatusRequest.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.OrderMassCancelRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassCancelRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassCancelRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.OrderMassCancelRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.OrderMassCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.OrderMassCancelRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.OrderMassCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.OrderMassCancelRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.OrderMassCancelRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.NewOrderCross.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderCross.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderCross.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.NewOrderCross.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.NewOrderCross.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.NewOrderCross.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.NewOrderCross.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.NewOrderCross.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.NewOrderCross.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderCross.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderCross.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX44.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX44.CrossOrderCancelRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CrossOrderCancelRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.CrossOrderCancelRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.CrossOrderCancelRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.CrossOrderCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.CrossOrderCancelRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.CrossOrderCancelRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.OrderMassCancelReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX44.OrderMassCancelReport.NoAffectedOrdersGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassCancelReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassCancelReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.OrderMassCancelReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.OrderMassCancelReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.OrderMassCancelReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.OrderMassCancelReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.OrderMassCancelReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.OrderMassCancelReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.OrderMassStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassStatusRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassStatusRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.OrderMassStatusRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.OrderMassStatusRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.OrderMassStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.OrderMassStatusRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.OrderMassStatusRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.NewOrderSingle.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderSingle.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderSingle.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderSingle.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.NewOrderSingle.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.NewOrderSingle.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.NewOrderSingle.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.NewOrderSingle.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.NewOrderSingle.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.NewOrderSingle.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.NewOrderSingle.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.NewOrderSingle.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderSingle.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoOrderAttributes: return new QuickFix.FIX44.NewOrderSingle.NoOrderAttributesGroup();
                case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX44.NewOrderSingle.NoStrategyParametersGroup();
                case QuickFix.Fields.Tags.NoExecRuleNames: return new QuickFix.FIX44.NewOrderSingle.NoExecRuleNamesGroup();
                case QuickFix.Fields.Tags.NoNotes: return new QuickFix.FIX44.NewOrderSingle.NoNotesGroup();
            }
        }

        if (QuickFix.FIX44.ListStrikePrice.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.ListStatus.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.ListStatus.NoOrdersGroup();
            }
        }

        if (QuickFix.FIX44.NewOrderList.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoStrategyParametersGroup();
                case QuickFix.Fields.Tags.NoOrderAttributes: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoOrderAttributesGroup();
                case QuickFix.Fields.Tags.NoExecRuleNames: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoExecRuleNamesGroup();
                case QuickFix.Fields.Tags.NoNotes: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoNotesGroup();
            }
        }

        if (QuickFix.FIX44.OrderCancelRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderCancelRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.OrderCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.OrderCancelRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.OrderCancelRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderCancelRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderCancelRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.OrderCancelRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.OrderCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.OrderCancelRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.OrderCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.OrderCancelRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.OrderCancelRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.OrderCancelRequest.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX44.OrderCancelReplaceRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoStrategyParametersGroup();
                case QuickFix.Fields.Tags.NoOrderAttributes: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoOrderAttributesGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoExecRuleNames: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoExecRuleNamesGroup();
                case QuickFix.Fields.Tags.NoNotes: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoNotesGroup();
            }
        }

        if (QuickFix.FIX44.AllocationInstruction.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.AllocationInstruction.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup();
                case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.AllocationInstruction.NoExecsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AllocationInstruction.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AllocationInstruction.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.AllocationInstruction.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.AllocationInstruction.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.AllocationInstruction.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.AllocationInstruction.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.AllocationInstruction.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.AllocationInstruction.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.AllocationInstruction.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.AllocationInstruction.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.AllocationInstruction.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.AllocationInstruction.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.AllocationInstruction.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup();
                case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.NewOrderMultileg.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.NewOrderMultileg.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderMultileg.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderMultileg.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.NewOrderMultileg.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.NewOrderMultileg.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.NewOrderMultileg.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.NewOrderMultileg.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.NewOrderMultileg.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegContractualDefinitions: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoLegContractualMatrices: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup();
                case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
                case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoOrderAttributes: return new QuickFix.FIX44.NewOrderMultileg.NoOrderAttributesGroup();
                case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX44.NewOrderMultileg.NoStrategyParametersGroup();
                case QuickFix.Fields.Tags.NoExecRuleNames: return new QuickFix.FIX44.NewOrderMultileg.NoExecRuleNamesGroup();
                case QuickFix.Fields.Tags.NoNotes: return new QuickFix.FIX44.NewOrderMultileg.NoNotesGroup();
            }
        }

        if (QuickFix.FIX44.BidRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX44.BidRequest.NoBidDescriptorsGroup();
                case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX44.BidRequest.NoBidComponentsGroup();
            }
        }

        if (QuickFix.FIX44.BidResponse.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX44.BidResponse.NoBidComponentsGroup();
            }
        }

        if (QuickFix.FIX44.MultilegOrderCancelReplace.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegContractualDefinitions: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoLegContractualMatrices: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup();
                case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
                case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoOrderAttributes: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoOrderAttributesGroup();
                case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoStrategyParametersGroup();
                case QuickFix.Fields.Tags.NoExecRuleNames: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoExecRuleNamesGroup();
                case QuickFix.Fields.Tags.NoNotes: return new QuickFix.FIX44.MultilegOrderCancelReplace.NoNotesGroup();
            }
        }

        if (QuickFix.FIX44.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.TradeCaptureReportRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.TradeCaptureReportRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.TradeCaptureReportRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.TradeCaptureReportRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.TradeCaptureReportRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.TradeCaptureReportRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.TradeCaptureReportRequest.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.TradeCaptureReportRequest.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.TradeCaptureReportRequest.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX44.TradeCaptureReportRequest.NoDatesGroup();
            }
        }

        if (QuickFix.FIX44.TradeCaptureReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.TradeCaptureReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.TradeCaptureReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.TradeCaptureReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.TradeCaptureReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.TradeCaptureReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.TradeCaptureReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.TradeCaptureReport.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.TradeCaptureReport.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.TradeCaptureReport.NoPosAmtGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.TradeCaptureReport.NoTrdRegTimestampsGroup();
                case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoClearingInstructionsGroup();
                case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoContAmtsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
                case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                case QuickFix.Fields.Tags.NoCompetingQuotes: return new QuickFix.FIX44.TradeCaptureReport.NoCompetingQuotesGroup();
                case QuickFix.Fields.Tags.NoNotes: return new QuickFix.FIX44.TradeCaptureReport.NoNotesGroup();
                case QuickFix.Fields.Tags.NoRegulatorTradeIDs: return new QuickFix.FIX44.TradeCaptureReport.NoRegulatorTradeIDsGroup();
                case QuickFix.Fields.Tags.NoPayments: return new QuickFix.FIX44.TradeCaptureReport.NoPaymentsGroup();
                case QuickFix.Fields.Tags.NoTrdRegPublications: return new QuickFix.FIX44.TradeCaptureReport.NoTrdRegPublicationsGroup();
            }
        }

        if (QuickFix.FIX44.SettlementInstructions.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup();
                case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.SettlementInstructionRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.SettlementInstructionRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.SettlementInstructionRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.SettlementInstructionRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.SettlementInstructionRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
            }
        }

        if (QuickFix.FIX44.ConfirmationRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.ConfirmationRequest.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup();
                case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.Confirmation.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.Confirmation.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.Confirmation.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.Confirmation.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.Confirmation.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.Confirmation.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup();
                case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Confirmation.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Confirmation.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.Confirmation.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.Confirmation.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.Confirmation.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.Confirmation.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.Confirmation.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.Confirmation.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.Confirmation.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.Confirmation.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX44.Confirmation.NoCapacitiesGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.Confirmation.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.Confirmation.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoRegulatoryTradeIDs: return new QuickFix.FIX44.Confirmation.NoRegulatoryTradeIDsGroup();
            }
        }

        if (QuickFix.FIX44.PositionMaintenanceRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionMaintenanceRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.PositionMaintenanceRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.PositionMaintenanceRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.PositionMaintenanceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.PositionMaintenanceRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.PositionMaintenanceRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.PositionMaintenanceRequest.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPositionsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.PositionMaintenanceReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionMaintenanceReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.PositionMaintenanceReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.PositionMaintenanceReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.PositionMaintenanceReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.PositionMaintenanceReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.PositionMaintenanceReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.PositionMaintenanceReport.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionMaintenanceReport.NoPositionsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.PositionMaintenanceReport.NoPosAmtGroup();
            }
        }

        if (QuickFix.FIX44.RequestForPositions.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RequestForPositions.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.RequestForPositions.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.RequestForPositions.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.RequestForPositions.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RequestForPositions.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RequestForPositions.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.RequestForPositions.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.RequestForPositions.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.RequestForPositions.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.RequestForPositions.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.RequestForPositions.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.RequestForPositions.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.RequestForPositions.NoTradingSessionsGroup();
            }
        }

        if (QuickFix.FIX44.RequestForPositionsAck.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RequestForPositionsAck.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RequestForPositionsAck.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.RequestForPositionsAck.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.RequestForPositionsAck.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.RequestForPositionsAck.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.RequestForPositionsAck.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.RequestForPositionsAck.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.PositionReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.PositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.PositionReport.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.PositionReport.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.PositionReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.PositionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.PositionReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.PositionReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.PositionReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.PositionReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionReport.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.PositionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.PositionReport.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.PositionReport.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.PositionReport.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.PositionReport.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionReport.NoPositionsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.PositionReport.NoPosAmtGroup();
            }
        }

        if (QuickFix.FIX44.AssignmentReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AssignmentReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.AssignmentReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.AssignmentReport.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.AssignmentReport.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AssignmentReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.AssignmentReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.AssignmentReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.AssignmentReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.AssignmentReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.AssignmentReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.AssignmentReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.AssignmentReport.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.AssignmentReport.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.AssignmentReport.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.AssignmentReport.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.AssignmentReport.NoPositionsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.AssignmentReport.NoPosAmtGroup();
            }
        }

        if (QuickFix.FIX44.CollateralRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.CollateralRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.CollateralRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralRequest.NoExecsGroup();
                case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralRequest.NoTradesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.CollateralRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.CollateralRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.CollateralRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.CollateralRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.CollateralRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.CollateralRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.CollateralRequest.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.CollateralRequest.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.CollateralRequest.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.CollateralRequest.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.CollateralRequest.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.CollateralRequest.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralRequest.NoTrdRegTimestampsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralRequest.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralRequest.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX44.CollateralAssignment.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralAssignment.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralAssignment.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.CollateralAssignment.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.CollateralAssignment.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralAssignment.NoExecsGroup();
                case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralAssignment.NoTradesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralAssignment.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.CollateralAssignment.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.CollateralAssignment.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.CollateralAssignment.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.CollateralAssignment.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.CollateralAssignment.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.CollateralAssignment.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.CollateralAssignment.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.CollateralAssignment.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.CollateralAssignment.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.CollateralAssignment.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.CollateralAssignment.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.CollateralAssignment.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralAssignment.NoTrdRegTimestampsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralAssignment.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralAssignment.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralAssignment.NoDlvyInstGroup();
                case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.CollateralResponse.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralResponse.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.CollateralResponse.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.CollateralResponse.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralResponse.NoExecsGroup();
                case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralResponse.NoTradesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralResponse.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.CollateralResponse.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.CollateralResponse.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.CollateralResponse.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.CollateralResponse.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.CollateralResponse.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.CollateralResponse.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.CollateralResponse.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.CollateralResponse.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.CollateralResponse.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.CollateralResponse.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.CollateralResponse.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.CollateralResponse.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralResponse.NoTrdRegTimestampsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralResponse.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralResponse.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX44.CollateralReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.CollateralReport.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.CollateralReport.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralReport.NoExecsGroup();
                case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralReport.NoTradesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.CollateralReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.CollateralReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.CollateralReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.CollateralReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.CollateralReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.CollateralReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.CollateralReport.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.CollateralReport.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.CollateralReport.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.CollateralReport.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.CollateralReport.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.CollateralReport.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralReport.NoTrdRegTimestampsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralReport.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralReport.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralReport.NoDlvyInstGroup();
                case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.NetworkStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX44.NetworkStatusRequest.NoCompIDsGroup();
            }
        }

        if (QuickFix.FIX44.NetworkStatusResponse.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX44.NetworkStatusResponse.NoCompIDsGroup();
            }
        }

        if (QuickFix.FIX44.CollateralInquiryAck.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX44.CollateralInquiryAck.NoCollInquiryQualifierGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralInquiryAck.NoExecsGroup();
                case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralInquiryAck.NoTradesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralInquiryAck.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.CollateralInquiryAck.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.CollateralInquiryAck.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.CollateralInquiryAck.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.CollateralInquiryAck.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.CollateralInquiryAck.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.CollateralInquiryAck.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.CollateralInquiryAck.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.CollateralInquiryAck.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.CollateralInquiryAck.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.CollateralInquiryAck.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.CollateralInquiryAck.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.CollateralInquiry.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX44.CollateralInquiry.NoCollInquiryQualifierGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralInquiry.NoExecsGroup();
                case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralInquiry.NoTradesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralInquiry.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.CollateralInquiry.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.CollateralInquiry.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.CollateralInquiry.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.CollateralInquiry.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.CollateralInquiry.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.CollateralInquiry.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.CollateralInquiry.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.CollateralInquiry.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.CollateralInquiry.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.CollateralInquiry.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.CollateralInquiry.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.CollateralInquiry.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralInquiry.NoTrdRegTimestampsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralInquiry.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralInquiry.NoDlvyInstGroup();
                case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.RegistrationInstructions.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RegistrationInstructions.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.RegistrationInstructions.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.RegistrationInstructions.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.RegistrationInstructions.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX44.RegistrationInstructions.NoRegistDtlsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX44.RegistrationInstructions.NoDistribInstsGroup();
            }
        }

        if (QuickFix.FIX44.RegistrationInstructionsResponse.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RegistrationInstructionsResponse.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.RegistrationInstructionsResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.RegistrationInstructionsResponse.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.RegistrationInstructionsResponse.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
            }
        }

        if (QuickFix.FIX44.TradeCaptureReportAck.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportAck.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportAck.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.TradeCaptureReportAck.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.TradeCaptureReportAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.TradeCaptureReportAck.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.TradeCaptureReportAck.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.TradeCaptureReportAck.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.TradeCaptureReportAck.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoRegulatoryTradeIDs: return new QuickFix.FIX44.TradeCaptureReportAck.NoRegulatoryTradeIDsGroup();
            }
        }

        if (QuickFix.FIX44.AllocationReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.AllocationReport.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup();
                case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.AllocationReport.NoExecsGroup();
                case QuickFix.Fields.Tags.NoTrdRegPublications: return new QuickFix.FIX44.AllocationReport.NoExecsGroup.NoTrdRegPublicationsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AllocationReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AllocationReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.AllocationReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.AllocationReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.AllocationReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.AllocationReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.AllocationReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.AllocationReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.AllocationReport.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.AllocationReport.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.AllocationReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.AllocationReport.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.AllocationReport.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.AllocationReport.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoRegulatoryTradeIDs: return new QuickFix.FIX44.AllocationReport.NoRegulatoryTradeIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoAllocRegulatoryTradeIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoAllocRegulatoryTradeIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoDlvyInstGroup();
                case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoTradeAllocAmts: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoTradeAllocAmtsGroup();
                case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.AllocationReport.NoTrdRegTimestampsGroup();
                case QuickFix.Fields.Tags.NoPriceQualifiers: return new QuickFix.FIX44.AllocationReport.NoPriceQualifiersGroup();
                case QuickFix.Fields.Tags.NoNotes: return new QuickFix.FIX44.AllocationReport.NoNotesGroup();
            }
        }

        if (QuickFix.FIX44.Advertisement.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Advertisement.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Advertisement.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.Advertisement.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.Advertisement.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.Advertisement.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.Advertisement.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.Advertisement.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.Advertisement.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Advertisement.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.Advertisement.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.Advertisement.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.Advertisement.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.Advertisement.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.Advertisement.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.MarketDataRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.MarketDataRequest.NoTradingSessionsGroup();
            }
        }

        if (QuickFix.FIX44.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
            }
        }

        if (QuickFix.FIX44.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.MarketDataRequestReject.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX44.MarketDataRequestReject.NoAltMDSourceGroup();
            }
        }

        if (QuickFix.FIX44.SecurityDefinitionRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityDefinitionRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityDefinitionRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.SecurityDefinitionRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.SecurityDefinitionRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.SecurityDefinitionRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.SecurityDefinitionRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.SecurityDefinitionRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.SecurityDefinitionRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityDefinitionRequest.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.SecurityDefinition.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityDefinition.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.SecurityDefinition.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.SecurityDefinition.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.SecurityDefinition.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.SecurityDefinition.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.SecurityDefinition.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.SecurityDefinition.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityDefinition.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.SecurityTypes.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX44.SecurityTypes.NoSecurityTypesGroup();
            }
        }

        if (QuickFix.FIX44.SecurityListRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityListRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityListRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.SecurityListRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.SecurityListRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.SecurityListRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.SecurityListRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.SecurityListRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.SecurityListRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityListRequest.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.SecurityListRequest.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.SecurityListRequest.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.SecurityList.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
            }
        }

        if (QuickFix.FIX44.DerivativeSecurityListRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingReinvCouponGroup();
            }
        }

        if (QuickFix.FIX44.DerivativeSecurityList.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.SecurityStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityStatusRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityStatusRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.SecurityStatusRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.SecurityStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.SecurityStatusRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.SecurityStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.SecurityStatusRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.SecurityStatusRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityStatusRequest.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.DontKnowTrade.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.DontKnowTrade.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.DontKnowTrade.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.DontKnowTrade.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.DontKnowTrade.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.DontKnowTrade.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.DontKnowTrade.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.DontKnowTrade.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.DontKnowTrade.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.SecurityStatus.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityStatus.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityStatus.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.SecurityStatus.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.SecurityStatus.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.SecurityStatus.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.SecurityStatus.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.SecurityStatus.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.SecurityStatus.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityStatus.NoInstrAttribGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.QuoteStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteStatusRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteStatusRequest.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.QuoteStatusRequest.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.QuoteStatusRequest.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.QuoteStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.QuoteStatusRequest.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.QuoteStatusRequest.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.QuoteStatusRequest.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.QuoteStatusRequest.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
            }
        }

        if (QuickFix.FIX44.QuoteRequestReject.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteRequestReject.NoQuoteQualifiersGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteRequestReject.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteRequestReject.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.QuoteRequestReject.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.QuoteRequestReject.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
            }
        }

        if (QuickFix.FIX44.RFQRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.Quote.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.Quote.NoQuoteQualifiersGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.Quote.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.Quote.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.Quote.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.Quote.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Quote.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Quote.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.Quote.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.Quote.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.Quote.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.Quote.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.Quote.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.Quote.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.Quote.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.Quote.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.Quote.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Quote.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.Quote.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.Quote.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.Quote.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.Quote.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.Quote.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.Quote.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.Quote.NoLegsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.Quote.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX44.QuoteCancel.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteCancel.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteCancel.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.QuoteCancel.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.QuoteCancel.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.QuoteStatusReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteStatusReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteStatusReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.QuoteStatusReport.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.QuoteStatusReport.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteStatusReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteStatusReport.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.QuoteStatusReport.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.QuoteStatusReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.QuoteStatusReport.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.QuoteStatusReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.QuoteStatusReport.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.QuoteStatusReport.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoContractualDefinitions: return new QuickFix.FIX44.QuoteStatusReport.NoContractualDefinitionsGroup();
                case QuickFix.Fields.Tags.NoContractualMatrices: return new QuickFix.FIX44.QuoteStatusReport.NoContractualMatricesGroup();
                case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteStatusReport.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoLegStreamsGroup();
                case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoLegStipulationsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteStatusReport.NoQuoteQualifiersGroup();
            }
        }

        if (QuickFix.FIX44.MassQuote.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MassQuote.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.MassQuote.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.MassQuote.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.MassQuote.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        if (QuickFix.FIX44.MassQuoteAcknowledgement.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoPartyIDsGroup.NoPartyAltIDsGroup();
                case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoPartyIDsGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
                case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoUnderlyingEvents: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingEventsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingStreams: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingStreamsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingReinvCoupon: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingReinvCouponGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
                case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
                case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup();
                case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoOptionExerciseExpirationDates: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoOptionExerciseExpirationDatesGroup();
                case QuickFix.Fields.Tags.NoStreams: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoStreamsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegEvents: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEvents: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegComplexEventsGroup();
                case QuickFix.Fields.Tags.NoLegComplexEventDates: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegComplexEventsGroup.NoLegComplexEventDatesGroup();
                case QuickFix.Fields.Tags.NoLegStreams: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegStreamsGroup();
            }
        }

        return null;
    }
}
