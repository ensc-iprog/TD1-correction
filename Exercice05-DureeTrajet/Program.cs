using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice05_dureeEnMinutesTrajet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heure et minutes de départ ?");
            int hDepart = int.Parse(Console.ReadLine());
            int minDepart = int.Parse(Console.ReadLine());

            Console.WriteLine("Heure et minutes d'arrivée ?");
            int hArrivee = int.Parse(Console.ReadLine());
            int minArrivee = int.Parse(Console.ReadLine());

            int dureeEnMinutes;
            if ((hDepart < hArrivee) || ((hDepart == hArrivee) && (minDepart < minArrivee)))
            {
                dureeEnMinutes = hArrivee * 60 + minArrivee - (hDepart * 60 + minDepart);
            }
            else
            {	// Cas du changement de jour
                dureeEnMinutes = 24 * 60 - (hDepart * 60 + minDepart) + hArrivee * 60 + minArrivee;
            }
            // Conversion des minutes en heures/minutes
            // % est l'opérateur modulo (reste de la division euclidienne)
            int hDuree = dureeEnMinutes / 60;
            int mDuree = dureeEnMinutes % 60;
            Console.WriteLine("Durée du trajet : {0} heure(s) et {1} minute(s)", hDuree, mDuree);
        }
    }
}
