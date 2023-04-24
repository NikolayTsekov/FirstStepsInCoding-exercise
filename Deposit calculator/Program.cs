using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            //1. Създавам три променливи и присвояваме стойност

            // депозирана сума
            // срок
            // лихвен процент
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine()) * 0.01;

            // 2. Създавам нова променлива, в която да пазим сумата
            // сума = депозирана сума + срок на депозита ((депозирана сума *годишен лихвен процент) / 12)
            double sum = deposit + term * (deposit * rate / 12);
            // 3. Отпечатваме резултата на конзолата
            Console.WriteLine(sum);
 
            }
        }
    }