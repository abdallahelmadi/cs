using System;

class Program
{
	// the main function
	static void Main()
	{
		// the menu options decalre as array of strings
		string[] menuOfOptions = {
			"Addition",
			"Subtraction",
			"Multiplication",
			"Division",
			"Power",
			"Combination",
			"Permutation",
			"Factorial",
			"Written Number",
			"Exit"
		};

		// the option seleted in the menu by user
		int optionSelected = 0;
		
		// the variable hold the key pressed
		ConsoleKey key;
		
		while (true)
		{
			// clear terminal & print welcome
			Console.Clear();
			Console.WriteLine("WELCOME TO MY PROGRAM");
			Console.WriteLine("=====================");

			// printf the list
			int index = 0;
			while (menuOfOptions.Length > index)
			{
				if (optionSelected == index)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("=> " + menuOfOptions[index]);
					Console.ResetColor();
				}
				else
					Console.WriteLine("   " + menuOfOptions[index]);
				index++;
			}

			// get the key pressed
			key = Console.ReadKey(true).Key;

			// set value of option select if user press UP/DOWN botton
			if (key == ConsoleKey.UpArrow)
			{
				optionSelected--;
				if (optionSelected == -1)
					optionSelected = 9;
			}
			else if (key == ConsoleKey.DownArrow)
			{
				optionSelected++;
				if (optionSelected == 10)
					optionSelected = 0;
			}
			else if (key == ConsoleKey.Enter) 
			{
				// select correct function depand from the select option
				if (optionSelected == 0)
					additionFunction();
				else if (optionSelected == 1)
					subtractionFunction();
				else if (optionSelected == 2)
					multiplicationFunction();
				else if (optionSelected == 3)
					divisionFunction();
				else if (optionSelected == 4)
					powerFunction();
				else if (optionSelected == 5)
					combinationFunction();
				else if (optionSelected == 6)
					permutationFunction();
				else if (optionSelected == 7)
					factorialFunction();
				else if (optionSelected == 8)
					writtenNumberFunction();
				else if (optionSelected == 9)
					exitFunction();

				// break the while after user select option
				break ;
			}
		}
	}

	static void additionFunction()
	{
		Console.Write("Please enter first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Please enter second number: ");
		int num2 = int.Parse(Console.ReadLine());
		Console.WriteLine($"Result is {num1 + num2}");
	}

	static void subtractionFunction()
	{
		Console.Write("Please enter first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Please enter second number: ");
		int num2 = int.Parse(Console.ReadLine());
		Console.WriteLine($"Result is {num1 - num2}");
	}

	static void multiplicationFunction()
	{
		Console.Write("Please enter first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Please enter second number: ");
		int num2 = int.Parse(Console.ReadLine());
		Console.WriteLine($"Result is {num1 * num2}");
	}

	static void divisionFunction()
	{
		Console.Write("Please enter first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Please enter second number: ");
		int num2 = int.Parse(Console.ReadLine());
		Console.WriteLine($"Result is {num1 / num2}");
	}

	static void powerFunction()
	{
		Console.Write("Please enter first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Please enter second number: ");
		int num2 = int.Parse(Console.ReadLine());

		// calcule power result
		int result = 1;
		int index = 0;
		while (index < num2)
		{
			result = result * num1; 
			index++;
		}

		Console.WriteLine($"Result is {result}");
	}

	static void combinationFunction()
	{
		Console.Write("Please enter first number: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Please enter second number: ");
		int r = int.Parse(Console.ReadLine());

		// calcule combination result
		int result = 1;
		int index = 1;
		if (r > n - r)
			r = n - r;
		while (index <= r)
		{
			result = result * (n - r + index) / index;
			index++;
		}

		Console.WriteLine($"Reslut is {result}");
	}

	static void permutationFunction()
	{
		Console.Write("Please enter first number: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Please enter second number: ");
		int r = int.Parse(Console.ReadLine());

		// calcule permutation result
		int result = 1;
		int index = 0;
		while (index < r)
		{
			result = result * (n - index);
			index++;
		}

		Console.WriteLine($"Result is {result}");
	}

	static void factorialFunction()
	{
		Console.Write("Please enter a number: ");
		int n = int.Parse(Console.ReadLine());

		// calcule factorial result
		int result = 1;
		int index = 2;
		while (index <= n)
		{
			result = result * index;
			index++;
		}

		Console.WriteLine($"Result is {result}");
	}

	static void writtenNumberFunction()
	{
		Console.Write("Please enter a number: ");
		int n = int.Parse(Console.ReadLine());

		// logic
		string[] unitsMap = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                          "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    string[] tensMap = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

    string words = "";

    if (num >= 1_000_000_000)
    {
        words += numberToWordsFunction(num / 1_000_000_000) + " billion ";
        num %= 1_000_000_000;
    }

    if (num >= 1_000_000)
    {
        words += numberToWordsFunction(num / 1_000_000) + " million ";
        num %= 1_000_000;
    }

    if (num >= 1_000)
    {
        words += numberToWordsFunction(num / 1_000) + " thousand ";
        num %= 1_000;
    }

    if (num >= 100)
    {
        words += numberToWordsFunction(num / 100) + " hundred ";
        num %= 100;
    }

    if (num > 0)
    {
        if (words != "")
            words += "";

        if (num < 20)
            words += unitsMap[num];
        else
        {
            words += tensMap[num / 10];
            if ((num % 10) > 0)
                words += " " + unitsMap[num % 10];
        }
    }

		Console.WriteLine("Result is " + words.Trim());
	}

	static void exitFunction()
	{
		Console.WriteLine("Exit");
	}

}
