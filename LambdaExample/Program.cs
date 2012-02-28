using System;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidNoParams(() => Console.WriteLine("Hello World"));
            VoidIntParam(number => DemoObject.WriteNumber(number), 16);
            Console.WriteLine(StringNoParam(() => { return "Hello World"; }));
            Console.WriteLine(StringIntParam(intParam => { return "Number is " + intParam; }, 28));

            Console.ReadLine();
        }

        static void VoidNoParams(Action action)
        {
            action();
        }

        static void VoidIntParam(Action<int> action, int param)
        {
            action(param);
        }

        static string StringNoParam(Func<string> func)
        {
            return func();
        }

        static string StringIntParam(Func<int, string> func, int param)
        {
            return func(param);
        }

        private static class DemoObject
        {
            public static void WriteNumber(int number)
            {
                Console.WriteLine("Number is: " + number);
            }
        }
    }
}
