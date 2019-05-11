using System;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread process1 = new Thread(() =>
            {
                TestSingleton("Foo");
            });

            Thread process2 = new Thread(() =>
            {
                TestSingleton("Bar");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            Console.ReadKey();
        }

        private static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetIntance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
