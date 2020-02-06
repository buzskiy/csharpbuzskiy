/*1. Создайте консольное приложение.В отдельных проектах создайте свои реализации следующих коллекций:
   Queue<T>
   Stack<T>
   Dictionary<TKey, TValue>
   Продемонстрируйте работу с коллекциями.
   */

using System;

namespace _16
{
    class Program
    {
        static void Main()
        {
            //create new queue/stack elements
            Element<int> element1 = new Element<int>(1);
            Element<int> element2 = new Element<int>(2);
            Element<int> element3 = new Element<int>(3);
            Element<int> element4 = new Element<int>(4);

            //dictionary operations demo
            Dictionary<object> dictionary = new Dictionary<object>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");

            dictionary.Remove(1);
            dictionary.Remove(3);

            //stack operations demo
            Stack<int> stack = new Stack<int>();
            //add element 
            stack.Push(element1);
            stack.Push(element2);
            stack.Push(element3);
            stack.Push(element4);

            //delete element
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            //return first element
            stack.Peek();

            //Queue operations demo
            Queue<int> queue = new Queue<int>();
            //add element
            queue.Enqueue(element1);
            queue.Enqueue(element2);
            queue.Enqueue(element3);
            queue.Enqueue(element4);

            //remove element
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            //return first element
            queue.Peek();

            Console.WriteLine("End of program");
        }
    }
}


public class Element<T>
{
    public T Data { get; set; }

    public Element<T> Next { get; set; }

    public Element(T data)
    {
        Data = data;
    }
}
