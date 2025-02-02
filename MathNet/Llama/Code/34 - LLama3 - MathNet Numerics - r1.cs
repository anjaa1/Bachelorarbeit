//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Numerics;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class ComplexExtensionsTests
//    {
//        [TestMethod]
//        public void SquareRoot_TypicalCase_ReturnsCorrectSquareRoot()
//        {
//            // Arrange
//            Complex complex = new Complex(4, 3);

//            // Act
//            Complex result = ComplexExtensions.SquareRoot(complex);

//            // Assert
//            Assert.AreEqual(new Complex(2, 1.224744871391589), result, 1e-9);
//        }

//        [TestMethod]
//        public void SquareRoot_EdgeCase_LargeNumber_ReturnsCorrectSquareRoot()
//        {
//            // Arrange
//            Complex complex = new Complex(1000000, 300000);

//            // Act
//            Complex result = ComplexExtensions.SquareRoot(complex);

//            // Assert
//            Assert.AreEqual(new Complex(1000, 148.3756228142868), result, 1e-9);
//        }

//        [TestMethod]
//        public void SquareRoot_EdgeCase_SmallNumber_ReturnsCorrectSquareRoot()
//        {
//            // Arrange
//            Complex complex = new Complex(0.000001, 0.000003);

//            // Act
//            Complex result = ComplexExtensions.SquareRoot(complex);

//            // Assert
//            Assert.AreEqual(new Complex(0.001, 0.0010397782600555705), result, 1e-9);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void SquareRoot_InvalidInput_NonComplexNumber_ThrowsArgumentException()
//        {
//            // Arrange
//            double real = 4;
//            double imaginary = 3;

//            // Act
//            ComplexExtensions.SquareRoot(new Complex(real, imaginary));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void SquareRoot_InvalidInput_NaN_ThrowsArgumentException()
//        {
//            // Arrange
//            double real = double.NaN;
//            double imaginary = 3;

//            // Act
//            ComplexExtensions.SquareRoot(new Complex(real, imaginary));
//        }
//    }
//}
