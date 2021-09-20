using System;

namespace Csharp
{
    //public record Person(string FirstName, string LastName);
    public record Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; init; }
        public string LastName { get; init; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
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
