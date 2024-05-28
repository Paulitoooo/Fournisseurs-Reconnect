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
    public partial class AjouterModifierSupprimerPieceDetachee : Form
    {
        public AjouterModifierSupprimerPieceDetachee()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterModifierSupprimerPieceDetachee_Load(object sender, EventArgs e)
        {
            string requeteType = "Select libelleTypePiece from typepiecedetachee;";
            MySqlConnection Conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            Conn.Open();
            MySqlCommand cmdType = new MySqlCommand(requeteType, Conn);
            MySqlDataReader drType = cmdType.ExecuteReader();
            while(drType.Read())
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

        private void boutonAjouter_Click(object sender, EventArgs e)
        {
            if(textBoxNomPiece.Text =="" || listeType.Text == "" || listeAppareil.Text == "")
            {
                MessageBox.Show("Il faut que tout les champs soient rempli !");
                return;
            }
            int leProchainId = 0;
            string prochainId = "Select count(idPieceDetachee) from piecedetachee";
            MySqlConnection Conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            Conn.Open();
            MySqlCommand cmdProchainId = new MySqlCommand(prochainId, Conn);
            MySqlDataReader drProchainId = cmdProchainId.ExecuteReader();
            if (drProchainId.Read())
            {
                leProchainId = drProchainId.GetInt32("count(idPieceDetachee)") + 1;
                drProchainId.Close();
                string requeteVerifId = "Select idPieceDetachee from piecedetachee order by idPieceDetachee desc;";
                MySqlCommand cmdVerifId = new MySqlCommand(requeteVerifId, Conn);
                MySqlDataReader drVerifId = cmdVerifId.ExecuteReader();
                while (drVerifId.Read())
                {

                    if (drVerifId.GetUInt32(0) == leProchainId)
                    {:
                        leProchainId--;
                    }
                }
                drVerifId.Close();
            }
            drProchainId.Close();
            string ajouter = "insert into piecedetachee values(" + leProchainId + ", " + getIdTypePieceDetachee(listeType.Text) + " , '" + listeAppareil.Text + "' , '" + textBoxNomPiece.Text + "' )";
            MySqlCommand cmdAjouter = new MySqlCommand(ajouter, Conn);
            MySqlDataReader drAjouter = cmdAjouter.ExecuteReader();
            MessageBox.Show("La piece détachée à bien été ajoutée");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifierSupprimerPieceDetachee modifierSupprimerPieceDetachee = new ModifierSupprimerPieceDetachee();
            modifierSupprimerPieceDetachee.ShowDialog();
        }
    }
}
