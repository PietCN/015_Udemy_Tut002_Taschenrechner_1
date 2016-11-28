using System;

namespace Taschenrechner
{
  class Program
  {
    static string HoleBenutzerEingabe(string ausgabeText)
    {
      Console.Write(ausgabeText);
      string stringWert =  Console.ReadLine();
      return stringWert;
    }

    static void Main()
    {
      //User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
      string ersteZahlAlsString = HoleBenutzerEingabe("Bitte gebe die erste Zahl ein: ");
      string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gebe die zweite Zahl ein: ");
      string operation = HoleBenutzerEingabe("Bitte gebe die auszuführende Operationein (+, -, *, /) : ");

      //  Wandelt Text in Gleitkommazahlen um
      //  TODO: Auslagern in Methoden, wenn Struktur umfangreicher geworden ist.
      double zahl1 = Convert.ToDouble(ersteZahlAlsString);
      double zahl2 = Convert.ToDouble(zweiteZahlAlsString);
      double ergebnis = 0;

      //  Berechnung ausführen
      switch (operation)
      {
        case "+":
          ergebnis = Addiere(zahl1, zahl2);
          Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
          break;
        case "-":
          ergebnis = Subtrahiere(zahl1, zahl2);
          Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
          break;
        case "*":
          ergebnis = Multiplizieren(zahl1, zahl2);
          Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
          break;
        case "/":
          ergebnis = Dividieren(zahl1, zahl2);
          Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
          break;
        default:
          Console.WriteLine("Du hast eine ungültige Auswahl oder Operation getroffen!");
          break;
      }

      HoleBenutzerEingabe("Zum beenden bitte Return drücken!");
    }

    //Mathematischen Operationsmethoden
    static double Addiere(double summand1, double summand2)
    {
      return summand1 + summand2;
    }

    static double Subtrahiere(double minuend, double subtrahent)
    {
      return minuend - subtrahent;
    }
    
    static double Multiplizieren(double faktor1, double faktor2)
    {
      return faktor1 * faktor2;
    }

    static double Dividieren(double divident, double divisor)
    {
      return divident / divisor;
    }
  }
}
