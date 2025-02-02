//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using MathNet.Numerics;
//using MathNet.Numerics.LinearAlgebra;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class ComplexExtensionsTests
//    {
//        [TestMethod]
//        public void ToComplex_TypicalFormats_ReturnsCorrectComplexNumbers()
//        {
//            // Arrange
//            var culture = CultureInfo.InvariantCulture;
//            var provider = culture;

//            // Act
//            var result1 = "1".ToComplex(provider);
//            var result2 = "1,1".ToComplex(provider);
//            var result3 = "1,1i".ToComplex(provider);
//            var result4 = "(1,1)".ToComplex(provider);
//            var result5 = "(1,1i)".ToComplex(provider);
//            var result6 = "1+1i".ToComplex(provider);
//            var result7 = "1+1i".ToComplex(provider);
//            var result8 = "1-1i".ToComplex(provider);
//            var result9 = "1-1i".ToComplex(provider);

//            // Assert
//            Assert.AreEqual(1, result1.Real);
//            Assert.AreEqual(0, result1.Imaginary);
//            Assert.AreEqual(1, result2.Real);
//            Assert.AreEqual(1, result2.Imaginary);
//            Assert.AreEqual(1, result3.Real);
//            Assert.AreEqual(1, result3.Imaginary);
//            Assert.AreEqual(1, result4.Real);
//            Assert.AreEqual(1, result4.Imaginary);
//            Assert.AreEqual(1, result5.Real);
//            Assert.AreEqual(1, result5.Imaginary);
//            Assert.AreEqual(1, result6.Real);
//            Assert.AreEqual(1, result6.Imaginary);
//            Assert.AreEqual(1, result7.Real);
//            Assert.AreEqual(-1, result7.Imaginary);
//            Assert.AreEqual(1, result8.Real);
//            Assert.AreEqual(-1, result8.Imaginary);
//            Assert.AreEqual(1, result9.Real);
//            Assert.AreEqual(1, result9.Imaginary);
//        }

//        [TestMethod]
//        public void ToComplex_InvalidFormats_ThrowsFormatException()
//        {
//            // Arrange
//            var culture = CultureInfo.InvariantCulture;
//            var provider = culture;

//            // Act and Assert
//            Assert.ThrowsException<FormatException>(() => "1,1,1".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => "1,1i,1i".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => "1,1i,1".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => "1,1i,1i,1".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => "1,1i,1i,1i".ToComplex(provider));
//        }

//        [TestMethod]
//        public void ToComplex_NullInput_ThrowsArgumentNullException()
//        {
//            // Arrange
//            var culture = CultureInfo.InvariantCulture;
//            var provider = culture;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentNullException>(() => (string)null.ToComplex(provider));
//        }

//        [TestMethod]
//        public void ToComplex_EmptyInput_ThrowsFormatException()
//        {
//            // Arrange
//            var culture = CultureInfo.InvariantCulture;
//            var provider = culture;

//            // Act and Assert
//            Assert.ThrowsException<FormatException>(() => "".ToComplex(provider));
//        }

//        [TestMethod]
//        public void ToComplex_LeadingOrTrailingSpaces_ThrowsFormatException()
//        {
//            // Arrange
//            var culture = CultureInfo.InvariantCulture;
//            var provider = culture;

//            // Act and Assert
//            Assert.ThrowsException<FormatException>(() => " 1".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => "1 ".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => " 1,1 ".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => "1,1 ".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => " 1+1i ".ToComplex(provider));
//            Assert.ThrowsException<FormatException>(() => "1+1i ".ToComplex(provider));
//        }
//    }
//}
