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
    public partial class SupprimerMarque : Form
    {
        public SupprimerMarque()
        {
            InitializeComponent();
        }

        private void SupprimerMarque_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteMarques = "SELECT * FROM marque;";
            MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
            MySqlDataReader drMarques = cmdMarques.ExecuteReader();
            while (drMarques.Read())
            {
                this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
            }
            drMarques.Close();

        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            int compteurSecurite = 0;
            string marqueASupprimer = listeMarques.Text;
            string requeteSupprimer = "DELETE FROM `marque` WHERE idMarque = (select idMarque where nomMarque = '" + marqueASupprimer + "');";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn.Open();
                string requeteSecurité = "SELECT count(appareil.idAppareil) from appareil WHERE appareil.idMarqueAppareil = (SELECT marque.idMarque from marque where marque.nomMarque = '" + marqueASupprimer + "');";
                MySqlCommand cmdSecurite = new MySqlCommand(requeteSecurité, conn);
                MySqlDataReader rdSecurite = cmdSecurite.ExecuteReader();
                if(rdSecurite.Read())
                {
                    compteurSecurite += rdSecurite.GetInt32("count(appareil.idAppareil)");
                }
                rdSecurite.Close();
                requeteSecurité = "SELECT count(objetconnecte.idObjetConnecte) from objetconnecte WHERE objetconnecte.idMarqueObjetCo = (SELECT marque.idMarque from marque where marque.nomMarque = '" + marqueASupprimer + "');";
                MySqlCommand cmdSecurite2 = new MySqlCommand(requeteSecurité, conn);
                rdSecurite = cmdSecurite2.ExecuteReader();
                if (rdSecurite.Read())
                {
                    compteurSecurite += rdSecurite.GetInt32("count(objetconnecte.idObjetConnecte)");
                }
                rdSecurite.Close();
                requeteSecurité = "SELECT COUNT(accessoire.idAccessoire) from accessoire WHERE idMarqueAccessoire = (SELECT marque.idMarque from marque where marque.nomMarque = '" + marqueASupprimer + "');";
                MySqlCommand cmdSecurite3 = new MySqlCommand(requeteSecurité, conn);
                rdSecurite = cmdSecurite3.ExecuteReader();
                if (rdSecurite.Read())
                {
                    compteurSecurite += rdSecurite.GetInt32("COUNT(accessoire.idAccessoire)");
                }
                rdSecurite.Close();
                if (compteurSecurite > 0)
                {
                    MessageBox.Show("Impossible de supprimer la marque car des appareils/accessoires/objets connectés y sont associés. Veuillez supprimer ces dernier pour supprimer la marque","Erreur de suppression",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer la marque " + marqueASupprimer + " ?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand cmdSuppresionMarque = new MySqlCommand(requeteSupprimer, conn);
                    MySqlDataReader drSuppresionMarque = cmdSuppresionMarque.ExecuteReader();
                    MessageBox.Show("La marque a bien été supprimée");
                    drSuppresionMarque.Close();
                }
                else
                {
                    return;
                }
                this.listeMarques.Items.Clear();
                string requeteMarques = "SELECT * FROM marque;";
                MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
                MySqlDataReader drMarques = cmdMarques.ExecuteReader();
                while (drMarques.Read())
                {
                    this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
                }
                drMarques.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
