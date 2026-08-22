# 🚜 Crazy Farm

## 📖 Overview
This repository contains a 3D top-down shooter built in Unity. Originally provided as a university base project, I expanded the codebase by engineering a dynamic difficulty curve, integrating interconnected game systems, and building a complete game loop from the main menu to the game-over state.

## 🛠️ Tech Stack
* **Engine:** Unity
* **Language:** C#

## 🚀 Key Systems & Features Implemented
* **Event-Driven Progression (GameManager):** Implemented modular logic to track score thresholds and trigger global game state changes. Programmed a milestone system that spawns a special high-value entity (Rooster) at exact 20-point intervals using modulo operators.
* **Dynamic Difficulty Curve:** Engineered a system that increases global game speed every 50 points ramping up the difficulty.
* **Dynamic Audio Pitching:** Created an audio controller that responds to the difficulty curve. As the game speeds up, the background music pitch increases proportionally (capped at 2.0x) to artificially build player tension.
* **Component Modularity:** Exposed key variables to the Unity Editor, allowing different enemy prefabs to have unique speeds and point values without requiring redundant or hardcoded scripts.
* **Game Loop & Scene Management:** Built the core UI (Health, Score) and a complete state loop. Upon player death, the game halts spawning, displays the Game Over state, and utilizes Coroutines/Invokes to smoothly transition back to the custom Title Screen.
