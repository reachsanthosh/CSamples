REM echo dotnet restore
REM dotnet restore
@echo build solution 
FOR /r %%G in ("*.csproj") DO dotnet build %%G 
@echo running unit tests 
CD test 
FOR /r %%G in ("*.csproj") DO dotnet test %%G 
cd %~dp0