using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата час и минути
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //2. Преобразуваме часовете и минутите само в минути
            minutes = minutes + hours * 60;
            //3. Към минутите прибавям 15 сек.
            minutes = minutes + 15;
            //4. Преобразуваме времето в часове и минути
            hours = minutes / 60;
            minutes = minutes % 60;
            //5/ Проверяваме дали сме отишли в следващие ден
            bool newDay = hours == 24;
            //6. Отпечатваме резулата на конзолата
            // мин се отпечатват с две цифри
            if (newDay)
            {
                Console.WriteLine($"0:{minutes:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
        }
    }
}












