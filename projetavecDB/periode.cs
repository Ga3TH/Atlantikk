using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetavecDB
{
    internal class Periode
    {
        private short noperiode;
        private DateTime datedebut;
        private DateTime datefin;

        public Periode(short noperiode ,DateTime datedebut, DateTime datefin) { 
            this.noperiode = noperiode;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }

        public short Getnoperiode() { return noperiode; }
        public DateTime getDateDebut() { return datedebut; }
        public DateTime getDateFin() { return datefin; }

        public override string ToString()
        {
            return (datedebut + " au " + datefin);
        }
    }
}
