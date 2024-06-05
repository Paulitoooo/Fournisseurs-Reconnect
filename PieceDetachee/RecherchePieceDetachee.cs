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

namespace Fournisseurs_Reconnect.PieceDetachee
{
    public partial class RecherchePieceDetachee : Form
    {
        int typeAppareilSelectionne = 0;
        int typePieceDetacheeSelectionne = 0;
        public RecherchePieceDetachee()
        {
            InitializeComponent();
        }

        private void RecherchePieceDetachee_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteMarque = "select * from marque ;";
            MySqlCommand cmdMarque = new MySqlCommand(requeteMarque, conn);
            MySqlDataReader drMarque = cmdMarque.ExecuteReader();
            while (drMarque.Read())
            {
                listeMarques.Items.Add(drMarque.GetString("nomMarque"));
            }
            drMarque.Close();
            string requeteTypeAppareil = "Select * from typeappareil;";
            MySqlCommand cmdTypeAppareil = new MySqlCommand(requeteTypeAppareil, conn);
            MySqlDataReader drTypeAppareil = cmdTypeAppareil.ExecuteReader();
            while (drTypeAppareil.Read())
            {
                listeTypeAppareil.Items.Add(drTypeAppareil.GetString("libelleTypeAppareil"));
            }
            drTypeAppareil.Close();

            conn.Close();
        }
        private void listeMarques_Click(object sender, EventArgs e)
        {
            listeAppareil.Items.Clear();
            listePieces.Items.Clear();
            if (listeMarques.Text == "")
            {
                return;
            }
            listeTypeAppareil.Enabled = true;

            if (typeAppareilSelectionne == 1)
            {
                string requeteAppareil = "select distinct modele from appareil where idMarqueAppareil = " + GetIdMarque(listeMarques.Text) + " and idTypeAppareil = " + GetIdTypeAppareil(listeTypeAppareil.Text) + " order by modele desc ;";
                MySqlConnection conn = new MySqlConnection(connexion);
                conn.Open();
                MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, conn);
                MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
                while (drAppareil.Read())
                {
                    listeAppareil.Items.Add(drAppareil.GetString("modele"));
                }
                drAppareil.Close();

                if (typePieceDetacheeSelectionne == 1)
                {
                    string requetePieceDetachee = "select nomPieceDetachee from piecedetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeTypePieceDetachee.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' ;";
                    MySqlCommand cmdPieceDetachee = new MySqlCommand(requetePieceDetachee, conn);
                    MySqlDataReader drPieceDetachee = cmdPieceDetachee.ExecuteReader();
                    while (drPieceDetachee.Read())
                    {
                        listePieces.Items.Add(drPieceDetachee.GetString("nomPieceDetachee"));
                    }
                    drPieceDetachee.Close();
                }
                conn.Close();
            }


        }

        private void listeTypeAppareil_Click(object sender, EventArgs e)
        {
            if (listeTypeAppareil.Text == "")
            {
                return;
            }
            listeAppareil.Items.Clear();
            listePieces.Items.Clear();
            listeTypePieceDetachee.Items.Clear();

            if (listeTypeAppareil.Text == "")
            {
                return;
            }
            typeAppareilSelectionne = 1;
            string requeteAppareil = "select distinct modele from appareil where idMarqueAppareil = " + GetIdMarque(listeMarques.Text) + " and idTypeAppareil = " + GetIdTypeAppareil(listeTypeAppareil.Text) + " order by modele desc ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, conn);
            MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
            while (drAppareil.Read())
            {
                listeAppareil.Items.Add(drAppareil.GetString("modele"));
            }
            drAppareil.Close();

            conn.Close();
        }

        private void listeAppareil_Click(object sender, EventArgs e)
        {
            listePieces.Items.Clear();
            listeTypePieceDetachee.Items.Clear();


            listeTypePieceDetachee.Enabled = true;
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteTypePieceDetachee = "select distinct libelleTypePiece from typepiecedetachee inner join piecedetachee on typepiecedetachee.idTypePieceDetachee = piecedetachee.idTypePieceDetachee where piecedetachee.nomModeleAppareil = '" + listeAppareil.Text + "' order by libelleTypePiece desc ;";
            MySqlCommand cmdTypePieceDetachee = new MySqlCommand(requeteTypePieceDetachee, conn);
            MySqlDataReader drTypePieceDetachee = cmdTypePieceDetachee.ExecuteReader();
            while (drTypePieceDetachee.Read())
            {
                listeTypePieceDetachee.Items.Add(drTypePieceDetachee.GetString("libelleTypePiece"));
            }
            drTypePieceDetachee.Close();
        }

        private void listeTypePieceDetachee_Click(object sender, EventArgs e)
        {
            listePieces.Items.Clear();

            typePieceDetacheeSelectionne = 1;
            string requetePieceDetachee = "select nomPieceDetachee from piecedetachee where idTypePieceDetachee = " + getIdTypePieceDetachee(listeTypePieceDetachee.Text) + " and nomModeleAppareil = '" + listeAppareil.Text + "' ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdPieceDetachee = new MySqlCommand(requetePieceDetachee, conn);
            MySqlDataReader drPieceDetachee = cmdPieceDetachee.ExecuteReader();
            while (drPieceDetachee.Read())
            {
                listePieces.Items.Add(drPieceDetachee.GetString("nomPieceDetachee"));
            }
            drPieceDetachee.Close();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int n = 0;
         List<Uri> listeSites = new List<Uri>();
         List<string> lesPrix = new List<string>();
         List<int> listeIdFournisseur = new List<int>();
        float prixActuel;
        int timer = 0;
        int idPiece;
        int idFournisseur;
        private void boutonRecherche_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lesPrix.Clear();
            listeSites.Clear();
            listeIdFournisseur.Clear();
            if (listePieces.Text == "")
            {
                MessageBox.Show("Il faut selectionner une pièce à rechercher !");
                return;
            }
            string requeteRecherche = "select * from piecedetachee_fournie where idPieceDetachee = " + getIdPieceDetachee(listePieces.Text, listeAppareil.Text) + " order by Prix;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdRecherche = new MySqlCommand(requeteRecherche, conn);
            MySqlDataReader drRecherche = cmdRecherche.ExecuteReader();
            while (drRecherche.Read())
            {
                lesPrix.Add(drRecherche.GetFloat("Prix").ToString());
                listeSites.Add(new Uri(drRecherche.GetString("sitePieceDetacheeFourni")));
                listeIdFournisseur.Add(drRecherche.GetInt32("idFournisseur"));
            }
            if (listeSites.Count == 0)
            {
                MessageBox.Show("Aucun fournisseur n'est affilié à cet appareil");
                return;
            }
            nbrFournisseur.Text = "Nombre de\r\n fournisseurs : " + listeSites.Count.ToString();
            webBrowser1.Url = listeSites[n];
            labelPrix.Text = lesPrix[n];
            flecheDroite.Enabled = true;
            flecheGauche.Enabled = true;
            idPiece = getIdPieceDetachee(listePieces.Text, listeAppareil.Text);
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

        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string leLien = linkLabelSite.Links[0].LinkData.ToString();
            System.Diagnostics.Process.Start(leLien);
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


                        string requetePrix = "update piecedetachee_fournie set Prix = " + labelPrix.Text + " where idFournisseur = " + listeIdFournisseur[n].ToString() + " and idPieceDetachee = " + getIdPieceDetachee(listePieces.Text,listeAppareil.Text) + " ;";
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
                catch(Exception ex)
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
    }
}