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
using Fournisseurs_Reconnect.Appareil;
using Fournisseurs_Reconnect.Fournisseur;

namespace Fournisseurs_Reconnect.Affiliation
{
    public partial class DesaffilierFournisseurAppareil : Form
    {
        public DesaffilierFournisseurAppareil()
        {
            InitializeComponent();
        }

        static int NeufOuReconditionné = 1;
        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DesaffilierFournisseurAppareil_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteMarques = "SELECT * FROM marque;";
            string requeteType = "SELECT `libelleTypeAppareil` FROM `typeappareil`;";
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
                listeType.Items.Add(drType.GetString("libelleTypeAppareil"));
            }
            drType.Close();
            conn.Close();
        }

        int leTypeEstSelectionné = 0;

        private void listeMarques_Click(object sender, EventArgs e)
        {
            listeModèles.Items.Clear();
            listeTailleStockage.Items.Clear();
            listeFournisseur.Items.Clear();
            if (listeMarques.Text == "")
            {
                return;
            }
            string typeSelectionné;
            if (leTypeEstSelectionné == 1)
            {
                typeSelectionné = listeType.SelectedItem.ToString();
                string marqueSelectionnée = listeMarques.SelectedItem.ToString();
                string requeteModeles = "SELECT distinct modele FROM appareil inner join marque on appareil.idMarqueAppareil " +
                   "= marque.idMarque WHERE idMarqueAppareil = " +
                   "(SELECT marque.idMarque from marque where marque.nomMarque ='" + marqueSelectionnée + "') " +
                   "and idTypeAppareil = (Select idTypeAppareil from typeappareil " +
                   "where libelleTypeAppareil = '" + typeSelectionné + "' ) order by modele desc ;";
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                conn.Open();
                MySqlCommand cmdModele = new MySqlCommand(requeteModeles, conn);
                MySqlDataReader drModele = cmdModele.ExecuteReader();
                while (drModele.Read())
                {
                    listeModèles.Items.Add(drModele.GetString("modele"));
                }
                conn.Close();
            }
            if (listeMarques.SelectedItem != "")
            {
                listeType.Enabled = true;
            }
        }

        private void listeType_Click(object sender, EventArgs e)
        {
            listeModèles.Items.Clear();
            listeTailleStockage.Items.Clear();
            listeFournisseur.Items.Clear();
            leTypeEstSelectionné = 1;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            if (listeType.Text == "")
            {
                return;
            }
            string marqueSelectionnée = listeMarques.SelectedItem.ToString();


            string typeSelectionné = listeType.SelectedItem.ToString();
            string requeteModeles = "SELECT distinct modele FROM appareil inner join marque on appareil.idMarqueAppareil " +
                "= marque.idMarque WHERE idMarqueAppareil = " +
                    "(SELECT marque.idMarque from marque where marque.nomMarque ='" + marqueSelectionnée + "') and idTypeAppareil = (Select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + typeSelectionné + "'  ) order by modele desc;";
            MySqlCommand cmdModele = new MySqlCommand(requeteModeles, conn);
            MySqlDataReader drModele = cmdModele.ExecuteReader();
            while (drModele.Read())
            {
                listeModèles.Items.Add(drModele.GetString("modele"));
            }
            listeModèles.Enabled = true;


            conn.Close();
        }

        private void listeModèles_Click(object sender, EventArgs e)
        {
            if (listeModèles.Text == "")
            {
                return;
            }
            listeTailleStockage.Items.Clear();
            listeFournisseur.Items.Clear();
            boutonNeuf.Checked = false;
            BoutonReconditionné.Checked = false;
            
        }

        private void listeTailleStockage_Click(object sender, EventArgs e)
        {
            listeFournisseur.Items.Clear();
            if (listeTailleStockage.Text == "")
            {
                return;
            }
            string requeteFournisseur = "Select * from appareil_fourni where idAppareil =" + fonctions.lesFonctions.GetIdAppareil(listeModèles.Text, listeMarques.Text, listeType.Text, Int32.Parse(listeTailleStockage.Text), NeufOuReconditionné) + " ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                string leFournisseur = GetNomFournisseur(drFournisseur.GetInt32("idFournisseur"));
                listeFournisseur.Items.Add(leFournisseur);
            }
        }

        private void boutonAffilier_Click(object sender, EventArgs e)
        {
            if (listeMarques.Text == "" || listeModèles.Text == "" || listeTailleStockage.Text == "" || listeType.Text == "")
            {
                MessageBox.Show("Il faut selectionner un appareil !");
                return;
            }

            if(listeFournisseur.Text == "")
            {
                MessageBox.Show("Il faut selectionner un fourniseur !");
                return;
            }

            string requeteDesaffilier = "Delete from appareil_fourni where idAppareil =" + GetIdAppareil(listeModèles.Text, listeMarques.Text, listeType.Text, Int32.Parse(listeTailleStockage.Text), NeufOuReconditionné) + " and idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdDesaffilier = new MySqlCommand(requeteDesaffilier, conn);
            MySqlDataReader drDesaffilier = cmdDesaffilier.ExecuteReader();
            string NR = "";
            if(NeufOuReconditionné == 1)
            {
                NR = " neuf ";
            }
            else
            {
                NR = " d'occasion ";
            }
            MessageBox.Show("L'appareil " + listeModèles.Text + " " + listeTailleStockage.Text + " Go" + NR +"et le fournisseur " + listeFournisseur.Text + " ont bien été désaffiliés .");
            drDesaffilier.Close();
            listeFournisseur.Items.Clear();
            string requeteFournisseur = "Select * from appareil_fourni where idAppareil =" + fonctions.lesFonctions.GetIdAppareil(listeModèles.Text, listeMarques.Text, listeType.Text, Int32.Parse(listeTailleStockage.Text), NeufOuReconditionné) + " ;";
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                string leFournisseur = GetNomFournisseur(drFournisseur.GetInt32("idFournisseur"));
                listeFournisseur.Items.Add(leFournisseur);
            }
            drFournisseur.Close();
            conn.Close();

        }

        private void boutonNeuf_CheckedChanged(object sender, EventArgs e)
        {
            listeTailleStockage.Items.Clear();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string typeSelectionné = listeType.Text;
            string modèleSelectionné = listeModèles.Text;
            string requeteTailleStockage = "Select StockageAppareil from appareil where modele='" + modèleSelectionné + "' and Neuf = 1;";
            MySqlCommand cmdTailleStockage = new MySqlCommand(requeteTailleStockage, conn);
            MySqlDataReader drTailleStockage = cmdTailleStockage.ExecuteReader();
            while (drTailleStockage.Read())
            {
                listeTailleStockage.Items.Add(drTailleStockage.GetUInt32("StockageAppareil"));
            }
            listeTailleStockage.Enabled = true;
            NeufOuReconditionné = 1;
            conn.Close();
        }

        private void BoutonReconditionné_CheckedChanged(object sender, EventArgs e)
        {
            listeTailleStockage.Items.Clear();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string typeSelectionné = listeType.Text;
            string modèleSelectionné = listeModèles.Text;
            string requeteTailleStockage = "Select StockageAppareil from appareil where modele='" + modèleSelectionné + "' and Neuf = 0;";
            MySqlCommand cmdTailleStockage = new MySqlCommand(requeteTailleStockage, conn);
            MySqlDataReader drTailleStockage = cmdTailleStockage.ExecuteReader();
            while (drTailleStockage.Read())
            {
                listeTailleStockage.Items.Add(drTailleStockage.GetUInt32("StockageAppareil"));
            }
            listeTailleStockage.Enabled = true;
            NeufOuReconditionné = 0;
            conn.Close();
        }
    }
}
