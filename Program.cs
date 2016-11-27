using System;

namespace Taschenrechner
{
  class Program
  {
    static string HoleBenutzerEingabe(string ausgabeText)
    {
      Console.Write(ausgabeText);
      string zahlAlsString =  Console.ReadLine();
      return zahlAlsString;
    }

    static void Main()
    {
      //User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
      string ersteZahlAlsString = HoleBenutzerEingabe("Bitte gebe die erste Zahl ein: ");
      string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gebe die zweite Zahl ein: ");

      //  Wandelt Text in Gleitkommazahlen um
      //  TODO: Auslagern in Methoden, wenn Struktur umfangreicher geworden ist.
      double ersterSummandAlsZahl = Convert.ToDouble(ersteZahlAlsString);
      double zweiterSummandAlsZahl = Convert.ToDouble(zweiteZahlAlsString);
      //  Berechnung ausführen
      double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

      //  Ausgabe
      Console.WriteLine("Die Summe ist: {0}", summe);
      HoleBenutzerEingabe("Zum beenden bitte Return drücken!");
    }

    static double Addiere(double summand1, double summand2)
    {
      return summand1 + summand2;
    }

    static double Subtrahiere(double minuend, double subtrahent)
    {
      return minuend - subtrahent;
    }
    
    static string HoleOperator()
    {
      Console.Write("Welche Operation soll ausgeführt werden? (+,-) : ");
      string operation = Console.ReadLine();
      return operation;
    }
  }
}
