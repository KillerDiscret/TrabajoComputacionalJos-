using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoCompu
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //cambiar el Form1 por otro nombre de formulario para que el programa abra eso primero
            //Application.Run(new FrmGenerarDeudas());
            Application.Run(new Form1());
        }
    }
}
