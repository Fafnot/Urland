@echo off
title main file
chcp 866 > nul
cd next  


set "SCRIPT_DIR=%~dp0"









:start
call :banner



:menu 
for /f %%A in ('"prompt $H &echo on &for %%B in (1) do rem "') do set BS=%%A 
echo                   ÌÍÍÍ 1: Blender                                                Rust Desk :11 ÍÍÍÎ
echo            info ÍÍÎ                                                                               ÎÍÍ code
echo	                  ÌÍÍÍÍ 2: pycharm                                             System app :12 ÍÍÍÍ¹
echo            game ÍÍÎ                                                                               ÎÍÍ 
echo	                  ÌÍÍÍÍÍ 3: VirtualBox                                                   :13 ÍÍÍÍÍ¹
echo         massege ÍÍÎ                                                                               ÎÍÍ
echo	                  ÌÍÍÍÍÍ 4: Photoshop                                                    :14 ÍÍÍÍÍ¹
echo            soft ÍÍÎ                                                                               ÎÍÍ
echo	                  ÌÍÍÍÍÍ 5: VS_code                                                      :15 ÍÍÍÍÍ¹
echo             cmd ÍÍÎ                                                                               ÎÍÍ
echo	                  ÌÍÍÍÍÍ 6: Obsidian                                                     :16 ÍÍÍÍÍ¹
echo           store ÍÍÎ                                                                               ÎÍÍ
echo	                  ÌÍÍÍÍÍ 7: RadminVPN                                                    :17 ÍÍÍÍÍ¹
echo       FileZilla ÍÍÎ                                                                               ÎÍÍ
echo	                  ÌÍÍÍÍÍÍ 8: BoosterX                                                   :18 ÍÍÍÍÍÍ¹
echo          basket ÍÍÎ                                                                               ÎÍÍ
echo	                  ÌÍÍÍÍÍÍ 9: KeePassXC                                                  :19 ÍÍÍÍÍÍ¹
echo             git ÍÍÎ                                                                               ÎÍÍ next
echo	                  ÌÍÍÍÍÍÍ 10: SublimeText                                               :20 ÍÍÍÍÍÍ¹
echo                   ;                                                                               Î                                                                                                                       
set /p input=.%BS%                 ÈÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍÍ^>



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

if /I %input% EQU reboot start shutdown /r /t 5 /c "ç¥à¥§ 5 á¥ª ¡ã¤¥â ¯¥à¥§ £àã§ª  : nonnsweety"

if /I %input% EQU shutdown start shutdown -s -t 5 /c "—¥à¥§ 5 á¥ª ¡ã¤¥â ¢ëª«îç¥­¨¥ : nonnsweety"

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









goto start 
echo. 





:banner
echo. 
echo.
echo           [38;2;128;0;128mÛÛÛ»   ÛÛ» ÛÛÛÛÛÛ» ÛÛÛ»   ÛÛ»ÛÛÛ»   ÛÛ»ÛÛÛÛÛÛÛ»ÛÛ»    ÛÛ»ÛÛÛÛÛÛÛ»ÛÛÛÛÛÛÛ»ÛÛÛÛÛÛÛÛ»ÛÛ»   ÛÛ»
echo           [38;2;153;51;204mÛÛÛÛ»  ÛÛºÛÛÉÍÍÍÛÛ»ÛÛÛÛ»  ÛÛºÛÛÛÛ»  ÛÛºÛÛÉÍÍÍÍ¼ÛÛº    ÛÛºÛÛÉÍÍÍÍ¼ÛÛÉÍÍÍÍ¼ÈÍÍÛÛÉÍÍ¼ÈÛÛ» ÛÛÉ¼
echo           [38;2;178;102;255mÛÛÉÛÛ» ÛÛºÛÛº   ÛÛºÛÛÉÛÛ» ÛÛºÛÛÉÛÛ» ÛÛºÛÛÛÛÛÛÛ»ÛÛº Û» ÛÛºÛÛÛÛÛ»  ÛÛÛÛÛ»     ÛÛº    ÈÛÛÛÛÉ¼ 
echo           [38;2;204;0;204mÛÛºÈÛÛ»ÛÛºÛÛº   ÛÛºÛÛºÈÛÛ»ÛÛºÛÛºÈÛÛ»ÛÛºÈÍÍÍÍÛÛºÛÛºÛÛÛ»ÛÛºÛÛÉÍÍ¼  ÛÛÉÍÍ¼     ÛÛº     ÈÛÛÉ¼
echo           [38;2;229;51;255mÛÛº ÈÛÛÛÛºÈÛÛÛÛÛÛÉ¼ÛÛº ÈÛÛÛÛºÛÛº ÈÛÛÛÛºÛÛÛÛÛÛÛºÈÛÛÛÉÛÛÛÉ¼ÛÛÛÛÛÛÛ»ÛÛÛÛÛÛÛ»   ÛÛº      ÛÛº     
echo           [38;2;255;102;255mÈÍ¼  ÈÍÍÍ¼ ÈÍÍÍÍÍ¼ ÈÍ¼  ÈÍÍÍ¼ÈÍ¼  ÈÍÍÍ¼ÈÍÍÍÍÍÍ¼ ÈÍÍ¼ÈÍÍ¼ ÈÍÍÍÍÍÍ¼ÈÍÍÍÍÍÍ¼   ÈÍ¼      ÈÍ¼     
echo.
echo.





