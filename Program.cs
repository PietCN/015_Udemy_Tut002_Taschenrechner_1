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
      string operation = HoleBenutzerEingabe("Bitte gebe die auszuführende Operationein (+ oder -) : ");

      //  Wandelt Text in Gleitkommazahlen um
      //  TODO: Auslagern in Methoden, wenn Struktur umfangreicher geworden ist.
      double zahl1 = Convert.ToDouble(ersteZahlAlsString);
      double zahl2 = Convert.ToDouble(zweiteZahlAlsString);
      double ergebnis = 0;

      //  Berechnung ausführen
      if (operation == "+")
      {
        ergebnis = Addiere(zahl1, zahl2);
      }
      else if(operation == "-")
      {
        ergebnis = Subtrahiere(zahl1, zahl2);
      }
      else
      {
        Console.WriteLine("Du hast eine ungültige Auswahl oder Operation getroffen!");
      }

      //  Ausgabe
      Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
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
    
  }
}
