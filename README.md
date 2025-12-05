NPOD
====

NASA Picture of the Day - Automatically update your desktop wallpaper with stunning astronomy images from NASA's APOD (Astronomy Picture of the Day) service.

For more information check out the [website](http://billcacy.github.io/NPOD).

## Features

- Automatically downloads NASA's Astronomy Picture of the Day
- Sets downloaded images as your desktop wallpaper
- Saves all images to your Pictures folder for later viewing
- Runs silently via scheduled task - no background processes needed
- Built on modern .NET 10 with NASA's official APOD API

## Windows Application

### Requirements
- Windows 10 or later
- .NET 10 Runtime ([Download here](https://dotnet.microsoft.com/download/dotnet/10.0))
- Internet connection

### Installation

1. **Clone the repository:**
```bash
git clone https://github.com/OscarHickman/NPOD.git
cd NPOD/windows
```

2. **Run the setup script:**
```powershell
.\Setup-ScheduledTask.ps1
```

This will:
- Build the application in Release mode
- Create a Windows Scheduled Task that runs daily at 12:00 PM
- Configure automatic wallpaper updates

### Usage

**Automatic Mode (Default):**
Once installed, the application runs automatically every day at 12:00 PM to update your wallpaper. No user interaction needed!

**Manual Mode:**
Run the app manually anytime:
```powershell
.\bin\Release\net10.0-windows\NasaPicOfDay.exe -silent
```

**System Tray Mode:**
Run without the `-silent` flag to use the classic system tray icon with menu options:
```powershell
.\bin\Release\net10.0-windows\NasaPicOfDay.exe
```

### Where Are Images Saved?

All downloaded NASA images are saved to:
```
%USERPROFILE%\Pictures\NASA\PicOfTheDay\
```

### Build from Source

```bash
cd windows
dotnet build -c Release
```

The compiled application will be in `bin\Release\net10.0-windows\`

### Uninstall

To remove the scheduled task:
```powershell
Unregister-ScheduledTask -TaskName "NPOD-DailyWallpaper" -Confirm:$false
```

## Mac Application

The Mac version is located in the `mac/` folder. See [mac/README.md](mac/README.md) for installation instructions.

## Development

Contributions are welcome! Feel free to submit pull requests for bug fixes or new features.

[**Mac todos**](https://www.pivotaltracker.com/n/projects/809635)<br />
[**Windows todos**](https://www.pivotaltracker.com/n/projects/809637)

## Technical Details

### Architecture
- **Language:** C# (.NET 10)
- **UI Framework:** Windows Forms (for system tray mode)
- **HTTP Client:** Modern HttpClient with async/await
- **JSON Serialization:** System.Text.Json
- **API:** NASA APOD (Astronomy Picture of the Day)

### API Usage
The application uses NASA's public APOD API:
```
https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY&hd=true
```

Note: The DEMO_KEY is rate-limited. For production use, [get your own free API key](https://api.nasa.gov/).

## License

See [LICENSE](LICENSE) file for details.
