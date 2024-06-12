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

namespace Fournisseurs_Reconnect.PieceDetachee
{
    public partial class ModifierSupprimerTypePieceDetachee : Form
    {
        public ModifierSupprimerTypePieceDetachee()
        {
            InitializeComponent();
        }

        public static TypePieceDetachee typeAModif;
        private void ModifierSupprimerTypePieceDetachee_Load(object sender, EventArgs e)
        {
            string requeteListeType = "Select * from typepiecedetachee";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdLsiteType = new MySqlCommand(requeteListeType, conn);
            MySqlDataReader drListeType = cmdLsiteType.ExecuteReader();
            while (drListeType.Read())
            {
                listeType.Items.Add(drListeType.GetString("libelleTypePiece"));
            }
            conn.Close();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            string requeteSuppression = "Delete from typepiecedetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeType.Text) + " ;";
            if(listeType.Text == "")
            {
                MessageBox.Show("Il faut selectionner un type !");
                    return;
            }
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            int compteurSécurité = 0;
            string requeteSecurite = "select * from piecedetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeType.Text) + " ;";
            MySqlCommand cmdSecurite = new MySqlCommand(requeteSecurite, conn);
            MySqlDataReader drSecurite = cmdSecurite.ExecuteReader();
            while (drSecurite.Read())
            {
                compteurSécurité++;
            }
            drSecurite.Close();
            if(compteurSécurité> 0)
            {
                MessageBox.Show("Impossible de supprimer ce type car des pièces détachées sont déjà assoiciées à ce type . Veuillez d'abord les supprimer .", "Suppression de type de piece détachée impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conn.Close();
                return;
            }
            MySqlCommand cmdSuppression = new MySqlCommand(requeteSuppression, conn);
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer le type " + listeType.Text + " ?", "", MessageBoxButtons.YesNo);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                MySqlDataReader drSuppression = cmdSuppression.ExecuteReader();
                MessageBox.Show("Le type " + listeType.Text + " a bien été  supprimé");
                drSuppression.Close();
            }
            listeType.Items.Clear();
            string requeteListeType = "Select * from typepiecedetachee";
            MySqlCommand cmdLsiteType = new MySqlCommand(requeteListeType, conn);
            MySqlDataReader drListeType = cmdLsiteType.ExecuteReader();
            while (drListeType.Read())
            {
                listeType.Items.Add(drListeType.GetString("libelleTypePiece"));
            }
            drListeType.Close();
            conn.Close();
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if (listeType.Text == "")
            {
                MessageBox.Show("Il faut selectionner un type !");
                return;
            }
            typeAModif = new TypePieceDetachee(getIdTypePieceDetachee(listeType.Text), listeType.Text);
            ModifierTypePieceDetachee modaifierTypePieceDetachee = new ModifierTypePieceDetachee();
            modaifierTypePieceDetachee.ShowDialog();
            listeType.Items.Clear();
            string requeteListeType = "Select * from typepiecedetachee";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdLsiteType = new MySqlCommand(requeteListeType, conn);
            MySqlDataReader drListeType = cmdLsiteType.ExecuteReader();
            while (drListeType.Read())
            {
                listeType.Items.Add(drListeType.GetString("libelleTypePiece"));
            }
            conn.Close();
        }
    }
}
