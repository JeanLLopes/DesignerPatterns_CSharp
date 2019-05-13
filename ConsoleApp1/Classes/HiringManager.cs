using ConsoleApp1.Interface;

namespace ConsoleApp1.Classes
{
    abstract class HiringManager
    {
        abstract protected IInterviewer MakeInterviewer();
        public void TakeInterview()
        {
            var interviewer = this.MakeInterviewer();
            interviewer.AskQuestion();
        }
    }
}
