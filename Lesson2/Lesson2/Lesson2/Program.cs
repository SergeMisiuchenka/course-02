using System;

//Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты).
//Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) 
//без возможности его дальнейшего изменения. 
//Реализуйте вывод на экран информации о пользователе.  
namespace Lesson2
{
        class Program
        {
            static void Main()
            {            

+           }

        public static UserList CreateUserList()
        {
            Console.WriteLine("Введите данные пользователя: ");
            Console.WriteLine("Login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("SecondName: ");
            string secondName = Console.ReadLine();
            Console.WriteLine("Age: ");
            string age = (Console.ReadLine());

            //User user1 = new User();
            User userList = new User(login, name, secondName, age);
            userList.Login = login;
            userList.Name = name;
            userList.SecondName = secondName;
            userList.Age = age;

            return userList;

            

           
        }
        }
}

