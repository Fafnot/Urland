@echo off
title main file
chcp 866 > nul
mode con cols=120 lines=60
cd next  


set "SCRIPT_DIR=%~dp0"




rem ํโฎ ญ คฎ ขฅแโจ ข PowerShell windows คฎซฆญ  ก๋โ์ ญฎขฅฅ 10 จซจ 10 reg add HKCU\Console /v VirtualTerminalLevel /t REG_DWORD /d 1




:start
call :banner



:menu 
for /f %%A in ('"prompt $H &echo on &for %%B in (1) do rem "') do set BS=%%A 


echo                                                     [38;2;255;255;0mversion v 0.1.0.0
echo        [38;2;0;0;255mษอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออป
echo          [1]: blender         [2]: PyCharm        [3]: VirtualBox       [4]: Photoshop       [5]: VS_code        
echo.    
echo          [6]: Obsidian        [7]: RadminVPN      [8]: BoosterX         [9]: KeePassXC       [10]: SublimeText 
echo.    
echo          [11]: RustDesk       [12]: system app
echo        ศอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออผ
echo.
echo                                                         [38;2;255;255;0mOther
echo        ษอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออป
echo                  pc off                     for pc                                               develops
echo           [shutdown] [reboot]     [pc] [store] [soft] [basket]    [massege]    [game]       [git] [code] [cmd]
echo        ศอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออผ
echo                                                                                                                 next 
                                                                                                                                
set /p input=.%BS%      [38;2;255;0;0m^>



if /I %input% EQU game (
    start C:\SetTimerResolution.exe --resolution 5000 --no-console
    start GameModeX.lnk
)

if /I %input% EQU massege (
	start Telegram.lnk
	start Vesktop.lnk
)

if /I %input% EQU code (
	start EnhancedKeyboard.exe
	start VS_code.lnk
)


if /I %input% EQU git start Git.lnk

if /I %input% EQU info_next start info_next.txt 

if /I %input% EQU basket start basket.lnk 

if /I %input% EQU cmd start cmd.lnk 

if /I %input% EQU pc start pc_optimizeshen  

if /I %input% EQU reboot start shutdown /r /t 5 /c "็ฅเฅง 5 แฅช กใคฅโ ฏฅเฅง ฃเใงช  : nonnsweety"

if /I %input% EQU shutdown start shutdown -s -t 5 /c "—ฅเฅง 5 แฅช กใคฅโ ข๋ชซ๎็ฅญจฅ : nonnsweety"

if /I %input% EQU FileZilla start FileZillaClient.lnk

if /I %input% EQU filezilla start FileZillaClient.lnk

if /I %input% EQU store start store_html.html

if /I %input% EQU info_game start info_game.txt

if /I %input% EQU soft start soft_index.html


if /I "%input%" EQU "next" (
    cd /d "%SCRIPT_DIR%"
    call "%SCRIPT_DIR%next.bat"
)


if /I %input% EQU info start info_main_file.txt 

if /I %input% EQU 1 start blender.lnk

if /I %input% EQU 2 start PyCharm.lnk

if /I %input% EQU 3 start VirtualBox.lnk

if /I %input% EQU 4 start Photoshop.lnk

if /I %input% EQU 5 start VS_code.lnk

if /I %input% EQU 6 start Obsidian.lnk 

if /I %input% EQU 7 start RadminVPN.lnk

if /I %input% EQU 8 start BoosterX.exe 

if /I %input% EQU 9 start KeePassXC.lnk 

if /I %input% EQU 10 start SublimeText.lnk 

if /I %input% EQU 11 start RustDesk.lnk

if /I %input% EQU 12 start start_Folder.vbs

if /I %input% EQU 13 start 








cls
goto start 
echo. 
pause





:banner
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






