# NPOD - NASA Picture of the Day - Scheduled Task Setup
# This script builds the application and creates a daily scheduled task to update your wallpaper

Write-Host "=== NPOD Daily Wallpaper Updater Setup ===" -ForegroundColor Cyan
Write-Host ""

# Build the application
Write-Host "Building application in Release mode..." -ForegroundColor Yellow
$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path
Set-Location $scriptPath

dotnet build -c Release
if ($LASTEXITCODE -ne 0) {
    Write-Host "Build failed! Please fix any errors and try again." -ForegroundColor Red
    exit 1
}

Write-Host "Build successful!" -ForegroundColor Green
Write-Host ""

# Get the executable path
$exePath = Join-Path $scriptPath "bin\Release\net10.0-windows\NasaPicOfDay.exe"

if (-not (Test-Path $exePath)) {
    Write-Host "Error: Could not find executable at $exePath" -ForegroundColor Red
    exit 1
}

Write-Host "Executable found: $exePath" -ForegroundColor Green
Write-Host ""

# Create scheduled task
Write-Host "Creating scheduled task..." -ForegroundColor Yellow

$taskName = "NPOD-DailyWallpaper"
$taskDescription = "Updates desktop wallpaper with NASA's Picture of the Day"

# Remove existing task if it exists
$existingTask = Get-ScheduledTask -TaskName $taskName -ErrorAction SilentlyContinue
if ($existingTask) {
    Write-Host "Removing existing task..." -ForegroundColor Yellow
    Unregister-ScheduledTask -TaskName $taskName -Confirm:$false
}

# Create action - run with -silent flag
$action = New-ScheduledTaskAction -Execute $exePath -Argument "-silent" -WorkingDirectory (Split-Path $exePath)

# Create trigger - daily at 12:00 PM
$trigger = New-ScheduledTaskTrigger -Daily -At "12:00PM"

# Create settings
$settings = New-ScheduledTaskSettingsSet `
    -AllowStartIfOnBatteries `
    -DontStopIfGoingOnBatteries `
    -StartWhenAvailable `
    -RunOnlyIfNetworkAvailable `
    -ExecutionTimeLimit (New-TimeSpan -Minutes 10)

# Create principal (run as current user)
$principal = New-ScheduledTaskPrincipal -UserId "$env:USERDOMAIN\$env:USERNAME" -RunLevel Limited

# Register the task
Register-ScheduledTask `
    -TaskName $taskName `
    -Description $taskDescription `
    -Action $action `
    -Trigger $trigger `
    -Settings $settings `
    -Principal $principal

Write-Host ""
Write-Host "=== Setup Complete! ===" -ForegroundColor Green
Write-Host ""
Write-Host "Scheduled task '$taskName' has been created." -ForegroundColor Cyan
Write-Host "- Runs daily at 12:00 PM" -ForegroundColor White
Write-Host "- Downloads NASA's Astronomy Picture of the Day" -ForegroundColor White
Write-Host "- Sets it as your desktop wallpaper" -ForegroundColor White
Write-Host "- Saves images to: $env:USERPROFILE\Pictures\NASA\PicOfTheDay" -ForegroundColor White
Write-Host ""
Write-Host "To test immediately, run:" -ForegroundColor Yellow
Write-Host "  Start-ScheduledTask -TaskName '$taskName'" -ForegroundColor White
Write-Host ""
Write-Host "To run manually:" -ForegroundColor Yellow
Write-Host "  $exePath -silent" -ForegroundColor White
Write-Host ""
Write-Host "To uninstall, run:" -ForegroundColor Yellow
Write-Host "  Unregister-ScheduledTask -TaskName '$taskName' -Confirm:`$false" -ForegroundColor White
Write-Host ""
