using System;

namespace POOConcepts
{
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main()
        {
            ////Inheritance
            var test1 = new Tester();

            var tester2 = new Tester(1);

            var tester3 = new Tester("Tester");
        }

        //safely cast
        public static void LogEmployee(Employee employee)
        {
            employee.LogMethod();

            if (employee is Tester) Console.WriteLine($"this employee is a tester {(employee as Tester).TesterKey}");
            if (employee is Developer)
                Console.WriteLine($"this employee is a tester {(employee as Developer).DeveloperKey}");
        }
    }
}