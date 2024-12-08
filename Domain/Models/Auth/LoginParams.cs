namespace Domain.Models.Auth
{
    public class LoginParams
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
    }
}