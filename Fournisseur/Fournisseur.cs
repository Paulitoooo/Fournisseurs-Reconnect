using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect.Fournisseur
{
    public class Fournisseurs
    {
        int idFournisseur;
        string nomFournisseur;
        string siteFournisseur;



        public Fournisseurs(int unId, string unNom, string unSite)
        {
            this.idFournisseur = unId;
            this.nomFournisseur = unNom;
            this.siteFournisseur = unSite;
        }

        public int getIdFournisseur()
        {
            return idFournisseur;
        }

        public string getNomFournisseur()
        {
            return nomFournisseur;
        }

        public string getSiteFournisseur()
        {
            return siteFournisseur;
        }


    }
}
