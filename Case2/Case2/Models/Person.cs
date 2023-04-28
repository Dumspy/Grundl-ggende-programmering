namespace Case2.Models;

public class Person : IPerson
{
    public string FirstName { get; }
    public string LastName { get; }
    private Subject[] Subjects;
    
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
        subjects[subjects.Length - 1] = subject;
        Subjects = subjects;
    }
    public Subject[] GetSubjects()
    {
        return Subjects;
    }
}