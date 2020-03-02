using System;
using System.Threading.Channels;

namespace Classes_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполните информацию о пользователе");
            
            var user = new User();
            
            Console.Write("Логин: ");
            user.Login = Console.ReadLine();
            
            Console.Write("Имя: ");
            user.FirstName = Console.ReadLine();
            
            Console.Write("Фамилия: ");
            user.LastName = Console.ReadLine();
            
            Console.Write("Возраст: ");
            user.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine(user);
            
            Console.ReadLine();
        }
    }
}