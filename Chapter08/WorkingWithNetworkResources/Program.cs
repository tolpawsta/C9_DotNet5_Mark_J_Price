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
            var exited=false;
            while (not exited)
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

                // pinging host
                var ping = new Ping();
                WriteLine("Pinging server. Please wait...");
                var reply = ping.Send(uri.Host);

                WriteLine($"{uri.Host} was pinged and replied: {reply.Status}");
                if (reply.Status == IPStatus.Success)
                {
                    WriteLine("Reply from {0} took {1:N0}ms",
                    arg0: reply.Address,
                    arg1: reply.RoundtripTime);
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
            ReadLine(); 
            }
            
        }
    }
}
