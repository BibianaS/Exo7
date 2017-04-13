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
    public partial class frmExo7 : Form
    {
        public frmExo7()
        {
            InitializeComponent();
            afficheStagiaires();
           
        }
            
        //Methode qui cree une table avec les stagiaires crées
        private void afficheStagiaires()
        {
            DataTable dt = new DataTable();
            DataRow dr;
           
            //ajout de trois colonnes pour l'affichage
            dt.Columns.Add(new DataColumn("Numéro OSIA", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            foreach (Stagiaire unStagiaireEF in Donnees.Db.Stagiaire.ToList())
            {
                //instanciation DataRow (=ligne du DataTable)
                dr = dt.NewRow();

                //affectation de 3 colonnes à partir de l'Entity
                dr[0] = unStagiaireEF.NumOsiaStagiaire;
                dr["Nom"] = unStagiaireEF.NomStagiaire;
                dr["Prénom"] = unStagiaireEF.PrenomStagiaire;

                //ajout de la ligne à la Datatable
                dt.Rows.Add(dr);
            }

            //determiner l'orogine des données à afficher
            this.grdStagiaires.DataSource = dt;
            //Rafraicchir l'affichage
            this.grdStagiaires.Refresh();
            dt = null;
            dr = null;
        }
        /// <summary>
        /// bouton Ajouter : instancie un form de saisie de stagiaire
        /// apres reaffiche la datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjoutStagiaire frmAjout = new frmAjoutStagiaire();

            //Si on sort de la saisie par ok
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                afficheStagiaires();
            }
        }

        private void grdStagiaires_DoubleClick(object sender, EventArgs e)
        {
            //rechercher le stagiaire correspondant à la ligne 
            int idStag;
            idStag = (int)this.grdStagiaires.CurrentRow.Cells[0].Value;

            //rechercher l'objet entity
            Stagiaire leStagiaireEF = Donnees.Db.Stagiaire.Find(idStag);

            //instancier un obj metier MStagiaire et le renseigner à partir de l'Entity
            MSstagiaire leStagiare      = new MSstagiaire();
            leStagiare.NumOsia          = leStagiaireEF.NumOsiaStagiaire;
            leStagiare.NomStagiaire     = leStagiaireEF.NomStagiaire;
            leStagiare.PrenomStagiaire  = leStagiaireEF.PrenomStagiaire;
            leStagiare.Rue              = leStagiaireEF.RueStagiaire;
            leStagiare.Ville            = leStagiaireEF.VilleStagiaire;
            leStagiare.CodePostal       = leStagiaireEF.CodePostalStagiaire;
         
            int iStag;
            iStag = this.grdStagiaires.CurrentRow.Index;
            //MessageBox.Show(iStag.ToString());

            //instancier un objet stagiaire pointant vers le stagiaire d'origine dns la collection
            MSstagiaire leStagiaire = Donnees.ArrayStag[iStag];

            //instancier un form detaille pour le stagiaire
            frmVisuStagiaire frmVisu = new frmVisuStagiaire(leStagiaire);

            //affiche le form détail en modal
            frmVisu.ShowDialog();

            this.afficheStagiaires();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idStag;
            idStag = (int)this.grdStagiaires.CurrentRow.Cells[0].Value;

            Stagiaire leStagiaireEF = Donnees.Db.Stagiaire.Find(idStag);

            //confirmer la suppression
            if (MessageBox.Show("Voulez-vous supprimer définitivement le stagiare "+leStagiaireEF.NomStagiaire.Trim()+ " - OSIA : " + leStagiaireEF.NumOsiaStagiaire.ToString() + "?", "confirmer") == DialogResult.OK)
            {
                //supprimer le stagiaire de la collection EF
                Donnees.Db.Stagiaire.Remove(leStagiaireEF);
                //impacter en BdD
                Donnees.Db.SaveChanges();
            }
            this.afficheStagiaires();
        }
    }
}
