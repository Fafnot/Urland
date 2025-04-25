@echo off
title Made by: Nonnsweety
chcp 65001
mode con cols=120 lines=60
cls
cd next  
Set Version=0.3.0.0

setlocal enabledelayedexpansion







:menu 
echo [38;2;128;0;128m
echo                                ╔═════════════════════════════════════════════════════════════╗
echo                                │             __  __     __                __                 │
echo                                │            / / / /____/ /___ _____  ____/ /                 │
echo                                │           / / / / ___/ / __ `/ __ \/ __  /                  │
echo                                │          / /_/ / /  / / /_/ / / / / /_/ /                   │
echo                                │          \____/_/  /_/\__,_/_/ /_/\__,_/                    │
echo                                │                                                             │
echo                                ╚═════════════════════════════════════════════════════════════╝                           
echo                                [35mMade By: [95mNonnsweety                           

echo                                                     [33mversion 0.3.0.0
echo        [38;2;0;0;255m╔═════════════════════════════════════════════════════════════════════════════════════════════════════════╗
echo          [38;5;63m[1]-[92msystem app[92m         [38;5;63m[2]-[92mPyCharm[92m        [38;5;63m[3]-[92mVirtualBox[92m       [38;5;63m[4]-[92mPhotoshop[92m       [38;5;63m[5]-[92mVS_code[92m            
echo          [38;5;63m[6]-[92mObsidian[92m           [38;5;63m[7]-[92mRadminVPN[92m      [38;5;63m[8]-[92mBoosterX[92m         [38;5;63m[9]-[92mKeePassXC[92m       [38;5;63m[10]-[92mRustDesk[92m         
echo        [38;2;0;0;255m╚═════════════════════════════════════════════════════════════════════════════════════════════════════════╝
echo.
echo                                                         [38;2;255;255;0mOther
echo        [38;2;0;191;255m╔═════════════════════════════════════════════════════════════════════════════════════════════════════════╗
echo                 [38;5;63mpc off                       [38;5;63mfor pc                                                [38;5;63mdevelops
echo         [38;2;255;0;0m[shutdown] [reboot]     [38;2;0;191;255m[inputlag] [store] [soft] [basket]   [Install] [ping]        [38;2;255;255;0m[git] [code] [cmd]
echo        [38;2;0;191;255m╚═════════════════════════════════════════════════════════════════════════════════════════════════════════╝
echo                                                                                                                 [31mnext 
echo.
                                                                                                          
set /p input=[0m[91m{%username%}[0m [96m{%computername%}[0m %BS%[38;2;255;0;0m ► 





if /I %input% EQU code ( 
	start EnhancedKeyboard.exe
	start VS_code.lnk
)

if /I %input% EQU ping start ping 8.8.8.8 -t 






if /I %input% EQU git start Git.lnk

if /I %input% EQU info_next start info_next.txt 

if /I %input% EQU basket start basket.lnk 

if /I %input% EQU cmd start custom_CMD_nonnsweety.bat 

if /I %input% EQU reboot start shutdown /r /t 5 /c "Через 5 перезакгрузится ПК : nonnsweety"

if /I %input% EQU shutdown start shutdown -s -t 5 /c "Через 5 выключится ПК : nonnsweety"

if /I %input% EQU store start store_html.html

if /I %input% EQU info_game start info_game.txt

if /I %input% EQU soft start soft_index.html

if /I %input% EQU inputlag start inputlag.bat 






if /I %input% EQU info start info_main_file.txt 

if /I %input% EQU 1 start start_Folder.vbs

if /I %input% EQU 2 start PyCharm.lnk

if /I %input% EQU 3 start VirtualBox.lnk

if /I %input% EQU 4 start Photoshop.lnk

if /I %input% EQU 5 start VS_code.lnk

if /I %input% EQU 6 start Obsidian.lnk 

if /I %input% EQU 7 start RadminVPN.lnk

if /I %input% EQU 8 start BoosterX.exe 

if /I %input% EQU 9 start KeePassXC.lnk 

if /I %input% EQU 10 start start RustDesk.lnk











if /I %input% EQU next ( 
	cls 
	goto :next_window
	
	:next_window
	echo.
	echo   [38;2;128;0;128m
	echo                                ╔═════════════════════════════════════════════════════════════╗
	echo                                │             __  __     __                __                 │
	echo                                │            / / / /____/ /___ _____  ____/ /                 │
	echo                                │           / / / / ___/ / __ `/ __ \/ __  /                  │
	echo                                │          / /_/ / /  / / /_/ / / / / /_/ /                   │
	echo                                │          \____/_/  /_/\__,_/_/ /_/\__,_/                    │
	echo                                │                                                             │
	echo                                ╚═════════════════════════════════════════════════════════════╝

	echo       [31mback                                   [33mversion 0.3.0.0
	echo    [38;2;0;0;255m╔═════════════════════════════════════════════════════════════════════════════════════════════════════════╗
	echo    [92m 
	echo     [92m[21] - AdministrativeTools   [22] -  MdSched        [23] - startup                        ╔══════════════╗  
    echo     [92m                                                                                              Shutdown
	echo     [92m[24] - all program pc        [25] - Clear cache     [26] - Download all update Cpp          [4] [6] [8]
	echo     [92m                                                                                              In hours  
	echo     [92m[27] - Update DriteX         [28] - info system     [29] - Activation Office              ╚══════════════╝
	echo     [92m 
	echo     [92m[30] - all Process 
	echo     [92m 
	echo    [38;2;0;0;255m╚═════════════════════════════════════════════════════════════════════════════════════════════════════════╝

	echo. 
	set /p input=[0m[91m{%username%}[0m [96m{%computername%}[0m %BS%[38;2;255;0;0m ► 

	


	if /I %input% EQU 4 start shutdown -s -t 14400 /c "4 hours shutdown pc : nonnsweety"

	if /I %input% EQU 6 start shutdown -s -t 21600 /c "6 hours shutdown pc : nonnsweety"			

	if /I %input% EQU 8 start shutdown -s -t 28800 /c "8 hours shutdown pc : nonnsweety"	

	if /I %input% EQU cancel start shutdown /a



	if /I %input% EQU 21 (
		start ComputerManagement.lnk
		start AdministrativeTools.lnk
	)
	
	if /I %input% EQU 28 (
		start SystemInformation.lnk
	)

	if /I %input% EQU 22 start mdsched.lnk

	if /I %input% EQU 23 start shell:startup

	if /I %input% EQU 24 start shell:appsfolder

	if /I %input% EQU 25 (
		del /q /f /s temp\*
		del /q /f /s %temp%\*
		del /q /f /s C:\Windows\SoftwareDistribution\Download\*
		del /q /f /s C:\Windows\Prefetch\*
		start temp 
		start %temp% 
		start C:\Windows\SoftwareDistribution\Download\
		start C:\Windows\Prefetch\
		start ipconfig /flushdns
		start DiskCleanup
		start dfrgui
		start SystemPropertiesProtection.lnk 
		WSReset.exe
	)

	if /I %input% EQU 26 start VisualCppRedist_AIO_x86_x64.exe 

	if /I %input% EQU 27 start dxwebsetup.exe 
	
	if /I %input% EQU 29 ( 
		start activation_Office.txt
		timeout 15
		start powershell -NoProfile -ExecutionPolicy Bypass -Command "irm https://get.activated.win | iex"
	)
	
	if /I %input% EQU 30 (
		start procexp.exe
	)

	
	if /I %input% EQU back (
		cls
		goto :menu
	)
	
	cls
	goto next_window
	

	

)


if /I %input% EQU Install (
	cls
	goto :Install
	
	
	:Install
	echo [38;5;63m⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
	echo [38;5;63m⠀⠀⠀ ⠀⠀⣰⣾⠁⠀⢦⣾⣤⠆⠀⠻⣧⠀⠀⠀⠀⠀⠀
	echo [38;5;63m⠀⠀ ⠀⢠⣼⠏⠀⠀⠀⠀⣿⡇⠀⠀⠀⠈⢷⣄⠀⠀⠀⠀
	echo [38;5;63m⠀ ⢀⣸⣿⠃⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⢿⣧⡀⠀⠀
	echo [38;5;63m⠀⢰⣾⣿⡁⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⢀⣿⣿⠖⠀                    ╔═══════════════════════╗
	echo [38;5;63m  ⠈⠻⣿⣦⣄⠀⠀⠀⠀⣿⡇⠀⠀⠀⢀⣴⣿⠟⠁⠀⠀
	echo [38;5;63m⠀ ⠀⠀⠈⠻⢿⣷⣄⡀⠀⣿⡇⠀⣠⣾⣿⠟⠁⠀⠀⠀⠀                        [33m[1] - 7z 
	echo [38;5;63m⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣦⣿⣧⣾⣿⠟⠁⠀⠀⠀⠀⠀⠀                        [33m[2] - chrome 
	echo [38;5;63m⠀⠀⠀⠀⠀⠀⠀⠀⠀⢙⣿⣿⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀                        [33m[3] - steam 
	echo [38;5;63m⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀                        [33m[4] - revo_uninstaller
	echo [38;5;63m⠀⠀⠀⠀⠀⢀⣴⣿⣿⠟⠁⣻⣿⠈⠙⢿⣿⣦⡀⠀⠀⠀⠀                        [33m[5] - screenshot
	echo [38;5;63m⠀⠀⠀⢀⣴⣿⡿⠋⠀⠀⠀⣽⣿⠀⠀⠀⠙⢿⣿⣦⣄⠀⠀                        [33m[6] - git 
	echo [38;5;63m⠀⣠⣴⣿⡿⠋⠀⠀⠀⠀⠀⢼⣿⠀⠀⠀⠀⠀⠈⢻⣿⣷⣄                        [33m[7] - office
	echo [38;5;63m⠈⠙⢿⣿⣦⣄⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⣠⣾⣿⠟⠁                        [33m[8] - 
	echo [38;5;63m⠀⠀⠀⠙⢿⣿⣷⣄⠀⠀⠀⢸⣿⠀⠀⠀⣠⣾⣿⠟⠁⠀⠀                   
	echo [38;5;63m⠀⠀⠀⠀⠀⠙⢻⣿⣷⡄⠀⢸⣿⠀⠀⣼⣿⣿⠃⠀⠀⠀⠀                   ╚═══════════════════════╝
	echo [38;5;63m⠀⠀⠀⠀⠀⠀⠈⠻⢿⣿⣦⣸⣿⣠⣾⣿⠟⠁⠀⠀⠀⠀⠀
	echo [38;5;63m⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⣿⣿⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀
	echo [38;5;63m⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀
	echo. 
	set /p input=[0m[91m{%username%}[0m [96m{%computername%}[0m %BS%[38;2;255;0;0m ► 




	if /I %input% EQU "exit" start exit 

	if /I %input% EQU 1 start 7z_install.exe

	if /I %input% EQU 2 start ChromeSetup.exe

	if /I %input% EQU 3 start SteamSetup.exe

	if /I %input% EQU 4 start revosetup.exe

	if /I %input% EQU 5 start setup-lightshot.exe

	if /I %input% EQU 6 (
		powershell Install-Module posh-git -Scope CurrentUser -Force
	)

	if /I %input% EQU 7 start MS_Office_2019.exe

	




	
	if /I %input% EQU back (
		cls
		goto :menu
	)
	
	cls
	goto :Install
)





  
cls 
goto :menu







