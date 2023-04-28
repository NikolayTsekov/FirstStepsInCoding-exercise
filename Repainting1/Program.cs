using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.5;
            double paintPrice = (paint + 1.1) * 14.5;
            double thinnerPrice = thinner * 5;
            double bagsPrice = 0.4;


            double materialPrice = nylonPrice + paintPrice + thinnerPrice + bagsPrice;

            double masterPrice = (materialPrice * 0.3) * 8;
            double totalPrice = materialPrice + masterPrice;

            Console.WriteLine(totalPrice);
        }
    }
}



