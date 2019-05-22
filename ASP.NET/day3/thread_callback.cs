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
            //1

            //Console.WriteLine("Please enter the target number");

            //object target = Console.ReadLine();

            //ParameterizedThreadStart parameterizedthreadStart = new ParameterizedThreadStart(Number.PrintNumbers);

            //Thread T = new Thread(parameterizedthreadStart);
            //T.Start(target);


            //2

            ThreadFinishedCallback callback = new ThreadFinishedCallback(delegate (int x) { Console.WriteLine("Something finished!!"); });


            Number newNumber = new Number(2,callback);

            ThreadStart threadStart = new ThreadStart(newNumber.PrintNumbers);

            Thread thread = new Thread(threadStart);

            thread.Start();

        }
    }

    class Number {

        int _target;

        ThreadFinishedCallback Callback;

        public Number(int target,ThreadFinishedCallback callback) {

            this._target = target;

            Callback = callback;
        }

        public void PrintNumbers() {

            Console.Write(_target);

            Callback(_target);
        }


        //1


        //public static void PrintNumbers(object obj) {
        //    int number = 0;
        //    if (int.TryParse(obj.ToString(), out number)) {
        //        Console.Write(number);
        //    }
        //}
    }
}
