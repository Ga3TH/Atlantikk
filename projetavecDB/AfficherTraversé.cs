using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using projetavecDB.projetavecDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace projetavecDB
{
    public partial class AfficherTraversé : Form
    {
        ErrorProvider pbSaisie = new ErrorProvider();

        private int GetQuantiteEnregistree(int noTraversee, string lettreCategorie)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;

            try
            {
                maCnx.Open();
                string requete = "SELECT quantitereservee from enregistrer inner join reservation on enregistrer.noreservation = reservation.noreservation inner join traversee on reservation.notraversee = traversee.notraversee where reservation.NOTRAVERSEE = @noTraversee and enregistrer.LETTRECATEGORIE = @lettreCategorie";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noTraversee", noTraversee);
                maCde.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    return (int)jeuEnr["quantitereservee"];
                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
                return 0;
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close();
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();

                }
            }
        }

        private List<Categorie> GetLesCategories()
        {
            List<Categorie> lesCategories = new List<Categorie>();
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                maCnx.Open();
                string requete = "select * from categorie";
                var maCde = new MySqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Categorie c = new Categorie((string)jeuEnr["lettrecategorie"], (string)jeuEnr["libelle"]);
                    lesCategories.Add(c);
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
                    jeuEnr.Close();
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();

                }
            }
            return lesCategories;
        }

        private List<Classe_traversee> GetLesTraverseesBateaux(int noliaison, string dateTraversee)
        {
            List<Classe_traversee> lesTraversee = new List<Classe_traversee>();
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                maCnx.Open();
                string requete = "SELECT traversee.NOTRAVERSEE, traversee.NOLIAISON, traversee.NOBATEAU, bateau.NOM, DATEHEUREDEPART FROM traversee INNER JOIN bateau ON traversee.NOBATEAU = bateau.NOBATEAU WHERE traversee.noliaison = @noliaison AND DATE(traversee.dateheuredepart) = @dateheuredepart";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noliaison", noliaison);
                maCde.Parameters.AddWithValue("@dateheuredepart", dateTraversee);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Classe_traversee t = new Classe_traversee((int)jeuEnr["notraversee"], (int)jeuEnr["noliaison"], (int)jeuEnr["nobateau"], (DateTime)jeuEnr["dateheuredepart"]);
                    lesTraversee.Add(t);
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
                    jeuEnr.Close();
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();

                }
            }
            return lesTraversee;
        }

        private int GetCapaciteMaximale(int noTraversee, string lettreCategorie)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;

            try
            {
                maCnx.Open();
                string requete = "SELECT capacitemax from contenir inner join bateau on contenir.NOBATEAU = bateau.NOBATEAU inner join traversee on bateau.NOBATEAU = traversee.NOBATEAU where traversee.notraversee = @nobateau and contenir.LETTRECATEGORIE = @lettrecategorie";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@nobateau", noTraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    return (int)jeuEnr["capacitemax"];
                }
                return 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
                return 0;
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close();
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();

                }
            }

        }
        public AfficherTraversé()
        {
            InitializeComponent();
        }

        private void AfficherTraversé_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            maCnx.Open();
            try
            {
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
                    jeuEnr.Close(); 
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); 

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
                    jeuEnr.Close(); 
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); 

                }
            }
        }

        private void lblAfficher_Click(object sender, EventArgs e)
        {
            lvTraversee.GridLines = true;
            lvTraversee.Items.Clear();
            lvTraversee.Columns.Clear();
            lvTraversee.View = View.Details;
            lvTraversee.Columns.Add("N°", 60);
            lvTraversee.Columns.Add("Heure", 60);
            lvTraversee.Columns.Add("Bateau", 80);

            List<Categorie> lesCategories = GetLesCategories();
            foreach (Categorie c in lesCategories)
            {
                lvTraversee.Columns.Add(c.GetLettrecategorie() + " " + c.GetLibelle(), 90);
            }

            if (cmbLiaison.SelectedItem == null)
            {
                MessageBox.Show("Selectionne une liaison ho tu t'es cru où là !");
                return;
            }


            int noLiaison = ((Liaison)cmbLiaison.SelectedItem).Getnoliaison();
            string dateTraversee = dtpDepartDate.Value.ToString("yyyy-MM-dd");
            List<Classe_traversee> lesTraversees = GetLesTraverseesBateaux(noLiaison, dateTraversee);

            foreach (Classe_traversee t in lesTraversees)
            {
                MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                MySqlDataReader jeuEnr = null;
                string nomBateau = "";

                try
                {
                    string requête;
                    maCnx.Open();
                    requête = "SELECT nom FROM bateau WHERE nobateau = @nobateau";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@nobateau", t.GetNobateau());
                    jeuEnr = maCde.ExecuteReader();
                    while (jeuEnr.Read())
                    {
                        nomBateau = (string)jeuEnr["nom"];
                    }

                    ListViewItem item = new ListViewItem(t.GetNotraversee().ToString());
                    item.SubItems.Add(t.GetDateheuredepart().ToString("HH:mm"));
                    item.SubItems.Add(nomBateau);

                    foreach (Categorie c in lesCategories)
                    {
                        int placesRestantes = GetCapaciteMaximale(t.GetNotraversee(), c.GetLettrecategorie()) - GetQuantiteEnregistree(t.GetNotraversee(), c.GetLettrecategorie());
                        item.SubItems.Add(placesRestantes.ToString());
                    }

                    lvTraversee.Items.Add(item);
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
    }
}