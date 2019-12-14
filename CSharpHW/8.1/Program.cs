//1. В консольном приложении продемностририруйте копирование значимого и ссылочного типа(Реализуйте метод клонирования).
//   Используйте User с произвольным набором полей как ссылочный / значимый тип.

using System;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            User Alex = new User(29, "Alex");
            User refAlex = Alex;
            Console.WriteLine(Alex.Age + " " + refAlex.Age);
            Alex.Age = 25;
            Console.WriteLine(Alex.Age + " " + refAlex.Age);

            UserAsValue Alex2 = new UserAsValue(18, "Ivan");
            UserAsValue valueAlex = Alex2;
            Console.WriteLine(Alex2.Age + " " + valueAlex.Age);
            Alex2.Age = 99;
            Console.WriteLine(Alex2.Age + " " + valueAlex.Age);

        }
    }

    public class User
    {
        public int Age;
        public string Name;

        public User(int age, string name)
        {
            Age = age;
            Name = name;
        }

    }

    public struct UserAsValue
    {
        public int Age;
        public string Name;

        public UserAsValue(int age, string name)
        {
            Age = age;
            Name = name;
        }


    }

}
