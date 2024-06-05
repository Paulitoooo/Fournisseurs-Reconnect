using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect.Objet_connecté
{
    public class objetConnecte
    {
        int idObjetConnecte;
        string nomMarqueObjetConnecte;
        string libelleTypeObjetConnecte;
        string nomModeleObjetConnecte;

        public objetConnecte(int unId,string uneMarque,string unLibelle,string unModele)
        {
            this.idObjetConnecte = unId;
            this.nomMarqueObjetConnecte = uneMarque;
            this.libelleTypeObjetConnecte = unLibelle;
            this.nomModeleObjetConnecte = unModele;
        }

        public int getIdObjetConnecte() { return this.idObjetConnecte; }

        public string getNomMarqueObjetConnecte() { return this.nomMarqueObjetConnecte; }

        public string getLibelleTypeObjetConnecte() { return this.libelleTypeObjetConnecte; }

        public string getModeleObjetConnecte() { return this.nomModeleObjetConnecte; }

    }
}
