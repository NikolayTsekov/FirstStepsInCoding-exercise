using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение "Enough" от лектора си. При всяка решена задача той получава оценка. Програмата трябва да приключи прочитането на данни при команда "Enough" или ако Марин получи определения брой незадоволителни оценки.Незадоволителна е всяка оценка, която е по-малка или равна на 4.
Вход
	•	На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
	•	След това многократно се четат по два реда:
		o	Име на задача - текст (низ)
	o	Оценка - цяло число в интервала [2…6]
Изход
	•	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда: 
	o	"Average score: {средна оценка}"
	o	"Number of problems: {броя на всички задачи}"
		o	"Last problem: {името на последната задача}"
	•	Ако получи определеният брой незадоволителни оценки:
	o	"You need a break, {брой незадоволителни оценки} poor grades."
Средната оценка да бъде форматирана до втория знак след десетичната запетая.*/
			int	failedThreshold = int.Parse(Console.ReadLine());
			int failedTimes = 0;
			int solvedProblmesCount = 0;
			double gradesSum = 0;
			string lastProblem = "";
			bool isFailed = true;

			while (failedTimes < failedThreshold) 
			{
				string problemName = Console.ReadLine();
				if ("Enough" ==  problemName) 
				{
					isFailed = false;
					break;
				}
				int grade = int.Parse(Console.ReadLine());
				if (grade <= 4)
				{
					failedTimes++;
				}
				gradesSum += grade;
				solvedProblmesCount++;
				lastProblem = problemName;

			}
			if (isFailed) 
			{
				Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
			}
			else
			{
				Console.WriteLine($"Average score: {gradesSum / solvedProblmesCount:f2}");
				Console.WriteLine($"Number of problems: {solvedProblmesCount}");
				Console.WriteLine($"Last problem: {lastProblem}");
			}
        }
    }
}























