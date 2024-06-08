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
            string requeteRecherche = "select * from objetconnecte_fourni where idObjetConnecte = " + GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text) + "order by Prix ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdRecherche = new MySqlCommand(requeteRecherche, conn);
            MySqlDataReader drRecherche = cmdRecherche.ExecuteReader();
            while (drRecherche.Read())
            {
                listeSites.Add(new Uri(drRecherche.GetString("siteObjetCoFourni")));
                lesPrix.Add(drRecherche.GetFloat("Prix").ToString());
                listeIdFournisseur.Add()
            }
        }
    }
}
