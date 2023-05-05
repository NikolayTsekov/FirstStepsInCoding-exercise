using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());  
            double turtleFood = double.Parse(Console.ReadLine());

            double neededDogFood = days * dogFood;
            double neededCatFood = days * catFood;
            double neededTurtleFood = (days * turtleFood) * 0.001;

            double totalFood = neededDogFood + neededCatFood + neededTurtleFood;
            if (totalFood <= food )
            {
                double foodLeft = (food - totalFood);

                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodLeft = (totalFood - food);
                Console.WriteLine($"{Math.Ceiling(foodLeft)} more kilos of food are needed.");
            }
        }
    }
}















































