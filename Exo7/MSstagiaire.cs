using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7
{
    ///Classe stagiaires:
    ///permet de mémoriser les informations concernant un stagiaire
    ///a des membres proprietes et attributs et le # de stagiaires
    ///Donnée patage par toutes les instances STATIC
    public class MSstagiaire
    {
        ///nombre stagiaires de la classe
        ///donée partage par toutes les instances
        ///
        public static int Nstag;
        public int numOsiaStagiaire; //Obtient le numero du stagiaire
        private string nomStagiaire;
        private string prenomStagiaire;
        private string rueStagiaire;
        private string villeStagiaire;
        public String codePostalStagiaire;
        private int nbreNotes;
        ///Cumul des points obtenus
        private double pointsNotes;

        ///numero du stagiaire
        public int NumOsia
        {
            get { return numOsiaStagiaire; }
            set { numOsiaStagiaire = value; }
        }

        
        public string NomStagiaire
        {
            get { return this.nomStagiaire; }
            set { this.nomStagiaire = value.Trim().ToUpper(); }
        }

        
        public string PrenomStagiaire
        {
            get { return this.prenomStagiaire; }
            set { this.prenomStagiaire = value.Trim().ToLower(); }
        }

        
        public string Rue
        {
            get { return this.rueStagiaire; }
            set { this.rueStagiaire = value; }
        }

        
        public string Ville
        {
            get { return villeStagiaire; }
            set { this.villeStagiaire = value.Trim().ToUpper(); }
        }

        /// <summary>
        /// Verification du code postal
        /// </summary>
        public string CodePostal
        {
            get { return codePostalStagiaire; }
            set
            {
                int i;
                bool erreur = false;
                if (value.Length == 5)
                {
                    for (i = 0; i < value.Length; i++)
                    {
                        if (!(Char.IsDigit(value[i])))
                        {
                            erreur = true;
                        }
                    }
                    if (erreur)
                    {
                        throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement chiffres");
                    }
                    else
                    {
                        codePostalStagiaire = value;
                    }

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Nombre de notes obtenues
        /// </summary>
        



        ///alimente nbre de notes et points Notes
        ///<param name="laNote"> la nouvelle note à prendre en compte 
        ///</param>
        public double RecevoirNote(float laNote)
        {
            this.nbreNotes++;
            this.pointsNotes += laNote;
            return pointsNotes;
        }

        ///calcule et returne lam oyenne des notes
        public double DonnerMoyenne()
        {
            return this.pointsNotes / this.nbreNotes;
        }


    }
}
