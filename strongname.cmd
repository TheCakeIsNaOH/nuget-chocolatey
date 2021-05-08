@echo Off
SETLOCAL
set config=%1
SET DIR=%~d0%~p0%

if "%config%" == "" (
   set config=release
)
echo %DIR%nuget\ILMerge\ILMerge.exe
call %DIR%build.cmd %config%

mkdir %DIR%ilmerge-output

if "%config%" == "debug" (
    set BINSDIR=%DIR%src\Core\bin\Debug\
) else (
    set BINSDIR=%DIR%src\Core\bin\Release\
)

%DIR%nuget\ILMerge\ILMerge.exe %BINSDIR%NuGet.Core.dll /keyfile:%DIR%chocolatey.snk /out:%DIR%ilmerge-output\NuGet.Core.dll /targetplatform:v4,"%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0" /log:%DIR%ilmerge-output\ILMerge.DELETE.log /allowDup
REM %DIR%..\ILMerge\ILMerge.exe NuGet.Core.dll /keyfile:%DIR%..\..\chocolatey.snk /out:%DIR%NuGet.Core.dll /targetplatform:v4,"%ProgramFiles(x86)%\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0" /log:%DIR%ILMerge.DELETE.log /ndebug /allowDup

ENDLOCAL