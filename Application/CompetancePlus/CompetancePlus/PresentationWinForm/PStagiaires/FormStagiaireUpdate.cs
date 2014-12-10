using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetancePlus.VO.PGroupes;
using CompetancePlus.VO.PFilieres;
using CompetancePlus.BAL.PGroupes;
using CompetancePlus.BAL.PFilieres;
using CompetancePlus.VO.PStagiaires;
using CompetancePlus.BAL.PStagiaires;

namespace GestionStagiaire.PackageStagiaire
{
    public partial class FormStagiaireUpdate : Form
    {
        public FormStagiaireUpdate()
        {
            InitializeComponent();
        }
        string Url;
        int id;

        public void UpdateU(Stagiaire s) {
            id = s.Id;
            pictureBox1.Image = Image.FromFile(s.ProfilImage);
            Url = s.ProfilImage;
            nomTextBox.Text = s.Nom;
            PrenomTextBox.Text = s.Prenom;
            dateNaissanceDateTimePicker.Value = s.DateNaissance;
            if (s.Sexe == true)
            {
                sexeRadioButton.Checked = true;
            }
            else SexeRadioButton2.Checked = true;
            CinTextBox.Text = s.Cin;
            groupeComboBox.SelectedIndex = groupeComboBox.Items.IndexOf(s.Groupe.Nom);
            FilierecomboBox.SelectedIndex = FilierecomboBox.Items.IndexOf(s.Groupe.Filiere.Nom);
            emailTextBox.Text = s.Email;
            telephoneTextBox.Text = s.Telephone.ToString();
            adresseTextBox.Text = s.Adresse;
        
        }

        private void BtValide_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.Id = id;
            s.ProfilImage = Url;
            s.Nom = nomTextBox.Text;
            s.Prenom = PrenomTextBox.Text;
            s.DateNaissance = dateNaissanceDateTimePicker.Value;
            if (sexeRadioButton.Checked == true)
            {
                s.Sexe = true;
            }
            else s.Sexe = false;
            s.Cin = CinTextBox.Text;
            s.Groupe = (Groupe)groupeComboBox.SelectedItem;
            s.Groupe.Filiere = (Filiere)FilierecomboBox.SelectedItem;
            s.Email = emailTextBox.Text;
            s.Telephone = telephoneTextBox.Text;
            s.Adresse = adresseTextBox.Text;
            new StagiaireBAO().Update(s);
            this.Dispose();

        }

        private void FormStagiaireInscription_Load(object sender, EventArgs e)
        {
            groupeComboBox.DataSource = new GroupeBAO().Select();
            FilierecomboBox.DataSource = new FiliereBAO().Select();
        }

        private void BtProfilImage_Click(object sender, EventArgs e)
        {
            openImageDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openImageDialog.FileName);
            Url = openImageDialog.FileName;
           
          
            
        }
    }
}
