using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Color
    {
        public string Colour { get; set; }

        public Color(){}

        public Color(string color)
        {
            Colour = color;
        }

        public override string ToString()
        {
            return Colour;
        }
    }
}
