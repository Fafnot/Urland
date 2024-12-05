@echo off
title next

chcp 866 >nul
 



color 5






:menu 
echo.
echo   [38;2;128;0;128m
echo                ÉÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ»
echo                ³                                                                                   ³
echo                ³      ÛÛ»   ÛÛ»    ÛÛÛÛÛÛ»     ÛÛ»          ÛÛÛÛÛ»     ÛÛÛ»   ÛÛ»    ÛÛÛÛÛÛ»       ³
echo                ³      ÛÛº   ÛÛº    ÛÛÉÍÍÛÛ»    ÛÛº         ÛÛÉÍÍÛÛ»    ÛÛÛÛ»  ÛÛº    ÛÛÉÍÍÛÛ»      ³
echo                ³      ÛÛº   ÛÛº    ÛÛÛÛÛÛÉ¼    ÛÛº         ÛÛÛÛÛÛÛº    ÛÛÉÛÛ» ÛÛº    ÛÛº  ÛÛº      ³
echo                ³      ÛÛº   ÛÛº    ÛÛÉÍÍÛÛ»    ÛÛº         ÛÛÉÍÍÛÛº    ÛÛºÈÛÛ»ÛÛº    ÛÛº  ÛÛº      ³
echo                ³      ÈÛÛÛÛÛÛÉ¼    ÛÛº  ÛÛº    ÛÛÛÛÛÛÛ»    ÛÛº  ÛÛº    ÛÛº ÈÛÛÛÛº    ÛÛÛÛÛÛÉ¼      ³
echo                ³       ÈÍÍÍÍÍ¼     ÈÍ¼  ÈÍ¼    ÈÍÍÍÍÍÍ¼    ÈÍ¼  ÈÍ¼    ÈÍ¼  ÈÍÍÍ¼    ÈÍÍÍÍÍ¼       ³
echo                ³                                                                                   ³
echo                ÈÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¼
echo.
echo.

:start 


echo       [38;2;255;255;0mback                                   [38;2;255;255;0mversion v 0.1.0.0
echo    [38;2;0;0;255mÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»
echo     [38;5;63m[1] - [92mAdministrativeTools[92m   [38;5;63m[2] -  [92mMdSched[92m                      [38;5;63m[3] - [92mstartup[92m       [38;5;63m[4] - [92mall program pc[92m                   
echo     [38;5;63m[5] - [92mClear time file[92m       [38;5;63m[6] - [92mDownload all update Cpp[92m   [38;5;63m[7] - [92mUpdate DriteX[92m         
echo    [38;2;0;0;255mÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼

set /p input=.%BS%     [38;2;255;0;0m^>


if /I %input% EQU 4 start shutdown -s -t 14400 /c "4 hours shutdown pc : nonnsweety"

if /I %input% EQU 6 start shutdown -s -t 21600 /c "6 hours shutdown pc : nonnsweety"

if /I %input% EQU 8 start shutdown -s -t 28800 /c "8 hours shutdown pc : nonnsweety"

if /I %input% EQU cancel start shutdown /a





if /I %input% EQU back call "%SCRIPT_DIR%main.bat"

if /I %input% EQU "exit" exit 



if /I %input% EQU 21 start AdministrativeTools.lnk

if /I %input% EQU 22 start mdsched.lnk

if /I %input% EQU 23 start shell:startup

if /I %input% EQU 24 start shell:appsfolder

if /I %input% EQU 25 (
	start temp 
	start %temp%
)

if /I %input% EQU 26 start VisualCppRedist_AIO_x86_x64.exe 

if /I %input% EQU 27 start .DXSETUP.exe 

if /I %input% EQU 28 start 

if /I %input% EQU 29 start 

if /I %input% EQU 30 start 





if /I %input% EQU input (
	 
	:test_input 
	echo.
	echo [95m
	echo		ÉÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ»
	echo		³      ____                                         ___ ___   ³
	echo		³     /  _/___ _ ____ ___   __ _  ___ _ ___  ___   / _// _/   ³
	echo		³    _/ / / _ `// __// _ \ /  ' \/ _ `// _ \/ _ \ / _// _/    ³
	echo		³   /___/ \_, //_/   \___//_/_/_/\_,_//_//_/\___//_/ /_/      ³
	echo		³        /___/                                                ³
	echo		³                                                             ³
	echo		ÈÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¼
	echo.
	echo       [38;2;255;255;0mback                                   [38;2;255;255;0mversion v 0.1.0.0
	echo    [38;2;0;0;255mÉÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ»
	echo.                        
	echo.             
	echo    [38;2;0;0;255mÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ¼
	
	set /p input=.%BS%     [38;2;255;0;0m^>
	
	
	if /I %input% EQU back (
		cls 
		goto :menu 
	)  
	
	cls 
	goto :test_input
	
)



cls 
goto :menu 













  
 







