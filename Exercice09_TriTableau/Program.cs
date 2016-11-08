using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etempercice09_TriTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 3, 6, 1 };
            int temp;

            if (t[0] > t[1])
            {
                temp = t[0];
                t[0] = t[1];
                t[1] = temp;
            }

            if (t[1] > t[2])
            {
                temp = t[1];
                t[1] = t[2];
                t[2] = temp;
            }

            if (t[0] > t[1])
            {
                temp = t[0];
                t[0] = t[1];
                t[1] = temp;
            }

            Console.WriteLine("{0} {1} {2}", t[0], t[1], t[2]);

            Console.ReadKey();
        }
    }
}
