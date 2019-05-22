//The preprocessor instruction is the
//operation before compile.
//So If you plan to product two versions of
//prodection,it may be useful.

#define PI 
using System;
namespace PreprocessorDAppl
{
   class Program
   {
      static void Main(string[] args)
      {
         #if (PI)
            Console.WriteLine("PI is defined");
         #else
            Console.WriteLine("PI is not defined");
         #endif
         Console.ReadKey();
      }
   }
}