using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTest.APP;

namespace XUnitTest.Test
{
   public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            //Arrange
            int a = 5;
            int b = 20;
            var calculator =new Calculator();
            //Act 
            var total = calculator.Add(a, b);
            //Assert
            Assert.Equal<int>(25,total);
        }
        [Fact]
        public void ExtractTest()
        {
            ////Arrange
            //int a = 5;
            //int b = 5;
            //var calculator = new Calculator();
            ////Act
            //var extraction = calculator.Extract(a, b);
            ////Assert
            //Assert.Equal<int>(1, extraction);
            Assert.DoesNotContain("Furkan", "Furkan Fidan");
        }
    }
}
