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
using static Fournisseurs_Reconnect.Affiliation.Pièce_détachée.ModifierAffiliationPieceDetachee;

namespace Fournisseurs_Reconnect.Affiliation.Pièce_détachée
{
    public partial class laModificationnAffiliationPieceDetachee : Form
    {
        PieceDetacheeFournie pieceAModifier = pieceDetacheeAModif;

        public laModificationnAffiliationPieceDetachee()
        {
            InitializeComponent();
        }
        private void laModificationnAffiliationPieceDetachee_Load(object sender, EventArgs e)
        {
            nouveauPrix.Text = pieceAModifier.getPrix().ToString();
            siteFournisseur.Text = pieceAModifier.getSitePieceDetachee();

        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(nouveauPrix.Text == pieceAModifier.getPrix().ToString() && pieceAModifier.getSitePieceDetachee() == siteFournisseur.Text)
            {
                MessageBox.Show("Rien n'a été modifié");
                this.Close();
                return;

            }
            string requeteModif = " update piecedetachee_fournie set Prix = " + nouveauPrix.Text + " , sitePieceDetacheeFourni = '" + siteFournisseur.Text + "' where idFournisseur = " + pieceAModifier.getIdFourisseur() + " and idPieceDetachee = " + pieceAModifier.getIdPieceDetachee() + ";";
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            
            MySqlCommand cmdModif = new MySqlCommand(requeteModif, conn);
            try
            {
                MySqlDataReader drModif = cmdModif.ExecuteReader();
                MessageBox.Show("L'affiliation entre la piece " + getNomPieceDetachee(pieceAModifier.getIdPieceDetachee()) + " pour " + pieceAModifier.getNomModelePourPieceDetachee() + " et le fournisseur " + GetNomFournisseur(pieceAModifier.getIdFourisseur()) + " a bien été modifiée ");
                drModif.Close();
            }
            catch
            {
                MessageBox.Show("Veillez à ce que le prix entré soit correct (avec un point avant les centimes et pas une virgule) \r\n Le lien du site ne doit pas contenir de caratères spéciaux tels que des guillemets ou apostrophes");
            }
            conn.Close();
            this.Close();
        }

        private void bouronRetablir_Click(object sender, EventArgs e)
        {
            siteFournisseur.Text = pieceAModifier.getSitePieceDetachee();
            nouveauPrix.Text = pieceAModifier.getPrix().ToString();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
