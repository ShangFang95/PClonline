[简体中文](README.md) | [English](README-EN.md) | **繁體中文**

<div align="center">

# PClonline

**基於 PCL2-CE 的 Minecraft 啟動器**

實例管理 · 模組整合 · 多來源下載 · 乾淨俐落的啟動體驗

[![License](https://img.shields.io/badge/license-Apache--2.0-blue?style=for-the-badge)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows-0078D4?style=for-the-badge&logo=windows)](https://www.microsoft.com/windows)
[![Based on](https://img.shields.io/badge/based%20on-PCL2--CE-2ea44f?style=for-the-badge)](https://github.com/PCL-Community/PCL2-CE)

</div>

**English summary**: A Minecraft launcher built on PCL2-CE, focused on instance management, mod handling, multi-source downloads and a clean startup experience.

PClonline 是基於 **PCL2-CE（Plain Craft Launcher 2 Community Edition）** 二次開發的 Minecraft 啟動器，沿用 PCL2 的介面與操作習慣，並針對實例管理、下載與啟動流程做了客製化與打磨。

> ⚠️ 本專案為社群驅動的第三方啟動器，與 Mojang Studios、Microsoft 無任何關聯。

## 📦 關於本倉庫

本倉庫開放的是啟動器的**通用部分**原始碼：

| 目錄 | 內容 |
|---|---|
| `PCL.Core` | 啟動器核心庫：設定、下載、Java、實例、日誌、在地化 |
| `Plain Craft Launcher 2` | WPF 介面、啟動流程、頁面與控制項 |
| `PCL.Core.SourceGenerators` | 編譯期原始碼產生器 |
| `PCL.Core.Test` | 單元測試 |

連線、帳號與自動更新模組**不包含在本倉庫內**，因此本倉庫無法直接編譯出完整發行版，僅供學習、參考與通用部分的二次開發。完整發行版請從官方發布管道取得。

## ✨ 功能特性

- **實例管理**：多版本、多載入器相互隔離，版本設定互不影響
- **模組與整合包**：安裝、啟停、衝突提示，支援 CurseForge / Modrinth
- **資源下載**：原版、Forge、Fabric、NeoForge、OptiFine 等一鍵安裝，多來源自動回退
- **Java 管理**：自動偵測與選擇 Java，缺少時可引導安裝 Mojang 官方執行環境
- **帳號**：Microsoft 正版登入、離線帳號、多帳號快速切換
- **介面與體驗**：明暗主題、自訂背景與音樂、啟動動畫、崩潰分析

## 🚀 快速上手

1. 從官方發布頁下載壓縮檔並解壓（自包含版開箱即用，無需安裝 .NET）
2. 啟動 `Plain Craft Launcher 2.exe`
3. 在「版本列表」選擇或安裝遊戲版本，點擊啟動即可

## 🛠️ 關於建置

倉庫中的通用部分可以獨立編譯為類別庫與介面程式；由於連線、帳號、更新模組未開源，完整發行版的建置需要在私有環境中補齊這些模組。歡迎基於本倉庫的通用能力打造自己的啟動器。

## 🗺️ 路線圖

- [x] 實例管理與多載入器支援
- [x] 模組 / 整合包安裝與更新
- [x] 多來源下載與 Java 自動選擇
- [ ] 持續打磨啟動穩定性與互動細節

## 🤝 參與貢獻

歡迎提交 Issue 回報問題，或透過 Pull Request 改進通用部分的實作。提交前請先閱讀 [CONTRIBUTING.md](CONTRIBUTING.md)。

安全性問題請勿公開提交，參見 [SECURITY.md](SECURITY.md)。

## 📄 授權與署名

本專案基於 [PCL2-CE](https://github.com/PCL-Community/PCL2-CE) 二次開發，遵循 **Apache-2.0** 授權，詳見 [LICENSE](LICENSE) 與 [NOTICE](NOTICE)。

原專案版權歸 PCL Community 與 龍騰貓躍 所有；本專案的修改部分同樣以 Apache-2.0 發布。
