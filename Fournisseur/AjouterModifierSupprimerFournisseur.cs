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

namespace Fournisseurs_Reconnect
{
    public partial class AjouterModifierSupprimerFournisseur : Form
    {
        public AjouterModifierSupprimerFournisseur()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            if (textBoxNomFournisseur.TextLength > 150)
            {
                MessageBox.Show("Le nom du fournisseur est trop long !", "Impossible d'enregistrer le fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxNomFournisseur.TextLength == 0)
            {
                MessageBox.Show("Il faut renseigner un nom de fournisseur !", "Impossible d'enregistrer le fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int prochainId;
            string requeteProchainId = "SELECT COUNT(idFournisseur) from fournisseur;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlCommand cmdRequeteId = new MySqlCommand(requeteProchainId, conn);
            MySqlDataReader drID = cmdRequeteId.ExecuteReader();
            if (drID.Read()) 
            {
                prochainId = drID.GetInt32("Count(idFournisseur)") + 1;
                drID.Close();
                string requeteVerifId = "Select * from fournisseur order by idFournisseur DESC";

                MySqlCommand cmdVerifId = new MySqlCommand(requeteVerifId, conn);
                MySqlDataReader drVerifId = cmdVerifId.ExecuteReader();
                while (drVerifId.Read())
                {
                    if (drVerifId.GetUInt32("idFournisseur") == prochainId)
                    {
                        prochainId = prochainId - 1;
                    }
                    if (drVerifId.GetString("nomFournisseur") == textBoxNomFournisseur.Text)
                    {
                        MessageBox.Show("Il existe déjà un fournisseur portant ce nom", "Ajout de fournisseur impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                drVerifId.Close();
                string requeteFournisseur = "INSERT INTO `fournisseur` VALUES (" + prochainId + ",'" + textBoxNomFournisseur.Text + "','" + textBoxSite.Text + "');";
                MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
                MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
                MessageBox.Show("Le fournisseur à bien été ajouté");
                textBoxNomFournisseur.Clear();
                textBoxSite.Clear();
                conn.Close();
            }
        }

        private void boutonModifSupprimerFournisseur_Click(object sender, EventArgs e)
        {
            ModifierSupprimerFournisseur modifierSupprimerFournisseur = new ModifierSupprimerFournisseur();
            modifierSupprimerFournisseur.ShowDialog();
        }
    }
}
