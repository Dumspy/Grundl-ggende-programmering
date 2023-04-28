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
            new Person("Alexander Mathias", "Thamdrup"),
            new Person("Allan", "Gawron"),
            new Person("Andreas Carl", "Balle"),
            new Person("Darab", "Hagnazar"),
            new Person("Felix Enok", "Berger"),
            new Person("Jamie Jamahl de la Sencerie" ,"El-Dessouky"),
            new Person("Jeppe Carlseng", "Pedersen"),
            new Person("Joseph", "Holland-Hale"),
            new Person("Kamil Marcin", "Kulpa"),
            new Person("Loke Emil", "Bendtsen"),
            new Person("Mark Hyrsting", "Larsen"),
            new Person("Niklas Kim", "Jensen"),
            new Person("Rasmus Peter", "Hjorth"),
            new Person("Sammy", "Damiri"),
            new Person("Thomas Mose", "Holmberg"),
            new Person("Tobias Casanas", "Besser"),
            new Person("Tobias Kofoed", "Larsen"),
        };
        
        Subjects = new Subject[]
        {
            new Subject
            (
                "Studieteknik",
                Teachers[0],
                new Person[] { Students[0], Students[1], Students[2], Students[3], Students[4], Students[5], Students[6], Students[7], Students[8], Students[9], Students[10], Students[11], Students[12], Students[13], Students[14] }
            ),
            new Subject
            (
                "Grundlæggende programmering",
                Teachers[0],
                new Person[] { Students[0], Students[1], Students[2], Students[3], Students[4], Students[5], Students[6], Students[7], Students[8], Students[9], Students[10], Students[11], Students[12], Students[13], Students[14], Students[15], Students[16] }
            ),
            new Subject
            (
            "Database programmering",
            Teachers[0],
            new Person[] { Students[0], Students[1], Students[2], Students[3], Students[4], Students[5], Students[6], Students[7], Students[8], Students[9], Students[10], Students[11], Students[12], Students[13], Students[14], Students[15], Students[16] }
            ),
            new Subject
            (
                "OOP",
                Teachers[1],
                new Person[] { Students[0], Students[1], Students[2], Students[3], Students[4], Students[5], Students[6], Students[7], Students[8], Students[9], Students[10], Students[11], Students[12], Students[13], Students[14], Students[15], Students[16] }
            ),
            new Subject
            (
                "Computerteknologi",
                Teachers[0],
                new Person[] { Students[0], Students[1], Students[2], Students[3], Students[4], Students[5], Students[6], Students[7], Students[8], Students[9], Students[10], Students[11], Students[12], Students[13], Students[14], Students[15], Students[16] }
            ),
            new Subject
            (
                "Clientside programmering",
                Teachers[2],
                new Person[] { Students[0], Students[1], Students[2], Students[3], Students[4], Students[5], Students[6], Students[7], Students[8], Students[9], Students[10], Students[11], Students[12], Students[13], Students[14], Students[15], Students[16] }
            ),
            new Subject
            (
                "Netværk",
                Teachers[3],
                new Person[] { Students[0], Students[1], Students[2], Students[3], Students[4], Students[5], Students[6], Students[7], Students[8], Students[9], Students[10], Students[11], Students[12], Students[13], Students[14], Students[15], Students[16] }
            )
            
        };

        foreach (var subject in Subjects)
        {
            foreach (var student in subject.GetStudents())
            {
                student.addSubject(subject);
            }
            subject.Teacher.addSubject(subject);
        }
    }

    public Person[] GetTeachers()
    {
        return Teachers;
    }
    
    public Person[] GetStudents()
    {
        return Students;
    }
    
    public Subject[] GetSubjects()
    {
        return Subjects;
    }
}