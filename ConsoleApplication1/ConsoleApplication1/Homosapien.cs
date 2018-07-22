using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜbungsProgramm
{
    sealed class Homosapien : Säugetier
    {
        int iq;

        // Konstruktor mit Übergabe an Basisklasse
        public Homosapien(int iq, int größe, int breite, int nichtWachsenAb)
            : base(größe, breite, nichtWachsenAb)
        {
            this.iq = iq;
        }

        // Verärbte Fähigkeiten
        // Mit schlüsselwort "new" wird die vererbte Methode Beschreiben ausgeblendet. D.H. es wird beim Aufruf die Methode von der Tochter Klasse verwendet.
        new public string Beschreiben()
        {
            string txtLebt = "gestorben";
            if (Lebt == true)
            {
                txtLebt = "am Leben";
            }
            return "Das ist ein Säugetier mit einer Höhe von " + Größe + "cm, einer Breite von " + Breite + "cm, einer Energie von " + Energie + "/100 Energiepunkten, einem Alter von " + Alter + ". Das Säugetier hat " + AnzahlKinder + " Kinder zur Welt gebracht und ist " + txtLebt + ". Es hat einen IQ von " + iq;
        }
        // Mit "override" kann eine aus der basisklasse vererbende Methode überschrieben werden, sofern diese als "virtuell" gekennzeichnet ist - besser als mit "new"
        public override void KindGebären()
        {
            AnzahlKinder += 2;
        }

        /*public override void Geburtstag()
        {
            Alter++;
            Wachsen(5);
        }
        */
        //public override void Wachsen(int zusätzlicheGröße)
        /*
        {
            if (Alter <= 20)
            {
                Größe += zusätzlicheGröße;
            }
            Energie--;
        }
        */

        // Eigenschaft
        public int IQ
        {
            get { return iq; }
        }

    }
}
