using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public  int Age { get; set; }

        public User(){ }

        public User(string firstName, string lastName, int age)
        {
            FirsName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return FirsName + " " + LastName + ", age = " + Age;
        }
    }
}
