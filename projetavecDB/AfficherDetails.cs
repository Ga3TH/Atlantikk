using Google.Protobuf.WellKnownTypes;
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
            lvReservation.FullRowSelect = true;
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

        private void lvReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvReservation.SelectedItems.Count != 0)
            {

                MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                MySqlDataReader jeuEnr = null;
                try
                {
                    gbxCaracteristiques.Controls.Clear();
                    string requête;
                    Label lblCategorie, lblValeur, lblMontant, lblValeurMontant, lblreglement;
                    int i = 2;
                    int noReservation = int.Parse(lvReservation.SelectedItems[0].Text);
                    maCnx.Open();
                    requête = "SELECT * from enregistrer inner join type on enregistrer.NOTYPE = type.NOTYPE inner join reservation on  enregistrer.NORESERVATION = reservation.NORESERVATION where type.LETTRECATEGORIE= enregistrer.LETTRECATEGORIE and enregistrer.NOTYPE = type.NOTYPE and enregistrer.NORESERVATION = @noreservation";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@noreservation", noReservation);
                    jeuEnr = maCde.ExecuteReader();

                    while (jeuEnr.Read())
                    {

                        string libelle = (string)jeuEnr["libelle"];
                        int valeur = (int)jeuEnr["quantitereservee"];

                        lblCategorie = new Label();
                        lblCategorie.Text = libelle;
                        lblCategorie.Location = new Point(15, 25 * i);
                        lblCategorie.AutoSize = true;
                        gbxCaracteristiques.Controls.Add(lblCategorie);

                        lblValeur = new Label();
                        lblValeur.Text = ":   " + valeur.ToString();
                        lblValeur.Location = new Point(150, 25 * i);
                        lblValeur.AutoSize = true;
                        gbxCaracteristiques.Controls.Add(lblValeur);

                        i++;

                    }
                    double Montant = (double)jeuEnr["montanttotal"];
                    lblMontant = new Label();
                    lblMontant.Text = "Montant total : ";
                    lblMontant.Location = new Point(15, 25 * i);
                    lblMontant.AutoSize = true;
                    gbxCaracteristiques.Controls.Add(lblMontant);

                    lblValeurMontant = new Label();
                    lblValeurMontant.Text = Montant.ToString() + "€";
                    lblValeurMontant.Location = new Point(150, 25 * i);
                    lblValeurMontant.AutoSize = true;
                    gbxCaracteristiques.Controls.Add(lblValeurMontant);
                    i++;
                    string reglement = (string)jeuEnr["modereglement"];
                    lblreglement = new Label();
                    lblreglement.Text = "Reglé par " + reglement;
                    lblreglement.Location = new Point(15, 25 * i + 1);
                    lblreglement.AutoSize = true;
                    gbxCaracteristiques.Controls.Add(lblreglement);

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
}
