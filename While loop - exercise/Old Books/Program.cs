using System;

namespace FirstStepsInCoding_22_04_2023
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Ани отива до родния си град след много дълъг период извън страната. Прибирайки се вкъщи тя вижда старата библиотека на баба си и си спомня за любимата си книга. Помогнете на Ани, като напишете програма в която тя въвежда търсената от нея книга(текст). Докато Ани не намери любимата си книга или не провери всички в библиотеката, програмата трябва да чете всеки път на нов ред името на всяка следваща книга (текст). Книгите в библиотеката са свършили щом получите текст "No More Books".
	•	Ако не открие търсената книгата да се отпечата на два реда: 
	o	"The book you search is not here!"
	o	"You checked {брой} books."
	•	Ако открие книгата си се отпечатва един ред:
		o	"You checked {брой} books and found it."  */
            string book = Console.ReadLine();

            int counter = 0;
            bool isBookFound = false;
            string nextBookName = Console.ReadLine();
            while (nextBookName != "No More Books")
            {
                if (nextBookName == book)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}






















