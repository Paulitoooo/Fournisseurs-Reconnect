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
using static fonctions.connexionServeur;
using static fonctions.lesFonctions;

namespace Fournisseurs_Reconnect.Accessoires
{
    public partial class RechercheAccessoire : Form
    {
        public RechercheAccessoire()
        {
            InitializeComponent();
        }

        private void RechercheAccessoire_Load(object sender, EventArgs e)
        {
            
                MySqlConnection conn = new MySqlConnection(connexion);
                conn.Open();
                string requeteMarque = "select distinct idMarqueAccessoire from accessoire ;";
                MySqlCommand cmdMarque = new MySqlCommand(requeteMarque, conn);
                MySqlDataReader drMarque = cmdMarque.ExecuteReader();
                while (drMarque.Read())
                {
                    listeMarque.Items.Add(GetNomMarque(drMarque.GetInt32(0)));
                }
                drMarque.Close();
                conn.Close();
        }

        private void listeMarque_Click(object sender, EventArgs e)
            {
                listeType.Items.Clear();
                listeAccessoires.Items.Clear();
                MySqlConnection conn = new MySqlConnection(connexion);
                conn.Open();
                string requeteType = "select distinct idTypeAccessoire from accessoire where idMarqueAccessoire = " + GetIdMarque(listeMarque.Text) + ";";
                MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
                MySqlDataReader drType = cmdType.ExecuteReader();
                while (drType.Read())
                {
                    listeType.Items.Add(GetLibelleTypeAccessoire(drType.GetInt32(0)));
                }
                drType.Close();
                conn.Close();
            }

            private void listeType_SelectedIndexChanged(object sender, EventArgs e)
            {
                listeAccessoires.Items.Clear();
                MySqlConnection conn = new MySqlConnection(connexion);
                conn.Open();
                string requeteAccessoire = "select nomAccessoire from accessoire where idMarqueAccessoire = " + GetIdMarque(listeMarque.Text) + " and idTypeAccessoire = " + GetIdTypeAccessoire(listeType.Text) + " order by nomAccessoire;";
                MySqlCommand cmdAccessoire = new MySqlCommand(requeteAccessoire, conn);
                MySqlDataReader drAccessoire = cmdAccessoire.ExecuteReader();
                while (drAccessoire.Read())
                {
                    listeAccessoires.Items.Add(drAccessoire.GetString(0));
                }
                drAccessoire.Close();
                conn.Close();

            }

        int n = 0;
        static List<Uri> listeSites = new List<Uri>();
        static List<string> lesPrix = new List<string>();
        static List<int> listeIdFournisseur = new List<int>();
        float prixActuel;
        int timer = 0;
        int idAccessoire;
        int idFournisseur;

        private void boutonRecherche_Click(object sender, EventArgs e)
        {
            linkLabelSite.Enabled = true;
            progressBar1.Value = 0;
            listeSites.Clear();
            lesPrix.Clear();
            listeIdFournisseur.Clear();
            int nombreFournisseur;
            timer = 0;
            string marqueSelectionnée = listeMarque.Text;
            string typeAccessoireSelectionne = listeType.Text;
            string AccessoireSelectionné = listeAccessoires.Text;
            if (marqueSelectionnée == "" || typeAccessoireSelectionne == "" || AccessoireSelectionné == "")
            {
                MessageBox.Show("Il faut selectionner un accessoire !");
                return;

            }
            string requeteRecherche = " select * from accessoire_fourni where idAccessoire = " + GetIdAccessoire(listeMarque.Text, listeType.Text, listeAccessoires.Text) + " order by Prix ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdRecherche = new MySqlCommand(requeteRecherche, conn);
            MySqlDataReader drRecherche = cmdRecherche.ExecuteReader();
            while (drRecherche.Read())
            {
                listeSites.Add(new Uri(drRecherche.GetString("siteAccessoireFourni")));
                lesPrix.Add(drRecherche.GetFloat("Prix").ToString());
                listeIdFournisseur.Add(drRecherche.GetInt32("idFournisseur"));
            }
            if (listeSites.Count == 0)
            {
                MessageBox.Show("Aucun fournisseur n'est affilié à cet objet connecté");
                conn.Close();
                return;
            }
            nbrFournisseur.Text = "Nombre de\r\n fournisseurs : " + listeSites.Count.ToString();
            webBrowser1.Url = listeSites[n];
            labelPrix.Text = lesPrix[n];
            flecheDroite.Enabled = true;
            flecheGauche.Enabled = true;
            idAccessoire = GetIdObjetConnecte(listeMarque.Text, listeType.Text, listeAccessoires.Text);
            prixActuel = float.Parse(labelPrix.Text);
            idFournisseur = listeIdFournisseur[n];
            linkLabelSite.Links.Clear();
            linkLabelSite.Links.Add(0, 12, listeSites[n]);
            drRecherche.Close();
            conn.Close();
        }

        private void flecheDroite_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            int MaxN = listeSites.Count - 1;
            timer = 0;
            n++;
            if (n > MaxN)
            {
                n--;
                return;
            }
            webBrowser1.Url = listeSites[n];
            labelPrix.Text = lesPrix[n];
            idFournisseur = listeIdFournisseur[n];
            linkLabelSite.Links.Clear();
            linkLabelSite.Links.Add(0, 12, listeSites[n]);
        }

        private void flecheGauche_Click(object sender, EventArgs e)
        {
            n--;
            progressBar1.Value = 0;
            timer = 0;
            if (n < 0)
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


                        string requetePrix = "update accessoire_fourni set Prix = " + float.Parse(labelPrix.Text) + " where idFournisseur = " + listeIdFournisseur[n] + " and idAccessoire = " + GetIdAccessoire(listeMarque.Text, listeType.Text, listeAccessoires.Text) + " ;";
                        MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                        conn.Open();
                        progressBar1.Value = 25;
                        MySqlCommand cmdPrix = new MySqlCommand(requetePrix, conn);
                        progressBar1.Value = 50;
                        MySqlDataReader drPrix = cmdPrix.ExecuteReader();
                        progressBar1.Value = 75;
                        drPrix.Close();
                        conn.Close();
                        progressBar1.Value = 100;
                        timer1.Enabled = false;
                        labelPrix.ForeColor = Color.Green;
                        timer2.Enabled = true;
                        prixActuel = float.Parse(labelPrix.Text);




                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Il faut saisir un prix valide ! \n\rVeillez à ce que le prix saisi soit un nombre et que les centimes soient précédés d'un point et non pas d'une virgule");
                    MessageBox.Show(ex.Message);
                    timer1.Enabled = false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelPrix.ForeColor = Color.Black;
            timer2.Enabled = false;
        }

        private void labelPrix_TextChanged(object sender, EventArgs e)
        {
            if (timer < 1)
            {
                timer++;

            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void linkLabelSite_Click(object sender, EventArgs e)
        {
            string leLien = linkLabelSite.Links[0].LinkData.ToString();
            System.Diagnostics.Process.Start(leLien);
        }
    }
}

