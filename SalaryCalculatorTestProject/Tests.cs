using System;
using Calculator;
using NUnit.Framework;

namespace SalaryCalculatorTestProject
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();
            
            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);
            
            // Assert
            Assert.AreEqual(104000, annualSalary);
        }
        
        [Test]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();
            
            // Act
            decimal hourlyWage = sc.GetHourlyWage(104000);
            
            // Assert
            Assert.AreEqual(50m, hourlyWage);
        }
    }
}