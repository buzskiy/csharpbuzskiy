   //Создайте консольное приложение.Создайте интерфейс IUser со свойствами Name, Password, Email а также методом "string GetFullInfo()". 
   //Создайте интерфейс IValidator с одним методом ValidateUser принимающим IUser.
   //Реализуйте слудующую логику: 
   //Консольное приложение спрашивает у пользователя его данные, пользователь должен ввести свое имя или еmail а также пароль.
   //Далее проверяется внутренний массив пользователей и если такой пользователь есть то происходит валидация.
   // Если валидация прошла успешно в консоль выводится инфонрмация о том когда последний раз входил в систему.
   //В качестве валидатора может быть одна из реализаций IValidator валидирующих пользователя по имени и паролю или по еmail и паролю.
   //Если пользователя нет во внутреннем массиве его необходимо добавить.
   //Программа должна предлагать вводить данные пользователя раз за разом и не завершаться. Для того чтобы программа завершилась в качестве имени пользователя,
   //еmail и пароля необходимо ввести "exit".
   
   


using System;

namespace _12
{
    class Program
    {
        static void Main()
        {
            UserBase userbase = new UserBase();

            string login = "";
            string password = "";

            while (login!="exit" && password!= "exit")
            {
                Console.WriteLine("Enter Login:");
                login = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                password = Console.ReadLine();
                userbase.ValidateUser(login, password, userbase);
            }

            Console.WriteLine("End of program");

        }
    }

    public interface IUser
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string GetFullInfo(string login, string password)
        {
            var k = "";
            return k;
        }
    }

    public interface IValidator
    {
        public void ValidateUser(IUser user)
        {

        }
    }

    public class User : IUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime lastlogin { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            lastlogin = DateTime.Now;
        }
        public string GetFullInfo(string login, string password)
        {
            var k = "";
            return k;
        }
    }
    public class UserBase : IValidator
    {
        public User[] UserDB = new User[0];
        public void AddUser(User user)
        {
            Array.Resize(ref UserDB, UserDB.Length + 1);
            UserDB[UserDB.GetUpperBound(0)] = user;
        }
        public void ValidateUser(string login, string password, UserBase userbase)
        {
            bool exists = false;
            User founduser = new User("1","1");
            foreach (User u in userbase.UserDB)
            {
                if (login == u.Login && password == u.Password)
                {
                    exists = true;
                    founduser = u;
                }
            }

            if (exists == true)
            {
                Console.WriteLine($"User Found. Username: '{founduser.Login}'. Last Login Date: '{founduser.lastlogin}'") ;
            }
            else
            {
                Console.WriteLine("User NOT found");
                User newuser = new User(login, password);
                userbase.AddUser(newuser);
            }
        }
    }
}
