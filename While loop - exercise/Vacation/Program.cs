using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере необходимата сума. Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.
Вход
От конзолата се четат:
	•	Пари нужни за екскурзията - реално число в интервала [1.00...25000.00]
	•	Налични пари - реално число в интервала [0.00...25000.00]
След това многократно се четат по два реда:
	•	Вид действие – текст с възможности "spend" и "save"
		•	Сумата, която ще спести / похарчи - реално число в интервала [0.01… 25000.00]
Изход
Програмата трябва да приключи при следните случаи:
	•	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
	o	"You can't save the money."
	o	"{Общ брой изминали дни}"
	•	Ако Джеси събере парите за почивката на конзолата се изписва:
	o	"You saved the money for {общ брой изминали дни} days."*/
			double neededMoney = double.Parse(Console.ReadLine());
			double ownedMoney = double.Parse(Console.ReadLine());

			int daysCounter = 0;
			int spendingCounter = 0;

			while (ownedMoney < neededMoney && spendingCounter < 5) 
			{
				string command = Console.ReadLine();
				double money = double.Parse(Console.ReadLine());
				if (command == "save")
				{
					ownedMoney += money;
					spendingCounter = 0;
					
				}
				else if (command == "spend")
				{
                    if (money > ownedMoney)
                    {
                        ownedMoney = 0;
                        spendingCounter++;
                    }
					else
					{
						ownedMoney -= money;
						spendingCounter++;
					}
                }
				if (ownedMoney < 0)
				{
					ownedMoney = 0;
				}
				daysCounter++;
			}
			if (spendingCounter == 5) 
			{
				Console.WriteLine("You can't save the money.");
				Console.WriteLine(daysCounter);
			}
			if (ownedMoney >= neededMoney)
			{
				Console.WriteLine($"You saved the money for {daysCounter} days.");
			}
        }
    }
}
























