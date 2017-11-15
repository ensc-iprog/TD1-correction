using System;

namespace Exercice10_Categories
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Entrez l'âge : ");
            int age = Convert.ToInt32(Console.ReadLine());

            string categorie = "inconnue";
            if (age >= 12)
            {
                categorie =  "Cadet";
            }
            else
            {
                if (age >= 10)
                {
                    categorie = "Minime";
                }
                else
                {
                    if (age >= 8)
                    {
                        categorie = "Pupille";
                    }
                    else
                    {
                        if (age >= 6)
                        {
                            categorie = "Poussin";
                        }
                    }
                }
            }
            Console.WriteLine("Catégorie = " + categorie);
        }
    }
}
