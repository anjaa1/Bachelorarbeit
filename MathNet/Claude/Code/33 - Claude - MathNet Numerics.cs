//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using Complex = System.Numerics.Complex;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class ComplexExtensionsTests
//    {
//        private readonly IFormatProvider _formatProvider = CultureInfo.InvariantCulture;
//        private const double Delta = 1e-10; // Tolerance for floating-point comparisons

//        [TestMethod]
//        public void ToComplex_RealNumber_ReturnsComplexWithZeroImaginary()
//        {
//            // Arrange
//            string input = "5.2";

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(5.2, result.Real, Delta);
//            Assert.AreEqual(0.0, result.Imaginary, Delta);
//        }

//        [TestMethod]
//        public void ToComplex_ImaginaryNumber_ReturnsComplexWithZeroReal()
//        {
//            // Arrange
//            string input = "3.7i";

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(0.0, result.Real, Delta);
//            Assert.AreEqual(3.7, result.Imaginary, Delta);
//        }

//        [TestMethod]
//        public void ToComplex_ComplexNumberWithPlus_ReturnsCorrectComplex()
//        {
//            // Arrange
//            string input = "2.1 + 3.4i";

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(2.1, result.Real, Delta);
//            Assert.AreEqual(3.4, result.Imaginary, Delta);
//        }

//        [TestMethod]
//        public void ToComplex_ComplexNumberWithMinus_ReturnsCorrectComplex()
//        {
//            // Arrange
//            string input = "2.1 - 3.4i";

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(2.1, result.Real, Delta);
//            Assert.AreEqual(-3.4, result.Imaginary, Delta);
//        }

//        [TestMethod]
//        public void ToComplex_ComplexNumberWithParentheses_ReturnsCorrectComplex()
//        {
//            // Arrange
//            string input = "(2.1, 3.4)";

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(2.1, result.Real, Delta);
//            Assert.AreEqual(3.4, result.Imaginary, Delta);
//        }

//        [TestMethod]
//        public void ToComplex_ImaginaryFirstWithPlus_ReturnsCorrectComplex()
//        {
//            // Arrange
//            string input = "3.4i + 2.1";

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(2.1, result.Real, Delta);
//            Assert.AreEqual(3.4, result.Imaginary, Delta);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void ToComplex_NullInput_ThrowsArgumentNullException()
//        {
//            // Act
//            string nullString = null;
//            nullString.ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FormatException))]
//        public void ToComplex_EmptyString_ThrowsFormatException()
//        {
//            // Act
//            "".ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FormatException))]
//        public void ToComplex_WhitespaceOnly_ThrowsFormatException()
//        {
//            // Act
//            "   ".ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FormatException))]
//        public void ToComplex_UnmatchedParentheses_ThrowsFormatException()
//        {
//            // Act
//            "(2.1, 3.4".ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FormatException))]
//        public void ToComplex_BothPartsImaginary_ThrowsFormatException()
//        {
//            // Act
//            "3i + 4i".ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FormatException))]
//        public void ToComplex_InvalidFormat_ThrowsFormatException()
//        {
//            // Act
//            "2.1i, 3.4i".ToComplex(_formatProvider);
//        }

//        [TestMethod]
//        public void ToComplex_NegativeNumbers_ReturnsCorrectComplex()
//        {
//            // Arrange
//            string input = "-2.1 - 3.4i";

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(-2.1, result.Real, Delta);
//            Assert.AreEqual(-3.4, result.Imaginary, Delta);
//        }

//        [TestMethod]
//        public void ToComplex_ScientificNotation_ReturnsCorrectComplex()
//        {
//            // Arrange
//            string input = "1.2e-3 + 3.4e2i";

//            // Act
//            Complex result = input.ToComplex(_formatProvider);

//            // Assert
//            Assert.AreEqual(0.0012, result.Real, Delta);
//            Assert.AreEqual(340.0, result.Imaginary, Delta);
//        }
//    }
//}
