//Write a program that generates and displays a random number between 2 numbers that the user inputs.

using System;

Random random = new Random();

Console.WriteLine("Enter a random range of numbers: ");
Console.WriteLine("1st Number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2nd Number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    int randomNumber = random.Next(number1, number2);

    Console.WriteLine($"The Random Number between {number1} and {number2} is = {randomNumber}");
    Console.ReadLine();
}
else if (number1 > number2)
{
    Console.WriteLine("Please enter the bigger number first. Press Enter to try again");
    Console.ReadLine();
}

                                                                      //This time with try and catch functions

using System;

Random random = new Random();

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
}
catch (FormatException)
{
    Console.WriteLine("Invalid Input. Please enter a valid integer. Press Enter to try again.");
    Console.ReadLine();
}
