using Mumuse;
using Exo_3;

Console.WriteLine("Bienvenue au darkest Dungeon");
Console.WriteLine("Quel est ton nom ?");
string PjName = Console.ReadLine();
int NombreMonstreBattu = 0;

// init objet PJ
var PJ = new Personnage { 
    name = PjName,
    bouclier = 14,
    vie = 12,
    puissance = 6,
    vitesse = 3,
};

int match = 1;
int round = 1;
int cooldown = 0;
string lastEnnemi = "";

// Début du combat
while (PJ.enVie)
{
    var ennemi = new Monstre();
    lastEnnemi = ennemi.name;
    Console.WriteLine("\n"+ennemi.name+" apparait");

    if (PJ.vitesse >= ennemi.vitesse)
    {
        Console.WriteLine("Plus rapide !");
    }
    else
    {
        Console.WriteLine("Plus lent !");
    }


    while (ennemi.enVie)
    {
        Console.WriteLine("Match : " + match + "{0,50}","Round " + round + "\n");
        Console.WriteLine("\nPJ : " + PJ.name + "\nVie : " + PJ.vie + "\nNiveau : " + PJ.niveau + "\n");

        if (PJ.vitesse > ennemi.vitesse)
        {
            Console.WriteLine("{0,60}", "Triple Axel : 1");
            Console.WriteLine("{0,60}", "Défense : 2");
            Console.WriteLine("{0,60}", "Petit soin : 3");
            Console.WriteLine("{0,60}", "Attaque : X");

            ConsoleKeyInfo valeur = Console.ReadKey();

            if (valeur.Key == ConsoleKey.D1)
            {
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                if (ennemi.vie <= 0)
                {
                    PJ.GetEXP(ennemi);
                }
                cooldown = 2;
            }
            else if (valeur.Key == ConsoleKey.D2)
            {
                PJ.Defense();
            }
            else if (valeur.Key == ConsoleKey.D3)
            {
                PJ.PetitHeal();
            }
            else 
            {
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                if (ennemi.vie <= 0)
                {
                    PJ.GetEXP(ennemi);
                }
            }

            ennemi.Attaque(PJ, ennemi.puissance);

        }
        else if (PJ.vitesse < ennemi.vitesse)
        {
            ennemi.Attaque(PJ, ennemi.puissance);
            Console.WriteLine("{0,60}","Triple Axel : 1");
            Console.WriteLine("{0,60}","Défense : 2");
            Console.WriteLine("{0,60}","Petit soin : 3");
            Console.WriteLine("{0,60}","Attaque : X");

            ConsoleKeyInfo valeur = Console.ReadKey();

            if (valeur.Key == ConsoleKey.D1)
            {
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                if (ennemi.vie <= 0)
                {
                    PJ.GetEXP(ennemi);
                }
                cooldown = 2;
            }
            else if (valeur.Key == ConsoleKey.D2)
            {
                PJ.Defense();
            }
            else if (valeur.Key == ConsoleKey.D3)
            {
                PJ.PetitHeal();
            }
            else
            {
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                if (ennemi.vie <= 0)
                {
                    PJ.GetEXP(ennemi);
                }
            }
        } 
        else
        {
            Console.WriteLine("{0,60}", "Triple Axel : 1");
            Console.WriteLine("{0,60}", "Défense : 2");
            Console.WriteLine("{0,60}", "Petit soin : 3");
            Console.WriteLine("{0,60}", "Attaque : X");
            ConsoleKeyInfo valeur = Console.ReadKey();
            if (valeur.Key == ConsoleKey.D1 && cooldown != 0)
            {
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                PJ.AttaquerMonstre(ennemi, PJ.puissance);

                if (ennemi.vie <= 0)
                {
                    PJ.GetEXP(ennemi);
                }
            }
            else if (valeur.Key == ConsoleKey.D2)
            {
                PJ.Defense();
            }
            else if (valeur.Key == ConsoleKey.D3)
            {
                PJ.PetitHeal();
            }
            else
            {
                PJ.AttaquerMonstre(ennemi, PJ.puissance);
                if (ennemi.vie <= 0)
                {
                    PJ.GetEXP(ennemi);
                }
            }
            ennemi.Attaque(PJ, ennemi.puissance);
        }
        Console.Clear();
        round++;
    }
    Console.Clear();
    Console.WriteLine(ennemi.name + " est mort");
    NombreMonstreBattu++;
    if (match % 5 == 0) 
    {
        PJ.Repos();
    }
    match++;
    round = 0;
}
Console.WriteLine(PJ.name + " est mort \nIl a tué " + NombreMonstreBattu + " monstre\nIl est mort face à " + lastEnnemi + "\nIl a tenu " + match + " match");
Console.ReadLine();