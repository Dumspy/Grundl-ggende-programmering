namespace Case2.Models;

public class Person : IPerson
{
    public string FirstName { get; }
    public string LastName { get; }
    public Subject[] Subjects { get; }
    
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Subjects = Array.Empty<Subject>();
    }
    public void addSubject(Subject subject)
    {
        var subjects = Subjects;
        Array.Resize(ref subjects, Subjects.Length + 1);
        Subjects[^1] = subject;
    }
}