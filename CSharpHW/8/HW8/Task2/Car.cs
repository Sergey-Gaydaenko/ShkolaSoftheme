using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Car
    {
        public Color Color { get; set; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }

        public override string ToString()
        {
            return "Color:"+ Color + ", Engine: " + Engine + ", Transmission: " + Transmission;
        }
    }
}
