using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която прочита едно число n, след това прочита n на брой цели числа и принтира средно аритметичното на тяхната сума число, форматирано до втората цифра след десетични знак.*/
            int n = int.Parse(Console.ReadLine());
            int dupf = n;
            double sum = 0;

            while (dupf != 0)
            {
                dupf = dupf - 1;
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"{sum / n:F2}");
        }
    }
}

































