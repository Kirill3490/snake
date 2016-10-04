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
            Console.SetBufferSize(80, 25);
            
            Point p = new Point(4, 5, '*');
            p.Draw();
            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            Upline.Drow();
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '+');
            Downline.Drow();
            VertikalLine leftline = new VertikalLine(0, 24, 0, '+');
            leftline.Drow();
            VertikalLine rightline = new VertikalLine(0, 24, 78, '+');
            rightline.Drow();

            Console.ReadLine();
        }
    }
}
