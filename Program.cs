using System;

class Program
{
    static void Main()
    {
        // Be om användarinmatning för start, stop och steg
        Console.Write("Ange startvärde: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Ange stopvärde: ");
        int stop = int.Parse(Console.ReadLine());

        Console.Write("Ange steg: ");
        int steg = int.Parse(Console.ReadLine());

        // Variabel för att hålla summan av alla tal
        int summa = 0;

        // For-loop som itererar från start till stop med angivet steg
        for (int i = start; i <= stop; i += steg)
        {
            Console.WriteLine(i);  // Skriver ut aktuellt tal
            summa += i;            // Lägger till aktuellt tal till summan
        }

        // Skriver ut den totala summan
        Console.WriteLine($"Summan av alla tal från {start} till {stop} med steg {steg} är: {summa}");
    }
}