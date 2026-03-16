using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
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
            try { 
                MySqlConnection maCnx;
                string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
                maCnx = new MySqlConnection(CHAINECONNEXION);
                maCnx.Open();

                MySqlCommand maCde;
                MySqlDataReader jeuEnregistrements;
                string requete = "INSERT INTO secteur(NOM) Values (@nom)";
                maCde = new MySqlCommand(requete, maCnx);
                string nom = tbxChoisie.Text;
                maCde.Parameters.AddWithValue("@nom", nom);
                jeuEnregistrements = maCde.ExecuteReader();
                while (jeuEnregistrements.Read())
                {
                    MessageBox.Show(e.ToString());
                }
                    MessageBox.Show("Secteur Ajouté avec succès !");
                maCnx.Close();
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void tbxChoisie_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            var résultatTest = objetRegEx.Match(tbxChoisie.Text);
            if (!résultatTest.Success)
            {   
                if (tbxChoisie.Text == "")
                {
                    tbxChoisie.BackColor = Color.Red;
                    e.Cancel = true;
                    pbSaisie.SetError(tbxChoisie, "Saisir un Secteur !");
                }
                else
                {
                    tbxChoisie.BackColor = Color.Red;
                    e.Cancel = true;
                    pbSaisie.SetError(tbxChoisie, "Saisir un Secteur !");
                }
                tbxChoisie.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbxChoisie, "Saisir un Secteur !");
            }
            else
            {
                // OK : Fond de la zone de saisie passe en vert
                tbxChoisie.BackColor = Color.Green;
                pbSaisie.Clear();
            }
        }
    }
}

