using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
           /* Екипът на СофтУни си организира футболен турнир.Първоначално прочитаме от конзолата капацитета на стадиона и броят на всички фенове. След това за всеки фен се чете секторът, в който се намира.Феновете на първия отбор са в сектор А и Б, а на втория – В и Г.Да се напише програма, която изчислява процентите на феновете във всеки сектор, спрямо общия брой фенове на стадиона, както и общият процент на феновете за двата отбора, спрямо капацитета на стадиона.Общият брой на феновете НЕ надвишава капацитета на стадиона.
Вход
От конзолата се четат поредица от числа, всяко на отделен ред:
            1.Капацитетът на стадиона – цяло число в интервала[1 … 10000];
            2.Броят на всички фенове – цяло число в интервала[1 … 10000].
За всеки един фен, на отделен ред се прочита:
	1.Секторът, на който се намира – текст – "A", "B", "V" и "G".
Изход
Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00 % и 100.00 %, форматирани до втората цифра след десетичната запетая:
            1.Процентът на феновете в сектор А

    2.Процентът на феновете в сектор Б

    3.Процентът на феновете в сектор В

    4.Процентът на феновете в сектор Г

    5.Процентът на всички фенове, спрямо капацитета на стадиона.*/

           int stadiumCapacity = int.Parse(Console.ReadLine());
           int fensNumber = int.Parse(Console.ReadLine());
           string sector = "";
            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < fensNumber; i++)
            {
                sector = Console.ReadLine();
                if (sector == "A")
                {
                    sectorA += 1;
                }
                else if (sector == "B") 
                {
                    sectorB += 1;
                }
                else if (sector == "V")
                {
                    sectorV += 1;
                }
                else if (sector == "G")
                {
                    sectorG += 1;
                }
            }
            sectorA = sectorA / fensNumber * 100;
            sectorB = sectorB / fensNumber * 100;
            sectorV = sectorV / fensNumber * 100;
            sectorG = sectorG / fensNumber * 100;
            double fensAccordingToStadium = (1.0 * fensNumber / stadiumCapacity) * 100;
            Console.WriteLine($"{sectorA:f2}%");
            Console.WriteLine($"{sectorB:f2}%");
            Console.WriteLine($"{sectorV:f2}%");
            Console.WriteLine($"{sectorG:f2}%");
            Console.WriteLine($"{fensAccordingToStadium:f2}%");
        }
    }
}













