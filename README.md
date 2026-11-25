# 🎮 Just a Game

> ⚠️ **Learning Project** — This is my **first ever Unity game**, built purely for learning purposes as part of my AR/VR assignments. It's simple, it's rough around the edges, and I'm proud of it!

---

## 📖 Overview

**Just a Game** is a 3D platformer built in **Unity 2022.3 LTS** using **C#**. The player navigates through two levels filled with moving platforms, enemies, and collectible coins — all the way to a finish line. It features a start screen, two gameplay levels, and an end screen.

The goal of this project was to get hands-on experience with:
- Unity's physics and input system
- Scene management and UI
- C# scripting for game mechanics
- Audio integration
- Prefab-based level design

---

## 🕹️ Gameplay

### Controls

| Key | Action |
|-----|--------|
| `W / A / S / D` or Arrow Keys | Move |
| `Space` | Jump |

### How to Play
1. Launch the game and hit **Start** on the main menu.
2. Navigate through **Level 01** and **Level 02**, avoiding enemies and hazards.
3. Collect **coins** scattered across each level.
4. Reach the **Finish** platform to advance to the next level.
5. After completing both levels, the **End Screen** appears — you win! 🎉

### Die & Respawn
- Touch an **enemy's body** → you die and the level restarts.
- **Jump on an enemy's head** → stomp it to defeat the enemy and get a bounce!
- **Fall off the map** (y < -1) → instant respawn.

---

## ✨ Features

- 🏃 **Smooth 3D player movement** with Rigidbody physics
- 🦘 **Jump mechanic** with ground-check using `Physics.CheckSphere`
- 👾 **Enemies** — static and walking (waypoint-following patrol)
- 🪙 **Collectible coins** with live counter UI (TextMesh Pro)
- 🚡 **Moving platforms** — sideways & up-down, waypoint-based
- 🧲 **Sticky platforms** so the player doesn't slip off
- 🏁 **Finish trigger** that loads the next scene
- 🎵 **Background music** + sound effects (jump, die, coin collect)
- 📺 **Start Screen**, **Level 01**, **Level 02**, **End Screen** — 4 scenes total
- 🔁 **Level restart on death** with a brief delay

---

## 🗂️ Project Structure

```
just_a_game/
├── Assets/
│   ├── script/              # All custom C# scripts
│   │   ├── PlayerMovement.cs    # Movement, jumping, enemy stomp
│   │   ├── PlayerLife.cs        # Death detection & respawn
│   │   ├── ItemCollectable.cs   # Coin pickup + counter
│   │   ├── Finish.cs            # Level completion trigger
│   │   ├── WaypointFollower.cs  # Moving platforms & walking enemies
│   │   ├── StickyPlatform.cs    # Player sticks to moving platforms
│   │   ├── Rotate.cs            # Rotating objects (coins, etc.)
│   │   ├── StartMenu.cs         # Start button → load Level 01
│   │   └── EndMenu.cs           # Exit button
│   ├── Scenes/
│   │   ├── StartScreen.unity
│   │   ├── Level01.unity
│   │   ├── Level02.unity
│   │   └── EndScreen.unity
│   ├── Prefab/              # Reusable game objects
│   │   ├── Player.prefab
│   │   ├── Coin.prefab
│   │   ├── Enemy.prefab
│   │   ├── Walking Enemie1.prefab
│   │   ├── Floor.prefab
│   │   ├── Finish.prefab
│   │   ├── sideways-movingPlatform.prefab
│   │   └── up-down-movingPlatform.prefab
│   ├── Materials/           # Visual materials
│   ├── Music/               # Background track (Beat em All)
│   ├── CasualGameSounds/    # 50 SFX clips
│   └── Physics Material/    # Slippery physics material
└── ProjectSettings/
```

---

## 🎬 Video Demo

> 📹 _Add your gameplay recording here!_

<!-- Replace the link below with your actual video URL (YouTube, Google Drive, etc.) -->

[![Watch the Demo](https://img.shields.io/badge/▶%20Watch%20Demo-Click%20Here-red?style=for-the-badge&logo=youtube)](YOUR_VIDEO_LINK_HERE)

> **To add your demo:**
> 1. Record your gameplay (OBS, Unity Recorder, or screen capture).
> 2. Upload it to YouTube or Google Drive.
> 3. Replace `YOUR_VIDEO_LINK_HERE` above with the actual URL.

---

## 🛠️ Built With

| Tool | Version |
|------|---------|
| Unity | 2022.3.62f1 LTS |
| Language | C# |
| TextMesh Pro | Built-in |
| Physics | Unity Rigidbody |
| Audio | Unity AudioSource |

---

## 📚 What I Learned

This being my **first game**, here's what I picked up:

- ✅ Setting up a Unity project from scratch
- ✅ Writing `MonoBehaviour` scripts in C#
- ✅ Using `Rigidbody` for physics-based movement
- ✅ Scene management with `SceneManager.LoadScene()`
- ✅ Collision detection with `OnCollisionEnter` and `OnTriggerEnter`
- ✅ Building a waypoint-based movement system (platforms & enemies)
- ✅ Playing audio clips on events (jump, die, collect)
- ✅ Connecting UI elements (TextMesh Pro) to game state
- ✅ Using Prefabs to reuse game objects across scenes
- ✅ Organizing a multi-scene Unity project (Start → Level01 → Level02 → End)

---

## 🚀 How to Run

1. Clone or download this repository.
2. Open **Unity Hub** and add the project folder.
3. Make sure you have **Unity 2022.3.x** installed.
4. Open the project, then open `Assets/Scenes/StartScreen.unity`.
5. Press ▶ **Play** in the Unity Editor — or build it!

---

## 🙏 Acknowledgements

- Background music: *Beat em All* (included in `/Assets/Music/`)
- Sound effects: *Casual Game Sounds* pack (`/Assets/CasualGameSounds/`)
- Built as part of **AR/VR Assignments** coursework

---

*Made with ❤️ and a lot of trial-and-error. It's just a game — but it's mine!*
