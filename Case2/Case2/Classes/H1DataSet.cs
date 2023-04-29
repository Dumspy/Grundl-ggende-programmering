using Case2.Models;

namespace Case2.Classes;

public class H1DataSet : IDataSet
{
    private readonly Person[] _teachers;
    private readonly Person[] _students;
    private readonly Subject[] _subjects;
    
    public H1DataSet()
    {
        _teachers = new Person[]
        {
            new Person("Niels", "Olesen"),
            new Person("Flemming", "Sørensen"),
            new Person("Peter Suni", "Lindenskov"),
            new Person("Henrik Vincents", "Poulsen")
        };
        
        _students = new Person[]
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
        
        _subjects = new Subject[]
        {
            new Subject
            (
                "Studieteknik",
                _teachers[0],
                new Person[] { _students[0], _students[1], _students[2], _students[3], _students[4], _students[5], _students[6], _students[7], _students[8], _students[9], _students[10], _students[11], _students[12], _students[13], _students[14] }
            ),
            new Subject
            (
                "Grundlæggende programmering",
                _teachers[0],
                new Person[] { _students[0], _students[1], _students[2], _students[3], _students[4], _students[5], _students[6], _students[7], _students[8], _students[9], _students[10], _students[11], _students[12], _students[13], _students[14], _students[15], _students[16] }
            ),
            new Subject
            (
            "Database programmering",
            _teachers[0],
            new Person[] { _students[0], _students[1], _students[2], _students[3], _students[4], _students[5], _students[6], _students[7], _students[8], _students[9], _students[10], _students[11], _students[12], _students[13], _students[14], _students[15], _students[16] }
            ),
            new Subject
            (
                "OOP",
                _teachers[1],
                new Person[] { _students[0], _students[1], _students[2], _students[3], _students[4], _students[5], _students[6], _students[7], _students[8], _students[9], _students[10], _students[11], _students[12], _students[13], _students[14], _students[15], _students[16] }
            ),
            new Subject
            (
                "Computerteknologi",
                _teachers[0],
                new Person[] { _students[0], _students[1], _students[2], _students[3], _students[4], _students[5], _students[6], _students[7], _students[8], _students[9], _students[10], _students[11], _students[12], _students[13], _students[14], _students[15], _students[16] }
            ),
            new Subject
            (
                "Clientside programmering",
                _teachers[2],
                new Person[] { _students[0], _students[1], _students[2], _students[3], _students[4], _students[5], _students[6], _students[7], _students[8], _students[9], _students[10], _students[11], _students[12], _students[13], _students[14], _students[15], _students[16] }
            ),
            new Subject
            (
                "Netværk",
                _teachers[3],
                new Person[] { _students[0], _students[1], _students[2], _students[3], _students[4], _students[5], _students[6], _students[7], _students[8], _students[9], _students[10], _students[11], _students[12], _students[13], _students[14], _students[15], _students[16] }
            )
            
        };

        foreach (var subject in _subjects)
        {
            foreach (var student in subject.GetStudents())
            {
                student.AddSubject(subject);
            }
            subject.Teacher.AddSubject(subject);
        }
    }

    public Person[] GetTeachers()
    {
        return _teachers;
    }
    
    public Person[] GetStudents()
    {
        return _students;
    }
    
    public Subject[] GetSubjects()
    {
        return _subjects;
    }
}