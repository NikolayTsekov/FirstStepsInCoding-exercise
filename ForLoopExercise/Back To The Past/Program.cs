﻿using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Иванчо е на 18 години и получава наследство, което се състои от X сума пари и машина на времето. Той решава да се върне до 1800 година, но не знае дали парите ще са достатъчни, за да живее без да работи. Напишете програма, която пресмята, дали Иванчо ще има достатъчно пари, за да не се налага да работи до дадена година включително. Като приемем, че за всяка четна (1800, 1802 и т.н.) година ще харчи 12 000 лева. За всяка нечетна (1801,1803  и т.н.) ще харчи 12 000 + 50 * [годините, които е навършил през дадената година].
Вход
Входът се чете от конзолата и съдържа точно 2 реда:
	•	Наследените пари – реално число в интервала [1.00 ... 1 000 000.00]
	•	Годината, до която трябва да живее (включително) – цяло число в интервала [1801 ... 1900]
Изход
Да се отпечата на конзолата 1 ред. Сумата трябва да е форматирана до два знака след десетичната запетая:
	•	Ако парите са достатъчно:
		o	"Yes! He will live a carefree life and will have {N} dollars left." – където N са парите, които ще му останат.
	•	Ако парите НЕ са достатъчно:
		o	"He will need {М} dollars to survive." – където M е сумата, която НЕ достига.*/
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            double yearsold = 17;
           
            for (int year = 1800; year <= yearToLive; year++)
            {
                if (year % 2 ==  0) 
                {
                    inheritedMoney = inheritedMoney - 12000;
                }
                else if (year % 2 != 0)
                {
                    yearsold += 2;
                    inheritedMoney = inheritedMoney - (12000 + (50*yearsold));
                }
            }
            if (inheritedMoney >= 0) 
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
            
        }
    }
}








