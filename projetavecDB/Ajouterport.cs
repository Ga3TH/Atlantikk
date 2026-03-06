using MySql.Data.MySqlClient;
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
    public partial class Ajouterport : Form
    {
        public Ajouterport()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            string CHAINECONNEXION = "server=localhost;user=root;database=Atlantik;port=3306;password=";
            maCnx = new MySqlConnection(CHAINECONNEXION);
            maCnx.Open();

            MySqlCommand maCde;
            MySqlDataReader jeuEnregistrements;
            string requete = "INSERT INTO port(NOM) Values (@nom)";
            maCde = new MySqlCommand(requete, maCnx);
            string nom = tbxChoisie.Text;
            maCde.Parameters.AddWithValue("@nom", nom);
            jeuEnregistrements = maCde.ExecuteReader();
            MessageBox.Show("Port Ajouté avec succès !");

            while (jeuEnregistrements.Read())
            {
                MessageBox.Show(e.ToString());
            }
            maCnx.Close();
        }
    }
}
