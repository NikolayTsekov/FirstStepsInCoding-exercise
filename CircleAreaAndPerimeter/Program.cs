using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r, като форматирате изхода в следния вид:
             * "<calculated area>" "<calculated parameter>". Форматирайте изходните данни до втория знак след десетичната запетая.*/
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * (r * r);
            double perimeter = ((2 * Math.PI) * r);

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}













