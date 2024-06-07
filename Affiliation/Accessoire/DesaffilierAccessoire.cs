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

namespace Fournisseurs_Reconnect.Affiliation.Accessoire
{
    public partial class DesaffilierAccessoire : Form
    {
        public DesaffilierAccessoire()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DesaffilierAccessoire_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteFournisseur = "select * from fournisseur;";
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                listeFournisseur.Items.Add(drFournisseur.GetString("nomFournisseur"));
            }
            drFournisseur.Close();
            conn.Close();

        }

        private void listeFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            listeMarque.Items.Clear();
            listeAccessoires.Items.Clear();
            listeType.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteMarque = "select distinct idMarqueAccessoire from accessoire inner join accessoire_fourni on accessoire.idAccessoire = accessoire_fourni.idAccessoire where idFournisseur =" + GetIdFournisseur(listeFournisseur.Text) + ";";
            MySqlCommand cmdMarque = new MySqlCommand(requeteMarque, conn);
            MySqlDataReader drMarque = cmdMarque.ExecuteReader();
            while (drMarque.Read())
            {
                listeMarque.Items.Add(GetNomMarque(drMarque.GetInt32("idMarqueAccessoire")));
            }
            drMarque.Close();
            conn.Close();
        }

        private void listeMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            listeType.Items.Clear();
            listeAccessoires.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteType ="select distinct idTypeAccessoire from accessoire inner join accessoire_fourni on accessoire.idAccessoire = accessoire_fourni.idAccessoire where idFournisseur =" + GetIdFournisseur(listeFournisseur.Text) + " and idMarqueAccessoire = " + GetIdMarque(listeMarque.Text) + ";";
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
            string requeteAccessoire = "select nomAccessoire from accessoire inner join accessoire_fourni on accessoire.idAccessoire = accessoire_fourni.idAccessoire where idFournisseur =" + GetIdFournisseur(listeFournisseur.Text) + " and idMarqueAccessoire = " + GetIdMarque(listeMarque.Text) + " and idTypeAccessoire = " + GetIdTypeAccessoire(listeType.Text) + ";";
            MySqlCommand cmdAccessoire = new MySqlCommand(requeteAccessoire, conn);
            MySqlDataReader drAccessoire = cmdAccessoire.ExecuteReader();
            while (drAccessoire.Read())
            {
                listeAccessoires.Items.Add(drAccessoire.GetString("nomAccessoire"));
            }
            drAccessoire.Close();
            conn.Close();
        }

        private void boutonAffilier_Click(object sender, EventArgs e)
        {
            if (listeAccessoires.Text == "" || listeFournisseur.Text == "")
            {
                MessageBox.Show("Il faut que tout les champs soient remplis !");
                return;
            }
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteSuppression = "delete from accessoire_fourni where idFournisseur = " + GetIdFournisseur(listeFournisseur.Text) + " and idAccessoire = " + GetIdAccessoire(listeMarque.Text, listeType.Text, listeAccessoires.Text) + ";";
            MySqlCommand cmdSuppression = new MySqlCommand(requeteSuppression, conn);
            MySqlDataReader drSupprimmer = cmdSuppression.ExecuteReader();
            MessageBox.Show("L'accessoire " + listeAccessoires.Text + "de la marque " + listeMarque.Text + " et le fournisseur " + listeFournisseur.Text + "ont bien été désaffiliés ");
            drSupprimmer.Close();
            conn.Close();
        }
    }
}
