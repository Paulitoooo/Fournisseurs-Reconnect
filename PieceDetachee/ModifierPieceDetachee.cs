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
using static Fournisseurs_Reconnect.PieceDetachees;
using static fonctions.lesFonctions;

namespace Fournisseurs_Reconnect.PieceDetachee
{
    public partial class ModifierPieceDetachee : Form
    {

        PieceDetachees PieceAModif = ModifierSupprimerPieceDetachee.pieceAModifier;
        public ModifierPieceDetachee()
        {
            InitializeComponent();
        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifierPieceDetachee_Load(object sender, EventArgs e)
        {
            textBoxNouveauNom.Text = PieceAModif.getNomPieceDetachee();
            string requeteType = "Select libelleTypePiece from typepiecedetachee;";
            MySqlConnection Conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            Conn.Open();
            MySqlCommand cmdType = new MySqlCommand(requeteType, Conn);
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeType.Items.Add(drType.GetString("libelleTypePiece"));
            }
            drType.Close();
            string requeteAppareil = "select distinct modele from appareil";
            MySqlCommand cmdAppareil = new MySqlCommand(requeteAppareil, Conn);
            MySqlDataReader drAppareil = cmdAppareil.ExecuteReader();
            while (drAppareil.Read())
            {
                listeAppareil.Items.Add(drAppareil.GetString("modele"));
            }
            Conn.Close();
            listeAppareil.SelectedItem = PieceAModif.getNomModele();
            listeType.SelectedItem = getLibelleTypePieceDetachee( PieceAModif.getIdTypePieceDetachee());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PieceDetachees PieceApresModif = new PieceDetachees(PieceAModif.getIdPieceDetachee(),
                getIdTypePieceDetachee(listeType.Text), listeAppareil.Text, textBoxNouveauNom.Text);
            string requeteModif = "update piecedetachee set idTypePieceDetachee = " +
                PieceApresModif.getIdTypePieceDetachee().ToString() + ", nomModeleAppareil = '" +
                PieceApresModif.getNomModele() + "' , nomPieceDetachee = '" + textBoxNouveauNom.Text + "' where idPieceDetachee = " + PieceAModif.getIdPieceDetachee() + " ;";
            MySqlConnection Conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            Conn.Open();
            MySqlCommand cmdModif = new MySqlCommand(requeteModif, Conn);
            string requeteVerif = "select * from piecedetachee";
            MySqlCommand cmdVerif = new MySqlCommand(requeteVerif, Conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            if(PieceApresModif.getIdTypePieceDetachee() == PieceAModif.getIdTypePieceDetachee() && PieceAModif.getNomPieceDetachee() == PieceApresModif.getNomPieceDetachee() && PieceApresModif.getNomModele() == PieceAModif.getNomModele()) 
            {
                MessageBox.Show("La pièce n'a pas été modifiée");
                return;
            }
            while (drVerif.Read())
            {
                if(drVerif.GetString("nomPieceDetachee") == PieceApresModif.getNomPieceDetachee() && drVerif.GetString("nomModeleAppareil") == PieceApresModif.getNomModele() && drVerif.GetInt32("idTypePieceDetachee") == PieceApresModif.getIdTypePieceDetachee()){
                    MessageBox.Show("Il existe déjà une pièce détachée comportant ces carateristiques");
                    return;
                }
            }
            drVerif.Close();
            MySqlDataReader drModif = cmdModif.ExecuteReader();
            MessageBox.Show("La pièce a bien été modifiée");
            Conn.Close();
            

        }
    }
}
