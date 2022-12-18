using Hackathons.Domain.Enums;

namespace Hackathons.Domain.Entity;

public class Users
{
    public int Id { get; init; }
    public string? Fullname { get; set; }
    public string? Username { get; set; }
    public Role Role { get; set; }
    public DateTime BirthDate { get; set; } 
    public DateTime RegisterDate { get; init; } 
    public int Reputation { get; set; }
}