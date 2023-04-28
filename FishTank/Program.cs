using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumCapacity = lenght * width * height;
            double capacityInLitres = aquariumCapacity * 0.001;
            double occupiedSpace = 0.185;

            double neededLitres = capacityInLitres * (1 - 0.185);

            Console.WriteLine(neededLitres);
        }
    }
}