
using System;
using System.Diagnostics.CodeAnalysis;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine($"{fahrenheit:F2}");
        }
    }
}







