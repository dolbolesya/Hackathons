using Hackathons.Domain.Events;
using Hackathons.Domain.Users;

namespace Hackathons.Domain.Companyes;

public class Company
{
    public int Id { get; init; }
    public string? CompanyName { get; set; }
    public DateTime RegisterDate { get; init; } 
    public List<Event>? EventsList { get; set; }
    public List<User>? Headship { get; set; }
    public List<User>? Employees { get; set; }
    public int Reputation { get; set; }
}