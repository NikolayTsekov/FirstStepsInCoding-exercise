using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());    
            int marker = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int discountPercents = int.Parse.(Console.ReadLine());  

            double penPrice = pen * 5.8;
            double markerPrice = marker * 7.2;
            double detergentPrice = detergent * 1.2;

            double totalPrice = (penPrice + markerPrice + detergentPrice) * 0.75;

            Console.WriteLine(totalPrice);
        }
    }
}







