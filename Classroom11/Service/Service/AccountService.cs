using Domain.Models;
using System;
using System.Linq;

namespace Service.Service
{
    public class AccountService
    {
        private User[] users; 
        public AccountService()
        {
            users = AllUser();
        }

        public User[] AllUser()
        {
            User user1 = new User
            {
                Id = 1,
                FullName = "Javad Bakirli",
                Password = "password123@",
                Age = 32,
                Email = "javad@gmail.com"
            };

            User user2 = new User
            {
                Id = 2,
                FullName = "Elshan Ahmedov",
                Password = "password123",
                Age = 30,
                Email = "elshan@gmail.com"
            };

            User user3 = new User
            {
                Id = 3,
                FullName = "Togrul Mammadov",
                Password = "password123@123",
                Age = 25,
                Email = "togrul@gmail.com"
            };
            return new User[] { user1, user2, user3 };
        }

        public bool Login(string email, string password)
        {
            User user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user != null;
        }
    }
}
