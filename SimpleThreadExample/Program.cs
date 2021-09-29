using System;
using System.Threading;

namespace SimpleThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a current thread
            Thread t = Thread.CurrentThread;

            //set a name of t thread
            t.Name = "Main Thread";

            //print the name of thread
            Console.WriteLine(t.Name);


        }
    }
}
