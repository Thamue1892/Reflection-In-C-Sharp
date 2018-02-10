using System;
using System.Reflection;

namespace ReflectionInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Using GetType to obtain type information
            int i = 42;
            var type = i.GetType();
            Console.WriteLine(type);

            //Using reflection to get information from an Assembly
            Assembly info = typeof(System.Int32).Assembly;
            Console.WriteLine(info);
        }
    }
}
