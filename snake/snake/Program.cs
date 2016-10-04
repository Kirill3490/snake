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

            Point p3 = new Point(7, 9, '@');
            p3.Draw();

            Point p4 = new Point(13, 15, '$');
            p4.Draw();


            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList) 
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<char> symvoly = new List<char>();
            symvoly.Add('*');
            symvoly.Add('#');

            foreach(char k in symvoly)
            {
                Console.WriteLine(k);
            }

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);

            Console.ReadLine();
        }
    }
}
