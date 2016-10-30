using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lottery!");
            do
            {
                var lottery = new Lottery();
                lottery.GenNewNubers();

                Console.WriteLine("Please input 6 numbers ranging from 1 to 9: ");

                int[] userNumbers = new int[6];
                CreateUserNumbers(userNumbers);

                lottery.CheckForWin(userNumbers);
                ////////////////////////////////////////////////////////
                while (true)
                {
                    Console.WriteLine("Do you want try again?(yes/no)");
                    var res = Console.ReadLine();
                    if (res == "no") { return; }

                    if (res == "yes") { break;}
                }
                Console.Clear();
            }
            while (true);
            
        }

        public static int[] CreateUserNumbers(int[] userNumbers)
        {
            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine("Please, input {0} number from 0 to 9", i + 1);
                try
                {
                    userNumbers[i] = Int32.Parse(Console.ReadLine());
                    if (userNumbers[i] < 1 || userNumbers[i] > 9)
                    { Console.WriteLine("Incorrect data"); break; }
                        
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect data: ");
                    break;
                }
            }
            return userNumbers;
        }
    }
}
