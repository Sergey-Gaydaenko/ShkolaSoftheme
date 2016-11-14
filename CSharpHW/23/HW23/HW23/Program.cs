using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HW23
{
    class Program
    {
        static void Main(string[] args)
        {
            
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"dataBook.xml");

            XmlData xmlData = new XmlData(xmlDocument);

            ////Console.WriteLine("Add New Book: ");
            ////xmlData.AddNewBook();

            Console.WriteLine("All books: ");
            xmlData.GetAllBooks();

            Console.WriteLine("Find Book: ");
            xmlData.FindBookByTitle();
            
            Console.ReadLine();
        }
        
    }
}
