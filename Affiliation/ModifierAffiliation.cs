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
    }
}
