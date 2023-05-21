using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int num;
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                count += num;
                if (num < 6)
                {
                    countP1+= num;
                }
                else if (num <= 12)
                {
                    countP2+= num;
                }
                else if (num <= 25)
                {
                    countP3+= num;
                }
                else if (num <= 40)
                {
                    countP4+= num;
                }
                else
                {
                    countP5+= num;
                }
            }
            double p1 = (double)countP1 / count * 100;
            double p2 = (double)countP2 / count * 100;
            double p3 = (double)countP3 / count * 100;
            double p4 = (double)countP4 / count * 100;
            double p5 = (double)countP5 / count * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");




        }
    }
}






