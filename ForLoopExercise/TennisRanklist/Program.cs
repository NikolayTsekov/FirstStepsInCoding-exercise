using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Григор Димитров е тенисист, чиято следваща цел е изкачването в световната ранглиста по тенис за мъже. 
През годината Гришо участва в определен брой турнири, като за всеки турнир получава точки, които зависят от позицията, на която е завършил в турнира. Има три варианта за завършване на турнир:
	▪	W - ако е победител получава 2000 точки
	▪	F - ако е финалист получава 1200 точки
	▪	SF - ако е полуфиналист получава 720 точки
Напишете програма, която изчислява колко ще са точките на Григор след изиграване на всички турнири, като знаете с колко точки стартира сезона. Също изчислете колко точки средно печели от всички изиграни турнири и колко процента от турнирите е спечелил. 
Вход
От конзолата първо се четат два реда:
	•	Брой турнири, в които е участвал – цяло число в интервала [1…20] 
	•	Начален брой точки в ранглистата - цяло число в интервала [1...4000]
За всеки турнир се прочита отделен ред:
	•	Достигнат етап от турнира – текст – "W", "F" или "SF"
Изход
Отпечатват се три реда в следния формат:
	•	"Final points: {брой точки след изиграните турнири}"
	•	"Average points: {средно колко точки печели за турнир}"
	•	"{процент спечелени турнири}%" 
			Средните точки да бъдат закръглени към най-близкото цяло число надолу, а процентът да се форматира до втората цифра след десетичния знак.*/
			int tournamentNumber = int.Parse(Console.ReadLine());
			int startingPoints = int.Parse(Console.ReadLine());

			int finalPoints = startingPoints;
			int wonCount = 0;

			for (int i = 1; i <= tournamentNumber; i++)
			{
				string placement = Console.ReadLine();
				if (placement == "W")
				{
					finalPoints += 2000;
					wonCount++;
				}
				else if (placement == "F")
				{
					finalPoints += 1200;
				}
				else if (placement == "SF") 
				{
					finalPoints += 720;
				}
			}
			
			Console.WriteLine($"Final points: {finalPoints}");
			finalPoints = finalPoints - startingPoints;
			double averagePoints = finalPoints / tournamentNumber;
			double averageWins = (1.0 * wonCount / tournamentNumber) * 100;
			Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
			Console.WriteLine($"{averageWins:f2}%");
        }
    }
}







