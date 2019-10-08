using System;

namespace Exercice12c_Colinearite
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double xA = 1, xB= 2, xC = 4;
            double yA = 1, yB = 2, yC = 5;

            // On calcule les pentes des droites (AB) et (AC)
            double penteAB = (yB - yA) / (xB - xA);
            double penteAC = (yC - yB) / (xC - xB);

            // Les points sont alignées ssi les pentes sont égales
            if (penteAB == penteAC)
                Console.WriteLine("Les points sont alignés");
            else
                Console.WriteLine("Les points ne sont pas alignés");
        }
    }
}
