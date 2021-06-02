using System;
using System.Collections.Generic;
using System.Linq;
using appgestiopersonnelsoma.controleur;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appgestiopersonnelsoma
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new appgestio());
           // new classControl();
        }
    }
}
