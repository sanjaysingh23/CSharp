// See https://aka.ms/new-console-template for more information

using System;
namespace GenericDemo
{
    //  where T : struct  constraint ensures that the types used with the Add method are value types,
    //  and therefore, it restricts the usage to types that support addition.
    class Generic<T> where T : struct
    {
        public T add(T o1, T o2)
        {
            return (dynamic)o1 + (dynamic)o2;
        }
    }
    class Demo1
    {
        public static void Main(string[] args)
        {
            Generic<int> passInt = new Generic<int>();
            Console.WriteLine(passInt.add(10, 20));

            Generic<float> passFloat = new Generic<float>();
            Console.WriteLine(passFloat.add(10.6f, 20.6f));

            //   if we use refrence type then we use class in place of struct
            //Generic<string> passString = new Generic<string>();
            //Console.WriteLine(passString.add("abc", "xyz"));
        }
    }
}
