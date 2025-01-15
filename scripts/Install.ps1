New-Item -Path "c:\" -ItemType Directory
Set-Location -Path "C:\Git" 

# install .net sdk8
Invoke-WebRequest -Uri "https://dot.net/v1/dotnet-install.ps1" -OutFile ".\scripts\dotnet-install.ps1" 
.\scripts\dotnet-install.ps1
dotnet.exe
# install git
Invoke-WebRequest -Uri "https://github.com/git-for-windows/git/releases/download/v2.47.1.windows.1/Git-2.47.1-64-bit.exe" -OutFile ".\scripts\git-setup.exe" 
$installerPath = ".\scripts\git-setup.exe"  
# Run the installer in silent mode with specified installation directory
Start-Process -FilePath $installerPath -ArgumentList "/SILENT", "/NORESTART", "/DIR=C:\Program Files\Git" -Wait -NoNewWindow

# clone repo

git clone https://github.com/Bedrijfstak14/EasyDevOps-ITM-550937.git

# Run app
