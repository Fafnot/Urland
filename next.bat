@echo off
title next
chcp 866 >nul
cd next 



color 5



:start
call :banner 


:menu 
for /f %%A in ('"prompt $H &echo on &for %%B in (1) do rem "') do set BS=%%A 

echo       [38;2;255;255;0mback                                   [38;2;255;255;0mversion v 0.1.0.0
echo    [38;2;0;0;255mษอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออป
echo     [38;5;63m[1] - [92mAdministrativeTools[92m   [38;5;63m[2] -  [92mMdSched[92m                      [38;5;63m[3] - [92mstartup[92m       [38;5;63m[4] - [92mall program pc[92m                   
echo     [38;5;63m[5] - [92mClear time file[92m       [38;5;63m[6] - [92mDownload all update Cpp[92m   [38;5;63m[7] - [92mUpdate DriteX[92m         
echo    [38;2;0;0;255mศอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออผ

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




cls 
goto start 
echo. 
pause





:banner
echo.
echo   [38;2;128;0;128m
echo                ษฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤป
echo                ณ                                                                                   ณ
echo                ณ      ÛÛป   ÛÛป    ÛÛÛÛÛÛป     ÛÛป          ÛÛÛÛÛป     ÛÛÛป   ÛÛป    ÛÛÛÛÛÛป       ณ
echo                ณ      ÛÛบ   ÛÛบ    ÛÛษออÛÛป    ÛÛบ         ÛÛษออÛÛป    ÛÛÛÛป  ÛÛบ    ÛÛษออÛÛป      ณ
echo                ณ      ÛÛบ   ÛÛบ    ÛÛÛÛÛÛษผ    ÛÛบ         ÛÛÛÛÛÛÛบ    ÛÛษÛÛป ÛÛบ    ÛÛบ  ÛÛบ      ณ
echo                ณ      ÛÛบ   ÛÛบ    ÛÛษออÛÛป    ÛÛบ         ÛÛษออÛÛบ    ÛÛบศÛÛปÛÛบ    ÛÛบ  ÛÛบ      ณ
echo                ณ      ศÛÛÛÛÛÛษผ    ÛÛบ  ÛÛบ    ÛÛÛÛÛÛÛป    ÛÛบ  ÛÛบ    ÛÛบ ศÛÛÛÛบ    ÛÛÛÛÛÛษผ      ณ
echo                ณ       ศอออออผ     ศอผ  ศอผ    ศออออออผ    ศอผ  ศอผ    ศอผ  ศอออผ    ศอออออผ       ณ
echo                ณ                                                                                   ณ
echo                ศฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤผ
echo.
echo.















