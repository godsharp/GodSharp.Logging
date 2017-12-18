@echo off& setlocal EnableDelayedExpansion
echo %cd%
echo "upload nuget packages"
for /r output/ %%n in (*.nupkg) do "%NUGET_PATH%" push %%n %MYGET_TOKEN% -Source https://www.myget.org/F/godsharp/api/v2/package