using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fournisseurs_Reconnect
{
    public partial class Demarrage : Form
    {
        public Demarrage()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/wamp64/wampmanager.exe");

                Process.Start("http://localhost/phpmyadmin/");
                ShowInTaskbar = false;
                Formulaire1 formulaire1 = new Formulaire1();
                formulaire1.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Wamp n'est pas installé sur cet ordinateur !");
            }
        }
    }
}
