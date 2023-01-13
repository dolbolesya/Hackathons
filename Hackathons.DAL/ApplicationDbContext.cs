using Hackathons.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Hackathons.DAL;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer(@"Server=WIN-4CRJ2VRDGKE\\SQLEXPRESS;Database=Hackathons;Trusted_Connection=True;MultipleActiveResultSets=true");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        
    }

    DbSet<User>? Users { get; set; }
    
}