@echo off
title main file
chcp 866 > nul
mode con cols=120 lines=60
cd next  


set "SCRIPT_DIR=%~dp0"









:start
call :banner



:menu 
for /f %%A in ('"prompt $H &echo on &for %%B in (1) do rem "') do set BS=%%A 


echo                                                     [38;2;255;255;0mversion v 0.1.0.0
echo        [38;2;0;0;255m浜様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様�
echo          [38;5;63m[1]-[92mblender[92m         [38;5;63m[2]-[92mPyCharm[92m        [38;5;63m[3]-[92mVirtualBox[92m       [38;5;63m[4]-[92mPhotoshop[92m       [38;5;63m[5]-[92mVS_code[92m            
echo          [38;5;63m[6]-[92mObsidian[92m        [38;5;63m[7]-[92mRadminVPN[92m      [38;5;63m[8]-[92mBoosterX[92m         [38;5;63m[9]-[92mKeePassXC[92m       [38;5;63m[10]-[92mSublimeText[92m     
echo          [38;5;63m[11]-[92mRustDesk[92m       [38;5;63m[12]-[92msystem app[92m
echo        [38;2;0;0;255m藩様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様�
echo.
echo                                                         [38;2;255;255;0mOther
echo        [38;2;0;191;255m浜様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様�
echo                 pc off                     for pc                                               develops
echo         [38;2;255;0;0m[shutdown] [reboot]     [38;2;0;191;255m[pc] [store] [soft] [basket]    [massege]    [game]       [38;2;255;255;0m[git] [code] [cmd]
echo        [38;2;0;191;255m藩様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様様�
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

if /I %input% EQU reboot start shutdown /r /t 5 /c "腑爛� 5 瓮� ＜ぅ� �ムェ��珮И� : nonnsweety"

if /I %input% EQU shutdown start shutdown -s -t 5 /c "�ムェ 5 瓮� ＜ぅ� �覈�鈑キ┘ : nonnsweety"

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
echo                苗陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳�
echo                �                                                                                   �
echo                �      栩�   栩�    栩栩栩�     栩�          栩栩杙     栩杙   栩�    栩栩栩�       �
echo                �      栩�   栩�    栩浜陽杙    栩�         栩浜陽杙    栩栩�  栩�    栩浜陽杙      �
echo                �      栩�   栩�    栩栩栩票    栩�         栩栩栩杠    栩布杙 栩�    栩�  栩�      �
echo                �      栩�   栩�    栩浜陽杙    栩�         栩浜陽杠    栩哉栩斯杠    栩�  栩�      �
echo                �      匪栩栩柯�    栩�  栩�    栩栩栩杙    栩�  栩�    栩� 匪栩杠    栩栩栩票      �
echo                �       藩様様�     藩�  藩�    藩様様夕    藩�  藩�    藩�  藩様�    藩様様�       �
echo                �                                                                                   �
echo                板陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳陳�
echo.






