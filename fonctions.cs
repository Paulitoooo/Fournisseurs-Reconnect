using MySql.Data.MySqlClient;
using HtmlAgilityPack;

namespace fonctions
{
    using System;
    using System.Windows.Forms;

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
            reader.Close();
            conn.Close();
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
            reader.Close();
            conn.Close();
        }

        public static int GetIdAppareil(string unModele , string uneMarque , string unType, int unStockage, int Neuf)
        {
            string requete = "select idAppareil from appareil where modele = '" + unModele + "' and idMarqueAppareil = " + GetIdMarque(uneMarque) + " and idTypeAppareil = " + GetIdType(unType) + " and StockageAppareil = " + unStockage + " and Neuf = "+ Neuf + ";";
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
            reader.Close();
            conn.Close();
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

        public static string GetNomFournisseur(int unId)
        {
            string leNom = "";
            string requete = "select nomFournisseur from fournisseur where idFournisseur =" + unId + " ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                leNom = reader.GetString(0);
            }
            return leNom;
        }

        public static float GetPrixAppareilFourni(int idAppareil , int idFournisseur)

        {
            float lePrix = 0F;
            string requete = "Select Prix from appareil_fourni where idAppareil =" + idAppareil + " and idFournisseur = " + idFournisseur + " ;";
            MySqlConnection conn = new MySqlConnection("server =localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lePrix = dr.GetFloat(0);
            }
            return lePrix;
            dr.Close();
            conn.Close();
        }

        public static string GetSiteAppareilFourni(int idAppareil, int idFournisseur)
        {
            string leSite = "";
            string requete = "Select siteAppareilFourni from appareil_fourni where idAppareil = " + idAppareil + " and idFournisseur = " + idFournisseur + " ;";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                leSite = dr.GetString(0);
            }
            return leSite;
            dr.Close();
            conn.Close();
        }

        public static int getIdTypePieceDetachee(string libelleType)
        {
            int id = 0;
            string requete = "Select idTypePieceDetachee from typepiecedetachee where libelleTypePiece = '" + libelleType + "' ;";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            return id;
            dr.Close();
            conn.Close();
        }

        public static int getIdPieceDetachee(string nomPiece)
        {
            int id = 0;
            string requete = "select idPieceDetachee from piecedetachee where nomPieceDetachee = '" + nomPiece + "' ;";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            return id;
            dr.Close();
            conn.Close();
        }

        public static string getLibelleTypePieceDetachee(int unId) 
        {
            string libelle = "";
            string requete = "select * from typepiecedetachee ;";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                libelle = dr.GetString("libelleTypePiece");
            }
            return libelle;
            dr.Close();
            conn.Close();
        }
     }
    

}