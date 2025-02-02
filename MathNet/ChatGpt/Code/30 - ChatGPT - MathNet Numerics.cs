//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class SpecialFunctionsTests
//    {
//        [TestMethod]
//        public void ExponentialIntegral_ValidInput_TypicalCase()
//        {
//            // Arrange
//            double x = 2.0;
//            int n = 1;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(result > 0, "Result should be positive for typical case.");
//        }

//        [TestMethod]
//        public void ExponentialIntegral_ValidInput_EdgeCase_xZero()
//        {
//            // Arrange
//            double x = 0.0;
//            int n = 2;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.AreEqual(0.5, result, 1e-13, "Result for x=0 and n=2 should be 0.5.");
//        }

//        [TestMethod]
//        public void ExponentialIntegral_ValidInput_EdgeCase_nZero()
//        {
//            // Arrange
//            double x = 1.0;
//            int n = 0;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.AreEqual(Math.Exp(-1), result, 1e-13, "Result for n=0 and x=1 should match expected value.");
//        }

//        [TestMethod]
//        public void ExponentialIntegral_InvalidInput_NegativeX()
//        {
//            // Arrange
//            double x = -1.0;
//            int n = 1;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SpecialFunctions.ExponentialIntegral(x, n));
//        }

//        [TestMethod]
//        public void ExponentialIntegral_InvalidInput_NegativeN()
//        {
//            // Arrange
//            double x = 1.0;
//            int n = -1;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SpecialFunctions.ExponentialIntegral(x, n));
//        }

//        [TestMethod]
//        public void ExponentialIntegral_SmallX_ConvergenceTest()
//        {
//            // Arrange
//            double x = 0.1;
//            int n = 2;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(result > 0, "Result should be positive for small x.");
//        }

//        [TestMethod]
//        public void ExponentialIntegral_LargeX_ConvergenceTest()
//        {
//            // Arrange
//            double x = 10.0;
//            int n = 3;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(result > 0, "Result should be positive for large x.");
//        }

//        [TestMethod]
//        public void ExponentialIntegral_SpecialCase_SmallN()
//        {
//            // Arrange
//            double x = 5.0;
//            int n = 1;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(result > 0, "Result should be positive for small n.");
//        }

//        [TestMethod]
//        public void ExponentialIntegral_SpecialCase_ExactValueCheck()
//        {
//            // Arrange
//            double x = 1.0;
//            int n = 2;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            double expected = 0.148495506775922;
//            Assert.AreEqual(expected, result, 1e-13, "Result does not match expected value.");
//        }
//    }
//}
