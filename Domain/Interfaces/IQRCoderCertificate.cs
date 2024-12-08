using Domain.Models;

namespace Domain.Interfaces
{
    public interface IQRCoderCertificate
    {
        public byte[] GetCertificate(CertFormParams formData);
    }
}