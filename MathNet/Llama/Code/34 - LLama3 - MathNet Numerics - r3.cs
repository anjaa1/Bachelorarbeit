using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using MathNet.Numerics;

namespace MathNet.Numerics.Tests
{
    [TestClass]
    public class ComplexExtensionsTests
    {
        [TestMethod]
        public void SquareRoot_TypicalCase_ReturnsCorrectSquareRoot()
        {
            // Arrange
            Complex complex = new Complex(4, 3);

            // Act
            Complex result = ComplexExtensions.SquareRoot(complex);

            // Assert
            Assert.AreEqual(new Complex(2.1213203435596424, 1.224744871391589), result);
        }

        [TestMethod]
        public void SquareRoot_EdgeCase_LargeNumber_ReturnsCorrectSquareRoot()
        {
            // Arrange
            Complex complex = new Complex(1000000, 300000);

            // Act
            Complex result = ComplexExtensions.SquareRoot(complex);

            // Assert
            Assert.AreEqual(new Complex(1010.9477362581745, 148.3756228142868), result);
        }

        [TestMethod]
        public void SquareRoot_EdgeCase_SmallNumber_ReturnsCorrectSquareRoot()
        {
            // Arrange
            Complex complex = new Complex(0.000001, 0.000003);

            // Act
            Complex result = ComplexExtensions.SquareRoot(complex);

            // Assert
            Assert.AreEqual(new Complex(0.001442615274452683, 0.0010397782600555705), result);
        }

        [TestMethod]
        public void SquareRoot_InvalidInput_NonComplexNumber_DoesNotThrowArgumentException()
        {
            // Arrange
            double real = 4;
            double imaginary = 3;

            // Act
            ComplexExtensions.SquareRoot(new Complex(real, imaginary));

            // Assert
            // No exception is thrown
        }

        [TestMethod]
        public void SquareRoot_InvalidInput_NaN_DoesNotThrowArgumentException()
        {
            // Arrange
            double real = double.NaN;
            double imaginary = 3;

            // Act
            ComplexExtensions.SquareRoot(new Complex(real, imaginary));

            // Assert
            // No exception is thrown
        }
    }
}
