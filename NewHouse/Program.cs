using System;
using System.ComponentModel.Design;
using System.Data;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да напишете програма която да изчисли колко  ще им струва, да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя са с различни цени. 

Съществуват следните отстъпки:
	•	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
	•	Ако Нели купи повече от 90  Далии - 15% отстъпка от крайната цена
	•	Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
	•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
	•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%
От конзолата се четат 3 реда:
	•	Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
	•	Брой цветя - цяло число в интервала [10…1000]
	•	Бюджет - цяло число в интервала [50…2500]
Да се отпечата на конзолата на един ред:
	•	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
	•	Ако бюджета им е НЕ достатъчен - "Not enough money, you need {нужната сума} leva more."
Сумата да бъде форматирана до втория знак след десетичната запетая.*/
			string flowerType = Console.ReadLine();
			int numberOfFlowers = int.Parse(Console.ReadLine());
			int budget = int.Parse(Console.ReadLine());

			double priceFlower = 0.0;

			switch (flowerType)
			{
				case "Roses": priceFlower = 5; break;
				case "Dahlias": priceFlower = 3.80; break;
				case "Tulips": priceFlower = 2.80; break;
				case "Narcissus": priceFlower = 3; break;
				case "Gladiolus": priceFlower = 2.50; break;

			}
			double totalPrice = numberOfFlowers * priceFlower;
			if (numberOfFlowers > 80 && flowerType == "Roses")
			{
				totalPrice = totalPrice - 0.10 * totalPrice;
				//totalPrice = totalPrice * 0.9;
				// totalPrice *= 0.9;
			}
			else if (numberOfFlowers > 90 && flowerType == "Dahlias")
			{
				totalPrice = totalPrice - 0.15 * totalPrice;
			}
			else if ( numberOfFlowers > 80 && flowerType == "Tulips")
			{
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
			else if ( numberOfFlowers < 120 && flowerType == "Narcissus")
			{
				totalPrice = totalPrice + 0.15 * totalPrice;
			}
			else if ( numberOfFlowers < 80 && flowerType == "Gladiolus")
			{
				totalPrice = totalPrice + 0.20 * totalPrice;
			}

			if (budget >= totalPrice) 
			{
				double leftSum = budget - totalPrice;
				Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {leftSum:F2} leva left.");
			}
			else
			{
				double neededSum = totalPrice - budget;
				Console.WriteLine($"Not enough money, you need {neededSum:F2} leva more.");
			}
        }
    }
}































