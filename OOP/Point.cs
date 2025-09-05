using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Point// (double x, double y)
    {
        public double X { get; set; } // = x;
        public double Y { get; set; } // = y;

        public Point(double x, double y) { X = x; Y = y; }

        //double x;
        //double y;
        //public double X
        //{
        //	get { return x; }
        //	set { x = value;}
        //}
        //public double Y
        //{
        //	get { return y; }
        //	set { y = value; }
        //}

        //public double GetX()
        //{
        //	return x;
        //}
        //public double GetY()
        //{
        //	return y;
        //}
        //public void SetX(double x)
        //{
        //	this.x = x;
        //}
        //public void SetY(double y)
        //{
        //	this.y = y;
        //}

        public double Distance(double x, double y)
        {
            return Math.Abs((X - x) + (Y-y));
        }
        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {X}");
        }


    }
}
