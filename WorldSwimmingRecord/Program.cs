using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            // Четем входа от конзолата
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]
            double worldrecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine()); 
            double timePerMeter = double.Parse(Console.ReadLine());
            //2. Намирам за колко време Иван ще преплува разстоянието
            // раст. * времето, за което преплува 1м
            double recordByIvan = distance * timePerMeter;
            //3. Намирам колко пъти Иван ще се забави
            //разст. / 15
            double delay = distance / 15;
            //4. Добавям времето, за което се забавя
            //времето на Иван + закръглено нагоре (броя на забавянията)*12.5
            recordByIvan += Math.Floor(delay) * 12.5;
            //5. Проверявам дали Иван е подобрил рекорда
            //ако времето на Иван е по-малко от св. рекорд=		o	" Yes, he succeeded! The new world record is {времето на Иван} seconds."
            //ако не е: "No, he failed! He was {недостигащите секунди} seconds slower."
            if(recordByIvan<worldrecord) 
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldrecord-recordByIvan):f2} seconds slower.");
            }
        }
    }
}













