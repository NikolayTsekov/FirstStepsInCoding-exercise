using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*1. Четем от конзолата 3 реда:
              брой пилешки менюта
              брой менюта с риба
              брой вегетариански менюта
             
            2. Намираме каква ще е цената на всяка група менюта

            3 Намирам общата сметка за менютата

            4. Намирам цената на десерта (20% от общата сметка)

            5. Намирам сумата на цялата сметка (общата сметка + десерта + доставка)*/
            int chickenQuantity = int.Parse(Console.ReadLine());
            int fishQuantity = int.Parse(Console.ReadLine());
            int veganQuantity = int.Parse(Console.ReadLine());

            double ckickenPrice = chickenQuantity * 10.35;
            double fishPrice = fishQuantity * 12.40;
            double veganPrice = veganQuantity * 8.15;

            double menuPrice = ckickenPrice + fishPrice + veganPrice;

            double dessertPrice = menuPrice * 0.20;

            double totalPrice = menuPrice + dessertPrice + 2.50;

            Console.WriteLine(totalPrice);






        }
    }
}

