﻿using code.src.Entities;

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

			Marco hero = new Marco("Marco Rossi", 27, "Major");

			System.Console.WriteLine(hero.ToString());

		}
	}
}