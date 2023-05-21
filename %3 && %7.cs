//Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.

while (true)
{
    Console.WriteLine("Enter a positive number to check whether if it's a multiple of 3 or 7: ");
    int x = Convert.ToInt32(Console.ReadLine());

    var y = (x % 3 == 0) || (x % 7 == 0);

    Console.WriteLine(y);
}
