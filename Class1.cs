
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;namespace Demo_Multithreading1
{
    class MyClass
    {
        public void Display()
        {
            Console.WriteLine("Implementing a thread1"); for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("\n {0}", i);
            }
            Console.WriteLine("Thread1 closes");
        }
    }
}

