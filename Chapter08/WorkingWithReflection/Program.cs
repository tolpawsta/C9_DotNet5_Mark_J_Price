using System;
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

            ReadLine();
        }
    }
}
