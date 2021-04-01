using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

using static System.Console;

namespace WorkingWithNetworkResources
{
    class Program
    {
        static void Main(string[] args)
        {
            var exited = false;
            while (!exited)
            {
                Write("Enter a valid web address: ");
                string url = ReadLine();
                if (string.IsNullOrWhiteSpace(url))
                {
                    url = "https://ggkttd.by";
                }
                try
                {
                    var uri = new Uri(url);
                    WriteLine($"URL: {url}");
                    WriteLine($"Scheme: {uri.Scheme}");
                    WriteLine($"Port: {uri.Port}");
                    WriteLine($"Host: {uri.Host}");
                    WriteLine($"Path: {uri.AbsolutePath}");
                    WriteLine($"Query: {uri.Query}");

                    var entry = Dns.GetHostEntry(uri.Host);
                    WriteLine("{0} has the following IP addresses:",
                    arg0: entry.HostName);
                    entry
                        .AddressList
                        .ToList()
                        .ForEach(address => WriteLine(address));

                    // pinging host
                    var ping = new Ping();
                    WriteLine("Pinging server. Please wait...");
                    var reply = ping.Send(uri.Host);

                    Write("{0} was pinged and replied: ", arg0: uri.Host);

                    if (reply.Status == IPStatus.Success)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        WriteLine(reply.Status);
                        Console.ForegroundColor = ConsoleColor.White;
                        WriteLine("Reply from {0} took {1:N0}ms",
                        arg0: reply.Address,
                        arg1: reply.RoundtripTime);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        WriteLine(reply.Status);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch (UriFormatException ex)
                {
                    WriteLine(ex.Message, ex.StackTrace);
                }
                catch (SocketException ex)
                {
                    WriteLine(ex.Message, ex.StackTrace);
                }
                catch (PingException ex)
                {
                    WriteLine(ex.Message, ex.StackTrace);
                }
                WriteLine("----------------");
                WriteLine("Press any key to continue or CTRL+C to exit...\n");
                ReadKey();
            }
        }
    }
}
