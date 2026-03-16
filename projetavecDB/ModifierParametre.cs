using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class ModifierParametre : Form
    {
        public ModifierParametre()
        {
            InitializeComponent();
        }

        private void ModifierParametre_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                Label lblSite, lblRang, lblIdentifiant, lblCléHMAC;
                TextBox tbxSite, tbxRang, tbxIdentifiant, tbxCléHMAC;
                int i = 2;
                maCnx.Open();
                string requête = "select * from parametres";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {

                    string Site = (string)jeuEnr["site_pb"];
                    string rang = (string)jeuEnr["rang_pb"];
                    string identifiant = (string)jeuEnr["identifiant_pb"];
                    string cleHMAC = (string)jeuEnr["cleHMAC_pb"];
                    bool prod = cbxProd.Checked;



                    lblSite = new Label();
                    lblSite.Text = "Site :";
                    lblSite.Location = new Point(15, 25 * i);
                    lblSite.AutoSize = true;
                    gbxInfo.Controls.Add(lblSite);

                    tbxSite = new TextBox();
                    tbxSite.Text = Site;
                    tbxSite.Location = new Point(150, 25 * i);
                    tbxSite.AutoSize = true;
                    gbxInfo.Controls.Add(tbxSite);

                    i++;
                    lblRang = new Label();
                    lblRang.Text = "Rang :";
                    lblRang.Location = new Point(15, 25 * i);
                    lblRang.AutoSize = true;
                    gbxInfo.Controls.Add(lblRang);

                    tbxRang = new TextBox();
                    tbxRang.Text = rang;
                    tbxRang.Location = new Point(150, 25 * i);
                    tbxRang.AutoSize = true;
                    gbxInfo.Controls.Add(tbxRang);

                    i++;

                    lblIdentifiant = new Label();
                    lblIdentifiant.Text = "Identifiant :";
                    lblIdentifiant.Location = new Point(15, 25 * i);
                    lblIdentifiant.AutoSize = true;
                    gbxInfo.Controls.Add(lblIdentifiant);

                    tbxIdentifiant = new TextBox();
                    tbxIdentifiant.Text = identifiant;
                    tbxIdentifiant.Location = new Point(150, 25 * i);
                    tbxIdentifiant.AutoSize = true;
                    gbxInfo.Controls.Add(tbxIdentifiant);

                    i++;

                    lblCléHMAC = new Label();
                    lblCléHMAC.Text = "Clé HMAC :";
                    lblCléHMAC.Location = new Point(15, 25 * i);
                    lblCléHMAC.AutoSize = true;
                    gbxInfo.Controls.Add(lblCléHMAC);

                    tbxCléHMAC = new TextBox();
                    tbxCléHMAC.Text = cleHMAC;
                    tbxCléHMAC.Location = new Point(150, 25 * i);
                    tbxCléHMAC.AutoSize = true;
                    gbxInfo.Controls.Add(tbxCléHMAC);



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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
            MySqlDataReader jeuEnr = null;
            try
            {
                Label lblnom;
                TextBox txtValeur;
                int i = 2;
                maCnx.Open();
                string requête = "update parametres set site_pb = @site,rang_pb = rang, identifiant_pb = @identifiant, cleHMAC_pb = @cleHMAC";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                foreach (Control c in gbxInfo.Controls)
                {
                    if (c is TextBox tbx)
                    {

                    }
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
