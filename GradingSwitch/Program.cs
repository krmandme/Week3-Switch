using System;

namespace GradingSwitch
{
	class Program
	{
		static void Main(string[] args)
		{
			//proge küsib, mis hinde kasutaja sai
			//kui kasutaja sai "A", konsool kuvab suurepärane
			//"B", konsool kuvab "Väga hea!"
			//"C", Konsool kuvab "Hea!";
			//"D", konsool kuvab "Rahuldav!";
			//"E", konsool kuvab "Kasin";
			//"F", konsool kuvab "Puudulik",
			//kui sisetatakse midagi muud, konsool kuvab "Vale väärtus!"

			//kasutame SWITCH
			Console.WriteLine("Sisesta oma hinne:");
			char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

			switch (userResult)
			{
				case 'A': 
					Console.WriteLine("Suurepärane!");
					break;
				case 'B':
					Console.WriteLine("Väga hea!");
					break;
				case 'C':
					Console.WriteLine("Hea!");
					break;
				case 'D':
					Console.WriteLine("Rahuldav!");
					break;
				case 'E':
					Console.WriteLine("Kssin!");
					break;
				case 'F':
					Console.WriteLine("Puudulik!");
					break;
				default:
					Console.WriteLine($"Vale väärtus!");
					break;
			}
			Console.WriteLine("Kena päeva!");
		}
	}
}
