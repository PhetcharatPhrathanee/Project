using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
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

            LoginForm login = new LoginForm();

            // เปิด LoginForm 
            
            {
                // ถ้า login ผ่าน เปิด TestMain (MainForm อยู่ใน Panel)
                Application.Run(new TestMain());
            }
        }
    }
}
