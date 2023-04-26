using Case2.Models;

namespace Case2.Classes;

public class H1DataSet : ICourse
{
    private Person[] Teachers;
    private Person[] Students;
    private Subject[] Subjects;
    
    public H1DataSet()
    {
        Teachers = new Person[]
        {
            new Person("Niels", "Olesen"),
            new Person("Flemming", "Sørensen"),
            new Person("Peter Suni", "Lindenskov"),
            new Person("Henrik Vincents", "Poulsen")
        };
        
        Students = new Person[]
        {
            new Person("John", "Doe"),
            new Person("Jane", "Doe")
        };
        
        Subjects = new Subject[]
        {
            new Subject
            (
                "Math",
                Teachers[0],
                new Person[] { Students[0], Students[1] }
            ),
            new Subject
            (
                "English",
                Teachers[1],
                new Person[] { Students[0], Students[1] }
            )
        };

        foreach (var subject in Subjects)
        {
            foreach (var student in subject.Students)
            {
                student.addSubject(subject);
            }
            subject.Teacher.addSubject(subject);
        }
    }
}