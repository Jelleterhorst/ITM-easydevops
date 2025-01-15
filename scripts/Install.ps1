# als er een error komt gelijk stoppen
$ErrorActionPreference = "Stop"

#.net installeren
Write-Host ".net sdk 8 installeren"
winget install Microsoft.DotNet.DesktopRuntime.9 winget install Microsoft.DotNet.AspNetCore.9 -NoNewWindow -Wait
Write-Host ".net sdk 8 geinstalleerd"

# Git installeren
Write-Host "Git isntalleren"
winget install --id Git.Git -e --source winget --accept-source-agreements --accept-package-agreements -e -q
Write-Host "Git geinstalleerd"

# Repository clonen
Write-Host "repository van github clonen"
$repoUrl = "https://github.com/Jelleterhorst/ITM-easydevops.git"
$clonePath = "$env:USERPROFILE\ITM-easydevops"
git clone $repoUrl $clonePath
Write-Host "repository is gecloned"

# dotnet applicatie builden en uitvoeren
Write-Host "dotnet applicatie builen en runnen"
Push-Location "$clonePath\frontend"
dotnet build
dotnet run --project "$clonePath\frontend\ConsoleApp\ConsoleApp.csproj"
Write-Host "dotnet applicatie draait"