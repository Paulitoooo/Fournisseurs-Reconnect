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
    public partial class AffilierAccessoire : Form
    {
        public AffilierAccessoire()
        {
            InitializeComponent();
        }

        private void AffilierAccessoire_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void listeFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPrix.Enabled = true;
            siteFournisseur.Enabled = true;
        }

        private void boutonAffilier_Click(object sender, EventArgs e)
        {
            int idAccessoire = GetIdAccessoire(listeMarque.Text, listeType.Text, listeAccessoires.Text);
            int idFournisseur = GetIdFournisseur(listeFournisseur.Text);
            string requeteAffilier = "insert into accessoire_fourni values(" + idFournisseur + "," + idAccessoire + "," + textBoxPrix.Text + ",'" + siteFournisseur.Text + "');";
            string requeteVerif = "select * from accessoire_fourni;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if(drVerif.GetInt32("idFournisseur") == idFournisseur && drVerif.GetInt32("idAccessoire") == idAccessoire)
                {
                    MessageBox.Show("Cet accessoire et ce fournisseur sont déjà affiliés !");
                    return;
                }
            }
            drVerif.Close();
            MySqlCommand cmdAffilier = new MySqlCommand(requeteAffilier, conn);
            try
            {
                MySqlDataReader drAffilier = cmdAffilier.ExecuteReader();
                MessageBox.Show("L'accessoire " + listeAccessoires.Text + "de la marque " + listeMarque.Text + " et le fournisseur " + listeFournisseur.Text + " ont bien été affiliés ");
                drAffilier.Close();
            }
            catch
            {
                MessageBox.Show("Veillez à ce que le prix entré soit correct (avec un point avant les centimes et pas une virgule) \r\n Le lien du site ne doit pas contenir de caratères spéciaux tels que des guillemets ou apostrophes");
            }
            conn.Close();
        }
    }
}
