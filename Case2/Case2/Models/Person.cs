namespace Case2.Models;

public class Person : IPerson
{
    public string FirstName { get; }
    public string LastName { get; }
    
    public string FullName => $"{FirstName} {LastName}";
    private Subject[] _subjects;
    
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        _subjects = Array.Empty<Subject>();
    }
    public void AddSubject(Subject subject)
    {
        var subjects = _subjects;
        Array.Resize(ref subjects, _subjects.Length + 1);
        subjects[subjects.Length - 1] = subject;
        _subjects = subjects;
    }
    public Subject[] GetSubjects()
    {
        return _subjects;
    }
}