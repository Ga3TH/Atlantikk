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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            AjouterSecteur ajouterSecteur = new AjouterSecteur();
            ajouterSecteur.ShowDialog();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            Ajouterport ajouterport = new Ajouterport();
            ajouterport.ShowDialog();
        }
    }
}
