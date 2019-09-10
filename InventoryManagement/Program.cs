using System;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace InventoryManagement
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutoUpdater.Start("https://raw.githubusercontent.com/SteffenCarlsen/Simple-Inventory-Management-Autoupdate-XML-storage/master/AutoUpdater.xml");
            Application.Run(new InventoryForm());
        }
    }
}