using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetavecDB
{
    internal class Port
    {
        private int noPort;
        private string nom;

        public Port(int noPort, string nom)
        {
            this.noPort = noPort;
            this.nom = nom;
        }

        public string GetNom() { return nom; }
        public int GetNoPort() { return noPort; }
        public override string ToString() { return nom; }

    }
}
