using System;

namespace Exercice12b_PointCercle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double xPoint = 2.1, yPoint = 1;
            double xCercle = 1.8, yCercle = 1.8;
            double rayon = 1.1;

            // On vérifie si la distance entre le point et le centre du cercle est < à son rayon
            if (Math.Sqrt((xPoint - xCercle) * (xPoint - xCercle) + (yPoint - yCercle) * (yPoint - yCercle))
                <= rayon)
                Console.WriteLine("Le point est à l'intérieur");
            else
                Console.WriteLine("Le point est à l'extérieur");

        }
    }
}
