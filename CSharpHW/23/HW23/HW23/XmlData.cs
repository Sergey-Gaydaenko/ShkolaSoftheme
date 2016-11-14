using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HW23
{
    public class XmlData
    {
        private XDocument _dataForLinq;
        private XmlDocument _data;

        public XmlData(XmlDocument data)
        {
            _data = data;
            _dataForLinq = XDocument.Load(SetDataPath() + @"\dataBook.xml");
        }

        public void AddNewBook()
        {
            Book newBook = new Book();
            XmlElement newElement = _data.CreateElement("book");

            XmlAttribute newAttribute = _data.CreateAttribute("id");
            Console.WriteLine("Enter Value for book Id: ");
            newAttribute.Value = Console.ReadLine();

            XmlElement author = _data.CreateElement("author");
            Console.WriteLine("Enter Value for Author: ");
            author.InnerText = Console.ReadLine();

            XmlElement title = _data.CreateElement("title");
            Console.WriteLine("Enter Value for Title:");
            title.InnerText = Console.ReadLine();

            XmlElement genre = _data.CreateElement("genre");
            Console.WriteLine("Enter Value for Genre:");
            genre.InnerText = Console.ReadLine();

            XmlElement price = _data.CreateElement("price");
            Console.WriteLine("Enter Value for Price:");
            price.InnerText = Console.ReadLine();

            XmlElement publishDate = _data.CreateElement("publish_date");
            Console.WriteLine("Enter Value for Publish Date:");
            publishDate.InnerText = Console.ReadLine();

            XmlElement description = _data.CreateElement("description");
            Console.WriteLine("Enter Value for Description:");
            description.InnerText = Console.ReadLine();

            newElement.Attributes.Append(newAttribute);
            newElement.AppendChild(author);
            newElement.AppendChild(title);
            newElement.AppendChild(genre);
            newElement.AppendChild(price);
            newElement.AppendChild(publishDate);
            newElement.AppendChild(description);
            _data.DocumentElement.AppendChild(newElement);

            _data.Save("Book.xml");
        }

        public void FindBookByTitle()
        {
            Console.WriteLine("Enter Title of Book");
            _dataForLinq = XDocument.Load(SetDataPath() + @"\dataBook.xml");
            string title = Console.ReadLine();
            
            XElement root = _dataForLinq.Root;
            XNamespace xname = root.Name.Namespace;
            var book = root.Elements(xname + "book")
                .Where(node => node.Element(xname + "title").Value == title)
                .Select(node => (node))
                .FirstOrDefault();

            if (!book.IsEmpty)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Can't find book with this title");
            }
        }



        public void GetAllBooks()
        {
            XmlNodeList xmlNodes = _data.GetElementsByTagName("book");
            foreach (XmlNode node in xmlNodes)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Selected book id: '{0}', details:", node.Attributes?["id"].Value);
                Console.ResetColor();

                XmlNodeReader xmlNodeReader = new XmlNodeReader(node);
                xmlNodeReader.Read();
                xmlNodeReader.Read();
                string author = xmlNodeReader.ReadElementContentAsString();
                string title = xmlNodeReader.ReadElementContentAsString();
                string genre = xmlNodeReader.ReadElementContentAsString();
                string price = xmlNodeReader.ReadElementContentAsString();
                string publishDate = xmlNodeReader.ReadElementContentAsString();
                string description = xmlNodeReader.ReadElementContentAsString();

                Console.WriteLine(genre + " book \"" + title + "\" written by \"" + author + "\", published on " + publishDate);
                Console.WriteLine(description);
            }
        }

        static public string SetDataPath()
        {
            string path = Environment.CommandLine;
            while (path.StartsWith("\""))
            {
                path = path.Substring(1, path.Length - 2);
            }
            while (path.EndsWith("\"") || path.EndsWith(" "))
            {
                path = path.Substring(0, path.Length - 2);
            }
            path = Path.GetDirectoryName(path);

            return Path.Combine(path);
        }
    }
}



