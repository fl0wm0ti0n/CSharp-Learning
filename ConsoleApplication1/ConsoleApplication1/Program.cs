using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWahl();
        }

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

        private static void TestWahl()
        {
            Console.WriteLine("Wähle das TestProgramm");
            Console.WriteLine("1 = TestProgrammConsoleEingabe");
            Console.WriteLine("2 = TestProgrammExceptionCatch");
            Console.WriteLine("3 = TestProgrammArrays");
            Console.WriteLine("4 = TestProgramm4");
            Console.WriteLine("5 = TestProgramm5");
            Console.WriteLine("6 = TestProgramm6");

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
                    Console.WriteLine("Starte ");
                    TestWahl();
                    break;
                case 5:
                    Console.WriteLine("Starte ");
                    TestWahl();
                    break;
                default:
                    Console.WriteLine("Keine gültige Auswahl...");
                    TestWahl();
                    break;
            }
        }
    }
}
