using Exo_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_3
{
    internal class Dndarmes : IDndobject
    {
        public string Name { get; set; }
        public int Poids { get; set; }
        public int Prix { get; set; }

        public Dndarmes(string name, int poids, int prix)
        {
            Name = name;
            Poids = poids;
            Prix = prix;
        }
    }
}
