using MySql.Data.MySqlClient;
using System;  
using System.Data;
using System.Drawing;
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

            try
            {
                maCnx.Open();
                string requête = "select * from PERIODE";

                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Periode date = new Periode((short)jeuEnr["noperiode"], (DateTime)jeuEnr["datedebut"], (DateTime)jeuEnr["datefin"]);
                    cmbxdate.Items.Add(date);
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
                Label lblCategorie;
                TextBox tbx;
                int i = 2;
                maCnx.Open();
                requête = "select * from type";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    
                    Type t = new Type((string)jeuEnr["lettrecategorie"], (short)jeuEnr["notype"], (string)jeuEnr["libelle"]);
                    lblCategorie = new Label();
                    lblCategorie.Text = t.ToString();
                    lblCategorie.Location = new Point(15,25*i);
                    lblCategorie.AutoSize = true;
                    grpbxTarif.Controls.Add(lblCategorie);
                    tbx = new TextBox();
                    tbx.Location = new Point(150, 25 * i);
                    tbx.AutoSize = true;
                    tbx.Tag = t.getLettrecategorie() + ";" + t.getNotype().ToString();
                    grpbxTarif.Controls.Add(tbx);
                    i++;

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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            try
            {
                string requête;
                int noLiaison = ((Liaison)cmbLiaison.SelectedItem).Getnoliaison();
                int noperiode = ((Periode)cmbxdate.SelectedItem).Getnoperiode();
                cmbLiaison.Items.Clear();
                maCnx.Open();
                requête = "insert into tarifer values (@noperiode,@lettrecategorie,@notype,@noliaison,@tarif)";
                foreach (Control c in grpbxTarif.Controls)
                {
                    if (c is TextBox tbx)
                    {
                        string type = c.Tag.ToString();
                        string[] word = type.Split(';');
                        string lettrecategorie = word[0];
                        int notype = int.Parse(word[1]);
                        double tarif = double.Parse(c.Text);
                        var maCde = new MySqlCommand(requête, maCnx);
                        maCde.Parameters.AddWithValue("@noperiode", noperiode);
                        maCde.Parameters.AddWithValue("@lettrecategorie",lettrecategorie);
                        maCde.Parameters.AddWithValue("@notype", notype);
                        maCde.Parameters.AddWithValue("@noliaison", noLiaison);
                        maCde.Parameters.AddWithValue("@tarif", tarif);
                        maCde.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tarifs ajoutée avec succès !");
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

    }
}
