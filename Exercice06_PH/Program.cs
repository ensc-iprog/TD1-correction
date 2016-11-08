using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice06_PH
{
    class Program
    {
        static void Main(string[] args)
        {
            double pH;
            Console.Write("Valeur du pH ? ");
            pH = double.Parse(Console.ReadLine());
            if (pH < 7)
            {
                Console.WriteLine("pH acide");
            }
            else
            {
                if (pH == 7)
                { Console.WriteLine("pH neutre"); }
                else
                { Console.WriteLine("pH basique"); }
            }
            Console.ReadKey();
        }
    }
}
