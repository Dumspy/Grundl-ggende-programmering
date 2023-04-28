// See https://aka.ms/new-console-template for more information

using Case2.Classes;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<H1DataSet>()
    .BuildServiceProvider();
    
var service = serviceProvider.GetService<H1DataSet>()!;

SearchTerms selectedItem = SearchTerms.None;
SearchTerms[] searchTerms = ((SearchTerms[])Enum.GetValues(typeof(SearchTerms))).Skip(1).ToArray();
int currentItem = 0;
while (selectedItem == SearchTerms.None)
{
    Console.Clear();
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

Console.WriteLine(selectedItem);

public enum SearchTerms
{
    None,
    Lærer,
    Elev,
    Fag
}