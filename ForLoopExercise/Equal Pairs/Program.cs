using System;
using System.Security.Cryptography;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Дадени са 2*n-на брой числа. Първото и второто формират двойка, третото и четвъртото също и т.н. Всяка двойка има стойност – сумата от съставящите я числа. Напишете програма, която проверява дали всички двойки имат еднаква стойност или печата максималната разлика между две последователни двойки. Ако всички двойки имат еднаква стойност, отпечатайте "Yes, value={Value}" + стойността. В противен случай отпечатайте "No, maxdiff={Difference}" + максималната разлика. */
            int n = int.Parse(Console.ReadLine());
            int sumNewPair = 0;
            int sumOldPair = 0;
            int maxDiff = 1;
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                int f = int.Parse(Console.ReadLine());
                int g = int.Parse(Console.ReadLine());
                sumNewPair = f + g;
                if (sumNewPair == sumOldPair)
                {
                    counter += 1;
                }
                if (maxDiff < Math.Abs(sumOldPair - sumNewPair) && i >= 2)
                    maxDiff = Math.Abs(sumOldPair - sumNewPair);
                if (sumNewPair != sumOldPair)
                {
                    sumOldPair = sumNewPair;
                }
            }
            if (counter == n - 1)
                Console.WriteLine("Yes, value={0}", sumNewPair);
            else
                Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}













