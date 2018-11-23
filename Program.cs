using System;
using System.Windows.Forms;

namespace PatchMaster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // AppDomain.CurrentDomain.AssemblyResolve += (sender, arg) => { if (arg.Name.Contains("WqlQueryEngine")) return Assembly.Load(Properties.Resources.AdminUI_WqlQueryEngine); return null; };

                // AppDomain.CurrentDomain.AssemblyResolve += (sender, arg) => { if (arg.Name.Contains("ManagementProvider")) return Assembly.Load(Properties.Resources.Microsoft_ConfigurationManagement_ManagementProvider); return null; };
            }
            catch (Exception)
            {
                // We're going nowhere if the DLL did not load
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Form1());

            Application.Run(new Splash());

            //if (globalObjects.GlobalClass.SilentRunning)
            //{
            //    Form1 f = new Form1();
            //    Application.Run();                
            //}
            //else
            //{
            //    Application.Run(new Form1());
            //}
        }
    }
}
