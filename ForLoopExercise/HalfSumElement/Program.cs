using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            // четем n от конзолата (колко числа да очакваме)
            int n = int.Parse(Console.ReadLine());

            int num;
            int maxNum = int.MinValue;
            int sum = 0;
            // създаваме цикъл, който да се изпълнява n на брой пъти
            // = четем число от конзолата
            //= проверявам дали числото е най-голямото въведено до момента и то става най-голямото число
            //=добавям го към сумата на всички числа
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());    
                if (num > maxNum)
                {
                    maxNum = num;
                }
                sum += num;
            }
            sum -= maxNum;
            // от сумата на всички числа изваждам най-голямото

            // проверка дали сумата на всички числа е равна на най-голямото число и ако е равно отпечатвам:
            //Yes и на нов ред sum
            if (sum == maxNum) 
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}




