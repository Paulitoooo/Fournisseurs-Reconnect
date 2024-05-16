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
                MessageBox.Show("Connexion réussie");
                
                

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
    }
    }

