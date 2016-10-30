using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCarAudi = new Car();
            myCarAudi.Model = "Audi";
            myCarAudi.Year = 2010;
            myCarAudi.Color = "Black";

            var myCarBmw = new Car("BMW", 1999, "Green");
            Console.WriteLine("Cars before tuning:");
            Console.WriteLine(myCarAudi);
            Console.WriteLine(myCarBmw);

            TuningAtelier.TuneCar(myCarAudi);
            TuningAtelier.TuneCar(myCarBmw);

            Console.WriteLine("\nCars after tuning:");
            Console.WriteLine(myCarAudi);
            Console.WriteLine(myCarBmw);
            Console.ReadLine();
        }
    }
}
