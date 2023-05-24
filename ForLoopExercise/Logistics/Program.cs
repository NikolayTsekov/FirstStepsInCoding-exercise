using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Отговаряте за логистиката на различни товари. В зависимост от теглото на товара е нужно различно превозно средство. Цената на тон, за която се превозва товара е различна за всяко превозно средство:
	•	До 3 тона – микробус (200 лева на тон)
	•	От 4 до 11 тона – камион (175 лева на тон)
	•	12 и повече тона – влак (120 лева на тон)
Вашата задача е да изчислите средната цена на тон превозен товар, както и процента на тоновете  превозвани с всяко превозно средство, спрямо общото тегло(в тонове) на всички товари.
Вход
От конзолата се четат поредица от числа, всяко на отделен ред:
	•	На първия ред – броя на товарите за превоз – цяло число в интервала [1...1000]
	•	За всеки един товар на отделен ред – тонажа на товара – цяло число в интервала [1...1000]
Изход
Да се отпечатат на конзолата 4 реда, както следва:
	•	Първи ред – средната цена на тон превозен товар (закръглена до втория знак след дес. запетая);
	•	Втори ред – процентът тона превозвани с микробус (процент между 0.00% и 100.00%);
	•	Трети ред – процентът  тона превозвани с камион (процент между 0.00% и 100.00%);
	•	Четвърти ред – процентът тона превозвани с влак (процент между 0.00% и 100.00%).*/
			int loadsCount = int.Parse(Console.ReadLine());
			double busLoad = 0;
			double truckLoad = 0;
			double trainLoad = 0;
			double totalLoad = 0;
			double busPercent = 0;
			double truckPercent = 0;
			double trainPercent = 0;

			for (int i = 1; i <= loadsCount; i++)
			{
				int loadTonnage = int.Parse(Console.ReadLine());
				totalLoad += loadTonnage;
				if (loadTonnage <= 3)
				{
					busLoad += loadTonnage; 
				}
				else if (loadTonnage >= 4 && loadTonnage <= 11)
				{
					truckLoad += loadTonnage;
				}
				else
				{
					trainLoad += loadTonnage;
				}
			}
			busPercent = busLoad / totalLoad * 100;
			truckPercent = truckLoad / totalLoad * 100;
			trainPercent = trainLoad / totalLoad * 100;
			double averagePrice = (busLoad * 200 + truckLoad * 175 + trainLoad * 120) / totalLoad;
			Console.WriteLine($"{averagePrice:f2}");
			Console.WriteLine($"{busPercent:f2}%");
			Console.WriteLine($"{truckPercent:f2}%");
			Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}











