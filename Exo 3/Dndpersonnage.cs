using Exo_3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumuse
{
     public class Personnage : BasePerso
    {
        public int experience { get; set; }
        public int experienceLevel { get; set; }
        public int niveau { get; set; }
        public void Defense()
        {
            bouclier += 1;
        }
        public void AttaquerMonstre(Monstre ennemi, int BBA)
        {
            int attaque;
            Random r = new Random();
            attaque = r.Next(20) + BBA;
            if (attaque > ennemi.bouclier)
            {
                Console.WriteLine(ennemi.name + " touché pour " + puissance);
                ennemi.PrendreDegat(puissance);
            }
            else
            {
                Console.WriteLine(this.name + " à loupé " + ennemi.name);
            }
        }

        public void PetitHeal()
        {
            int vieRecup;
            int vieSurplus;
            Random r = new Random();
            vieRecup = r.Next(6) + 2;
            vie += vieRecup;
            Console.WriteLine(vieRecup + " points de vie récup");
            if (vie > vieMax)
            {
                vieSurplus = vie - vieMax;
                vie = vieMax;
                Console.WriteLine("Surplus de vie de " + vieSurplus + " point");
            }
        }

        public void Repos()
        {
            int vieRecup;
            int vieSurplus;
            Random rand = new Random();
            vieRecup = rand.Next(12);
            vie += vieRecup;
            Console.WriteLine(vieRecup + " points de vie récup");
            if (vie > vieMax)
            {
                vieSurplus = vie - vieMax;
                vie = vieMax;
                Console.WriteLine("Surplus de vie de " + vieSurplus + " point");
            }
        }

        public void LevelUp()
        {
            niveau++;
            if (niveau == 20)
            {
                experienceLevel = 999999999;
            }
            else
            {
                experienceLevel += 500;
            }
        }

        public void GetEXP(Monstre ennemi)
        {
            int surplusEXP = 0;
            Console.WriteLine(name + " à gagné " + ennemi.experience + "EXP");
            experience += ennemi.experience;
            if (experience > experienceLevel)
            {
                surplusEXP = experienceLevel - experience;
                LevelUp();
                experience = surplusEXP;
            }

        }

        public Personnage()
        {
            Random rand = new Random();
            vieMax = rand.Next(9, 25);
            vie = vieMax;
            bouclier = rand.Next(11, 15);
            vitesse = rand.Next(0, 5);
            experienceLevel = 500;
            experience = 0;
        }
    }
}
