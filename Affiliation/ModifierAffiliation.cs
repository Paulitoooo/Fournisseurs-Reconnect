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
    public partial class ModifierAffiliation : Form
    {
        public ModifierAffiliation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifierAffiliationAppareil modifierAffiliationAppareil = new ModifierAffiliationAppareil();
            modifierAffiliationAppareil.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModifierAffiliationPieceDetachee modifierAffiliationPieceDetachee = new ModifierAffiliationPieceDetachee();
            modifierAffiliationPieceDetachee.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModifierAffiliationObjetConnecte modifierAffiliationObjetConnecte = new ModifierAffiliationObjetConnecte();
            modifierAffiliationObjetConnecte.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ModifierAffiliationAccessoire modifierAffiliationAccessoire = new ModifierAffiliationAccessoire();
            modifierAffiliationAccessoire.ShowDialog();
        }
    }
}
