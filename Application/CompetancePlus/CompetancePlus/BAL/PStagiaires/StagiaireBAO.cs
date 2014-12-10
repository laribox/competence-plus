using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP10.Service;
using System.Windows.Forms;
using CompetancePlus.VO.PStagiaires;
using CompetancePlus.Outils;
using CompetancePlus.DAL.PStagiaires;

namespace CompetancePlus.BAL.PStagiaires
{
    public class StagiaireBAO : StagiaireDAO
    {

        public static new void Add(Stagiaire s)
        {
            if (s.Nom != "")
                new StagiaireDAO().Add(s);

        }
         
    }
}
