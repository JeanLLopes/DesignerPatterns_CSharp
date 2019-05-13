using ConsoleApp1.Interface;
using System;

namespace ConsoleApp1.Classes
{
    class Executive : IInterviewer
    {
        public void AskQuestion()
        {
            Console.WriteLine("Ask Executive");
        }
    }
}
