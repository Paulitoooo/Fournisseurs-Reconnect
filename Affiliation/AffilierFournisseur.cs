using Fournisseurs_Reconnect.Affiliation;
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
    }
}
