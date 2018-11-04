using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(3, 3, 4);
            foreach (var item in a.Array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            
            List<Rectangle> rectangles = new List<Rectangle>
            {
                new Rectangle(),
                new Rectangle(3, 5),
                //Rectangle.Factory(),
            };
            var beautifier = new Beautifier();
            foreach (var tégla in rectangles)
            {
                beautifier.Beautify += tégla.Color;
                beautifier.OnBeautify("ződ");
                Console.WriteLine(tégla);
            }
            Console.ReadLine();
            /*
            Console.WriteLine("Eredeti: {0} ", rectangles[0]);
            rectangles[0].ChangeLocation(1, 1).ChangeColor("Barna");
            Console.WriteLine("Megváltoztatva: {0} ", rectangles[0]);
            foreach (var item in rectangles)
            {
                Console.WriteLine(item);
                Console.ReadKey();

            }
            */

        }
    }
}
