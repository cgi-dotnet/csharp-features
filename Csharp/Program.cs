using System;

namespace Csharp
{
    public record Person(string FirstName, string LastName)
    {
        public string? MiddleName { get; init; }
        public Person With(
    string? firstName = null,
    string? lastName = null,
    string? middleName = null)
        {
            return new Person(
                firstName != null ? firstName : this.FirstName,
                lastName != null ? lastName : this.LastName)
            {
                MiddleName = middleName != null ? middleName : this.MiddleName
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("John", "Doe");
            //Person modifiedPerson = person.With(middleName: "Patrick");
            Person modifiedPerson = person with
            {
                MiddleName = "Patrick"
            };
            Console.WriteLine($"Hello World! {modifiedPerson.MiddleName}");
        }
    }
}
