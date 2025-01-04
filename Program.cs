using SysLogit.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace SysLogit
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize Unity container
            var container = new UnityContainer();
            UnityConfig.RegisterComponents();

            // Resolve MainForm with dependencies
            var mainForm = container.Resolve<Main>();

            Application.Run(mainForm);
        }
    }
}
