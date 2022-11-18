using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_3
{
    internal interface IDndobject
    {
        public int Poids { get; set;}
        public string Name { get; set; }
        public int Prix { get; set; }
    }
}
