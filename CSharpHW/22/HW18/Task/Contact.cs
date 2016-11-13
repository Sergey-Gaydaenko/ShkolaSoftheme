using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ProtoBuf;

namespace Task
{
    [ProtoContract]
    [Serializable]
    [DataContract]
    public class Contact
    {
        [XmlAttribute]
        [DataMember]
        [ProtoMember(5)]
        public string FirstName { get; set; }
        [XmlAttribute]
        [DataMember]
        [ProtoMember(6)]
        public string LastName { get; set; }

        [XmlAttribute]
        [DataMember]
        [ProtoMember(7)]
        public int Number { get; set; }

        public Contact()
        {
            
        }
        public Contact(string fName, string lName, int number)
        {
            FirstName = fName;
            LastName = lName;
            Number = number;
        }
    }
}
