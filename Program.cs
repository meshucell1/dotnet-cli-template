using System;

namespace DotnetCliStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from .NET CLI Starter!");
            Console.WriteLine("This is a simple console application.");

            if (args.Length > 0)
            {
                Console.WriteLine($"Argument provided: {args[0]}");
            }
            else
            {
                Console.WriteLine("No arguments provided. Run with --help for usage.");
            }
        }
    }
}