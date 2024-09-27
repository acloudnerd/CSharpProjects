using System;

namespace HelloWorldApp{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Welcome to my first C# project!");
            
            Console.Write("What's your name? ");
            string? name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Hope you're having a great day!");
        }
    }
}