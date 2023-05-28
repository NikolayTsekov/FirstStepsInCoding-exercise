using System;
using System.ComponentModel.Design;

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
		    int collectedSum = int.Parse(Console.ReadLine());
			string input = Console.ReadLine();
			int paymentCounter = 0;
			int paymentCash = 0;
			int paymentCard = 0;
			int paymentCashCounter = 0;
			int paymentCardCounter = 0;

			while (input != "End" && collectedSum > 0) 
			{
				paymentCounter++;
				int productPrice = int.Parse(input);
				if (paymentCounter % 2 != 0 && productPrice <= 100) 
				{
					paymentCashCounter++;
					collectedSum -= productPrice;
					paymentCash += productPrice;
					Console.WriteLine($"Product sold!");
				}
				else if (paymentCounter % 2 != 0 && productPrice > 100)
				{
					Console.WriteLine("Error in transaction!");
				}
				
				if (paymentCounter % 2 == 0 && productPrice >= 10)
				{
					paymentCounter++;
					collectedSum -= productPrice;
					paymentCard += productPrice;
					Console.WriteLine("Product sold!");
				}
				else if (paymentCardCounter % 2 == 0 && productPrice < 10)
				{
					Console.WriteLine("Error in transaction!");
				}
				
				input = Console.ReadLine();
			}
			if (collectedSum <= 0)
			{
                
                    Console.WriteLine($"Average CS: {1.0 * paymentCash / paymentCardCounter:f2}");
                    Console.WriteLine($"Average CC: {1.0 * paymentCard / paymentCardCounter:f2}");
                    return;
            }
			else
			{
				Console.WriteLine($"Failed to collect required money for charity.");
			}

        }
    }
}






























