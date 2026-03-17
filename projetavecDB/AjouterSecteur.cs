using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace projetavecDB
{
    public partial class AjouterSecteur : Form
    {
        public AjouterSecteur()
        {
            InitializeComponent();
        }
        ErrorProvider pbSaisie = new ErrorProvider();
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (tbxChoisie.Text == "")
            {
                MessageBox.Show("Veuillez saisir un secteur !");
                return;
            }
            try { 
                MySqlConnection maCnx;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx.Open();

                MySqlCommand maCde;
                string requete = "INSERT INTO secteur(NOM) Values (@nom)";
                maCde = new MySqlCommand(requete, maCnx);
                string nom = tbxChoisie.Text;
                maCde.Parameters.AddWithValue("@nom", nom);
                maCde.ExecuteNonQuery();
                MessageBox.Show("Secteur Ajouté avec succès !");
                maCnx.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            
        }

        private void tbxChoisie_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôùûïî-]+$");
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

