using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма която да пресмята средният разход за месец на семейство за даден период време. За всеки месец разходите са следните:
	•	За ток – всеки месец е различен, ще се чете от конзолата
	•	за вода – 20 лв.
	•	за интернет – 15 лв.
	•	за други – събират се тока, водата и интернета за месеца и към сумата се прибавят 20%.
За всеки разход трябва да се пресметне колко общо е платено за всички месеци.
Вход
Входът се чете от конзолата:
	•	Първи ред – месеците за които се търси средният разход – цяло число в интервала [1...100]
	•	За всеки месец – сметката за ток – реално число в интервала [1.00...1000.00]
Изход
Да се отпечата на конзолата 5 реда:
	•	1ви ред: "Electricity: {ток за всички месеци} lv"
	•	2ри ред: "Water: {вода за всички месеци} lv"
	•	3ти ред: "Internet: {интернет за всички месеци} lv"
	•	4ти ред: "Other: {други за всички месеци} lv"
	•	5ти ред: "Average: {средно всички разходи за месец} lv"
Всички числа трябва да са форматирана до вторият знак след запетаята.*/
			int months = int.Parse(Console.ReadLine());

			double totalElectricity = 0;
			double waterCost = months * 20;
			double internetCost = months * 15;
			double others = 0;

			for (int i = 1; i <= months; i++)
			{
				double electricityCost = double.Parse(Console.ReadLine());
				totalElectricity += electricityCost; 
				others += (35 + electricityCost) * 1.2;
			}
			Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
			Console.WriteLine($"Water: {waterCost:f2} lv");
			Console.WriteLine($"Internet: {internetCost:f2} lv");
			Console.WriteLine($"Other: {others:f2} lv");
			Console.WriteLine($"Average: {(totalElectricity + waterCost + internetCost + others) / months:f2} lv");
        }
    }
}












