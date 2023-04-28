using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            double vegetable = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());   
            int vegetableTotalKilograms = int.Parse(Console.ReadLine());
            int fruitsTotalKilograms = int.Parse(Console.ReadLine());
            
            double vegetablePrice = vegetable * vegetableTotalKilograms;
            double fruitsPrice = fruits * fruitsTotalKilograms;   
            double total = (vegetablePrice + fruitsPrice) / 1.94;

            Console.WriteLine($"{total:F2}");
        }
    }
}









