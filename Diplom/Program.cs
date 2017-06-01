using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
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
            var auth = new AuthForm();
            Application.Run(auth);
            if (auth.DialogResult == DialogResult.OK)
            {
                auth.Close();
                Application.Run(new MainForm(auth.User));
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
