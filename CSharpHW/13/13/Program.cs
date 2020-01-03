//Создайте консольное приложение.Постойте иерархию наследования ResourceHolderBase, ResourceHolderDerived. Реализуйте IDisposable для каждого из них.
//Продемонстрируйте вызов Dispose каждого из них.Реализуйте деструктор, убедитесь что ресурсы будут освободжены если деструктор отработает ранее,
//убедитесь что повторый вызов Dispose не вызывает исключительные ситуации.
   

using System;

namespace _13
{
    class Program
    {
        static void Main()
        {
            using (ResourceHolderBase n1 = new ResourceHolderBase())
            {
            }
            using (ResourceHolderDerived n2 = new ResourceHolderDerived())
            {
            }
            ResourceHolderBase n3 = new ResourceHolderBase();
            n3.Dispose();
            GC.SuppressFinalize(n3);
            ResourceHolderDerived n4 = new ResourceHolderDerived();
            n4.Dispose();
            GC.SuppressFinalize(n4);
            Console.WriteLine("End of program");
            



        }
    }

    public class ResourceHolderBase : IDisposable
    {
        public ResourceHolderBase()
        {
            Console.WriteLine("Object being created");
        }

        public void Dispose()
        {
            Console.WriteLine("Object being disposed");
        }

        ~ResourceHolderBase()
        {
            Console.WriteLine("Object being finalized");
            Dispose();
        }

    }

    public class ResourceHolderDerived : ResourceHolderBase, IDisposable
    {

        public new void Dispose()
        {
            Console.WriteLine("Derived Object being disposed");
        }
    }
}
