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

namespace GestionStagiaire.PackageStagiaire
{
    public partial class FormStagiairesInscription : Form
    {
        public FormStagiairesInscription()
        {
            InitializeComponent();
        }
        string Url;
        bool up;
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Up
        {
            get { return up; }
            set { up = value; }
        }
      
       

        private void BtValide_Click(object sender, EventArgs e)
        {
            string sexe;
            if (sexeRadioButton.Checked)
            {
                sexe = "Male";
            }
            else sexe = "Femelle";

            FormStagiaireConfirmerInscription f = new FormStagiaireConfirmerInscription();
            f.Update(Url,nomTextBox.Text,PrenomTextBox.Text,dateNaissanceDateTimePicker.Value.ToString(),
                sexe,CinTextBox.Text,(Groupe)groupeComboBox.SelectedItem,(Filiere)FilierecomboBox.SelectedItem,
                emailTextBox.Text,telephoneTextBox.Text,adresseTextBox.Text);
            f.Formu = this;
            f.Show();
            this.Hide();

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
