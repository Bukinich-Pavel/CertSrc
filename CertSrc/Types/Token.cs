using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CertSrc.Types
{
    public class Token
    {
        /// <summary>
        /// название организации
        /// </summary>
        public const string NAME_ORG = "Массажный салон";

        /// <summary>
        /// название клиента
        /// </summary>
        public const string NAME_CLIENT = "Массажный салон";

        /// <summary>
        /// цена сертификата
        /// </summary>
        public const string COUNT = "10000";

        /// <summary>
        /// ключ для шифрации
        /// </summary>
        const string KEY = "mysupersecret_secretsecretsecretkey!123";

        /// <summary>
        /// токен
        /// </summary>
        /// <returns></returns>
        public static SymmetricSecurityKey GetSymmetricSecurityKey() => new(Encoding.UTF8.GetBytes(KEY));
    }
}
