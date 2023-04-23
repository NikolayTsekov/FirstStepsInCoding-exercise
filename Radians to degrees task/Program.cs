using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
           
            double radians = double.Parse(Console.ReadLine());

            double degrees = radians * 180 / Math.PI;


            Console.WriteLine(degrees);
        }
    }
}






