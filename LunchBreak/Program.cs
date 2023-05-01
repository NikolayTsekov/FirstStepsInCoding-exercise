using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine(); 
            int episode = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine()) ;
           
            double lunchTime = breakTime / 8.0;
            double restTime = breakTime / 4.0;
            double leftTime = breakTime - lunchTime - restTime;
            double timeNeeded = Math.Abs(leftTime - episode);

            if (leftTime >= episode)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(timeNeeded)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(timeNeeded)} more minutes.");
            }
        }
    }
}














