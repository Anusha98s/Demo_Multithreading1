
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;namespace Demo_Multithreading1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Multitasking using Multithreading in c#");
            MyClass History = new MyClass();
            Console.WriteLine("Main thread starts......");
            History.Display(); ThreadStart th1 = History.Display; Thread s1 = new Thread(th1); s1.Start();
            Console.WriteLine("Main thread ends here!!!!");
            Console.ReadKey();
        }
    }
}


