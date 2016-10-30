using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static int[] CreateMass()
        {
            int[] arr = new int[10001];
            for (int i = 0; i <= arr.Length-2; i+=2)
            {
                arr[i] = i;
                arr[i+1] = arr[i];
            }
            return arr;
        }

        public static int GetAloneNumber(int[] arr)
        {
            int result = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                result = result^arr[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] mass = CreateMass();
            mass[1] = 1111111;
            Console.WriteLine(GetAloneNumber(mass));
            Console.ReadLine();
        }
    }
}
