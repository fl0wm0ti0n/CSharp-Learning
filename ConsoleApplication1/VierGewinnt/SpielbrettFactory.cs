using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class SpielbrettFactory
    {

        public Spielbrett Erstelle(int reihenAnzahl, int spaltenAnzahl)
        {

            if (spaltenAnzahl < 2) throw new ArgumentOutOfRangeException("spaltenAnzahl", "Die Spaltenanzahl darf nicht kleiner 2 sein");
            if (reihenAnzahl < 2) throw new ArgumentOutOfRangeException("reihenAnzahl", "Sie Reihenanzahl darf nicht kleiner 2 sein");


            //-2-dimensionaler Array erzeugen-------
            // Erstelle ein Array mit einer Dimension der Anzahl "spaltenAnzahl". Das Array kann in jedem Arrayfeld ein weiteres Array aufnehmen.
            // Erstelle für jedes einzelne Feld "spaltenAnzahl" ein weiteres Array welches die Anzahl "reihenAnzahl" Felder enthält.
            // Füge in jedes der Felder "reihenAnzahl" ein objekt des Typs "Platz" ein.
            //--------------------------------------

            var plätze = new Platz[spaltenAnzahl][]; // Ein Array welcher mehre andere Arrays enthalten kann

            for (var i = 0; i < spaltenAnzahl; i++)
            {

                plätze[i] = new Platz[reihenAnzahl]; // an Array Position "i" erstelle Array mit "reihenAnzahl"

                for (var j = 0; j < reihenAnzahl; j++)
                {

                    plätze[i][j] = new Platz(); // Erzeuge tatsächliches Platz Objekt an für jedes Feld im Array

                }

            }


            //-Spalten -----------------------------
            // Erstelle für die Anzahl "spaltenAnzahl" Spalten des Typs Liste. Erstelle für die Anzahl "reihenAnzahl"
            // Spaltenplätze und füge die Plätze des 2D-Arrays in jedes einzelne Feld in "spaltenplätze"
            //--------------------------------------

            var spalten = new List<Spalte>(); // Erstelle Liste mit Typ "Spalte"

            for (var i = 0; i < spaltenAnzahl; i++)
            {

                var spaltenPlätze = new List<Platz>(); // Erstelle Liste mit Typ "Platz"

                for (var j = 0; j < reihenAnzahl; j++)
                {
                    spaltenPlätze.Add(plätze[i][j]); // Füge der Liste des Typs "Platz" die zuvor generierten Objekte des Typs "Platz" ein
                }
                
                spalten.Add(new Spalte(spaltenPlätze)); // Füge der Spaltenliste eine neue Spalte ein, die Spalte beinhaltet die Liste des Typs "Platz" welche breits mit Objekten des Typs "Platz befüllt wurde"

            }


            //-Reihen ------------------------------
            // Erstelle für die Anzahl "reihenAnzahl" Reihen des Typs Liste. Erstelle für die Anzahl "spaltenAnzahl"
            // Reihenplätze und füge die Plätze des 2D-Arrays in jedes einzelne Feld in "reihenPlätze"
            //--------------------------------------

            var reihen = new List<Reihe>(); // Erstelle Liste mit Typ "Reihe"

            for (var i = 0; i < reihenAnzahl; i++)
            {

                var reihenPlätze = new List<Platz>(); // Erstelle Liste mit Typ "Platz"

                for (var j = 0; j < spaltenAnzahl; j++)
                {
                    reihenPlätze.Add(plätze[i][j]); // Füge der Liste des Typs "Platz" die zuvor generierten Objekte des Typs "Platz" ein
                }
                
                reihen.Add(new Reihe(reihenPlätze)); // Füge der Reihenliste eine neue Reihe ein, die Reihe beinhaltet die Liste des Typs "Platz" welche breits mit Objekten des Typs "Platz befüllt wurde"

            }


            //-Diagonalen --------------------------
            // Erstelle Diagonalen des Typs Liste. Erstelle für die mögliche Anzahl "diagonalenPlätze"
            // und füge die Plätze des 2D-Arrays in jedes einzelne Feld in "diagonalenPlätze"
            //--------------------------------------

            var diagonalen = new List<Diagonale>(); // Erstelle Liste mit Typ "Diagonale"


            // Diagonalen von Links oben nach Rechts unten

            for (var i = 0; i < spaltenAnzahl; i++) 
            {

                var spaltenIndex = i;
                var reihenIndex = 0;

                var diagonalenPlätze = new List<Platz>(); // Erstelle Liste mit Typ "Platz"

                while (spaltenIndex < spaltenAnzahl && reihenIndex < reihenAnzahl)
                {

                    diagonalenPlätze.Add(plätze[spaltenIndex][reihenIndex]); // Füge der Liste des Typs "Platz" die zuvor generierten Objekte des Typs "Platz" ein

                    spaltenIndex++;
                    reihenIndex++;

                }

                if (diagonalenPlätze.Count >= 4)
                {

                    diagonalen.Add(new Diagonale(diagonalenPlätze)); // Wenn aktuelle diagonalenPlätze mehr als 4 plätze enthält füge der Diagonalenliste eine neue Diagonale ein,
                    // die Diagonale beinhaltet die Liste des Typs "Platz" welche breits mit Objekten des Typs "Platz befüllt wurde"

                }

            }

            for (var j = 1; j < reihenAnzahl; j++)
            {

                var reihenIndex = j;
                var spaltenIndex = 0;
                
                var diagonalenPlätze = new List<Platz>(); // Erstelle Liste mit Typ "Platz"

                while (spaltenIndex < spaltenAnzahl && reihenIndex < reihenAnzahl)
                {

                    diagonalenPlätze.Add(plätze[spaltenIndex][reihenIndex]); // Füge der Liste des Typs "Platz" die zuvor generierten Objekte des Typs "Platz" ein

                    spaltenIndex++;
                    reihenIndex++;

                }

                if (diagonalenPlätze.Count >= 4)
                {

                    diagonalen.Add(new Diagonale(diagonalenPlätze)); // Wenn aktuelle diagonalenPlätze mehr als 4 plätze enthält füge der Diagonalenliste eine neue Diagonale ein,
                    // die Diagonale beinhaltet die Liste des Typs "Platz" welche breits mit Objekten des Typs "Platz befüllt wurde"

                }
            }


            // Diagonalen von Rechts oben nach links unten

            for (var i = spaltenAnzahl; i > 0; i--)
            {

                var spaltenIndex = i;
                var reihenIndex = 0;

                var diagonalenPlätze = new List<Platz>(); // Erstelle Liste mit Typ "Platz"

                while (spaltenIndex >= 0 && reihenIndex < reihenAnzahl)
                {

                    diagonalenPlätze.Add(plätze[spaltenIndex][reihenIndex]); // Füge der Liste des Typs "Platz" die zuvor generierten Objekte des Typs "Platz" ein

                    spaltenIndex--;
                    reihenIndex++;

                }

                if (diagonalenPlätze.Count >= 4)
                {

                    diagonalen.Add(new Diagonale(diagonalenPlätze)); // Wenn aktuelle diagonalenPlätze mehr als 4 plätze enthält füge der Diagonalenliste eine neue Diagonale ein,
                    // die Diagonale beinhaltet die Liste des Typs "Platz" welche breits mit Objekten des Typs "Platz befüllt wurde"

                }

            }

            for (var j = 1; j < reihenAnzahl; j++)
            {

                var reihenIndex = j;
                var spaltenIndex = 0;

                var diagonalenPlätze = new List<Platz>(); // Erstelle Liste mit Typ "Platz"

                while (spaltenIndex >= 0 && reihenIndex < reihenAnzahl)
                {

                    diagonalenPlätze.Add(plätze[spaltenIndex][reihenIndex]); // Füge der Liste des Typs "Platz" die zuvor generierten Objekte des Typs "Platz" ein

                    spaltenIndex--;
                    reihenIndex++;

                }

                if (diagonalenPlätze.Count >= 4)
                {

                    diagonalen.Add(new Diagonale(diagonalenPlätze)); // Wenn aktuelle diagonalenPlätze mehr als 4 plätze enthält füge der Diagonalenliste eine neue Diagonale ein,
                    // die Diagonale beinhaltet die Liste des Typs "Platz" welche breits mit Objekten des Typs "Platz befüllt wurde"

                }
            }

            

            // Initialisierung Spielbrett

            return new Spielbrett(plätze, reihen, spalten, diagonalen);
        }

    }
}