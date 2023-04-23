using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            1. Създаване на променлива за USD (double) и задаваме стойност, която идва от конзолата.
                double usd = double.Parse(Console.WriteLine());

            2. Създаваме променлива BGN (double) и задаваме стойност равна на щатските долари умножени по курса.
                double bgn = usd * 1.79549;

            3. Отпечатваме на конзолата
                Console.WriteLine(bgn);
        }
    }
}



