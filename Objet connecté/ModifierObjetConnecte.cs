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
    public partial class ModifierObjetConnecte : Form
    {
        public ModifierObjetConnecte()
        {
            InitializeComponent();
        }
        objetConnecte objetAModifier = ModifierSupprimerObjetConnecte.objetCoAModif;
        private void ModifierObjetConnecte_Load(object sender, EventArgs e)
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
            listeMarque.SelectedItem = objetAModifier.getNomMarqueObjetConnecte();
            drMarque.Close();
            string requeteType = "select * from typeobjetco order by libelleTypeObjetCo;";
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeTypeObjetCo.Items.Add(drType.GetString("libelleTypeObjetCo"));
            }
            listeTypeObjetCo.SelectedItem = objetAModifier.getLibelleTypeObjetConnecte();
            textBoxNomModele.Text = objetAModifier.getModeleObjetConnecte();
            drType.Close();
            conn.Clone();
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(objetAModifier.getModeleObjetConnecte() == textBoxNomModele.Text && objetAModifier.getLibelleTypeObjetConnecte()==listeTypeObjetCo.Text && objetAModifier.getNomMarqueObjetConnecte() == listeMarque.Text)
            {
                MessageBox.Show("L'objet connecté n'a pas été modifié");
                return;
            }
            string requeteModif = " update objetconnecte set idMarqueObjetCo = " + GetIdMarque(listeMarque.Text) + " , idTypeObjetCo = " + GetIdTypeObjetCo(listeTypeObjetCo.Text) + " , modeleObjetCo = '" + textBoxNomModele.Text + "' where idObjetConnecte = " + objetAModifier.getIdObjetConnecte() + " ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requeteVerif = "select * from objetconnecte";
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if(drVerif.GetInt32("idMarqueObjetCo") == GetIdMarque(listeMarque.Text) && drVerif.GetInt32("idTypeObjetCo") == GetIdTypeObjetCo(listeTypeObjetCo.Text) && drVerif.GetString("modeleObjetCo") == textBoxNomModele.Text)
                {
                    MessageBox.Show("Il existe déjà un objet connecté comportant ces paramètres dans la base de données", "Modification de l'objet connecté impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            drVerif.Close();
            MySqlCommand cmdModif = new MySqlCommand(requeteModif, conn);
            MySqlDataReader drModif = cmdModif.ExecuteReader();
            MessageBox.Show("L'objet connecté " + objetAModifier.getModeleObjetConnecte() + " a bien été modifié");
            drModif.Close();
            conn.Close();
            this.Close();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
