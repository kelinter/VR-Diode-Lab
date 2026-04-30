# VR Electronics Learning Lab (Unity XR)

An interactive virtual reality environment designed to introduce foundational electronics concepts through hands-on exploration. Built using Unity and the XR Interaction Toolkit, this project allows users to engage with electronic components in an immersive lab setting.

---

## Overview

This project recreates a basic electronics lab in VR where users can:

* Pick up and inspect electronic components
* View educational UI panels attached to each object
* Hear audio explanations during interaction
* Navigate the environment using teleportation

The goal is to provide an intuitive introduction to circuits through interaction rather than memorization.

---

## Demo

*(Add videos here)*

---

## Assets

The following 3D models were imported from Sketchfab and integrated into the project.

### Core Components

* **Electronic Components Pack**
  [https://sketchfab.com/3d-models/cc0-set-of-electronic-components-f4cb777b4ea3490587008e24b61bcf75](https://sketchfab.com/3d-models/cc0-set-of-electronic-components-f4cb777b4ea3490587008e24b61bcf75)

* **AA Battery**
  [https://sketchfab.com/3d-models/aa-battery-2a3d0e9dc5714963af14ce11fdcb7fbc](https://sketchfab.com/3d-models/aa-battery-2a3d0e9dc5714963af14ce11fdcb7fbc)

* **Breadboard**
  [https://sketchfab.com/3d-models/arduino-breadboard-low-poly-497ee275a25e4166b98c7be3105b4ad9](https://sketchfab.com/3d-models/arduino-breadboard-low-poly-497ee275a25e4166b98c7be3105b4ad9)

* **Buzzer Module**
  [https://sketchfab.com/3d-models/arduino-module-buzzer-e5890a29eaec43ba93de8a5100275632](https://sketchfab.com/3d-models/arduino-module-buzzer-e5890a29eaec43ba93de8a5100275632)

* **Integrated Circuit (IC)**
  [https://sketchfab.com/3d-models/integrated-circuit-ic-7a371e15688741bf846c6c7b68000048](https://sketchfab.com/3d-models/integrated-circuit-ic-7a371e15688741bf846c6c7b68000048)

* **Microcontroller Module**
  [https://sketchfab.com/3d-models/komponen-elektronika-microcontrollers-bb4c7f974cef44f8b1db21afb0cce78d](https://sketchfab.com/3d-models/komponen-elektronika-microcontrollers-bb4c7f974cef44f8b1db21afb0cce78d)

---

### Sensors and Interfaces

* **DHT11 Temperature & Humidity Sensor**
  [https://sketchfab.com/3d-models/modulo-sensor-de-umidade-e-temperatura-dht11-4b7c7f7436ad46cc97a837b7503b5901](https://sketchfab.com/3d-models/modulo-sensor-de-umidade-e-temperatura-dht11-4b7c7f7436ad46cc97a837b7503b5901)

* **OLED Display (SSD1306)**
  [https://sketchfab.com/3d-models/ssd1306-oled-screen-128x32-i2c-version-7c6f63e7a62b4b2a895b52778426a7ed](https://sketchfab.com/3d-models/ssd1306-oled-screen-128x32-i2c-version-7c6f63e7a62b4b2a895b52778426a7ed)

---

### Control Components

* **Potentiometer**
  [https://sketchfab.com/3d-models/potentiometer-5a998eb2ef8f4e7c993759e8887c8919](https://sketchfab.com/3d-models/potentiometer-5a998eb2ef8f4e7c993759e8887c8919)

* **Push Button**
  [https://sketchfab.com/3d-models/two-pin-tactile-push-button-caa7bb6a632249daa4032eb7f7eaa1e5](https://sketchfab.com/3d-models/two-pin-tactile-push-button-caa7bb6a632249daa4032eb7f7eaa1e5)

---

### Discrete Components

* **Transistor**
  [https://sketchfab.com/3d-models/transistor-c7e502ecf6c645ffa93567e15003081c](https://sketchfab.com/3d-models/transistor-c7e502ecf6c645ffa93567e15003081c)

---

### Environment Assets

* **Virtual Studio Environment**
  [https://sketchfab.com/3d-models/virtual-studio-b8cb1e447f9b420592fdab52920bb6f0](https://sketchfab.com/3d-models/virtual-studio-b8cb1e447f9b420592fdab52920bb6f0)

* **School Table**
  [https://sketchfab.com/3d-models/simple-school-table-b53067a498f1478a989881bcc7715696](https://sketchfab.com/3d-models/simple-school-table-b53067a498f1478a989881bcc7715696)

---

All assets are used under their respective licenses. Many are CC0/public domain, but each should be verified before redistribution.

---

## Features

* XR grab interaction for components
* Floating and rotating object presentation
* Audio playback triggered on grab
* UI panels displaying component information
* Teleportation-based locomotion
* Prefab-based component system for reuse

---

## Educational Design

Each component is paired with a simple explanation to introduce core concepts:

* Resistor: limits current flow
* Diode / LED: allows current in one direction
* Capacitor: stores electrical energy
* Transistor: functions as a switch or amplifier
* Battery: provides power to a circuit
* Button: controls current flow

The experience emphasizes interaction and exploration.

---

## Tech Stack

* Unity (URP)
* XR Interaction Toolkit
* C#
* Oculus Quest 3

---

## Setup

1. Clone the repository
2. Open in Unity (6000.2 recommended)
3. Enable XR Plugin Management
4. Connect Quest device via USB-C
5. Build and run to device

---

## Project Structure

```
Assets/
  Imports/
  Prefabs/
  Scripts/
  Scenes/
  XR/
```

---

## System Design

```
User (VR Player)
  → XR Interaction Toolkit
    → Component Prefab
        → Grab Interaction
        → Audio Script
        → UI Panel
        → Visual Behavior
```

---

## Future Work

* Add circuit-building functionality (connecting components)
* Introduce guided lessons or challenges
* Expand component library
* Improve visual consistency and lighting
* Add progression or learning flow

---

## Development Notes

* Imported assets required scaling and material adjustments
* Collider and rigidbody tuning improved interaction stability
* XR teleportation required debugging across controllers
* UI placement was adjusted for readability in VR

---

## Author

Kelly Interiano,
Bucknell University – Computer Engineering

---

## License

This project uses third-party assets from Sketchfab. Refer to each asset’s license for usage rights.


