using System;
using System.Collections.Generic;

namespace Packt.Shared.Providers
{
    public class PersonProvider
    {
        public static IEnumerable<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person()
                {
                    Name = "Павел Толочко",
                    DateOfBirth = new DateTime(1984, 09, 07),
                    Gender = Gender.Man
                },
                new Person()
                {
                    Name = "Наталья Толочко",
                    DateOfBirth = new DateTime(1986, 12, 02),
                    Gender = Gender.Woman
                },
                new Person()
                {
                    Name = "Мария Толочко",
                    DateOfBirth = new DateTime(2007, 12, 06),
                    Gender = Gender.Girl
                },
                new Person()
                {
                    Name = "Елизавета Толочко",
                    DateOfBirth = new DateTime(2014, 06, 16),
                    Gender = Gender.Girl
                },
                new Person()
                {
                    Name = "Михаил Толочко",
                    DateOfBirth = new DateTime(2020, 11, 17),
                    Gender = Gender.Boy
                }
            };
        }
    }
}
