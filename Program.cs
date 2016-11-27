using System;

namespace Taschenrechner
{
  class Program
  {
    static string HoleSummanden(string ausgabeText)
    {
      Console.Write(ausgabeText);
      string summand =  Console.ReadLine();
      return summand;
    }

    static void Main()
    {
      //User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
      string ersterSummand = HoleSummanden("Bitte gebe den ersten Summanden ein: ");
      string zweiterSummand = HoleSummanden("Bitte gebe den zweiten Summanden ein: ");

      //  Wandelt Text in Gleitkommazahlen um
      //  TODO: Auslagern in Methoden, wenn Struktur umfangreicher geworden ist.
      double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
      double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);
      //  Berechnung ausführen
      double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

      //  Ausgabe
      Console.WriteLine("Die Summe ist: {0}", summe);
      WarteAufBenutzerEingabe();
    }

    static double Addiere(double summand1, double summand2)
    {
      return summand1 + summand2;
    }

    static void WarteAufBenutzerEingabe()
    {
      Console.Write("Zum beenden bitte Return drücken!");
      Console.ReadLine();
    }
  }
}
