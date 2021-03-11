using System;

namespace POOConcepts
{
    public class Employee
    {
        public string Name { get; set; }

        public Employee()
        {
            Console.WriteLine("Employee empty constructor");
        }

        public Employee(string name)
        {
            this.Name = name;
            Console.WriteLine("Employee with parameter constructor");
        }

        public virtual void LogMethod()
        {
            Console.WriteLine("Employee LogMethod");
        }
    }
}