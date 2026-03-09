using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projetavecDB
{
    public partial class ModifierBateau : Form
    {
        public ModifierBateau()
        {
            InitializeComponent();
        }

        private void ModifierBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
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
                string requête;
                Label lblCategorie;
                TextBox tbx;
                int i = 2;
                maCnx.Open();
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

        private void cmbBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
            MySqlDataReader jeuEnr = null;
            maCnx.Open();
            try
            {
                string request = "Select * from contenir where nobateau = @nobateau and lettrecategorie = @lettrecategorie";
                foreach (Control c in gbxCapacite.Controls)
                {
                    if (c is TextBox tbx )
                    {
                        var maCde = new MySqlCommand(request, maCnx);
                        maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbBateau.SelectedItem).GetNobateau());
                        string[] parts = tbx.Tag.ToString().Split(';');
                        string lettreCategorie = parts[0];
                        maCde.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                        jeuEnr = maCde.ExecuteReader();
                        while (jeuEnr.Read())
                        {
                            tbx.Text = jeuEnr["capacitemax"].ToString();
                        }
                        jeuEnr.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "KO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

            private void btnValider_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
            MySqlDataReader jeuEnr = null;
            maCnx.Open();
            try
            {
                int nobateau = 0;
                foreach (Control control in gbxCapacite.Controls)
                {
                    if (control is TextBox tbx)
                    {
                        string type = control.Tag.ToString();
                        string[] word = type.Split(';');
                        string lettreCategorie = word[0];
                        int capaciteMax = int.Parse(tbx.Text);
                        nobateau = ((Bateau)cmbBateau.SelectedItem).GetNobateau();


                        string requete2 = "Update contenir set capaciteMax = @capaciteMax where nobateau = @nobateau and lettrecategorie =@lettrecategorie ";
                        var maCde2 = new MySqlCommand(requete2, maCnx);
                        maCde2.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                        maCde2.Parameters.AddWithValue("@noBateau", nobateau);
                        maCde2.Parameters.AddWithValue("@capaciteMax", capaciteMax);
                        maCde2.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("La Modification a été effectué !");
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
    }
}
