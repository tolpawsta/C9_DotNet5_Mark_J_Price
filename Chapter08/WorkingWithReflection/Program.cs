using System;
using System.Linq;
using System.Reflection;

using static System.Console;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Assemley metadata: ");
            var assemley = Assembly.GetEntryAssembly();

            WriteLine($"Full name: {assemley.FullName}");
            WriteLine($" Location: {assemley.Location}");

            var attributes = assemley.GetCustomAttributes();
            attributes.ToList().ForEach(a => WriteLine($" {a.GetType()}"));

            var version =
                assemley
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>(
                    );
            WriteLine($"Version: {version.InformationalVersion}");
            var company =
                assemley.GetCustomAttribute<AssemblyCompanyAttribute>();
            WriteLine($"Company: {company.Company}");
            // ReadLine();
        }
    }
}
