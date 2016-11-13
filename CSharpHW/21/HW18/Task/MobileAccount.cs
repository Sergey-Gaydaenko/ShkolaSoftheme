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
    [Serializable]
    [DataContract]
    [ProtoContract]
    public class MobileAccount
    {
        [DataMember]
        [ProtoMember(1)]
        private int _number;

        [DataMember]
        [ProtoMember(2)]
        private List<Contact> _contacts = new List<Contact>();

        private MobileAccount()
        {
            
        }
        public MobileAccount(int number, MobileOperator mobileOperator)
        {
            _number = number;
        }

        [DataMember]
        [ProtoMember(3)]
        public int Number { get; set; }

        public event Action<int, int> OnCall;
        public event Action<int, string, int> OnMessagePost;

        public void AddContact(int number, string fName, string lName)
        {
            _contacts.Add(new Contact(fName, lName, number));
        }
        public void SendMessage(int number, string message)
        {   
            Console.WriteLine("Send message: {0} \nTo {1}", message, number);

            OnMessagePost?.Invoke(number, message, _number);
        }

        public void Call(int number)
        {
            Console.WriteLine("Call to {0}", number);

            OnCall?.Invoke(number, _number);
        }

        public void ReceiveMessage(int number, string message)
        {
            string fromContact = GetContactStr(number);
            Console.WriteLine("New message: {0} \nFrom:{1}", message, fromContact);
        }

        public void ReceiveCall(int number)
        {
            string fromContact = GetContactStr(number);

            Console.WriteLine($"Incoming call from {fromContact}");
        }

        private string GetContactStr(int number)
        {
            Contact contact;
            if (_contacts.Exists(x => x.Number == number))
            {
                contact = _contacts.Find(x => x.Number == number);
                return string.Format("{0} {1}", contact.FirstName, contact.LastName);
            }
            return number.ToString();
            ////return _contacts.TryGetValue(number, out contact)
            ////    ? $"{contact.FirstName} {contact.LastName}"
            ////    : number.ToString();
        }
    }
}
