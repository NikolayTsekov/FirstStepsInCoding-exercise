using System;
using System.Runtime.CompilerServices;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто. Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.*/
            // 2 лв = 200; 1лв = 100; 50; 20; 10; 5; 2; 1.

            //1. Четем ресто, което трябва да върнем от конзолата и го превръщаме в стотинки от левове ( * 100)
            double changeToReturn = double.Parse(Console.ReadLine()) * 100;
            //създавам брояч на монети
            int counter = 0;
            //2. Създавам цикъл, който се изпълнява, докато има ресто за връщане
            while (changeToReturn > 0) 
            {
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200;
                }
                else if (changeToReturn >= 100)
                {
                    changeToReturn -= 100;
                }
                else if (changeToReturn >= 50)
                {
                    changeToReturn -= 50;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                }
                else if (changeToReturn >= 1)
                {
                    changeToReturn -= 1;
                }
                else
                {
                    changeToReturn = 0;
                    break;
                }
                counter++;

            }
            //=> проверявам коя е най-голямата монета, която можем да върнем
            //връщаме
            //увеличавам брояча на монетите, които сме върнали с 1

            //3. Отпечатвам с колко монети сме върнали рестото
            Console.WriteLine(counter);
        }
    }
}


























