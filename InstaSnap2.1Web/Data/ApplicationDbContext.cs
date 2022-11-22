using InstaSnapWeb.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InstaSnapWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CredentialModel> Credentials { get; set; }
        public DbSet<UserDataModel> UserData { get; set; } 
    }
}
