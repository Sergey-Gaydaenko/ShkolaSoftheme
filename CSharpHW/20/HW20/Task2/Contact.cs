using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
    }
}