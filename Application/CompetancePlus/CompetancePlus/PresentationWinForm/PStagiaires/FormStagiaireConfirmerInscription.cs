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
using CompetancePlus.VO.PStagiaires;
using CompetancePlus.BAL.PGroupes;
using CompetancePlus.BAL.PStagiaires;


namespace GestionStagiaire.PackageStagiaire
{
    public partial class FormStagiaireConfirmerInscription : Form
    {
        public FormStagiaireConfirmerInscription()
        {
            InitializeComponent();
        }
        string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

      

        public FormStagiairesInscription Formu { get; set; }
        
        public void  Update(string Url,string nom,string Prenom,string dateNaissance,string Sexe ,string Cin,Groupe g ,Filiere f ,string Email,string Telephone,string Adresse){
        pictureBox1.Image=Image.FromFile(Url);
        NomLab.Text = nom;
        PrenomLab.Text = Prenom;
        DateNaissanceLab.Text = dateNaissance;
        SexeLab.Text = Sexe;
        CinLab.Text = Cin;
        GroupeLab.Text = g.Nom;
        FiliereLab.Text = f.Nom;
        EmailLab.Text = Email;
        TelephoneLab.Text = Telephone;
        AdresseLab.Text = Adresse;
        this.url = Url;
        
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Formu.Show();
            
        }
        private void BtConfirmer_Click(object sender, EventArgs e)
        {
           
            Stagiaire s = new Stagiaire();
           
            s.Nom = NomLab.Text;
            s.Prenom = PrenomLab.Text;
            s.DateNaissance = DateTime.Parse(DateNaissanceLab.Text);
            if (SexeLab.Text == "Male")
            {
                s.Sexe = true;
            }
            else s.Sexe = false;
            s.Cin = CinLab.Text; 
            s.Groupe = new GroupeBAO().FindByName(GroupeLab.Text) ;
            s.Email = EmailLab.Text;
            s.Telephone = TelephoneLab.Text;
            s.Adresse = AdresseLab.Text;
            s.Etat = 0;
            s.ProfilImage = url;
            s.Id = 1;
            StagiaireBAO.Add(s);
            this.Dispose(); 
          
        }

        private void FormStagiaireConfirmerInscription_Load(object sender, EventArgs e)
        {

        }

        
    }
}
