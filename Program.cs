using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nameList = new List<string>(); // Skapar en lista för att lagra namnen
        string input;
        int maxNames = 200; // Max antal namn som användaren kan mata in

        // Mata in namn tills användaren säger nej eller vi når maxantalet 200
        do
        {
            if (nameList.Count >= maxNames)
            {
                Console.WriteLine("Du har nått max antal inmatade namn (200).");
                break;
            }

            // Be användaren att mata in ett namn
            Console.Write("Mata in ett namn: ");
            input = Console.ReadLine();
            nameList.Add(input); // Lägg till namnet i listan

            // Fråga om användaren vill mata in ett till namn
            Console.Write("Vill du mata in ett till namn? (ja/nej): ");
            input = Console.ReadLine().ToLower();

        } while (input == "ja");

        // Skapa en dictionary för att hålla reda på antal förekomster av varje namn
        Dictionary<string, int> nameCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        // Loopa igenom nameList och räkna hur många gånger varje namn förekommer
        foreach (string name in nameList)
        {
            if (nameCount.ContainsKey(name))
            {
                nameCount[name]++; // Öka räknaren för detta namn
            }
            else
            {
                nameCount[name] = 1; // Lägg till namnet med ett värde av 1
            }
        }

        // Skriver ut hur många gånger varje namn förekommer
        Console.WriteLine("\nNamnförekomster:");
        foreach (var entry in nameCount)
        {
            Console.WriteLine($"{entry.Key} förekommer {entry.Value} gång(er).");
        }
    }
}