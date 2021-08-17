@echo Adding solution if not exist 

IF NOT EXIST *.sln GOTO :ADDSLN
IF EXIST *.sln GOTO :ADDPROJECT

:ADDSLN
set /p addSln= You want to add solution (y/n) ?

IF %addSln%==y GOTO :DISPLAY 
ELSE GOTO :ADDPROJECT

:DISPLAY 
set /p slnName= enter solution name 

@echo %slnName%
dotnet new sln -n %slnName%
GOTO :ADDPROJECT

:ADDPROJECT
FOR /r %%G in ("*.csproj") DO dotnet sln add %%G 
EXIT /b 0