using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Coordinate
    {
        Double X { get; set; } = 0;
        Double Y { get; set; } = 0;

        public Coordinate() { }
        public Coordinate(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return String.Format("origo : ({0}, {1})", this.X, this.Y);
        }
    }
    public class Circle
    {
        #region statics and constants

        public const Double ONE = 1;

        public static Int32 Count { get; private set; } = 0;

        public static Circle operator +(Circle a, Circle b) => new Circle(a.X + b.X, a.Y+b.Y,a.R+b.R);

        public static Boolean operator <(Circle a, Circle b) => a.R < b.R;
        public static Boolean operator >(Circle a, Circle b) => !(a < b);

        //public static Boolean operator ==(Circle a, Circle b) => a.X == b.X && a.Y == b.Y && a.R == b.R;
        //public static Boolean operator !=(Circle a, Circle b) => !(a==b);
        #endregion

        public List<Coordinate> Array { get;private  set; }
        public Coordinate this[int i]
        {
            get { return Array[i]; }
            set { Array[i] = value; }
        }


        Double X { get; set; } = 0;
        Double Y { get; set; } = 0;
        Double R { get; set; } = 1;


        public Circle()
        {
            Console.WriteLine("paraméter nélküli construktor");
            Circle.Count++;
        }
        public Circle(Double x, Double y, Double r)
        {
            //Console.WriteLine("paraméteres construktor");
            this.X = x;
            this.Y = y;

            if (r <= 0)
            {
                //throw new ArgumentException("Radius should greater than zero");
                this.R = Circle.ONE;
            }
            else
            {
                this.R = r;
            }
            //this.Color = c;
            Circle.Count++;
        }

        public Circle(Double x, Double y, Double r, Int32 n):this(x,y,r)
        {
            this.Array = new List<Coordinate>()
            {
                new Coordinate(1, 5),
                new Coordinate(5,5),
                new Coordinate(5,1),
                new Coordinate(1,1),
                
            };
        }


        Double Perimeter => 2 * this.R * Math.PI;
        Double Area => Math.Pow(this.R, 2) * Math.PI;


        public override string ToString()
        {
            return String.Format("origo : ({0}, {1}), radius: {2}, perimeter: {3:0.00 egység}, area: {4:0.00 egysénégyzet}",
                                 this.X, this.Y, this.R, this.Perimeter, this.Area);

        }
        public static Circle Factory()
        {
            Console.WriteLine("Adjuk meg a síkbeli pont koordinátáit, sugarát, illetve színét:");

            Console.Write("x: ");
            Double x = Double.Parse(Console.ReadLine());

            Console.Write("y: ");
            Double y = Double.Parse(Console.ReadLine());

            Double r;
            do
            {
                Console.Write("r: ");
                r = Double.Parse(Console.ReadLine());
                if (r < 0) { Console.WriteLine("Radius should greater than zero."); }


            } while (r < 0);

            return new Circle(x, y, r);
        }
        public Circle ChangeLocation(Double x, Double y)
        {
            this.X += x;
            this.Y += y;
            return this;
        }
        public Circle ChangeRadius(Double r)
        {

            this.R += r;
            return this;
        }

    }
}

