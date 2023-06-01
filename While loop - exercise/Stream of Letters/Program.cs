using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която прочита скрито съобщение в поредица от символи. Те се получават по един на ред до получаване на командата "End". Думите се образуват от буквите в реда на четенето им. Символите, които не са латински букви трябва да бъдат игнорирани. Думите скрити в потока са разделени от тайна команда от три букви – "c", "o" и "n". При първото получаване на една от тези букви, тя се маркира като срещната, но не се запазва в думата. При всяко следващо нейно срещане се записва нормално в думата. След като са налични и трите символа от командата, се печата думата и интервал " ". Започва се нова дума, която по същия начин чака тайната команда, за да бъде отпечатана.
 Вход
 От конзолата се чете поредица от редове с един символ на всеки до получаване на командата "End".
 Изход
 На конзолата се печата на един ред всяка дума след тайната команда, следвана от интервал.*/
            string expression, result = "";
            bool isItCCommand = false, isItOCommand = false, isItNCommand = false;

            while (true)
            {

                expression = Console.ReadLine();

                if (isItCCommand == true && isItNCommand == true && isItOCommand == true)
                {
                    Console.Write(result + " ");
                    result = "";
                    isItCCommand = false;
                    isItNCommand = false;
                    isItOCommand = false;
                }

                if (expression.Equals("End"))
                {
                    break;
                }

                char letter = char.Parse(expression);

                if (((int)letter >= 65 && (int)letter <= 90) || ((int)letter >= 97 && (int)letter <= 122))
                {

                    if (letter == 'c' && isItCCommand == false)
                    {
                        isItCCommand = true;
                        continue;
                    }
                    else if (letter == 'c' && isItCCommand == true)
                    {
                        result = result + "" + letter;
                        continue;
                    }

                    if (letter == 'o' && isItOCommand == false)
                    {
                        isItOCommand = true;
                        continue;
                    }
                    else if (letter == 'o' && isItOCommand == true)
                    {
                        result = result + "" + letter;
                        continue;
                    }

                    if (letter == 'n' && isItNCommand == false)
                    {
                        isItNCommand = true;
                        continue;
                    }
                    else if (letter == 'n' && isItNCommand == true)
                    {
                        result = result + "" + letter;
                        continue;
                    }

                    result = result + "" + letter;

                }
                else
                {
                    continue;
                }
            }


        }
    }
}































