using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetavecDB
{
    internal class Liaison
    {
        private string nomport_depart;
        private string nomport_arrivee;
        private int noliaison;


        public Liaison(string nomport_depart, string nomport_arrivee, int noliaison)
        {

            this.nomport_depart = nomport_depart;
            this.nomport_arrivee = nomport_arrivee;
            this.noliaison = noliaison;
        }

        public string Getnomport_depart() { return nomport_depart; }
        public string Getnomport_arrive() { return nomport_arrivee; }
        public int Getnoliaison() { return noliaison; }
        public override string ToString()
        {
            return (nomport_depart + " -> " + nomport_arrivee);
        }
    }
}
