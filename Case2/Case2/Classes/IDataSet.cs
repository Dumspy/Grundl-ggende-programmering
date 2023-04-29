using Case2.Models;

namespace Case2.Classes;

public interface IDataSet
{
    Person[] GetTeachers();

    Person[] GetStudents();


    Subject[] GetSubjects();

}