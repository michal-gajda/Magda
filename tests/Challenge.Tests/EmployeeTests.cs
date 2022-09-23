using ChallengeApp;
using Xunit;

namespace Challenge.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void CheckAverageHighLow()
        {
            //arrange
            var emp = new Employee("Adam");
            emp.AddGrade(12.3);
            emp.AddGrade(88.9);
            emp.AddGrade(0.22);

            //act moment egzekucji na teście
            var result = emp.GetStatistics();

            //assert sprawdzenie czy wartosc rzeczywista jest zgodna z oczekiwaną
            Assert.Equal(33.8, result.Average, 1);
            Assert.Equal(88.9, result.High);
            Assert.Equal(0.22, result.Low);

        }
    }
}