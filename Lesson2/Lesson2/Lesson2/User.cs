using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    struct UserDate
    {
        public static string GetDate()
        {
            string date = "23.11.2022";
            return date;
        }
    }
   
   
    //public class UserList
    //{
    //    public Login Login;

    //    public void Show()
    //    {
    //        Login.Show();
    //    }
    //}
        
    class User
    {
        string login, name, secondName, age;
        public readonly string date;
        

        public string Login
        {
            set { login = value; }
            get { return login;  }
        }
       
       

        public string Name
        {
            set { name = value; }
            get { return name; }
        }


        public string SecondName
        {
            set { secondName = value; }
            get { return secondName; }
        }

        public string Age
        {
            set { age = value; }
            get { return age; }
        }

        public User()
        {
            date = UserDate.GetDate();
        }

        public User(string login, string name, string secondName, string age)
        {
            this.login = login;
            this.name = name;
            this.secondName = secondName;
            this.age = age;
            date = UserDate.GetDate();
        }
        public void Show()
        {
            Console.WriteLine(Login);
            Console.WriteLine(Name);
            Console.WriteLine(SecondName);
            Console.WriteLine(Age);
            Console.WriteLine(date);
        }


    }
}
