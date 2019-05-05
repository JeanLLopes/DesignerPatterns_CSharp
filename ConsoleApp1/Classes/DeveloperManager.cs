using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Classes
{
    class DeveloperManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }
}
