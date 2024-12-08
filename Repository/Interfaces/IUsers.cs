using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.Interfaces
{
    public interface IUsers
    {
        public bool CreateUser(string name, string password);
        public User? GetUser(string name, string password);
    }
}