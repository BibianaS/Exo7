using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7
{

    /// <summary> /// classe générale des données à gérer 
    /// ----------------------------------- 
    /// classe qui regroupe les données 
    /// de l'application de gestion des stagiaires 
    /// dans une collection d'objets définie en static (= non instanciable)  
    /// </summary>
    public class Donnees
    {
        ///collection d'objets MStagiaires
        public static List<MSstagiaire> ArrayStag = new List<MSstagiaire>();

        public static FormationsEntities Db = new FormationsEntities();
    }
}
