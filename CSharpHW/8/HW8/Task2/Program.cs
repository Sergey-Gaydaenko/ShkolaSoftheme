using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color("Red");
            Engine engine = new Engine("External combustion engine");
            Transmission transmission = new Transmission("Semi-automatic");

            Transmission newTransmission = new Transmission("Automatic");
            Car car = new Car();

            car.Construct(color, engine, transmission);
            Console.WriteLine(car);
           
            car.Reconstruct(newTransmission);
            Console.WriteLine(car);

            Console.ReadLine();
        }
    }
}
