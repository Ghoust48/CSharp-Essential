using System;
using System.Threading.Channels;

namespace Classes_002
{
    public class User
    {
        private string _login;
        private string _firstName;
        private string _lastName;
        private int _age;
        private readonly DateTime _date;

        public string Login
        {
            get
            {
                if (_login == null)
                {
                    return "Поле не заполнено";
                }

                return _login;
            }
            set => _login = value;
        }
        
        public string FirstName
        {
            get
            {
                if (_firstName == null)
                {
                    return "Поле не заполнено";
                }

                return _firstName;
            }
            set => _firstName = value;
        }
        
        public string LastName
        {
            get
            {
                if (_lastName == null)
                {
                    return "Поле не заполнено";
                }

                return _lastName;
            }
            set => _lastName = value;
        }

        public int Age
        {
            get
            {
                if (_age <= 0)
                {
                    Console.WriteLine("Возраст не может быть мень 0");
                    return 0;
                }

                return _age;
            }
            set => _age = value;
        }
        

        public User()
        {
            _date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Логин: {Login}\n" +
                   $"Имя: {FirstName}\n" +
                   $"Фамилия: {LastName}\n" +
                   $"Возраст: {Age}\n" +
                   $"Дата заполнения анкеты: {_date}\n";
        }
    }
}