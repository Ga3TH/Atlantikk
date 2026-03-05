using MySql.Data.MySqlClient;
using System;  
using System.Data;
using System.Windows.Forms;

namespace projetavecDB
{
    public partial class AjouterTarif : Form
    {
        public AjouterTarif()
        {
            InitializeComponent();
        }

        private void AjouterTarif_Load(object sender, EventArgs e)
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
        }

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            cmbLiaison.Items.Clear();
            try
            {
                string requête;
                int noSecteur = ((Secteur)lbxSecteurs.SelectedItem).GetNoSecteur();
                maCnx.Open();
                requête = "select *, p1.nom as 'nomport_depart', p2.nom as 'nomport_arrivee' from liaison li inner join port p1 on (li.NOPORT_DEPART = p1.noport) inner join port p2 on (li.NOPORT_ARRIVEE = p2.noport) where nosecteur = @noSecteur";

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
    }
}
