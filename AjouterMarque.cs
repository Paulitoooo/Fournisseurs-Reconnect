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
    public partial class AjouterMarque : Form
    {
        public AjouterMarque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxNomMarque.TextLength > 150 ) 
            {
                MessageBox.Show("Le nom de la marque est trop long !","Impossible d'enregistrer la marque",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(textBoxNomMarque.TextLength == 0)
            {
                MessageBox.Show("Il faut renseigner un nom de marque !", "Impossible d'enregistrer la marque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int prochainId;
            string requeteId = "SELECT count(idMarque) from marque;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MySqlCommand mySqlCommandId = new MySqlCommand(requeteId, conn);
            MySqlDataReader drId = mySqlCommandId.ExecuteReader();
            if (drId.Read())
            {

                prochainId = drId.GetInt32("count(idMarque)") + 1;
                string requeteAjoutMarque = "Insert into marque values("+ prochainId+",'"+textBoxNomMarque.Text+"');";
                MySqlCommand cmdAjoutMarque = new MySqlCommand(requeteAjoutMarque, conn);
                drId.Close();
                MySqlDataReader drAjoutMarque = cmdAjoutMarque.ExecuteReader();
                MessageBox.Show("La marque a bien été ajoutée à la base de données");
            }
            
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupprimerMarque supprimerMarque = new SupprimerMarque();
            supprimerMarque.ShowDialog();
        }
    }
}
