using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fournisseurs_Reconnect
{
    public partial class ModifierSupprimerMarque : Form
    {
        public ModifierSupprimerMarque()
        {
            InitializeComponent();
        }

        private void SupprimerMarque_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteMarques = "SELECT * FROM marque;";
            MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
            MySqlDataReader drMarques = cmdMarques.ExecuteReader();
            while (drMarques.Read())
            {
                this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
            }
            drMarques.Close();

        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            int compteurSecurite = 0;
            string marqueASupprimer = listeMarques.Text;
            string requeteSupprimer = "DELETE FROM `marque` WHERE idMarque = (select idMarque where nomMarque = '" + marqueASupprimer + "');";
            if(marqueASupprimer == "")
            {
                MessageBox.Show("Il faut selectionner une marque");
                return;
            }
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn.Open();
                string requeteSecurité = "SELECT count(appareil.idAppareil) from appareil WHERE appareil.idMarqueAppareil = (SELECT marque.idMarque from marque where marque.nomMarque = '" + marqueASupprimer + "');";
                MySqlCommand cmdSecurite = new MySqlCommand(requeteSecurité, conn);
                MySqlDataReader rdSecurite = cmdSecurite.ExecuteReader();
                if(rdSecurite.Read())
                {
                    compteurSecurite += rdSecurite.GetInt32("count(appareil.idAppareil)");
                }
                rdSecurite.Close();
                requeteSecurité = "SELECT count(objetconnecte.idObjetConnecte) from objetconnecte WHERE objetconnecte.idMarqueObjetCo = (SELECT marque.idMarque from marque where marque.nomMarque = '" + marqueASupprimer + "');";
                MySqlCommand cmdSecurite2 = new MySqlCommand(requeteSecurité, conn);
                rdSecurite = cmdSecurite2.ExecuteReader();
                if (rdSecurite.Read())
                {
                    compteurSecurite += rdSecurite.GetInt32("count(objetconnecte.idObjetConnecte)");
                }
                rdSecurite.Close();
                requeteSecurité = "SELECT COUNT(accessoire.idAccessoire) from accessoire WHERE idMarqueAccessoire = (SELECT marque.idMarque from marque where marque.nomMarque = '" + marqueASupprimer + "');";
                MySqlCommand cmdSecurite3 = new MySqlCommand(requeteSecurité, conn);
                rdSecurite = cmdSecurite3.ExecuteReader();
                if (rdSecurite.Read())
                {
                    compteurSecurite += rdSecurite.GetInt32("COUNT(accessoire.idAccessoire)");
                }
                rdSecurite.Close();
                if (compteurSecurite > 0)
                {
                    MessageBox.Show("Impossible de supprimer la marque car des appareils/accessoires/objets connectés y sont associés. Veuillez supprimer ces dernier pour supprimer la marque","Erreur de suppression",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer la marque " + marqueASupprimer + " ?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand cmdSuppresionMarque = new MySqlCommand(requeteSupprimer, conn);
                    MySqlDataReader drSuppresionMarque = cmdSuppresionMarque.ExecuteReader();
                    MessageBox.Show("La marque a bien été supprimée");
                    drSuppresionMarque.Close();
                }
                else
                {
                    return;
                }
                this.listeMarques.Items.Clear();
                string requeteMarques = "SELECT * FROM marque;";
                MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
                MySqlDataReader drMarques = cmdMarques.ExecuteReader();
                while (drMarques.Read())
                {
                    this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
                }
                drMarques.Close();
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifNom(string nouveauNom , string unMarque)
        {
            string requeteModif = "Update marque set nomMarque = '" + nouveauNom + "' where idMarque = (select idMarque where nomMarque = '" + unMarque + "');";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn.Open();
                MySqlCommand cmdRequeteModif = new MySqlCommand(requeteModif, conn);
                MySqlDataReader drModif = cmdRequeteModif.ExecuteReader();
                MessageBox.Show("Le nom a bien été modifié");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void boutonModifier_Click(object sender, EventArgs e)
        {
            string laMarqueAModif = listeMarques.Text;
            if (laMarqueAModif == "")
            {
                MessageBox.Show("Il faut selectionner une marque");
                return;
            }
            Form formModif = new Form();
            formModif.Size = new Size(446, 246);
            formModif.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            formModif.ControlBox = false;
            formModif.StartPosition = FormStartPosition.CenterScreen ;
            formModif.Text = "Modifier une marque";
            formModif.AutoSize = false;
            formModif.SizeGripStyle = SizeGripStyle.Hide;
            TextBox textBoxModif = new TextBox();
            textBoxModif.Size = new Size(312,20);
            textBoxModif.Location = new Point(57, 47);
            formModif.Controls.Add(textBoxModif);
            Label label1 = new Label();
            label1.Text = "Saisissez un nouveau nom de marque";
            label1.Location = new Point(125, 31);
            label1.Size = new Size(186,13);
            formModif.Controls.Add(label1);
            Button boutonModif = new Button();
            boutonModif.Size = new Size(75, 23);
            boutonModif.Location = new Point(236, 112);
            boutonModif.Text = "Modifier";
            Button retour = new Button();
            retour.Size = new Size(75, 23);
            retour.Location = new Point(110, 112);
            retour.Text = "< Retour";
            void fermerModif(object send , EventArgs e2)
            {
                formModif.Close();
            }
            retour.Click += fermerModif;
            formModif.Controls.Add(retour);
            void modifNom(object send ,EventArgs e2)
            {
                string nouveauNom = textBoxModif.Text;

                string requeteModif = "Update marque set nomMarque = '" + nouveauNom + "' where idMarque = (select idMarque where nomMarque = '" + laMarqueAModif + "');";
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                try
                {
                    conn.Open();
                    MySqlCommand cmdRequeteModif = new MySqlCommand(requeteModif, conn);
                    MySqlDataReader drModif = cmdRequeteModif.ExecuteReader();
                    MessageBox.Show("Le nom a bien été modifié");
                    drModif.Close();
                    listeMarques.Items.Clear();
                    string requeteMarques = "SELECT * FROM marque;";
                    MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
                    MySqlDataReader drMarques = cmdMarques.ExecuteReader();
                    while (drMarques.Read())
                    {
                        this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
                    }
                    drMarques.Close();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            boutonModif.Click +=   modifNom;
            formModif.Controls.Add(boutonModif);
            formModif.AcceptButton = boutonModif;
            formModif.CancelButton = retour;
            
            formModif.ShowDialog();
        }

        private void BoutonModif_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
