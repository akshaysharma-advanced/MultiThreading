using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling method in single threading 
            //ThreadClass.Print();
            //ThreadClass.Display();
            //ThreadClass.Show();

            Console.WriteLine("------------------------Main Thread----------------------------");

            //Creating Thread for all the methods in ThreadClass 
            Thread printThread = new Thread(ThreadClass.Print);
            Thread displayThread = new Thread(ThreadClass.Display);
            Thread showThread = new Thread(ThreadClass.Show);

            //displayThread don't wait for printThread to execute it start its execution both run simultaneously 
            printThread.Start();

            Thread.Sleep(1000);

            //suspend thread temporarily
            printThread.Suspend();

            //sleep for 6 sec
            Thread.Sleep(6000);

            //resume printThread again
            printThread.Resume();

            //Using Join on Thread means pausing the calling thread untill the execution of thread is finished on which join is called
            printThread.Join();

            //wait untill printThread finished its execution
            displayThread.Start();

            Thread.Sleep(1000);

            //suspend thread temporarily
            displayThread.Suspend();

            //resume printThread again
            displayThread.Resume();

            showThread.Start();
        }
    }
}