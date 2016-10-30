using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return Model + ", year of release:" + Year + ", color: " + Color;
        }
        public Car()
        { }

        public Car(string model, int year, string color)
        {
            Model = model;
            Year = year;
            Color = color;
        }
    }
}
