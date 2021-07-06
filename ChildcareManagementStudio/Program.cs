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
            var runapp = new System.Threading.ThreadStart(async () =>
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());

                using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/jburton6/ChildcareManagementStudio"))
                {
                    try
                    {
                        await mgr.Result.UpdateApp();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("No update necessary since no previous version installed./nDetails: " + ex.Message);
                    }
                }
                
            });

            var thread = new System.Threading.Thread(runapp);
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}