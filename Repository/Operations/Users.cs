using System.Diagnostics;
using Repository.Data;
using Repository.Interfaces;
using Repository.Models;

namespace Repository.Operations
{
    public class Users : IUsers
    {
        public bool CreateUser(string name, string password)
        {
            try
            {
                using var context = new ApplicationContext();
                var user = new User { Name = name, Password = password };
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public User? GetUser(string name, string password)
        {
            try
            {
                using var context = new ApplicationContext();
                var user = context.Users.Where(u => u.Name == name && u.Password == password).ToList();
                if (user != null && user.Count > 0) return user[0];
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}