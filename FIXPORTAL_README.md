# FixPortal QuickFIX/n Fork

## Overview

This repository is a [FixPortal](https://github.com/FixPortal) fork of
[QuickFIX/n](https://github.com/connamara/quickfixn), the .NET implementation
of the FIX protocol engine. The fork adds custom data dictionaries, additional
FIX 5.0 SP2 support, message-rejection notification hooks, and other engine
enhancements on top of upstream releases.

For general QuickFIX/n documentation, refer to the upstream `README.md`.

## Repository structure

| Remote     | URL                                  | Purpose                       |
|------------|--------------------------------------|-------------------------------|
| `origin`   | `github.com/FixPortal/quickfixn`     | FixPortal fork (this repo)    |
| `upstream` | `github.com/connamara/quickfixn`     | Official QuickFIX/n (GitHub)  |

### Key branches

| Branch       | Purpose                                                                      |
|--------------|------------------------------------------------------------------------------|
| `master`     | Tracks upstream `master`                                                     |
| `qfsim`      | FixPortal deployment branch — upstream `v1.14.0` + FixPortal enhancements    |

### FixPortal-specific content

- `spec/FixPortal/` — Custom data-dictionary XML files (legacy directory name)
- `scripts/Generate-Message-Sources.ps1` — Uses the custom specs
- `DDTool/Structures/DataDictionary.cs` — Ordering enhancements for spec processing
- FixPortal enhancements throughout `QuickFIXn/`, marked with a single-line banner of the form
  `// FP Enhancement: YYYY-MM-DD — <one-line rationale>.` (matching the convention used in the
  FixPortal FixAtdl repo). Older `// FixPortal Enhancement` markers and `#region FixPortal Enhancement`
  blocks may still appear in unreviewed corners; convert on touch.

## Upgrade workflow

When a new upstream release is available (e.g. `v1.15.0`), follow these steps to
incorporate it into `qfsim`.

### 1. Sync `master` with upstream

```bash
git checkout master
git fetch upstream --tags
git merge upstream/master
git push origin master
```

### 2. Merge the release into `qfsim`

```bash
git checkout qfsim
git merge v1.15.0
```

Merge conflicts are expected in core files (`Session.cs`, `Message.cs`,
`DataDictionary.cs`, `ThreadedSocketAcceptor.cs`, logger and transport).
FixPortal enhancements are marked with `// FP Enhancement: YYYY-MM-DD — <rationale>.`
banners where practical (older `// FixPortal Enhancement` markers may also appear) —
when in doubt, take the upstream change and re-apply the FixPortal modification on
top, then convert the marker to the banner format if it isn't already.

The `DDTool/Structures/DataDictionary.cs` model class (~86 lines) is distinct
from the runtime `QuickFIXn/DataDictionary/DataDictionary.cs` (700+ lines);
do not confuse them during merges.

### 3. Regenerate message sources

```powershell
pwsh scripts/Generate-Message-Sources.ps1
```

This runs DDTool against `spec/FixPortal/*.xml` and regenerates fields and
message classes. DDTool does not delete stale outputs — clean the relevant
`Messages/*/` directory before regenerating if definitions have been removed.

### 4. Build and test

```bash
dotnet build
dotnet test
```

### 5. Pack and publish

The packable projects — `QuickFIXn/QuickFix.csproj` and `Messages/*/QuickFix.*.csproj`
(10 in total) — each carry a `<Version>` and `<PackageId>FixPortal.QuickFIXn.*</PackageId>`.
Bump `<Version>` on all 10 (e.g. `1.14.0-fixportal.1` → `1.14.0-fixportal.2`,
or move to the new upstream base such as `1.15.0-fixportal.1` after an
upstream merge).

```bash
dotnet pack QuickFIXn.sln -c Release -o _pkgout
```

Debug symbols are embedded (`<DebugType>embedded</DebugType>`), so no separate
symbol packages are produced.

## Spec maintenance

The custom data dictionaries in `spec/FixPortal/` replace the standard
QuickFIX/n specs in `spec/fix/`. The approach:

- **Standard versions** (FIX 4.0, 4.1, 4.3, 5.0, 5.0 SP1, FIXT 1.1) are copied
  from upstream with a numeric prefix for ordering
- **Customised versions** (FIX 4.2, 4.4, 5.0 SP2) extend the standard versions
  with FixPortal-specific fields, components, and message additions
- The customised FIX 5.0 SP2 spec (`10_FIX50SP2_FP_QF.xml`) is built from the
  upstream FIX50SP2.xml with FixPortal additions merged in. `scripts/build_fix50_fp.py`
  can regenerate it from the upstream base and the FIX44 source
- Custom specs use a `name` attribute on the root `<fix>` element (e.g.
  `name="FIX50SP2_FP_QF"`) to avoid DDTool's duplicate-name check

### Known tag collisions (custom FIX44 vs FIX50SP2)

Several custom tags in the FIX44 spec collide with standard FIX50SP2 tags. When
building the custom FIX50SP2 spec, FIX50SP2 definitions take precedence:

- **Tags 1586-1605**: Custom `LegPosAmt` fields vs FIX50SP2 `RelationshipRisk` fields
- **Tag 800**: Custom `NOE` (CHAR) vs FIX50SP2 `OrderBookingQty` (QTY)
- **Tag 327**: Custom `HaltReason` (CHAR) vs FIX50SP2 `HaltReasonInt` (INT)
- **Tags 22086-22091**: Custom `PartyAltID` fields — superseded by FIX50SP2 tags 1516-1521

Custom message references to colliding fields are removed from the FIX50SP2 spec.

## Version history

| Version            | Date    | Notes                                                          |
|--------------------|---------|----------------------------------------------------------------|
| 1.14.0-fixportal.1 | 2026-05 | Initial FixPortal release — fork of upstream `v1.14.0` baseline |
