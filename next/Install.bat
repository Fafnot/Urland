@echo off
title Made by: Nonnsweety
chcp 65001
mode con cols=120 lines=60
cls
Set Version=0.2.1.1

setlocal enabledelayedexpansion




:next_window
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
echo [38;5;63m⠀⣠⣴⣿⡿⠋⠀⠀⠀⠀⠀⢼⣿⠀⠀⠀⠀⠀⠈⢻⣿⣷⣄                     
echo [38;5;63m⠈⠙⢿⣿⣦⣄⠀⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⣠⣾⣿⠟⠁                   ╚═══════════════════════╝
echo [38;5;63m⠀⠀⠀⠙⢿⣿⣷⣄⠀⠀⠀⢸⣿⠀⠀⠀⣠⣾⣿⠟⠁⠀⠀
echo [38;5;63m⠀⠀⠀⠀⠀⠙⢻⣿⣷⡄⠀⢸⣿⠀⠀⣼⣿⣿⠃⠀⠀⠀⠀
echo [38;5;63m⠀⠀⠀⠀⠀⠀⠈⠻⢿⣿⣦⣸⣿⣠⣾⣿⠟⠁⠀⠀⠀⠀⠀
echo [38;5;63m⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⣿⣿⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀
echo [38;5;63m⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀
echo. 
set /p input=[0m[91m{%username%}[0m [96m{%computername%}[0m %BS%[38;2;255;0;0m ► 



if /I %input% EQU 1 start 7z_install.exe

if /I %input% EQU 2 start ChromeSetup.exe

if /I %input% EQU 3 start SteamSetup.exe

if /I %input% EQU 4 start revosetup.exe

if /I %input% EQU 5 start setup-lightshot.exe

if /I %input% EQU 6 (
	powershell Install-Module posh-git -Scope CurrentUser -Force
)




cls
goto :next_window