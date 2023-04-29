using Case2.Models;

namespace Case2.Classes;

public interface ISearchHandler
{
    Person? FindStudent(string fullName);
    Person? FindTeacher(string fullName); 
    Subject? FindSubject(string subjectName);
}