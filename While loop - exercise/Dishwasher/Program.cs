using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Гошо работи в ресторант и отговаря за зареждането на съдомиялната накрая на деня.
Вашата задача е да напишете програма, която изчислява, дали дадено закупено количество бутилки от препарат за съдомиялна е достатъчно, за да измие определено количество съдове. Знае се, че всяка бутилка съдържа 750 мл. препарат, за 1 чиния са нужни 5 мл., а за тенджера 15 мл.  Приемете, че на всяко трето зареждане със съдове, съдомиялната се пълни само с тенджери, а останалите пъти с чинии. Докато не получите команда "End" ще продължите да получавате бройка съдове, които трябва да бъдат измити.
Вход
От конзолата се четат:
	•	Брой бутилки от препарат, който ще бъде използван за миенето на чинии - цяло число в интервала [1…10] 
На всеки следващ ред, до получаване на командата "End" или докато количеството препарат не се изчерпи, брой съдове, които трябва да бъдат измити - цяло число в интервала [1…100]
Изход
В случай, че количеството препарат е било достатъчно за измиването на съдовете:
"Detergent was enough!"
"{брой чисти чинии} dishes and {брой чисти тенджери} pots were washed."
"Leftover detergent {количество останал препарат} ml."
В случай, че количеството препарат не е било достатъчно за измиването на съдовете:
"Not enough detergent, {количество не достигнал препарат} ml. more necessary!"*/
            int bottlesDetergentCount = int.Parse(Console.ReadLine());
            int bottlesDetergent = bottlesDetergentCount * 750;
            string input = string.Empty;  
            int dishes = 0;
            int plates = 0;
            int counter = 0;
            int pots = 0;

            while (true) 
            {
                input = Console.ReadLine(); 
                if (input == "End") 
                {
                    break;
                }
                counter++;
                if (counter % 3 ==  0) 
                {
                    dishes = int.Parse(input);
                    pots += dishes;
                    bottlesDetergent -= dishes * 15;
                }
                else 
                {
                    dishes = int.Parse(input);
                    plates += dishes;
                    bottlesDetergent -= dishes * 5;
                }
            if (bottlesDetergent < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(bottlesDetergent)} ml. more necessary!");
                return;
            }
            }
            
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
            Console.WriteLine($"Leftover detergent {bottlesDetergent} ml.");
        }
    }
}





























