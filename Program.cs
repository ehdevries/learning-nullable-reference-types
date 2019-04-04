using System;

namespace NullableReferenceTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = PersonStore.GetFirstPerson();

            int letterCount =
                p.FirstName.Length +
                p.MiddleName.Length +
                p.LastName.Length;

            Console.WriteLine($"Hello, {p.FirstName} {p.MiddleName} {p.LastName}");
            Console.WriteLine($"You have {letterCount} letters in your name");
        }
    }

    class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
    }

    class PersonStore
    {
        public static Person GetFirstPerson()
            => new Person { FirstName = "Pat", MiddleName = "Q", LastName = "McTest" };
    }
}
