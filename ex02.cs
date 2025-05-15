using System;

class Program
{
    static string[] menuItems = {
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

    static void Main()
    {
        int selectedIndex = 0;

        ConsoleKey key;

        do
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO MY PROGRAM\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("=> " + menuItems[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("   " + menuItems[i]);
                }
            }

            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow)
            {
                selectedIndex--;
                if (selectedIndex < 0)
                    selectedIndex = menuItems.Length - 1;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                selectedIndex++;
                if (selectedIndex >= menuItems.Length)
                    selectedIndex = 0;
            }

        } while (key != ConsoleKey.Enter);

        Console.Clear();
        Console.WriteLine($"You selected: {menuItems[selectedIndex]}");
    }
}
