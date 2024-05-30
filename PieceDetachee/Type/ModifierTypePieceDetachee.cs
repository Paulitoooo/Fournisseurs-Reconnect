using MySql.Data.MySqlClient;
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
using static fonctions.lesFonctions;

namespace Fournisseurs_Reconnect.PieceDetachee
{
    public partial class ModifierTypePieceDetachee : Form
    {
        public ModifierTypePieceDetachee()
        {
            InitializeComponent();
        }

        TypePieceDetachee typeModif = ModifierSupprimerTypePieceDetachee.typeAModif;

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifierTypePieceDetachee_Load(object sender, EventArgs e)
        {
            textBox1.Text = typeModif.getLibelleTypePieceDetachee();
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            string requeteModif = "update typepiecedetachee set libelleTypePiece= '" + textBox1.Text + "' where idTypePieceDetachee = " + typeModif.getIdTypePieceDetachee() + " ;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteVerif = "select * from typepiecedetachee";
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            while (drVerif.Read())
            {
                if(drVerif.GetString("libelleTypePiece") == textBox1.Text)
                {
                    MessageBox.Show("Ce type existe déjà dans la base de données", "Modification de type impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            drVerif.Close();
            MySqlCommand cmdModif = new MySqlCommand(requeteModif, conn);
            MySqlDataReader drModif = cmdModif.ExecuteReader();
            MessageBox.Show("Le type " + typeModif.getLibelleTypePieceDetachee() + " a bien été modifié pour : " + textBox1.Text);
            conn.Close();
            this.Close();

        }
    }
}
