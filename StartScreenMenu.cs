using System;
using SpaceGame;

/// <summary>
/// Summary description for Class1
/// </summary>
public class StartScreenMenu
{
	public static void Choices()
	{
        Console.WriteLine("Welcome to the Space Game!");
        Console.WriteLine("Enter your name!");

		string name = Console.ReadLine();

		Console.WriteLine("Enter your race! From the following selection");
        Console.WriteLine("(1) Humans , (2) Alien");
        int raceSelection = InitialInputValue();
        Console.WriteLine($"Your choice is {raceSelection}");


		Character character = new Character(name, raceSelection);
		

	}
    static int InitialInputValue()
    {
        Console.Write("\nPlease enter your choice: ");
        bool isValid = false;
        string fromUser = Console.ReadLine();
        int output = 0;
        while (isValid == false)
        {
            checked
            {
                if (!int.TryParse(fromUser, out output))
                {
                    Console.WriteLine("{0} is not a valid input", fromUser);
                    Console.WriteLine("Please enter a valid value");
                    fromUser = Console.ReadLine();
                    continue;
                }
                if (output > 2)
                {
                    Console.WriteLine("{0} is not a right choice", fromUser);
                    Console.WriteLine("Please enter a valid value");
                    fromUser = Console.ReadLine();
                    continue;
                }
                if (output == 0)
                {
                    Console.WriteLine("{0} is not a right choice", fromUser);
                    Console.WriteLine("Please enter a valid value");
                    fromUser = Console.ReadLine();
                    continue;
                }
                else
                {
                    isValid = true;
                }
            }
        }
        return output;
    }
}
