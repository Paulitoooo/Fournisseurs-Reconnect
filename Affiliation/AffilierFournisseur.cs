using Fournisseurs_Reconnect.Affiliation;
using Fournisseurs_Reconnect.Affiliation.Accessoire;
using Fournisseurs_Reconnect.Affiliation.Objet_Connecté;
using Fournisseurs_Reconnect.Affiliation.Pièce_détachée;
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
    public partial class AffilierFournisseur : Form
    {
        public AffilierFournisseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AffilierFournisseurAppareil affilierFournisseurAppareil = new AffilierFournisseurAppareil();
            affilierFournisseurAppareil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AffilierFournisseurPieceDetachee affilierFournisseurPieceDetachee = new AffilierFournisseurPieceDetachee();
            affilierFournisseurPieceDetachee.ShowDialog();
        }

        private void AffilierFournisseur_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AffilierObjetConnecte affilierObjetConnecte = new AffilierObjetConnecte();
            affilierObjetConnecte.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AffilierAccessoire affilierAccessoire = new AffilierAccessoire();
            affilierAccessoire.ShowDialog();
        }
    }
}
