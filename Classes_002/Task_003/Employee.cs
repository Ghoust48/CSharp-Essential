namespace Task_003
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private Post _post;
        private Experience _experience;
        private float _salary;

        public string FirstName => _firstName;
        public string LastName => _lastName;

        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void Salary(Post post, Experience experience)
        {
            _salary = (float)post * (float)experience;

            _post = post;
            _experience = experience;
        }

        public override string ToString()
        {
            return $"Имя: {FirstName} \n" +
                   $"Фамилия: {LastName} \n" +
                   $"Должность: {_post} \n" +
                   $"Стаж: {(int)_experience} \n" +
                   $"Оклад: {_salary} \n" +
                   $"Налоговый сбор: {_salary * 0.13}\n" +
                   $"{new string('-', 20)}";
        }
    }
}