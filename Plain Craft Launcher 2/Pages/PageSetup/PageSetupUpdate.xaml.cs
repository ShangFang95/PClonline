using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PCL;

public partial class PageSetupUpdate
{
    private PclUpdater.CheckResult? _last;

    public PageSetupUpdate()
    {
        InitializeComponent();
        Loaded += (_, _) => Init();
    }

    private void Init()
    {
        TextCurrentVersion.Text = "PClonline " + PclUpdater.LocalVersion;
        if (!PclUpdater.Available)
        {
            TextCurrentDesc.Text = "缺少更新器 PClonlineUpdater.exe，无法检查更新";
            BtnCheckAgain.IsEnabled = false;
            return;
        }

        _ = CheckAsync();
    }

    private async Task CheckAsync()
    {
        BtnCheckAgain.IsEnabled = false;
        BtnChangelog.Visibility = Visibility.Collapsed;
        TextCurrentDesc.Text = "正在检查更新…";

        _last = await PclUpdater.CheckAsync();
        BtnCheckAgain.IsEnabled = true;
        ShowResult(_last);
    }

    private void ShowResult(PclUpdater.CheckResult result)
    {
        if (!result.Ok)
        {
            TextCurrentDesc.Text = result.Message;
            return;
        }

        if (!result.HasUpdate)
        {
            TextCurrentDesc.Text = "已是最新版本 " + result.RemoteVersion;
            return;
        }

        var sizeMb = result.DownloadBytes / 1048576.0;
        TextCurrentDesc.Text = $"发现新版本 {result.RemoteVersion}：本次只需下载约 {sizeMb:0.#} MB，完成后自动重启。";
        BtnChangelog.Text = "立即更新并重启";
        BtnChangelog.Visibility = Visibility.Visible;
    }

    private void ApplyAndRestart()
    {
        if (_last is not { HasUpdate: true }) return;
        var sizeMb = _last.DownloadBytes / 1048576.0;
        if (ModMain.MyMsgBox($"将下载约 {sizeMb:0.#} MB 并重启启动器以完成更新。", "更新", "开始", "取消") == 2) return;

        if (!PclUpdater.StartApply(out var error))
        {
            HintService.Hint("无法启动更新器：" + error, HintType.Error);
            return;
        }

        ModMain.frmMain.EndProgram(false, true);
    }

    private void BtnChangelog_Click(object sender, MouseButtonEventArgs e) => ApplyAndRestart();

    private void BtnCheckAgain_OnClick(object sender, MouseButtonEventArgs e) => _ = CheckAsync();
}
