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

        static int num = 0;

        static void Main(string[] args)
        {

            Stopwatch stopwatch = Stopwatch.StartNew();

            Thread thread1 = new Thread(AddOneMillion);

            Thread thread2 = new Thread(AddOneMillion);

            Thread thread3 = new Thread(AddOneMillion);

            thread1.Start();thread2.Start();thread3.Start();


            thread1.Join();thread2.Join();thread3.Join();



            stopwatch.Stop();

            Console.WriteLine("The num now is "+ num);

            Console.WriteLine("The all time =" + stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }


        static Object obj = new Object();

        public static void AddOneMillion() {
            //for (int i = 0; i < 1000000; i++) {
            //  num++;
            //}


            //method 1 slower

            //for(int i=0;i < 100000; i++) {
            //    lock (obj)
            //    {
            //        num++;
            //    }
            //}

            for (int i = 0; i < 100000; i++) {
                Interlocked.Increment(ref num);
            }


        }


    }

    
}
