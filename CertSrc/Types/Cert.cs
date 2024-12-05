namespace CertSrc.Types
{
    public class CertFormParams
    {
        public required string Count { get; set; }
        public required DateTime Date { get; set; }
    }

    public class CertFormData: CertFormParams
    {
        public required string JwtToken { get; set; }
    }
}
