using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            bool result = myClass.CheckArgument(args);

            if (result)
            {
                Console.WriteLine("Arguments passed.");
            }
            else
            {
                Console.WriteLine("Argument not passed.");
            }
        }
    }
}
