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

namespace Fournisseurs_Reconnect.PieceDetachee
{
    public partial class AjouterSupprimerModifierTypePieceDetachee : Form
    {
        public AjouterSupprimerModifierTypePieceDetachee()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boutonValider_Click(object sender, EventArgs e)
        {
            if(textBoxLibelleType.Text == "")
            {
                MessageBox.Show("Il faut saisir un nom de type !");
                return;
            }
            int prochainId = 0;
            string requeteProchainId = "select count(idTypePieceDetachee) from typepiecedetachee ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdProchainID = new MySqlCommand(requeteProchainId, conn);
            MySqlDataReader drProchainId = cmdProchainID.ExecuteReader();
            if (drProchainId.Read())
            {
                prochainId = drProchainId.GetInt32("count(idTypePieceDetachee)") + 1;
                drProchainId.Close();
                string requeteVerifId = "select idTypePieceDetachee from typepiecedetachee order by idTypePieceDetachee desc";
                MySqlCommand cmdVerifId = new MySqlCommand(requeteVerifId, conn);
                MySqlDataReader drVerifId = cmdVerifId.ExecuteReader();
                while (drVerifId.Read())
                {
                    if(drVerifId.GetInt32("idTypePieceDetachee") == prochainId)
                    {
                        prochainId--;
                    }
                }
                drVerifId.Close();
            }
            string verifLibelle = "select * from typepiecedetachee";
            MySqlCommand cmdVerifLibelle = new MySqlCommand(verifLibelle, conn);
            MySqlDataReader drVerifLibelle = cmdVerifLibelle.ExecuteReader();
            while (drVerifLibelle.Read())
            {
                if(drVerifLibelle.GetString("libelleTypePiece") == textBoxLibelleType.Text)
                {
                    MessageBox.Show("Ce type de pièce détachée existe déjà !","AJout du type de pièce détachée impossible", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }
            drVerifLibelle.Close();
            string requeteAjout = "insert into typepiecedetachee values ( " + prochainId + " , '" + textBoxLibelleType.Text + "' );";
            MySqlCommand cmdAjout = new MySqlCommand(requeteAjout, conn);
            MySqlDataReader drAjout = cmdAjout.ExecuteReader();
            MessageBox.Show("Le type " + textBoxLibelleType.Text + " a bien été ajouté à la base de données");
            textBoxLibelleType.Clear();
            drAjout.Close();
            conn.Close();
        }

        private void boutonModifierSupprimer_Click(object sender, EventArgs e)
        {
            ModifierSupprimerTypePieceDetachee modifierSupprimerTypePieceDetachee = new ModifierSupprimerTypePieceDetachee();
            modifierSupprimerTypePieceDetachee.ShowDialog();
        }
    }
}
