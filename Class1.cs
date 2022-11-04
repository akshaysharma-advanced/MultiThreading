using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_Assignment
{
    //Creating ThreadClass 
    internal class ThreadClass
    {
        //Create static string array
        static string[] fruits = { "Apple", "Banana", "Mango", "Orange" };
        //Create static char array
        static char[] codes = { 'S', 'R', 'J', 'X' };

        //static Print method
        public static void Print()
        {

            for (int index = 0; index < 4; index++)
            {
                //Print Numbers
                Console.WriteLine("Print Method is printing : " + index);
                //add delay of 2 sec when i = 2
                if (index == 3)
                {
                    Thread.Sleep(2000);
                }
            }
        }

        public static void Display()
        {
            //print all value in fruits array
            foreach (string fruit in fruits)
            {
                //when fruit==orange add delay of 4 sec
                if (fruit == "Orange")
                {
                    Thread.Sleep(4000);
                }
                Console.WriteLine("Display method is displaying : " + fruit);
            }
        }

        public static void Show()
        {
            //print all value of in codes array
            foreach (char code in codes)
            {
                Console.WriteLine("Show method is showing : " + code);
            }
        }

    }
}