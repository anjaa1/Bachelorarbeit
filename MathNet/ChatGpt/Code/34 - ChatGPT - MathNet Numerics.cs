//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Numerics;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class ComplexExtensionsTests
//    {
//        [TestMethod]
//        public void SquareRoot_RealNonNegativeNumber_ReturnsCorrectResult()
//        {
//            // Arrange
//            var input = new Complex(4, 0);
//            var expected = new Complex(2, 0);

//            // Act
//            var result = input.SquareRoot();

//            // Assert
//            Assert.AreEqual(expected, result, "Square root of a non-negative real number is incorrect.");
//        }

//        [TestMethod]
//        public void SquareRoot_RealNegativeNumber_ReturnsCorrectResult()
//        {
//            // Arrange
//            var input = new Complex(-4, 0);
//            var expected = new Complex(0, 2);

//            // Act
//            var result = input.SquareRoot();

//            // Assert
//            Assert.AreEqual(expected, result, "Square root of a negative real number is incorrect.");
//        }

//        [TestMethod]
//        public void SquareRoot_PureImaginaryPositive_ReturnsCorrectResult()
//        {
//            // Arrange
//            var input = new Complex(0, 4);
//            var expected = new Complex(1.4142135623730951, 1.4142135623730951); // sqrt(2) + i*sqrt(2)

//            // Act
//            var result = input.SquareRoot();

//            // Assert
//            Assert.AreEqual(expected, result, "Square root of a positive pure imaginary number is incorrect.");
//        }

//        [TestMethod]
//        public void SquareRoot_PureImaginaryNegative_ReturnsCorrectResult()
//        {
//            // Arrange
//            var input = new Complex(0, -4);
//            var expected = new Complex(1.4142135623730951, -1.4142135623730951); // sqrt(2) - i*sqrt(2)

//            // Act
//            var result = input.SquareRoot();

//            // Assert
//            Assert.AreEqual(expected, result, "Square root of a negative pure imaginary number is incorrect.");
//        }

//        [TestMethod]
//        public void SquareRoot_GeneralComplexNumber_ReturnsCorrectResult()
//        {
//            // Arrange
//            var input = new Complex(3, 4);
//            var expected = new Complex(2, 1); // Known result for sqrt(3 + 4i)

//            // Act
//            var result = input.SquareRoot();

//            // Assert
//            Assert.AreEqual(expected, result, "Square root of a general complex number is incorrect.");
//        }

//        [TestMethod]
//        public void SquareRoot_Zero_ReturnsZero()
//        {
//            // Arrange
//            var input = Complex.Zero;
//            var expected = Complex.Zero;

//            // Act
//            var result = input.SquareRoot();

//            // Assert
//            Assert.AreEqual(expected, result, "Square root of zero is incorrect.");
//        }

//        [TestMethod]
//        public void SquareRoot_LargeNumbers_ReturnsCorrectResult()
//        {
//            // Arrange
//            var input = new Complex(1e16, 1e16);

//            // Act
//            var result = input.SquareRoot();

//            // Assert
//            Assert.IsNotNull(result, "Square root of large numbers should not throw an exception.");
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void SquareRoot_InvalidInput_ThrowsException()
//        {
//            // Arrange
//            Complex input = default; // Simulate invalid or uninitialized Complex input

//            // Act
//            _ = input.SquareRoot();
//        }
//    }
//}
