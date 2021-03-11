using System;

namespace POOConcepts
{
    public class Developer : Employee
    {
        public int DeveloperKey { get; set; }

        public Developer()
        {
            Console.WriteLine("Developer empty constructor");
        }
        public Developer(string name)
        {
            this.Name = name;
            Console.WriteLine("Developer with parameter constructor");
        }

        public new void LogMethod()
        {
            Console.WriteLine("Developer log");
        }


        public void LogTime()
        {
            Console.WriteLine("Developer LogWork");
        }
        public void LogTime(int i = 0)
        {
            Console.WriteLine("Developer LogWork int");
        }
        public void LogTime(double i)
        {
            Console.WriteLine("Developer LogWork double");
        }
        public int LogTime(int i, double t)
        {
            Console.WriteLine("Developer LogWork retrun");
            return (int)t;
        }
    }
}