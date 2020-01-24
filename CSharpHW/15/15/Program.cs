// Создайте консольное приложение.С помощью обобщенных типов реализуйте двухсвязный список.Поддерживаемые операции:
// - добавление элемента 
// - удаление элемента
// - узнать кол-во элементов 
// - проверка наличия элемента в списке 
// - ToArray

using System;

namespace _15
{
    class Program
    {
        static void Main()
        {
            //instantiate new List of ints
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            //create new list elements
            ListElement<int> element1 = new ListElement<int>(1);
            ListElement<int> element2 = new ListElement<int>(2);
            ListElement<int> element3 = new ListElement<int>(3);
            ListElement<int> element4 = new ListElement<int>(4);

            //add elements to the list
            list.AddElementToTheList(element1);
            list.AddElementToTheList(element2);
            list.AddElementToTheList(element3);
            list.AddElementToTheList(element4);

            //check if element is in the list
            list.PrintElementSearchResult(3);
            list.PrintElementSearchResult(5);

            //get element count
            list.GetListElementCount();

            //delete element from list by data
            list.DeleteElementFromTheList(3);
            list.DeleteElementFromTheList(5);

            //Convery list to array
            var array = list.ConvertListToArray();
        }
    }

    public class ListElement<T>
    {
        public T Data { get; set; }

        public ListElement<T> Previous { get; set; }
        public ListElement<T> Next { get; set; }

        public ListElement(T data)
        {
            Data = data;
        }
    }

    public class DoublyLinkedList<T>
    {
        ListElement<T> head;
        ListElement<T> tail;
        public int Count = 0;

        public void AddElementToTheList(ListElement<T> listElement)
        {

            if (head == null)
            {
                head = listElement;
            }
            else if (tail == null)
            {
                tail = listElement;
                listElement.Previous = head;
                head.Next = listElement;
            }
            else
            {
                tail.Next = listElement;
                listElement.Previous = tail;
                tail = listElement;
            }
            Count++;
        }

        public ListElement<T> FindElementInTheList(T data)
        {
            ListElement<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            return current;
        }

        public void PrintElementSearchResult(T data)
        {
            ListElement<T> current = FindElementInTheList(data);
            if (current == null)
            {
                Console.WriteLine("Element not Found");
            }
            else
                Console.WriteLine("Element Found");
        }

        public void DeleteElementFromTheList(T data)
        {
            ListElement<T> current = FindElementInTheList(data);

            if (current != null)
            {
                if (current.Previous == null)
                {
                    head = current.Next;
                    head.Previous = null;
                }
                else if (current.Next == null)
                {
                    tail = current.Previous;
                    tail.Next = null;
                }
                else
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                }
                Count--;
            }
            else
            {
                Console.WriteLine("Element not Found. Can't Delete.");
            }
        }

        public ListElement<T>[] ConvertListToArray()
        {
            ListElement<T>[] array = new ListElement<T>[Count];
            ListElement<T> current = head;
            while (current != null)
            {
                for (int i = 0; i < Count; i++)
                {
                    array[i] = current;
                    current = current.Next;
                }
            }
            return array;
        }

        public int GetListElementCount()
        {
            return Count;
        }
    }
}
