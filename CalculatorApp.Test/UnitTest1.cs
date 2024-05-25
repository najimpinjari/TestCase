using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using Calculator;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_SimpleValues_ReturnsSum()
        {
            // Arrange
            CalculaterMain calculator = new CalculaterMain();
            int a = 5;
            int b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_SimpleValues_ReturnsDifference()
        {
            // Arrange
            CalculaterMain calculator = new CalculaterMain();
            int a = 5;
            int b = 3;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
