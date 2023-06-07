using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
           /*Курсът "Train the trainers" е към края си и финалното оценяване наближава. Вашата задача е да помогнете на журито което ще оценява презентациите, като напишете програма в която да изчислява средната оценка от представянето на всяка една презентация от даден студент, а накрая средният успех от всички тях.
От конзолата на първият ред се прочита броят на хората в журито n - цяло число в интервала [1…20]
След това на отделен ред се прочита името на презентацията - текст
За всяка една презентация на нов ред се четат n - на брой оценки - реално число в интервала [2.00…6.00]
След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
 "{името на презентацията} - {средна оценка}."
След получаване на команда "Finish" на конзолата се печата "Student's final assessment is {среден успех от всички презентации}." и програмата приключва.
Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.*/
           int n = int.Parse(Console.ReadLine());
           double counter = 0;
           double allScore = 0;

           while (true)
           {
                string presentationName = Console.ReadLine();
                double sumGrades = 0;
                if (presentationName == "Finish")
                {
                    double scoreSum = allScore / counter;
                    Console.WriteLine($"Student's final assessment is {scoreSum:f2}.");
                    break;

                }
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                    allScore += grade;
                    counter++;
                }
                double sumAfter = sumGrades / n;
                Console.WriteLine($"{presentationName} - {sumAfter:f2}.");

            }

        }
    }
}




























