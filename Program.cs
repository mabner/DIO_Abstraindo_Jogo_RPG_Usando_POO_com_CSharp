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

			Rifleman marco = new Rifleman("Marco Rossi", 27, "Major");
			Grenadiers tarma = new Grenadiers("Tarma Roving", 27, "Captain");

			// .ToString gets used by default when printing out the object
			System.Console.WriteLine(marco);
			System.Console.WriteLine(tarma);
			System.Console.WriteLine("---------------------------------");
			System.Console.WriteLine(marco.Attack());
			System.Console.WriteLine(tarma.Attack("fire"));

		}
	}
}