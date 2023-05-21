class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 789, 123, 456, 987, 321, 654 };
 
        // Zeige das unsortierte Array
        Console.WriteLine("Unsortiertes Array: ");
        foreach (int abc in array)
        {
            Console.Write(abc + " ");
        }
 
        // Durchlaufe von 0 bis Länge des Arrays
        for (int a = 0; a < array.Length - 1; a++)
            // Durchlaufe von a+1 bis Länge des Arrays
            for (int b = a + 1; b < array.Length; b++)
                // Vergleiche Array-Element mit allen nachfolgenden Elementen
                if (array[a] > array[b])
                {
                    int c = array[a];
                    array[a] = array[b];
                    array[b] = c;
                }
 
        Console.WriteLine("\nSortiertes Array: ");
        // Zeige alle Elemente des Arrays
        foreach (int abc in array)
        {
            Console.Write(abc + " ");
        }
        Console.Read();
    }
}
