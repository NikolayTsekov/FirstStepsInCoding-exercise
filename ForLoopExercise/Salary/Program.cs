using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            // създавам цикъл, който да се изпълнява за всеки отворен таб
            //= четем име на сайт, отворен на съответния таб
            for (int tab = 1; tab <= tabs; tab++)
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                    salary -= 150;
                }
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }
            }
            //Проверяваме дали е:
            //Facebook - глоба 150 лв (заплата 150 лв)
            //Instagram - глоба 100 лв (заплата 100 лв)
            //Reddit - глоба 50 лв (заплата 50 лв)

            //проверявам дали заплатата е <=0
            // ако е: отпечатвам you have lost... и спирам изпълнението на цикъла

            //прверявам дали е останала заплата: ако е - отпечатвам остатъка от заплатата
            if (salary > 0) 
            {
                Console.WriteLine(salary);
            }

        }
    }
}







