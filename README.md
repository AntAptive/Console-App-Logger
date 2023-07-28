![Console App Logger](/consoleAppLoggerBanner.png)

### A simple program that allows the user to run and keep logs of a console application.

This is my first Windows Forms application and I wanted to post it on GitHub for everyone to check it out.<br>

### [Check out my other projects!](https://antaptive.com/projects/)

# How to install
1. Check our [Releases page](https://github.com/AntAptive/Console-App-Logger/releases) to download the latest release.
2. Extract the .zip file anywhere.
3. Run the file `Console App Logger.exe`.

# How to use
- Press "Open File..." to choose an applicable .exe file.
- Press "Start Process" to begin the selected process.
- Press "Save log to file" to save the log without having to stop the process.
- Press "Stop Process" to stop the process.
- Use the command line to send commands to the running process.

# Settings
- Dump log to file: If checked, the program will save the log to a file upon exit.
- Include timestamps in log: If checked, the program will include the time and date for every line in the log.
- Minimize to tray: If checked, the program will minimize to the system tray when the user presses the X/Close button.

# How to run in Visual Studio
- Download the Source Code zip.
- Use Visual Studio 2022.
- Set "Console App Logger" to the startup project.
1. In Solution Explorer, highlight the "Console App Logger" project and right-click on it.
2. In the popup menu, click "Set As Startup Project".

# Known bugs
- "Kill Process" in the system tray dialog does nothing.
- Input lines will not appear in the log until after an input is entered.
   - Code: `set /p cho=Enter:` (from .bat file converted to .exe)
   - Expected Output: `Enter:`
- Output log does not automatically scroll.
- If the program is terminated abruptly, the console app may continue running in the background.
- Program will throw an exception if the user attempts to send a command while a process isn't running.

# Future Project Goals
- Add support for .bat and maybe .cmd files.
- Add support for multiple console apps running simultaneously.
