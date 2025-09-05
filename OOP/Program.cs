using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2,5);
            Point point2 = new Point(10,20);
            //point.SetX(2);
            //point.SetY(3);
            point1.Print();
            point2.Print();
            double res = point1.Distance(point2.X, point2.Y);
            Console.WriteLine(res);
        }
    }
}
