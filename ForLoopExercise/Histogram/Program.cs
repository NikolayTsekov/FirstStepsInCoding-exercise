using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num;
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if(num < 200)
                {
                    countP1++;
                }
                else if (num < 400)
                {
                    countP2++;
                }
                else if(num < 600)
                {
                    countP3++;
                }
                else if (num < 800)
                {
                    countP4++;
                }
                else
                {
                    countP5++;
                }
            }
            double p1 = (double)countP1 / n*100;
            double p2 = (double)countP2 / n*100;
            double p3 = (double)countP3 / n*100;
            double p4 = (double)countP4 / n*100;
            double p5 = (double)countP5 / n*100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");




        }
    }
}





