using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect.Affiliation.Accessoire
{
    public class Accessoire_fourni
    {
        Fournisseur.Fournisseurs fournisseur;
        Accessoires.Accessoire accessoire;
        float Prix;
        string siteFournisseur;

        public Accessoire_fourni(Fournisseur.Fournisseurs fournisseurs , Accessoires.Accessoire accessoire , float unPrix , string unSite)
        {
            this.fournisseur = fournisseurs;
            this.accessoire = accessoire;
            this.Prix = unPrix;
            this.siteFournisseur = unSite;
        }

        public Fournisseur.Fournisseurs GetFournisseurs() { return this.fournisseur; }

        public Accessoires.Accessoire GetAccessoire() { return this.accessoire; }

        public float GetPrix() { return this.Prix; }

        public string GetSite() { return this.siteFournisseur; }
    }
}
