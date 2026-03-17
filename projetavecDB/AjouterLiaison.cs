using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class AjouterLiaison : Form
    {
        public AjouterLiaison()
        {
            InitializeComponent();
        }
        ErrorProvider pbSaisie = new ErrorProvider();

        private void AjouterLiaison_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "select * from secteur";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Secteur s = new Secteur((int)jeuEnr["noSecteur"], (string)jeuEnr["nom"]);
                    lbxSecteurs.Items.Add(s);
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

            try
            {
                string requête;
                maCnx.Open();
                requête = "select * from port";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Port p = new Port((int)jeuEnr["noPort"], (string)jeuEnr["nom"]);
                    cmbArrivée.Items.Add(p);
                    cmbDepart.Items.Add(p);
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
            Console.ReadLine();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");

            if (cmbDepart.SelectedItem == null || cmbArrivée.SelectedItem == null || lbxSecteurs.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un port de départ, un port d'arrivée et un secteur !");
                return;
            }

            try
            {
                string requête;
                int noPortDepart = ((Port)cmbDepart.SelectedItem).GetNoPort();
                int noPortArrivee = ((Port)cmbArrivée.SelectedItem).GetNoPort();
                int noSecteur = ((Secteur)lbxSecteurs.SelectedItem).GetNoSecteur();
                string distance = tbxDistance.Text;
                maCnx.Open();
                requête = "insert into liaison(noport_depart,nosecteur,noport_arrivee,distance) values (@noPortDepart, @noSecteur, @noPortArrivee, @distance)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noPortDepart", noPortDepart);
                maCde.Parameters.AddWithValue("@noPortArrivee", noPortArrivee);
                maCde.Parameters.AddWithValue("@noSecteur", noSecteur);
                maCde.Parameters.AddWithValue("@distance", distance);
                maCde.ExecuteNonQuery();
                MessageBox.Show("Liaison ajoutée avec succès !");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte

                }
            }
        }

        private void lbxSecteurs_Validating(object sender, CancelEventArgs e)
        {
            if (lbxSecteurs.SelectedItem == null)
            {
                e.Cancel = true;
                pbSaisie.SetError(lbxSecteurs, "Veuillez sélectionner un secteur !");
            }
            else
            {
                pbSaisie.SetError(lbxSecteurs, "");
            }
        }

        private void cmbDepart_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDepart.SelectedItem == null)
            {
                e.Cancel = true;
                pbSaisie.SetError(cmbDepart, "Veuillez sélectionner un port de départ !");
            }
            else
            {
                pbSaisie.SetError(cmbDepart, "");
            }
        }

        private void cmbArrivée_Validating(object sender, CancelEventArgs e)
        {
            if (cmbArrivée.SelectedItem == null)
            {
                e.Cancel = true;
                pbSaisie.SetError(cmbArrivée, "Veuillez sélectionner un port d'arrivée !");
            }
            else
            {
                pbSaisie.SetError(cmbArrivée, "");
            }
        }

        private void tbxDistance_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex(@"^\d+([.,]\d{1,2})?$");
            if (tbxDistance.Text == "" || !objetRegEx.IsMatch(tbxDistance.Text))
            {
                tbxDistance.BackColor = Color.Red;
                e.Cancel = true;
                pbSaisie.SetError(tbxDistance, "Veuillez saisir une distance valide (ex: 8.30) !");
            }
            else
            {
                tbxDistance.BackColor = Color.Green;
                pbSaisie.SetError(tbxDistance, "");
            }
        }
    }
}   

        
