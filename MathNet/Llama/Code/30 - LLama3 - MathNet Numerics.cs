//using System;
//using MathNet.Numerics;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class SpecialFunctionsTests
//    {
//        [TestMethod]
//        public void TestExponentialIntegral_TypicalCases()
//        {
//            // Arrange
//            double x = 2.0;
//            int n = 1;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.AreEqual(0.219383934395520494, result, 1e-12);
//        }

//        [TestMethod]
//        public void TestExponentialIntegral_EdgeCases()
//        {
//            // Arrange
//            double x = 0.0;
//            int n = 0;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.AreEqual(1.0 / (n - 1.0), result, 1e-12);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void TestExponentialIntegral_InvalidInput()
//        {
//            // Arrange
//            double x = -2.0;
//            int n = 0;

//            // Act
//            SpecialFunctions.ExponentialIntegral(x, n);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArithmeticException))]
//        public void TestExponentialIntegral_ContinuedFractionFailure()
//        {
//            // Arrange
//            double x = 1000.0;
//            int n = 1;

//            // Act
//            SpecialFunctions.ExponentialIntegral(x, n);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArithmeticException))]
//        public void TestExponentialIntegral_SeriesFailure()
//        {
//            // Arrange
//            double x = 0.001;
//            int n = 1;

//            // Act
//            SpecialFunctions.ExponentialIntegral(x, n);
//        }
//    }
//}
