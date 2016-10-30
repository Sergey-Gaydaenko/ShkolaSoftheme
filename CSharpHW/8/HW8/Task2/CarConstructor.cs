using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class CarConstructor
    {
        public static Car Construct(this Car car, Color color, Engine engine, Transmission transmission)
        {
            ////Car car = new Car();
            car.Color = color;
            car.Engine = engine;
            car.Transmission = transmission;
            return car;
            
        }

        public static Car Reconstruct(this Car car, Transmission transmission)
        {
            car.Transmission = transmission;
            return car;
        }
    }
}
