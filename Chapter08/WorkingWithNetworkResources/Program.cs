using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

using static System.Console;

namespace WorkingWithNetworkResources
{
    class Program
    {
        static void Main(string[] args)
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
                WriteLine($"{entry.HostName} has the following IP addresses:");
                entry
                    .AddressList
                    .ToList()
                    .ForEach(address => WriteLine(address));
            }
            catch (UriFormatException ex)
            {
                WriteLine(ex.Message, ex.StackTrace);
            }
            catch (SocketException ex)
            {
                WriteLine(ex.Message, ex.StackTrace);
            }
        }
    }
}
