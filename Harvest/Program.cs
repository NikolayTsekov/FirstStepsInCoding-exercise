using System;
using System.ComponentModel.Design;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());  
            int workers = int.Parse(Console.ReadLine());

            double grape = x * y;
            double wine = grape * 0.4 / 2.5;
            //double wineLeft = wine - z;
            double wineLeft = Math.Abs(wine - z);
            double gallonsPerPerson = wineLeft / workers;

            if (wine < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLeft)} liters wine needed.");
            }
            
            else
            {                
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");

                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(gallonsPerPerson)} liters per person.");
            }
        }
    }
}















