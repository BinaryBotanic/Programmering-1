using System;

namespace Kasta_Tärning__Uppgift_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en instans av Random-klassen för att generera slumptal
            Random random = new Random();
            string spelaIgen;

            // En do-while loop för att fortsätta spelet tills användaren vill avsluta
            do
            {
                // Frågar användaren om att ange tärningskast i formatet "3T6", "2T20", etc.
                Console.Write("Ange tärningskast (ex: 3T6, 2T20): ");
                string tarningInput = Console.ReadLine();

                // Anropar den nya överlagrade metoden KastaTärning som tar en sträng som inparameter
                int resultat = KastaTärning(tarningInput, random);

                // Skriver ut den totala summan av alla kast
                Console.WriteLine("Summan blir: Resultat " + resultat);

                // Frågar användaren om de vill kasta tärningen igen eller avsluta
                Console.WriteLine("Vill du kasta igen? (ja/nej): ");
                spelaIgen = Console.ReadLine().ToLower(); // Läser in svaret och gör det gemener för enkel jämförelse

            } while (spelaIgen == "ja");

            // Avslutar programmet med ett meddelande
            Console.WriteLine("Programmet avslutas. Tack för att du spelade!");
        }

        // Ny överlagrad metod: Tar en sträng som input, t.ex. "3T6" och tolkar den
        static int KastaTärning(string tarningInput, Random random)
        {
            // Dela upp strängen baserat på bokstaven "T"
            string[] delar = tarningInput.Split('T');

            // Parsar antalet kast (första delen av strängen)
            int antalKast = int.Parse(delar[0]);

            // Parsar antalet sidor på tärningen (andra delen av strängen)
            int antalSidor = int.Parse(delar[1]);

            // Anropar den överlagrade metoden som tar antal sidor och antal kast
            return KastaTärning(antalSidor, antalKast, random);
        }

        // Ursprunglig metod: Kasta en tärning med specifikt antal sidor ett visst antal gånger
        static int KastaTärning(int antalSidor, int antalKast, Random random)
        {
            int summa = 0;

            // Loopar igenom antalet kast
            for (int i = 1; i <= antalKast; i++)
            {
                // Slumpar fram ett tal mellan 1 och antal sidor på tärningen
                int kast = random.Next(1, antalSidor + 1);

                // Skriver ut resultatet av varje kast
                Console.WriteLine("Kast " + i + " blir: " + kast);

                // Lägger till kastets resultat till summan
                summa += kast;
            }

            // Returnerar den totala summan av alla kast
            return summa;
        }
    }
}