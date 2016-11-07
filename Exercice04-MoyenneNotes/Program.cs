using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice04_MoyenneNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vos 3 notes ?");
            double note1 = double.Parse(Console.ReadLine());
            double note2 = double.Parse(Console.ReadLine());
            double note3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vos 3 coefficients ?");
            double ponde1 = double.Parse(Console.ReadLine());
            double ponde2 = double.Parse(Console.ReadLine());
            double ponde3 = double.Parse(Console.ReadLine());

            double moyenne = (note1 * ponde1 + note2 * ponde2 + note3 * ponde3) / (ponde1 + ponde2 + ponde3);
            Console.WriteLine(" La moyenne est de {0}", moyenne); ;
            if (moyenne >= 10)
            {
                Console.WriteLine(" L'eleve passe ");
                if (moyenne < 12)
                {
                    Console.WriteLine(" Appreciation :P ");
                }
                else
                {
                    if (moyenne < 14)
                    {
                        Console.WriteLine(" Appreciation :AB ");
                    }
                    else
                    {
                        if (moyenne < 16)
                        {
                            Console.WriteLine(" Appreciation :Bien ");
                        }
                        else
                        {
                            Console.WriteLine(" Appreciation :Excellent ");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine(" L'élève est refuse  ");
            }

            Console.ReadKey();
        }
    }
}
