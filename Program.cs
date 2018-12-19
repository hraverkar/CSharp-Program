using System;

namespace ConsoleApplication10
{
    // Delegate are type safe and the function pointer means pointing the function which have
    // same return type and same type of parameter ..........
    
    public delegate void HelloFunctionDelegate(string Message);
    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var helloFunctionDelegate = new HelloFunctionDelegate(Hello);
            helloFunctionDelegate("Hello Harshal Raverkar How Are you");
        }

        private static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}