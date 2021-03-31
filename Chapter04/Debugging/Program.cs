using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;

using static System.Console;
using System.IO;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {

            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.Listeners.Add(new TextWriterTraceListener(new StreamWriter("log.txt")));
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("createrLog.txt")));
            Trace.AutoFlush = true;
            List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 7, 10, 7, 8 };
            var count = 0;
            foreach (var number in numbers)
            {
                count++;
                Trace.WriteLine(number);
            }
        }        
    }
}
