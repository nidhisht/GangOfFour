using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.Log("Before Hello World!");
            Console.WriteLine("Hello World!");
            Logger.Instance.Log("After Hello World!");
            Console.Read();
        }
    }
}
