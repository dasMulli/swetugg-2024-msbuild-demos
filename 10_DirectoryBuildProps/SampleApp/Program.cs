﻿using System;
using System.Reflection;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = typeof(Program).Assembly;
            Console.WriteLine($"This is sample app version {assembly.GetName().Version} by {assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company}.");
            
            var unused = "something";
        }
    }
}
