using System;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.CompilerServices;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Атанас решава да прекара отпуската си в Банско и да кара ски. Преди да отиде обаче, трябва да резервира хотел и да изчисли колко ще му струва престоя. Налични са следните видове помещения, със следните цени за престой:
			▪	"room for one person" – 18.00 лв за нощувка
			▪	"apartment" – 25.00 лв за нощувка 
			▪	"president apartment" – 35.00 лв за нощувка
Според броят на дните, в които ще остане в хотела (пример: 11 дни = 10 нощувки) и видът на помещението, което ще избере, той може да ползва различно намаление.*/ 
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();   
            string feedback = Console.ReadLine();

            //1. крайна цена за престоя = бр. нощувки + цена за нощувка
            int nights = days - 1;
            double priceNight = 0.0;

            switch (roomType) 
            {
                case "room for one person": priceNight = 18; break;
                case "apartment": priceNight = 25; break;
                case "president apartment": priceNight = 35; break;

            }
            double totalPrice = nights * priceNight;
            //2. отстъпки
            if (roomType == "apartment")
            {
                if (days < 10)
                {
                    totalPrice = totalPrice - 0.30 * totalPrice;
                }
                else if (days >= 10 && days <= 15) 
                {
                    totalPrice = totalPrice - 0.35 * totalPrice;
                }
                else if (days > 15)
                {
                    totalPrice = totalPrice - 0.50 * totalPrice;
                }
            }
            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    totalPrice = totalPrice - 0.10 * totalPrice;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice = totalPrice - 0.15 * totalPrice;
                }
                else if (days > 15)
                {
                    totalPrice = totalPrice - 0.20 * totalPrice;
                }
            }
            //3. доп.отстъпли/ намаления - зависят от feedback-a
            if  (feedback == "positive")
            {
                totalPrice = totalPrice + 0.25 * totalPrice;
            }
            else if (feedback == "negative")
            {
                totalPrice = totalPrice - 0.10 * totalPrice;
            }
            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
































