@echo off

skypack install Skytech.Application.ansible --env DEV
if %errorlevel% neq 0 exit /b %errorlevel%

ansible -i PROD -l CollaboServer -m win_copy ---src "reference/stages-api.yaml" ---dest "E:\Data\Collabo\stages-api.yaml"

PAUSE