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


namespace Fournisseurs_Reconnect.Affiliation.Objet_Connecté
{
    public partial class AffilierObjetConnecte : Form
    {
        public AffilierObjetConnecte()
        {
            InitializeComponent();
        }

        int typeSelectionne = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AffilierObjetConnecte_Load(object sender, EventArgs e)
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
            string requeteFournisseur = "Select * from fournisseur order by nomFournisseur;";
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                listeFournisseur.Items.Add(drFournisseur.GetString("nomFournisseur"));
            }
            drFournisseur.Close();
            conn.Clone();
        }

        private void listeMarque_Click(object sender, EventArgs e)
        {
            if (listeMarque.Text == "")
            {
                return;
            }
            listeModele.Items.Clear();
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

            listeTypeObjetCo.Enabled = true;
        }

        private void listeTypeObjetCo_Click(object sender, EventArgs e)
        {
            if (listeTypeObjetCo.Text == "")
            {
                return;
            }
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

        private void boutonAffilier_Click(object sender, EventArgs e)
        {
            if(listeModele.Text == "" || listeFournisseur.Text =="" || textBoxPrix.Text == "" || siteFournisseur.Text == "")
            {
                MessageBox.Show("Il faut que tout les champs soient complétés !");
                return;
            }

            string requeteAffilier = "insert into objetconnecte_fourni values(" + GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text) + "," + GetIdFournisseur(listeFournisseur.Text) + "," + textBoxPrix.Text + ",'" + siteFournisseur.Text + "')";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteVerif = "select * from objetconnecte_fourni;";
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if(drVerif.GetInt32("idObjetConnecte") == GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text) && drVerif.GetInt32("idFournisseur")== GetIdFournisseur(listeFournisseur.Text)) 
                {
                    MessageBox.Show("Cet objet connecté et ce fournisseur sont déjà affilié !");
                    return;
                }
            }
            drVerif.Close();
            MySqlCommand cmdAffiliation = new MySqlCommand(requeteAffilier, conn);
            try
            {
                MySqlDataReader drAffiliation = cmdAffiliation.ExecuteReader();
                MessageBox.Show("L'objet connecté " + listeModele.Text + " et le fournisseur " + listeFournisseur.Text + " ont bien été affiliés");
                drAffiliation.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Il faut saisir un prix valide ! \n\rVeillez à ce que le prix saisi soit un nombre et que les centimes soient précédés d'un point et non pas d'une virgule");
            }
            conn.Close();
        }

        private void listeFournisseur_Click(object sender, EventArgs e)
        {
            if (listeFournisseur.Text == "")
            {
                return;
            }
            textBoxPrix.Enabled = true;
            siteFournisseur.Enabled = true;
        }
    }
}
