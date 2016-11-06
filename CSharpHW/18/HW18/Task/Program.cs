using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        private static void Main(string[] args)
        {
            MobileOperator mobileOperator = new MobileOperator();
            var acc1 = mobileOperator.CreateAccount(0930575249);
            var acc2 = mobileOperator.CreateAccount(1234565656);
            var acc3 = mobileOperator.CreateAccount(1232123123);
            
            acc2.AddContact(acc1.Number, "First", "Contact");
            acc1.Call(acc2.Number);
            Console.WriteLine();

            acc1.AddContact(acc3.Number, "Third", "Contact");
            acc3.SendMessage(acc1.Number, "Hello");
            Console.ReadLine();
        }
    }
}
