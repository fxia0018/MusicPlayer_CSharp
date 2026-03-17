# 🎵 Jace's Music Player
A terminal-based interactive music player built with **C#** and the **SplashKit SDK**.

## 📋 Audio Setup
To run this application, ensure the following `.ogg` files are placed in the project root directory. The filenames must match the internal logic precisely:

| ID | Song Title | Required Filename |
| :--- | :--- | :--- |
| 1 | Kokoro no Ame | `Kokoro no Ame.ogg` |
| 2 | Itsudemo Hohoemi wo | `Itsudemo Hohoemi wo.ogg` |
| 3 | Hello! | `hello.ogg` |
| 4 | Feel the rain | `rain.ogg` |

## 🎮 Controls & Commands
Once the program is running, use the following inputs in the terminal:

### Main Menu
- **`start`**: Opens the song selection menu (1-4).
- **`p`**: Toggle **Pause/Resume** for the current track.
- **`quit`**: Stops all audio and exits the player safely.

### During Playback (Real-time)
- **`P`**: Press the 'P' key to pause or resume without re-entering the menu.
- **`Q`**: Press the 'Q' key to stop music and force quit the loop.

## 🛠️ Technical Implementation
- **Audio Engine**: Powered by `SplashKitSDK` using `LoadMusic` and `PlayMusic`.
- **Input Handling**: Utilizes `Console.KeyAvailable` for non-blocking real-time keyboard interaction.
- **Fade Effect**: Implements `FadeMusicOut(2000)` to ensure a smooth transition upon exiting.

---
*Developed as part of a C# systems logic study at Monash University.*
