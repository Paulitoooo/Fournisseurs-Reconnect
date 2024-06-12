using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using MySql.Data.MySqlClient;
using Fournisseurs_Reconnect.Appareil;
using static fonctions.lesFonctions;
using Fournisseurs_Reconnect.Fournisseur;
using System.Collections;
using System.CodeDom;

namespace Fournisseurs_Reconnect.Affiliation
{
    public partial class AffilierFournisseurAppareil : Form
    {
        public AffilierFournisseurAppareil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.apple.com/fr/shop/buy-iphone/iphone-15/%C3%A9cran-de-6,1-pouces-128go-noir";
            HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            IEnumerable<HtmlNode> nodes = doc.DocumentNode.Descendants().Where(n => n.HasClass("rc-prices-fullprice"));
            foreach(var item in nodes)
            {
                MessageBox.Show(item.InnerText);
            }
            
            

        }

        private void AffilierFournisseurAppareil_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteMarques = "SELECT * FROM marque;";
            string requeteType = "SELECT `libelleTypeAppareil` FROM `typeappareil`;";
            string requeteFournisseur = "Select * from fournisseur;";
            MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
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
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                listeFournisseur.Items.Add(drFournisseur.GetString("nomFournisseur"));
            }
            drFournisseur.Close();
            conn.Close();
        }

        int leTypeEstSelectionné = 0;
        int NeufOuReconditionné = 1;
        private void listeMarques_Click(object sender, EventArgs e)
        {
            listeModèles.Items.Clear();
            listeTailleStockage.Items.Clear();
            string typeSelectionné;
            if (leTypeEstSelectionné == 1)
            {
                typeSelectionné = listeType.SelectedItem.ToString();
                string marqueSelectionnée = listeMarques.SelectedItem.ToString();
                string requeteModeles = "SELECT distinct modele FROM appareil inner join marque on appareil.idMarqueAppareil " +
                   "= marque.idMarque WHERE idMarqueAppareil = " +
                   "(SELECT marque.idMarque from marque where marque.nomMarque ='" + marqueSelectionnée + "') " +
                   "and idTypeAppareil = (Select idTypeAppareil from typeappareil " +
                   "where libelleTypeAppareil = '" + typeSelectionné + "') order by modele desc ;";
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

            string marqueSelectionnée = listeMarques.SelectedItem.ToString();


            string typeSelectionné = listeType.SelectedItem.ToString();
            string requeteModeles = "SELECT distinct modele FROM appareil inner join marque on appareil.idMarqueAppareil " +
                "= marque.idMarque WHERE idMarqueAppareil = " +
                    "(SELECT marque.idMarque from marque where marque.nomMarque ='" + marqueSelectionnée + "') and idTypeAppareil = (Select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + typeSelectionné + "') order by modele desc ;";
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
            listeTailleStockage.Items.Clear();
            boutonNeuf.Checked = false;
            BoutonReconditionné.Checked = false;
            
        }

        private void boutonAffilier_Click(object sender, EventArgs e)
        {
            if(listeMarques.Text =="" || listeModèles.Text == "" || listeTailleStockage.Text == "" || listeType.Text == "" || (boutonNeuf.Checked == false && BoutonReconditionné.Checked == false) )
            {
                MessageBox.Show("Il faut selectionner un appareil !");
                return;
            }
            if(listeFournisseur.Text == "" || siteFournisseur.Text == "")
            {
                MessageBox.Show("Il faut renseigner un fournisseur et son site !");
                return;
            }
            Appareils appareilsAffilié = new Appareils(GetIdAppareil(listeModèles.Text, listeMarques.Text, listeType.Text, Int32.Parse(listeTailleStockage.Text),NeufOuReconditionné),
                listeModèles.Text,
                GetIdMarque(listeMarques.Text),
                GetIdTypeAppareil(listeType.Text),
                Int32.Parse(listeTailleStockage.Text),
                true);
            Fournisseurs fournisseurAffilié = new Fournisseurs(GetIdFournisseur(listeFournisseur.Text),
                listeFournisseur.Text,
                siteFournisseur.Text);
            string lePrix = "0";
            try
            {
                lePrix = textBoxPrix.Text;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
                return;
            }
            string requeteAffilierAppareil = "insert into appareil_fourni values " +
                "(" + fournisseurAffilié.getIdFournisseur() + ", "
                + appareilsAffilié.getIdAppareil() + ", " 
                + lePrix + ", '" 
                + fournisseurAffilié.getSiteFournisseur() + "');";
            string requeteVerif = "Select * from appareil_fourni;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdFournisseurAppareil = new MySqlCommand(requeteAffilierAppareil, conn);
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if (drVerif.GetUInt32("idAppareil") == appareilsAffilié.getIdAppareil() && drVerif.GetUInt32("idFournisseur") == fournisseurAffilié.getIdFournisseur())
                {
                    MessageBox.Show("Ce fournisseur et cet appareil sont déjà associés", "Affiliation impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }
            }
            drVerif.Close();
            try
            {
                MySqlDataReader drFournisseur = cmdFournisseurAppareil.ExecuteReader();
                MessageBox.Show("Le fournisseur et l'appareil ont bien été assignés");
            }
            catch
            {
                MessageBox.Show("Il faut saisir un prix valide ! \n\rVeillez à ce que le prix saisi soit un nombre et que les centimes soient précédés d'un point et non pas d'une virgule");
            }
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
