using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           int current = 1;
           bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int column = 1; column <= rows; column++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger) 
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}























