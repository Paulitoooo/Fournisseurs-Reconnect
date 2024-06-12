using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static fonctions.connexionServeur;
using static fonctions.lesFonctions;

namespace Fournisseurs_Reconnect.Affiliation.Pièce_détachée
{
    public partial class ModifierAffiliationPieceDetachee : Form
    {
        public ModifierAffiliationPieceDetachee()
        {
            InitializeComponent();
        }

        int typeAppareilSelectionne = 0;
        int typePieceDetacheeSelectionne = 0;

        private void ModifierAffiliationPieceDetachee_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteMarque = "select * from marque ;";
            MySqlCommand cmdMarque = new MySqlCommand(requeteMarque, conn);
            MySqlDataReader drMarque = cmdMarque.ExecuteReader();
            while (drMarque.Read())
            {
                listeMarques.Items.Add(drMarque.GetString("nomMarque"));
            }
            drMarque.Close();
            string requeteTypeAppareil = "Select * from typeappareil;";
            MySqlCommand cmdTypeAppareil = new MySqlCommand(requeteTypeAppareil, conn);
            MySqlDataReader drTypeAppareil = cmdTypeAppareil.ExecuteReader();
            while (drTypeAppareil.Read())
            {
                listeTypeAppareil.Items.Add(drTypeAppareil.GetString("libelleTypeAppareil"));
            }
            drTypeAppareil.Close();

            conn.Close();
        }

        private void listeMarques_Click(object sender, EventArgs e)
        {
            listeAppareil.Items.Clear();
            listePieces.Items.Clear();
            listeFournisseur.Items.Clear();

            if (listeMarques.Text == "")
            {
                return;
            }
            listeTypeAppareil.Enabled = true;

            if (typeAppareilSelectionne == 1)
            {
                string requeteAppareil = "select distinct modele from appareil where idMarqueAppareil = " + GetIdMarque(listeMarques.Text) + " and idTypeAppareil = " + GetIdTypeAppareil(listeTypeAppareil.Text) + " order by modele desc ;";
                MySqlConnection conn = new MySqlConnection(connexion);
                conn.Open();
                MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, conn);
                MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
                while (drAppareil.Read())
                {
                    listeAppareil.Items.Add(drAppareil.GetString("modele"));
                }
                drAppareil.Close();

                if (typePieceDetacheeSelectionne == 1)
                {
                    string requetePieceDetachee = "select nomPieceDetachee from piecedetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeTypePieceDetachee.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' ;";
                    MySqlCommand cmdPieceDetachee = new MySqlCommand(requetePieceDetachee, conn);
                    MySqlDataReader drPieceDetachee = cmdPieceDetachee.ExecuteReader();
                    while (drPieceDetachee.Read())
                    {
                        listePieces.Items.Add(drPieceDetachee.GetString("nomPieceDetachee"));
                    }
                    drPieceDetachee.Close();
                }
                conn.Close();
            }
            
            
        }

        private void listeTypeAppareil_Click(object sender, EventArgs e)
        {
            if(listeTypeAppareil.Text == "")
            {
                return;
            }
            listeAppareil.Items.Clear();
            listePieces.Items.Clear();
            listeTypePieceDetachee.Items.Clear();
            listeFournisseur.Items.Clear();

            if (listeTypeAppareil.Text == "")
            {
                return;
            }
            typeAppareilSelectionne = 1;
            string requeteAppareil = "select distinct modele from appareil where idMarqueAppareil = " + GetIdMarque(listeMarques.Text) + " and idTypeAppareil = " + GetIdTypeAppareil(listeTypeAppareil.Text) + " order by modele desc ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, conn);
            MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
            while (drAppareil.Read())
            {
                listeAppareil.Items.Add(drAppareil.GetString("modele"));
            }
            drAppareil.Close();

            conn.Close();
        }

        private void listeAppareil_Click(object sender, EventArgs e)
        {
            listePieces.Items.Clear();
            listeTypePieceDetachee.Items.Clear();
            listeFournisseur.Items.Clear();

            listeTypePieceDetachee.Enabled = true;
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteTypePieceDetachee = "select distinct libelleTypePiece from typepiecedetachee inner join piecedetachee on typepiecedetachee.idTypePieceDetachee = piecedetachee.idTypePieceDetachee where piecedetachee.nomModeleAppareil = '" + listeAppareil.Text + "' order by libelleTypePiece desc ;";
            MySqlCommand cmdTypePieceDetachee = new MySqlCommand(requeteTypePieceDetachee, conn);
            MySqlDataReader drTypePieceDetachee = cmdTypePieceDetachee.ExecuteReader();
            while (drTypePieceDetachee.Read())
            {
                listeTypePieceDetachee.Items.Add(drTypePieceDetachee.GetString("libelleTypePiece"));
            }
            drTypePieceDetachee.Close();
            conn.Close();
        }

        private void listeTypePieceDetachee_Click(object sender, EventArgs e)
        {
            listePieces.Items.Clear();
            listeFournisseur.Items.Clear();

            typePieceDetacheeSelectionne = 1;
            string requetePieceDetachee = "select nomPieceDetachee from piecedetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeTypePieceDetachee.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdPieceDetachee = new MySqlCommand(requetePieceDetachee, conn);
            MySqlDataReader drPieceDetachee = cmdPieceDetachee.ExecuteReader();
            while (drPieceDetachee.Read())
            {
                listePieces.Items.Add(drPieceDetachee.GetString("nomPieceDetachee"));
            }
            drPieceDetachee.Close();
            conn.Close();
        }

        private void listePieces_Click(object sender, EventArgs e)
        {
            listeFournisseur.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteFournisseur = "select * from fournisseur inner join piecedetachee_fournie on piecedetachee_fournie.idFournisseur = fournisseur.idFournisseur where idPieceDetachee = " + getIdPieceDetachee(listePieces.Text,listeAppareil.Text) + " ;";
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                listeFournisseur.Items.Add(drFournisseur.GetString("nomFournisseur"));
            }
            drFournisseur.Close();
            conn.Close();

        }

        public static PieceDetacheeFournie pieceDetacheeAModif;
        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(listeFournisseur.Text==""|| listePieces.Text == "")
            {
                MessageBox.Show("Il faut renseigner un fournisseur et une pièce détachée !");
                return;
            }
            pieceDetacheeAModif = new PieceDetacheeFournie(new Fournisseur.Fournisseurs(GetIdFournisseur(listeFournisseur.Text), listeFournisseur.Text), new PieceDetachees(getIdPieceDetachee(listePieces.Text, listeAppareil.Text), getIdTypePieceDetachee(listeTypePieceDetachee.Text), listeAppareil.Text, listePieces.Text),getPrixPieceDetacheeFournie(getIdPieceDetachee(listePieces.Text,listeAppareil.Text),GetIdFournisseur(listeFournisseur.Text)),getSitePieceDetacheeFournie(getIdPieceDetachee(listePieces.Text, listeAppareil.Text), GetIdFournisseur(listeFournisseur.Text)));
            laModificationnAffiliationPieceDetachee laModificationnAffiliationPieceDetachee = new laModificationnAffiliationPieceDetachee();
            laModificationnAffiliationPieceDetachee.ShowDialog();
        }
    }
}
