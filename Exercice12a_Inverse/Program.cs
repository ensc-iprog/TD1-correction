using System;

namespace Exercice12a_Inverse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x = 3;
            double a = 2.5;

            double v = (Math.Pow(x, 2) + a);
            if (v != 0)
            {
                double inverse = 1 / v;
                Console.WriteLine(inverse);
            }
            else
            {
                Console.WriteLine("Erreur : division par 0");
            }
        }
    }
}
