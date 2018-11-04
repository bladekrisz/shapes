using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Csúcsok
    {
        Double X { get; set; } = 0;
        Double Y { get; set; } = 0;

        public Csúcsok() { }
        public Csúcsok(Double x, Double y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return String.Format("Csúcs: ({0}, {1})", this.X, this.Y);
        }
    }
    public class Rectangle
    {
        Double A { get; set; } = 1;
        Double B { get; set; } = 1;
        public string C { get; set; }
        public List<Csúcsok> Array { get; private set; }
        public Csúcsok this[int i]
        {
            get { return Array[i]; }
            set { Array[i] = value; }
        }
        public void Color(object sender, string color)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            this.C = color;
        }


        public Rectangle() { }
        public Rectangle(Double a, Double b)
        {
            this.A = a;
            this.B = b;
        }
        Double Perimeter => 2 * this.A + 2 * this.B;
        Double Area => this.A * this.B;

        public Rectangle(Double x, Double y, Int32 n) : this(x, y)
        {
            this.Array = new List<Csúcsok>()
            {
                new Csúcsok(0,0),
                new Csúcsok(0,3),
                new Csúcsok(3,3),
                new Csúcsok(3,0)
            };
        }


        public static Rectangle Factory()
        {
            Console.WriteLine("Adjuk meg az új négyzetünk paramétereit: ");

            Console.Write("A: ");
            Double a = Double.Parse(Console.ReadLine());

            Console.Write("B: ");
            Double b = Double.Parse(Console.ReadLine());

            

            return new Rectangle(a, b);
        }
        public Rectangle ChangeLocation(Double a, Double b)
        {
            this.A += a;
            this.B += b;

            return this;
        }
        public override string ToString()
        {
            return String.Format("A négyzet 'A' oldala: {0:0 egység}, 'B' oldala: {1:0 egység}, kerülete: {2:0 egység}, területe: {3:0 egységnégyzet}, szín: {4}",
                                this.A, this.B, this.Perimeter, this.Area,this.C);
        }
    }
    public class Beautifier
    {
        public event EventHandler<string> Beautify;
        public void OnBeautify(string c)
        {
            Beautify(this, c);
            
        }
    }
}
