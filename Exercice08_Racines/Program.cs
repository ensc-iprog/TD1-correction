using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice08_Racines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez a : ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Entrez b : ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Entrez c : ");
            double c = int.Parse(Console.ReadLine());

            int n;
            double x1, x2;

            double delta = b*b - 4*a*c;
            if (delta >= 0)
            {
                if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    n = 1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    n = 2;
                }

                if (n == 1)
                    Console.WriteLine("La solution est " + x1);
                else
                    Console.WriteLine("Les solutions sont " + x1 + " et " + x2);
            }
            else
                Console.WriteLine("Delta négatif");
            
            Console.ReadKey();
        }
    }
}
