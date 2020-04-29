using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("p1");
            ConcretePrototype1 clonedP1 = (ConcretePrototype1)p1.Clone();

            Console.WriteLine(clonedP1.Id);
            Console.WriteLine(p1.Equals(clonedP1));

            ConcretePrototype2 p2 = new ConcretePrototype2("p2");
            ConcretePrototype2 clonedP2 = (ConcretePrototype2)p2.Clone();
            
            Console.WriteLine(clonedP2.Id);
            Console.WriteLine(p2.Equals(clonedP2));

            Console.Read();
        }
    }
}
