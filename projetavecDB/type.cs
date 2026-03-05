using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetavecDB
{
    internal class Type
    {
        private string lettrecategorie;
        private short notype;
        private string libelle;

        public Type(string lettrecategorie, short notype, string libelle)
        {
            this.lettrecategorie = lettrecategorie;
            this.notype = notype;
            this.libelle = libelle;
        }

        public string getLettrecategorie() { return lettrecategorie; }
        public short getNotype() { return notype; }
        public string getLibelle() { return libelle; }

        public override string ToString() { 
            return (lettrecategorie+ notype)+" - "+(libelle);
        }


    }
}
