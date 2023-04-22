@echo off
echo Initializing Roblox Reshade Injector
echo ----------------------------------
set root=%~dp0
echo %root%
if exist "C:\Users\%username%\Roblox_Reshade_Injector" (
	echo Injecting Reshade!
	cd C:/Users/%username%/Roblox_Reshade_Injector
	start %root%gui/WRAPPER
) else (
	echo Reshade not found, setting Reshade up...
	robocopy %root%SLauncherSRC C:/Users/%username%/Roblox_Reshade_Injector
	echo Reshade Setup, launching
	cd C:/Users/%username%/SLauncherMC
	start %root%gui/WRAPPER
)
pause