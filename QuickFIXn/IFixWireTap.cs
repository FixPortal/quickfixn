namespace QuickFix;

/// <summary>
/// FP enhancement: a verbatim wire-frame tap for the engine Tier-2 capture seam. A
/// <see cref="Session"/> invokes this (when one is supplied) at the two wire chokepoints:
/// <list type="bullet">
/// <item><see cref="OnInbound"/> at the top of <c>Session.Next(string)</c> — once per wire
/// arrival, before the frame is parsed and before any field redaction, so the raw is complete
/// even for malformed frames and for sessions that redact fields in their logs.</item>
/// <item><see cref="OnOutbound"/> at the top of <c>Session.Send(string)</c> — the single
/// outbound chokepoint that <c>SendRaw</c> funnels every admin / app / resend / gap-fill frame
/// through, before redaction and before the frame reaches the responder.</item>
/// </list>
/// The implementation is called on the FIX session thread and <b>must never block</b>; the
/// session additionally guards every call so a throwing tap can never disrupt FIX processing.
/// The tap is purely observational — it never mutates the frame or the session.
/// </summary>
public interface IFixWireTap
{
    /// <summary>Called once per inbound wire arrival with the verbatim, pre-parse frame.</summary>
    /// <param name="sessionId">The session the frame arrived on.</param>
    /// <param name="rawFrame">The exact wire bytes, SOH-delimited, before parsing or redaction.</param>
    void OnInbound(SessionID sessionId, string rawFrame);

    /// <summary>Called once per inbound queued-replay arrival with the verbatim, pre-parse frame.</summary>
    /// <param name="sessionId">The session the frame arrived on.</param>
    /// <param name="rawFrame">The exact wire bytes, SOH-delimited, before parsing or redaction.</param>
    void OnInboundReplay(SessionID sessionId, string rawFrame) => OnInbound(sessionId, rawFrame);

    /// <summary>Called for every outbound frame with the verbatim, pre-redaction body.</summary>
    /// <param name="sessionId">The session the frame is sent on.</param>
    /// <param name="rawFrame">The exact wire bytes, SOH-delimited, before redaction.</param>
    void OnOutbound(SessionID sessionId, string rawFrame);
}
