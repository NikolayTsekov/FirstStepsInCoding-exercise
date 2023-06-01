using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*На благотворително събитие плащанията за закупените продукти винаги се редуват: плащане в брой и плащане с карта. Установени са следните правила за заплащане:
     •	Ако продуктът надвишава 100лв., за него не може да се плати в брой
     •	Ако продуктът е на цена под 10лв., за него не може да се плати с кредитна карта
 Програмата приключва или след като получим команда "End" или след като средствата бъдат събрани.
 Вход
 От конзолата се четат:
     •	Сумата, която се очаква да бъде събрана от продажбите - цяло число в интервала [1 ... 10000]
 На всеки следващ ред, до получаване на командата "End" или докато не се съберат нужните средства: цените на предметите, които ще бъдат закупени - цяло число в интервала [1 ... 500]
 Изход
 На конзолата да се отпечата:
     •	При успешна транзакция: "Product sold!"
     •	При неуспешна транзакция: "Error in transaction!"
     •	Ако сумата на всички закупени продукти надвиши или достигне очакваната сума, програмата трябва да приключи и на конзолата да се изпишат два реда:
     o	"Average CS: {средно плащане в кеш на човек}"
     o	"Average CC: {средно плащане с карта на човек}" 
               Плащанията трябва да бъдат форматирани до втората цифра след десетичния знак.
     •	При получаване на команда "End", да се изпише един ред:
     o	"Failed to collect required money for charity."*/
            int totalSum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int payCash = 0;
            int payCard = 0;
            int payCashCounter = 0;
            int payCardCounter = 0;
            int paymentCounter = 0;

            //while (input != "End" && totalSum > 0)
            while (input != "End")
            {
                paymentCounter++;
                int productPrice = int.Parse(input);
                if (paymentCounter % 2 != 0 && productPrice <= 100)
                {
                    payCashCounter++;
                    totalSum -= productPrice;
                    payCash += productPrice;
                    Console.WriteLine($"Product sold!");
                }
                //else if (paymentCounter % 2 != 0 && productPrice > 100)
                //{
                //    Console.WriteLine("Error in transaction!");
                //}
                else if (paymentCounter % 2 == 0 && productPrice >= 10)
                {
                    payCardCounter++;
                    totalSum -= productPrice;
                    payCard += productPrice;
                    Console.WriteLine("Product sold!");
                }
                //else if (payCardCounter % 2 == 0 && productPrice < 10)
                else
                {
                    Console.WriteLine("Error in transaction!");
                }

                if (totalSum <= 0)
                {
                    Console.WriteLine($"Average CS: {1.0 * payCash / payCardCounter:f2}");
                    Console.WriteLine($"Average CC: {1.0 * payCard / payCardCounter:f2}");
                    break;
                }

                input = Console.ReadLine();
            }


            //if (totalSum <= 0)
            //{
            //    Console.WriteLine($"Average CS: {1.0 * payCash / payCardCounter:f2}");
            //    Console.WriteLine($"Average CC: {1.0 * payCard / payCardCounter:f2}");
            //}
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}






























