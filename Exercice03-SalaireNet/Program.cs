using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice03_SalaireNet
{
    class Program
    {
        static void Main(string[] args)
        {
            double salBase = 2600;
            double primeTechnicite = 55;
            double primeTransport = 70;
            int nbJours = 24;
            int nbEnfants = 3;
            double primeParEnfant = 89;
            double txCNSS = 0.265;
            double txImpot = 0.02;

			double primeEnfants = 0;
            if (nbEnfants != 0)
            {
                primeEnfants = primeParEnfant * nbEnfants;
            }

            // 26d : force un résultat réel et non entier
            double txTravail = nbJours / 26d;
            double salBrut = (salBase + primeTechnicite + primeTransport + primeEnfants) * txTravail;
            double valCNSS = txCNSS * salBrut;
            double valImpot = txImpot * salBrut;
            double salNet = salBrut - valImpot - valCNSS;

            Console.WriteLine("Salaire net = " + salNet);
        }
    }
}
