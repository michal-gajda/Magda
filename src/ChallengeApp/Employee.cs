using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public sealed class Employee
    {
        private readonly List<double> grades = new();

        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }


        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;


            foreach (var grade in this.grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }


            result.Average /= this.grades.Count;

            return result;


        }

    }
}