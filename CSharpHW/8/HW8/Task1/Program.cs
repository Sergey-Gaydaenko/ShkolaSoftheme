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
            int valType1 = 5;
            int valType2 = 10;
            Console.WriteLine("ValType1 = {0}, ValType2 = {1}", valType1, valType2);
            valType1 = valType2;
            Console.WriteLine("\nValType1 = ValueType2: \nValType1 = {0}, ValType2 = {1}", valType1, valType2);
            valType2 = 666;
            Console.WriteLine("\nvalType2 = 666: \nValType1 = {0}, ValType2 = {1}", valType1, valType2);

            var user1 = new User("Sergey", "Gaydaenko", 20);
            var user2 = new User("Ivan", "Ivanov", 35);
            Console.WriteLine("user1 = {0}, user2 = {1}", user1, user2);
            user1 = user2;
            Console.WriteLine("\nuser1 = user2: \nuser1 = {0}, user2 = {1}", user1, user2);
            user2.FirsName = "Andrey";
            Console.WriteLine("\nuser2.FirstName = Andrey: \nuser1 = user2: \nuser1 = {0}, user2 = {1}", user1, user2);
            Console.ReadLine();
        }
    }
}
