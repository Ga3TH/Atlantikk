using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetavecDB
{
    internal class Client
    {
        private int noclient;
        private string nom;
        private string prenom;

        public Client(int noclient, string nom, string prenom)
        {
            this.noclient = noclient;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int GetNoClient()
        {
            return noclient;
        }
        public string GetNom() 
        { 
            return nom;
        }

        public string GetPrenom()
        {
            return prenom;
        }

        public override string ToString()
        {
            return nom + ", " + prenom;
        }
    }
}
