using Case2.Enums;
using Case2.Models;

namespace Case2.Classes;

public class SearchHandler : ISearchHandler
{
    private readonly IDataSet _dataSet;
    
    public SearchHandler(IDataSet dataSet)
    {
        _dataSet = dataSet;   
    }

    public Person? FindTeacher(string fullName)
    {
        return _dataSet.GetTeachers().FirstOrDefault(teacher => string.Equals(teacher.FullName, fullName, StringComparison.CurrentCultureIgnoreCase));
    }

    public Person? FindStudent(string fullName)
    {
        return _dataSet.GetStudents().FirstOrDefault(student => string.Equals(student.FullName, fullName, StringComparison.CurrentCultureIgnoreCase));
    }
    
    public Subject? FindSubject(string subjectName)
    {
        return _dataSet.GetSubjects().FirstOrDefault(subject => string.Equals(subject.Name, subjectName, StringComparison.CurrentCultureIgnoreCase));
    }
}