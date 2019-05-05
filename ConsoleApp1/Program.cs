using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var developer = new DeveloperManager();
            developer.TakeInterview();

            var executive = new ExecutiveManager();
            executive.TakeInterview();

            Console.ReadKey();
        }
    }
}
