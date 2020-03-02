using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Игорь", "Слепухин");
            
            employee.Salary(Post.Senior, Experience.More);

            Console.WriteLine(employee);
            
            Console.ReadLine();
        }
    }
}