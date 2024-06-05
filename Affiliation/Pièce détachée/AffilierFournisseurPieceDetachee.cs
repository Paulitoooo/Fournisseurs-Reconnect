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
using static fonctions.lesFonctions;

namespace Fournisseurs_Reconnect.Affiliation.Pièce_détachée
{
    public partial class AffilierFournisseurPieceDetachee : Form
    {
        public AffilierFournisseurPieceDetachee()
        {
            InitializeComponent();
        }

        int typeAppareilSelectionné = 0;
        int typePieceSelectionné = 0;
        private void AffilierFournisseurPieceDetachee_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteFournisseur = "Select * from fournisseur;";
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                listeFournisseur.Items.Add(drFournisseur.GetString("nomFournisseur"));
            }
            drFournisseur.Close();
            string requeteType = "Select libelleTypePiece from typepiecedetachee;";
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeType.Items.Add(drType.GetString("libelleTypePiece"));
            }
            drType.Close();
            
            string requeteMarques = "SELECT * FROM marque;";
            string requeteTypeAppareil = "SELECT `libelleTypeAppareil` FROM `typeappareil`;";
            MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
            MySqlCommand cmdTypeAppareil = new MySqlCommand(requeteTypeAppareil, conn);
            MySqlDataReader drMarques = cmdMarques.ExecuteReader();
            while (drMarques.Read())
            {
                this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
            }
            drMarques.Close();
            MySqlDataReader drTypeAppareil = cmdTypeAppareil.ExecuteReader();
            while (drTypeAppareil.Read())
            {
                listeTypeAppareil.Items.Add(drTypeAppareil.GetString("libelleTypeAppareil"));
            }
            conn.Close();


        }

        private void listeTypeAppareil_Click(object sender, EventArgs e)
        {
            listeAppareil.Items.Clear();
            if (listeTypeAppareil.Text == "")
            {
                return;
            }
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteAppareil = "select distinct modele from appareil where idMarqueAppareil = " + GetIdMarque(listeMarques.Text) + " and idTypeAppareil = " + GetIdTypeAppareil(listeTypeAppareil.Text) + " order by modele desc ;";
            MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, conn);
            MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
            while (drAppareil.Read())
            {
                listeAppareil.Items.Add(drAppareil.GetString("modele"));
            }
            typeAppareilSelectionné = 1;
            drAppareil.Close();
            conn.Close();


        }

        private void listeMarques_Click(object sender, EventArgs e)
        {
            listeAppareil.Items.Clear();
            listeTypeAppareil.Enabled = true;
            if (listeTypeAppareil.Text == "")
            {
                return;
            }
            if (typeAppareilSelectionné == 1)
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                conn.Open();
                string requeteAppareil = "select distinct modele from appareil where idMarqueAppareil = " + GetIdMarque(listeMarques.Text) + " and idTypeAppareil = " + GetIdTypeAppareil(listeTypeAppareil.Text) + " order by modele desc ;";
                MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, conn);
                MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
                while (drAppareil.Read())
                {
                    listeAppareil.Items.Add(drAppareil.GetString("modele"));
                }
                conn.Close();

            }

        }

        private void listeAppareil_Click(object sender, EventArgs e)
        {
            if(listeAppareil.Text == "")
            {
                return;
            }
            listeType.Enabled = true;
            if (typePieceSelectionné == 1)
            {
                listePieces.Items.Clear();
                string requetePiece = "Select * from piecedetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeType.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' order by nomPieceDetachee desc ;";
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                conn.Open();
                MySqlCommand cmdPiece = new MySqlCommand(requetePiece, conn);
                MySqlDataReader drPiece = cmdPiece.ExecuteReader();
                while (drPiece.Read())
                {
                    listePieces.Items.Add(drPiece.GetString("nomPieceDetachee"));
                }
                conn.Close();
            }
        }

        private void listeType_Click(object sender, EventArgs e)
        {
            if(listeType.Text == "")
            {
                return;
            }
            typePieceSelectionné = 1;
            listePieces.Items.Clear();
            string requetePiece = "Select * from piecedetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeType.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' order by nomPieceDetachee desc ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdPiece = new MySqlCommand(requetePiece, conn);
            MySqlDataReader drPiece = cmdPiece.ExecuteReader();
            while (drPiece.Read())
            {
                listePieces.Items.Add(drPiece.GetString("nomPieceDetachee"));
            }
            conn.Close();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listeFournisseur_Click(object sender, EventArgs e)
        {
            textBoxPrix.Enabled = true;
            siteFournisseur.Enabled = true;
        }

        private void boutonAffilier_Click(object sender, EventArgs e)
        {
            if(listePieces.Text=="" || listeFournisseur.Text == "" || textBoxPrix.Text=="" || siteFournisseur.Text =="")
            {
                MessageBox.Show("Il faut reseigner une piece et un fournisseur ainsi que son site et son prix !");
                return;
            }
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteVerif = "select * from piecedetachee_fournie";
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if(drVerif.GetInt32("idFournisseur") == GetIdFournisseur(listeFournisseur.Text) && drVerif.GetInt32("idPieceDetachee") == getIdPieceDetachee(listePieces.Text, listeAppareil.Text))
                {
                    MessageBox.Show("La pièce détachée " + listePieces.Text + " pour " + listeAppareil.Text + " et le fournisseur " + listeFournisseur.Text + " sont déjà affiliés");
                    return;
                }
            }
            drVerif.Close();
            string requeteAffiliation = "Insert into piecedetachee_fournie values( " + GetIdFournisseur(listeFournisseur.Text) + ", " + getIdPieceDetachee(listePieces.Text, listeAppareil.Text) + ", " + textBoxPrix.Text + ", '" + siteFournisseur.Text + "' );";
            MySqlCommand cmdAffiliation = new MySqlCommand(requeteAffiliation, conn);
            try
            {
                MySqlDataReader drAffilitation = cmdAffiliation.ExecuteReader();
                MessageBox.Show("La pièce " + listePieces.Text + " et le fournisseur " + listeFournisseur.Text + " ont bien été affiliés");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Il faut saisir un prix valide ! \n\rVeillez à ce que le prix saisi soit un nombre et que les centimes soient précédés d'un point et non pas d'une virgule");
            }
            conn.Close();
        }
    }
}
