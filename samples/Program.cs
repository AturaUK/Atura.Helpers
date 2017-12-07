using System;

namespace Samples
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");

            var myClass = new MyClass();

            myClass.MyMethod("hello"); // does not throw

            myClass.MyMethod(null); // throws
        }
    }
}