using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Поканени сте на 30-ти рожден ден, на който рожденикът черпи с огромна торта. Той обаче не знае колко парчета могат да си вземат гостите от нея. Вашата задача е да напишете програма, която изчислява броя на парчетата, които гостите са взели, преди тя да свърши. Ще получите размерите на тортата (широчина и дължина – цели числа в интервала [1...1000]) и след това на всеки ред, до получаване на командата "STOP" или докато не свърши тортата, броят на парчетата, които гостите вземат от нея. 
Бележка: Едно парче торта е с размер 1х1 см.
Да се отпечата на конзолата един от следните редове:
	•	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
"No more cake left! You need {брой недостигащи парчета} pieces more."*/
            //1. Четем от конзолата ширина и дължина на тортата
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            //2.Намираме броя парчета на тортата
            int cakeSize = width * lenght;
            string input = Console.ReadLine();
            //3. Създавам цикъл, който да се изпълнява, докато не получа командата Стоп от конзолата
            while (input != "STOP")
            {
                cakeSize -= int.Parse(input);
                ///= четем парчета торта, които гостите вземат
                /////изваждам парчетата от останалата торта

                if (cakeSize < 0)
                {
                    break;
                }
                // проверявам дали парчетата са < 0
                // break;
                input = Console.ReadLine();

            }            //4. проверявам дали парчетата са >= 0
            if (cakeSize >= 0) 
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
             // ако са:{брой парчета} pieces are left.Ако не са:No more cake left! You need {брой недостигащи парчета} pieces more.
        }
    }
}



























