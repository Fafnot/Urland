@echo off
title next
chcp 866 >nul
cd next 



color 5



:start
call :banner 


:menu 
for /f %%A in ('"prompt $H &echo on &for %%B in (1) do rem "') do set BS=%%A 
echo.
echo.
echo                   ฬอออ 21: AdministrativeTools
echo            back ออฮ
echo	                  ฬออออ 22: MdSched
echo                 ออฮ
echo	                  ฬอออออ 23: startup
echo                 ออฮ
echo	                  ฬอออออ 24: all program pc
echo                 ออฮ
echo	                  ฬอออออ 25: Clear time file
echo                 ออฮ
echo	                  ฬอออออ 26: Download all update Cpp
echo                 ออฮ
echo	                  ฬอออออ 27: Update DriteX
echo                 ออฮ
echo	                  ฬออออออ 28:
echo                 ออฮ
echo	                  ฬออออออ 29:  
echo                 ออฮ
echo	                  ฬออออออ 30: 
echo                      ฮ
set /p input=.%BS%                    ศออออออออออออออออออออออออออ^>


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
echo.
echo           [38;2;128;0;128mÛÛÛป   ÛÛป ÛÛÛÛÛÛป  ÛÛÛÛÛÛป ÛÛÛป   ÛÛปÛÛÛป   ÛÛปÛÛÛÛÛÛÛปÛÛป    ÛÛปÛÛÛÛÛÛÛปÛÛÛÛÛÛÛปÛÛÛÛÛÛÛÛปÛÛป   ÛÛป
echo           [38;2;153;51;204mÛÛÛÛป  ÛÛบÛÛษอออÛÛปÛÛษอออÛÛปÛÛÛÛป  ÛÛบÛÛÛÛป  ÛÛบÛÛษออออผÛÛบ    ÛÛบÛÛษออออผÛÛษออออผศออÛÛษออผศÛÛป ÛÛษผ
echo           [38;2;178;102;255mÛÛษÛÛป ÛÛบÛÛบ   ÛÛบÛÛบ   ÛÛบÛÛษÛÛป ÛÛบÛÛษÛÛป ÛÛบÛÛÛÛÛÛÛปÛÛบ Ûป ÛÛบÛÛÛÛÛป  ÛÛÛÛÛป     ÛÛบ    ศÛÛÛÛษผ 
echo           [38;2;204;0;204mÛÛบศÛÛปÛÛบÛÛบ   ÛÛบÛÛบ   ÛÛบÛÛบศÛÛปÛÛบÛÛบศÛÛปÛÛบศออออÛÛบÛÛบÛÛÛปÛÛบÛÛษออผ  ÛÛษออผ     ÛÛบ     ศÛÛษผ  
echo           [38;2;229;51;255mÛÛบ ศÛÛÛÛบศÛÛÛÛÛÛษผศÛÛÛÛÛÛษผÛÛบ ศÛÛÛÛบÛÛบ ศÛÛÛÛบÛÛÛÛÛÛÛบศÛÛÛษÛÛÛษผÛÛÛÛÛÛÛปÛÛÛÛÛÛÛป   ÛÛบ      ÛÛบ   
echo           [38;2;255;102;255mศอผ  ศอออผ ศอออออผ  ศอออออผ ศอผ  ศอออผศอผ  ศอออผศออออออผ ศออผศออผ ศออออออผศออออออผ   ศอผ      ศอผ   
echo.
echo.















