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
    public partial class ModifierSupprimerApareil : Form
    {
        public ModifierSupprimerApareil()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool typeSelectionné = false;
        public string laMarqueSelectionnée;
        public string leTypeSelectionné;
        public string leModeleSelectionné;
        public string leStockageSelectionné;
        private void AjouterModifierSupprimerApareil_Load(object sender, EventArgs e)
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

        private void listeMarques_Click(object sender, EventArgs e)
        {
            boutonModifier.Enabled = false;
            boutonSupprimer.Enabled = false;
            if (listeMarques.Text != "")
            {
                listeTypes.Enabled = true;
            }
            if (typeSelectionné)
            {
                listeAppareils.Items.Clear();
                listeStockage.Items.Clear();
                string requeteModele = "Select distinct modele from appareil where idMarqueAppareil = (select idMarque from marque where nomMarque = '" + listeMarques.Text + "') and idTypeAppareil = (select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + listeTypes.Text + "');";
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                conn.Open();
                MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
                MySqlDataReader drModele = cmdModele.ExecuteReader();
                while (drModele.Read())
                {
                    listeAppareils.Items.Add(drModele.GetString("modele"));
                }
                drModele.Close();
                conn.Close();
            }

        }

        private void listeTypes_Click(object sender, EventArgs e)
        {
            boutonModifier.Enabled = false;
            boutonSupprimer.Enabled = false;
            listeAppareils.Items.Clear();
            listeStockage.Items.Clear();
            typeSelectionné = true;
            string requeteModele = "Select distinct modele from appareil where idMarqueAppareil = (select idMarque from marque where nomMarque = '" + listeMarques.Text + "') and idTypeAppareil = (select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + listeTypes.Text + "');";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
            MySqlDataReader drModele = cmdModele.ExecuteReader();
            while (drModele.Read())
            {
                listeAppareils.Items.Add(drModele.GetString("modele"));
            }
            if(listeTypes.Text != "")
            {
                listeAppareils.Enabled = true;
            }
            drModele.Close();
            conn.Close();
        }

        private void listeAppareils_Click(object sender, EventArgs e)
        {
            boutonModifier.Enabled = false;
            boutonSupprimer.Enabled = false;
            listeStockage.Items.Clear();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string typeSelectionné = listeTypes.Text;
            string modèleSelectionné = listeAppareils.Text;
            string requeteTailleStockage = "Select StockageAppareil from appareil where modele='" + modèleSelectionné + "';";
            MySqlCommand cmdTailleStockage = new MySqlCommand(requeteTailleStockage, conn);
            MySqlDataReader drTailleStockage = cmdTailleStockage.ExecuteReader();
            while (drTailleStockage.Read())
            {
                listeStockage.Items.Add(drTailleStockage.GetUInt32("StockageAppareil"));
            }
            listeStockage.Enabled = true;
            drTailleStockage.Close();
            conn.Close();
        }

        private void listeStockage_Click(object sender, EventArgs e)
        {
            boutonModifier.Enabled = true;
            boutonSupprimer.Enabled = true;
            
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            leModeleSelectionné = listeAppareils.Text;
            leStockageSelectionné = listeStockage.Text;
            leTypeSelectionné = listeTypes.Text;
            laMarqueSelectionnée = listeMarques.Text;

        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            leModeleSelectionné = listeAppareils.Text;
            leStockageSelectionné = listeStockage.Text;
            leTypeSelectionné = "( Select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + listeTypes.Text + "' )";
            laMarqueSelectionnée = "( Select idMarque from marque where nomMarque = '" + listeMarques.Text + "')";
            string idAppareil = "(Select idAppareil where modele = '" + leModeleSelectionné + "' and StockageAppareil = " + leStockageSelectionné + " and idTypeAppareil = " + leTypeSelectionné + " and idMarqueAppareil = " + laMarqueSelectionnée + " )";
            string requeteSupprimer = "Delete from appareil where idAppareil = " + idAppareil + ";";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdSupprimer = new MySqlCommand(requeteSupprimer, conn);
            MySqlDataReader drSupprimer = cmdSupprimer.ExecuteReader();
            MessageBox.Show("L'appareil " + leModeleSelectionné + " a bien été supprimé");
            drSupprimer.Close();
            conn.Close();
            listeAppareils.Items.Clear();
            listeStockage.Items.Clear();
        }
    }
    }
