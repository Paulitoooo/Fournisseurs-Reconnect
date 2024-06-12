using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fournisseurs_Reconnect.Appareil
{
    public class Appareils
    {
        private int idAppareil;
        private string modele;
        private int idMarque;
        private int idType;
        private int stockageAppareil;
        private bool Neuf;


        public Appareils(int unId, string unModele, int unIdMarque, int unIdType, int unStockage, bool estNeuf)
        {
            this.idAppareil = unId;
            this.modele = unModele;
            this.idMarque = unIdMarque;
            this.idType = unIdType;
            this.stockageAppareil = unStockage;
            this.Neuf = estNeuf;
        }

        public int getIdAppareil()
        {
            return idAppareil;
        }

        public string getModele()
        {
            return modele;
        }

        public int getIdMarque() 
        {
            return idMarque; 
        }

        public int getIdType()
        {
            return idType;
        }

        public int getStockageAppareil()
        {
            return stockageAppareil;
        }

        public bool getNeuf() 
        {
            return Neuf;
        }

        public string getNomMarque()
        {
            string requeteNom = "Select nomMarque from marque where idMarque =" + this.getIdMarque().ToString() + ";";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requeteNom, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            string nomMarque = "";
            if (dataReader.Read())
            {
                nomMarque = dataReader.GetString(0);
            }
            conn.Close();
            return nomMarque;

        }

        public string getLibelleType()
        {
            string requeteType = "Select libelleTypeAppareil from typeappareil where idTypeAppareil =" + this.getIdType() + ";";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requeteType, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            string libelleType = "";
            if (dataReader.Read())
            {
                libelleType = dataReader.GetString(0);
            }
            conn.Close();
            return libelleType;

        }
    }
}
