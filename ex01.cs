using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("WELCOME TO MY PROGRAM");
        Console.WriteLine("=====================\n");
        Console.WriteLine("Please choose one of the option below\n");
        Console.WriteLine("1. Developer's name's first three letter");
        Console.WriteLine("2. Addition");
        Console.WriteLine("3. Absolute value of the subtraction");
        Console.WriteLine("4. Multiplication");
        Console.WriteLine("5. Exit");

        Console.Write("\nWrite your option please: ");
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            sayMyName();
        }
        else if (input == 2)
        {
            totalOfNumbers();
        }
        else if (input == 3)
        {
            differenceOfNumbers();
        }
        else if (input == 4)
        {
            multiplicationOfNumbers();
        }
        else if (input == 5)
        {
            ;
        }
        else
        {
            Console.WriteLine("\nYou entered something other than a menu number");
        }
        Console.WriteLine("\nTHANK YOU and GOOD BYE");
    }

    static void sayMyName()
    {
        Console.WriteLine("\nMy name's first three letter\n");
        Console.WriteLine("M    M  AAAA  RRRR");
        Console.WriteLine("MM  MM A    A R   R");
        Console.WriteLine("M MM M AAAAAA RRR");
        Console.WriteLine("M    M A    A R  R");
        Console.WriteLine("M    M A    A R   R");
    }

    static void totalOfNumbers()
    {
        Console.Write("\nPlease enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nTotal of {num1} and {num2} is {num1 + num2}");
    }

    static void differenceOfNumbers()
    {
        Console.Write("\nPlease enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int result = 0;
        if (num1 > num2)
        {
            result = num1 - num2;
        }
        else
        {
            result = num2 - num1;
        }
        Console.WriteLine($"\nDifference of {num1} and {num2} is {result}");
    }

    static void multiplicationOfNumbers()
    {
        Console.Write("\nPlease enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nMultiplication of {num1} and {num2} is {num1 * num2}");
    }
}
