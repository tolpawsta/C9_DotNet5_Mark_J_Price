using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using Packt.Shared;
using PacktLibrary9;
using static System.Console;

namespace PeopleApp.Views
{
    public class AppView
    {
        public void Show(IEnumerable<Person> incomingPersons)
        {
            foreach (var person in incomingPersons)
            {
                Show (person);
            }
        }

        public void Show(Person person)
        {
            WriteLine("{0} был(а) рожден(а) в {1:dddd, d MMMM yyyy} - пол : {2}",
            arg0: person.Name,
            arg1: person.DateOfBirth,
            arg2: person.Gender);
            WriteLine("Объект {0} находящийся на планете {1} был создан в {2:hh:mm:ss} {2:dddd}",
            arg0: person.Name,
            arg1: person.HomePlanet,
            arg2: person.Instantiated);
        }

        public void Show(IEnumerable<BankAccount> bankAccounts)
        {
            bankAccounts.ToList().ForEach(Show);
        }

        public void Show(BankAccount bankAccount)
        {
            WriteLine("{0} earned {1:C} interest.",
            arg0: bankAccount.AccountName,
            arg1: bankAccount.Balance * BankAccount.InterestRate);
        }

        public void Show(object[] passengers)
        {
            foreach (var passenger in passengers)
            {
                var flightCost = passenger switch
                {
                    FirstClassPassenger p => p.AirMiles switch{
                        > 35000=>1500M,
                        > 15000=>1750M,
                        _       => 2000M
                    },
                    BusinessClassPassenger=>1000M,
                    CoachClassPassenger p=> p.CarryOnKG switch{
                        < 10.0=>500M,
                        _=>650M
                    },
                    _=>800M
                };
                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }
        }
    }
}
