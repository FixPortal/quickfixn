if ($args.Length -gt 0) {
    Write-Error "This script does not take any parameters."
    Exit 1
}

$rootpath = Join-Path $PSScriptRoot '..' | Resolve-Path

$specs = Get-ChildItem -Path (Join-Path $rootpath 'spec\Centerprise') -Filter '*.xml' |
         Sort-Object { [int]($_.BaseName -split '_')[0] } |
         ForEach-Object { $_.FullName }

pushd (Join-Path $rootpath DDTool)
dotnet run --project DDTool --reporoot $rootpath --outputdir $rootpath $specs
popd