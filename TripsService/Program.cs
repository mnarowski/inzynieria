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
            //Konfiguracja połączenia nhibernate'a
            User u = new User();
            u.vlogin = "root";
            u.vpassword = "root";
            u.vsex = SexEnum.Male;
            u.vSureName = "";
            u.vname = "system";
            DbService.Add<User>(u);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            SoundManager player = (SoundManager) SoundManager.GetInstance();
            player.Play("C:\\costam");
        }
    }
}
