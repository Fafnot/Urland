@echo off 
mode con: cols=100 
title now user
chcp 866 >nul
color 5


:start 
call :banner


:menu 
for /f %%A in ('"prompt $H &echo on &for %%B in (1) do rem "') do set BS=%%A 
echo.
echo.


echo "…б«Ё ўл гўҐаҐ­л в® ўҐ¤ЁвҐ  | user | :keyboard en_US"

echo              О
echo              О
echo      info НННО
echo              О
echo              О  nonnsweety
set /p input=.%BS%            ИНННННННННННННН^>



if /I %input% EQU user start user.bat

if /I %input% EQU info start info_now_user.txt



cls
goto start 
echo. 
pause



:banner 
echo.
echo.
echo                          ЫЫЫЫЫЫ» ЫЫЫЫЫ» ЫЫЫЫЫЫ» ЫЫЫЫЫЫЫ»ЫЫЫЫЫЫЫ»ЫЫ»   ЫЫ»ЫЫ»     ЫЫ»  ЫЫ»   ЫЫ»
echo                         ЫЫЙННННјЫЫЙННЫЫ»ЫЫЙННЫЫ»ЫЫЙННННјЫЫЙННННјЫЫє   ЫЫєЫЫє     ЫЫє  ИЫЫ» ЫЫЙј
echo                         ЫЫє     ЫЫЫЫЫЫЫєЫЫЫЫЫЫЙјЫЫЫЫЫ»  ЫЫЫЫЫ»  ЫЫє   ЫЫєЫЫє     ЫЫє   ИЫЫЫЫЙј 
echo                         ЫЫє     ЫЫЙННЫЫєЫЫЙННЫЫ»ЫЫЙННј  ЫЫЙННј  ЫЫє   ЫЫєЫЫє     ЫЫє    ИЫЫЙј  
echo                         ИЫЫЫЫЫЫ»ЫЫє  ЫЫєЫЫє  ЫЫєЫЫЫЫЫЫЫ»ЫЫє     ИЫЫЫЫЫЫЙјЫЫЫЫЫЫЫ»ЫЫЫЫЫЫЫ»ЫЫє   
echo                          ИНННННјИНј  ИНјИНј  ИНјИННННННјИНј      ИНННННј ИННННННјИННННННјИНј  
echo.
echo.



















