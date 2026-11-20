[简体中文](README.md) | **English** | [繁體中文](README-ZH_TW.md)

<div align="center">

# PClonline

**A Minecraft launcher built on PCL2-CE**

Instance management · Mods & modpacks · Multi-source downloads · A clean start experience

[![License](https://img.shields.io/badge/license-Apache--2.0-blue?style=for-the-badge)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows-0078D4?style=for-the-badge&logo=windows)](https://www.microsoft.com/windows)
[![Based on](https://img.shields.io/badge/based%20on-PCL2--CE-2ea44f?style=for-the-badge)](https://github.com/PCL-Community/PCL2-CE)

</div>

PClonline is a Minecraft launcher built on top of **PCL2-CE (Plain Craft Launcher 2 Community Edition)**. It keeps the familiar PCL2 workflow while refining instance management, downloads and the launch experience.

> ⚠️ This is a community-driven third-party launcher and is not affiliated with Mojang Studios or Microsoft.

## 📦 About this repository

This repository contains the **general-purpose** parts of the launcher:

| Path | Contents |
|---|---|
| `PCL.Core` | Core library: configuration, downloads, Java, instances, logging, localization |
| `Plain Craft Launcher 2` | WPF UI, launch pipeline, pages and controls |
| `PCL.Core.SourceGenerators` | Compile-time source generators |
| `PCL.Core.Test` | Unit tests |

Networking, account and auto-update modules are **not** included here. As a result, this repository cannot be built into a complete release — it is intended for learning, reference and downstream development of the general parts. Please obtain the full release from the official channel.

## ✨ Features

- **Instance management** — isolated versions and loaders, independent per-instance settings
- **Mods & modpacks** — install, toggle, conflict hints, CurseForge / Modrinth support
- **Downloads** — vanilla, Forge, Fabric, NeoForge, OptiFine and more, with automatic source fallback
- **Java management** — automatic detection and selection, guided install of Mojang runtimes
- **Accounts** — Microsoft login, offline accounts, quick switching
- **Experience** — light/dark themes, custom backgrounds and music, launch animations, crash analysis

## 🚀 Quick start

1. Download the archive from the official release page and extract it (the self-contained build requires no .NET installation)
2. Run `Plain Craft Launcher 2.exe`
3. Pick or install a game version from the version list and hit launch

## 🛠️ Building

The general parts can be compiled independently as libraries and a UI application. Because networking, account and update modules are closed-source, assembling a full release requires adding those modules in a private environment. You are welcome to build your own launcher on top of the general capabilities here.

## 🗺️ Roadmap

- [x] Instance management and multi-loader support
- [x] Mod / modpack installation and updates
- [x] Multi-source downloads and automatic Java selection
- [ ] Ongoing polish of launch stability and interaction details

## 🤝 Contributing

Issues and pull requests are welcome. Please read [CONTRIBUTING.md](CONTRIBUTING.md) first.

For security issues, do not open a public issue — see [SECURITY.md](SECURITY.md).

## 📄 License & credits

Built on [PCL2-CE](https://github.com/PCL-Community/PCL2-CE) and licensed under **Apache-2.0**; see [LICENSE](LICENSE) and [NOTICE](NOTICE).

Original copyright belongs to PCL Community and 龙腾猫跃. Modifications in this project are released under the same license.
