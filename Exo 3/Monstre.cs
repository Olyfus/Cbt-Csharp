using Mumuse;
using Exo_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_3
{
    public class Monstre : BasePerso
    {
        public int experience { get; set; }
        public void Attaque(Personnage hero, int BBA)
        {
            int attaque;
            Random r = new Random();
            attaque = r.Next(20) + BBA;
            if (attaque > hero.bouclier)
            {
                Console.WriteLine(this.name + " à touché "+ hero.name +" pour");
                hero.PrendreDegat(puissance);
            }
            else
            {
                Console.WriteLine(this.name + " à loupé " + hero.name);
            }
        }
        public Monstre()
        {
            Random rand = new Random();
            int RNG = rand.Next(100);
            Console.WriteLine("RNG :"+RNG);
            if (RNG == 99)
            {
                name = "Balrogu";
                vie = vieMax = 250;
                puissance = 45;
                vitesse = 30;
                experience = 15000;
            }
            else if (RNG > 90)
            {
                name = "Chevalier squelette";
                vie = vieMax = 75;
                puissance = 20;
                vitesse = 1;
                experience = 1000;
            }
            else if (RNG > 70)
            {
                name = "Terrorist";
                vie = vieMax = 50;
                puissance = 10;
                vitesse = 2;
                experience = 500;
            }
            else if (RNG > 50)
            {
                name = "Goblin";
                vie = vieMax = 25;
                puissance = 6;
                vitesse = 2;
                experience = 250;
            }
            else if (RNG > 20)
            {
                name = "Squelette";
                vie = vieMax = 20;
                puissance = 4;
                vitesse = 3;
                experience = 100;
            }
            else if (RNG > 0)
            {
                name = "Rat";
                vie = vieMax = 2;
                puissance = 1;
                vitesse = 5;
                experience = 5;
            }
            else
            {
                Console.WriteLine("ERREUR RNG");
            }
            Console.WriteLine("\n" + name + " apparait devant le héros");

        }
    }
}
