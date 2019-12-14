/**Создайте консольное приложение. Создайте класс Human. 
   Клас должен содержать следующие свойства: BirthDate, FirstName, Lastame, Age.
   Свойство Age должно быть только для чтения. Класс Human должен иметь несколько конструкторов.
   Класс должен иметь метод проверяющий текущий екземпляр на еквивалентность с другим. */

using System;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Human Borys = new Human("Borys", "Ivanov");
            Human Borys2 = new Human ("Borys", "Ivanov", 27);
            var equalitycheck = Borys.HumanEqual(Borys2);
            Console.WriteLine(equalitycheck);
        }
    }

    class Human
    {
        private readonly int age;

        public string BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }

        public Human(string firstName)
        {
            FirstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Human(string firstName, string lastName, int age, string birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            BirthDate = birthdate;
        }
       

        public Boolean HumanEqual(Human human2)
        {
            if (FirstName == human2.FirstName && LastName == human2.LastName && BirthDate == human2.BirthDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
