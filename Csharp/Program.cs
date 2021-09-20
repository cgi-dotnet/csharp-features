using System;

namespace Csharp
{
    public record Person(string FirstName, string LastName);
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("John", "Doe");
            (var firstName, var lastName) = person;
            Console.WriteLine($"Hello World! {lastName}");
        }
    }
}
