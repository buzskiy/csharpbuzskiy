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
            Console.WriteLine("Initializing array.. \n");
            string[] test = new string[0];
            string input = "";
            string searchInput = "";

            do
            {
                Console.WriteLine("Please enter value to add to array:");
                input = Console.ReadLine();
                test = ArrayOperations.AddElement(test, input);
                Console.WriteLine("Array elements are:");
                foreach (string i in test)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");
            }
            while (input != "q");

            do 
            {
                Console.WriteLine("Please enter value to search by:");
                searchInput = Console.ReadLine();
                ArrayOperations.ContainsElement(test, searchInput);
            }
            while (searchInput != "q");

        }
    }


    public class ArrayOperations
    {


        public static string[] AddElement(string[] array, string element)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.GetUpperBound(0)] = element;
            return array;
        }

        public static void ContainsElement(string[] array, string searchInput)
        {
            foreach (string element in array)
            {
                if (element == searchInput)
                {
                    Console.WriteLine("Element Exists");
                    break;
                }
                else
                {
                    Console.WriteLine("Element Does Not Exist");
                    break;
                }
            }
            
        }

        public void GetByIndex()
        {
            //test.GetValue()
        }
    }
}
