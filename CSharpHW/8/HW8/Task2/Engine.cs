using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Engine
    {
        public string Model { get; set; }

        public Engine(){}

        public Engine(string model)
        {
            Model = model;
        }

        public override string ToString()
        {
            return Model;
        }
    }
}
