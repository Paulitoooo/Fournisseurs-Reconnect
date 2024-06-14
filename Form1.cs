using MySql.Data.MySqlClient;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fournisseurs_Reconnect.Affiliation;
using Fournisseurs_Reconnect.PieceDetachee;
using Fournisseurs_Reconnect.Objet_connecté;
using Fournisseurs_Reconnect.Accessoires;
using System.Diagnostics;
using static fonctions.connexionServeur;
using static fonctions.lesFonctions;

namespace Fournisseurs_Reconnect
{
    public partial class Formulaire1 : Form
    {
        public Formulaire1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\wamp64\wampmanager.exe");
        }

        private void buttonAppareil_Click(object sender, EventArgs e)
        {
            RechercheAppareil rechercheAppareil = new RechercheAppareil();
            rechercheAppareil.ShowDialog();

        }

        private void buttonAJouterMarque_Click(object sender, EventArgs e)
        {
            AjouterMarque ajouterMarque = new AjouterMarque();
            ajouterMarque.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjouterModifierSupprimerFournisseur ajouterModifierSupprimerFournisseur = new AjouterModifierSupprimerFournisseur();
            ajouterModifierSupprimerFournisseur.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AjouterModifierSupprimerAppareil ajouterModifierSupprimerApareil = new AjouterModifierSupprimerAppareil();
            ajouterModifierSupprimerApareil.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AffilierFournisseur affilierFournisseur = new AffilierFournisseur();
            affilierFournisseur.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DesaffilierFournisseur desaffilierFournisseur = new DesaffilierFournisseur();
            desaffilierFournisseur.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModifierAffiliation modifierAffiliation = new ModifierAffiliation();
            modifierAffiliation.ShowDialog();
        }

        private void boutonPieceDetachee_Click(object sender, EventArgs e)
        {
            AjouterModifierSupprimerPieceDetachee ajouterModifierSupprimerPieceDetachee = new AjouterModifierSupprimerPieceDetachee();
            ajouterModifierSupprimerPieceDetachee.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AjouterSupprimerModifierTypePieceDetachee ajouterSupprimerModifierTypePieceDetachee = new AjouterSupprimerModifierTypePieceDetachee();
            ajouterSupprimerModifierTypePieceDetachee.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RecherchePieceDetachee recherchePieceDetachee = new RecherchePieceDetachee();
            recherchePieceDetachee.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AjouterModifierSupprimerObjetConnecte ajouterModifierSupprimerObjetConnecte = new AjouterModifierSupprimerObjetConnecte();
            ajouterModifierSupprimerObjetConnecte.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AjouterModifierSupprimerAccessoire ajouterModifierSupprimerAccessoire = new AjouterModifierSupprimerAccessoire();
            ajouterModifierSupprimerAccessoire.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RechercheObjetConnecte rechercheObjetConnecte = new RechercheObjetConnecte();
            rechercheObjetConnecte.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RechercheAccessoire rechercheAccessoire = new RechercheAccessoire();
            rechercheAccessoire.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = 1;
            List<string> listeAccessoire = new List<string>();
            MySqlConnection conn = new MySqlConnection(connexion);
            conn.Open();
            string requete = "select * from a WHERE FAM = 'ACCESSOIRES';";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            int idType = 0;
            int idMarque = 0;
            int id = 1;
            while (dr.Read())
            {
                try
                {
                    if (dr.GetString("SFAM") is null)
                    {
                        idType = 0;
                    }
                    else
                    {
                        idType = GetIdTypeAccessoire(dr.GetString("SFAM"));
                    }
                    if (dr.GetString("Marque") is null)
                    {
                        idMarque = 0;
                    }
                    else
                    {
                        idMarque = GetIdMarque(dr.GetString("Marque"));
                    }
                    string requeteAjout = "insert into  accessoire values(" + id + "," + idType + "," + idMarque + ",'" + dr.GetString("Désignation") + "');";
                    listeAccessoire.Add(requeteAjout);
                    id++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                




            }
            dr.Close();
            for(int i = 1; i<id; i++)
            {
                string laRequete = listeAccessoire[i];
                MySqlCommand cmdAjout = new MySqlCommand(laRequete, conn);
                MySqlDataReader drAjout = cmdAjout.ExecuteReader();
                drAjout.Close();
            }
        }
    }
}
    