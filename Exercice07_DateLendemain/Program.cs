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
            int jour, mois, annee;
            int jourS = 0, moisS = 0, anneeS = 0;

            Console.WriteLine("jour mois et annee ?");
            jour = int.Parse(Console.ReadLine());
            mois = int.Parse(Console.ReadLine());
            annee = int.Parse(Console.ReadLine());

            anneeS = annee;
            if (((mois % 2 == 0) && (mois < 7)) || ((mois % 2 == 1) && (mois > 8)))   // mois pairs
            {
                if (jour == 30)
                {
                    jourS = 1;
                    moisS = mois + 1;
                }
                else
                {
                    if (mois == 2) // mois de février
                    {	// annee bissextile
                        if ((annee % 400 == 0) || ((annee % 4 == 0) && (annee % 100 != 0)))
                        {
                            if (jour == 29)
                            {
                                jourS = 1;
                                moisS = mois + 1;
                            }
                            else // annee non bissextile
                            {
                                if (jour == 28)
                                {
                                    jourS = 1;
                                    moisS = mois + 1;
                                }
                            }
                        }
                        else
                        {
                            jourS = jour + 1;
                            moisS = mois;
                        }
                    }
                }
            }
            else    // mois impairs : à 31 jours
            {
                if (jour == 31)
                {
                    jourS = 1;
                    moisS = mois + 1;
                }
                else
                {
                    jourS = jour + 1;
                    moisS = mois;
                }

                if (moisS == 13)
                {
                    moisS = 1;
                    anneeS = annee + 1;
                }
                else
                { anneeS = annee; }
            }
            Console.WriteLine("jour suivant : {0}/{1}/{2}", jourS, moisS, anneeS);

            Console.ReadKey(); 
        }
    }
}
