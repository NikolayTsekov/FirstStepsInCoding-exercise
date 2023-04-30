using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Четем от конзолата времето на всеки от състезателите
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine()); 
            int third = int.Parse(Console.ReadLine());  

            // 2. Сумираме времето на състезателите в секунди
            int totalTime = first + second + third;
            //3. Преобразуваме времето в мин. и сек.
            int min = totalTime / 60; // 110/60 = 1 (50 остатък)
            int sec = totalTime % 60; // 110%60 = 50
            //4. Отпечатваме резултата на конзолата
            if (sec >=10)
            {
                Console.WriteLine($"{min}:{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            // ако сек. са по-малко от 10 ги отпечатваме с водеща нула - 02, а ако не ги отпечатваме стандартно



        }
    }
}










