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
        builder.UseSqlServer("DefaultConnection");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        
    }
}