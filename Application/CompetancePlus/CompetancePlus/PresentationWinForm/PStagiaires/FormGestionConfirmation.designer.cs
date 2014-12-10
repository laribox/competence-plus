using CompetancePlus.VO.PStagiaires;
namespace GestionStagiaire.PackageStagiaire
{
    partial class FormGestionConfirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stagiaireDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Stagiaire = new System.Windows.Forms.GroupBox();
            this.Groupe = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.FirstRow = new System.Windows.Forms.Button();
            this.PriviousRow = new System.Windows.Forms.Button();
            this.NextRow = new System.Windows.Forms.Button();
            this.LastRow = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirm = new System.Windows.Forms.DataGridViewImageColumn();
            this.Updates = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataGridView)).BeginInit();
            this.Stagiaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stagiaireDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(91, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tableau stagiaires";
            // 
            // stagiaireDataGridView
            // 
            this.stagiaireDataGridView.AutoGenerateColumns = false;
            this.stagiaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagiaireDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10,
            this.Confirm,
            this.Updates,
            this.Delete});
            this.stagiaireDataGridView.DataSource = this.stagiaireBindingSource;
            this.stagiaireDataGridView.Location = new System.Drawing.Point(6, 22);
            this.stagiaireDataGridView.Name = "stagiaireDataGridView";
            this.stagiaireDataGridView.Size = new System.Drawing.Size(645, 220);
            this.stagiaireDataGridView.TabIndex = 0;
            this.stagiaireDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stagiaireDataGridView_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Confirm";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // Stagiaire
            // 
            this.Stagiaire.Controls.Add(this.Groupe);
            this.Stagiaire.Controls.Add(this.prenom);
            this.Stagiaire.Controls.Add(this.Nom);
            this.Stagiaire.Controls.Add(this.pictureBox1);
            this.Stagiaire.Location = new System.Drawing.Point(62, 32);
            this.Stagiaire.Name = "Stagiaire";
            this.Stagiaire.Size = new System.Drawing.Size(715, 192);
            this.Stagiaire.TabIndex = 1;
            this.Stagiaire.TabStop = false;
            this.Stagiaire.Text = "Stagiaire";
            // 
            // Groupe
            // 
            this.Groupe.AutoSize = true;
            this.Groupe.Location = new System.Drawing.Point(187, 119);
            this.Groupe.Name = "Groupe";
            this.Groupe.Size = new System.Drawing.Size(42, 13);
            this.Groupe.TabIndex = 3;
            this.Groupe.Text = "Groupe";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(187, 85);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(43, 13);
            this.prenom.TabIndex = 2;
            this.prenom.Text = "Prenom";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(187, 48);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom";
            // 
            // FirstRow
            // 
            this.FirstRow.Location = new System.Drawing.Point(178, 245);
            this.FirstRow.Name = "FirstRow";
            this.FirstRow.Size = new System.Drawing.Size(84, 23);
            this.FirstRow.TabIndex = 2;
            this.FirstRow.Text = "<<";
            this.FirstRow.UseVisualStyleBackColor = true;
            this.FirstRow.Click += new System.EventHandler(this.FirstRow_Click);
            // 
            // PriviousRow
            // 
            this.PriviousRow.Location = new System.Drawing.Point(287, 245);
            this.PriviousRow.Name = "PriviousRow";
            this.PriviousRow.Size = new System.Drawing.Size(84, 23);
            this.PriviousRow.TabIndex = 3;
            this.PriviousRow.Text = "<";
            this.PriviousRow.UseVisualStyleBackColor = true;
            this.PriviousRow.Click += new System.EventHandler(this.PriviousRow_Click);
            // 
            // NextRow
            // 
            this.NextRow.Location = new System.Drawing.Point(406, 245);
            this.NextRow.Name = "NextRow";
            this.NextRow.Size = new System.Drawing.Size(84, 23);
            this.NextRow.TabIndex = 4;
            this.NextRow.Text = ">";
            this.NextRow.UseVisualStyleBackColor = true;
            this.NextRow.Click += new System.EventHandler(this.NextRow_Click);
            // 
            // LastRow
            // 
            this.LastRow.Location = new System.Drawing.Point(523, 245);
            this.LastRow.Name = "LastRow";
            this.LastRow.Size = new System.Drawing.Size(84, 23);
            this.LastRow.TabIndex = 5;
            this.LastRow.Text = ">>";
            this.LastRow.UseVisualStyleBackColor = true;
            this.LastRow.Click += new System.EventHandler(this.LastRow_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Confirm";
            this.dataGridViewImageColumn2.Image = global::CompetancePlus.Properties.Resources.confirm;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Update";
            this.dataGridViewImageColumn3.Image = global::CompetancePlus.Properties.Resources.Update;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Delete";
            this.dataGridViewImageColumn4.Image = global::CompetancePlus.Properties.Resources.Delete;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // stagiaireBindingSource
            // 
            this.stagiaireBindingSource.DataSource = typeof(CompetancePlus.VO.PStagiaires.Stagiaire);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Groupe";
            this.dataGridViewTextBoxColumn10.HeaderText = "Groupe";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Confirm
            // 
            this.Confirm.HeaderText = "Confirm";
            this.Confirm.Image = global::CompetancePlus.Properties.Resources.confirm;
            this.Confirm.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Confirm.Name = "Confirm";
            this.Confirm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Updates
            // 
            this.Updates.HeaderText = "Update";
            this.Updates.Image = global::CompetancePlus.Properties.Resources.Update;
            this.Updates.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Updates.Name = "Updates";
            this.Updates.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Updates.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::CompetancePlus.Properties.Resources.Delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormGestionConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 539);
            this.Controls.Add(this.LastRow);
            this.Controls.Add(this.NextRow);
            this.Controls.Add(this.PriviousRow);
            this.Controls.Add(this.FirstRow);
            this.Controls.Add(this.Stagiaire);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestionConfirmation";
            this.Text = "FormGestionConfirmation";
            this.Load += new System.EventHandler(this.FormGestionConfirmation_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataGridView)).EndInit();
            this.Stagiaire.ResumeLayout(false);
            this.Stagiaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView stagiaireDataGridView;
        private System.Windows.Forms.BindingSource stagiaireBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox Stagiaire;
        private System.Windows.Forms.Label Groupe;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FirstRow;
        private System.Windows.Forms.Button PriviousRow;
        private System.Windows.Forms.Button NextRow;
        private System.Windows.Forms.Button LastRow;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn Confirm;
        private System.Windows.Forms.DataGridViewImageColumn Updates;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}