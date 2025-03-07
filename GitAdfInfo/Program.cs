// See https://aka.ms/new-console-template for more information
using GitAdfInfo.Services;

Console.WriteLine("ADF INFO");

var service = new NumberService();
var result = service.CalculateNumbers([1, 2, 3, 4, 5]);
Console.WriteLine($"Sum: {result.Sum}");

var orderedNumbers = service.OrderNumbers([5, 4, 3, 2, 1]);
Console.WriteLine($"Ordered numbers:");
foreach (var item in orderedNumbers)
{
    Console.WriteLine(item);
}
