using System;

namespace OO_Kontoverwaltung
{
    class Program
    {
        // ein Objekt bzw. eine Instanz der Klasse Konto erzeugen
        static Konto konto = null;

        static void Main(string[] args)
        {
            Console.Title = "Kontoverwaltung";

            
        }

        static void KontoAnlegen()
        {
            konto = new Konto(); // Konto erzeugen und mit Daten füllen

        }

        // Methode, welches uns das Menü anzeigen soll
        static void MenuAnzeige()
        {
            Console.Clear(); // löscht die BS-Anzeige

            Console.WriteLine("Wählen Sie eine Aktion aus!");
            Console.WriteLine("1. Kontodaten anzeigen");
            Console.WriteLine("2. Geld einzahlen");
            Console.WriteLine("3. Geld auszahlen");
            Console.WriteLine("4. Programm beenden");

            // eine Leerzeile
            Console.WriteLine();

            // Aufforderung zur BS-Eingabe
            Console.WriteLine("Geben Sie eine Zahl ein: ");
        }
    }
}
