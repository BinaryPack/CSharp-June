using System;
using System.Collections.Generic;
using System.Text;

namespace WorkProject__01._07._26_
{
    internal class TaskExams2
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Игорь");
            Employee programmer = new Programmer("Иван");
            Employee manager = new Manager("Степан");
            employee.DoWork(); programmer.DoWork(); manager.DoWork();
        }
    }
    public class Employee
    {
        public string Name { get; private set; }

        public Employee(string name)
        {
            Name = name;
        }

        virtual public void DoWork()
        {
            Console.WriteLine($"[Сотрудник] {Name} просто работает.");
        }
    }
    public class Programmer : Employee
    {
        public Programmer(string Name) : base(Name)
        {
            
        }
        public override void DoWork()
        {
            Console.WriteLine($"[Сотрудник] {Name} пишет код на C#.");
        }
    }
    public class Manager : Employee
    {
        public Manager(string Name) : base(Name) { }
        public override void DoWork() { Console.WriteLine($"[Сотрудник] {Name} пьёт кофе и раздает задачи."); }
    }
}
