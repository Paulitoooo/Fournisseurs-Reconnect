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
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
using static fonctions.lesFonctions;

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
            listeType.Enabled = true;

        }

        private void listeModèles_Click(object sender, EventArgs e)
        {
            listeTailleStockage.Items.Clear();
            boutonNeuf.Checked = false;
            BoutonReconditionné.Checked = false;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            
        }

        int NeufOuReconditionné;
        int  n = 0;
        static List<Uri> listeSites = new List<Uri>();
        static List<string> lesPrix = new List<string>();
        static List<int> listeIdFournisseur = new List<int>();
        float prixActuel;
        int timer = 0;
        int idAppareil;
        int idFournisseur;

        private void boutonRecherche_Click(object sender, EventArgs e)
        {
            lesPrix.Clear();
            listeSites.Clear();
            listeIdFournisseur.Clear();
            int nombreFournisseur = 0;
            timer = 0;
            if (boutonNeuf.Checked)
            {
                NeufOuReconditionné = 1;
            }
            if (BoutonReconditionné.Checked)
            {
                NeufOuReconditionné = 0;
            }
            string marqueSelectionnée = listeMarques.Text;
                string modèleSelectionné = listeModèles.Text;
                string stockageSelectionné = listeTailleStockage.Text;
            if(marqueSelectionnée == "" || modèleSelectionné == "" || stockageSelectionné == "" || listeType.Text == "")
            {
                MessageBox.Show("Il faut selectionner un appareil !");
                return;
            }
            string requeteFinale = "SELECT * from appareil_fourni" +
                    " inner join appareil on appareil_fourni.idAppareil = appareil.idAppareil" +
                    " where appareil.idMarqueAppareil = (SELECT `idMarque` from marque where nomMarque ='" +
                    marqueSelectionnée + "') and appareil.modele = '" + modèleSelectionné + "' and appareil.StockageAppareil =" +
                    stockageSelectionné + " and appareil.Neuf =" + NeufOuReconditionné + " order by Prix;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdFinale = new MySqlCommand(requeteFinale, conn);
            MySqlDataReader drFinal = cmdFinale.ExecuteReader();


            while (drFinal.Read())

                {

                //MessageBox.Show(drFinal.GetUInt32("Prix") + " " + drFinal.GetString("siteAppareilFourni"));
                string unPrix = drFinal.GetFloat("Prix").ToString();
                linkLabelSite.Text = "Lien du site";
                linkLabelSite.Links.Clear();
                    //string lienSite = drFinal.GetString("siteAppareilFourni");
                    //System.Diagnostics.Process.Start(lienSite);
                string siteAppareilFourni = drFinal.GetString("siteAppareilFourni");
                listeSites.Add(new Uri(siteAppareilFourni));
                lesPrix.Add(unPrix);
                listeIdFournisseur.Add(drFinal.GetInt32("idFournisseur"));
                 

                    


                }
            if (listeSites.Count == 0)
            {
                MessageBox.Show("Aucun fournisseur n'est affilié à cet appareil");
                return;
            }
            nbrFournisseur.Text = "Nombre de\r\n fournisseurs : " + listeSites.Count.ToString();
            webBrowser1.Url = listeSites[n];
            labelPrix.Text = lesPrix[n] ;
            flecheDroite.Enabled = true;
            flecheGauche.Enabled = true;
            prixActuel = float.Parse(labelPrix.Text);
            idAppareil = GetIdAppareil(listeModèles.Text, listeMarques.Text, listeType.Text, Int32.Parse(listeTailleStockage.Text), NeufOuReconditionné);
            idFournisseur = listeIdFournisseur[n];
            linkLabelSite.Links.Clear();
            linkLabelSite.Links.Add(0, 12, listeSites[n]);



            drFinal.Close();
                conn.Close();
            
            
            
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

        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start();
            string leLien = linkLabelSite.Links[0].LinkData.ToString();
            System.Diagnostics.Process.Start(leLien);
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flecheDroite_Click(object sender, EventArgs e)
        {
            int MaxN = listeSites.Count - 1;
            timer = 0;
            n++;
            if (n > MaxN)
            {
                n--;
                return;
            }
            webBrowser1.Url = listeSites[n];
            labelPrix.Text = lesPrix[n] ;
            idFournisseur = listeIdFournisseur[n];
            linkLabelSite.Links.Clear();
            linkLabelSite.Links.Add(0, 12, listeSites[n]);
        }

        private void flecheGauche_Click(object sender, EventArgs e)
        {
            n--;
            timer = 0;
            if(n< 0)
            {
                n++;
                return;
            }
            webBrowser1.Url = listeSites[n];
            labelPrix.Text = lesPrix[n];
            idFournisseur = listeIdFournisseur[n];
            linkLabelSite.Links.Clear();
            linkLabelSite.Links.Add(0, 12, listeSites[n]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelPrix.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    if (prixActuel != float.Parse(labelPrix.Text))
                    {


                        string requetePrix = "Update appareil_fourni set Prix = " + labelPrix.Text + " where idAppareil = " + idAppareil + " and idFournisseur = " + listeIdFournisseur[n] + " ;";
                        MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                        conn.Open();
                        MySqlCommand cmdPrix = new MySqlCommand(requetePrix, conn);
                        MySqlDataReader drPrix = cmdPrix.ExecuteReader();
                        drPrix.Close();
                        conn.Close();
                        timer1.Enabled = false;
                        labelPrix.ForeColor = Color.Green;
                        timer2.Enabled = true;
                        prixActuel = float.Parse(labelPrix.Text);




                    }
                }
                catch
                {
                    MessageBox.Show("Il faut saisir un prix valide ! \n\rVeillez à ce que le prix saisi soit un nombre et que les centimes soient précédés d'un point et non pas d'une virgule");
                    timer1.Enabled = false;
                }
            }
        }

        private void labelPrix_TextChanged(object sender, EventArgs e)
        {
            if(timer < 1)
            {
                timer++;

            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelPrix.ForeColor = Color.Black;
            timer2.Enabled = false;
        }

        private void boutonNeuf_CheckedChanged(object sender, EventArgs e)
        {
            if (boutonNeuf.Checked)
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
                conn.Close();
            }
        }

        private void BoutonReconditionné_CheckedChanged(object sender, EventArgs e)
        {
            if (BoutonReconditionné.Checked)
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
                conn.Close();
            }
        }
    }
    }