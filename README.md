# Installation

To run the project, you need to:  
1. Install Unity 2022.3.38f1 (you can download it [here](https://unity.com/pt/releases/editor/archive))  
2. Clone the project from the cloud to your local directory  
3. Open Unity Hub  
4. Add the project to Unity Hub (after fully cloning the project)  
5. Open the project  
6. Go to the folder: "Assets > _Structure > _Scenes > Gameplay"  
7. Press PLAY to run the project  

# How to Play  

https://github.com/user-attachments/assets/d65f085c-6b1e-46a4-ad46-891896eb1755  

## Headset  
- WASD - Move character  
- Mouse - Rotate camera  
- T - Switch between XR controller (left) and headset  
- Y - Switch between XR controller (right) and headset  

## XR Controller (Left)  
- WASD - Move character  
- Move Mouse - Rotate XR controller (left)  
- Mouse (left click) - Interact  
- T - Switch between XR controller (left) and headset  
- Y - Switch between XR controller (right) and headset  

## XR Controller (Right)  
- IJKL - Move character  
- Move Mouse - Rotate XR controller (right)  
- T - Switch between XR controller (left) and headset  
- Y - Switch between XR controller (right) and headset  

# Practices Used  

- The event-based concept was used, ensuring that scripts and functions work independently. This makes maintenance, adaptation, and scalability easier.  
- Canvas World Space was used for each circuit component.  
- Logic was reused among circuit components to avoid redundant code repetition.  

# Implementation Wish  

- Creation of multiple "sockets" in a single component, allowing cable branching, power sources, etc., to enable complex circuits. (Although there are multiple "sockets" and a base logic for creating infinite components, there is no logic to manage them.)  

# Challenges  

- The VR system was implemented, but it was also the first contact and experience with VR, which took more time to understand how to handle the plugin. Additionally, there was no prior knowledge of the correct VR plugin for the project, leading to a longer analysis.  
- Uncertainty about whether the project works perfectly for VR, as there is no hardware to test it in a "build" version or sufficient technical knowledge in this area (VR) to confirm the stable functionality of the plugin used.  
- It was not possible to disable certain interaction buttons from the XR Toolkit plugin, causing unnecessary keyboard inputs during project execution.

# Assets usados

[Magic Effects FREE](https://assetstore.unity.com/packages/vfx/particles/spells/magic-effects-free-247933)

[TOOLKIT vol.2 Sound Pack Bundle](https://assetstore.unity.com/packages/audio/sound-fx/toolkit-vol-2-sound-pack-bundle-198011)

- XR Interaction Toolkit (Package Manager - Unity Registry)
- XR Core Utilities (Package Manager - Unity Registry)
- XR Legacy Input Helpers (Package Manager - Unity Registry)
- XR Plugin Management (Package Manager - Unity Registry)
- Text Mesh Pro (TMP) (Package Manager - Unity Registry)
