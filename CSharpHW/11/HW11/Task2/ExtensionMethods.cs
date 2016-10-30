using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    public static class ExtensionMethods
    {
        public static void ExtPrint(this Printer printer, string[] messages)
        {
            Console.WriteLine("Extention method for class Printer");
            for (int i = 0; i < messages.Length; i++)
            {
                Console.WriteLine(messages[i]);
            }
        }

        public static void ExtPrint(this PhotoPrinter printer, string[] messages, string[] photos)
        {
            Console.WriteLine("Extention method for class Photo");
            
            for (int i = 0; i <photos.Length; i++)
            {
                Console.WriteLine(photos[i]);
            }
        }

        public static void ExtPrint(this ColourPrinter printer, string[] messages, ConsoleColor[] colors)
        {
            Console.WriteLine("Extention method for class ColourPrinter");

            for (int i = 0; i < colors.Length; i++)
            {
                Console.BackgroundColor = colors[i];
                Console.WriteLine(messages[i]);
                Console.ResetColor();
            }
        }
    }
}
