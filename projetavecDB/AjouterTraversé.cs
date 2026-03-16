using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace projetavecDB
{
    public partial class AjouterTraversé : Form
    {
        public AjouterTraversé()
        {
            InitializeComponent();
        }
        ErrorProvider pbSaisie = new ErrorProvider();

        private void AjouterTraversé_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            maCnx.Open();
            try
            {
                string requête = "select * from Bateau";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Bateau p = new Bateau((int)jeuEnr["nobateau"], (string)jeuEnr["nom"]);
                    cmbBateau.Items.Add(p);
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

            try
            {
                maCnx.Open();
                string requête = "select * from secteur";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Secteur s = new Secteur((int)jeuEnr["noSecteur"], (string)jeuEnr["nom"]);
                    lbxSecteur.Items.Add(s);
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

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {

            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            cmbLiaison.Items.Clear();
            try
            {
                int noSecteur = ((Secteur)lbxSecteur.SelectedItem).GetNoSecteur();
                maCnx.Open();
                string requête = "select *, p1.nom as 'nomport_depart', p2.nom as 'nomport_arrivee' from liaison li inner join port p1 on (li.NOPORT_DEPART = p1.noport) inner join port p2 on (li.NOPORT_ARRIVEE = p2.noport) where nosecteur = @noSecteur";

                var maCde = new MySqlCommand(requête, maCnx);

                maCde.Parameters.AddWithValue("@noSecteur", noSecteur);

                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Liaison p = new Liaison((string)jeuEnr["nomport_depart"], (string)jeuEnr["nomport_arrivee"], (int)jeuEnr["noliaison"]);
                    cmbLiaison.Items.Add(p);

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

        private void btnValider_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;

            if (cmbBateau.SelectedItem == null || cmbLiaison.SelectedItem == null || lbxSecteur.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            try
            {
                maCnx.Open();

                string requête = "Insert into traversee(noliaison,nobateau,dateheuredepart,dateheurearrivee) Values (@noliaison,@nobateau,@dateheuredepart,@dateheurearrivee)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).Getnoliaison());
                maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbBateau.SelectedItem).GetNobateau());
                maCde.Parameters.AddWithValue("@dateheuredepart", DateTime.Parse(dtpDepartDate.Text + " " + dtpDepartHeure.Text));
                maCde.Parameters.AddWithValue("@dateheurearrivee", DateTime.Parse(dtpArriveeDate.Text + " " + dtpArriveeHeure.Text));
                maCde.ExecuteNonQuery();
                MessageBox.Show("Traversee ajoutée avec succès !");


            
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

        private void dtpArriveDate_ValueChanged(object sender, EventArgs e)
        {
            dtpArriveeDate.MinDate = dtpDepartDate.Value;
        }

        private void dtpArriveeHeure_ValueChanged(object sender, EventArgs e)
        {
            dtpArriveeHeure.MinDate = dtpDepartHeure.Value;
        }

        private void cmbBateau_Validating(object sender, CancelEventArgs e)
        {
            if (cmbBateau.SelectedItem == null)
            {
                e.Cancel = true;
                pbSaisie.SetError(cmbBateau, "Veuillez sélectionner un bateau !");
            }
            else
            {
                pbSaisie.SetError(cmbBateau, "");
            }
        }

        private void cmbLiaison_Validating(object sender, CancelEventArgs e)
        {
            if (cmbLiaison.SelectedItem == null)
            {
                e.Cancel = true;
                pbSaisie.SetError(cmbLiaison, "Veuillez sélectionner une liaison !");
            }
            else
            {
                pbSaisie.SetError(cmbLiaison, "");
            }
        }

        private void lbxSecteur_Validating(object sender, CancelEventArgs e)
        {
            if (lbxSecteur.SelectedItem == null)
            {
                e.Cancel = true;
                pbSaisie.SetError(lbxSecteur, "Veuillez sélectionner un secteur !");
            }
            else
            {
                pbSaisie.SetError(lbxSecteur, "");
            }
        }
    }
}
