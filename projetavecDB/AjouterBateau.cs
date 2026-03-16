using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace projetavecDB
{
    public partial class AjouterBateau : Form
    {
        public AjouterBateau()
        {
            InitializeComponent();
        }
        ErrorProvider pbSaisie = new ErrorProvider();

        private void btnValider_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
            MySqlDataReader jeuEnr = null;
            maCnx.Open();


            try
            {
                string requete = "INSERT INTO bateau(NOM) Values (@nom)";
                var maCde = new MySqlCommand(requete, maCnx);
                string nom = tbxChoisie.Text;
                maCde.Parameters.AddWithValue("@nom", nom);
                maCde.ExecuteNonQuery();

                int nobateau = 0;
                foreach (Control control in gbxCapacite.Controls)
                {
                    if (control is TextBox tbx)
                    {
                        string type = control.Tag.ToString();
                        string[] word = type.Split(';');
                        string lettreCategorie = word[0];
                        int capaciteMax = int.Parse(tbx.Text);
                        nobateau = int.Parse(maCde.LastInsertedId.ToString());
 

                        string requete2 = "INSERT INTO contenir (lettrecategorie, nobateau, capacitemax) VALUES (@lettreCategorie, @noBateau, @capaciteMax)";
                        var maCde2 = new MySqlCommand(requete2, maCnx);
                        maCde2.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                        maCde2.Parameters.AddWithValue("@noBateau", nobateau);
                        maCde2.Parameters.AddWithValue("@capaciteMax", capaciteMax);
                        maCde2.ExecuteNonQuery();
                        
                    }
                }
                MessageBox.Show("Tout a été ajouter c'est bon !");
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
        private void AjouterBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
            MySqlDataReader jeuEnr = null;
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
                    gbxCapacite.Controls.Add(lblCategorie);
                    tbx = new TextBox();
                    tbx.Location = new Point(150, 25 * i);
                    tbx.AutoSize = true;
                    tbx.Tag = t.GetLettrecategorie() + ";" + t.GetLibelle();
                    tbx.Validating += tbxCapacite_Validating;
                    gbxCapacite.Controls.Add(tbx);
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
                    jeuEnr.Close(); 
                }

                if (maCnx is object && maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
        private void tbxCapacite_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            if (tbx.Text == "" || !int.TryParse(tbx.Text, out int valeur) || valeur <= 0)
            {
                tbx.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbx, "Veuillez saisir un nombre entier supérieur à 0 !");
            }
            else
            {
                tbx.BackColor = Color.Green;
                pbSaisie.SetError(tbx, "");
            }
        }

        private void tbxChoisie_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî -]+$");
            var résultatTest = objetRegEx.Match(tbxChoisie.Text);

            if (tbxChoisie.Text == "" || !résultatTest.Success)
            {
                tbxChoisie.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbxChoisie, "Saisir un secteur valide !");
            }
            else
            {
                tbxChoisie.BackColor = Color.Green;
                pbSaisie.Clear();
            }

        }
    }
}
