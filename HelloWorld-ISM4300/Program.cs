//
// Simple Console Program to print a message to the user and wait for key input from the user before terminating.
// Author: Ettienne Voges
//
//
using System;

namespace HelloWorld_ISM4300
{
    class Program
    {
        static void Main(string[] args)
        {
            // Notify the user that he/she need to press any key to continue.
            Console.WriteLine("Press any key to continue..");

            // Print the "Hello World!" message            
            Console.WriteLine("Hello World!");

            // Wait for a key pressed by the user by sending true for intercept argument of ReadKey function.
            Console.ReadKey(true);
        }
    }
}
