using System.ComponentModel.DataAnnotations;

namespace Hackathons.Domain.Enum;

public enum Role
{
    Guest,
    User,
    EventMaker,
    Moderator,
    Admin
}