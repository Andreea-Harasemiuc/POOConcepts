using System;

namespace POOConcepts
{
    public class Tester : Employee
    {
        public int TesterKey;
        public Tester()
        {
            Console.WriteLine("Tester empty constructor");
        }
        public Tester(int key)
        {
            TesterKey = key;
            Console.WriteLine($"Tester with parameter constructor {TesterKey}");
        }
        public Tester(string name) : base(name)
        {
            Console.WriteLine("Tester with parameter constructor with base call");
        }

        public override void LogMethod()
        {
            Console.WriteLine("Tester LogMethod");
        }
    }
}