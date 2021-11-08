using System;


namespace penduConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialisation des variables 
            string motSecret; 
            char lettreEssai;
            int compteur = 10, bonneRep = 0;
            bool correct = false;

            // saisie du mot à chercher par le joueur 1 : 
            Console.WriteLine("Entrez le mot à chercher");
            motSecret = Console.ReadLine();
            Console.Clear(); 

            // initialisation des valeurs du tableau à "_" (simulation cacher des lettre)
            int tailleMot = motSecret.Length;
            string[] motEssai = new string [tailleMot];
            for (int i = 0; i<tailleMot; i++)
            {
                motEssai[i] = "_";
            }


            // Boucle du jeu:
            for (int essai = 0; (compteur > 0) && (bonneRep != tailleMot) ; essai++)
            {
                correct = false;
                Console.WriteLine("Entrez l'essai " + (essai + 1) + ":");
                lettreEssai = char.Parse(Console.ReadLine()); // en entre une lettre 
                for (int i = 0; i < tailleMot; i++) // grâce à cette double boucle, la lettre est testé avec toutes les case du tableau
                {
                    if (lettreEssai == motSecret[i]) // si la lettre correspond, la valeur remplace le "_" dans le taleau mot secret
                    {
                        motEssai[i] = (lettreEssai).ToString();
                        bonneRep += 1;
                        correct = true;
                    }
                }
                for (int i = 0; i < tailleMot; i++)
                {
                    Console.Write(motEssai[i]);
                }
                if (correct == false)
                {
                    compteur -= 1;
                }
                Console.WriteLine();
                Console.WriteLine($"Il vous reste {compteur} essai");
                Console.WriteLine();          
            }
            if (compteur > 0)
            {
                Console.WriteLine("Bravo ! vous avez trouvez le mot");
            }
            else
            {
                Console.WriteLine($"Perdu, vous êtes mort, le mot caché était {motSecret}");
            }
            Console.ReadLine();
        }
    }
}
