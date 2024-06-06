using Fournisseurs_Reconnect.Objet_connecté;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Fournisseurs_Reconnect.Affiliation.Objet_Connecté.ModifierAffiliationObjetConnecte;
using static fonctions.connexionServeur;
using static fonctions.lesFonctions;
using MySql.Data.MySqlClient;

namespace Fournisseurs_Reconnect.Affiliation.Objet_Connecté
{
    public partial class laModificationAffiliationObjetCo : Form
    {
        public laModificationAffiliationObjetCo()
        {
            InitializeComponent();
        }

        ObjetCo_Fourni objetCoAModifier = ModifierAffiliationObjetConnecte.objetAModif;
        private void laModificationAffiliationObjetCo_Load(object sender, EventArgs e)
        {
            siteFournisseur.Text = objetCoAModifier.getSiteObjetCoFourni();
            nouveauPrix.Text = objetCoAModifier.getPrix().ToString();

        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(objetCoAModifier.getPrix().ToString()== nouveauPrix.Text && objetCoAModifier.getSiteObjetCoFourni() == siteFournisseur.Text)
            {
                MessageBox.Show("Rien a été modifié");
                return;
            }

            string requeteModif = "update objetconnecte_fourni set Prix = " + nouveauPrix.Text + " , siteObjetCoFourni  = '" + siteFournisseur.Text + "' where idFournisseur = " + objetCoAModifier.getIdFournisseur() + " and idObjetConnecte = " + objetCoAModifier.GetObjetConnecte().getIdObjetConnecte() + " ;";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            MySqlCommand cmdModif = new MySqlCommand(requeteModif, conn);
            try
            {
                MySqlDataReader drModif = cmdModif.ExecuteReader();
                MessageBox.Show("L'objet connecté a bien été modifié");
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Veillez à ce que le prix entré soit correct (avec un point avant les centimes et pas une virgule) \r\n Le lien du site ne doit pas contenir de caratères spéciaux tels que des guillemets ou apostrophes");
            }
            conn.Close();
            this.Close();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bouronRetablir_Click(object sender, EventArgs e)
        {
            siteFournisseur.Text = objetCoAModifier.getSiteObjetCoFourni();
            nouveauPrix.Text = objetCoAModifier.getPrix().ToString();
        }
    }
}
