using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);

                MainMerge(numbers, left, (mid + 1), right);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
            Console.Write("\n\nEnter number of elements: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[lenght];
            Random rand = new Random();
            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = rand.Next(0, 101);
            }

            Console.Write("Input int array : ");
            Console.Write("\n");
            for (int k = 0; k < lenght; k++)
            {
                Console.Write(numbers[k] + " ");
                Console.Write("\n");
            }


            Console.WriteLine("Sorted items: ");
            SortMerge(numbers, 0, lenght - 1);
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
