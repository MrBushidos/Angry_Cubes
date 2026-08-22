# 🧊 Angry Cubes - Mobile AR Physics Sandbox

## 📖 Overview
An exploratory Augmented Reality (AR) prototype built to study spatial computing and mobile AR deployment. Based on an educational framework, the goal of this project was to get hands-on experience configuring AR SDKs, handling camera passthrough, and managing physics interactions in mixed reality.

## 🛠️ Tech Stack
* **Engine:** Unity
* **Framework:** AR Foundation / XR Interaction Toolkit
* **Target:** Mobile AR

## 🚀 Core Implementations
* **Spatial Mapping:** Configured AR Plane Manager to scan environments and detect horizontal/vertical surfaces to anchor digital objects.
* **Raycasting & Instantiation:** Implemented screen-to-world raycasting to allow users to spawn 3D geometry (blocks, planks) directly onto detected real-world planes.
* **Mixed Reality Physics:** Configured Unity's Rigidbody and Collider systems to allow physical projectiles to interact with instantiated structures in physical space.

## 🐞 Technical Notes & Known Issues (WIP)
Currently debugging a specific Rigidbody/Collider resolution issue within the physics engine:
* **The "Plank" Collider Bug:** The "Plank" prefab currently has an improperly scaled BoxCollider.
* **Behavior:** This prevents accurate raycast placement on top of it. Furthermore, if a Plank is spawned intersecting existing blocks, the physics engine attempts to resolve the overlapping colliders immediately on `Start()`. This results in a massive, instantaneous application of force, causing the structures to scatter violently.
* **Planned Fix:** Recalculate the bounding box dimensions on the prefab and experiment with Continuous vs. Discrete collision detection to prevent tunneling/overlap on spawn.
