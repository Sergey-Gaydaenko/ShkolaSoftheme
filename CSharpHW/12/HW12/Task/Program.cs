using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Ivan", "qwerty", "Ivan@ukr.net");
            var user2 = new User("Gamer777", "parol", "Gamer2008@mail.ru");
            var user3 = new User("Petrenko", "12345", "Petr@gmail.com");
            List<User> users = new List<User> {user, user2, user3};
            
            do
            {
                var currentUser = new User();
                Console.WriteLine("Enter your Login: ");
                currentUser.Name = Console.ReadLine();
                Console.WriteLine("Please Enter your Email:");
                currentUser.Email = Console.ReadLine();
                Console.WriteLine("Please Enter your Password:");
                currentUser.Password = Console.ReadLine();
                
                foreach (var item in users)
                {
                    if (item.LoginOrExit(currentUser))
                    {
                        Console.WriteLine(item.GetFullInfo());
                        item.LastLogin = DateTime.Now;
                    }      
                }
                
                AddNewUser(users,currentUser);
            }
            while (true);

        }

        public static void AddNewUser(List<User> users, User currentUser )
        {
            foreach (var item in users)
            {
                if (item.Name == currentUser.Name
                    || item.Email == currentUser.Email)
                {
                    Console.WriteLine("Invalid data, pls try again");
                    return;
                }             
            }

            currentUser.LastLogin = DateTime.Now;
            users.Add(currentUser);
        }
    }
}
