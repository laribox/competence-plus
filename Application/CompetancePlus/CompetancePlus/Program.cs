using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CompetancePlus.BAL.PStagiaires;
using CompetancePlus.VO.PStagiaires;
using GestionStagiaire;

namespace CompetancePlus
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
            Application.Run(new MenuApplication());

       
        }
    }
}
