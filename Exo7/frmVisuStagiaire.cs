using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo7
{
    public partial class frmVisuStagiaire : frmStagiaire
    {
        private MSstagiaire leStagiaire;

        public frmVisuStagiaire(MSstagiaire unStagiaire)
        {
            this.leStagiaire = unStagiaire;
            InitializeComponent();
        }

        private void frmVisuStagiaire_Load(object sender, EventArgs e)
        {
            this.afficheStagiaire(this.leStagiaire);
        }

        private void afficheStagiaire (MSstagiaire unStagiaire)
        {
            this.txtOsia.Text = unStagiaire.NumOsia.ToString();
            this.txtNom.Text = unStagiaire.NomStagiaire;
            this.txtPrenom.Text = unStagiaire.PrenomStagiaire;
            this.txtAdresse.Text = unStagiaire.Rue;
            this.txtCP.Text = unStagiaire.CodePostal.ToString();

            


        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (controle())
            {
                this.leStagiaire.NumOsia = int.Parse(txtOsia.Text);
                this.leStagiaire.NomStagiaire = txtNom.Text;
                this.leStagiaire.PrenomStagiaire = txtPrenom.Text;
                this.leStagiaire.Rue = txtAdresse.Text;
                this.leStagiaire.CodePostal = txtCP.Text;

                this.DialogResult = DialogResult.OK;


            }            
        }

        private Boolean controle()
        {
            Boolean code = true;
            if (!(Outils.EstEntier(this.txtOsia.Text)))
            {
                code = false;
                MessageBox.Show("Le code OSIA saisie n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }
            if (!(Outils.EstEntier(this.txtCP.Text)))
            {
                code = false;
                MessageBox.Show("Le CP saisie n'est pas correct", "ERREUR", MessageBoxButtons.OK);
            }
            return code;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            afficheStagiaire(this.leStagiaire);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
