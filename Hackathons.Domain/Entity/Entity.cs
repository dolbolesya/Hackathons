using Hackathons.Domain.Interface;

namespace Hackathons.Domain.Entity;

public class Entity : IEntity
{
    public int Id { get; set; }
    
    public string? FullName { get; set; }
    
    public int Age { get; set; }
    
    public string? Status { get; set; }
    
    public string? CompanyName { get; set; }

    public int Reputation { get; set; }
}

