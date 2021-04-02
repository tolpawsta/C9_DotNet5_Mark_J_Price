using System;
using System.Linq;
using System.Reflection;
using WorkingWithReflection.Shared;

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

            // Types
            WriteLine($"** Types");
            var types = assemley.GetTypes();
            types.ToList().ForEach(t => WriteLine(t.FullName));

            WriteLine("*************************");

            // Members
            WriteLine($"*** Members");
            var members = types.SelectMany(t => t.GetMembers()).ToList();
            members
                .ForEach(member =>
                    WriteLine("{0}: {1} ({2})",
                    arg0: member.MemberType,
                    arg1: member.Name,
                    arg2: member.DeclaringType.Name));

            // Coders
            WriteLine("*************************");
            var coders =
                members
                    .SelectMany(member =>
                        member.GetCustomAttributes<CoderAttribute>())
                    .OrderByDescending(coder => coder.LastModified)
                    .ToList();
            coders
                .ForEach(coder =>
                    WriteLine("Modified by {0} on {1}",
                    arg0: coder.Coder,
                    arg1: coder.LastModified.ToShortDateString()));
            ReadLine();
        }

        [Coder("tolpawsta", "02.04.2021")]
        [Coder("Thomas Anderson", "03.04.2009")]
        public static void DoStuff()
        {
        }
    }
}
