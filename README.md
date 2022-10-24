# MultiDisplayHoloplay

## Requirements

Tested on Unity version `2021.3.6f1`

Use the latest version of `Holoplay`

## How to use

- Add a `DisplayManager` to your scene.
- Add a `DisplayHelper` to the components you want to seperate into different displays (UserInterface, Camera, Holoplay).
- Add the `DisplayHelper` to the `ExternalDisplays` field in the `DisplayManager` and assign the display number you want.
- Build and run.

## Known Issues

- Sometimes the displays are reversed (Holographic display doesn't appear on Looking Glass) just swap the display numbers around in the `DisplayManager` to fix this issue.