using System;
using System.Windows.Forms;

namespace CPS_5RH;

internal static class Program
{
    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    private static void Main()
    {
        if (Environment.OSVersion.Version.Major != 5)
        {
            Application.EnableVisualStyles();
        }
        Application.SetCompatibleTextRenderingDefault(defaultValue: false);
        Settings.Load();
        Application.Run(new FormMain());
    }
}
