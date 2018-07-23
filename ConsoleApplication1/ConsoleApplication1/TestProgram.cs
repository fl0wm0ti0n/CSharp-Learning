using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜbungsProgramm
{
    class TestProgram
    {

        // Testwahl -----------------------------------------------------------------------------------------------------
        public static void TestWahl()
        {
            Console.WriteLine("Wähle das TestProgramm");
            Console.WriteLine("1 = TestProgrammConsoleEingabe");
            Console.WriteLine("2 = TestProgrammExceptionCatch");
            Console.WriteLine("3 = TestProgrammArrays");
            Console.WriteLine("4 = TestProgrammUeberladen");
            Console.WriteLine("5 = TestProgrammRueckgabe");
            Console.WriteLine("6 = MenschObjektAnlegen");
            Console.WriteLine("7 = Vererbung");
            Console.WriteLine("8 = Polymorphie");
            Console.WriteLine("9 = Schnittstellen");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Starte TestProgrammConsoleEingabe...");
                    TestProgrammConsoleEingabe();
                    TestWahl();
                    break;
                case 2:
                    Console.WriteLine("Starte TestProgrammExceptionCatch...");
                    TestProgrammExceptionCatch();
                    TestWahl();
                    break;
                case 3:
                    Console.WriteLine("Starte TestProgrammMalSehen...");
                    TestProgrammArrays();
                    TestWahl();
                    break;
                case 4:
                    Console.WriteLine("Starte TestProgrammUeberladen...");
                    TestProgrammUeberladen();
                    TestWahl();
                    break;
                case 5:
                    Console.WriteLine("Starte TestProgrammRueckgabe");
                    TestProgrammRueckgabe();
                    TestWahl();
                    break;
                case 6:
                    Console.WriteLine("Starte MenschObjektAnlegen");
                    MenschAnlegen();
                    TestWahl();
                    break;
                case 7:
                    Console.WriteLine("Starte Vererbung");
                    Vererbung();
                    TestWahl();
                    break;
                case 8:
                    Console.WriteLine("Starte Polymorphie");
                    Polymorphie();
                    TestWahl();
                    break;
                case 9:
                    Console.WriteLine("Starte Schnittstellen");
                    Schnittstellen();
                    TestWahl();
                    break;
                default:
                    Console.WriteLine("Keine gültige Auswahl...");
                    TestWahl();
                    break;
            }
        }

        // Console eingabe -----------------------------------------------------------------------------------------------------
        private static void TestProgrammConsoleEingabe()
        {
            string name;
            int alter;

            Console.WriteLine("Bitte geben Sie Ihren Namen ein");
            name = (Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihr Alter ein");
            alter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ihr Name lautet '" + name + "', ihr Alter ist '" + alter + "'.");
            Console.ReadKey();
        }

        // Arrays -----------------------------------------------------------------------------------------------------
        private static void TestProgrammArrays()
        {
            string[] obst = new string[7];

            obst[0] = "Apfel";
            obst[1] = "banane";
            obst[2] = "Birne";
            obst[3] = "Orange";
            obst[4] = "kiwi";

            foreach (string s in obst)
            {
                Console.WriteLine(s);
            }

            string[,] zweiDArray1 = new string[2, 3];

            zweiDArray1[0, 0] = "0,0";
            zweiDArray1[0, 1] = "0,1";
            zweiDArray1[0, 2] = "0,2";
            zweiDArray1[1, 0] = "1,0";
            zweiDArray1[1, 1] = "1,1";
            zweiDArray1[1, 2] = "1,2";

            foreach (string s in zweiDArray1)
            {
                Console.WriteLine(s);
            }

            string[,] zweiDArray2 = { { "0,0", "0,1", "0,2" }, { "1,0", "1,1", "1,2" } };

            foreach (string s in zweiDArray2)
            {
                Console.WriteLine(s);
            }

        }

        // Exception & try - Catch ----------------------------------------------------------------------------------------
        private static void TestProgrammExceptionCatch()
        {

            int i = 0;

            try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }

        }

        // Überladen -----------------------------------------------------------------------------------------------------
        private static void TestProgrammUeberladen()
        {
            int u1 = 10, u2 = 20;

            Ueberladen(u1, u2);
            Ueberladen(50, 80);
            Ueberladen("100");
        }

        private static void Ueberladen(int geschwindigkeit1, int geschwindigkeit2)
        {
            Console.WriteLine("Die aktuelle Geschwindigkeit beträgt " + geschwindigkeit1 + "km/h");
            Console.WriteLine("Die aktuelle Geschwindigkeit beträgt " + geschwindigkeit2 + "km/h");

        }

        private static void Ueberladen(string geschwindigkeit1)
        {
            Console.WriteLine("Die aktuelle Geschwindigkeit beträgt " + geschwindigkeit1 + "km/h");

        }

        // Rueckgabe -----------------------------------------------------------------------------------------------------
        private static void TestProgrammRueckgabe()
        {

            Console.WriteLine("Geben Sie einen Rückgabewert ein");
            string g = Console.ReadLine();

            Console.WriteLine(Rueckgabe(g));
        }

        private static string Rueckgabe(string rueckgabe)
        {
            rueckgabe = "Folgende Eingabe wurde wieder zurückgegeben: " + rueckgabe;

            return rueckgabe;
        }
        // MenschAnlegen -----------------------------------------------------------------------------------------------------

        private static void MenschAnlegen()
        {
            Mensch mensch1;
            mensch1 = new Mensch("Max", "Mustermann", 30, 3);

            Console.WriteLine(mensch1.Gewicht);
            Console.WriteLine(mensch1.Alter);
            mensch1.Geburtstag();
            Console.WriteLine(mensch1.Alter);
            mensch1.Gewicht = 6;
            Console.WriteLine(mensch1.Gewicht);

            Mensch mensch2 = mensch1;

            Basic.Alter = 5;

            Console.ReadKey();


        }

        // Vererbung -----------------------------------------------------------------------------------------------------
        private static void Vererbung()
        {

            Homosapien homosapien1;
            homosapien1 = new Homosapien(5, 30, 20, 20);

            Console.WriteLine(homosapien1.Beschreiben());
            homosapien1.Geburtstag();
            Console.WriteLine(homosapien1.Beschreiben());
            homosapien1.Wachsen(10);
            Console.WriteLine(homosapien1.Beschreiben());
            homosapien1.Geburtstag();
            Console.WriteLine(homosapien1.Beschreiben());
            homosapien1.Essen();
            Console.WriteLine(homosapien1.Beschreiben());

            for (int i = 0; i <= 60; i++)
            {
                homosapien1.Geburtstag();
                Console.WriteLine(homosapien1.Beschreiben());
            }

        }
        // Polymorphie -----------------------------------------------------------------------------------------------------
        private static void Polymorphie()
        {
            Shape[] shapes = new Shape[9];

            shapes[0] = new Triangle(10, 20, 30, 40);
            shapes[1] = new Rectangle(10, 20, 30, 40);
            shapes[2] = new Circle(10, 20, 30, 40);
            shapes[3] = new Triangle(1, 2, 3, 4);
            shapes[4] = new Rectangle(1, 2, 3, 4);
            shapes[5] = new Circle(1, 2, 3, 4);
            shapes[6] = new Triangle(30, 50, 33, 27);
            shapes[7] = new Rectangle(12, 23, 36, 48);
            shapes[8] = new Circle(98, 12, 57, 93);

            foreach (Shape s in shapes)
            {
                s.Draw();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        // Schnittstellen -----------------------------------------------------------------------------------------------------
        // Siehe Klasse Säufetier die Methode "public int CompareTo(object obj)"
        private static void Schnittstellen()
        {
            
            List<Säugetier> Säugetiere = new List<Säugetier>();
            Säugetiere.Add(new Homosapien(5, 30, 10, 23));
            Säugetiere.Add(new Homosapien(5, 20, 6, 20));
            Säugetiere.Add(new Wal(100,40,40));

            Säugetiere[1].Geburtstag();
            Säugetiere[2].Geburtstag();
            Säugetiere[2].Geburtstag();
            Säugetiere[0].Geburtstag();
            Säugetiere[0].Geburtstag();
            Säugetiere[0].Geburtstag();

            // Methode "Sort" benötgt die Schnittstelle "IComparable"
            Säugetiere.Sort();

            foreach (Säugetier s in Säugetiere)
            {
                Console.WriteLine(s.Alter);
            }

            Console.ReadKey();

        }
    }    
    // Klasse Mensch -----------------------------------------------------------------------------------------------------
    class Mensch : IDisposable
    {
        // Konstruktor - wird beim Objekt erstellen als erstes aufgerufen
        public Mensch(string name, string vorname, int größe, int gewicht)
        {
            this.name = name;
            this.vorname = vorname;
            this.größe = größe;
            this.gewicht = gewicht;
            alter = 0;
            aktuelleGeschwindigkeit = 0;

        }

        // Deklaration der Klasseneigenschaften
        int alter, größe, gewicht, aktuelleGeschwindigkeit;
        string name, vorname;

        // Methoden - Fähigkeiten der Klasse
        public int Geburtstag()
        {
            return ++alter;
        }
        public void Stehen()
        {
            aktuelleGeschwindigkeit = 0;
        }
        public void LaufenMitGeschwindigkeit(int geschwindigkeit)
        {
            aktuelleGeschwindigkeit = geschwindigkeit;
        }

        public void Dispose()
        {
            // Datenbankverbindungen freigeben
            GC.SuppressFinalize(this);
        }
        public void GetGeneration()
        {
            GC.GetGeneration(this);
        }

        // Eigenschaften - Benötigen mindestens einen Accessor - Werden benötigt um zb eine eine Objekteigenschaft zu verändern oder abzufragen
        public int Größe
        {
            get { return größe; }
            set { größe = value; }
        }
        public int Gewicht
        {
            get { return gewicht; }
            set { gewicht = value; }
        }
        public int Alter
        {
            get { return alter; }
        }
        public int AktuelleGeschwindigkeit
        {
            get { return aktuelleGeschwindigkeit; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Vorname
        {
            get { return vorname; }
        }
    }

    static class Basic
    {
        public static int Alter;
    }
}
