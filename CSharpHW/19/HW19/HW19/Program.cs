using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator mobileOperator = new MobileOperator();
            var acc1 = mobileOperator.CreateAccount(1111111111);
            var acc2 = mobileOperator.CreateAccount(222222222);
            var acc3 = mobileOperator.CreateAccount(333333333);
            var acc4 = mobileOperator.CreateAccount(444444444);
            var acc5 = mobileOperator.CreateAccount(555555555);
            var acc6 = mobileOperator.CreateAccount(666666666);

            acc2.AddContact(acc1.Number, "First", "Contact");
            acc1.Call(acc2.Number);
            acc2.Call(acc3.Number);
            acc3.Call(acc4.Number);
            acc4.Call(acc5.Number);
            acc5.Call(acc5.Number);
            acc4.Call(acc6.Number);
            Console.WriteLine();

            acc1.AddContact(acc3.Number, "Third", "Contact");
            acc3.SendMessage(acc1.Number, "Hello");

            var nums = mobileOperator.Get5MostCallingNumbers();
            Console.WriteLine("\n5 Most Calling Accounts: ");
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }

            mobileOperator.Get5MostActiveNumbers();
            Console.ReadLine();
        }
    }
}
