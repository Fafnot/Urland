@echo off
title main file
chcp 866 > nul
mode con cols=120 lines=60
cd next  





:menu 
     
echo                                [38;2;128;0;128mษฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤป
echo                                ณ             __  __     __                __                 ณ
echo                                ณ            / / / /____/ /___ _____  ____/ /                 ณ
echo                                ณ           / / / / ___/ / __ `/ __ \/ __  /                  ณ
echo                                ณ          / /_/ / /  / / /_/ / / / / /_/ /                   ณ
echo                                ณ          \____/_/  /_/\__,_/_/ /_/\__,_/                    ณ
echo                                ณ                                                             ณ
echo                                ศฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤฤผ                            
echo.

echo                                                     [38;2;255;255;0mversion v 0.1.0.0
echo        [38;2;0;0;255mษอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออป
echo          [38;5;63m[1]-[92mblender[92m         [38;5;63m[2]-[92mPyCharm[92m        [38;5;63m[3]-[92mVirtualBox[92m       [38;5;63m[4]-[92mPhotoshop[92m       [38;5;63m[5]-[92mVS_code[92m            
echo          [38;5;63m[6]-[92mObsidian[92m        [38;5;63m[7]-[92mRadminVPN[92m      [38;5;63m[8]-[92mBoosterX[92m         [38;5;63m[9]-[92mKeePassXC[92m       [38;5;63m[10]-[92mSublimeText[92m     
echo          [38;5;63m[11]-[92mRustDesk[92m       [38;5;63m[12]-[92msystem app[92m
echo        [38;2;0;0;255mศอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออผ
echo.
echo                                                         [38;2;255;255;0mOther
echo        [38;2;0;191;255mษอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออป
echo                 [38;5;63mpc off                     [38;5;63mfor pc                                               [38;5;63mdevelops
echo         [38;2;255;0;0m[shutdown] [reboot]     [38;2;0;191;255m[pc] [store] [soft] [basket]    [massege]    [game]       [38;2;255;255;0m[git] [code] [cmd]
echo        [38;2;0;191;255mศอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออผ
echo                                                                                                                 next 
echo.
                                                                                                          
set /p input=[0m[91m{%username%}[0m [96m{%computername%}[0m %BS%[38;2;255;0;0m $ 



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







if /I %input% EQU next ( 
	
	:next_window
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

	echo       [38;2;255;255;0mback                                   [38;2;255;255;0mversion v 0.1.0.0
	echo    [38;2;0;0;255mษอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออป
	echo     [38;2;255;255;0m[21] - AdministrativeTools   [22] -  MdSched                     [23] - startup                         
	echo     [38;2;255;255;0m[24] - all program pc        [25] - Clear time file              [26] - Download all update Cpp 
	echo     [38;2;255;255;0m[27] - Update DriteX
	echo    [38;2;0;0;255mศอออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออออผ

	
	set /p input=.%BS%     [38;2;255;0;0m $ 

	


	if /I %input% EQU 4 start shutdown -s -t 14400 /c "4 hours shutdown pc : nonnsweety"

	if /I %input% EQU 6 start shutdown -s -t 21600 /c "6 hours shutdown pc : nonnsweety"			

	if /I %input% EQU 8 start shutdown -s -t 28800 /c "8 hours shutdown pc : nonnsweety"	

	if /I %input% EQU cancel start shutdown /a



	if /I %input% EQU 21 start AdministrativeTools.lnk

	if /I %input% EQU 22 start mdsched.lnk

	if /I %input% EQU 23 start shell:startup

	if /I %input% EQU 24 start shell:appsfolder

	if /I %input% EQU 25 (
		start temp 
		start %temp%
	)

	if /I %input% EQU 26 start VisualCppRedist_AIO_x86_x64.exe 

	if /I %input% EQU 27 start dxwebsetup.exe 

	if /I %input% EQU 28 start 

	if /I %input% EQU 29 start 

	if /I %input% EQU 30 start 
	
	

	if /I %input% EQU back (
		cls 
		goto :menu
	)
	
	cls
	goto :next_window 
)

  
cls 
goto :menu







