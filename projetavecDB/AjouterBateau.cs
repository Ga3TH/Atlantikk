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

namespace projetavecDB
{
    public partial class AjouterBateau : Form
    {
        public AjouterBateau()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
            maCnx.Open();

            MySqlCommand maCde;
            MySqlDataReader jeuEnregistrements;
            string requete = "INSERT INTO bateau(NOM) Values (@nom)";
            maCde = new MySqlCommand(requete, maCnx);
            string nom = tbxChoisie.Text;
            maCde.Parameters.AddWithValue("@nom", nom);
            jeuEnregistrements = maCde.ExecuteReader();
            MessageBox.Show("Secteur Ajouté avec succès !");

            while (jeuEnregistrements.Read())
            {
                MessageBox.Show(e.ToString());
            }
            maCnx.Close();
        }

        private void AjouterBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
            maCnx.Open();
            try
            {
                string requête;
                Label lblCategorie;
                TextBox tbx;
                int i = 2;
                maCnx.Open();
                requête = "select * from type";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {

                    Type t = new Type((string)jeuEnr["lettrecategorie"], (short)jeuEnr["notype"], (string)jeuEnr["libelle"]);
                    lblCategorie = new Label();
                    lblCategorie.Text = t.ToString();
                    lblCategorie.Location = new Point(15, 25 * i);
                    lblCategorie.AutoSize = true;
                    grpbxTarif.Controls.Add(lblCategorie);
                    tbx = new TextBox();
                    tbx.Location = new Point(150, 25 * i);
                    tbx.AutoSize = true;
                    tbx.Tag = t.getLettrecategorie() + ";" + t.getNotype().ToString();
                    grpbxTarif.Controls.Add(tbx);
                    i++;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte

                }
            }
        }
    }
}
