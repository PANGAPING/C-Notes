using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{



    class Program
    {
        static void Main(string[] args)
        {
            doSomethingAsyn();
        }

        

        static async void doSomethingAsyn() {
            Task<int> task = new Task<int>(getNumber);

            task.Start();

            Console.WriteLine("Processing data.");

            int count = await task;

            Console.WriteLine("The result is"+task);

        }

        static int getNumber() {
            return 9;
        }
    }
}
