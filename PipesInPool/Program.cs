using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int vPool = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine()); 
            double h = double.Parse(Console.ReadLine());

            double pipe1 = p1 * h;
            double pipe2 = p2 * h;
            double total = pipe1 + pipe2;

            double fillinP1 = pipe1 / total * 100;
            double fillinP2 = pipe2 / total * 100;
            double fillinTotal = total / vPool * 100;
            double overflowed = total - vPool;

            if (total <= vPool)
            {
                Console.WriteLine($"The pool is {Math.Abs(fillinTotal):f2}% full. Pipe 1: {Math.Abs(fillinP1):f2}%. Pipe 2: {Math.Abs(fillinP2):f2}%.");
            }
            else
            {
                Console.WriteLine($"For {h:f2} hours the pool overflows with {Math.Abs(overflowed):f2} liters.");
            }
        }
    }
}














