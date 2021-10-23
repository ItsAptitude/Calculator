using System;
public class Program
{
	public static void Main()
	{
		Console.Title = "Aptitude's Calculator";

		Console.WriteLine("Type Number 1");
		string tal1 = Console.ReadLine(); // läs tal 1

		Console.WriteLine("Type Operator (+, -, *, /)");
		string op = Console.ReadLine(); // läs operator

		Console.WriteLine("Type Number 2");
		string tal2 = Console.ReadLine(); // läs tal 2

		float nytal1 = float.Parse(tal1); // gör tal 1 till float value eftersom vi vill kunna ha decimaler
		float nytal2 = float.Parse(tal2); // gör tal 2 till float value eftersom vi vill kunna ha decimaler

		if (op == "+") // om operator är +
		{
			Console.WriteLine(tal1 + " + " + tal2 + " = " + (nytal1 + nytal2));
		}
		if (op == "-") // om operator är -
		{
			Console.WriteLine(tal1 + " - " + tal2 + " = " + (nytal1 - nytal2));
		}

		if (op == "/") // om operator är /
		{
			if (!(nytal2 == 0) && (!(nytal1 == 0))) // om tal 1 eller tal 2 är 0, så visar den fel meddelande
			{
				Console.WriteLine(tal1 + " / " + tal2 + " = " + (nytal1 / nytal2)); // om tal 1 eller tal 2 inte är 0
			}
			else // om tal 1 eller 2 är 0
			{
				Console.WriteLine("You cannot divide with 0!\n");
				Main();
			}
		}
		if (op == "*") // om operator är *
		{
			Console.WriteLine(tal1 + " * " + tal2 + " = " + (nytal1 * nytal2));
		}

		Console.WriteLine(""); // tom rad
		Main(); // kör om Program.Main, vilket gör om hela koden från början
	}
}