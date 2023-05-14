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
            /*Напишете програма, която чете две цели числа (N1 и N2) и оператор, с който да се извърши дадена математическа операция с тях. Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%). При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен. При обикновеното деление – резултата. При модулното деление – остатъка. Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели. В този случай трябва да се отпечата специално съобщениe.
Вход
От конзолата се прочитат 3 реда, въведени от потребителя:
	•	N1 – цяло число в интервала [0...40 000]
	•	N2 – цяло число в интервала [0...40 000]
	•	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
Изход
Да се отпечата на конзолата един ред:
	•	Ако операцията е деление:
		o	"{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
	•	Ако операцията е модулно деление: 
		o	"{N1} % {N2} = {остатък}"
	•	В случай на деление с 0 (нула): 
		o	"Cannot divide {N1} by zero" */

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();

            switch (mathOperator) 
            {
                case "+": int sum = n1 + n2; 
                    if (sum % 2 == 0) 
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                    }
                    break; 
                case "-": int difference = n1 - n2; 
                    if (difference % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {difference} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {difference} - odd");
                    }
                    break;
                case "*": int product = n1 * n2; 
                    if (product % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {product} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {product} - odd");
                    }
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        double result = n1 * 1.0 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:F2}");
                    }
                    break;
                case "%": 
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        int leftover = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {leftover}");
                    }
                    break;
            }
            
        }
    }
}

































