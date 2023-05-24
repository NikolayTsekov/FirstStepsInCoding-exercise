using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която да пресмята резултата от игра. Първо получавате число, което показва колко хода ще продължи играта. После за всеки ход на играта ще получавате по едно ново число. Според интервала в който попада числото се прибавят точки. Ако числото е отрицателно или по-голямо 50, тогава то е невалидно. В началото на играта резултата е 0 и на всеки ход се прибавят точки по следният начин:

	•	От 0 до 9  20 % от числото
	•	От 10 до 19  30 % от числото
	•	От 20 до 29  40 % от числото
	•	От 30 до 39  50 точки
	•	От 40 до 50  100 точки
	•	Невалидно число  резултата се дели на 2

Освен резултата програмата трябва да изкарва статистика за проценти числа в дадените интервали.
Вход
Входът се чете от конзолата:
	•	Първи ред - колко хода ще има по време на играта – цяло число в интервала [1...100]
	•	За всеки ход – числата, които се проверяват в кой интервал са – цели числа в интервала [-100...100]
Изход
Да се отпечата на конзолата 7 реда:
	•	1ви ред: "{Краен резултат}"
	•	2ри ред: "From 0 to 9: {процент в интервала}%"
	•	3ти ред: "From 10 to 19: {процент в интервала}%"
	•	4ти ред: "From 20 to 29: {процент в интервала}%"
	•	5ти ред: "From 30 to 39: {процент в интервала}%"
	•	6ти ред: "From 40 to 50: {процент в интервала}%"
	•	7ми ред: "Invalid numbers: {процент в интервала}%"
Всички числа трябва да са форматирана до вторият знак след запетаята.*/
			int moves = int.Parse(Console.ReadLine());
			double interval1 = 0;
			double interval2 = 0;
			double interval3 = 0;
			double interval4 = 0;
			double interval5 = 0;
			double invalidInterval = 0;
			double points = 0;

			for (int i = 0; i < moves; i++)
			{
				double numbers = double.Parse(Console.ReadLine());
				if (numbers >= 0 && numbers <= 9)
				{
					interval1++;
					points += numbers * 0.2;
				}
				else if (numbers >= 10 && numbers <= 19)
				{
					interval2++;
					points += numbers * 0.3;
				}
				else if (numbers >= 20 && numbers <= 29)
				{
					interval3++;
					points += numbers * 0.4;
				}
				else if (numbers >= 30 && numbers <= 39)
				{
					interval4++;
					points += 50;
				}
				else if (numbers >= 40 && numbers <= 50)
				{
					interval5++;
					points += 100;
				}
				else
				{
					invalidInterval++;
					points = points / 2;
				}
			}
			Console.WriteLine($"{points:f2}");
			Console.WriteLine($"From 0 to 9: {interval1 / moves * 100:f2}%");
			Console.WriteLine($"From 10 to 19: {interval2 / moves * 100:f2}%");
			Console.WriteLine($"From 20 to 29: {interval3 / moves * 100:f2}%");
			Console.WriteLine($"From 30 to 39: {interval4 / moves * 100:f2}%");
			Console.WriteLine($"From 40 to 50: {interval5 / moves * 100:f2}%");
			Console.WriteLine($"Invalid numbers: {invalidInterval / moves * 100:f2}%");

        }
    }
}












