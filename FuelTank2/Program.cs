using System;
using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която да изчислява, колко ще струва на един шофьор да напълни резервоара на автомобила си, като знаете – какъв тип гориво зарежда, каква е цената за литър гориво и дали разполага с карта за отстъпки. Цените на горивата са както следва: 
	•	Бензин – 2.22 лева за един литър, 
	•	Дизел – 2.33 лева за един литър
	•	Газ – 0.93 лева за литър
Ако водача има карта за отстъпки,  той се възползва от следните намаления за литър гориво: 18 ст. за литър бензин, 12 ст. за литър дизел и 8 ст. за литър газ. 
Ако шофьора е заредил между 20 и 25 литра включително, той получава 8 процента отстъпка от крайната цена, при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена.
Вход
Входът се чете от конзолата и се състои от 3 реда:
	•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
	•	Количество гориво – реално число в интервала [1.00 … 50.00]
	•	Притежание на клубна карта – текст с възможности: "Yes" или "No"
Изход
На конзолата трябва да се отпечата един ред.
	•	"{крайната цена на горивото} lv."
Цената на горивото да бъде форматираната до втората цифра след десетичния знак.*/
            string fuel = Console.ReadLine();
            double amountOfFuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;
            double gasPrice = 0.93;

            double totalPrice = 0;

            if (fuel == "Gas")
            {
                totalPrice = gasPrice * amountOfFuel;
                if (card == "Yes")
                {
                    totalPrice = amountOfFuel * (gasPrice - 0.08);
                }
                if (amountOfFuel >= 20 && amountOfFuel <= 25)
                {
                    totalPrice *= 0.92; 
                }
                if (amountOfFuel > 25)
                {
                    totalPrice *= 0.90;
                }
            }
            else if (fuel == "Gasoline")
            {
                totalPrice = gasolinePrice * amountOfFuel;
                if (card == "Yes")
                {
                    totalPrice = amountOfFuel * (gasolinePrice - 0.18);

                }
                if (amountOfFuel >= 20 && amountOfFuel <= 25)
                {
                    totalPrice *= 0.92; 
                }
                if (amountOfFuel > 25)
                {
                    totalPrice *= 0.90;
                }
            }
            else if (fuel == "Diesel")
            {
                totalPrice = dieselPrice * amountOfFuel;
                if (card == "Yes")
                {
                    totalPrice = amountOfFuel * (dieselPrice - 0.12);
                }
                if (amountOfFuel >= 20 && amountOfFuel <=25)
                {
                    totalPrice *= 0.92; 
                }
                if (amountOfFuel > 25)
                {
                    totalPrice *= 0.90;
                }
            }
            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}

















































