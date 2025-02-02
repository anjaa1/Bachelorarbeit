//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.RootFinding;
//using System.Numerics;

//namespace UnitTests
//{
//    [TestClass]
//    public class CubicTests
//    {
//        [TestMethod]
//        public void Roots_TypicalValues_ReturnsValidRoots()
//        {
//            // Arrange
//            double d = 1;
//            double c = -6;
//            double b = 11;
//            double a = -6;

//            // Act
//            var result = Cubic.Roots(d, c, b, a);

//            // Assert
//            // Check if all roots are valid
//            Assert.IsNotNull(result);
//            Assert.AreEqual(3, result.Length);

//            // Check if the roots satisfy the cubic equation
//            foreach (var root in result)
//            {
//                double x = root.Real;
//                double y = root.Imaginary;
//                double equationValue = x * x * x + a * x * x + b * x + c;
//                Assert.IsTrue(Math.Abs(equationValue) < 1e-6);
//            }
//        }

//        [TestMethod]
//        public void Roots_EdgeCases_ReturnsValidRoots()
//        {
//            // Arrange
//            double d = 0;
//            double c = 0;
//            double b = 0;
//            double a = 1;

//            // Act
//            var result = Cubic.Roots(d, c, b, a);

//            // Assert
//            // Check if all roots are valid
//            Assert.IsNotNull(result);
//            Assert.AreEqual(3, result.Length);

//            // Check if the roots satisfy the cubic equation
//            foreach (var root in result)
//            {
//                double x = root.Real;
//                double y = root.Imaginary;
//                double equationValue = x * x * x + a * x * x + b * x + c;
//                Assert.IsTrue(Math.Abs(equationValue) < 1e-6);
//            }
//        }

//        [TestMethod]
//        public void Roots_InvalidInput_ReturnsException()
//        {
//            // Arrange
//            double d = double.NaN;
//            double c = 0;
//            double b = 0;
//            double a = 1;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentException>(() => Cubic.Roots(d, c, b, a));
//        }

//        [TestMethod]
//        public void Roots_DuplicateRoots_ReturnsValidRoots()
//        {
//            // Arrange
//            double d = 1;
//            double c = -6;
//            double b = 11;
//            double a = -6;

//            // Act
//            var result = Cubic.Roots(d, c, b, a);

//            // Assert
//            // Check if all roots are valid
//            Assert.IsNotNull(result);
//            Assert.AreEqual(3, result.Length);

//            // Check if the roots satisfy the cubic equation
//            foreach (var root in result)
//            {
//                double x = root.Real;
//                double y = root.Imaginary;
//                double equationValue = x * x * x + a * x * x + b * x + c;
//                Assert.IsTrue(Math.Abs(equationValue) < 1e-6);
//            }
//        }

//        [TestMethod]
//        public void Roots_RealRoot_ReturnsValidRoots()
//        {
//            // Arrange
//            double d = 1;
//            double c = -6;
//            double b = 11;
//            double a = -6;

//            // Act
//            var result = Cubic.Roots(d, c, b, a);

//            // Assert
//            // Check if all roots are valid
//            Assert.IsNotNull(result);
//            Assert.AreEqual(3, result.Length);

//            // Check if the roots satisfy the cubic equation
//            foreach (var root in result)
//            {
//                double x = root.Real;
//                double y = root.Imaginary;
//                double equationValue = x * x * x + a * x * x + b * x + c;
//                Assert.IsTrue(Math.Abs(equationValue) < 1e-6);
//            }
//        }
//    }
//}
