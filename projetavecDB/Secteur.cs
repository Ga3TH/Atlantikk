using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetavecDB
{
    internal class Secteur
    {
        private int noSecteur;
        private string nom;

        public Secteur(int noSecteur, string nom)
        {
            this.noSecteur = noSecteur;
            this.nom = nom;
        }

        public string GetNom() { return nom; }
        public int GetNoSecteur() { return noSecteur; }
        public override string ToString() { return nom; }

    }

}