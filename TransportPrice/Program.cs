using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string tariff = Console.ReadLine();

            double taxiStartPrice = 0.70;
            double taxiDailyPrice = 0.79;
            double taxiNightPrice = 0.90;
            double busDailyNightPrice = 0.09;
            double trainDailyNightPrice = 0.06;

            if (kilometers < 20)
            {
                if (tariff == "day")
                {
                    double taxiPrice = taxiStartPrice + (kilometers * taxiDailyPrice);
                    Console.WriteLine($"{Math.Abs(taxiPrice):f2}");
               
                }
                else
                {
                    double taxiPrice = taxiStartPrice + (kilometers * taxiNightPrice);
                    Console.WriteLine($"{Math.Abs(taxiPrice):f2}");
                }
                
            }
            else if (kilometers >= 100)
            {
                double trainPrice = kilometers * trainDailyNightPrice;
                Console.WriteLine($"{Math.Abs(trainPrice):f2}");
                
            }
            else 
            {
                double busPrice = kilometers * busDailyNightPrice;
                Console.WriteLine($"{Math.Abs(busPrice):f2}");
            }
        }
    }
}














































