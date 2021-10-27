using System;
using System.Collections.Generic;

public class Program
{
	public static List<string> Historik = new List<string>();
	public static string plus;
	public static string minus;
	public static string division;
	public static string multiply;

	public static void Main()
	{
		Console.WriteLine("Type Number 1");
		string tal1 = Console.ReadLine(); // läs tal 1

		Console.WriteLine("Type Operator (+, -, *, /)");
		string op = Console.ReadLine(); // läs operator

		Console.WriteLine("Type Nummer 2");
		string tal2 = Console.ReadLine(); // läs tal 2

		float nytal1 = float.Parse(tal1); // gör tal 1 till float value eftersom vi vill kunna ha decimaler
		float nytal2 = float.Parse(tal2); // gör tal 2 till float value eftersom vi vill kunna ha decimaler

		if (op == "+") // om operator är +
		{
			plus = tal1 + " + " + tal2 + " = " + (nytal1 + nytal2); // säger att stringen plus är nytal1 + nytal2
			Historik.Add(plus); // lägger till hela uträkningen i historik listen
		}
		if (op == "-") // om operator är -
		{
			minus = tal1 + " - " + tal2 + " = " + (nytal1 - nytal2); // säger att stringen minus är nytal1 - nytal2
			Historik.Add(minus); // lägger till hela uträkningen i historik listen
		}

		if (op == "/") // om operator är /
		{
			if (!(nytal2 == 0) && (!(nytal1 == 0))) // Kollar om nytal1 eller nytal 2 är 0
			{
				division = tal1 + " / " + tal2 + " = " + (nytal1 / nytal2); // säger att stringen division är nytal1 / nytal2
				Historik.Add(division); // lägger till hela uträkningen i historik listen
			}
			else // om tal 1 eller 2 är 0
			{
				Console.WriteLine("You cannot divide with 0!\n");
				Main();
			}
		}
		if (op == "*") // om operator är *
		{
			multiply = tal1 + " * " + tal2 + " = " + (nytal1 * nytal2); // säger att stringen multiply är nytal1 * nytal2
			Historik.Add(multiply); // lägger till hela uträkningen i historik listen
		}
		Console.WriteLine(""); // tom rad

		Console.WriteLine("History:");
		foreach (string Item in Historik) // för varje string i listan Historik så skriver vi ut den stringen i consolen
		{
			Console.WriteLine(Item);
		}
		Console.WriteLine(""); // tom rad
		Main(); // kör om Program.Main, vilket kör om hela koden från början
	}
}