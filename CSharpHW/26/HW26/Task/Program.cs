using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your directory path: ");
            string path = Console.ReadLine();

            Console.WriteLine("Enter text that you need to change: ");
            string oldText = Console.ReadLine();

            Console.WriteLine("Enter new text: ");
            string newText = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Indicate extension for files? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Enter extension of your files: ");
                    string extension = Console.ReadLine();
                    FileChanger fc = new FileChanger(path, oldText, newText, extension);
                    fc.ChangeFiles();

                    break;
                }
                if (answer == "n")
                {
                    FileChanger fc = new FileChanger(path, oldText, newText);
                    fc.ChangeFiles();
                    break;
                }
            }

            Console.WriteLine("All files are changed. See log file in your directory!");
            Console.ReadLine();

        }
    }
}
