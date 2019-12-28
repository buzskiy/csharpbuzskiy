//3. Создайте консольное приложение.Создайте класс обертку над массивом позволяющий добавлять
//  неограниченное количество елементов во внутренний массив и получение елемента по индексу.
//  Реализуйте метод проверки наличия елемента. (методы Add, Contains, GetByIndex)

using System;

namespace _10._2
{
    class Program
    {
        static void Main()
        {
            //initializing object
            ArrayOperations testarray = new ArrayOperations();

            //testing method AddElement
            testarray.AddElement("value 1");
            testarray.AddElement("value 2");
            Console.WriteLine("Checking values have been successfully added");
            Console.WriteLine(testarray.array[0]);
            Console.WriteLine(testarray.array[1]);

            //testing whether array contains element
            Console.WriteLine("Should be True:");
            Console.WriteLine(testarray.ContainsElement("value 1"));
            Console.WriteLine("Should be False:");
            Console.WriteLine(testarray.ContainsElement("fsff"));
            Console.WriteLine("Should be True:");
            Console.WriteLine(testarray.ContainsElement("value 2"));

            //getting element by index
            Console.WriteLine("Should be 'value 1'");
            Console.WriteLine(testarray.GetElementByIndex(0));
            Console.WriteLine("Should be 'value 2'");
            Console.WriteLine(testarray.GetElementByIndex(1));


        }
    }


    public class ArrayOperations
    {
        public string [] array = new string [0];
        public string arrayElement;
        public string searchInput;
        public string indexInput;
        public bool exists;

        public string[] AddElement(string addelement)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.GetUpperBound(0)] = addelement;
            return array;
        }

        public bool ContainsElement(string searchInput)
        {
            foreach (string element in array)
            {
                exists = false;
                if (searchInput == element)
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        public string GetElementByIndex(int indexInput)
        {
                return array[indexInput];
        }
    }
}