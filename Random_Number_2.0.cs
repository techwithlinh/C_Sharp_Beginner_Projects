//Write a program that generates and displays a random number between 2 numbers that the user inputs
//with a loop to allow the user to use the program multiple times

using System;

Random random = new Random();
bool finished = false;

while (!finished)
{
    try
    {
        Console.WriteLine("Enter a random range of numbers: ");
        Console.WriteLine("1st Number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2nd Number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            int randomNumber = random.Next(number2, number1);

            Console.WriteLine($"The Random Number between {number2} and {number1} is = {randomNumber}");
            Console.ReadLine();
        }
        else if (number1 < number2)
        {
            int randomNumber = random.Next(number1, number2);

            Console.WriteLine($"The Random Number between {number1} and {number2} is = {randomNumber}");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid Input. Press Enter to try again");
            Console.ReadLine();
        }

        Console.WriteLine("Enter 'exit' to quit or press any key to use the program again");
        string input = Console.ReadLine();
        if (input.ToLower() == "exit")
        {
            finished = true;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Input. Please enter a valid integer. Press Enter to try again.");
        Console.ReadLine();
    }
}

