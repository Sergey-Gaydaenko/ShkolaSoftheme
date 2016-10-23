using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Program
    {
        private static int ValidateData(int size)
        {
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid data, try again");
            }
            return size;
        }
        static void Main(string[] args)
        {
            int trSize = 0;
            int squareSize = 0;
            int rombSize = 0;

            Console.WriteLine("Enter the size of triangle: ");
            trSize = ValidateData(trSize);
            PrintTriangle(trSize);

            Console.WriteLine("Enter the squareSize: ");
            squareSize = ValidateData(squareSize);
            PrintSquare(squareSize);

            Console.WriteLine("Enter the rombSize: ");
            rombSize = ValidateData(rombSize);
            PrintRomb(rombSize);

            Console.ReadLine();
        }

        private static void PrintTriangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }

        private static void PrintRomb(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < size - i; j++)
                    Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                for (int k = 1; k < i; k++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 0; j < size - i; j++)
                    Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                for (int k = 1; k < i; k++)
                    Console.Write("* ");
                Console.WriteLine();
            }       
        }
    }
}
