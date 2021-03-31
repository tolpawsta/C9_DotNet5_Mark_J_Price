using System;

namespace Packt.Shared
{
    public class Person : System.Object
    {
        public readonly string HomePlanet = "Earth";

        public readonly DateTime Instantiated;

        public string Name;

        public DateTime DateOfBirth;

        public Gender Gender;

        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
    }
}
