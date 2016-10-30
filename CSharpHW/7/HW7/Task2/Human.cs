using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Human
    {
        public DateTime BirthDay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  int Age {
            get {
                DateTime nowDate = DateTime.Today;
                int age = nowDate.Year - BirthDay.Year;
                if (BirthDay > nowDate.AddYears(-age)) age--;
                return age;
            }
        }

        public Human()
        {
        }

        public Human(DateTime BirthDay, string FirstName, string LastName)
        {
            this.BirthDay = BirthDay;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public override bool Equals(object obj)
        {
            Human human = (Human) obj;
            try
            {
                return (BirthDay == human.BirthDay &&
                FirstName == human.FirstName && LastName == human.LastName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex);
            }
            return false;
        }
    }
}
