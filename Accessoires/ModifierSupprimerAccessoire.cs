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
    public partial class ModifierSupprimerAccessoire : Form
    {
        public ModifierSupprimerAccessoire()
        {
            InitializeComponent();
        }

        private void ModifierSupprimerAccessoire_Load(object sender, EventArgs e)
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
                listeType.Items.Add(GetLibelleTypeAccessoire( drType.GetInt32(0)));
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

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteSuppression = "delete from accessoire where idAccessoire = " + GetIdAccessoire(listeMarque.Text, listeType.Text, listeAccessoires.Text) + " ;";
            MySqlCommand cmdSuppression = new MySqlCommand(requeteSuppression, conn);
            MySqlDataReader drSuppression = cmdSuppression.ExecuteReader();
            MessageBox.Show("L'accessoire " + listeAccessoires.Text + " de la marque " + listeMarque.Text + " a bien été supprimé de la base de données");
            drSuppression.Close();
            listeMarque.Items.Clear();
            listeType.Items.Clear();
            listeAccessoires.Items.Clear();
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
    }
}
