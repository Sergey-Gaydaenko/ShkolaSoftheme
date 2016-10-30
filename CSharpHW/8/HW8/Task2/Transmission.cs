using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Transmission
    {
        public string Model { get; set; }

        public Transmission(){}

        public Transmission(string model)
        {
            Model = model;
        }

        public override string ToString()
        {
            return Model;
        }
    }
}
