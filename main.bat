@echo off
title main file
chcp 65001 >nul
cd files
color 5



:start
call :banner



:menu 
for /f %%A in ('"prompt $H &echo on &for %%B in (1) do rem "') do set BS=%%A 
echo                   ╠═══ 1: Blender                                                Rust Desk :11 ═══╬
echo            info ══╬                                                                               ╬══ code
echo	                  ╠════ 2: pycharm                                             System app :12 ════╣
echo            game ══╬                                                                               ╬══ 
echo	                  ╠═════ 3: VirtualBox                                                   :13 ═════╣
echo         massege ══╬                                                                               ╬══
echo	                  ╠═════ 4: Photoshop                                                    :14 ═════╣
echo            soft ══╬                                                                               ╬══
echo	                  ╠═════ 5: VS_code                                                      :15 ═════╣
echo             cmd ══╬                                                                               ╬══
echo	                  ╠═════ 6: Obsidian                                                     :16 ═════╣
echo           store ══╬                                                                               ╬══
echo	                  ╠═════ 7: RadminVPN                                                    :17 ═════╣
echo       FileZilla ══╬                                                                               ╬══
echo	                  ╠══════ 8: BoosterX                                                   :18 ══════╣
echo          basket ══╬                                                                               ╬══
echo	                  ╠══════ 9: KeePassXC                                                  :19 ══════╣
echo             git ══╬                                                                               ╬══ next
echo	                  ╠══════ 10: SublimeText                                               :20 ══════╣
echo                   ╬                                                                               ╬                                                                                                                       
set /p input=.%BS%                 ╚══════════════════════════^>



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

if /I %input% EQU reboot start shutdown /r /t 5 /c "через 5 сек будет перезагрузка : nonnsweety"

if /I %input% EQU shutdown start shutdown -s -t 5 /c "Через 5 сек будет выключение : nonnsweety"

if /I %input% EQU FileZilla start FileZillaClient.lnk

if /I %input% EQU filezilla start FileZillaClient.lnk

if /I %input% EQU store start store_html.html

if /I %input% EQU info_game start info_game.txt

if /I %input% EQU soft start soft_index.html

if /I %input% EQU next start next.bat

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
echo. 
echo.
echo           [38;2;128;0;128m███╗   ██╗ ██████╗ ███╗   ██╗███╗   ██╗███████╗██╗    ██╗███████╗███████╗████████╗██╗   ██╗
echo           [38;2;153;51;204m████╗  ██║██╔═══██╗████╗  ██║████╗  ██║██╔════╝██║    ██║██╔════╝██╔════╝╚══██╔══╝╚██╗ ██╔╝
echo           [38;2;178;102;255m██╔██╗ ██║██║   ██║██╔██╗ ██║██╔██╗ ██║███████╗██║ █╗ ██║█████╗  █████╗     ██║    ╚████╔╝ 
echo           [38;2;204;0;204m██║╚██╗██║██║   ██║██║╚██╗██║██║╚██╗██║╚════██║██║███╗██║██╔══╝  ██╔══╝     ██║     ╚██╔╝
echo           [38;2;229;51;255m██║ ╚████║╚██████╔╝██║ ╚████║██║ ╚████║███████║╚███╔███╔╝███████╗███████╗   ██║      ██║     
echo           [38;2;255;102;255m╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝ ╚══╝╚══╝ ╚══════╝╚══════╝   ╚═╝      ╚═╝     
echo.
echo.





