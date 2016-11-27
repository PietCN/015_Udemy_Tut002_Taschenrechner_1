using System;

namespace Taschenrechner
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

      //  Wandelt Text in Gleitkommazahlen um
      float ersterSummandAlsZahl = Convert.ToSingle(ersterSummand);
      float zweiterSummandAlsZahl = Convert.ToSingle(zweiterSummand);
      //  Berechnung ausführen
      float summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

      //  Ausgabe
      Console.WriteLine("Die Summe ist: {0}", summe);
      Console.ReadLine();
    }
  }
}
