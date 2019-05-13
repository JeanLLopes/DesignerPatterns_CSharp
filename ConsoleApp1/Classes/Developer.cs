using ConsoleApp1.Interface;
using System;

namespace ConsoleApp1.Classes
{
    class Developer : IInterviewer
    {
        public void AskQuestion()
        {
            Console.WriteLine("Ask Developer...");
        }
    }
}
