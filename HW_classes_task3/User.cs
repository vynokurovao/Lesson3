using System;

namespace HW_classes_task3
{
    public class User
    {
        private string _login;
        private string _name;
        private string _surname;
        private int _age;
        private readonly DateTime _date;

        public User(string login, string name, string surname, int age, DateTime date)
        {
            _login = login;
            _name = name;
            _surname = surname;
            _age = age;
            _date = date;
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public DateTime Date
        {
            get { return _date; }
        }
    }
}
