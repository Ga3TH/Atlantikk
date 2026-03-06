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

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }


        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            AjouterSecteur ajouterSecteur = new AjouterSecteur();
            ajouterSecteur.ShowDialog();
        }

        

        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            Ajouterport ajouterport = new Ajouterport();
            ajouterport.ShowDialog();
        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            AjouterLiaison ajouterLiaison = new AjouterLiaison();  
            ajouterLiaison.ShowDialog();
        }

        private void btnAjouterTarif_Click(object sender, EventArgs e)
        {
            AjouterTarif ajouterTarif = new AjouterTarif();
            ajouterTarif.ShowDialog();
        }

        private void btnAjouterBateau_Click(object sender, EventArgs e)
        {
            AjouterBateau ajouterBateau = new AjouterBateau();
            ajouterBateau.ShowDialog();
        }

        private void btnAjouterTraverse_Click(object sender, EventArgs e)
        {
            AjouterTraversé ajouterTraversé = new AjouterTraversé();
            ajouterTraversé.ShowDialog();
        }

        private void btnModifierBateau_Click(object sender, EventArgs e)
        {
            ModifierBateau modifierBateau = new ModifierBateau();
            modifierBateau.ShowDialog();
        }

        private void btnModifierParametre_Click(object sender, EventArgs e)
        {
            ModifierParametre modifierParametre = new ModifierParametre(); 
            modifierParametre.ShowDialog();
        }

        private void btnAfficherTraverse_Click(object sender, EventArgs e)
        {
            AfficherTraversé afficherTraversé = new AfficherTraversé();
            afficherTraversé.ShowDialog();
        }

        private void btnAfficherDetails_Click(object sender, EventArgs e)
        {
            AfficherDetails afficherDetails = new AfficherDetails();
            afficherDetails.ShowDialog();
        }
    }
}
