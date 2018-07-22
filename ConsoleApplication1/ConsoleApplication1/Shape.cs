using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜbungsProgramm
{
    public class Shape
    {

        public Shape(int x, int y, int height, int width)
        {
            this.X = x;
            this.Y = y;
            this.Height = height;
            this.Width = width;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Die Zeichenaufgabe der Basisklasse läuft...");
        }
    }

    class Circle : Shape
    {
        public Circle(int x, int y, int height, int width)
            : base(x, y, height, width)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Einen Kreis zeichnen...");
            base.Draw();
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int x, int y, int height, int width)
            : base(x, y, height, width)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Ein Rechteck zeichnen...");
            base.Draw();
        }
    }

    class Triangle : Shape
    {
        public Triangle(int x, int y, int height, int width)
            : base(x, y, height, width)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Ein Dreieck zeichnen...");
            base.Draw();
        }
    }
}
