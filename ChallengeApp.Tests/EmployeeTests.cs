using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            //arrange
            var employee = new EmployeeInFile("Tomasz", "Szletter");
            employee.AddGrade(90);


            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(90, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            //arrange
            var employee = new EmployeeInFile("Tomasz", "Szletter");
            employee.AddGrade(2);


            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            //arrange
            var employee = new EmployeeInFile("Tomasz", "Szletter");
            employee.AddGrade(90);
            employee.AddGrade(20);

            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(46, 2, statistics.Average);
        }
    }
}