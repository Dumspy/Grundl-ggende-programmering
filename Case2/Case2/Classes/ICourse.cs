using Case2.Models;

namespace Case2.Classes;

public class ICourse
{
    string Name { get; }
    Person Teacher { get; }
    Person[] Students { get; }
}