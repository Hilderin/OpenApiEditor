@echo off

skypack install Skytech.Application.ansible --env DEV
if %errorlevel% neq 0 exit /b %errorlevel%

ansible -i PROD -l CollaboServer -m win_copy ---src "reference/demo-api.yaml" ---dest "E:\Data\Collabo\demo-api.yaml"

PAUSE