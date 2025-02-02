//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using System.Numerics;
//using MathNet.Numerics;

//namespace ComplexExtensionsTests
//{
//    [TestClass]
//    public class ToComplexTests
//    {
//        private readonly IFormatProvider _formatProvider = CultureInfo.InvariantCulture;

//        [TestMethod]
//        public void ToComplex_ValidPositiveInfinity_ReturnsComplex()
//        {
//            // Arrange
//            string input = "Infinity + Infinityi";
//            Complex expected = new Complex(double.PositiveInfinity, double.PositiveInfinity);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ToComplex_ValidRealNumber_ReturnsComplex()
//        {
//            // Arrange
//            string input = "5";
//            Complex expected = new Complex(5, 0);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ToComplex_ValidImaginaryNumber_ReturnsComplex()
//        {
//            // Arrange
//            string input = "5i";
//            Complex expected = new Complex(0, 5);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ToComplex_ValidComplexNumberWithPlus_ReturnsComplex()
//        {
//            // Arrange
//            string input = "3 + 4i";
//            Complex expected = new Complex(3, 4);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ToComplex_ValidComplexNumberWithMinus_ReturnsComplex()
//        {
//            // Arrange
//            string input = "3 - 4i";
//            Complex expected = new Complex(3, -4);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ToComplex_ValidTupleFormat_ReturnsComplex()
//        {
//            // Arrange
//            string input = "(3,4)";
//            Complex expected = new Complex(3, 4);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void ToComplex_NullInput_ThrowsArgumentNullException()
//        {
//            // Arrange
//            string input = null;

//            // Act
//            input.ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FormatException))]
//        public void ToComplex_EmptyString_ThrowsFormatException()
//        {
//            // Arrange
//            string input = "";

//            // Act
//            input.ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FormatException))]
//        public void ToComplex_InvalidFormat_ThrowsFormatException()
//        {
//            // Arrange
//            string input = "abc";

//            // Act
//            input.ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FormatException))]
//        public void ToComplex_MismatchedParentheses_ThrowsFormatException()
//        {
//            // Arrange
//            string input = "(3,4";

//            // Act
//            input.ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        public void ToComplex_ValidNegativeImaginaryNumber_ReturnsComplex()
//        {
//            // Arrange
//            string input = "-4i";
//            Complex expected = new Complex(0, -4);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }



//        [TestMethod]
//        public void ToComplex_ValidNegativeInfinity_ReturnsComplex()
//        {
//            // Arrange
//            string input = "-Infinity - Infinityi";
//            Complex expected = new Complex(double.NegativeInfinity, double.NegativeInfinity);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ToComplex_ValidNaN_ReturnsComplex()
//        {
//            // Arrange
//            string input = "NaN + NaNi";
//            Complex expected = new Complex(double.NaN, double.NaN);

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(expected.Real, result.Real);
//            Assert.AreEqual(expected.Imaginary, result.Imaginary);
//        }
//    }
//}
