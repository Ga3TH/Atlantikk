using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class AjouterLiaison : Form
    {
        public AjouterLiaison()
        {
            InitializeComponent();
        }

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
            Console.ReadLine();

            try
            {
                string requête;
                maCnx.Open();
                requête = "select * from port";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    port p = new port((int)jeuEnr["noPort"], (string)jeuEnr["nom"]);
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
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            try
            {
                string requête;
                int noPortDepart = ((port)cmbDepart.SelectedItem).GetNoPort();
                int noPortArrivee = ((port)cmbArrivée.SelectedItem).GetNoPort();
                int noSecteur = ((Secteur)lbxSecteurs.SelectedItem).GetNoSecteur();
                string distance = tbxDistance.Text;
                maCnx.Open();
                requête = "insert into liaison(noport_depart,nosecteur,noport_arrivee,distance) values (@noPortDepart, @noSecteur, @noPortArrivee, @distance)";
                var maCde = new MySqlCommand(requête, maCnx);
                
                maCde.Parameters.AddWithValue("@noPortDepart", noPortDepart);
                maCde.Parameters.AddWithValue("@noPortArrivee", noPortArrivee);
                maCde.Parameters.AddWithValue("@noSecteur", noSecteur);
                maCde.Parameters.AddWithValue("@distance", distance);

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
            Console.ReadLine();
        }
    }
}   

        
