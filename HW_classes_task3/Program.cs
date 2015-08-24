using System;

namespace HW_classes_task3
{
    class Program
    {
        public static void DisplayInformation(User user)
        {
            Console.WriteLine(String.Format("Login: {0}", user.Login));
            Console.WriteLine(String.Format("Name: {0}", user.Name));
            Console.WriteLine(String.Format("Surname: {0}", user.Surname));
            Console.WriteLine(String.Format("Age: {0}", user.Age));
            Console.WriteLine(String.Format("Date: {0}", user.Date));
        }
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2008, 6, 23);
            User user = new User("balina", "Alina", "Bila", 21, dt);
            DisplayInformation(user);
            Console.ReadKey();
        }
    }
}
