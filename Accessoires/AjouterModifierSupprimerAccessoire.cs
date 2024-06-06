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
    public partial class AjouterModifierSupprimerAccessoire : Form
    {
        public AjouterModifierSupprimerAccessoire()
        {
            InitializeComponent();
        }

        private void AjouterModifierSupprimerAccessoire_Load(object sender, EventArgs e)
        {
            string requeteMarque = "select * from marque;";
            string requeteType = "select * from typeaccessoire;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdMarque = new MySqlCommand(requeteMarque, conn);
            MySqlDataReader drMarque = cmdMarque.ExecuteReader();
            while (drMarque.Read())
            {
                listeMarque.Items.Add(drMarque.GetString("nomMarque"));
            }
            drMarque.Close();
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeType.Items.Add(drType.GetString("libelleTypeAccessoire"));
            }
            drType.Close();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prochainId = 0;
            string requeteProchainId = "select count(*) from accessoire;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdProchainId = new MySqlCommand(requeteProchainId, conn);
            MySqlDataReader drProchainId = cmdProchainId.ExecuteReader();
            if (drProchainId.Read())
            {
                prochainId = drProchainId.GetInt32(0) + 1;
            }
            drProchainId.Close();
            string requeteVerif = "select * from accessoire order by idAccessoire desc;";
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if(drVerif.GetInt32("idAccessoire") == prochainId)
                {
                    prochainId--;
                }
                if(drVerif.GetString("nomAccessoire") == textBoxNomAccessoire.Text && drVerif.GetInt32("idMarqueAccessoire") == GetIdMarque(listeMarque.Text) && drVerif.GetInt32("idTypeAccessoire") == GetIdTypeAccessoire(listeType.Text))
                {
                    MessageBox.Show("Cet accessoire existe déjà !");
                    return;
                }
            }
            drVerif.Close();
            string requeteAjouter = "insert into accessoire values (" + prochainId + "," + GetIdTypeAccessoire(listeType.Text) + "," + GetIdMarque(listeMarque.Text) + ",'" + textBoxNomAccessoire.Text + "')";
            MySqlCommand cmdAjout = new MySqlCommand(requeteAjouter, conn);
            MySqlDataReader drAjout = cmdAjout.ExecuteReader();
            MessageBox.Show("L'accessoire " + textBoxNomAccessoire.Text + " a bien été ajouté");
            drAjout.Close();
            conn.Close();
            textBoxNomAccessoire.Clear();
        }

    }
}
