using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TripsService.AppFiles.Database;

namespace TripsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            SoundManager player = (SoundManager) SoundManager.GetInstance();
            player.Play("C:\\costam");
        }
    }
}
