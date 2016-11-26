using System;

namespace Taschenrechner_Iteration_1
{
  class Program
  {
    static void Main()
    {
      //User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
      Console.Write("Bitte gebe den ersten Summanden ein: ");
      string ersterSummand = Console.ReadLine();
      Console.Write("Bitte gebe den zweiten Summanden ein: ");
      string zweiterSummand = Console.ReadLine();

      //  Wandelt Text in Ganzzahl um
      int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
      int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

      //  Berechnung ausführen
      int summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

      //  Ausgabe
      Console.WriteLine("Die Summe ist: {0}", summe);
      Console.ReadLine();
    }
  }
}
