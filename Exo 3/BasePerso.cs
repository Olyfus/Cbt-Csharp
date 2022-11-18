using Mumuse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_3
{
    public class BasePerso
    {
        public string name { get; set; }
        public int vie { get; set; }
        public int vieMax { get; set; }
        public bool enVie { get; set; } = true;
        public int puissance { get; set; }
        public int bouclier { get; set; }
        public int vitesse { get; set; }

        public void PrendreDegat(int attaque)
        {
            vie = vie - attaque;
            if (vie < 0)
            {
                enVie = false;
            }
        }
    }
}
