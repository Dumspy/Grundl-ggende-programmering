// See https://aka.ms/new-console-template for more information

using Case2.Classes;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<H1DataSet>()
    .BuildServiceProvider();
    
var service = serviceProvider.GetService<H1DataSet>()!;

public enum SearchTerms
{
    Lærer,
    Elev,
    Fag
}