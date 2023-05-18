using System;


namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Студент трябва да отиде на изпит в определен час (например в 9:30 часа). Той идва в изпитната зала в даден час на пристигане (например 9:40). Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това. Ако е пристигнал по-рано повече от 30 минути, той е подранил. Ако е дошъл след часа на изпита, той е закъснял. Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.
Вход
От конзолата се четат 4 цели числа (по едно на ред), въведени от потребителя:
	•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
	•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
	•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
	•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
Изход
На първият ред отпечатайте:
	•	“Late”, ако студентът пристига по-късно от часа на изпита.
	•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
	•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
	•	
“mm minutes after the start” за закъснение под час.
	•	“hh:mm hours after the start” за закъснение от 1 час или повече. Минутите винаги печатайте с 2 цифри, например “1:03”.*/
			int examHour = int.Parse(Console.ReadLine());
			int examMinute = int.Parse(Console.ReadLine());

			examMinute = examMinute + examHour * 60;

			int arrivalHour = int.Parse(Console.ReadLine());
			int arrivalMinute = int.Parse(Console.ReadLine());

			arrivalMinute = arrivalMinute + arrivalHour * 60;

			int difference = examMinute - arrivalMinute;

			if (difference < 0)
			{
				Console.WriteLine("Late");
				if (difference > -60) 
				{
					Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
				}
				else
				{
					Console.WriteLine($"{Math.Abs(difference / 60)} : {Math.Abs(difference % 60):D2} hours after the start");
				}
			}
			else if (difference >= 0 && difference <= 30)
			{
				Console.WriteLine("On time");
				if (difference > 0) 
				{
					Console.WriteLine($"{difference} minutes before the start");
				}
			}
			else
			{
				Console.WriteLine("Early");
				if (difference < 60) 
				{
					Console.WriteLine($"{difference} minutes before the start");
				}
				else
				{
					Console.WriteLine($"{difference/60} : {difference%60:D2} hours before the start");
				}
			}

        }
    }
}




































