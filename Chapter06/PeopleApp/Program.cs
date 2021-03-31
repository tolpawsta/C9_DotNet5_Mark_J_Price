using System;
using System.Security.AccessControl;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using PacktLibrary;
using PacktLibrary.Shared;

using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // demo benchmark
            /*
            var summary =
                BenchmarkRunner
                    .Run<DemoBench>(DefaultConfig
                        .Instance
                        .AddJob(Job.Default.WithRuntime(CoreRuntime.Core50)));
            */
            // Casting examples
            Employee aliceInEmployee =
                new Employee() { Name = "Alice", Company = "Microsoft" };
            Person aliceInPerson = aliceInEmployee;
            Animal jackDog = new Animal() { Name = "Jack" };
            if (aliceInPerson is Employee aliceCustToEmployee)
            {
                WriteLine (aliceInEmployee);
                WriteLine (aliceCustToEmployee);
            }
            if (aliceInPerson is not Employee)
            {
                WriteLine (jackDog);
            }
        }
    }
}
