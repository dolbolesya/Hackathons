namespace Hackathons.Domain.Interface;

public interface IEntity
{
     // user id
     // 0,1,2,3...
     int Id { get; set; }
     
     // user fullname 
     // John Doe, James Bond
     string FullName { get; set; }
     // user age
     // 18, 25
     int Age { get; set; }

     // studen, worker, dev, etc
     string? Status { get; set; }
     
     // National University, College, Google ink...
     string? CompanyName { get; set; }
     
     // HR, Student, SEO, etc
     //string? JobTitle { get; set; }
     
     // rep + or rep -
     int Reputation { get; set; }
}