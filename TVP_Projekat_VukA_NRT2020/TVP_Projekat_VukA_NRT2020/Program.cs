using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat_VukA_NRT2020
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
            if (File.Exists("users.txt") && File.Exists("rooms.txt") && File.Exists("guests.txt") && File.Exists("reservations.txt"))
            {
                ModelLister.populateLister();
                Application.Run(LogInFormProvider.provide());
            }
            else
            {
                Application.Run(new ErrorHandler());
            }
        }
    }
}
