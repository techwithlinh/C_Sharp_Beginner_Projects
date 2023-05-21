//Schreibe ein Programm, das die Eingabe des Benutzers liest und dann eine Schleife verwendet,
//um alle Zahlen von 1 bis zur eingegebenen Zahl auszugeben.

bool fertig = false;

while (!fertig) 
{
    try {
        Console.WriteLine("Geben Sie eine zufällige Nummer ein: ");
        ulong number = ulong.Parse(Console.ReadLine());

        for (ulong i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }


        Console.WriteLine("\n\n'Exit' oder 'Enter'? ");
        string input = Console.ReadLine();
        if (input.ToLower() == "exit") { fertig = true; break; }
    }

    catch ( FormatException )
    {
        Console.WriteLine("Falsche Eingabe. Bitte versuchen Sie es nochmal! ");
        Console.ReadLine();
    } 
}

