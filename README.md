**简体中文** | [English](README-EN.md) | [繁體中文](README-ZH_TW.md)

<div align="center">

# PClonline

**基于 PCL2-CE 的 Minecraft 启动器**

实例管理 · 模组整合 · 多源下载 · 干净利落的启动体验

[![License](https://img.shields.io/badge/license-Apache--2.0-blue?style=for-the-badge)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows-0078D4?style=for-the-badge&logo=windows)](https://www.microsoft.com/windows)
[![Based on](https://img.shields.io/badge/based%20on-PCL2--CE-2ea44f?style=for-the-badge)](https://github.com/PCL-Community/PCL2-CE)

</div>

**English summary**: A Minecraft launcher built on PCL2-CE, focused on instance management, mod handling, multi-source downloads and a clean startup experience.

PClonline 是基于 **PCL2-CE（Plain Craft Launcher 2 Community Edition）** 二次开发的 Minecraft 启动器，沿用 PCL2 的界面与操作习惯，并围绕实例管理、下载与启动流程做了定制与打磨。

> ⚠️ 本项目为社区驱动的第三方启动器，与 Mojang Studios、Microsoft 无任何关联。

## 📦 关于本仓库

本仓库开放的是启动器的**通用部分**源码：

| 目录 | 内容 |
|---|---|
| `PCL.Core` | 启动器核心库：配置、下载、Java、实例、日志、本地化 |
| `Plain Craft Launcher 2` | WPF 界面、启动流程、页面与控件 |
| `PCL.Core.SourceGenerators` | 编译期源码生成器 |
| `PCL.Core.Test` | 单元测试 |

联机、账号与自动更新模块**不包含在本仓库内**，因此本仓库无法直接编译出完整发行版，仅供学习、参考与通用部分的二次开发。完整发行版请从官方发布渠道获取。

## ✨ 功能特性

- **实例管理**：多版本、多加载器相互隔离，版本设置互不影响
- **模组与整合包**：安装、启停、冲突提示，支持 CurseForge / Modrinth
- **资源下载**：原版、Forge、Fabric、NeoForge、OptiFine 等一键安装，多源自动回退
- **Java 管理**：自动检测与选择 Java，缺失时可引导安装 Mojang 官方运行时
- **账户**：微软正版登录、离线账户、多账户快速切换
- **界面与体验**：明暗主题、自定义背景与音乐、启动动画、崩溃分析

## 🚀 快速上手

1. 从官方发布页下载压缩包并解压（自包含版开箱即用，无需安装 .NET）
2. 启动 `Plain Craft Launcher 2.exe`
3. 在「版本列表」选择或安装游戏版本，点击启动即可

## 🛠️ 关于构建

仓库中的通用部分可以独立编译为类库与界面程序；由于联机、账号、更新模块未开源，完整发行版的构建需要在私有环境中补齐这些模块。欢迎基于本仓库的通用能力做自己的启动器。

## 🗺️ 路线图

- [x] 实例管理与多加载器支持
- [x] 模组 / 整合包安装与更新
- [x] 多源下载与 Java 自动选择
- [ ] 持续打磨启动稳定性与交互细节

## 🤝 参与贡献

欢迎提交 Issue 反馈问题，或通过 Pull Request 改进通用部分的实现。提交前请先阅读 [CONTRIBUTING.md](CONTRIBUTING.md)。

安全问题请勿公开提交，参见 [SECURITY.md](SECURITY.md)。

## 📄 许可证与署名

本项目基于 [PCL2-CE](https://github.com/PCL-Community/PCL2-CE) 二次开发，遵循 **Apache-2.0** 许可证，详见 [LICENSE](LICENSE) 与 [NOTICE](NOTICE)。

原项目版权归 PCL Community 与 龙腾猫跃 所有；本项目的修改部分同样以 Apache-2.0 发布。
