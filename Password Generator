using System;
using System.Security.Cryptography;
using System.Text;

public class Program
{
    private const string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
    private const string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string digitChars = "0123456789";
    private const string specialChars = "!@#$%^&*()-_=+{}[]|;:<>,.?/\\`~";
    private static Random random = new Random();

    private static char GetRandomChar(string characters)
    {
        return characters[random.Next(characters.Length)];
    }

    public static string GeneratePassword(int length, string characterSet)
    {
        string chosenCharacterSet = "";

        switch (characterSet)
        {
            case "lower":
                chosenCharacterSet += lowerCaseChars;
                break;
            case "upper":
                chosenCharacterSet += upperCaseChars;
                break;
            case "digit":
                chosenCharacterSet += digitChars;
                break;
            case "special":
                chosenCharacterSet += specialChars;
                break;
            case "all":
                chosenCharacterSet += lowerCaseChars + upperCaseChars + digitChars + specialChars;
                break;
        }

        var result = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            result.Append(GetRandomChar(chosenCharacterSet));
        }

        return result.ToString();
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEnter the desired password length (or type 'quit' or 'q' to exit):");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit" || input.ToLower() == "q")
            {
                break;
            }

            int passwordLength;
            if (!int.TryParse(input, out passwordLength))
            {
                Console.WriteLine("Invalid input. Please enter a numeric password length.");
                continue;
            }

            Console.WriteLine("\nEnter the desired character set (lower, upper, digit, special, or all):");
            var characterSet = Console.ReadLine();

            var password = GeneratePassword(passwordLength, characterSet);
            Console.WriteLine("Generated password: " + password);
        }
    }
}
