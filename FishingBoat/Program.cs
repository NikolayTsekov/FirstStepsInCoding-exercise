using System;


namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат на риболов с кораб. Цената за наема на кораба зависи от сезона и броя рибари.
Цената зависи от сезона:
	•	Цената за наем на кораба през пролетта е  3000 лв.
	•	Цената за наем на кораба през лятото и есента е  4200 лв.
	•	Цената за наем на кораба през зимата е  2600 лв.
В зависимост от броя си групата ползва отстъпка:
	•	Ако групата е до 6 човека включително  –  отстъпка от 10%.
	•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15%.
	•	Ако групата е от 12 нагоре  –  отстъпка от 25%. 
Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. */
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double shipPrice = 0;

            if (season == "Spring")
            {
                shipPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                shipPrice = 4200;
            }
            else if (season == "Winter")
            {
                shipPrice = 2600;
            }


            if (fisherman <= 6)
            {
                shipPrice = shipPrice - 0.10 * shipPrice;
            }
            else if (fisherman >= 7 && fisherman <= 11)
            {
                shipPrice = shipPrice - 0.15 * shipPrice;
            }
            else if (fisherman >= 12)
            {
                shipPrice = shipPrice - 0.25 * shipPrice;
            }

            if (fisherman % 2 == 0 && season == "Spring" && season == "Summer" && season == "Winter") 
            {
                shipPrice = shipPrice - 0.05 * shipPrice;

            }     
           

            if (budget >= shipPrice)
            {
                double leftMoney = budget - shipPrice;
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");

            }
            else
            {
                double needMoney = shipPrice - budget;
                Console.WriteLine($"Not enough money! You need {needMoney:F2} leva.");
            }

        }
    }
}



































