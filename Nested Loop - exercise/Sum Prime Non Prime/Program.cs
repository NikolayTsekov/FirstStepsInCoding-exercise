using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата цели числа в диапазона, докато не се получи команда "stop". Да се намери сумата на всички въведени прости и сумата на всички въведени непрости числа. Тъй като по дефиниция от математиката отрицателните числа не могат да бъдат прости, ако на входа се подаде отрицателно число да се изведе следното съобщение "Number is negative.". В този случай въведено число се игнорира и не се прибавя към нито една от двете суми, а програмата продължава своето изпълнение, очаквайки въвеждане на следващо число. 
На изхода да се отпечатат на два реда двете намерени суми в следния формат:
	•	"Sum of all prime numbers is: {prime numbers sum}"
	•	"Sum of all non prime numbers is: {nonprime numbers sum}"*/
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop") 
            {
                int num = int.Parse(input);
                if (num < 0) 
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i < num; i++) 
                {
                    if (num%i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    primeSum += num;
                else
                    nonPrimeSum += num;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");

        }
    }
}

























