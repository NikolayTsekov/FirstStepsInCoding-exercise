using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 1 типа променливи и присвояваме стойност от конзолата за:
               - брой страници
               - страници за 1 час
               - брой дни */
            int page = int.Parse(Console.ReadLine());
            int pagePerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            // 2 намираме общото време
            // - брой страници  / страници за 1 час
            int totalHours = page / pagePerHour;
            // 3. Намираме по колко часа на ден трябва да чете
            // - обшо време / брой дни
            int hoursPerDay = totalHours / days;
            // 4. отпечатваме на конзолата колко часа на ден трябва да чете
            Console.WriteLine(hoursPerDay);
        }
    }
}







