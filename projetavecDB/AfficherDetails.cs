using MySql.Data.MySqlClient;
using Mysqlx.Session;
using projetavecDB.projetavecDB;
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
    public partial class AfficherDetails : Form
    {
        public AfficherDetails()
        {
            InitializeComponent();
        }

        private void AfficherDetails_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            maCnx.Open();
            try
            {
                string requête = "select * from client";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Client c = new Client((int)jeuEnr["noclient"], (string)jeuEnr["nom"], (string)jeuEnr["prenom"]);
                    cmbNom.Items.Add(c);
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

        private void cmbNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvReservation.GridLines = true;
            lvReservation.Items.Clear();
            lvReservation.Columns.Clear();
            lvReservation.View = View.Details;
            lvReservation.Columns.Add("N° Reservation", 100);
            lvReservation.Columns.Add("Liaison", 150);
            lvReservation.Columns.Add("N° Traversée", 80);
            lvReservation.Columns.Add("Date Départ", 120);

            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                maCnx.Open();
                string requête = "select NORESERVATION, reservation.NOTRAVERSEE, DATEHEURE from reservation inner join traversee on reservation.NOTRAVERSEE = traversee.NOTRAVERSEE inner join liaison on traversee.NOLIAISON = liaison.NOLIAISON inner join client on reservation.NOCLIENT = client.NOCLIENT where client.noclient = 1";

                var maCde = new MySqlCommand(requête, maCnx);


                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    string noreservation = jeuEnr["NORESERVATION"].ToString();
                    string notraversee = jeuEnr["NOTRAVERSEE"].ToString();
                    string liaison = GetLiaison(notraversee);
                    string dateheure = ((DateTime)jeuEnr["DATEHEURE"]).ToString("dd/MM/yyyy à HH:mm");

                    ListViewItem position = new ListViewItem(noreservation);
                    position.SubItems.Add(liaison);
                    position.SubItems.Add(notraversee);
                    position.SubItems.Add(dateheure);
                    lvReservation.Items.Add(position);
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
        private string GetLiaison(string noTraversee)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;

            try
            {
                maCnx.Open();
                string requete = "select p1.nom as 'nomport_depart', p2.nom as 'nomport_arrivee', li.noliaison from liaison li inner join port p1 on li.NOPORT_DEPART = p1.noport inner join port p2 on li.NOPORT_ARRIVEE = p2.noport inner join traversee on traversee.NOLIAISON = li.NOLIAISON where traversee.notraversee = @notraversee";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noTraversee", noTraversee);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    Liaison p = new Liaison((string)jeuEnr["nomport_depart"], (string)jeuEnr["nomport_arrivee"], (int)jeuEnr["noliaison"]);
                    return p.ToString();
                }
                return "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString());
                return "";
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
