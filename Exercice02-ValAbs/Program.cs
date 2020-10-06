using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice02_ValAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un nombre entier : ");
            string saisie = Console.ReadLine();
            int x = int.Parse(saisie);

            int valAbs = x;
            if (x < 0)
            {
                valAbs = -x;
            }

            //Console.WriteLine("La valeur absolue de " + x + " est " + valAbs);
            Console.WriteLine("La valeur absolue de {0} est {1}", x, valAbs);
        }
    }
}
