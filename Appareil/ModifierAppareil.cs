using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fournisseurs_Reconnect.Appareil;
using MySql.Data.MySqlClient;
using static fonctions.lesFonctions;

namespace Fournisseurs_Reconnect
{
    public partial class ModifierAppareil : Form
    {
        public ModifierAppareil()
        {
            InitializeComponent();
        }
        Appareils appareilModif = ModifierSupprimerApareil.AppareilAModifier;
        public static bool laModifFinie = false;

        string NeufOuReconditionné = "";

        private void ModifierAppareil_Load(object sender, EventArgs e)
        {
            nomModele.Text = appareilModif.getModele();
            string requeteMarques = "SELECT * FROM marque;";
            string requeteType = "SELECT `libelleTypeAppareil` FROM `typeappareil`;";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drMarques = cmdMarques.ExecuteReader();
            while (drMarques.Read())
            {
                this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
            }
            drMarques.Close();
            listeMarques.SelectedItem = appareilModif.getNomMarque();
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeTypes.Items.Add(drType.GetString("libelleTypeAppareil"));
            }
            drType.Close();
            listeTypes.SelectedItem = appareilModif.getLibelleType();
            conn.Close();
            tailleStockage.Text = appareilModif.getStockageAppareil().ToString();
            laModifFinie = false;

        }

        private void boutonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void boutonModifier_Click(object sender, EventArgs e)
        {
            Appareils appareilApresModif = new Appareils(appareilModif.getIdAppareil(), nomModele.Text, fonctions.lesFonctions.GetIdMarque(listeMarques.Text), GetIdTypeAppareil(listeTypes.Text), Int32.Parse(tailleStockage.Text), appareilModif.getNeuf());
            string requeteModif = "Update appareil set modele = '" + nomModele.Text + "' , idMarqueAppareil = (select idMarque from marque where nomMarque = '" + listeMarques.Text + "'), idTypeAppareil = (select idTypeAppareil from typeappareil where libelleTypeAppareil ='" + listeTypes.Text + "') , StockageAppareil = " + tailleStockage.Text + " where idAppareil = " + appareilModif.getIdAppareil() + ";";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string verif = "select * from appareil;";
            MySqlCommand cmdVerif = new MySqlCommand(verif, conn);
            MySqlDataReader drVerif = cmdVerif.ExecuteReader();
            if(nomModele.Text == appareilModif.getModele() && listeMarques.Text == appareilModif.getNomMarque() && listeTypes.Text == appareilModif.getLibelleType() && Int32.Parse(tailleStockage.Text) == appareilModif.getStockageAppareil())
            {
                MessageBox.Show("L'appareil reste inchangé");
                conn.Close();
                laModifFinie = true;
                this.Close();
                return;
            }
            while (drVerif.Read())
            {
                if (drVerif.GetString("modele") == nomModele.Text && drVerif.GetUInt32("StockageAppareil") == Int32.Parse(tailleStockage.Text) && drVerif.GetUInt32("idMarqueAppareil") == appareilApresModif.getIdMarque() && drVerif.GetUInt32("idTypeAppareil") == appareilApresModif.getIdType() && drVerif.GetBoolean("Neuf") == appareilApresModif.getNeuf())
                
                {
                    if(appareilApresModif.getNeuf() == true)
                    {
                        NeufOuReconditionné = "Neuf";
                    }
                    else
                    {
                        NeufOuReconditionné = "Reconditionné";
                    }
                    MessageBox.Show("Il existe déjà un appareil " + nomModele.Text + " " + tailleStockage.Text + " Go " + NeufOuReconditionné + " enregistré dans la base de données ", "Modification impossible",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                    return;
                }
            }
            string NR = "";
            if (appareilModif.getNeuf())
            {
                NR = " neuf ";
            }
            else
            {
                NR = " d'occasion ";
            }
            drVerif.Close();
            MySqlCommand cmdModif = new MySqlCommand(requeteModif, conn);
            MySqlDataReader drModif = cmdModif.ExecuteReader();
            MessageBox.Show("L'appareil " + appareilModif.getModele() + NR + "a bien été modifié");
            drModif.Close();
            conn.Close();
            laModifFinie = true;
            this.Close();
        }
    }
}
