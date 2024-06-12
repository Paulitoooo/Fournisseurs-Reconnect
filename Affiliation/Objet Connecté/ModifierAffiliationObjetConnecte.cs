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
using Fournisseurs_Reconnect.Objet_connecté;


namespace Fournisseurs_Reconnect.Affiliation.Objet_Connecté
{
    public partial class ModifierAffiliationObjetConnecte : Form
    {
        public ModifierAffiliationObjetConnecte()
        {
            InitializeComponent();
        }
        int typeSelectionne = 0;

        private void ModifierAffiliationObjetConnecte_Load(object sender, EventArgs e)
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

        private void listeFournisseur_Click(object sender, EventArgs e)
        {
            if (listeFournisseur.Text == "")
            {
                return;
            }
            listeMarque.Enabled = true;
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
            conn.Close();
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

        public static ObjetCo_Fourni objetAModif;
        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(listeFournisseur.Text=="" || listeModele.Text == "")
            {
                MessageBox.Show("Il faut que tout les champs soient remplis !");
                return;
            }
            objetConnecte unObjet = new objetConnecte(GetIdObjetConnecte(listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text), listeMarque.Text, listeTypeObjetCo.Text, listeModele.Text);
            objetAModif = new ObjetCo_Fourni(unObjet, GetIdFournisseur(listeFournisseur.Text), getPrixObjetCoFourni(unObjet.getIdObjetConnecte(), GetIdFournisseur(listeFournisseur.Text)), getSiteObjetCoFOurni(unObjet.getIdObjetConnecte(), GetIdFournisseur(listeFournisseur.Text)));
            laModificationAffiliationObjetCo laModificationAffiliationObjetCo = new laModificationAffiliationObjetCo();
            laModificationAffiliationObjetCo.ShowDialog();
        }
    }
}
