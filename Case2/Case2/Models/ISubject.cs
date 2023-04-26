namespace Case2.Models;

public interface ISubject
{
   string Name { get; }
   Person Teacher { get; }
   Person[] Students { get; }
   void addStudent(Person student);
}