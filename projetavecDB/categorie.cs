using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetavecDB
{
    internal class Categorie
    {
        private string lettrecategorie;
        private string libelle;

        public Categorie(string LettreCategorie, string libelle)
        {
            this.lettrecategorie = LettreCategorie;
            this.libelle = libelle;
        }

        public string Getlettrecategorie() {return lettrecategorie;}
        public string Getlibelle() {return libelle;}
        public override string ToString() 
        { 
            return lettrecategorie+"("+libelle+")";
        }
    }
}
