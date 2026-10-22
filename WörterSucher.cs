using System;

Console.WriteLine("Please enter a word or letter to search for:");
string searchTerm = Console.ReadLine();

if (string.IsNullOrWhiteSpace(searchTerm))
{
    Console.WriteLine("You did not enter a valid word or letter.");
}
else
{
    Console.WriteLine($"You entered: {searchTerm}");

    Console.WriteLine("\nSearching for results...");
}
