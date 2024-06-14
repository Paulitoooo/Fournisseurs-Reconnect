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
using static fonctions.lesFonctions;
using static Fournisseurs_Reconnect.Fournisseur.Fournisseurs;

namespace Fournisseurs_Reconnect.Affiliation
{
    public partial class ModifierAffiliationAppareil : Form
    {
        public ModifierAffiliationAppareil()
        {
            InitializeComponent();
        }
        int leTypeEstSelectionné = 0;
        private void ModifierAffiliationAppareil_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string requeteMarques = "SELECT * FROM marque;";
            string requeteType = "SELECT `libelleTypeAppareil` FROM `typeappareil`;";
            MySqlCommand cmdMarques = new MySqlCommand(requeteMarques, conn);
            MySqlCommand cmdType = new MySqlCommand(requeteType, conn);
            MySqlDataReader drMarques = cmdMarques.ExecuteReader();
            while (drMarques.Read())
            {
                this.listeMarques.Items.Add(drMarques.GetString("nomMarque"));
            }
            drMarques.Close();
            MySqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                listeType.Items.Add(drType.GetString("libelleTypeAppareil"));
            }
            drType.Close();
            conn.Close();
        }

        private void listeMarques_Click(object sender, EventArgs e)
        {
            if(listeMarques.Text == "")
            {
                return;
            }
            listeModèles.Items.Clear();
            listeTailleStockage.Items.Clear();
            listeFournisseur.Items.Clear();
            listeFournisseur.Enabled = false;
            boutonModifier.Enabled = false;
            string typeSelectionné;
            if (leTypeEstSelectionné == 1)
            {
                typeSelectionné = listeType.SelectedItem.ToString();
                string marqueSelectionnée = listeMarques.SelectedItem.ToString();
                string requeteModeles = "SELECT distinct modele FROM appareil inner join marque on appareil.idMarqueAppareil " +
                   "= marque.idMarque WHERE idMarqueAppareil = " +
                   "(SELECT marque.idMarque from marque where marque.nomMarque ='" + marqueSelectionnée + "') " +
                   "and idTypeAppareil = (Select idTypeAppareil from typeappareil " +
                   "where libelleTypeAppareil = '" + typeSelectionné + "') order by modele desc;";
                MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
                conn.Open();
                MySqlCommand cmdModele = new MySqlCommand(requeteModeles, conn);
                MySqlDataReader drModele = cmdModele.ExecuteReader();
                while (drModele.Read())
                {
                    listeModèles.Items.Add(drModele.GetString("modele"));
                }
                conn.Close();
            }
            if (listeMarques.SelectedItem != "")
            {
                listeType.Enabled = true;
            }
        }

        private void listeType_Click(object sender, EventArgs e)
        {
            if(listeType.Text == "")
            {
                return;
            }
            listeModèles.Items.Clear();
            listeTailleStockage.Items.Clear();
            listeFournisseur.Items.Clear();
            boutonModifier.Enabled = false;
            listeFournisseur.Enabled = false;

            leTypeEstSelectionné = 1;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();

            string marqueSelectionnée = listeMarques.SelectedItem.ToString();


            string typeSelectionné = listeType.SelectedItem.ToString();
            string requeteModeles = "SELECT distinct modele FROM appareil inner join marque on appareil.idMarqueAppareil " +
                "= marque.idMarque WHERE idMarqueAppareil = " +
                    "(SELECT marque.idMarque from marque where marque.nomMarque ='" + marqueSelectionnée + "') and idTypeAppareil = (Select idTypeAppareil from typeappareil where libelleTypeAppareil = '" + typeSelectionné + "')  order by modele desc;";
            MySqlCommand cmdModele = new MySqlCommand(requeteModeles, conn);
            MySqlDataReader drModele = cmdModele.ExecuteReader();
            while (drModele.Read())
            {
                listeModèles.Items.Add(drModele.GetString("modele"));
            }
            listeModèles.Enabled = true;


            conn.Close();
        }
        static int NeufOuReconditionné;

        private void listeModèles_Click(object sender, EventArgs e)
        {
            if(listeModèles.Text == "")
            {
                return;
            }
            listeTailleStockage.Items.Clear();
            listeFournisseur.Items.Clear();
            boutonModifier.Enabled = false;
            listeFournisseur.Enabled = false;
            listeTailleStockage.Items.Clear();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            string typeSelectionné = listeType.Text;
            string modèleSelectionné = listeModèles.Text;
            string requeteTailleStockage = "Select StockageAppareil from appareil where modele='" + modèleSelectionné + "' and idTypeAppareil = " + GetIdTypeAppareil( typeSelectionné) + " and Neuf = 1;";
            MySqlCommand cmdTailleStockage = new MySqlCommand(requeteTailleStockage, conn);
            MySqlDataReader drTailleStockage = cmdTailleStockage.ExecuteReader();
            while (drTailleStockage.Read())
            {
                listeTailleStockage.Items.Add(drTailleStockage.GetUInt32("StockageAppareil"));
            }
            listeTailleStockage.Enabled = true;
            NeufOuReconditionné = 1;
            conn.Close();
        }

        private void listeTailleStockage_Click(object sender, EventArgs e)
        {
            if(listeTailleStockage.Text == "")
            {
                return;
            }
            boutonModifier.Enabled = false;
            listeFournisseur.Enabled = true;

            listeFournisseur.Items.Clear();
            string requeteFournisseur = "select * from fournisseur inner join appareil_fourni on fournisseur.idFournisseur = appareil_fourni.idFournisseur where appareil_fourni.idAppareil = " + GetIdAppareil(listeModèles.Text, listeMarques.Text, listeType.Text, Int32.Parse(listeTailleStockage.Text), NeufOuReconditionné) + " ; ";
            MySqlConnection conn = new MySqlConnection("server=localhost;database=fournisseur_reconnect;user=root;pwd=");
            conn.Open();
            MySqlCommand cmdFournisseur = new MySqlCommand(requeteFournisseur, conn);
            MySqlDataReader drFournisseur = cmdFournisseur.ExecuteReader();
            while (drFournisseur.Read())
            {
                string leFournisseur = GetNomFournisseur(drFournisseur.GetInt32("idFournisseur"));
                listeFournisseur.Items.Add(leFournisseur);
            }
            conn.Close();
        }

        public static Appareil_Fourni affiliationAModif;
        bool neufOuReconditioné = true;
        private void boutonAffilier_Click(object sender, EventArgs e)
        {
            Appareil.Appareils appareil = new Fournisseurs_Reconnect.Appareil.Appareils(GetIdAppareil(listeModèles.Text, listeMarques.Text, listeType.Text, Int32.Parse(listeTailleStockage.Text),NeufOuReconditionné), listeModèles.Text, GetIdMarque(listeMarques.Text), GetIdTypeAppareil(listeType.Text), Int32.Parse(listeTailleStockage.Text), true);
            affiliationAModif = new Appareil_Fourni(new Fournisseur.Fournisseurs(GetIdFournisseur(listeFournisseur.Text), listeFournisseur.Text), GetPrixAppareilFourni(appareil.getIdAppareil(), GetIdFournisseur(listeFournisseur.Text)),GetSiteAppareilFourni(appareil.getIdAppareil(),GetIdFournisseur(listeFournisseur.Text)),appareil);
            laModificationAffiliationAppareil laModificationAffiliationAppareil = new laModificationAffiliationAppareil();
            laModificationAffiliationAppareil.ShowDialog();
        }

        private void listeFournisseur_Click(object sender, EventArgs e)
        {
            if(listeFournisseur.Text == "")
            {
                return;
            }
            boutonModifier.Enabled = true;

        }

    }
}
