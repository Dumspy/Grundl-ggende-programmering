namespace Case2.Models;

public class Subject : ISubject
{
    public string Name { get; set; }
    public Person Teacher { get; set; }
    
    private Person[] _students;
    public Subject(string name, Person teacher, Person[] students)
    {
        Name = name;
        Teacher = teacher;
        _students = students;
    }
    
    public void AddStudent(Person student)
    {
        var students = _students;
        Array.Resize(ref students, students.Length + 1);
        students[students.Length - 1] = student;
        _students = students;
    }
    
    public Person[] GetStudents()
    {
        return _students;
    }
}