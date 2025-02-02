using System;

class Program
{
    static void Main()
    {
        bool köraIgen = true;

        while (köraIgen)
        {
            // Be användaren mata in temperaturerna för de tre städerna.
            Console.Write("Ange temperatur för Östersund: ");
            int ostersund = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange temperatur för Åmål: ");
            int amal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange temperatur för Arboga: ");
            int arboga = Convert.ToInt32(Console.ReadLine());

            // Kontrollera vilken stad som är kallast med OCH-operatorn (&&).
            if (ostersund < amal && ostersund < arboga)
            {
                Console.WriteLine("Det är kallast i Östersund");
            }
            else if (amal < ostersund && amal < arboga)
            {
                Console.WriteLine("Det är kallast i Åmål");
            }
            else
            {
                Console.WriteLine("Det är kallast i Arboga");
            }

            // Fråga om användaren vill köra programmet igen.
            Console.Write("Vill du köra programmet igen? (ja/nej): ");
            string svar = Console.ReadLine().ToLower();
            if (svar != "ja")
            {
                köraIgen = false;
            }
        }
    }
}