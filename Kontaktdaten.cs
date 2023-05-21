//Ziel: Man kann mit dieser App Kotaktdaten zeigen lassen.

namespace PersonApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo! Herzlich Wilkommen in meiner Kontakte-App. Dein Name: ");
            string[] Name = { Console.ReadLine() };

            Console.WriteLine("Dein Alter: ");
            string[] Geburtsdatum = { Console.ReadLine() };

            Console.WriteLine("Deine Whatsapp Nummer: ");
            string[] Whatsapp = { Console.ReadLine() };

            Console.WriteLine("Deine E-Mail-Adresse: ");
            string[] Email = { Console.ReadLine() };

            Console.WriteLine("Perfekt! Und jetzt das Passwort für deine Email bitte:  ");
            Console.WriteLine("\nNah just kidding :D \nDrücke bitte noch mal ENTER um die Kontaktdaten zu überprüfen.");
            Console.ReadLine();


            foreach (string i in Name)
            {
                Console.WriteLine($"Name: {i} ");
            }

            foreach (string i in Geburtsdatum)
            {
                Console.WriteLine($"Geburtsdatum: {i} ");
            }

            foreach (string i in Whatsapp)
            {
                Console.WriteLine($"Whatsapp: {i}");
            }
            foreach (string i in Email)
            {
                Console.WriteLine($"E-Mail: {i}");
            }


        }
    }
}

