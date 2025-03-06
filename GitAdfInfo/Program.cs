// See https://aka.ms/new-console-template for more information
using GitAdfInfo.Services;

Console.WriteLine("ADF INFO");

var service = new NumberService();
var result = service.CalculateNumbers([1, 2, 3, 4, 5]);
Console.WriteLine($"Sum: {result.Sum}");
