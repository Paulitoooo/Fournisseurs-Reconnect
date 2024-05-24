using MySql.Data.MySqlClient;
using HtmlAgilityPack;

namespace fonctions
{
    using System;
    public struct lesFonctions
    {
        public static int GetIdMarque(string unNom)
        {
            int id = 0;
            string requete = "select idMarque from marque where nomMarque = '" + unNom + "' ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }

        public static int GetIdType(string unNom)
        {
            int id = 0;
            string requete = "select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + unNom + "';";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }

        public static int GetIdAppareil(string unModele , string uneMarque , string unType, int unStockage)
        {
            string requete = "select idAppareil from appareil where modele = '" + unModele + "' and idMarqueAppareil = " + GetIdMarque(uneMarque) + " and idTypeAppareil = " + GetIdType(unType) + " and StockageAppareil = " + unStockage + ";";
            int id = 0;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }

        public static int GetIdFournisseur(string unNom)
        {
            int id = 0;
            string requete = "Select idFournisseur from fournisseur where nomFournisseur = '" + unNom + "' ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }
     }
    

}