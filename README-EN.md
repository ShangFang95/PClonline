[简体中文](README.md) | **English** | [繁體中文](README-ZH_TW.md)

<div align="center">

# PClonline

**A Minecraft multiplayer launcher — one room code, straight into the game**

[![Release](https://img.shields.io/github/v/release/ShangFang95/PClonline?style=for-the-badge&logo=github)](https://github.com/ShangFang95/PClonline/releases)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue?style=for-the-badge)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows-0078D4?style=for-the-badge&logo=windows)](https://www.microsoft.com/windows)

</div>

PClonline is a Minecraft launcher built on **PCL2-CE (Plain Craft Launcher 2 Community Edition)**. It reduces hosting and inviting friends to two steps — **open a room, share a code** — with no public IP, port forwarding or command line involved.

> ⚠️ This is a community-driven third-party launcher and is not affiliated with Mojang Studios or Microsoft.

## 🎮 Multiplayer: one room code is all it takes

**① A 5-character room code**

After you start the game and open a room, the launcher gives you a 5-character code. A friend types it into the join page and lands in the same world — no ports, no IPs, no firewall setup.

**② Friends online at a glance**

Once signed in, the left panel shows which friends are online. Send them the room code and they can join your room directly, without extra invite links or third-party tools.

**③ Direct connections first**

The launcher tries a direct player-to-player path first. When the network allows it, game traffic takes the short route for lower latency and more bandwidth, with automatic fallback so the room stays reachable.

**④ Accounts and friends**

Sign in with a QR scan or ID + password. Account IDs are fixed at 10 digits, easy to share. Your friend list lives in the cloud, so switching computers keeps everything.

## ✨ Launcher features

Beyond multiplayer, PClonline keeps the full PCL2 launcher toolbox:

- **Instances** — isolated versions and loaders with independent settings
- **Mods & modpacks** — install, toggle, conflict hints, CurseForge / Modrinth support
- **Downloads** — vanilla, Forge, Fabric, NeoForge, OptiFine and more, with automatic source fallback
- **Java management** — automatic detection and selection, guided install of Mojang runtimes
- **Accounts** — Microsoft login, offline accounts, quick switching
- **Experience** — light/dark themes, custom backgrounds and music, launch animations, crash analysis

## 📦 About this repository

This repository contains the **general-purpose** parts of the launcher:

| Path | Contents |
|---|---|
| `PCL.Core` | Core library: configuration, downloads, Java, instances, logging, localization |
| `Plain Craft Launcher 2` | WPF UI, launch pipeline, pages and controls |
| `PCL.Core.SourceGenerators` | Compile-time source generators |
| `PCL.Core.Test` | Unit tests |

Networking, account and auto-update modules are **not** included here, so this repository cannot be built into a complete release. It is intended for learning, reference and downstream development of the general parts.

## 🚀 Download

- **Source snapshot** — see [Releases](https://github.com/ShangFang95/PClonline/releases) (source archives only, no executables)
- **Full release** (including multiplayer) — available through the official channel

## 🗺️ Roadmap

- [x] 5-character room code and friend system
- [x] Direct-connection-first multiplayer
- [x] Instance management and multi-loader support
- [x] Multi-source downloads and automatic Java selection
- [ ] Ongoing polish of multiplayer stability and launch experience

## 🤝 Contributing

Issues and pull requests are welcome. Please read [CONTRIBUTING.md](CONTRIBUTING.md) first.

For security issues, do not open a public issue — see [SECURITY.md](SECURITY.md).

## 📄 License & credits

Built on [PCL2-CE](https://github.com/PCL-Community/PCL2-CE) and licensed under **Apache-2.0**; see [LICENSE](LICENSE) and [NOTICE](NOTICE).

Original copyright belongs to PCL Community and 龙腾猫跃. Modifications in this project are released under the same license.
