using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            1. Създаваме променлива за радианите и присвояваме стойността, която идва от конзолата.
            double radians = double.Parse(Console.ReadLine());

            2. Създаваме променлива за градусите и просвояваме = радиан * 180/пи (Math.PI).
            double degrees = radians * 180 / Math.PI;

            3. Отпечатваме градусите на конзолата 

            Console.WriteLine(degrees);
        }
    }
}





