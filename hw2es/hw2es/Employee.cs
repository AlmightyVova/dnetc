using System;

namespace hw2es
{
    public enum Posts
    {
        Trainee,
        Junior,
        Middle,
        Senior,
        ProjectManager,
        CEO
    }

    public class Employee
    {
        private string Name { get; }
        private string Surname { get; }
        private Posts Post { get; set; } = Posts.Trainee;
        private int LengthOfService { get; set; }
        private double Salary { get; set; }
        private double Taxation => Salary * 0.2;
        private double ATIncome => Salary-Taxation;

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void SetPost(Posts post)
        {
            Post = post;
        }

        public void SetLengthOfService(int lengthOfService)
        {
            LengthOfService = lengthOfService;
        }

        public void CalculateSalary()
        {
            Salary = 50 * LengthOfService * (int) Post;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}\n" +
                              $"Surname: {Surname}\n" +
                              $"Post: {Post}\n" +
                              $"Salary: {Salary}\n" +
                              $"Taxation: {Taxation}\n"+
                              $"After-Tax Income: {ATIncome}");
        }
    }
}