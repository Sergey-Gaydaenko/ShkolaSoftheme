using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW19
{
    public class MobileAccount
    {
        private int _number;

        private Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        public MobileAccount(int number, MobileOperator mobileOperator)
        {
            _number = number;
        }

        public int Number => _number;

        public event Action<int, int> OnCall;
        public event Action<int, string, int> OnMessagePost;

        public void AddContact(int number, string fName, string lName)
        {
            _contacts.Add(number, new Contact(fName, lName));
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
            var Contacts = (from cont in _contacts
                            where cont.Key == number
                            select cont);
            var contact = Contacts.GetEnumerator();
            if (contact.MoveNext())
            {
                return contact.Current.Value.FirstName + " " + contact.Current.Value.LastName;
            }
            return number.ToString();
        }   
    }
}
