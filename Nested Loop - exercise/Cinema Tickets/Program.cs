using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от продадените билети: студентски(student), стандартен(standard) и детски(kid), за всички прожекции. Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
Вход
Входът е поредица от цели числа и текст:
	•	На първия ред до получаване на командата "Finish" - име на филма – текст
	•	На втори ред – свободните места в салона за всяка прожекция – цяло число [1 … 100]
	•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
		o	Типа на закупения билет - текст ("student", "standard", "kid")
Изход
На конзолата трябва да се печатат следните редове:
	•	След всеки филм да се отпечата, колко процента от кино залата е пълна
"{името на филма} - {процент запълненост на залата}% full."
	•	При получаване на командата "Finish" да се отпечатат четири реда:
		o	"Total tickets: {общият брой закупени билети за всички филми}"
		o	"{процент на студентските билети}% student tickets."
		o	"{процент на стандартните билети}% standard tickets."
"{процент на детските билети}% kids tickets."*/
			int studentTickets = 0;
			int standardTickets = 0;
			int kidTickets = 0;

			string movieName = Console.ReadLine();
			while (movieName != "Finish") 
			{
				int free = int.Parse(Console.ReadLine());
				string type = Console.ReadLine();
				int tickets = 0;
				while (type != "End")
				{
					if (type == "student")
						studentTickets++;
					else if (type == "standard")
						standardTickets++;
					else
						kidTickets++;

					tickets++;
					if (tickets == free)
						break;

					type = Console.ReadLine();

				}
				Console.WriteLine($"{movieName} - {(double)tickets*100/free:f2}% full.");
				movieName = Console.ReadLine();
			}
			int totalTickets = studentTickets + standardTickets + kidTickets;
			Console.WriteLine($"Total tickets: {totalTickets}");

			Console.WriteLine($"{(double)studentTickets*100/totalTickets:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTickets*100/totalTickets:f2}% standard tickets.");
			Console.WriteLine($"{(double)kidTickets*100/totalTickets:f2}% kids tickets.");
		}
    }
}



























