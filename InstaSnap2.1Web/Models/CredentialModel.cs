using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace InstaSnapWeb.Data.Models
{
    public class CredentialModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Handle { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Remember Me")]
        public bool PersistentCookie { get; set; } = false;

        [Required]
        public UserDataModel UserData { get; set; }

        public string HashPassword(string password)
        {
            SHA256 hash = SHA256.Create();
            var passwordBytes = Encoding.Default.GetBytes(password);

            hash.ComputeHash(passwordBytes);

            var hashedPass = hash.ComputeHash(passwordBytes);

            return Convert.ToHexString(hashedPass);
        }
    }

}
