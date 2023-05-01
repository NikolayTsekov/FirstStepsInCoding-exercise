using System;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Петър иска да купи N видеокарти, M процесора и P на брой рам памет. Ако броя на видеокартите е по-голям от този на процесорите получава 15% отстъпка от 
             крайната сметка. Важат следните цени:
	•	Видеокарта – 250 лв./бр.
	•	Процесор – 35% от цената на закупените видеокарти/бр.
	•	Рам памет – 10% от цената на закупените видеокарти/бр.
Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.
Вход
Входът се състои от четири реда:
	1.	Бюджетът на Петър - реално число в интервала [0.0…100000.0]
	2.	Броят видеокарти - цяло число в интервала [0…100]
	3.	Броят процесори - цяло число в интервала [0…100]
	4.	Броят рам памет - цяло число в интервала [0…100]
Изход
На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:
	•	Ако бюджета е достатъчен:
"You have {остатъчен бюджет} leva left!"
	•	Ако сумата надхвърля бюджета:
"Not enough money! You need {нужна сума} leva more!"
Резултатът да се форматира до втория знак след десетичната запетая.
			Бюджет: 900 лв
Сума за видеокарти: 2 * 250 = 500 лв.

Цената за процесор: 35% от 500 = 175 лв. 
Сума за процесори: 1 * 175 = 175 лв.

Цената за рам памет: 10% от 500 = 50 лв.
Сума за рам памет: 3 * 50 = 150 лв. 

Обща сума: 500 + 175 + 150 = 825 лв.
Броя на видеокартите е по-голям от броя на процесорите, затова той получава 15% отстъпка от крайната цена: 825 – 15% = 701.25 лв.
701.25 <= 900 
=> парите са му достатъчни 
=> остават 900 – 701.25 = 198.75 лв.*/
			double PetarsBudget = double.Parse(Console.ReadLine());
			int videoCards = int.Parse(Console.ReadLine());
			int processors = int.Parse(Console.ReadLine());
			int ram = int.Parse(Console.ReadLine());

			int videoCardsPrice = 250;
			double videoCardsSum = videoCardsPrice * videoCards;
			double processorsPrice = videoCardsSum * 0.35;
			double processorsSum = processorsPrice * processors;
			double ramPrice = videoCardsSum * 0.1;
			double ramSum = ramPrice * ram;
			double totalPrice = videoCardsSum + processorsSum + ramSum;
			
			if (videoCards > processors)
			{
				totalPrice = totalPrice * 0.85;
			}
			double moneyLeft = PetarsBudget - totalPrice;
			if (totalPrice <= PetarsBudget)
			{
				Console.WriteLine($"You have {Math.Abs(moneyLeft):f2} leva left!");
			}
			else
			{
				Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva more!");
			}
			
		}
    }
}











