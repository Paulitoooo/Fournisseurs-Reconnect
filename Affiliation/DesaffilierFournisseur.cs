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

namespace Fournisseurs_Reconnect.Affiliation
{
    public partial class DesaffilierFournisseur : Form
    {
        public DesaffilierFournisseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DesaffilierFournisseurAppareil desaffilierFournisseurAppareil = new DesaffilierFournisseurAppareil();
            desaffilierFournisseurAppareil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DesaffilierFournisseurPieceDetachee desaffilierFournisseurPieceDetachee = new DesaffilierFournisseurPieceDetachee();
            desaffilierFournisseurPieceDetachee.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DesaffilierObjetConnecte desaffilierObjetConnecte = new DesaffilierObjetConnecte();
            desaffilierObjetConnecte.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DesaffilierAccessoire desaffilierAccessoire = new DesaffilierAccessoire();
            desaffilierAccessoire.ShowDialog();
        }
    }
}
