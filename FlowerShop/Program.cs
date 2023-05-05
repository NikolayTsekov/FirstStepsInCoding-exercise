using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Мария иска да купи подарък на сина си. Тя работи в магазин за цветя. В магазина идва поръчка за цветя. Напишете програма, която пресмята сумата от поръчката 
             * и дали печалбата е достатъчна за подаръка. Цветята имат следните цени:

	•	Магнолии – 3.25 лева
	•	Зюмбюли – 4 лева
	•	Рози – 3.50 лева
	•	Кактуси – 8 лева
От общата сума, Мария трябва да плати 5% данъци.
Входът се чете от конзолата и се състои от 5 реда:
	•	Брой магнолии – цяло число в интервала [0 … 50]
	•	Брой зюмбюли – цяло число в интервала [0 … 50]
	•	Брой рози – цяло число в интервала [0 … 50]
	•	Брой кактуси – цяло число в интервала [0 … 50]
	•	Цена на подаръка – реално число в интервала [0.00 … 500.00]

На конзолата трябва да се отпечата един ред.
	•	Ако парите СА стигнали: "She is left with {останали} leva." – сумата трябва да е закръглена към по-малко цяло число (пр. 1.90 -> 1).
	•	Ако парите НЕ достигат: "She will have to borrow {останали} leva." – сумата трябва да е закръглена към по-голямо цяло число (пр. 1.10 -> 2).*/
			int magnolia = int.Parse(Console.ReadLine());
			int hyacinth = int.Parse(Console.ReadLine());
			int roses = int.Parse(Console.ReadLine());
			int cactus = int.Parse(Console.ReadLine());
			double giftPrice = double.Parse(Console.ReadLine());

			double magnoliaPrice = 3.25;
			double hyacinthPrice = 4.0;
			double rosesPrice = 3.50;
			double cactusPrice = 8.0;

			double sum = (magnolia * magnoliaPrice) + (hyacinth * hyacinthPrice) + (roses * rosesPrice) + (cactus * cactusPrice);
			double discount = sum * 0.05;
			double profit = sum - discount;
 
			if (profit >= giftPrice)
			{			
				double priceLeft = Math.Abs(profit - giftPrice);

				Console.WriteLine($"She is left with {Math.Floor(priceLeft)} leva.");
			}
			else
			{
				double priceLeft = Math.Abs(profit - giftPrice);
				Console.WriteLine($"She will have to borrow {Math.Ceiling(priceLeft)} leva.");
			}



        }
    }
}















































