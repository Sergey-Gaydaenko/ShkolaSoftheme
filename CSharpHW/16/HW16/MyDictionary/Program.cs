using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<Guid, string> dictionary = new MyDictionary<Guid, string>();
            Guid firstGuid = Guid.NewGuid();
            
            Guid secondGuid = Guid.NewGuid();
            dictionary.Add(firstGuid, "Aloe");
            dictionary.Add(secondGuid, "Papaya");

            Console.WriteLine(dictionary.ContainsKey(firstGuid));

            Console.WriteLine(dictionary.ContainsValue("Papaya"));
            Console.WriteLine(dictionary.ContainsValue("qwerty"));
            Console.ReadLine();
        }
    }
}
