# 🚀 AR Shuttle IMU Control App

This Unity-based mobile AR application places a **world-locked 3D space shuttle** in your real environment and allows you to control its orientation using your phone’s **accelerometer (IMU)**.

## 🎯 Features
- AR plane detection for object placement
- Real-time tilt-based shuttle control using IMU
- Reset button for orientation
- Optional toggle IMU ON/OFF

## 🛠 Tech Stack
- Unity 2021.3.45f1 (LTS)
- AR Foundation 5.1.3
- ARCore XR Plugin (Android)
- C# Scripting

## 📱 Platform Setup

### ✅ Android
1. Enable Developer Mode + USB Debugging
2. In Unity: 
   - Platform: Android
   - Scripting Backend: IL2CPP
   - Architecture: ARM64
   - Graphics: OpenGLES3
3. Build APK and install on device

## 🎮 Controls
- **Tilt** phone = rotate shuttle (pitch/roll)
- **Tap** surface = place shuttle
- **Reset button** = reset shuttle rotation

## 🧪 Known Issues
- Jittery rotation on some devices
- Requires real device (no emulators)


## 👤 Author
- **Name**: Alekhya vaddineni
- **Email**: vaddinea@mail.gvsu.edu 
- **Target Device**: Android (Galaxy A15 5G.)

