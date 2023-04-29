namespace Case2.Models;

public interface IPerson
{
    string FirstName { get; }
    string LastName { get; }
    void AddSubject(Subject subject);
}