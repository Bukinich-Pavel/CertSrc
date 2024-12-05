using Microsoft.AspNetCore.Mvc;
using CertificateLibrary;
using CertSrc.Types;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;

namespace CertSrc.Controllers
{
    [ApiController]
    [Route("cert/[action]")]
    public class CertController(Certificate cert) : ControllerBase
    {
        readonly Certificate certificate = cert;

        [HttpPost]
        [ActionName(name: "get")]
        public IActionResult Get([FromBody] CertFormParams formData)
        {
            var jwt = new JwtSecurityToken(
                issuer: Token.NAME_ORG,
                audience: Token.NAME_CLIENT,
                //claims: claims,
                //expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
                signingCredentials: new SigningCredentials(Token.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            var certFormData = new CertFormData()
            {
                Count = formData.Count,
                Date = formData.Date,
                JwtToken = new JwtSecurityTokenHandler().WriteToken(jwt)
            };

            string json = JsonSerializer.Serialize(certFormData);

            var fileBytes = certificate.GenerateQRCode(json);
            return File(fileBytes, "image/jpeg");
        }
    }
}
