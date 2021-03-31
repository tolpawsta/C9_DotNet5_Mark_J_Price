using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace PacktLibrary.Shared
{
    public class Person
    {
        // Fields
        public string Name;

        public DateTime DateOfBirth;

        public List<Person> Children;

        public EventHandler Shout;

        public int AngleLevel;

        // Constructor
        public Person()
        {
            Children = new List<Person>();
        }

        // Methods
        public void Poke()
        {
            AngleLevel++;
            if (AngleLevel >= 3)
            {
                Shout?.Invoke(this, EventCommandEventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return $"Name is {this.Name}\nDate of birth is {this.DateOfBirth}";
        }
    }
}
