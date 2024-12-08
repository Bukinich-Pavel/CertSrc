using Domain.Models.Auth;
using Repository.Models;

namespace Domain.Interfaces
{
    public interface IAuthorization
    {
        public User? Login(LoginParams loginParams);
        public bool Registration(LoginParams loginParams);
    }
}