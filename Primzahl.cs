//Schreibe ein Programm, das die Eingabe des Benutzers liest und überprüft, ob die eingegebene Zahl eine Primzahl ist.

while (true)
{
    Console.Write("\nEnter a number to check whether it's a prime number or not \n(or type 'exit' to quit): ");
    string input = Console.ReadLine();

    if (input == "exit")
    {
        break;
    }

    if (int.TryParse(input, out int number))
    {
        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid integer number or 'exit' to quit.");
    }
}

Console.WriteLine("\nGoodbye!");
