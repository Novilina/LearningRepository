using System;
using Microsoft.VisualBasic;

namespace Count
{
	class EnteringInteger
	{
		static void Main()
		{
			Console.Title = "Узнай свой возраст, если забыл";
			string res,
			       txt;
			int year = 2018,
			    age,
			    born;
			Console.WriteLine("В каком году Вы родились?");
			res = Console.ReadLine();

			born = Int32.Parse(res);
			age = year - born;
			txt = "Тогда Вам " + age + " лет";
			Console.WriteLine(txt);
			Console.ReadLine();
		}
	}
}
