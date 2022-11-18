using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_3
{
    internal class Dndarmures : IDndobject
    {
        public string Name { get; set; }
        public int Poids { get; set; }
        public int Prix { get; set; }

        public Dndarmures(string name, int poids, int prix)
        {
            Name = name;
            Poids = poids;
            Prix = prix;
        }
    }
}
