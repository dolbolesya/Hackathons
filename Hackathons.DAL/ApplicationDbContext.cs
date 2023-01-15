using Hackathons.Domain.Events;
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
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        
    }

    public DbSet<User>? Users { get; set; }
    public DbSet<Event>? Events { get; set; }

}