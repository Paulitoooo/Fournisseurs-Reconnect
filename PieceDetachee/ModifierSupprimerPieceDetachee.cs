using Fournisseurs_Reconnect.PieceDetachee;
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

namespace Fournisseurs_Reconnect
{
    public partial class ModifierSupprimerPieceDetachee : Form
    {
        public ModifierSupprimerPieceDetachee()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static PieceDetachees pieceAModifier;
        private void ModifierSupprimerPieceDetachee_Load(object sender, EventArgs e)
        {
            string requeteType = "Select libelleTypePiece from typepiecedetachee;";
            MySqlConnection Conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            Conn.Open();
            MySqlCommand cmdType = new MySqlCommand(requeteType, Conn);
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeType.Items.Add(drType.GetString("libelleTypePiece"));
            }
            drType.Close();
            string requeteAppareil = "select distinct modele from appareil";
            MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, Conn);
            MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
            while (drAppareil.Read())
            {
                listeAppareil.Items.Add(drAppareil.GetString("modele"));
            }
            Conn.Close();
        }

        private void listeAppareil_Click(object sender, EventArgs e)
        {
            listeType.Enabled = true;
        }
        PieceDetachees pieceASupprimer;

        private void listeType_Click(object sender, EventArgs e)
        {
            listePieces.Enabled = true;
            string requetePiece = "Select * from piecedetachee where idTypePieceDetachee =" + getIdTypePieceDetachee(listeType.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' ;";
            MySqlConnection Conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            Conn.Open();
            MySqlCommand cmdPiece = new MySqlCommand(requetePiece, Conn);
            MySqlDataReader drPiece = cmdPiece.ExecuteReader();
            while (drPiece.Read())
            {
                listePieces.Items.Add(drPiece.GetString("nomPieceDetachee"));
            }
            Conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pieceASupprimer = new PieceDetachees(getIdPieceDetachee(listePieces.Text,listeAppareil.Text), getIdTypePieceDetachee(listeType.Text), listeAppareil.Text, listePieces.Text);
            string requeteSupprimer = "Delete from piecedetachee where idPieceDetachee = " + pieceASupprimer.getIdPieceDetachee() + " ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdSuppression = new MySqlCommand(requeteSupprimer, conn);
            
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment suppprimer la piece : " + pieceASupprimer.getNomPieceDetachee() + " ?", "", MessageBoxButtons.YesNo);
            if(dialogResult.Equals(DialogResult.Yes))
            {
                MySqlDataReader drSuppression = cmdSuppression.ExecuteReader();
                MessageBox.Show("La piece " + pieceASupprimer.getNomPieceDetachee() + " à bien été supprimée");
                listePieces.Items.Clear();
                drSuppression.Close();
                string requetePiece = "Select * from piecedetachee where idTypePieceDetachee =" + getIdTypePieceDetachee(listeType.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' ;";
                MySqlConnection Conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                Conn.Open();
                MySqlCommand cmdPiece = new MySqlCommand(requetePiece, Conn);
                MySqlDataReader drPiece = cmdPiece.ExecuteReader();
                while (drPiece.Read())
                {
                    listePieces.Items.Add(drPiece.GetString("nomPieceDetachee"));
                }
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pieceAModifier = new PieceDetachees(getIdPieceDetachee(listePieces.Text, listeAppareil.Text), getIdTypePieceDetachee(listeType.Text), listeAppareil.Text, listePieces.Text);
            ModifierPieceDetachee modifierPieceDetachee = new ModifierPieceDetachee();
            modifierPieceDetachee.ShowDialog();
        }
    }
}
