﻿using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни. С парите, които ще спечели иска да отиде на екскурзия. 
Цени на играчките:
	•	Пъзел - 2.60 лв.
	•	Говореща кукла - 3 лв.
	•	Плюшено мече - 4.10 лв.
	•	Миньон - 8.20 лв.
	•	Камионче - 2 лв.
Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена. От спечелените пари Петя трябва да даде 10% за наема на магазина. Да се пресметне дали 
			парите ще ѝ стигнат да отиде на екскурзия.
Вход
От конзолата се четат 6 реда:
	1.	Цена на екскурзията - реално число в интервала [1.00 … 10000.00]
	2.	Брой пъзели - цяло число в интервала [0… 1000]
	3.	Брой говорещи кукли - цяло число в интервала [0 … 1000]
	4.	Брой плюшени мечета - цяло число в интервала [0 … 1000]
	5.	Брой миньони - цяло число в интервала [0 … 1000]
	6.	Брой камиончета - цяло число в интервала [0 … 1000]
Изход
На конзолата се отпечатва:
	•	Ако парите са достатъчни се отпечатва:
		o	"Yes! {оставащите пари} lv left."
	•	Ако парите НЕ са достатъчни се отпечатва:
		o	"Not enough money! {недостигащите пари} lv needed."

Резултатът трябва да се форматира до втория знак след десетичната запетая.*/
			double tourPrice = double.Parse(Console.ReadLine());
			int puzzles = int.Parse(Console.ReadLine());
			int dolls = int.Parse(Console.ReadLine());
			int teddybears = int.Parse(Console.ReadLine());	
			int minions = int.Parse(Console.ReadLine());
			int trucks = int.Parse(Console.ReadLine());

			double puzzlesPrice = 2.60;
			int dollsPrice = 3;
			double teddybearPrice = 4.10;
			double minionsPrice = 8.20;
			int truckPrice = 2;

			double sum = (puzzles * puzzlesPrice) + (dolls * dollsPrice) + (teddybears * teddybearPrice) + (minions * minionsPrice) + (trucks * truckPrice);
			double toysNum = puzzles + dolls + teddybears + minions + trucks;

			if (toysNum >= 50) 
			{
				sum = sum * 0.75;
			}

			double rent = sum * 0.1;
			double profit = sum - rent;
			double moneyLeft = profit - tourPrice;
			if (profit >= tourPrice)
			{
				Console.WriteLine($"Yes! {Math.Abs(moneyLeft):f2} lv left.");
			}
			else
			{
				Console.WriteLine($"Not enough money! {Math.Abs(moneyLeft):f2} lv needed.");
			}
		}
    }
}












