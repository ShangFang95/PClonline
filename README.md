**简体中文** | [English](README-EN.md) | [繁體中文](README-ZH_TW.md)

<div align="center">

# PClonline

**Minecraft 联机启动器 —— 一个房间码，直接进游戏**

[![Release](https://img.shields.io/github/v/release/ShangFang95/PClonline?style=for-the-badge&logo=github)](https://github.com/ShangFang95/PClonline/releases)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue?style=for-the-badge)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows-0078D4?style=for-the-badge&logo=windows)](https://www.microsoft.com/windows)

</div>

**English summary**: PClonline is a Minecraft launcher built on PCL2-CE. Hosting and inviting friends is reduced to two steps — open a room, share a 5-character code.

PClonline 是基于 **PCL2-CE（Plain Craft Launcher 2 Community Edition）** 二次开发的 Minecraft 启动器。它把「开服 + 邀请好友」压缩成两步：**开房、发码**——不需要公网 IP、端口映射和命令行。

> ⚠️ 本项目为社区驱动的第三方启动器，与 Mojang Studios、Microsoft 无任何关联。

## 🎮 联机：一个房间码就够了

**① 5 位房间码，输入就进**

启动游戏并开始联机后，启动器会给出一枚 5 位房间码。好友在加入页输入这串码，就能进入同一个世界或服务器，不用管端口、IP 和防火墙。

**② 好友在线，一眼看清**

登录之后，左栏直接显示好友的在线状态。把房间码发给对方，他输入后就能进你的房间——不需要额外的邀请链接或第三方工具。

**③ 直连优先，延迟更低**

优先尝试玩家之间的直连通道：网络条件合适时，游戏数据不绕远路，延迟更低、带宽更充足。连不上时会自动降级，尽量让房间「总能进得去」。

**④ 账号与好友体系**

支持扫码登录与账号密码登录，账号 ID 固定 10 位，方便抄给朋友。好友名单保存在云端，换一台电脑登录也不会丢。

## ✨ 启动器能力

在联机之外，PClonline 继承了 PCL2 的完整启动器功能：

- **实例管理**：多版本、多加载器相互隔离，版本设置互不影响
- **模组与整合包**：安装、启停、冲突提示，支持 CurseForge / Modrinth
- **资源下载**：原版、Forge、Fabric、NeoForge、OptiFine 等一键安装，多源自动回退
- **Java 管理**：自动检测与选择 Java，缺失时可引导安装 Mojang 官方运行时
- **账户**：微软正版登录、离线账户、多账户快速切换
- **界面与体验**：明暗主题、自定义背景与音乐、启动动画、崩溃分析

## 📦 关于本仓库

本仓库开放的是启动器的**通用部分**源码：

| 目录 | 内容 |
|---|---|
| `PCL.Core` | 启动器核心库：配置、下载、Java、实例、日志、本地化 |
| `Plain Craft Launcher 2` | WPF 界面、启动流程、页面与控件 |
| `PCL.Core.SourceGenerators` | 编译期源码生成器 |
| `PCL.Core.Test` | 单元测试 |

联机、账号与自动更新模块**不包含在本仓库内**，因此本仓库无法直接编译出完整发行版，仅供学习、参考与通用部分的二次开发。

## 🚀 下载

- **源码快照**：见 [Releases](https://github.com/ShangFang95/PClonline/releases)（仅源码归档，不含可执行文件）
- **完整发行版**（含联机模块）：请通过官方发布渠道获取

## 🗺️ 路线图

- [x] 5 位房间码加入与好友体系
- [x] 直连优先的联机通道
- [x] 实例管理与多加载器支持
- [x] 多源下载与 Java 自动选择
- [ ] 持续打磨联机稳定性与启动体验

## 🤝 参与贡献

欢迎提交 Issue 反馈问题，或通过 Pull Request 改进通用部分的实现。提交前请先阅读 [CONTRIBUTING.md](CONTRIBUTING.md)。

安全问题请勿公开提交，参见 [SECURITY.md](SECURITY.md)。

## 📄 许可证与署名

本项目基于 [PCL2-CE](https://github.com/PCL-Community/PCL2-CE) 二次开发，遵循 **Apache-2.0** 许可证，详见 [LICENSE](LICENSE) 与 [NOTICE](NOTICE)。

原项目版权归 PCL Community 与 龙腾猫跃 所有；本项目的修改部分同样以 Apache-2.0 发布。
