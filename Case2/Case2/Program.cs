// See https://aka.ms/new-console-template for more information

using Case2.Enums;
using Case2.Classes;
using Case2.Models;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<H1DataSet>()
    .AddTransient<SearchHandler>(sp => new SearchHandler(sp.GetService<H1DataSet>()!))
    .BuildServiceProvider();

while (true)
{
    SearchTerms selectedItem = SearchTerms.None;
    SearchTerms[] searchTerms = ((SearchTerms[])Enum.GetValues(typeof(SearchTerms))).Skip(1).ToArray();
    int currentItem = 0;

    while (selectedItem == SearchTerms.None)
    {
        Console.Clear();
        Console.WriteLine("TEC søgemaskine for H1");
        Console.WriteLine("Tast pil op/ned for at vælge søgekategori og tryk enter for at vælge");
        Console.WriteLine("Søg efter:");
        for (int i = 0; i < searchTerms.Length; i++)
        {
            Console.WriteLine($"{(i == currentItem ? "> " : "  ")}{searchTerms[i]}");
        }

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.UpArrow:
                currentItem = currentItem == 0 ? searchTerms.Length - 1 : currentItem - 1;
                break;
            case ConsoleKey.DownArrow:
                currentItem = currentItem == searchTerms.Length - 1 ? 0 : currentItem + 1;
                break;
            case ConsoleKey.Enter:
                selectedItem = searchTerms[currentItem];
                break;
        }
    }

    Console.Clear();
    Console.WriteLine($"Søg efter {selectedItem}");
    Console.Write(selectedItem is SearchTerms.Elev or SearchTerms.Lærer ? "Indtast fulde navn:" : "Indtast fagnavn:");

    string searchTerm = Console.ReadLine()!;
    Console.Clear();

    var searchHandler = serviceProvider.GetService<SearchHandler>()!;
    switch (selectedItem)
    {
        case SearchTerms.Elev:
            Person? student = searchHandler.FindStudent(searchTerm);
            if (student is null)
            {
                Console.WriteLine("Ingen elev fundet");
                break;
            }

            PrintStudent(student);
            break;
        case SearchTerms.Lærer:
            Person? teacher = searchHandler.FindTeacher(searchTerm);
            if (teacher is null)
            {
                Console.WriteLine("Ingen lære fundet");
                break;
            }

            PrintTeacher(teacher);
            break;
        case SearchTerms.Fag:
            Subject? subject = searchHandler.FindSubject(searchTerm);
            if (subject is null)
            {
                Console.WriteLine("Intet fag fundet");
                break;
            }

            PrintSubject(subject);
            break;
    }

    Console.ReadKey();
}

void PrintStudent(Person student)
{
    Console.WriteLine($"Elev: {student.FullName}");
    foreach (var subject in student.GetSubjects())
    {
        Console.WriteLine($" {subject.Name}:");
        Console.WriteLine($"    Lære: {subject.Teacher.FullName}");
    }
}

void PrintTeacher(Person teacher)
{
    Console.WriteLine($"Lære: {teacher.FullName}");
    foreach (var subject in teacher.GetSubjects())
    {
        Console.WriteLine($" {subject.Name}");
        Person[] students = subject.GetStudents();
        Console.WriteLine($"    Elever: {students.Length}");
        foreach (var student in students)
        {
            Console.WriteLine($"     {student.FullName}");
        }
    } 
}

void PrintSubject(Subject subject)
{
    Console.WriteLine($"Fag: {subject.Name}");
    Console.WriteLine($" Lære: {subject.Teacher.FullName}");
    Person[] students = subject.GetStudents();
    Console.WriteLine($"    Elever: {students.Length}");
    foreach (var student in students)
    {
        Console.WriteLine($"     {student.FullName}");
    }
}
