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
    public partial class ModifierAccessoire : Form
    {
        public ModifierAccessoire()
        {
            InitializeComponent();
        }

        Accessoire accessoireAModifier = ModifierSupprimerAccessoire.accessoireAModif;
        private void ModifierAccessoire_Load(object sender, EventArgs e)
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

            listeMarque.SelectedItem = GetNomMarque(accessoireAModifier.getIdMarqueAccessoire());
            listeType.SelectedItem = GetLibelleTypeAccessoire(accessoireAModifier.getIdTypeAccessoire());
            textBoxNomAccessoire.Text = accessoireAModifier.getNomAccessoire();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listeMarque.Text == GetNomMarque(accessoireAModifier.getIdMarqueAccessoire()) && listeType.Text == GetLibelleTypeAccessoire(accessoireAModifier.getIdTypeAccessoire()) && textBoxNomAccessoire.Text == accessoireAModifier.getNomAccessoire())
            {
                MessageBox.Show("Rien a été changé");
                return;
            }
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteVerif = "select * from accessoire order by idAccessoire desc;";
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if (drVerif.GetString("nomAccessoire") == textBoxNomAccessoire.Text && drVerif.GetInt32("idMarqueAccessoire") == GetIdMarque(listeMarque.Text) && drVerif.GetInt32("idTypeAccessoire") == GetIdTypeAccessoire(listeType.Text))
                {
                    MessageBox.Show("Cet accessoire existe déjà !");
                    return;
                }
            }
                drVerif.Close();
                string requeteModifier = "update accessoire set idTypeAccessoire =" + GetIdTypeAccessoire(listeType.Text) + " , idMarqueAccessoire = " + GetIdMarque(listeMarque.Text) + " , nomAccessoire = '" + textBoxNomAccessoire.Text + "' where idAccessoire = " + accessoireAModifier.getIdAccessoire() + " ;";
                MySqlCommand cmdModifier = new MySqlCommand(requeteModifier, conn);
                MySqlDataReader drModifier = cmdModifier.ExecuteReader();
                MessageBox.Show("L'accessoire " + accessoireAModifier.getNomAccessoire() + " de la marque " + listeMarque.Text + " a bien été modifié");
                drModifier.Close();
                conn.Close();
            this.Close();
            
        }
    }
}
