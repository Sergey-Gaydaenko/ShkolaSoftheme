using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task
{
    public class User : IUser, IValidator
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public string GetFullInfo()
        {
            return Name + " email:" + Email + " password:" + Password + ", Last login time: " + LastLogin;
        }

        public User()
        {}

        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
            LastLogin = DateTime.Now;
        }

        bool IValidator.ValidateUser(IUser value)
        {
            return (value.Password == Password && (value.Name == Name || value.Email == Email));
        }
        
        public bool LoginOrExit(User value)
        {
            if (value.Name == value.Password && value.Email == value.Name && value.Name == "exit")
            { Environment.Exit(0); }

            return ((IValidator) this).ValidateUser(value);
        }
    }
}
