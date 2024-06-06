using MySql.Data.MySqlClient;
using HtmlAgilityPack;

namespace fonctions
{
    using Org.BouncyCastle.Asn1.Mozilla;
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

        public static int GetIdTypeAppareil(string unNom)
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
            string requete = "select idAppareil from appareil where modele = '" + unModele + "' and idMarqueAppareil = " + GetIdMarque(uneMarque) + " and idTypeAppareil = " + GetIdTypeAppareil(unType) + " and StockageAppareil = " + unStockage + " and Neuf = "+ Neuf + ";";
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

        public static int getIdPieceDetachee(string nomPiece,string nomModele)
        {
            int id = 0;
            string requete = "select idPieceDetachee from piecedetachee where nomPieceDetachee = '" + nomPiece + "' and nomModeleAppareil = '" + nomModele + "' ;";
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
            string requete = "select * from typepiecedetachee where idTypePieceDetachee = " + unId + " ;";
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

        public static string GetNomMarque(int unId)
        {
            string nomMarque = "";
            string requete = "select * from marque where idMarque = " + unId + " ;";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nomMarque = dr.GetString("nomMarque");
            }
            return nomMarque;
            dr.Close();
            conn.Close();
        }

        public static int GetUnIdTypePourUnePiece(int idPiece)
        {
            int id = 0;
            string requete = "select idTypePieceDetachee from piecedetachee where idPieceDetachee = " + idPiece + " ;";
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

        public static string GetUnModelePourUnePiece(int idPiece)
        {
            string modele = "";
            string requete = "Select nomModeleAppareil from piecedetachee where idPieceDetachee = " + idPiece + " ;";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                modele = dr.GetString("nomModeleAppareil");
            }
            return modele;
            dr.Close();
            conn.Close();
        }

        public static float getPrixPieceDetacheeFournie(int idPiece,int idFounisseur)
        {
            float lePrix = 0F;
            string requete = "select Prix from piecedetachee_fournie where idFournisseur = " + idFounisseur + " and idPieceDetachee = " + idPiece + "; ";
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

        public static string getSitePieceDetacheeFournie(int idPiece, int idFournisseur)
        {
            string leSite = "";
            string requete = "select sitePieceDetacheeFourni from piecedetachee_fournie where idFournisseur = " + idFournisseur + " and idPieceDetachee = " + idPiece + "; ";
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

        public static string getNomPieceDetachee(int unId)
        {
            string nom = ""; 
            string requete = "select nomPieceDetachee from piecedetachee where idPieceDetachee = " + unId + " ;";
            MySqlConnection conn = new MySqlConnection(connexionServeur.connexion);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nom = dr.GetString(0);
            }
            conn.Close();
            return nom;
        }

        public static int GetIdTypeObjetCo(string unLibelle)
        {
            int id = 0;
            string requete = "select * from typeobjetco where libelleTypeObjetCo = '" + unLibelle + "';";
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

        public static int GetIdObjetConnecte(string uneMarque,string unType,string unModele)
        {
            int id = 0;
            string requete = "select idObjetConnecte from objetconnecte where idMarqueObjetCo = " + GetIdMarque(uneMarque).ToString() + " and idTypeObjetCo = " + GetIdTypeObjetCo(unType) + " and modeleObjetCo = '" + unModele + "' ;";
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

        public static float getPrixObjetCoFourni(int idObjetCo,int idFournisseur)
        {
            float lePrix = 0F;
            string requete = "select Prix from objetconnecte_fourni where idObjetConnecte = " + idObjetCo + " and idFournisseur = " + idFournisseur + " ;";
            MySqlConnection conn = new MySqlConnection("server = localhost; database = fournisseur_reconnect; user = root; pwd =");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lePrix = dr.GetFloat(0);
            }
            return lePrix;

        }

        public static string getSiteObjetCoFOurni(int idObjetCo, int idFournisseur)
        {
            string leSite = "";
            string requete = "select siteObjetCoFourni from objetconnecte_fourni where idObjetConnecte = " + idObjetCo + " and idFournisseur = " + idFournisseur + " ;";
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
    }

    public struct connexionServeur
    {
        public static string connexion = "server=localhost;database=fournisseur_reconnect;user=root;pwd=";
    }
    

}