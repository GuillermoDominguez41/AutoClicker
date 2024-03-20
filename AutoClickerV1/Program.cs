using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClickerV1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutoClicker());


            //AutoClicker autoclicker = new AutoClicker();
            //autoclicker.Text = "Auto Clicker";
            //Application.Run(autoclicker);

            // https://github.com/KodyKendall/Auto-Clicker/tree/master
        }
    }
}
