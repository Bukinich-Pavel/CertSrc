using QRCoder;
using Domain.Interfaces;
using Domain.Models;
using Domain.Types;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json;

namespace Domain.Services
{
    public class QRCoderCertificate : IQRCoderCertificate
    {
        public byte[] GetCertificate(CertFormParams formData)
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

            var fileBytes = GenerateQRCode(json);
            return fileBytes;
        }

        private byte[] GenerateQRCode(string url)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentException("URL cannot be empty.");

            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);

            byte[] qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }
}
