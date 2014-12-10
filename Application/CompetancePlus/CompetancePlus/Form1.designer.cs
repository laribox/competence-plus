namespace GestionStagiaire
{
    partial class MenuApplication
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStagiaireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneInscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesInscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesStagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionGroupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionFiliereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionStagiaireToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionStagiaireToolStripMenuItem
            // 
            this.gestionStagiaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionStagiaireToolStripMenuItem1});
            this.gestionStagiaireToolStripMenuItem.Name = "gestionStagiaireToolStripMenuItem";
            this.gestionStagiaireToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.gestionStagiaireToolStripMenuItem.Text = "Gestion individu";
            // 
            // gestionStagiaireToolStripMenuItem1
            // 
            this.gestionStagiaireToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneInscriptionToolStripMenuItem,
            this.gérerLesInscriptionToolStripMenuItem,
            this.gérerLesStagiairesToolStripMenuItem});
            this.gestionStagiaireToolStripMenuItem1.Name = "gestionStagiaireToolStripMenuItem1";
            this.gestionStagiaireToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.gestionStagiaireToolStripMenuItem1.Text = "Gestion stagiaire";
            // 
            // ajouterUneInscriptionToolStripMenuItem
            // 
            this.ajouterUneInscriptionToolStripMenuItem.Name = "ajouterUneInscriptionToolStripMenuItem";
            this.ajouterUneInscriptionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajouterUneInscriptionToolStripMenuItem.Text = "Ajouter une inscription";
            this.ajouterUneInscriptionToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneInscriptionToolStripMenuItem_Click);
            // 
            // gérerLesInscriptionToolStripMenuItem
            // 
            this.gérerLesInscriptionToolStripMenuItem.Name = "gérerLesInscriptionToolStripMenuItem";
            this.gérerLesInscriptionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gérerLesInscriptionToolStripMenuItem.Text = "Gérer les inscriptions";
            this.gérerLesInscriptionToolStripMenuItem.Click += new System.EventHandler(this.gérerLesInscriptionToolStripMenuItem_Click);
            // 
            // gérerLesStagiairesToolStripMenuItem
            // 
            this.gérerLesStagiairesToolStripMenuItem.Name = "gérerLesStagiairesToolStripMenuItem";
            this.gérerLesStagiairesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gérerLesStagiairesToolStripMenuItem.Text = "Gérer les stagiaires";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionGroupeToolStripMenuItem,
            this.gestionFiliereToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.gestionToolStripMenuItem.Text = "Gestion information";
            // 
            // gestionGroupeToolStripMenuItem
            // 
            this.gestionGroupeToolStripMenuItem.Name = "gestionGroupeToolStripMenuItem";
            this.gestionGroupeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.gestionGroupeToolStripMenuItem.Text = "Gestion groupe";
            this.gestionGroupeToolStripMenuItem.Click += new System.EventHandler(this.gestionGroupeToolStripMenuItem_Click);
            // 
            // gestionFiliereToolStripMenuItem
            // 
            this.gestionFiliereToolStripMenuItem.Name = "gestionFiliereToolStripMenuItem";
            this.gestionFiliereToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.gestionFiliereToolStripMenuItem.Text = "Gestion Filiere";
            this.gestionFiliereToolStripMenuItem.Click += new System.EventHandler(this.gestionFiliereToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue";
            // 
            // MenuApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuApplication";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStagiaireToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneInscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesInscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesStagiairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionGroupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionFiliereToolStripMenuItem;


    }
}

