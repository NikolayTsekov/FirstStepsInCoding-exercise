using System;
using System.ComponentModel.Design;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която при въведени градуси (реално число) принтира какво е времето
             * 26.00 - 35.00 =Hot
               20.1 - 25.9 = Warm
               15.00 - 20.00 = Mild
               12.00 - 14.9 = Cool
                5.00 - 11.9 = Cold
             * Ако се въведат градуси, различни от посочените в таблицата, да се отпечата "unknown".*/
            double degrees = double.Parse(Console.ReadLine());

            if (degrees <= 5)
            {
                Console.WriteLine("unknown");
            }
            else if (degrees <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (degrees <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degrees <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (degrees <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degrees <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}













