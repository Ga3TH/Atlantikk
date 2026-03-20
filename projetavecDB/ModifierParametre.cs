using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class ModifierParametre : Form
    {
        public ModifierParametre()
        {
            InitializeComponent();
        }
        ErrorProvider pbSaisie = new ErrorProvider();

        private void ModifierParametre_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                maCnx.Open();
                string requête = "select * from parametres";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    tbxSite.Text = jeuEnr["site_pb"].ToString();
                    tbxRang.Text = jeuEnr["rang_pb"].ToString();
                    tbxIdentifiant.Text = jeuEnr["identifiant_pb"].ToString();
                    tbxCleHMAC.Text = jeuEnr["cleHMAC_pb"].ToString();
                    cbxProd.Checked = (bool)jeuEnr["enProduction"];
                    tbxMail.Text = jeuEnr["melsite"].ToString();
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString() + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]+$");
            var objetRegExMel = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");

            if (tbxSite.Text == "")
            {
                tbxSite.BackColor = Color.Red;
                pbSaisie.SetError(tbxSite, "Veuillez saisir un site !");
                return;
            }
            if (tbxRang.Text == "" || !objetRegEx.IsMatch(tbxRang.Text))
            {
                tbxRang.BackColor = Color.Red;
                pbSaisie.SetError(tbxRang, "Veuillez saisir un rang entier valide !");
                return;
            }
            if (tbxIdentifiant.Text == "" || !objetRegEx.IsMatch(tbxIdentifiant.Text))
            {
                tbxIdentifiant.BackColor = Color.Red;
                pbSaisie.SetError(tbxIdentifiant, "Veuillez saisir un identifiant entier valide !");
                return;
            }
            if (tbxCleHMAC.Text == "")
            {
                tbxCleHMAC.BackColor = Color.Red;
                pbSaisie.SetError(tbxCleHMAC, "Veuillez saisir une clé HMAC !");
                return;
            }
            if (tbxMail.Text == "" || !objetRegExMel.IsMatch(tbxMail.Text))
            {
                tbxMail.BackColor = Color.Red;
                pbSaisie.SetError(tbxMail, "Mail invalide !");
                return;
            }

            tbxSite.BackColor = Color.Green;
            tbxRang.BackColor = Color.Green;
            tbxIdentifiant.BackColor = Color.Green;
            tbxCleHMAC.BackColor = Color.Green;
            tbxMail.BackColor = Color.Green;

            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                maCnx.Open();
                string requête = "update parametres set site_pb = @site, rang_pb = @rang, identifiant_pb = @identifiant, cleHMAC_pb = @cleHMAC, enproduction = @enproduction, melsite = @melsite";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@site", tbxSite.Text);
                maCde.Parameters.AddWithValue("@rang", tbxRang.Text);
                maCde.Parameters.AddWithValue("@identifiant", tbxIdentifiant.Text);
                maCde.Parameters.AddWithValue("@cleHMAC", tbxCleHMAC.Text);
                maCde.Parameters.AddWithValue("@enproduction", cbxProd.Checked);
                maCde.Parameters.AddWithValue("@melsite", tbxMail.Text);
                maCde.ExecuteNonQuery();
                MessageBox.Show("Paramètres modifiés avec succès !");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (jeuEnr is object && !jeuEnr.IsClosed) jeuEnr.Close();
                if (maCnx is object && maCnx.State == ConnectionState.Open) maCnx.Close();
            }
        }
        private void tbxSite_Validating(object sender, CancelEventArgs e)
        {
            if (tbxSite.Text == "")
            {
                tbxSite.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbxSite, "Veuillez saisir un site !");
            }
            else
            {
                tbxSite.BackColor = Color.Green;
                pbSaisie.SetError(tbxSite, "");
            }
        }

        private void tbxRang_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]+$");
            if (tbxRang.Text == "" || !objetRegEx.IsMatch(tbxRang.Text))
            {
                tbxRang.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbxRang, "Veuillez saisir un rang entier valide !");
            }
            else
            {
                tbxRang.BackColor = Color.Green;
                pbSaisie.SetError(tbxRang, "");
            }
        }
        private void tbxIdentifiant_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]+$");
            if (tbxIdentifiant.Text == "" || !objetRegEx.IsMatch(tbxIdentifiant.Text))
            {
                tbxIdentifiant.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbxIdentifiant, "Veuillez saisir un identifiant entier valide !");
            }
            else
            {
                tbxIdentifiant.BackColor = Color.Green;
                pbSaisie.SetError(tbxIdentifiant, "");
            }
        }

        private void tbxCleHMAC_Validating(object sender, CancelEventArgs e)
        {
            if (tbxCleHMAC.Text == "")
            {
                tbxCleHMAC.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbxCleHMAC, "Veuillez saisir une clé HMAC !");
            }
            else
            {
                tbxCleHMAC.BackColor = Color.Green;
                pbSaisie.SetError(tbxCleHMAC, "");
            }
        }

        private void tbxMail_Validating(object sender, CancelEventArgs e)
        {
            var objetRegExMel = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
            if (tbxMail.Text == "" || !objetRegExMel.IsMatch(tbxMail.Text))
            {
                tbxMail.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbxMail, "Mail invalide !");
            }
            else
            {
                tbxMail.BackColor = Color.Green;
                pbSaisie.SetError(tbxMail, "");
            }
        }
    }
}
