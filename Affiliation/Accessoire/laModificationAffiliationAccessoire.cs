using Fournisseurs_Reconnect.Accessoires;
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

namespace Fournisseurs_Reconnect.Affiliation.Accessoire
{
    public partial class laModificationAffiliationAccessoire : Form
    {
        public laModificationAffiliationAccessoire()
        {
            InitializeComponent();
        }

        Accessoire_fourni accessoireAModifier = ModifierAffiliationAccessoire.accessoireAModif;

        private void laModificationAffiliationAccessoire_Load(object sender, EventArgs e)
        {
            siteFournisseur.Text = accessoireAModifier.GetSite();
            nouveauPrix.Text = accessoireAModifier.GetPrix().ToString();

        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(siteFournisseur.Text == accessoireAModifier.GetSite() && nouveauPrix.Text == accessoireAModifier.GetPrix().ToString())
            {
                MessageBox.Show("Rien a été modifié");
                return;
            }
            string requeteModif = "update accessoire_fourni set Prix = " + nouveauPrix.Text + " , siteAccessoireFourni = '" + siteFournisseur.Text + "' where idFournisseur = " + accessoireAModifier.GetFournisseurs().getIdFournisseur() + " and idAccessoire = " + accessoireAModifier.GetAccessoire().getIdAccessoire() + " ;";
            MySqlConnection conn = new MySqlConnection("server = localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdModif = new MySqlCommand(requeteModif, conn);
            MySqlDataReader drModif = cmdModif.ExecuteReader();
            MessageBox.Show("L'affiliation entre l'accessoire " + accessoireAModifier.GetAccessoire().getNomAccessoire() + " de la marque " + GetNomMarque(accessoireAModifier.GetAccessoire().getIdAccessoire()) + " a bien été modifiée");
            drModif.Close();
            conn.Close();
            this.Close();
        }

        private void bouronRetablir_Click(object sender, EventArgs e)
        {
            siteFournisseur.Text = accessoireAModifier.GetSite();
            nouveauPrix.Text = accessoireAModifier.GetPrix().ToString();
        }
    }
}
