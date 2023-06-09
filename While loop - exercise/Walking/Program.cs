﻿using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Габи си е поставила за цел да върви 10 000 стъпки всеки ден. Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си. Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня и когато постигне целта си да се изписва "Goal reached! Good job!"  и колко стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла докато се прибира. След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: "{разликата между стъпките} more steps to reach goal."*/
            // създавам променливи за:
            // => брой стъпки, които е направила
            // => вход от конзолата
            int steps = 0;
            string input;

            //1. Създавам цикъл, който се изпълнява докато тя не постигне целта си (10 000 стъпки)
            //=> четем вход от конзолата
            while (steps < 10000) 
            {
                //=> проверявам дали входът е съобщението "Going home"
                //==> четем стъпките, които прави до вкъщи  и ги добавям към общия брой
                //===> проверявам дали стъпките са по-малко от 10 000. Ако са:отпечатвам {разликата между стъпките} more steps to reach goal. и спирам изпълнението на цикъла

                //=> към общия брой стъпки добавям стъпките, въведени като вход от конзолата
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }
                steps += int.Parse(input);
            }
            //2. Проверявам дали е успяла да постигне целта си. Ако е: отпечатвам = Goal reached! Good job!{разликата между стъпките} steps over the goal! на два реда.
            if (steps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(steps - 10000)} more steps to reach goal.");
            }



        }
    }
}

























