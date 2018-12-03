using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
	        int rightAnswersCount = 0;
	        var random = new Random();
	        do
	        {
		        Console.ForegroundColor = ConsoleColor.Gray;
		        int guessedNumber = random.Next(2);
				Console.WriteLine("Угадайте число: 1 или 2");
		        int selectedNumber = Convert.ToInt32(Console.ReadLine());
		        if (guessedNumber == selectedNumber)
		        {
			        Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Верно! Вы угадали.");
		        }
		        else
		        {
			        Console.ForegroundColor = ConsoleColor.Red;
			        Console.WriteLine("К сожалению, Вы проиграли. :(");
		        }


	        } while (true);

        }
    }
}
