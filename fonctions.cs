﻿using MySql.Data.MySqlClient;
using HtmlAgilityPack;

namespace fonctions
{
    using Org.BouncyCastle.Asn1.Mozilla;
    using Org.BouncyCastle.Asn1.Ocsp;
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
            reader.Close();
            conn.Close();
            return id;

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
            reader.Close();
            conn.Close();
            return id;

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
                id = reader.GetInt32("idAppareil");
            }
            reader.Close();
            conn.Close();
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
            conn.Close();
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
            conn.Close();
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
            dr.Close();
            conn.Close();
            return lePrix;
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
            dr.Close();
            conn.Close();
            return leSite;
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
            dr.Close();
            conn.Close();
            return id;
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
            dr.Close();
            conn.Close();
            return id;
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
            dr.Close();
            conn.Close();
            return libelle;

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
            dr.Close();
            conn.Close();
            return nomMarque;

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
            dr.Close();
            conn.Close();
            return id;

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
            dr.Close();
            conn.Close();
            return modele;

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
            dr.Close();
            conn.Close();
            return lePrix;

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
            dr.Close();
            conn.Close();
            return leSite;

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
            dr.Close();
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
            dr.Close();
            conn.Close();
            return id;

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
            dr.Close();
            conn.Close();
            return id;

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
            dr.Close();
            conn.Close();
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
            dr.Close();
            conn.Close();
            return leSite;

        }

        public static int GetIdTypeAccessoire(string unType)
        {
            int id = 0;
            string requete = "select idTypeAccessoire from typeaccessoire where libelleTypeAccessoire = '" + unType + "' ;";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            dr.Close();
            conn.Close();
            return id;

        }

        public static string GetLibelleTypeAccessoire(int unId)
        {
            string libelle = "";
            string requete = "select libelleTypeAccessoire from typeaccessoire where idTypeAccessoire = " + unId + ";";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                libelle = dr.GetString(0);
            }
            dr.Close();
            conn.Close();
            return libelle;

        }

        public static int GetIdAccessoire(string uneMarque , string unType , string unAccessoire)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            int id = 0;
            string requete = "select idAccessoire from accessoire where idMarqueAccessoire = " + GetIdMarque(uneMarque) + " and idTypeAccessoire = " + GetIdTypeAccessoire(unType) + " and nomAccessoire = '" + unAccessoire + "' ;";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            dr.Close();
            conn.Close();
            return id;

        }

        public static float getPrixAccessoire(int idFournisseur,int idAccessoire)
        {
            float lePrix = 0F;
            string requete = "select Prix from accessoire_fourni where idFournisseur = " + idFournisseur + " and idAccessoire = " + idAccessoire + ";";
            MySqlConnection conn = new MySqlConnection("server = localhost; database = fournisseur_reconnect; user = root; pwd =");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lePrix = dr.GetFloat(0);
            }
            dr.Close();
            conn.Close();
            return lePrix;

        }

        public static string getSiteAccessoire(int idFournisseur , int idAccessoire)
        {
            string leSite = "";
            string requete = "select siteAccessoireFourni from accessoire_fourni where idFournisseur = " + idFournisseur + " and idAccessoire = " + idAccessoire + ";";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                leSite = dr.GetString(0);
            }
            dr.Close();
            conn.Close();
            return leSite;


        }

    }

    public struct connexionServeur
    {
        public static string connexion = "server=localhost;database=fournisseur_reconnect;user=root;pwd=";
    }
    

}
