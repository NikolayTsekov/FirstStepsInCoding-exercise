﻿using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Георги ще има гости вечерта и решава да ги нагости с паламуд, сафрид и миди. Затова отива на рибната борса, за да си купи по няколко килограма.
             * Oт конзолата се въвеждат цените в лева на скумрията и цацата. Също количеството на паламуд, сафрид и миди в килограми. Колко пари ще са му необходими, 
             * за да плати сметката си, ако цените на борсата са:
	•	Паламуд – 60% по-скъп от скумрията
	•	Сафрид – 80% по-скъп от цацата
	•	Миди – 7.50 лв. за килограм
Вход
От конзолата се четат 5 числа:
	•	Първи ред – цена на скумрията на килограм. Реално число в интервала [0.00…40.00]
	•	Втори ред – цена на цацата на килограм. Реално число в интервала [0.00…30.00]
	•	Трети ред – килограма паламуд. Реално число в интервала [0.00…50.00]
	•	Четвърти ред – килограма сафрид. Реално число в интервала [0.00… 70.00]
	•	Пети ред – килограма миди. Цяло число в интервала [0 ... 100]
Изход
Да се отпечата на конзолата едно число с плаваща запетая: колко пари ще са нужни на Георги, за да си плати сметката.
            Числото трябва да е форматирано до вторият знак след десетичната запетая (1.2457 -> 1.25).
            Цена на паламуда = 6.90 + 6.90 * 0.60 = 11.04 лв. за килограм
Сума паламуд = 1.5 * 11.04 = 16.56
Цена на сафрид = 4.20 + 4.20 * 0.80 =  7.56 лв. за килограм
Сума сафрид = 2.5 * 7.56 = 18.90 
Сума миди = 1 * 7.50 = 7.50 
Сметка = 16.56 + 18.90 + 7.50 = 42.96 */
            double mackerel = double.Parse(Console.ReadLine());
            double sprat = double.Parse(Console.ReadLine());
            double bonito = double.Parse(Console.ReadLine());
            double scad = double.Parse(Console.ReadLine());    
            int clams = int.Parse(Console.ReadLine());

            double bonitoPrice = mackerel + mackerel * 0.60;
            double bonitoSum = bonito * bonitoPrice;
            double scadPrice = sprat + sprat * 0.80;
            double scadSum = scad * scadPrice;
            double clamsSum = clams * 7.50;

            double finalPrice = bonitoSum + scadSum + clamsSum;

            Console.WriteLine($"{finalPrice:F2}");


        }
    }
}











