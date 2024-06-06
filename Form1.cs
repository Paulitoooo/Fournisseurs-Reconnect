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
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            
           
                conn.Open();
                MessageBox.Show("Connexion réussie !");
            conn.Close();
                

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
    }
    }

