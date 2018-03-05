using System;
using System.Reflection;

namespace ReflectionInCSharp
{
    class Program
    {

        public static void PrintMembers(MemberInfo[] ms)
        {
            foreach (MemberInfo m in ms)
            {
                Console.WriteLine("{0}{1}","    ",m);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            //Using GetType to obtain type information
            int i = 42;
            var type = i.GetType();
            Console.WriteLine(type);

            //Using reflection to get information from an Assembly
            Assembly info = typeof(System.Int32).Assembly;
            Console.WriteLine(info);
            Console.WriteLine();

            //Getting type objects from a loaded assembly
            Assembly a = typeof(object).Module.Assembly;
            Console.WriteLine(a);
            Console.WriteLine();

            //Listing all the public constructors of the System.String class.
            Type t = typeof(System.String);
            Console.WriteLine("Listing all the public constructors of the {0} type",t);

            //Constructors
            ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("//Constructors");

            PrintMembers(ci);
            Console.WriteLine();

            Console.WriteLine("\nReflection.MemberInfo");

            //Gets the Type and MemberInfo
            Type myType = Type.GetType("System.IO.File");

            ////Gets and displays the DeclaratingType method.
            //Console.WriteLine("\nThere are {0} members in {1}.",myType.Module,myType.FullName);


        }
    }
}
