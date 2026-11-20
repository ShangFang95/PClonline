using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Win32;
using PCL.Core.App.IoC;
using PCL.Core.App.Localization;
using PCL.Core.UI;
using PCL.Core.Utils;

namespace PCL.Core.App.Tools;

[LifecycleScope("dependency-check", "依赖检查")]
[LifecycleService(LifecycleState.Running)]
public sealed partial class DependencyCheckService
{
    [LifecycleStart]
    private static async Task _StartAsync()
    {
        Context.Info(Lang.Text("Tools.Test.Dependency.Checking"));

        if (RuntimeInformation.OSArchitecture.Equals(Architecture.Arm64))
            await _CheckAndAskAsync("Microsoft.D3DMappingLayers", "OpenGL 兼容包", "9nqpsl29bfff")
                .ConfigureAwait(false);

        await _CheckAndAskAsync("Microsoft.WebpImageExtension", "WebP 组件包", "9pg2dk419drg")
            .ConfigureAwait(false);
    }

    private static async Task _CheckAndAskAsync(string packageId, string packageName, string storeId)
    {
        if (!await _CheckPackageAsync(packageId))
        {
            Context.Info($"检测到依赖缺失 (package-id = {packageId})");
            var selection = MsgBoxWrapper.Show(
                Lang.Text("Tools.Test.Dependency.MissingMessage", packageName),
                buttons: [Lang.Text("Common.Action.Confirm"), Lang.Text("Tools.Test.Dependency.Later")]);
            if (selection == 1) _LaunchMsStore(storeId);
        }
    }

    private static void _LaunchMsStore(string id)
    {
        Context.Info($"正在打开微软应用商店 (id = {id})");
        var psi = new ProcessStartInfo()
        {
            FileName = $"ms-windows-store://pdp?launch=true&productid={id}&mode=full",
            UseShellExecute = true
        };
        using var ps = new Process() { StartInfo = psi };
        ps.Start();
    }

    /// <summary>
    /// 查注册表判断 Appx 包是否已安装。
    /// 不使用 powershell.exe：杀软会把「未签名进程执行 PowerShell」判成可疑脚本并拦截，
    /// 而两条注册表路径能覆盖 Get-AppxPackage 的全部可见范围（含机器级安装）。
    /// </summary>
    private static Task<bool> _CheckPackageAsync(string id)
    {
        // ① 当前用户已注册的包（Get-AppxPackage 的默认数据源）
        var found = _RegistryHasPackage(RegistryHive.CurrentUser,
            @"Software\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppModel\Repository\Packages", id);
        // ② 机器级安装（Get-AppxPackage 在多用户机器上同样会漏，这里显式补上）
        if (!found)
            found = _RegistryHasPackage(RegistryHive.LocalMachine,
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Appx\AppxAllUserStore\Applications", id);
        return Task.FromResult(found);
    }

    private static bool _RegistryHasPackage(RegistryHive hive, string path, string id)
    {
        try
        {
            using var baseKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default);
            using var key = baseKey.OpenSubKey(path);
            if (key is null) return false;
            foreach (var name in key.GetSubKeyNames())
            {
                if (name.Contains(id, StringComparison.OrdinalIgnoreCase)) return true;
            }
        }
        catch
        {
            // 注册表不可读时按“已安装”处理：宁可漏提示，也不要每次启动都弹安装框
            return true;
        }
        return false;
    }
}
