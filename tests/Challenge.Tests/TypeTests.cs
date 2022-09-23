using ChallengeApp;
using Xunit;

namespace Challenge.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetEmployeeReturnsDifferentObjects()
        {
            var emp1 = GetEmployee("Adam");
            var emp2 = GetEmployee("Ewa");

            Assert.NotSame(emp1, emp2);
            Assert.False(Object.ReferenceEquals(emp1, emp2));
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {

            var emp1 = GetEmployee("Adam");
            var emp2 = emp1;

            Assert.True(Object.ReferenceEquals(emp1, emp2));
            Assert.Same(emp1, emp2);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var emp1 = GetEmployee("Employee 1");
            GetEmployeeSetName(out emp1, "New Name");
            Assert.Equal("New Name", emp1.Name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var emp1 = GetEmployee("Adam");
            SetName(emp1, "NewName");
            Assert.Equal("NewName", emp1.Name);
        }

        private static void GetEmployeeSetName(out Employee emp, string name)
        {
            emp = new Employee(name);
        }

        private static Employee GetEmployee(string name)
        {
            return new Employee(name);
        }

        private static void SetName(Employee employee, string name)
        {
            employee.Name = name;
        }
    }
}
