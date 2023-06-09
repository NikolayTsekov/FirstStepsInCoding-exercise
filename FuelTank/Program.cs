﻿using System;
using System.ComponentModel.Design;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която познава дали резервоара на едно превозно средство има нужда от презареждане на горивото или не. 
             * От конзолата се четат два реда – текст и реално число, на първия ред се чете типа на горивото – текст с възможности: "Diesel", "Gasoline" или "Gas", 
             * а на втория литрите гориво, които има в резервоара. Ако литрите гориво са повече или равни на 25, 
             * на конзолата да се отпечата "You have enough {вида на горивото}.", ако са по-малко от 25, да се отпечата "Fill your tank with {вида на горивото}!". 
             * В случай, че бъде въведено гориво, различно от посоченото, да се отпечата "Invalid fuel!".*/

            string fuel = Console.ReadLine().ToLower();
            double litres = double.Parse(Console.ReadLine());

            if (fuel == "diesel" || fuel == "gasoline" || fuel == "gas")
            {
                if (litres >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else if (litres < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }

        }
    }
}
















































