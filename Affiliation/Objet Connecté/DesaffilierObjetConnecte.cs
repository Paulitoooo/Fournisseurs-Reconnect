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
using static fonctions.connexionServeur;

namespace Fournisseurs_Reconnect.Affiliation.Objet_Connecté
{
    public partial class DesaffilierObjetConnecte : Form
    {
        public DesaffilierObjetConnecte()
        {
            InitializeComponent();
        }

        int typeSelectionne = 0;
        private void DesaffilierObjetConnecte_Load(object sender, EventArgs e)
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
            drFournisseur.Close();
            string requeteType = "select * from typeobjetco;";
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeTypeObjetCo.Items.Add(drType.GetString("libelleTypeObjetCo"));
            }
            drType.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listeFournisseur_Click(object sender, EventArgs e)
        {
            if(listeFournisseur.Text == "")
            {
                return;
            }
            listeMarque.Items.Clear();
            listeTypeObjetCo.SelectedItems.Clear();
            listeTypeObjetCo.Enabled = false;
            listeModele.Items.Clear();
            string requeteMarque = "select * from marque inner join objetconnecte on marque.idMarque = objetconnecte.idMarqueObjetCo inner join objetconnecte_fourni on objetconnecte.idObjetConnecte = objetconnecte_fourni.idObjetConnecte WHERE idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + ";";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdMarque = new MySqlCommand(requeteMarque, conn);
            MySqlDataReader drMarque = cmdMarque.ExecuteReader();
            while (drMarque.Read())
            {
                listeMarque.Items.Add(drMarque.GetString("nomMarque"));
            }

        }

        private void listeMarque_Click(object sender, EventArgs e)
        {
            listeTypeObjetCo.Enabled = true;
            if (typeSelectionne == 1)
            {
                listeModele.Items.Clear();
                string requeteModele = "select * from objetconnecte inner join objetconnecte_fourni on objetconnecte.idObjetConnecte = objetconnecte_fourni.idObjetConnecte where idMarqueObjetCo = " + GetIdMarque(listeMarque.Text) + " and idTypeObjetCo = " + GetIdTypeObjetCo(listeTypeObjetCo.Text) + " and idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " order by modeleObjetCo desc;";
                MySqlConnection conn = new MySqlConnection(connexion);
                conn.Open();
                MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
                MySqlDataReader drModele = cmdModele.ExecuteReader();
                while (drModele.Read())
                {
                    listeModele.Items.Add(drModele.GetString("modeleObjetCo"));
                }
                drModele.Close();
                conn.Close();
            }
        }

        private void listeTypeObjetCo_Click(object sender, EventArgs e)
        {
            listeModele.Items.Clear();
            string requeteModele = "select * from objetconnecte inner join objetconnecte_fourni on objetconnecte.idObjetConnecte = objetconnecte_fourni.idObjetConnecte where idMarqueObjetCo = " + GetIdMarque(listeMarque.Text) + " and idTypeObjetCo = " + GetIdTypeObjetCo(listeTypeObjetCo.Text) + " and idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " order by modeleObjetCo desc;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
            MySqlDataReader drModele = cmdModele.ExecuteReader();
            while (drModele.Read())
            {
                listeModele.Items.Add(drModele.GetString("modeleObjetCo"));
            }
            drModele.Close();
            conn.Close();
            typeSelectionne = 1;
        }

        private void boutonAffilier_Click(object sender, EventArgs e)
        {
            if (listeModele.Text == "" || listeFournisseur.Text == "")
            {
                MessageBox.Show("Il faut que tout les champs soient remplis !");
                return;
            }
            string requeteDesaffilier = "delete from objetconnecte_fourni where idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " and idObjetConnecte = " + GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text) + " ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdDesaffilier = new MySqlCommand(requeteDesaffilier, conn);
            MySqlDataReader drDesaffilier = cmdDesaffilier.ExecuteReader();
            MessageBox.Show("L'objet connecté " + listeModele.Text + " et le fournisseur " + listeFournisseur.Text + " ont bien désaffilier");
            drDesaffilier.Close();
            listeModele.Items.Clear();
            string requeteModele = "select * from objetconnecte inner join objetconnecte_fourni on objetconnecte.idObjetConnecte = objetconnecte_fourni.idObjetConnecte where idMarqueObjetCo = " + GetIdMarque(listeMarque.Text) + " and idTypeObjetCo = " + GetIdTypeObjetCo(listeTypeObjetCo.Text) + " and idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " order by modeleObjetCo desc;";
            MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
            MySqlDataReader drModele = cmdModele.ExecuteReader();
            while (drModele.Read())
            {
                listeModele.Items.Add(drModele.GetString("modeleObjetCo"));
            }
            drModele.Close();

            conn.Close();

        }
    }
}
