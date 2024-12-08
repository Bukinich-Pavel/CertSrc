using Domain.Interfaces;
using Domain.Models.Auth;
using Repository.Interfaces;
using Repository.Models;

namespace Domain.Services
{
    public class Authorization(IUsers users) : IAuthorization
    {
        public User? Login(LoginParams loginParams) => users.GetUser(loginParams.Name, loginParams.Password);
        public bool Registration(LoginParams loginParams) => users.CreateUser(loginParams.Name, loginParams.Password);
    }
}