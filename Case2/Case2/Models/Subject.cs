namespace Case2.Models;

public class Subject : ISubject
{
    public string Name { get; set; }
    public Person Teacher { get; set; }
    
    private Person[] Students;
    public Subject(string name, Person teacher, Person[] students)
    {
        Name = name;
        Teacher = teacher;
        Students = students;
    }
    
    public void addStudent(Person student)
    {
        var students = Students;
        Array.Resize(ref students, students.Length + 1);
        students[students.Length - 1] = student;
        Students = students;
    }
    
    public Person[] GetStudents()
    {
        return Students;
    }
}