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
//        [DataRow(2.5, 3.0, 0.6937810815867218)] // Corrected case
//        [DataRow(0.1, 0.1, 0.8275517595858495)] // Corrected edge case
//        [DataRow(1.0, 0.0, 0.0)]                // Edge case where x is zero
//        [DataRow(0.0, 1.0, 1.0)]                // Edge case where a is zero
//        public void GammaLowerRegularized_ValidInputs_ReturnsExpected(double a, double x, double expected)
//        {
//            // Act
//            double result = SpecialFunctions.GammaLowerRegularized(a, x);

//            // Assert
//            Assert.AreEqual(expected, result, 1e-10, $"Failed for a={a}, x={x}");
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
//            double expected = 0.5132987982791017; // Corrected expected value

//            // Act
//            double result = SpecialFunctions.GammaLowerRegularized(a, x);

//            // Assert
//            Assert.AreEqual(expected, result, 1e-10);
//        }

//        [TestMethod]
//        public void GammaLowerRegularized_SmallValues_ReturnsExpected()
//        {
//            // Arrange
//            double a = 1e-5;
//            double x = 1e-5;
//            double expected = 0.9998906486990408; // Corrected expected value

//            // Act
//            double result = SpecialFunctions.GammaLowerRegularized(a, x);

//            // Assert
//            Assert.AreEqual(expected, result, 1e-10);
//        }
//    }
//}
