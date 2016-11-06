using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration reg = new Registration();

            reg.FirstName = "Anna";
            reg.LastName = "Ivanovna";
            reg.BirthDay = "11/11/2011";
            reg.Email = "qwerty@mail.ru";
            reg.Gender = "female";
            reg.PhoneNumber = "0930575249";
            reg.AdditionalInfo = "nothing";

            Console.ReadLine();
        }
    }
}
