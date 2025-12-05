NPOD
====

NASA Pic of the Day

For more information check out the [website](http://billcacy.github.io/NPOD).

## Recent Updates (December 2025)

**Windows Application Migrated to .NET 10:**
- Upgraded from .NET Framework 4.5.1 to .NET 10
- Migrated from Newtonsoft.Json to System.Text.Json
- Replaced obsolete WebClient/WebRequest with HttpClient
- Updated to NASA APOD API (Astronomy Picture of the Day)
- Modernized Windows Forms APIs (ContextMenuStrip, ToolStripMenuItem)
- All code cleaned and warnings resolved

**Requirements:**
- Windows with .NET 10 Runtime
- Internet connection for NASA API access

**Build Instructions:**
```bash
cd windows
dotnet build -c Release
```

## Development

There's still some work left to be done on both the Mac and Windows apps. Check out our list of things left to do in pivotal tracker and feel free to work on them. Just submit a pull request with your code updates, and what it addresses.

[**Mac todos**](https://www.pivotaltracker.com/n/projects/809635)<br />
[**Windows todos**](https://www.pivotaltracker.com/n/projects/809637)
