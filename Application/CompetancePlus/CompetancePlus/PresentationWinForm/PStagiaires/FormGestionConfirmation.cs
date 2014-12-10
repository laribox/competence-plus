using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetancePlus.VO.PStagiaires;
using CompetancePlus.BAL.PStagiaires;

namespace GestionStagiaire.PackageStagiaire
{
    public partial class FormGestionConfirmation : Form
    {
        public FormGestionConfirmation()
        {
            InitializeComponent();
        }
        public void Actualiser() {
            stagiaireBindingSource.DataSource = null;
            stagiaireBindingSource.DataSource =new  StagiaireBAO().SelectNotConfirm();
        }

        private void stagiaireDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (e.ColumnIndex == 3)
                {
                    Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                    new StagiaireBAO().UpdateStat(s.Id);
                    this.Actualiser();
                }
                if (e.ColumnIndex == 4)
                {
                    Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                    FormStagiaireUpdate f = new FormStagiaireUpdate();
                    f.UpdateU(s);
                    f.ShowDialog();
                    this.Actualiser();
                }
                if (e.ColumnIndex == 5)
                {
                    Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                    new StagiaireBAO().Delete(s.Id);
                    this.Actualiser();
                }
                Stagiaire x = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(x.ProfilImage);
                Nom.Text = x.Nom;
                prenom.Text = x.Prenom;
                Groupe.Text = x.Groupe.Nom;
           
            
          

        }

        private void FormGestionConfirmation_Load(object sender, EventArgs e)
        {
            this.Actualiser();
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Groupe.Text = s.Groupe.Nom;
            }
            catch (Exception)
            {
            }
           
        }

        private void FirstRow_Click(object sender, EventArgs e)
        {
            stagiaireBindingSource.Position = 0;
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Groupe.Text = s.Groupe.Nom;
            }
            catch (Exception)
            {
            }
        }

        private void LastRow_Click(object sender, EventArgs e)
        {
            stagiaireBindingSource.Position = stagiaireBindingSource.Count;
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Groupe.Text = s.Groupe.Nom;
            }
            catch (Exception)
            {
            }
        }

        private void NextRow_Click(object sender, EventArgs e)
        {
            stagiaireBindingSource.Position = stagiaireBindingSource.Position+1;
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Groupe.Text = s.Groupe.Nom;
            }
            catch (Exception)
            {
            }
        }

        private void PriviousRow_Click(object sender, EventArgs e)
        {
            stagiaireBindingSource.Position = stagiaireBindingSource.Position - 1;
            try
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                pictureBox1.Image = Image.FromFile(s.ProfilImage);
                Nom.Text = s.Nom;
                prenom.Text = s.Prenom;
                Groupe.Text = s.Groupe.Nom;
            }
            catch (Exception)
            {
            }
        }
    }
}
