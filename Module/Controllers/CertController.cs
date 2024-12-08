using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.Models;

namespace CertSrc.Controllers
{
    [ApiController]
    [Route("cert/[action]")]
    public class CertController(IQRCoderCertificate certificate) : ControllerBase
    {
        readonly IQRCoderCertificate _certificate = certificate;

        [HttpPost]
        [ActionName(name: "get")]
        public IActionResult Get([FromBody] CertFormParams formData)
        {
            var fileBytes = _certificate.GetCertificate(formData);
            return File(fileBytes, "image/jpeg");
        }
    }
}
