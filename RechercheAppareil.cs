using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;

namespace Fournisseurs_Reconnect
{
    public partial class RechercheAppareil : Form
    {
        public RechercheAppareil()
        {
            InitializeComponent();
        }


        private void RechercheAppareil_Load(object sender, EventArgs e)
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
            conn.Close();
            

        }

        int leTypeEstSelectionné = 0;
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
                   "where libelleTypeAppareil = '" + typeSelectionné + "');";
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
            listeType.Enabled = true;

        }

        private void listeModèles_Click(object sender, EventArgs e)
        {
            listeTailleStockage.Items.Clear();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string typeSelectionné = listeType.SelectedItem.ToString();
            string modèleSelectionné = listeModèles.SelectedItem.ToString();
            string requeteTailleStockage = "Select StockageAppareil from appareil where modele='" + modèleSelectionné + "';";
            MySqlCommand cmdTailleStockage = new MySqlCommand(requeteTailleStockage, conn);
            MySqlDataReader drTailleStockage = cmdTailleStockage.ExecuteReader();
            while (drTailleStockage.Read())
            {
                listeTailleStockage.Items.Add(drTailleStockage.GetUInt32("StockageAppareil"));
            }
            listeTailleStockage.Enabled = true;
            conn.Close();
        }

        int NeufOuReconditionné;

        private void boutonRecherche_Click(object sender, EventArgs e)
        {
            if (boutonNeuf.Checked)
            {
                NeufOuReconditionné = 1;
            }
            if (BoutonReconditionné.Checked)
            {
                NeufOuReconditionné = 0;
            }
            LinkLabel linkLabel2 = new LinkLabel();
            linkLabel2.Text = "test";
            linkLabel2.Location = new System.Drawing.Point(562, 187);
            linkLabel2.AutoSize = true;
            try
            {
                string marqueSelectionnée = listeMarques.Text;
                string modèleSelectionné = listeModèles.Text;
                string stockageSelectionné = listeTailleStockage.Text;
                string requeteFinale = "SELECT `Prix` , `siteAppareilFourni` from appareil_fourni" +
                    " inner join appareil on appareil_fourni.idAppareil = appareil.idAppareil" +
                    " where appareil.idMarqueAppareil = (SELECT `idMarque` from marque where nomMarque ='" +
                    marqueSelectionnée + "') and appareil.modele = '" + modèleSelectionné + "' and appareil.StockageAppareil =" +
                    stockageSelectionné + " and appareil.Neuf =" + NeufOuReconditionné + ";";
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                conn.Open();
                MySqlCommand cmdFinale = new MySqlCommand(requeteFinale, conn);
                MySqlDataReader drFinal = cmdFinale.ExecuteReader();
                

                if (drFinal.Read())
                {
                    //MessageBox.Show(drFinal.GetUInt32("Prix") + " " + drFinal.GetString("siteAppareilFourni"));
                    labelPrix.Text = drFinal.GetUInt32("Prix").ToString() + " €";
                    linkLabelSite.Links.Add(0,3,"www.microsoft.com");
                    //string lienSite = drFinal.GetString("siteAppareilFourni");
                    //System.Diagnostics.Process.Start(lienSite);
                    

                    


                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Il faut renseigner les paramètres","Recherche impossible",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
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
                    "(SELECT marque.idMarque from marque where marque.nomMarque ='" + marqueSelectionnée + "') and idTypeAppareil = (Select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + typeSelectionné + "');";
            MySqlCommand cmdModele = new MySqlCommand(requeteModeles, conn);
            MySqlDataReader drModele = cmdModele.ExecuteReader();
            while (drModele.Read())
            {
                listeModèles.Items.Add(drModele.GetString("modele"));
            }
            listeModèles.Enabled = true;
            
            
            conn.Close();
        }

        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start();

        }
    }
}
