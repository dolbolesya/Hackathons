using Hackathons.Domain.Enums;
using Hackathons.Domain.Users;

namespace Hackathons.Domain.Events;

public class Event
{
    public int Id { get; init; }
    public string? Title { get; set; }
    public string? Descroption { get; set; }
    public EventType EventType { get; set; }
    public List<User>? Members { get; set; }
    public DateTime StartEvent { get; set; }
    public DateTime StopEvent { get; set; }
}