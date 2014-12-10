using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionStagiaire.PackageStagiaire;


namespace GestionStagiaire
{
    public partial class MenuApplication : Form
    {
        public MenuApplication()
        {
            InitializeComponent();
        }

        private void ajouterUneInscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStagiairesInscription f = new FormStagiairesInscription();
            f.Show();
        }

        private void gestionFiliereToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void gestionGroupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gérerLesInscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionConfirmation f = new FormGestionConfirmation();
            f.Show();
        }
    }
}
