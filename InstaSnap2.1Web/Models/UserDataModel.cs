using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Xml.Linq;

namespace InstaSnapWeb.Data.Models
{
    public class UserDataModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Handle { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 

        public string Bio { get; set; } = string.Empty;

        // same as PostModel
        public string ProfileImg { get; set; } = string.Empty;

        [NotMapped]
        [Display(Name="Profile Picture")]
        public IFormFile ImageFile { get; set; }


        public CredentialModel UserCredentials { get; set; }

        public int UserCredentialsId { get; set; }
    }
}
