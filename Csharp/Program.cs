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
            var person1 = new Person("John", "Doe");
            var person2 = new Person("John", "Doe");
            var areEqual = person1.Equals(person2); // = false
//In contrast to that, records implement value equality which means that two instances are treated
//as equal if all of their properties are equal(that’s how structs behave):

            var person1 = new Person("John", "Doe");
            var person2 = new Person("John", "Doe");
            var areEqual = person1.Equals(person2); // = true
        }
    }
}
