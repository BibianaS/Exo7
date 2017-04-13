using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exo7
{
    /// <summary>
    /// Classe herite de la class stagiaire, permet d'ajouter un stagiaire apres double click
    /// dans le tableau
    /// </summary>
    public partial class frmAjoutStagiaire : frmStagiaire
    {
        //Constructeur de la fenetre ajouter stagiaire
        public frmAjoutStagiaire()
        {
            InitializeComponent();
        }

        //Evennement sur le bouton ok
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.controle())
            {
                if (this.instancie())
                {
                    MSstagiaire.Nstag += 1;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        //Methode qui contrôle la saisie du num OSIA et du Code Postale
        public Boolean controle()
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


        private Boolean instancie()
        {
            MSstagiaire nouveauStagiaire = new MSstagiaire();
            try
            {
                nouveauStagiaire.NumOsia = int.Parse(base.txtOsia.Text.Trim());
                nouveauStagiaire.NomStagiaire = base.txtNom.Text;
                nouveauStagiaire.PrenomStagiaire = base.txtPrenom.Text;
                nouveauStagiaire.Rue = base.txtAdresse.Text;
                nouveauStagiaire.Ville = base.txtVille.Text;
                nouveauStagiaire.CodePostal =base.txtCP.Text.Trim();
                Donnees.ArrayStag.Add(nouveauStagiaire);
                

                //impact sur la BdD
                //création et enregistrement Entity Stagiaire
                Stagiaire nouveauStagiaireEF = new Stagiaire();
                nouveauStagiaireEF.NumOsiaStagiaire = nouveauStagiaire.NumOsia;
                nouveauStagiaireEF.NomStagiaire = nouveauStagiaire.NomStagiaire;
                nouveauStagiaireEF.PrenomStagiaire = nouveauStagiaire.PrenomStagiaire;
                nouveauStagiaireEF.RueStagiaire = nouveauStagiaire.Rue;
                nouveauStagiaireEF.VilleStagiaire = nouveauStagiaire.Ville;
                nouveauStagiaireEF.CodePostalStagiaire = nouveauStagiaire.NomStagiaire;
               
                //insertion en dbcontext
                Donnees.Db.Stagiaire.Add(nouveauStagiaireEF);
                //Maj BdD
                Donnees.Db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                nouveauStagiaire = null;
                MessageBox.Show("Erreur : \n"+ex.Message,"Ajout de dtagiaire");
                return false;
            }
        }
    
        //Evennement, si on appuie sur annuler, la fenetre se ferme
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
