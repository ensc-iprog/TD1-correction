using System;

namespace Exercice11_Remises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double totalHT = 4230.25;
            double montantArticle = 700;
            string typeArticle = "magnétoscope";

			double txRemise = 0;
            if (totalHT > 5000)
                txRemise = 20;
            else
            {
                if ((montantArticle > 400) && (typeArticle == "magnétoscope") && (totalHT > 1000))
                {
                    txRemise = 15;
                }
                else
                {
                    if ((montantArticle > 500 && typeArticle == "camescope") || (totalHT > 1000))
                    {
                        txRemise = 10;
                    }
                }
            }
            Console.WriteLine("Montant de la remise accordée : " + txRemise + "%");

            double prixFinal = totalHT * (1 - txRemise / 100);
            Console.WriteLine("Prix final : " + prixFinal);
        }
    }
}
