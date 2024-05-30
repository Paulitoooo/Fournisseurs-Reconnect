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

namespace Fournisseurs_Reconnect.Affiliation
{
    public partial class laModificationAffiliationAppareil : Form
    {
        public laModificationAffiliationAppareil()
        {
            InitializeComponent();
        }

        Appareil_Fourni affiliationAModifier = ModifierAffiliationAppareil.affiliationAModif;

        private void laModificationAffiliationAppareil_Load(object sender, EventArgs e)
        {
            siteFournisseur.Text = affiliationAModifier.getSiteAppareil();
            nouveauPrix.Text = affiliationAModifier.getPrix().ToString();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(affiliationAModifier.getSiteAppareil() != siteFournisseur.Text || affiliationAModifier.getPrix().ToString() != nouveauPrix.Text)
            {
                string requete = "Update appareil_fourni set siteAppareilFourni = '" + siteFournisseur.Text + "' , Prix = " + nouveauPrix.Text + " where idAppareil = "+ affiliationAModifier.getIdAppareil() + " and idFournisseur = " + affiliationAModifier.getIdFourisseur() +"; ";
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                conn.Open();
                MySqlCommand cmdModif = new MySqlCommand(requete, conn);
                try
                {
                    MySqlDataReader drModif = cmdModif.ExecuteReader();
                    MessageBox.Show("L'affiliation à bien été modifiée");
                    drModif.Close();
                    conn.Clone();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Il faut saisir un prix valide ! \n\r Veillez à ce que le prix saisi soit un nombre et que les centimes soient précédés d'un point et non pas d'une virgule");
                }
                
            }
            else
            {
                MessageBox.Show("Rien n'a été modifié");
            }
        }

        private void bouronRetablir_Click(object sender, EventArgs e)
        {
            siteFournisseur.Text = affiliationAModifier.getSiteAppareil();
            nouveauPrix.Text = affiliationAModifier.getPrix().ToString();
        }
    }
}
