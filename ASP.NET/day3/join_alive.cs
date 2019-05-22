using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{


    delegate void ThreadFinishedCallback(int num);
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main has started!!");

            Thread Worker1 = new Thread(Function1);
            Thread Worker2 = new Thread(Function2);

            Worker1.Start();
            Worker2.Start();


            //Judge if thread has finished in passin millsecond.
            if (Worker1.Join(1000))
            {
                Console.WriteLine("Thread1 has finished in 1 second.");
            }
            else {
                Console.WriteLine("Thread1 has not finished in 1 second.");
            }



            //Wait for worker's finish.
            Worker2.Join();


            if (Worker1.IsAlive) {
                Console.WriteLine("Worker1 is still working!!");
            }



            Console.WriteLine("Main has finished!!");
        }


        private static void Function1() {
            Console.WriteLine("Function1 has started!!");
            Thread.Sleep(5000);
        }

        private static void Function2() {
            Console.WriteLine("Function2 has started!!");
        }


    }

    
}
