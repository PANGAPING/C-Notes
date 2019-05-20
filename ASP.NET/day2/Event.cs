using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new MyEvent(5);
            e.SetValue(10);

            //generate the event handler
            e.ChangeNum += new MyEvent.NumManipulationHandler(MyEvent.EventFired);

            e.SetValue(200);

            Console.ReadLine();
        }
    }


    class MyEvent
    {
        private int value;


        // delegate
        public delegate void NumManipulationHandler();

        //The method recommoned.
        public delegate void ChangedEventhandler(object sender, EventArgs e);


        //Set the event
        public event NumManipulationHandler ChangeNum;

        public MyEvent(int n)
        {
            SetValue(n);
        }

        public static void EventFired()
        {
            Console.WriteLine("Binded Event fired");
        }

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Event fired!");
            }
        }


        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }
}
