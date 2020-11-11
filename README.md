# Loupedeck Notepad Plugin

Hello there 👋 and welcome!

This repo contains a very simple custom Plugin developed with the Loupedeck SDK and is tested on Windows against a Loupedeck LIVE.

The main reason for this repo was to gain better understanding of the development process with writing custom plugins for the Loupedeck device. Also during initial dev and testing, I ran into some interesting issues that I had to resolve to get the plugin fully functioning.

This sample plugin showcases the following interesting tidbits;

- Defines a very basic virtual button command and rotation action.
- Attaches to the Notepad.exe process on Windows, doesn't do anything on macOS.
- Interesting hack to work around plugin licensing as discovered via Reflection/HTTP traffic interception.
- Copies binaries after build directly into Loupedeck folder, and restarts the Loupedeck process.
- Enables very simple run/debug loop as explained on the Loupedeck Plugin Development Guide.

All in all, this simple project gave me enough insight to start developing an actual plugin.
