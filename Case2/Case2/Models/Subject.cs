namespace Case2.Models;

public class Subject : ISubject
{
    public string Name { get; set; }
    public Person Teacher { get; set; }    
    public Person[] Students { get; set; }
    public Subject(string name, Person teacher, Person[] students)
    {
        Name = name;
        Teacher = teacher;
        Students = students;
    }

    public void addStudent(Person student)
    {
        var students = Students;
        Array.Resize(ref students, Students.Length + 1);
        Students[^1] = student;
    }
}