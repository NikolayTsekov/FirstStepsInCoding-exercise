using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата таксата за една година
            int taxPerYear = int.Parse(Console.ReadLine());
            //2. Намирам цената за всяка част от екипировката
            double shoes = taxPerYear - taxPerYear * 0.4;
            Console.WriteLine("shoes = " + shoes);
            double outfit = shoes - shoes * 0.2;
            Console.WriteLine("outfit = " + outfit);
            double ball = outfit / 4;
            Console.WriteLine("ball = " + ball);
            double acc = ball / 5;
            Console.WriteLine("acc = " + acc);



            //3 Намирам общата сума: такса + кецове +екип + топка + аксесоари
            double sum = taxPerYear + shoes + outfit + ball + acc;
            //4 Отпечатвам резултата на конзолата
            Console.WriteLine(sum);
        }
    }
}
