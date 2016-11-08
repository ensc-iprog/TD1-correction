using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice05_DureeTrajet
{
    class Program
    {
        static void Main(string[] args)
        {
            int hDepart, minDepart, hArrivee, minArrivee;
            int nbmT;

            Console.WriteLine("Heure et minute de départ ?");
            hDepart = int.Parse(Console.ReadLine());
            minDepart = int.Parse(Console.ReadLine());

            Console.WriteLine("Heure et minute d arrivee ?");
            hArrivee = int.Parse(Console.ReadLine());
            minArrivee = int.Parse(Console.ReadLine());

            if ((hDepart < hArrivee) || ((hDepart == hArrivee) && (minDepart < minArrivee)))
            {
                nbmT = hArrivee * 60 + minArrivee - (hDepart * 60 + minDepart);
            }
            else
            {	// Cas ou changement de jour
                nbmT = 24 * 60 - (hDepart * 60 + minDepart) + hArrivee * 60 + minArrivee;
            }
            Console.WriteLine("Durée du trajet : {0}", nbmT);

            Console.ReadKey();

        }
    }
}
