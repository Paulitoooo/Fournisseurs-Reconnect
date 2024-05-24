using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fournisseurs_Reconnect.Appareil;
using Fournisseurs_Reconnect.Fournisseur;

namespace Fournisseurs_Reconnect
{
    internal class Appareil_Fourni
    {
        Fournisseurs fournisseur;
        float prix;
        string siteAppareilFourni;
        Appareils Appareil;
        
        public Appareil_Fourni(Fournisseurs unFournisseur, float unPrix , string unSite, Appareils unAppareil)
        {
            this.fournisseur = unFournisseur;
            this.prix = unPrix;
            this.siteAppareilFourni = unSite;
            this.Appareil = unAppareil;
        }

        public string getSiteAppareil() {  return siteAppareilFourni; }

        public float getPrix() { return prix; }

        public int getIdAppareil() { return Appareil.getIdAppareil(); }




    }
}
