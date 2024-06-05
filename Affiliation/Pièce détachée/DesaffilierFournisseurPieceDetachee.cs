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
    public partial class DesaffilierFournisseurPieceDetachee : Form
    {
        public DesaffilierFournisseurPieceDetachee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int typeAppareilSelectionne = 0;
        int typePieceDetacheeSelectionne = 0;

        private void DesaffilierFournisseurPieceDetachee_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteFournisseur = "select * from fournisseur ;";
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur  = cmdFournisseur.ExecuteReader();
            while(drFournisseur.Read())
            {
                listeFournisseur.Items.Add(drFournisseur.GetString("nomFournisseur"));
            }
            drFournisseur.Close();
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

        private void listeTypeAppareil_Click(object sender, EventArgs e)
        {
            listeAppareil.Items.Clear();
            listePieces.Items.Clear();
            listeTypePieceDetachee.Items.Clear();
            if (listeTypeAppareil.Text == "")
            {
                return;
            }
            typeAppareilSelectionne = 1;
            string requeteAppareil = "select distinct modele from piecedetachee inner join appareil on piecedetachee.nomModeleAppareil = appareil.modele inner join marque on appareil.idMarqueAppareil = marque.idMarque INNER join piecedetachee_fournie on piecedetachee_fournie.idPieceDetachee = piecedetachee.idPieceDetachee INNER JOIN fournisseur on piecedetachee_fournie.idFournisseur = fournisseur.idFournisseur where idMarqueAppareil = " + GetIdMarque(listeMarques.Text) + " and idTypeAppareil = " + GetIdTypeAppareil(listeTypeAppareil.Text) + " and fournisseur.IdFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " order by modele desc ;";
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

        private void listeMarques_Click(object sender, EventArgs e)
        {
            listeAppareil.Items.Clear();
            listePieces.Items.Clear();
            if (listeMarques.Text == "")
            {
                return;
            }
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
                if(typePieceDetacheeSelectionne == 1)
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
            listeTypeAppareil.Enabled = true;

        }

        private void listeTypePieceDetachee_Click(object sender, EventArgs e)
        {
            listePieces.Items.Clear();
            typePieceDetacheeSelectionne = 1;
            string requetePieceDetachee = "select nomPieceDetachee from piecedetachee inner join piecedetachee_fournie on piecedetachee.idPieceDetachee = piecedetachee_fournie.idPieceDetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeTypePieceDetachee.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' and idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " ;";
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

        private void listeAppareil_Click(object sender, EventArgs e)
        {
            listePieces.Items.Clear();
            listeTypePieceDetachee.Items.Clear();
            listeTypePieceDetachee.Enabled = true;
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteTypePieceDetachee = "select distinct libelleTypePiece from typepiecedetachee inner join piecedetachee on typepiecedetachee.idTypePieceDetachee = piecedetachee.idTypePieceDetachee inner join piecedetachee_fournie on piecedetachee_fournie.idPieceDetachee = piecedetachee.idPieceDetachee where piecedetachee.nomModeleAppareil = '" + listeAppareil.Text + "' and piecedetachee_fournie.idFournisseur =" + GetIdFournisseur(listeFournisseur.Text) + " order by libelleTypePiece desc ;";
            MySqlCommand cmdTypePieceDetachee = new MySqlCommand(requeteTypePieceDetachee, conn);
            MySqlDataReader drTypePieceDetachee = cmdTypePieceDetachee.ExecuteReader();
            while (drTypePieceDetachee.Read())
            {
                listeTypePieceDetachee.Items.Add(drTypePieceDetachee.GetString("libelleTypePiece"));
            }
            drTypePieceDetachee.Close();
            conn.Close();

        }

        private void boutonDesaffilier_Click(object sender, EventArgs e)
        {
            if (listeFournisseur.Text == "" || listePieces.Text == "")
            {
                MessageBox.Show("Il faut selectionner un fournisseur et une pièce détachée");
            }
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteDesaffiliation = "delete from piecedetachee_fournie where idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " and idPieceDetachee = " + getIdPieceDetachee(listePieces.Text, listeAppareil.Text) + " ;";
            MySqlCommand cmdDesaffiliation = new MySqlCommand(requeteDesaffiliation, conn);
            try
            {
                MySqlDataReader drDesaffiliation = cmdDesaffiliation.ExecuteReader();
                MessageBox.Show("La piece détachée " + listePieces.Text + " et le fournisseur " + listeFournisseur.Text + " ont bien été désaffiliés");
                listeMarques.Items.Clear();
                listeTypeAppareil.Enabled = false;
                listeAppareil.Items.Clear();
                listeTypePieceDetachee.Items.Clear();
                listePieces.Items.Clear();
                drDesaffiliation.Close();
                string requeteMarque = "select distinct nomMarque from piecedetachee inner join  appareil on piecedetachee.nomModeleAppareil = appareil.modele inner join marque on appareil.idMarqueAppareil = marque.idMarque INNER join piecedetachee_fournie on piecedetachee_fournie.idPieceDetachee = piecedetachee.idPieceDetachee INNER JOIN fournisseur on piecedetachee_fournie.idFournisseur = fournisseur.idFournisseur where fournisseur.idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " ;";
                MySqlCommand cmdMarque = new MySqlCommand(requeteMarque, conn);
                MySqlDataReader drMarque = cmdMarque.ExecuteReader();
                while (drMarque.Read())
                {
                    listeMarques.Items.Add(drMarque.GetString("nomMarque"));
                }
                drMarque.Close();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("La pièce détachée " + listePieces.Text + " et le fournisseur " + listeFournisseur.Text + "ne sont pas affiliés");
                return;
            }
            conn.Close();


        }

        private void listeFournisseur_Click(object sender, EventArgs e)
        {
            listeMarques.Items.Clear();
            listeTypeAppareil.ClearSelected();
            listeTypeAppareil.Enabled = false;
            listeAppareil.Items.Clear();
            listeTypePieceDetachee.Items.Clear();
            listePieces.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteMarque = "select distinct nomMarque from piecedetachee inner join  appareil on piecedetachee.nomModeleAppareil = appareil.modele inner join marque on appareil.idMarqueAppareil = marque.idMarque INNER join piecedetachee_fournie on piecedetachee_fournie.idPieceDetachee = piecedetachee.idPieceDetachee INNER JOIN fournisseur on piecedetachee_fournie.idFournisseur = fournisseur.idFournisseur where fournisseur.idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " ;";
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

        }
    }
}
