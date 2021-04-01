﻿using System;
using System.Net;

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
                url = "https//:world/episerver.com/cms/&q=pagetype";
            }
            var uri = new URI(url);
            WriteLine($"URL: {url}");
            WriteLine($"Scheme: {uri.Scheme}");
            WriteLine($"Port: {uri.Port}");
            WriteLine($"Host: {uri.Host}");
            WriteLine($"Path: {uri.AbsolutePath}");
            WriteLine($"Query: {uri.Query}");
        }
    }
}