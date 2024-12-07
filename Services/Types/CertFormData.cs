namespace Service.Types
{
    public class CertFormData
    {
        public required string Count { get; set; }
        public required DateTime Date { get; set; }
        public required string JwtToken { get; set; }
    }
}
