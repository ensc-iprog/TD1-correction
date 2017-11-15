using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice07_DateLendemain
{
    class Program
    {
        static void Main(string[] args)
        {
            // On suppose que la date saisie est toujours correcte
            Console.WriteLine("jour mois et annee ?");
            int jour = int.Parse(Console.ReadLine());
            int mois = int.Parse(Console.ReadLine());
            int annee = int.Parse(Console.ReadLine());

            // Cas par défaut
            int jourS = jour + 1, moisS = mois, anneeS = annee;

            if (((mois % 2 == 0) && (mois < 7)) || ((mois % 2 == 1) && (mois > 8)))   // mois à 28, 29 ou 30 jours
            {
                if (jour == 30)
                {
                    jourS = 1;
                    moisS = mois + 1;
                }
                else
                {
                    if (mois == 2) // mois de février
                    {
                        // année bissextile
                        if ((annee % 400 == 0) || ((annee % 4 == 0) && (annee % 100 != 0)))
                        {
                            if (jour == 29)
                            {
                                jourS = 1;
                                moisS = mois + 1;
                            }
                        }
                        else if (jour == 28)
                        {
                            jourS = 1;
                            moisS = mois + 1;
                        }
                    }
                }
            }
            else // mois à 31 jours
            {
                if (jour == 31)
                {
                    jourS = 1;
                    moisS = mois + 1;

                    // Cas du 31/12 : passage à l'année suivante
					if (moisS == 13)
					{
						moisS = 1;
						anneeS = annee + 1;
					}
                }
            }
            Console.WriteLine("Jour suivant : {0}/{1}/{2}", jourS, moisS, anneeS);
        }
    }
}
