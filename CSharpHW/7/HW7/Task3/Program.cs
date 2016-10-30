using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(5, 5);
            var p2 = new Point(5, 10);
            var p3 = new Point(20, 15);
            var p4 = new Point(1, 1);

            ShapeDiscriptor shapedisc = new ShapeDiscriptor(p1, p2);
            Console.WriteLine(shapedisc.GetInfo());
            shapedisc = new ShapeDiscriptor(p1,p2,p3);
            Console.WriteLine(shapedisc.GetInfo());
            shapedisc = new ShapeDiscriptor(p1,p2,p3,p4);
            Console.WriteLine(shapedisc.GetInfo());

            Console.ReadLine();
        }
    }
}
