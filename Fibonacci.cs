namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n, a = 0, b = 1, c, i;
            Console.Write("Enter the number of terms : ");
            n = Int32.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (i <= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.Write(c + "  ");
            }
            Console.ReadKey();
        }
    }
}


/*Write a Fibonacci exercise in C#.
The Fibonacci sequence is a series of numbers where a number is the sum of the two preceding numbers.
The simplest is the series 1, 1, 2, 3, 5, 8, etc.
This is a program that takes an integer and prints out the Fibonacci sequence leading up to that number.
For example, if the input is 8, your program should output 1, 1, 2, 3, 5.
If the input is 20, the output should be 1, 1, 2, 3, 5, 8, 13.
If the input is 1, the output should just be “1”.*/

using System;

namespace RandomTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Initialize variables for the first and second numbers in the sequence, and the sum
            int firstNumber = 1;
            int secondNumber = 1;
            int sum = 0;

            // Print the first two numbers in the sequence
            Console.Write(firstNumber + " " + secondNumber + " ");

            // Generate the Fibonacci sequence up to the entered number
            while (sum < number)
            {
                sum = firstNumber + secondNumber;

                // Update the values of the first and second numbers in the sequence
                firstNumber = secondNumber;
                secondNumber = sum;

                // Print the sum if it is less than the entered number
                if (sum < number)
                {
                    Console.Write(sum + " ");
                }

                //Print the current number in the sequence without a trailing space if it equals the entered number
                else
                {
                    Console.Write(sum);
                }
            }
            Console.ReadLine();
        }
    }
}
