using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която да пресмята статистика на оценки от изпит. В началото програмата получава броят на студентите явили се на изпита и за всеки студент неговата оценка. На края програмата трябва да изпечата процента на студенти с оценка между 2.00 и 2.99, между 3.00 и 3.99, между 4.00 и 4.99, 5.00 или повече. Също така и средният успех на изпита.
Вход
От конзолата се четат поредица от числа, всяко на отделен ред:
	•	На първия ред – броя на студентите явили се на изпит – цяло число в интервала [1...1000]
	•	За всеки един студент на отделен ред – оценката от изпита – реално число в интервала [2.00...6.00]
Изход
Да се отпечатат на конзолата 5 реда, които съдържат следната информация:
	Ред 1 -	"Top students: {процент студенти с успех 5.00 или повече}%"
	Ред 2 -	"Between 4.00 and 4.99: {между 4.00 и 4.99 включително}%"
	Ред 3 -	"Between 3.00 and 3.99: {между 3.00 и 3.99 включително}%"
	Ред 4 -	"Fail: {по-малко от 3.00}%"
	Ред 5 -	"Average: {среден успех}"
Всички числа трябва да са форматирани до вторият знак след десетичната запетая.*/
            int studentsCount = int.Parse(Console.ReadLine());
            double examGrade = 0;
            double numberOfFailedStudents = 0;
            double numberOfAverageStudents = 0;
            double numberOfGoodStudents = 0;
            double numberOfExellentStudents = 0;
            double average = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                examGrade = double.Parse(Console.ReadLine());
                if (examGrade < 3)
                {
                    numberOfFailedStudents++;
                }
                if (examGrade >= 3 && examGrade <= 3.99)
                {
                    numberOfAverageStudents++;
                }
                if (examGrade >= 4 && examGrade <= 4.99)
                {
                    numberOfGoodStudents++;
                }
                if (examGrade >= 5)
                {
                    numberOfExellentStudents++;
                }
                average += examGrade;
            }
            Console.WriteLine($"Top students: {(numberOfExellentStudents / studentsCount * 100.0):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(numberOfGoodStudents / studentsCount * 100.0):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(numberOfAverageStudents / studentsCount * 100.0):f2}%");
            Console.WriteLine($"Fail: {(numberOfFailedStudents / studentsCount * 100.0):f2}%");
            Console.WriteLine($"Average: {average / studentsCount:f2}");
        }
    }
}












