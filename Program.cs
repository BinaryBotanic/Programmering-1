// Program som läser in två tal och beräknar summan, produkten och kvoten.
using System;

class Program
{
    static void Main()
    {
        // Variabel som kontrollerar om programmet ska köras igen
        string körIgen;

        // Använd en do-while-loop för att köra programmet flera gånger
        do
        {
            // Be användaren mata in två tal
            Console.Write("Mata in det första talet: ");
            double tal1 = Convert.ToDouble(Console.ReadLine()); // Läs in första talet som ett flyttal

            Console.Write("Mata in det andra talet: ");
            double tal2 = Convert.ToDouble(Console.ReadLine()); // Läs in andra talet som ett flyttal

            // Beräkna summan, produkten och kvoten av de två talen
            double summa = tal1 + tal2; // Beräknar summan av tal1 och tal2
            double produkt = tal1 * tal2; // Beräknar produkten av tal1 och tal2
            double divition = tal1 / tal2; // Beräknar kvoten av tal1 och tal2

            // Skriv ut resultaten
            Console.WriteLine("Summan av talen är: " + summa); //Ger svar för summa
            Console.WriteLine("Produkten av talen är: " + produkt); //Ger svar för produkten
            Console.WriteLine("Divition av talen är: " + divition); //Ger svar för divition

            // Fråga användaren om de vill köra programmet igen
            Console.WriteLine("Tryck på Enter om du vill köra en gång till, eller skriv 'n' och tryck Enter för att avsluta.");
            körIgen = Console.ReadLine();

        } while (körIgen == ""); // Kör om användaren trycker på Enter utan att skriva något

        // Meddelande om att programmet avslutas
        Console.WriteLine("Programmet avslutas.");
    }
}
