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
    public partial class AjouterModifierSupprimerObjetConnecte : Form
    {
        public AjouterModifierSupprimerObjetConnecte()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterModifierSupprimerObjetConnecte_Load(object sender, EventArgs e)
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

        private void boutonAjouter_Click(object sender, EventArgs e)
        {
            if(listeTypeObjetCo.Text == "" || listeMarque.Text =="" || textBoxNomModele.Text == "")
            {
                MessageBox.Show("Il faut que tout les champs soient renseigner");
                return;
            }
            
            string requeteProchainId = "select count(*) from objetconnecte;";
            int prochainId = 1;
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdProchainId = new MySqlCommand(requeteProchainId, conn);
            MySqlDataReader drProchainId = cmdProchainId.ExecuteReader();
            if (drProchainId.Read())
            {
                prochainId = drProchainId.GetInt32(0) + 1;
            }
            drProchainId.Close();
            string requeteVerifId = "select * from objetconnecte order by idObjetConnecte desc ;";
            MySqlCommand cmdVerifId = new MySqlCommand(requeteVerifId, conn);
            MySqlDataReader drVerifId = cmdVerifId.ExecuteReader();
            while(drVerifId.Read())
            {
                if (drVerifId.GetInt32("idObjetConnecte") == prochainId)
                {
                    prochainId--;
                }
                if(drVerifId.GetString("modeleObjetCo")==textBoxNomModele.Text && GetIdMarque(listeMarque.Text) == drVerifId.GetInt32("idMarqueObjetCo"))
                {
                    MessageBox.Show("Ce modèle existe déjà dans la base de données");
                    return;
                }
            }
            drVerifId.Close();
            string requeteAjouterObjetCo = "insert into objetconnecte values ("+ prochainId+", "+GetIdMarque( listeMarque.Text)+", '"+textBoxNomModele.Text+"', "+GetIdTypeObjetCo(listeTypeObjetCo.Text)+") ;";
            MySqlCommand cmdAjouterObjetCo = new MySqlCommand(requeteAjouterObjetCo, conn);
            MySqlDataReader drAjouterObjetCo = cmdAjouterObjetCo.ExecuteReader();
            MessageBox.Show("L'objet connecté " + textBoxNomModele.Text + " a bien été ajouté à la base de données");
            conn.Close();
            textBoxNomModele.Clear();
        }

        private void boutonSupprimerMarque_Click(object sender, EventArgs e)
        {
            ModifierSupprimerObjetConnecte modifierSupprimerObjetConnecte = new ModifierSupprimerObjetConnecte();
            modifierSupprimerObjetConnecte.ShowDialog();
        }


    }
}
