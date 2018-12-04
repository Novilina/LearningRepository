using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class InputConsoleDemo
	{
		static void Main()
		{
			string name;
			Console.Title = "Давайте познакомимся...";
			Console.Write("Пожалуйста, представьтесь");
			name = Console.ReadLine();
			string txt = "Очень приятно, " + name + "!";
			Console.Title = "Знакомство прошло успешно. Поздравляем!";
			Console.WriteLine(txt);
			Console.ReadLine();
		}
	}
}
