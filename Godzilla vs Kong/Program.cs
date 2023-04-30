using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Четем входа от конзолата
            // бюджет double
            // брой статисти int
            //цена на облекло double
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine()); 
            double clothingPrice = double.Parse(Console.ReadLine());
            //2. Намираме цената на декора, която е 10 % от бюджета
            double decor = budget * 0.10;
            //3. Намираме цената за облеклото, която = на броя статисти  * цената за облекло
            double priceForExtras = extras * clothingPrice;
            //4. Проверяваме дали броя на статистите е  повече от 150
            // ако е:начисляваме отстъпка за облеклото 10%
            if(extras>150)
            {
                priceForExtras = priceForExtras - priceForExtras * 0.10;
            }
            //5. Намираме общата сума (декор+облекло)
            double totalPrice = priceForExtras + decor;
            //6. Проверявам дали бюджета е достатъчен
            if (budget>=totalPrice) 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget-totalPrice):f2} leva more.");
            }
            //ако е:бюджета >= общата сума
            //Отпечатвам "Action!" и Wingard starts filming with (останалитепараметри)
            //в противен случай:
            //Отпечатвам "Not enough money"



        }
    }
}













