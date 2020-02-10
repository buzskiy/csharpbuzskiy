//1. Используя solution Iterator в папке Demo\01_Iterator создайте обобщенную версию этого шаблона.

using System;

namespace Iterator
{
    class MainApp
    {
        static void Main()
        {
            ConcreteAggregate<int?> a = new ConcreteAggregate<int?>();
            a[0] = 123;
            a[1] = 234;
            a[2] = 345;
            a[3] = 456;

            ConcreteIterator<int?> i = new ConcreteIterator<int?>(a);

            Console.WriteLine("Iterating over collection:");

            var item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}