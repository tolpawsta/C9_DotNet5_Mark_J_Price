using System.Security.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using PacktLibrary9;
using PacktLibrary9.Records;
using Packt.Shared;
using Packt.Shared.Providers;
using PeopleApp.Views;

using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new AppView();
            RunPersonsDemo(view);
            RunBankAccountDemo(view);
            RunTurplesDemo();
            RunSwitchDemoWithPasenger(view);
            RunRecordsDemo();
        }

        private static void RunRecordsDemo()
        {
            // work with records
            var pavel =
                new ImmutablePerson
                {
                    FirstName = "Pavel",
                    LastName = "Talochka"
                };
            //init exception, Has to intialize when object create
            // pavel.FirstName = "Michail";

            var car = new ImmutableVehicle
            {
                Brand = "BMW",
                Color = "Soul Red Crystal Metallic",
                Wheels = 4
            };
            // cloning object
            var repaintingCar = car with { Color = "Pink" };

            WriteLine("Original color of the car is {0}, new color is {1}",
            arg0: car.Color,
            arg1:repaintingCar.Color);

            // immutable animal example

            var oscar=new ImmutableAnimal("Oscar","Labrador");
            var (who,what) =oscar;
            WriteLine("{0} is a {1}.",
            arg0: who,
            arg1: what);
        }

        private static void RunSwitchDemoWithPasenger(AppView view)
        {
            // switch with passenger exapmle
            var passengers = FlightPatternsProvider.GetFlightPassengers();
            view.Show(passengers);
        }

        private static void RunTurplesDemo()
        {
            // turple example
            WriteLine($"Turple example");
            var fruit = GetFruit();
            WriteLine("There are {0} {1}",
            arg0: fruit.Item1,
            arg1: fruit.Item2);

            // example named turple
            WriteLine($"Example named turple");
            var namedFruit = GetNamedFruit();
            WriteLine("There are {0} {1}",
            arg0: namedFruit.Name,
            arg1: namedFruit.Number);
        }

        private static void RunBankAccountDemo(AppView view)
        {
            BankAccount.InterestRate = 0.012M;
            var accounts = BankAccountProvider.GetBankAccounts();
            view.Show(accounts);
        }

        private static void RunPersonsDemo(AppView view)
        {
            var persons = PersonProvider.GetPersons();
            view.Show(persons);
        }

        private static (string Name, int Number) GetNamedFruit()
        {
            var name = "Apples";
            var number = 14;
            return (Name: name, Number: number);
        }

        private static (string, int) GetFruit()
        {
            return ("Apples", 5);
        }
    }
}
