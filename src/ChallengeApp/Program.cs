using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee = new Employee("Adam");
            employee.AddGrade(24.4);

            var grades = new List<double>() { 1.34, 2.82, 3.938 };

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;


            foreach (var n in grades)
            {
                lowGrade = Math.Min(lowGrade, n);
                highGrade = Math.Max(highGrade, n);
                result += n;
            }


            result /= grades.Count;



            Console.WriteLine($"Average: {result:N3}");
            Console.WriteLine($"Highest: {highGrade}");
            Console.WriteLine($"Lowest: {lowGrade}");

            var stat = employee.GetStatistics();

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("Provide the name");
            }


        }
    }


}