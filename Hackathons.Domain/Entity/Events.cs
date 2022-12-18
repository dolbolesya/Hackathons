using Hackathons.Domain.Enums;

namespace Hackathons.Domain.Entity;

public class Events
{
    public int Id { get; init; }
    public string? Title { get; set; }
    public string? Descroption { get; set; }
    public EventType EventType { get; set; }
    public List<Users> Members { get; set; }
    public DateTime StartEvent { get; set; }
    public DateTime StopEvent { get; set; }
}