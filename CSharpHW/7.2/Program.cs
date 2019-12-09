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
            Human Alex = new Human();
            Human Borys = new Human("Borys", "Ivanov");
            Human Borys2 = new Human ("Borys", "Ivanov");
            Human Ivan = new Human("Ivan","Ivanov");
            Human.HumanEqual(Borys,Borys2);
        }
    }

    class Human
    {
        public string BirthDate {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Age {get;} = 29;

        public  Human() {}
        public  Human(string FirstName)
        {
            this.FirstName=FirstName;
        } 
        public  Human(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public static void HumanEqual (Human human1, Human human2)
        {
            if (human1.FirstName==human2.FirstName&&human1.LastName==human2.LastName&&human1.BirthDate==human2.BirthDate)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

    }
}
