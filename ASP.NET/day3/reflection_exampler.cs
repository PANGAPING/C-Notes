using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];

            parameters[0] = "WeiHao";
            parameters[1] = "Deng";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("The result is " + fullName);


        }
    }


    public class Customer {
        string GetFullName(string firstName, string lastName) {
            return firstName + lastName;
        }

    }
}
