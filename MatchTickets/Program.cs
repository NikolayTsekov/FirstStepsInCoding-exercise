using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Когато пуснали билетите за Евро 2016, група запалянковци решили да си закупят. Билетите имат две категории с различни цени:
	•	IP – 499.99 лева.
	•	Normal – 249.99 лева.
Запалянковците имат определен бюджет, а броят на хората в групата определя какъв процент от бюджета трябва да се задели за транспо
		От 1 до 4 – 75% от бюджета.
	•	От 5 до 9 – 60% от бюджета.
	•	От 10 до 24 – 50% от бюджета.
	•	От 25 до 49 – 40% от бюджета.
	•	50 или повече – 25% от бюджета.
Напишете програма, която да пресмята дали с останалите пари от бюджета могат да си купят билети за избраната категория. И колко пари ще им останат или ще са им нужни.
Вход
Входът се чете от конзолата и съдържа точно 3 реда:
	•	На първия ред е бюджетът – реално число в интервала [1 000.00 ... 1 000 000.00]
	•	На втория ред е категорията – "VIP" или "Normal"
	•	На третия ред е броят на хората в групата – цяло число в интервала [1 ... 200]
Изход
Да се отпечата на конзолата един ред:
	•	Ако бюджетът е достатъчен:
		o	"Yes! You have {останалите пари на групата} leva left."
	•	Ако бюджетът НЕ Е достатъчен:
		o	"Not enough money! You need {сумата, която не достига} leva."
Сумите трябва да са форматирани с точност до два знака след десетичната запетая.*/
			double budget = double.Parse(Console.ReadLine());
			string category = Console.ReadLine();
			int people = int.Parse(Console.ReadLine());

			double neededMoney = 0;
			double moneyLeft = 0;

			if (people >= 1 && people <= 4) 
			{
				moneyLeft = budget - (budget * 0.75);
			}
			else if (people >= 5 && people <= 9) 
			{
				moneyLeft = budget - (budget * 0.60);
			}
			else if (people >= 10 && people <= 24) 
			{
				moneyLeft = budget - (budget * 0.50);
			}
			else if (people >= 25 && people <= 49)
			{
				moneyLeft = budget - (budget * 0.40);
			}
			else if (people >= 50)
			{
				moneyLeft = budget - (budget * 0.25);
			}
			if (category == "VIP")
			{
				neededMoney = people * 499.99;
				if (moneyLeft > neededMoney) 
				{
					Console.WriteLine($"Yes! You have {moneyLeft - neededMoney:F2} leva left.");
				}
				else 
				{
					Console.WriteLine($"Not enough money! You need {neededMoney - moneyLeft:F2} leva.");
				}
			}
			if ( category == "Normal")
			{
				neededMoney = people * 249.99;
				if (moneyLeft > neededMoney)
				{
                    Console.WriteLine($"Yes! You have {moneyLeft - neededMoney:F2} leva left.");
                }
				else
				{
                    Console.WriteLine($"Not enough money! You need {neededMoney - moneyLeft:F2} leva.");
                }
            }
        }
    }
}


















































