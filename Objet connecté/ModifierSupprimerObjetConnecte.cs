using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static fonctions.connexionServeur;
using static fonctions.lesFonctions;

namespace Fournisseurs_Reconnect.Objet_connecté
{
    public partial class ModifierSupprimerObjetConnecte : Form
    {
        public ModifierSupprimerObjetConnecte()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifierSupprimerObjetConnecte_Load(object sender, EventArgs e)
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

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            
            string requeteSupprimer = "delete from objetconnecte where idObjetConnecte = " + GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text) + " ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteSecurite = "delete from objetconnecte_fourni where idObjetConnecte = " + GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text) + " ;";
            MySqlCommand cmdSecurite = new MySqlCommand(requeteSecurite, conn);
            MySqlDataReader drSecurite = cmdSecurite.ExecuteReader();
            drSecurite.Close();
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer l'objet connecté " + listeModele.Text + " ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlCommand cmdSupprimer = new MySqlCommand(requeteSupprimer, conn);
                MySqlDataReader drSupprimer =cmdSupprimer.ExecuteReader();
                MessageBox.Show("L'objet connecté " + listeModele.Text + " a bien été supprimé de la base de données");
                listeModele.Items.Clear();
                drSupprimer.Close();
                string requeteModele = "select modeleObjetCo from objetconnecte where idMarqueObjetCo = " + GetIdMarque(listeMarque.Text) + " and idTypeObjetCo =" + GetIdTypeObjetCo(listeTypeObjetCo.Text) + " ; ";
                MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
                MySqlDataReader drModele = cmdModele.ExecuteReader();
                while (drModele.Read())
                {
                    listeModele.Items.Add(drModele.GetString(0));
                }
                conn.Close();
            }

        }

        int typeSelectionne = 0;
        private void listeMarque_Click(object sender, EventArgs e)
        {
            if(listeMarque.Text == "")
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
                while(drModele.Read())
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

        private void listeModele_Click(object sender, EventArgs e)
        {
            boutonModifier.Enabled = true;
            boutonSupprimer.Enabled = true;
        }

        public static objetConnecte objetCoAModif;
        private void boutonModifier_Click(object sender, EventArgs e)
        {
            objetCoAModif = new objetConnecte(GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text), listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text);
            ModifierObjetConnecte modifierObjetConnecte = new ModifierObjetConnecte();
            modifierObjetConnecte.ShowDialog();
            listeModele.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteModele = "select modeleObjetCo from objetconnecte where idMarqueObjetCo = " + GetIdMarque(listeMarque.Text) + " and idTypeObjetCo =" + GetIdTypeObjetCo(listeTypeObjetCo.Text) + " ; ";
            MySqlCommand cmdModele = new MySqlCommand(requeteModele, conn);
            MySqlDataReader drModele = cmdModele.ExecuteReader();
            while (drModele.Read())
            {
                listeModele.Items.Add(drModele.GetString(0));
            }
            conn.Close();
        }
    }
}
