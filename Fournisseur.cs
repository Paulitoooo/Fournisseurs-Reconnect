using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fournisseurs_Reconnect
{
    public class Fournisseur
    {
        int idFournisseur;
        string nomFournisseur;
        string siteFournisseur;



        public Fournisseur(int unId, string unNom, string unSite)
        {
            this.idFournisseur = unId;
            this.nomFournisseur = unNom;
            this.siteFournisseur = unSite;
        }

        public int getIdFournisseur()
        {
            return idFournisseur;
        }
    }
}
