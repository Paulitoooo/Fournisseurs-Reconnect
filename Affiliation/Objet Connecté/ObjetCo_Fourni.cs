using Fournisseurs_Reconnect.Objet_connecté;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect.Affiliation.Objet_Connecté
{
    public class ObjetCo_Fourni
    {
        objetConnecte objetCO;
        int idFournisseur;
        float prix;
        string siteObjetCoFourni;

        public ObjetCo_Fourni(objetConnecte objetCO, int idFournisseur, float prix, string siteObjetCoFourni)
        {
            this.objetCO = objetCO;
            this.idFournisseur = idFournisseur;
            this.prix = prix;
            this.siteObjetCoFourni = siteObjetCoFourni;
        }

        public int getIdFournisseur() { return this.idFournisseur; }

        public objetConnecte GetObjetConnecte() { return this.objetCO; }

        public float getPrix() { return this.prix; }

        public string getSiteObjetCoFourni() { return this.siteObjetCoFourni; }
    }
}
