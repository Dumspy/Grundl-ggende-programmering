namespace Case2.Models;

public interface ISubject
{
   string Name { get; }
   Person Teacher { get; }
   void AddStudent(Person student);
}