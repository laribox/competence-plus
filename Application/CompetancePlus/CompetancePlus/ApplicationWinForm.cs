using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionStagiaire.PackageStagiaire;

namespace CompetancePlus
{
    public partial class ApplicationWinForm : Form
    {
        public ApplicationWinForm()
        {
            InitializeComponent();
        }

        private void gestionDesStaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStagiairesInscription f = new FormStagiairesInscription();
            f.Show();
        }
    }
}
