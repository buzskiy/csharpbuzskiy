//1. Создайте консольное приложение.
//   Напишите метод который обаратывает массив целочисленных значений
//   размерностью 10001 елементов.
//   Все значения кроме одного хранятся парное количество раз.
//   Необходимо найти единственное неповторяющееся значение массива наиболее оптимальным образом.

using System;


namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 10001;
            int[] array = new int[n];
            int j;

            Console.WriteLine($"Enter single value from 1 to {n - 1}");
            int k = Convert.ToInt32(Console.ReadLine());

            for (j=0; j<=n/2-1; j++)
            {
                array[j] = j;
                array[j+n/2] = j;
            }

            Random rand = new Random();
            int randomIndex = rand.Next(array.Length);
            Console.WriteLine("Random index is " + randomIndex);
            int randomElement = array[randomIndex];
            Console.WriteLine("Random Element is " + randomElement);

            array[randomIndex] = k;
            array[n - 1] = randomElement;

            Console.WriteLine("Array elements list:");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.WriteLine(array[5]);
            Console.WriteLine(array[6]);
            Console.WriteLine(array[7]);
            Console.WriteLine(array[8]);
            Console.WriteLine(array[9]);
            Console.WriteLine(array[10]);


            int res = array[0];
            for (int i = 0; i < array.Length; i++)
                res ^= array[i];

            Console.WriteLine("Non-Repeatable Element is " + res);
        }
    }
}
