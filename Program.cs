using code.src.Entities;

namespace code
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Major Marco Rossi
			Captain Tarma Roving
			Sergeant Second Class Eri Kasamoto
			Master Sergeant Fiolina "Fio" Germi
			Nadia Cassel
			Trevor Spacey
			Cadet Walter Ryan
			Cadet Tyra Elson
			Colonel Ralf Jones
			Second Lieutenant Clark Stil
			Leona Heidern			
			*/

			Hero marco = new Hero("Marco Rossi", 27, "Major");
			Hero tarma = new Hero("Tarma Roving", 27, "Captain");

			System.Console.WriteLine(marco.ToString());
			System.Console.WriteLine(tarma.ToString());

		}
	}
}