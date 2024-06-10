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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fournisseurs_Reconnect.Objet_connecté
{
    public partial class RechercheObjetConnecte : Form
    {
        public RechercheObjetConnecte()
        {
            InitializeComponent();
        }

        int typeSelectionne = 0;

        private void RechercheObjetConnecte_Load(object sender, EventArgs e)
        {
            string requeteMarque = "select * from marque order by nomMarque;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdMarque = new MySqlCommand(requeteMarque, conn);
            MySqlDataReader drMarque = cmdMarque.ExecuteReader();
            while (drMarque.Read())
            {
                listeMarque.Items.Add(drMarque.GetString("nomMarque"));
            }
            drMarque.Close();
            string requeteType = "select * from typeobjetco order by libelleTypeObjetCo;";
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeTypeObjetCo.Items.Add(drType.GetString("libelleTypeObjetCo"));
            }
            drType.Close();
            conn.Clone();

        }

        private void listeMarque_Click(object sender, EventArgs e)
        {
            listeModele.Items.Clear();
            listeTypeObjetCo.Enabled = true;
            if (typeSelectionne == 1)
            {
                string requeteModele = "select modeleObjetCo from objetconnecte where idMarqueObjetCo = " + GetIdMarque(listeMarque.Text) + " and idTypeObjetCo =" + GetIdTypeObjetCo(listeTypeObjetCo.Text) + " ; ";
                MySqlConnection conn = new MySqlConnection(connexion);
                conn.Open();
                MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
                MySqlDataReader drModele = cmdModele.ExecuteReader();
                while (drModele.Read())
                {
                    listeModele.Items.Add(drModele.GetString(0));
                }
                conn.Close();
                listeModele.Enabled = true;
            }

        }

        private void listeTypeObjetCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listeModele.Items.Clear();
            typeSelectionne = 1;
            string requeteModele = "select modeleObjetCo from objetconnecte where idMarqueObjetCo = " + GetIdMarque(listeMarque.Text) + " and idTypeObjetCo =" + GetIdTypeObjetCo(listeTypeObjetCo.Text) + " ; ";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
            MySqlDataReader drModele = cmdModele.ExecuteReader();
            while (drModele.Read())
            {
                listeModele.Items.Add(drModele.GetString(0));
            }
            conn.Close();
            listeModele.Enabled = true;

        }

        int n = 0;
        static List<Uri> listeSites = new List<Uri>();
        static List<string> lesPrix = new List<string>();
        static List<int> listeIdFournisseur = new List<int>();
        float prixActuel;
        int timer = 0;
        int idObjetCo;
        int idFournisseur;

        private void boutonRecherche_Click(object sender, EventArgs e)
        {
            linkLabelSite.Enabled = true;
            listeSites.Clear();
            lesPrix.Clear();
            listeIdFournisseur.Clear();
            int nombreFournisseur;
            timer = 0;
            string marqueSelectionnée = listeMarque.Text;
            string typeObjetCoSelectionné = listeTypeObjetCo.Text;
            string modeleSelectionné = listeModele.Text;
            if(marqueSelectionnée == "" || typeObjetCoSelectionné ==  "" || modeleSelectionné == "")
            {
                MessageBox.Show("Il faut selectionner un objet connecté !");
                return;

            }
            string requeteRecherche = "select * from objetconnecte_fourni where idObjetConnecte = " + GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text) + " order by Prix ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdRecherche = new MySqlCommand(requeteRecherche, conn);
            MySqlDataReader drRecherche = cmdRecherche.ExecuteReader();
            while (drRecherche.Read())
            {
                listeSites.Add(new Uri(drRecherche.GetString("siteObjetCoFourni")));
                lesPrix.Add(drRecherche.GetFloat("Prix").ToString());
                listeIdFournisseur.Add(drRecherche.GetInt32("idFournisseur"));
            }
            if (listeSites.Count == 0)
            {
                MessageBox.Show("Aucun fournisseur n'est affilié à cet objet connecté");
                return;
            }
            nbrFournisseur.Text = "Nombre de\r\n fournisseurs : " + listeSites.Count.ToString();
            webBrowser1.Url = listeSites[n];
            labelPrix.Text = lesPrix[n];
            flecheDroite.Enabled = true;
            flecheGauche.Enabled = true;
            idObjetCo = GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text);
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


                        string requetePrix = "update objetconnecte_fourni set Prix = " + float.Parse(labelPrix.Text) + " where idFournisseur = " + listeIdFournisseur[n] + " and idObjetConnecte = " + GetIdObjetConnecte(listeMarque.Text,listeTypeObjetCo.Text,listeModele.Text)  + " ;";
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

        private void linkLabelSite_LinkClicked(object sender, EventArgs e)
        {
            string leLien = linkLabelSite.Links[0].LinkData.ToString();
            System.Diagnostics.Process.Start(leLien);
        }
    }
}
