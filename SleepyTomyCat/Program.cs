using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            
            double workingDays = 365 - holidays;
            double totalPlayMinutes = workingDays * 63 + (holidays * 127);

            double difference = Math.Abs(totalPlayMinutes - 30000);
            double hours = difference / 60;
            double minutes = difference % 60;

            if (totalPlayMinutes > 30000) 
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes} minutes less for play");
            }
        }
    }
}














