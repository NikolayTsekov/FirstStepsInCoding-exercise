using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем num от конзолата
            int num = int.Parse(Console.ReadLine());
            double bonus;
            //2. Проверяваме големината на числото
            // - ако числото е <=100 начилсяваме бонус 5 точки
            /// - ако числото е >1000 бонуса е 10% от num
            /// - в противен случай  (числото е между 101 и 1000) бонусът е 20% от num
            if(num <= 100)
            {
                bonus = 5;
            }
            //3.Проверки за доп. бонус
            // дали числото е четно: ако е бонус = 1 точка
            // в противен случай проверяваме дали завършва на 5, ако завършва бонусът е 2 точки
            else if (num > 1000)
            {
                bonus = num * 0.1;
            }
            //4. Отпечатваме резултата на конзолата
            // бонусът
            // бонусът + числото
            else
            {
                bonus = num * 0.2;
            }

            if (num%2==0)
            {
                bonus = bonus + 1;
            }
            else if (num%10==5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + num); 
        }
    }
}











