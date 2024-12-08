using Domain.Interfaces;
using Domain.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace CertSrc.Controllers
{
    [ApiController]
    [Route("auth/[action]")]
    public class AuthController(IAuthorization authorization) : ControllerBase
    {
        [HttpPost]
        [ActionName(name: "login")]
        public bool Login(LoginParams loginParams)
        {
            var user = authorization.Login(loginParams);
            return user != null;
        }

        [HttpPost]
        [ActionName(name: "regis")]
        public bool Registration(LoginParams loginParams) => authorization.Registration(loginParams);

    }
}