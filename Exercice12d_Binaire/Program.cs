using System;

namespace Exercice12d_Binaire
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int nombre = 7;

            int[] binaire = new int[4];
            binaire[3] = nombre % 2;
            binaire[2] = (nombre / 2) % 2;
            binaire[1] = (nombre / 4) % 2;
            binaire[0] = (nombre / 8) % 2;

            Console.WriteLine("{0} s'écrit en binaire {1}", nombre, string.Join("", binaire));
        }
    }
}
