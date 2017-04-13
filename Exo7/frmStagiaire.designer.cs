namespace Exo7
{
    partial class frmStagiaire
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
            this.gbxStagiaire = new System.Windows.Forms.GroupBox();
            this.lblOsia = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtOsia = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.gbxStagiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStagiaire
            // 
            this.gbxStagiaire.Controls.Add(this.txtCP);
            this.gbxStagiaire.Controls.Add(this.txtVille);
            this.gbxStagiaire.Controls.Add(this.txtAdresse);
            this.gbxStagiaire.Controls.Add(this.txtPrenom);
            this.gbxStagiaire.Controls.Add(this.txtNom);
            this.gbxStagiaire.Controls.Add(this.txtOsia);
            this.gbxStagiaire.Controls.Add(this.lblCodePostal);
            this.gbxStagiaire.Controls.Add(this.lblVille);
            this.gbxStagiaire.Controls.Add(this.lblAdresse);
            this.gbxStagiaire.Controls.Add(this.lblPrenom);
            this.gbxStagiaire.Controls.Add(this.lblNom);
            this.gbxStagiaire.Controls.Add(this.lblOsia);
            this.gbxStagiaire.Location = new System.Drawing.Point(13, 27);
            this.gbxStagiaire.Name = "gbxStagiaire";
            this.gbxStagiaire.Size = new System.Drawing.Size(372, 243);
            this.gbxStagiaire.TabIndex = 0;
            this.gbxStagiaire.TabStop = false;
            this.gbxStagiaire.Text = "Stagiaire";
            // 
            // lblOsia
            // 
            this.lblOsia.AutoSize = true;
            this.lblOsia.Location = new System.Drawing.Point(24, 31);
            this.lblOsia.Name = "lblOsia";
            this.lblOsia.Size = new System.Drawing.Size(78, 13);
            this.lblOsia.TabIndex = 0;
            this.lblOsia.Text = "Numéro OSIA :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(24, 63);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(24, 93);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(24, 126);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(24, 155);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville :";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(27, 183);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(67, 13);
            this.lblCodePostal.TabIndex = 5;
            this.lblCodePostal.Text = "CodePostal :";
            // 
            // txtOsia
            // 
            this.txtOsia.Location = new System.Drawing.Point(124, 31);
            this.txtOsia.Name = "txtOsia";
            this.txtOsia.Size = new System.Drawing.Size(227, 20);
            this.txtOsia.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(124, 63);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(227, 20);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(124, 93);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(227, 20);
            this.txtPrenom.TabIndex = 8;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(124, 123);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(227, 20);
            this.txtAdresse.TabIndex = 9;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(124, 152);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(227, 20);
            this.txtVille.TabIndex = 10;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(124, 183);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(106, 20);
            this.txtCP.TabIndex = 11;
            // 
            // frmStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 304);
            this.Controls.Add(this.gbxStagiaire);
            this.Name = "frmStagiaire";
            this.Text = "Classe virtuelle parente stagiaire";
            this.gbxStagiaire.ResumeLayout(false);
            this.gbxStagiaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblOsia;
        protected System.Windows.Forms.GroupBox gbxStagiaire;
        protected System.Windows.Forms.TextBox txtCP;
        protected System.Windows.Forms.TextBox txtVille;
        protected System.Windows.Forms.TextBox txtAdresse;
        protected System.Windows.Forms.TextBox txtPrenom;
        protected System.Windows.Forms.TextBox txtNom;
        protected System.Windows.Forms.TextBox txtOsia;
    }
}

