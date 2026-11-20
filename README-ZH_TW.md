[简体中文](README.md) | [English](README-EN.md) | **繁體中文**

<div align="center">

# PClonline

**Minecraft 連線啟動器 —— 一個房間碼，直接進遊戲**

[![Release](https://img.shields.io/github/v/release/ShangFang95/PClonline?style=for-the-badge&logo=github)](https://github.com/ShangFang95/PClonline/releases)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue?style=for-the-badge)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows-0078D4?style=for-the-badge&logo=windows)](https://www.microsoft.com/windows)

</div>

**English summary**: PClonline is a Minecraft launcher built on PCL2-CE. Hosting and inviting friends is reduced to two steps — open a room, share a 5-character code.

PClonline 是基於 **PCL2-CE（Plain Craft Launcher 2 Community Edition）** 二次開發的 Minecraft 啟動器。它把「開服 + 邀請好友」壓縮成兩步：**開房、發碼**——不需要公網 IP、連接埠對應與命令列。

> ⚠️ 本專案為社群驅動的第三方啟動器，與 Mojang Studios、Microsoft 無任何關聯。

## 🎮 連線：一個房間碼就夠了

**① 5 位房間碼，輸入就進**

啟動遊戲並開始連線後，啟動器會給出一枚 5 位房間碼。好友在加入頁輸入這串碼，就能進入同一個世界或伺服器，不用管連接埠、IP 與防火牆。

**② 好友線上，一眼看清**

登入之後，左欄直接顯示好友的線上狀態。把房間碼發給對方，他輸入後就能進你的房間——不需要額外的邀請連結或第三方工具。

**③ 直連優先，延遲更低**

優先嘗試玩家之間的直連通道：網路條件合適時，遊戲資料不繞遠路，延遲更低、頻寬更充足。連不上時會自動降級，盡量讓房間「總能進得去」。

**④ 帳號與好友體系**

支援掃碼登入與帳號密碼登入，帳號 ID 固定 10 位，方便抄給朋友。好友名單保存在雲端，換一台電腦登入也不會丟。

## ✨ 啟動器能力

在連線之外，PClonline 繼承了 PCL2 的完整啟動器功能：

- **實例管理**：多版本、多載入器相互隔離，版本設定互不影響
- **模組與整合包**：安裝、啟停、衝突提示，支援 CurseForge / Modrinth
- **資源下載**：原版、Forge、Fabric、NeoForge、OptiFine 等一鍵安裝，多來源自動回退
- **Java 管理**：自動偵測與選擇 Java，缺少時可引導安裝 Mojang 官方執行環境
- **帳號**：Microsoft 正版登入、離線帳號、多帳號快速切換
- **介面與體驗**：明暗主題、自訂背景與音樂、啟動動畫、崩潰分析

## 📦 關於本倉庫

本倉庫開放的是啟動器的**通用部分**原始碼：

| 目錄 | 內容 |
|---|---|
| `PCL.Core` | 啟動器核心庫：設定、下載、Java、實例、日誌、在地化 |
| `Plain Craft Launcher 2` | WPF 介面、啟動流程、頁面與控制項 |
| `PCL.Core.SourceGenerators` | 編譯期原始碼產生器 |
| `PCL.Core.Test` | 單元測試 |

連線、帳號與自動更新模組**不包含在本倉庫內**，因此本倉庫無法直接編譯出完整發行版，僅供學習、參考與通用部分的二次開發。

## 🚀 下載

- **原始碼快照**：見 [Releases](https://github.com/ShangFang95/PClonline/releases)（僅原始碼封存，不含可執行檔）
- **完整發行版**（含連線模組）：請透過官方發布管道取得

## 🗺️ 路線圖

- [x] 5 位房間碼加入與好友體系
- [x] 直連優先的連線通道
- [x] 實例管理與多載入器支援
- [x] 多來源下載與 Java 自動選擇
- [ ] 持續打磨連線穩定性與啟動體驗

## 🤝 參與貢獻

歡迎提交 Issue 回報問題，或透過 Pull Request 改進通用部分的實作。提交前請先閱讀 [CONTRIBUTING.md](CONTRIBUTING.md)。

安全性問題請勿公開提交，參見 [SECURITY.md](SECURITY.md)。

## 📄 授權與署名

本專案基於 [PCL2-CE](https://github.com/PCL-Community/PCL2-CE) 二次開發，遵循 **Apache-2.0** 授權，詳見 [LICENSE](LICENSE) 與 [NOTICE](NOTICE)。

原專案版權歸 PCL Community 與 龍騰貓躍 所有；本專案的修改部分同樣以 Apache-2.0 發布。
