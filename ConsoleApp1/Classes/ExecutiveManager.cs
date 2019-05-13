using ConsoleApp1.Interface;

namespace ConsoleApp1.Classes
{
    class ExecutiveManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Executive();
        }
    }
}
