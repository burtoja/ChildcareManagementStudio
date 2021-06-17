using ChildcareManagementStudio.View;
using Squirrel;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/jburton6/ChildcareManagementStudio"))
            {
                await mgr.Result.UpdateApp();
            }
        }
    }
}