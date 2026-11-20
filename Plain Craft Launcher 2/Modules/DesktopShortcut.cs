using System.IO;
using System.Runtime.InteropServices;

namespace PCL;

/// <summary>
/// 首次打开启动器时在桌面创建一个快捷方式（只尝试一次，成功或已存在都会留下标记）。
/// </summary>
internal static class DesktopShortcut
{
    private const string ShortcutName = "PClonline.lnk";

    private static string FlagPath => Path.Combine(ModBase.exePath, "PCL", "desktop-shortcut.ok");

    public static void EnsureOnce()
    {
        try
        {
            if (File.Exists(FlagPath)) return;
            var target = Environment.ProcessPath;
            if (string.IsNullOrEmpty(target) || !File.Exists(target)) return;
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (string.IsNullOrEmpty(desktop)) return;

            var lnk = Path.Combine(desktop, ShortcutName);
            if (File.Exists(lnk))
            {
                // 玩家自己已经有同名快捷方式：不覆盖，只记标记。
                MarkDone();
                return;
            }

            if (!Create(lnk, target)) return;
            MarkDone();
            HintService.Hint("已在桌面创建 PClonline 快捷方式", HintType.Success);
        }
        catch (Exception ex)
        {
            ModBase.Log(ex, "创建桌面快捷方式失败（忽略）", ModBase.LogLevel.Debug);
        }
    }

    private static void MarkDone()
    {
        try
        {
            var dir = Path.GetDirectoryName(FlagPath);
            if (!string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);
            File.WriteAllText(FlagPath, DateTimeOffset.UtcNow.ToString("O"));
        }
        catch
        {
            // 标记写不进去就下次再试，不影响启动
        }
    }

    private static bool Create(string lnk, string target)
    {
        var type = Type.GetTypeFromProgID("WScript.Shell");
        if (type is null) return false;
        object? shell = null;
        try
        {
            shell = Activator.CreateInstance(type);
            if (shell is null) return false;
            dynamic wsh = shell;
            dynamic shortcut = wsh.CreateShortcut(lnk);
            shortcut.TargetPath = target;
            shortcut.WorkingDirectory = Path.GetDirectoryName(target) ?? ModBase.exePath;
            shortcut.IconLocation = target + ",0";
            shortcut.Description = "PClonline";
            shortcut.WindowStyle = 1;
            shortcut.Save();
            return File.Exists(lnk);
        }
        finally
        {
            if (shell is not null && Marshal.IsComObject(shell)) Marshal.FinalReleaseComObject(shell);
        }
    }
}
