using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Да се напише програма, която генерира трицифрени PIN кодове, като цифрите на всеки PIN код са в определен интервал. За да бъде валиден един PIN код той трябва да отговаря на следните условия:
	•	Първата и третата цифра трябва да бъдат четни.
	•	Втората цифра трябва да бъде просто число в диапазона [2...7].
Вход
От конзолата се четат 3 реда:
	•	Горната граница на първото число - цяло число в диапазона [1...9]
	•	Горната граница на второто число - цяло число в диапазона [1...9]
	•	Горната граница на третото число - цяло число в диапазона [1...9]
Изход
Да се отпечатат на конзолата всички валидни трицифрени PIN кодове, чиито цифри отговарят на съответните интервали.*/
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int outputNumber;

            for (int a = 1; a <= firstNum; a++)
            {
                for (int b = 1; b <= secondNum; b++)
                {
                    for (int c = 1; c <= thirdNum; c++)
                    {
                        if (a%2==0)
                        {
                            if (c%2==0)
                            {
                                if ((b == 2) || (b == 3) || (b == 5) || (b == 7))
                                {
                                    outputNumber = 100 * a + 10 * b + c;
                                    Console.WriteLine(outputNumber);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}

























