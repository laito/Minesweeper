using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Minesweeper
{
    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Game());
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            DatabaseManager db = DatabaseManagerFactory.getDatabaseManager("txt");
            db.closeDB();
        }
    }
}
