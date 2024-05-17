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

namespace Fournisseurs_Reconnect
{
    public partial class ModifierSupprimerFournisseur : Form
    {
        public ModifierSupprimerFournisseur()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            string fournisseurASupprimer = listeFournisseur.Text;
            if(fournisseurASupprimer == "")
            {
                MessageBox.Show("Il faut selectionner un fournisseur", "Suppresion du fournisseur impossible",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
                return;
            }
            string requeteSuppression = "DELETE FROM `fournisseur` WHERE idFournisseur = (Select idFournisseur where nomFournisseur ='" + fournisseurASupprimer + "');";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult dialog = MessageBox.Show("Voulez vous vraiment supprimer le fournisseur " + fournisseurASupprimer + " ?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MySqlCommand cmdSuppression = new MySqlCommand(requeteSuppression, conn);
                MySqlDataReader drSuppression = cmdSuppression.ExecuteReader();
                drSuppression.Close();
                MessageBox.Show("Le fournisseur a bien été supprimée");
                listeFournisseur.Items.Clear();
                string requeteListe = "Select nomFournisseur from fournisseur";
                MySqlCommand cmdListe = new MySqlCommand(requeteListe, conn);
                MySqlDataReader drListe = cmdListe.ExecuteReader();
                while (drListe.Read())
                {
                    listeFournisseur.Items.Add(drListe.GetString("nomFournisseur"));
                }
                drListe.Close();
            }
            conn.Close();
        }

        private void ModifierSupprimerFournisseur_Load(object sender, EventArgs e)
        {
            string requeteListe = "Select nomFournisseur from fournisseur";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlCommand cmdListe = new MySqlCommand(requeteListe, conn);
            MySqlDataReader drListe = cmdListe.ExecuteReader();
            while (drListe.Read())
            {
                listeFournisseur.Items.Add(drListe.GetString("nomFournisseur"));
            }
            drListe.Close();
            conn.Close();
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {

            string leFournisseurAModif = listeFournisseur.Text;
            if(leFournisseurAModif == "")
            {
                MessageBox.Show("Il faut selectionner un fournisseur à modifier","Modification du fournisseur impossible",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string leSiteAmodif = "";
            string requeteSite = "Select siteFournisseur from fournisseur where idFournisseur = (Select idFournisseur where nomFournisseur = '" + leFournisseurAModif + "');";
            MySqlConnection conn1 = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlCommand cmdListe = new MySqlCommand(requeteSite, conn1);
            MySqlDataReader drListe = cmdListe.ExecuteReader();
            if (drListe.Read())
            {
                leSiteAmodif = drListe.GetString("siteFournisseur");
            }
            drListe.Close();
            conn1.Close();
            Form formModif = new Form();
            formModif.Size = new Size(446, 246);
            formModif.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            formModif.ControlBox = false;
            formModif.StartPosition = FormStartPosition.CenterScreen;
            formModif.ShowInTaskbar = false;
            formModif.Text = "Modifier un fournisseur";
            formModif.AutoSize = false;
            formModif.SizeGripStyle = SizeGripStyle.Hide;
            TextBox textBoxModif = new TextBox();
            textBoxModif.Size = new Size(312, 20);
            textBoxModif.Location = new Point(57, 27);
            textBoxModif.Text = leFournisseurAModif;
            formModif.Controls.Add(textBoxModif);
            Label label1 = new Label();
            label1.Text = "Saisissez un nouveau nom de fournisseur";
            label1.Location = new Point(125, 11);
            label1.Size = new Size(220, 13);
            Label label2 = new Label();
            label2.Text = "Saisissez un nouveau site de fournisseur";
            label2.Location = new Point(125, 50);
            label2.Size = new Size(220, 13);
            TextBox textBoxSiteModif = new TextBox();
            textBoxSiteModif.Text = leSiteAmodif;
            textBoxSiteModif.Size = new Size(312, 20);
            textBoxSiteModif.Location = new Point(57, 67);
            formModif.Controls.Add(label1);
            formModif.Controls.Add(label2);
            formModif.Controls.Add(textBoxSiteModif);
            Button boutonModif = new Button();
            boutonModif.Size = new Size(75, 23);
            boutonModif.Location = new Point(236, 112);
            boutonModif.Text = "Modifier";
            Button retour = new Button();
            retour.Size = new Size(75, 23);
            retour.Location = new Point(110, 112);
            retour.Text = "< Retour";
            void fermerModif(object send, EventArgs e2)
            {
                formModif.Close();
            }
            retour.Click += fermerModif;
            formModif.Controls.Add(retour);
            void modifNom(object send, EventArgs e2)
            {
                string nouveauNom = textBoxModif.Text;
                string nouveauSite = textBoxSiteModif.Text;
                string requeteModif = "Update fournisseur set nomFournisseur = '" + nouveauNom + "' , siteFournisseur = '" + nouveauSite + "'where idFournisseur = (select idFournisseur where nomFournisseur = '" + leFournisseurAModif + "');";
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                try
                {
                    conn.Open();
                    MySqlCommand cmdRequeteModif = new MySqlCommand(requeteModif, conn);
                    MySqlDataReader drModif = cmdRequeteModif.ExecuteReader();
                    if (nouveauNom != leFournisseurAModif && nouveauSite != leSiteAmodif)
                    {
                        MessageBox.Show("Le nom et le site du fournisseur ont bien été modifiés");

                    }
                    else
                    {
                        if (nouveauNom == leFournisseurAModif && nouveauSite != leSiteAmodif)
                        {
                            MessageBox.Show("Le site du fournisseur a bien été modifié");

                        }
                        else
                        {
                            if( nouveauNom != leFournisseurAModif && nouveauSite == leSiteAmodif)
                            {
                                MessageBox.Show("Le nom du fournisseur a bien été modifié");

                            }
                            else
                            {
                                MessageBox.Show("Les nom et site du fournisseur restent inchangés");
                            }
                        }
                    }
                    drModif.Close();
                    formModif.Close();
                    listeFournisseur.Items.Clear();
                    string requeteFournisseur = "SELECT * FROM fournisseur;";
                    MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
                    MySqlDataReader drFournisseur= cmdFournisseur.ExecuteReader();
                    while (drFournisseur.Read())
                    {
                        this.listeFournisseur.Items.Add(drFournisseur.GetString("nomFournisseur"));
                    }
                    drFournisseur.Close();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            boutonModif.Click += modifNom;
            formModif.Controls.Add(boutonModif);
            formModif.AcceptButton = boutonModif;
            formModif.CancelButton = retour;

            formModif.ShowDialog();

        }
    }
}
