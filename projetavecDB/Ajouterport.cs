using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetavecDB
{
    public partial class Ajouterport : Form
    {
        public Ajouterport()
        {
            InitializeComponent();
        }
        ErrorProvider pbSaisie = new ErrorProvider();

        private void btnValider_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            maCnx.Open();

            if (tbxChoisie.Text == "")
            {
                MessageBox.Show("Veuillez saisir un secteur !");
                return;
            }
            try 
            { 
                MySqlCommand maCde;
                string requete = "INSERT INTO port(NOM) Values (@nom)";
                maCde = new MySqlCommand(requete, maCnx);
                string nom = tbxChoisie.Text;
                maCde.Parameters.AddWithValue("@nom", nom);
                maCde.ExecuteNonQuery();
                MessageBox.Show("Port Ajouté avec succès !");
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
