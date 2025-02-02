//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class SpecialFunctionsTests
//    {
//        [TestMethod]
//        [DataRow(1.0, 1.0, 0.6321205588285577)] // Typical case
//        [DataRow(2.5, 3.0, 0.8012528742177771)] // Typical case
//        [DataRow(0.1, 0.1, 0.9054140840791538)] // Edge case with small values
//        [DataRow(1.0, 0.0, 0.0)]                // Edge case where x is zero
//        [DataRow(0.0, 1.0, 1.0)]                // Edge case where a is zero
//        public void GammaLowerRegularized_ValidInputs_ReturnsExpected(double a, double x, double expected)
//        {
//            // Act
//            double result = SpecialFunctions.GammaLowerRegularized(a, x);

//            // Assert
//            Assert.AreEqual(expected, result, 1e-15, $"Failed for a={a}, x={x}");
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void GammaLowerRegularized_NegativeA_ThrowsException()
//        {
//            // Act
//            SpecialFunctions.GammaLowerRegularized(-1.0, 1.0);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void GammaLowerRegularized_NegativeX_ThrowsException()
//        {
//            // Act
//            SpecialFunctions.GammaLowerRegularized(1.0, -1.0);
//        }

//        [TestMethod]
//        public void GammaLowerRegularized_LargeValues_ReturnsExpected()
//        {
//            // Arrange
//            double a = 100.0;
//            double x = 100.0;
//            double expected = 0.5; // Expected result for large equal values

//            // Act
//            double result = SpecialFunctions.GammaLowerRegularized(a, x);

//            // Assert
//            Assert.AreEqual(expected, result, 1e-15);
//        }

//        [TestMethod]
//        public void GammaLowerRegularized_SmallValues_ReturnsExpected()
//        {
//            // Arrange
//            double a = 1e-5;
//            double x = 1e-5;
//            double expected = 0.999995;

//            // Act
//            double result = SpecialFunctions.GammaLowerRegularized(a, x);

//            // Assert
//            Assert.AreEqual(expected, result, 1e-5);
//        }
//    }
//}
