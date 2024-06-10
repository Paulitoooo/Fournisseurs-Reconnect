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

            string requeteFournisseur = "Select * from fournisseur;";
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                string leFournisseur = GetNomFournisseur(drFournisseur.GetInt32("idFournisseur"));
                listeFournisseur.Items.Add(leFournisseur);
            }

            
            conn.Close();
        }

        int leTypeEstSelectionné = 0;

        private void listeMarques_Click(object sender, EventArgs e)
        {
            listeModèles.Items.Clear();
            listeTailleStockage.Items.Clear();
            if (listeMarques.Text == "")
            {
                return;
            }
            string typeSelectionné;
            if (leTypeEstSelectionné == 1)
            {
                typeSelectionné = listeType.Text;
                string marqueSelectionnée = listeMarques.Text;
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
            leTypeEstSelectionné = 1;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            if (listeType.Text == "")
            {
                return;
            }
            string marqueSelectionnée = listeMarques.Text;


            string typeSelectionné = listeType.Text;
            string requeteModeles = "SELECT distinct modele FROM appareil inner join marque on appareil.idMarqueAppareil " +
                "= marque.idMarque inner join appareil_fourni on appareil.idAppareil = appareil_fourni.idAppareil WHERE idMarqueAppareil = " +
                    "(SELECT marque.idMarque from marque where marque.nomMarque ='" + marqueSelectionnée + "') and idTypeAppareil = (Select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + typeSelectionné + "'  ) and idFournisseur = " + GetIdFournisseur(listeFournisseur.Text)+ " order by modele desc;";
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
            boutonNeuf.Checked = false;
            BoutonReconditionné.Checked = false;
            
        }

        private void listeTailleStockage_Click(object sender, EventArgs e)
        {
            if (listeTailleStockage.Text == "")
            {
                return;
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
            conn.Close();
            listeFournisseur.ClearSelected();
            listeMarques.Items.Clear();
            listeType.Items.Clear();
            listeModèles.Items.Clear();
            listeTailleStockage.Items.Clear();
            boutonNeuf.Checked = false;
            BoutonReconditionné.Checked = false;

        }

        private void boutonNeuf_CheckedChanged(object sender, EventArgs e)
        {
            listeTailleStockage.Items.Clear();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string typeSelectionné = listeType.Text;
            string modèleSelectionné = listeModèles.Text;
            string requeteTailleStockage = "Select StockageAppareil from appareil inner join appareil_fourni on appareil.idAppareil = appareil_fourni.idAppareil where modele='" + modèleSelectionné + "' and Neuf = 1 and idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " ;";
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
            string requeteTailleStockage = "Select StockageAppareil from appareil inner join appareil_fourni on appareil.idAppareil = appareil_fourni.idAppareil where modele='" + modèleSelectionné + "' and Neuf = 0  and idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " ;";
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

        private void listeFournisseur_Click(object sender, EventArgs e)
        {
            listeMarques.Items.Clear();
            listeType.Items.Clear();
            listeModèles.Items.Clear();
            boutonNeuf.Checked = false;
            BoutonReconditionné.Checked = false;
            listeTailleStockage.Items.Clear();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteMarques = "SELECT DISTINCT appareil.idMarqueAppareil FROM appareil_fourni inner join appareil on appareil_fourni.idAppareil = appareil.idAppareil where idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " ;";
            string requeteType = "SELECT `libelleTypeAppareil` FROM `typeappareil`;";
            MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drMarques = cmdMarques.ExecuteReader();
            while (drMarques.Read())
            {
                this.listeMarques.Items.Add(GetNomMarque( drMarques.GetInt32("idMarqueAppareil")));
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
    }
}
