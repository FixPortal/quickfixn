# Upstream finding — CME Enhanced Resend continuation chunk requests `MaxMessagesInResendRequest + 1`

**Target:** `connamara/quickfixn` (upstream)
**Status:** draft question to raise upstream (not a confirmed bug)
**Found:** 2026-06-08, during the FixPortal adversarial review of the `v1.14.1` merge
**Affected:** `QuickFIXn/Session.cs` @ `v1.14.1` / current `master` (the CME Enhanced Resend feature)

---

## Suggested issue title

CME Enhanced Resend: continuation chunk requests `MaxMessagesInResendRequest + 1` messages — intentional?

## Body

There are three places that compute a `ResendRequest` chunk end in `Session.cs`. Two span exactly `MaxMessagesInResendRequest` messages; the CME gap-fill continuation spans one more. Wanting to check whether that `+1` is intentional before treating it as a defect.

**1. Initial request — `GenerateResendRequest`** (`Session.cs:1356`)
```csharp
endChunkSeqNum = Math.Min(endRangeSeqNum, beginSeqNum + MaxMessagesInResendRequest - 1);
```
Range `[beginSeqNum, beginSeqNum + Max - 1]` → **exactly `Max`** messages.

**2. Non-CME continuation — in `Verify`** (`Session.cs:1111`)
```csharp
SeqNumType newChunkEndSeqNo = Math.Min(range.EndSeqNo, range.ChunkEndSeqNo + MaxMessagesInResendRequest); // TODO we can +1 this
```
Next chunk starts at `range.ChunkEndSeqNo + 1`, so `[ChunkEndSeqNo + 1, ChunkEndSeqNo + Max]` → **exactly `Max`** messages.

**3. CME gap-fill continuation — `HandleCmeEnhancedResendGapFill`** (`Session.cs:988`, the chunk line at `1020`)
```csharp
SeqNumType newStart = max;                  // max == range.ChunkEndSeqNo + 1
SeqNumType newChunkEnd = Math.Min(range.EndSeqNo, newStart + MaxMessagesInResendRequest); // TODO we can +1 this
```
Here the base is already `newStart = ChunkEndSeqNo + 1`, so `[newStart, newStart + Max]` → **`Max + 1`** messages.

### The question

Cases (1) and (2) span `Max`; case (3) spans `Max + 1`. (2) and (3) look like the same formula but their base differs by one (`ChunkEndSeqNo` vs `newStart = ChunkEndSeqNo + 1`), and the `// TODO we can +1 this` comment appears on **both** (2) and (3) — yet (3) has *already* effectively `+1`'d.

Is the `Max + 1` in the CME continuation **intentional** (does CME expect / tolerate one more than `MaxMessagesInResendRequest` per `ResendRequest`)? Or is it an inadvertent inconsistency? If a venue enforces a strict cap of exactly `MaxMessagesInResendRequest` per request, the CME continuation chunk would exceed it.

### Reproduction (arithmetic)

`MaxMessagesInResendRequest = 5`, counterparty's last seq makes the gap `3..99` (much larger than `Max`, so chunking applies):

1. Initial chunked request: `BeginSeqNo=3, EndSeqNo=7` — 5 messages. ✅
2. Counterparty gap-fills the chunk (`SequenceReset-GapFill`, `NewSeqNo=8`).
3. Next chunk requested: `BeginSeqNo=8, EndSeqNo=13` — **6 messages** (`Max + 1`). Expected `8..12` (5) to match (1)/(2).

A regression test exercising this (fails at `EndSeqNo=13`, passes at `12`) was written during the review and is available if a fix PR is wanted.

### Note

FixPortal initially "fixed" this to `newStart + Max - 1` but reverted it pending this clarification, because the `// TODO we can +1 this` suggests `Max + 1` may be deliberate. Raising as a question rather than a drive-by fix.
