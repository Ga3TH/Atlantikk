using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetavecDB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace projetavecDB
    {
        internal class Classe_traversee
        {
            int notraversee, noliaison, nobateau;
            DateTime dateheuredepart;

            public Classe_traversee(int notraversee, int noliaison, int nobateau, DateTime dateheuredepart)
            {
                this.notraversee = notraversee;
                this.noliaison = noliaison;
                this.nobateau = nobateau;
                this.dateheuredepart = dateheuredepart;
            }

            public int GetNotraversee() { return notraversee; }
            public int GetNoliaison() { return noliaison; }
            public int GetNobateau() { return nobateau; }
            public DateTime GetDateheuredepart() { return dateheuredepart; }

            public override string ToString()
            {
                return dateheuredepart.ToString();
            }

        }
    }
}
