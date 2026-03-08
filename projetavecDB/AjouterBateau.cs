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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

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
            MySqlDataReader jeuEnr = null; // Initialisation pour éviter CS0165
            maCnx.Open();
            try
            {
                string requete = "INSERT INTO bateau(NOM) Values (@nom)";
                var maCde = new MySqlCommand(requete, maCnx);
                string nom = tbxChoisie.Text;
                maCde.Parameters.AddWithValue("@nom", nom);
                int rowsAffected = maCde.ExecuteNonQuery();
                MessageBox.Show("Bateau c'est bon !");

                // Ajout des capacités par catégorie
                foreach (Control control in grpbxCapacite.Controls)
                {
                    if (control is TextBox tbx)
                    {
                        string lettreCategorie = (string)tbx.Tag;
                        int capaciteMax = int.Parse(tbx.Text);
                        string nom2 = tbxChoisie.Text;

                        string requete2 = "INSERT INTO contenir(LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@lettreCategorie, (SELECT NOBATEAU FROM bateau WHERE NOM = @nom2), @capaciteMax)";
                        var maCde2 = new MySqlCommand(requete2, maCnx);
                        maCde.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                        maCde.Parameters.AddWithValue("@nom2", nom2);
                        maCde.Parameters.AddWithValue("@capaciteMax", capaciteMax);
                        maCde.ExecuteNonQuery();
                        MessageBox.Show("Tout a été ajouter c'est bon !");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (maCnx is object && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

        }
        private void AjouterBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
            MySqlDataReader jeuEnr = null; // Initialisation pour éviter CS0165
            maCnx.Open();
            try
            {
                string requête;
                Label lblCategorie;
                TextBox tbx;
                int i = 2;
                requête = "select * from categorie";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Categorie t = new Categorie((string)jeuEnr["lettrecategorie"], (string)jeuEnr["libelle"]);
                    lblCategorie = new Label();
                    lblCategorie.Text = t.ToString();
                    lblCategorie.Location = new Point(15, 25 * i);
                    lblCategorie.AutoSize = true;
                    grpbxCapacite.Controls.Add(lblCategorie);
                    tbx = new TextBox();
                    tbx.Location = new Point(150, 25 * i);
                    tbx.AutoSize = true;
                    tbx.Tag = t.GetLettrecategorie(); // Modification ici
                    grpbxCapacite.Controls.Add(tbx);
                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (jeuEnr is object && !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }

                if (maCnx is object && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }
    }
}
