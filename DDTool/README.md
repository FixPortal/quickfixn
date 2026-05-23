# DDTool
DataDictionary analyzer/codegen for QuickFIX/n

It intentionally has minimal dependencies, and the UTs use
Microsoft's default TestFramework.

## To run

To parse DDs, but only analyze (not generate):  
`> dotnet run --project DDTool <ddFile> <ddFile>...`

To parse DDs and generate:  
`> dotnet run --project DDTool --reporoot <qfRepoDir> --outputdir <destDir> <ddFile> <ddFile>...`

Typically invoked via the wrapper script:  
`> pwsh scripts/Generate-Message-Sources.ps1`

## FixPortal Changes

### DDTool modifications

The only DDTool modification is in `Structures/DataDictionary.cs`, which adds an
ordering enhancement to ensure specs are processed in the correct order during field
aggregation. DDTool itself is otherwise unmodified from upstream — the FixPortal specs
use only standard FIX field types that upstream DDTool already supports.

### Spec file organisation

FixPortal data dictionaries live in `spec/Centerprise/` (a legacy directory name kept
for path stability) rather than `spec/fix/`. Files are numbered with a prefix that
controls processing order, which matters because DDTool's field aggregation uses
"latest version wins" semantics:

```
1_FIX40.xml          Standard FIX 4.0
2_FIX41.xml          Standard FIX 4.1
3_FIX43.xml          Standard FIX 4.3
4_FIX50.xml          Standard FIX 5.0
5_FIX50SP1.xml       Standard FIX 5.0 SP1
7_FIXT11.xml         Standard FIXT 1.1
8_FIX42_CP_QF.xml    Customised FIX 4.2 (replaces standard FIX 4.2)
9_FIX44_CP_QF.xml    Customised FIX 4.4 (replaces standard FIX 4.4)
10_FIX50SP2_CP_QF.xml   Customised FIX 5.0 SP2 (replaces standard FIX 5.0 SP2)
```

Customised specs use a `name` attribute on the root `<fix>` element (e.g.
`name="FIX42_CP_QF"`) so they can coexist with the standard versions without
triggering DDTool's duplicate-name check.

### Generation script

`scripts/Generate-Message-Sources.ps1` is modified from upstream to:

- Read specs from `spec/Centerprise/` instead of `spec/fix/`
- Sort input files by their numeric prefix to ensure deterministic processing order
