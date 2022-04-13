SET DOTNET_CLI_TELEMETRY_OPTOUT=true
SET DOTNET_SKIP_FIRST_TIME_EXPERIENCE=true

dotnet.exe publish -r win7-x64 --self-contained true  --framework net6.0-windows --configuration Release -p:PublishTrimmed=false -p:PublishSingleFile=true -p:PublishReadyToRun=true
dotnet.exe publish -r win7-x86 --self-contained true  --framework net6.0-windows  --configuration Release -p:PublishTrimmed=false -p:PublishSingleFile=true -p:PublishReadyToRun=true
dotnet.exe publish -r win81-x64 --self-contained true  --framework net6.0-windows  --configuration Release -p:PublishTrimmed=false -p:PublishSingleFile=true -p:PublishReadyToRun=true
dotnet.exe publish -r win81-x86 --self-contained true  --framework net6.0-windows  --configuration Release -p:PublishTrimmed=false -p:PublishSingleFile=true -p:PublishReadyToRun=true
dotnet.exe publish -r win10-x64 --self-contained true  --framework net6.0-windows  --configuration Release -p:PublishTrimmed=false -p:PublishSingleFile=true -p:PublishReadyToRun=true
dotnet.exe publish -r win10-x86 --self-contained true  --framework net6.0-windows  --configuration Release -p:PublishTrimmed=false -p:PublishSingleFile=true -p:PublishReadyToRun=true