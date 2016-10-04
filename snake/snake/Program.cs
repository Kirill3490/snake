using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(0, 70, 12, '-');
            line.Drow();

            HorizontalLine line1 = new HorizontalLine(0, 70, 0, '-');
            line1.Drow();

            VertikalLine line2 = new VertikalLine(0, 12, 0, '|');
            line2.Drow();

            VertikalLine line3 = new VertikalLine(0, 12, 70, '|');
            line3.Drow();

            Console.ReadLine();
        }
    }
}
