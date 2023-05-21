using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingmachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int money = 0;
            // създавам цикъл, който да се изпълнява за всеки рожден ден
            // проверяваме дали текущия рд е четен или нечетен
            //ако е четен - към спестяванията до момента += възрастта*5-1
            // ако е нечетен - към спестяванията до момента += цена за играчка
            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    money += birthday * 5 - 1;

                }
                else
                {
                    money += toyPrice; 
                }
            }
            // проверявам дали парите са достатъчни за пералня
            if (money >= washingmachinePrice) 
            {
                Console.WriteLine($"Yes! {money - washingmachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingmachinePrice - money:f2}");
            }
        }
    }
}






