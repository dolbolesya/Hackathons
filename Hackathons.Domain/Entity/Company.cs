namespace Hackathons.Domain.Entity;

public class Company
{
    public int Id { get; init; }
    public string? CompanyName { get; set; }
    public DateTime RegisterDate { get; init; } 
    public List<Events>? EventsList { get; set; }
    public List<Users>? Headship { get; set; }
    public List<Users>? Employees { get; set; }
    public int Reputation { get; set; }
}