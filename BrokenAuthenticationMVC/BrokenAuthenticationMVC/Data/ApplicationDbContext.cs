using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BrokenAuthenticationMVC.Models;

namespace BrokenAuthenticationMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BrokenAuthenticationMVC.Models.Todo> Todo { get; set; } = default!;
    }
}