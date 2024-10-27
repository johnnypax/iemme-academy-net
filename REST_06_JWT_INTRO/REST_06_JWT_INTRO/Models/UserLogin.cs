using System.Text.Json.Serialization;

namespace REST_06_JWT_INTRO.Models
{
    public class UserLogin
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        [JsonIgnore]
        public string? UserType { get; set; }       // ADMIN | USER
    }
}
