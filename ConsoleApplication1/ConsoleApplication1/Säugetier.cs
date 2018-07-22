using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜbungsProgramm
{
    class Säugetier
    {
        int alter, größe, breite, anzahlKinder, energie, nichtWachsenAb;
        bool lebt;

        // Konstruktor
        public Säugetier(int größe, int breite, int nichtWachsenAb)
        {
            this.größe = größe;
            this.breite = breite;
            this.nichtWachsenAb = nichtWachsenAb; 
            energie = 100;
            lebt = true;
            
        }

        // Fähigkeiten
        public string Beschreiben()
        {
            string txtLebt = "gestorben";
            if (Lebt == true)
            {
                txtLebt = "am Leben";
            }
            return "Das ist ein Säugetier mit einer Höhe von " + größe + "cm, einer Breite von " + breite + "cm, einer Energie von " + energie + "/100 Energiepunkten, einem Alter von " + alter + ". Das Säugetier hat " + anzahlKinder + " Kinder zur Welt gebracht und ist " + txtLebt + ".";
        }

        public virtual void Geburtstag()
        {
            alter++;
            Wachsen(7);
        }

        public virtual void Wachsen(int zusätzlicheGröße)
        {
           if (alter <= nichtWachsenAb)
           {
                größe += zusätzlicheGröße;
           }
            energie--;
        }

        public virtual void KindGebären()
        {
            anzahlKinder++;
        }

        public void Essen()
        {
            energie += 10;
        }

        public void Fortbewegen(int km)
        {
            energie -= km;
        }

        public void Sprechen(int text)
        {
            Console.WriteLine("Das Säugetier spricht!");
        }

        // Eigenschaften
        public int Energie
        {
            get { return energie; }
            protected set
            {
                if (energie + value > 100)
                {
                    energie = 100;
                }
                else
                {
                    energie = value;
                }
                if (energie + value <= 0)
                {
                    lebt = false;
                    Console.WriteLine("Das Säugetier ist gestorben!");
                }

            }

        }
        public int Größe
        {
            get { return größe; }
            set { größe = value; }
        }
        public int Alter
        {
            get { return alter; }
            protected set { größe = value; }
        }
        public int Breite
        {
            get { return breite; }
        }
        public int AnzahlKinder
        {
            get { return anzahlKinder; }
            protected set { anzahlKinder = value; }
        }
        public bool Lebt
        {
            get { return lebt; }
        }
    }
}
