using System;

Console.WriteLine("Please enter a word or letter to search for:");
string searchTerm = Console.ReadLine();

while (true)
    Console.ReadLine();
if (string.IsNullOrWhiteSpace(searchTerm))
{
    Console.WriteLine("You did not enter a valid number");
}
else
{
    Console.WriteLine($"You entered: {searchTerm}");
}