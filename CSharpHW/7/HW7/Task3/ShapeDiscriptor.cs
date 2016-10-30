using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ShapeDiscriptor
    {
        public string ShapeType { get; }
        public ShapeDiscriptor(Point p, Point p2)
        {
            ShapeType = "This is line";
        }

        public ShapeDiscriptor(Point p1, Point p2, Point p3)
        {
            ShapeType = "This is triangle";
        }

        public ShapeDiscriptor(Point p1, Point p2, Point p3, Point p4)
        {
            ShapeType = "This is square";
        }

        public string GetInfo()
        {
            return this.ShapeType;
        }
    }
}
