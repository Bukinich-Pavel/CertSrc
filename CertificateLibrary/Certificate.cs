using QRCoder;

namespace CertificateLibrary
{
    public class Certificate
    {
        public byte[] GenerateQRCode(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL cannot be empty.");
            }

            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);

            byte[] qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }
}
