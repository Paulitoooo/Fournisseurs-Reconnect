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
    public partial class AjouterModifierSupprimerAppareil : Form
    {
        public AjouterModifierSupprimerAppareil()
        {
            InitializeComponent();
        }

        private void boutonSupprimerMarque_Click(object sender, EventArgs e)
        {
            ModifierSupprimerApareil modifierSupprimerApareil = new ModifierSupprimerApareil();
            modifierSupprimerApareil.ShowDialog();
        }

        private void AjouterModifierSupprimerAppareil_Load(object sender, EventArgs e)
        {
            string requeteMarques = "SELECT * FROM marque;";
            string requeteType = "SELECT `libelleTypeAppareil` FROM `typeappareil`;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drMarques = cmdMarques.ExecuteReader();
            while (drMarques.Read())
            {
                this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
            }
            drMarques.Close();
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeTypes.Items.Add(drType.GetString("libelleTypeAppareil"));
            }
            drType.Close();
            conn.Close();

        }


        private void listeMarques_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listeMarques_Click(object sender, EventArgs e)
        {
            if (listeMarques.Text != "")
            {
                listeTypes.Enabled = true;
            }
        }

        private void listeTypes_Click(object sender, EventArgs e)
        {
            if (listeTypes.Text != "")
            {
                textBoxNomModèle.Enabled = true;
                textBoxStockage.Enabled = true;
            }
        }

        private void boutonEnregistrer_Click(object sender, EventArgs e)
        {
            if (textBoxNomModèle.Text == "")
            {
                MessageBox.Show("Il faut rensiegner un nom de modèle", "Ajout de l'appareil impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxStockage.Text == "")
            {
                MessageBox.Show("Il faut rensiegner un stockage", "Ajout de l'appareil impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int NeufOuReconditionné = 1;
            if (boutonNeuf.Checked)
            {
                NeufOuReconditionné = 1;
            }
            if (BoutonReconditionné.Checked)
            {
                NeufOuReconditionné = 0;
            }
            string requeteVerif = "select * from appareil;";
            int prochainId;
            string requeteId = "SELECT count(idAppareil) from appareil;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if(drVerif.GetString("modele") == textBoxNomModèle.Text && drVerif.GetUInt32("StockageAppareil").ToString() == textBoxStockage.Text && NeufOuReconditionné == drVerif.GetInt32("Neuf"))
                {
                    MessageBox.Show(textBoxNomModèle.Text + " " + textBoxStockage.Text + " existe déjà dans la base de données");
                    return;
                }
            }
            drVerif.Close();
            MySqlCommand mySqlCommandId = new MySqlCommand(requeteId, conn);
            MySqlDataReader drId = mySqlCommandId.ExecuteReader();
            if (drId.Read())
            {
                prochainId = drId.GetInt32("count(idAppareil)") + 1;
                drId.Close();
                string requeteVerifId = "Select idAppareil from appareil order by idAppareil DESC";

                MySqlCommand cmdVerifId = new MySqlCommand(requeteVerifId, conn);
                MySqlDataReader drVerifId = cmdVerifId.ExecuteReader();
                while (drVerifId.Read())
                {
                    if (drVerifId.GetUInt32("idAppareil") == prochainId)
                    {
                        prochainId = prochainId - 1;
                    }
                }
                drVerifId.Close();
                try
                {
                    string requeteAppareil = "INSERT INTO `appareil` VALUES (" + prochainId + ", '" + textBoxNomModèle.Text + "', (Select idMarque from marque where nomMarque = '" + listeMarques.Text + "') , (select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + listeTypes.Text + "') , " + textBoxStockage.Text + " , + " + NeufOuReconditionné + "); ";


                    MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, conn);
                    MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
                    MessageBox.Show("L'appareil a bien été ajouté à la base de données");
                    textBoxNomModèle.Clear();
                    textBoxStockage.Clear();
                    drAppareil.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veillez à ce que le stockage saisi soit un nombre");
                }
                conn.Close();
            }

        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
