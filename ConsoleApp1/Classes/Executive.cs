using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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
