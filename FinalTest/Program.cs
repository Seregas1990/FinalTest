using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult[] people = new Adult[2]
            {
                new Child
                {
                    FirstName = "Dante",
                    LastName = "Sierkov"
                },
                new Adult
                {
                    FirstName = "Serhii",
                    LastName = "Sierkov"
                }
            };
            foreach (var human in people)
            {
                Console.WriteLine($"First Name: {human.FirstName}  Last Name: {human.LastName} Type of record: {human.GetType().Name}");
            }
        }
    }
}
