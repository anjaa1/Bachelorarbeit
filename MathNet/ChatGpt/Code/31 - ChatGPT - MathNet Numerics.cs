//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class SpecialFunctionsTests
//    {
//        [TestMethod]
//        public void GammaLowerRegularizedInv_ValidInputs_ShouldReturnExpectedResults()
//        {
//            // Typical case
//            double a = 2.5;
//            double y0 = 0.5;
//            double result = SpecialFunctions.GammaLowerRegularizedInv(a, y0);

//            Assert.IsTrue(result > 0, "Result should be a positive number.");
//        }

//        [TestMethod]
//        public void GammaLowerRegularizedInv_ZeroY0_ShouldReturnZero()
//        {
//            // Edge case: y0 = 0
//            double a = 2.5;
//            double y0 = 0.0;
//            double result = SpecialFunctions.GammaLowerRegularizedInv(a, y0);

//            Assert.AreEqual(0.0, result, "Result should be zero when y0 is zero.");
//        }

//        [TestMethod]
//        public void GammaLowerRegularizedInv_Y0EqualToOne_ShouldReturnPositiveInfinity()
//        {
//            // Edge case: y0 = 1
//            double a = 2.5;
//            double y0 = 1.0;
//            double result = SpecialFunctions.GammaLowerRegularizedInv(a, y0);

//            Assert.AreEqual(double.PositiveInfinity, result, "Result should be positive infinity when y0 is 1.");
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void GammaLowerRegularizedInv_NegativeA_ShouldThrowException()
//        {
//            // Invalid input: a < 0
//            double a = -1.0;
//            double y0 = 0.5;
//            SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void GammaLowerRegularizedInv_Y0OutOfRange_ShouldThrowException()
//        {
//            // Invalid input: y0 < 0 or y0 > 1
//            double a = 2.5;
//            double y0 = -0.1; // Out of range
//            SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//        }

//        [TestMethod]
//        public void GammaLowerRegularizedInv_NaNInputs_ShouldReturnNaN()
//        {
//            // Invalid input: a or y0 is NaN
//            double a = double.NaN;
//            double y0 = 0.5;
//            double result = SpecialFunctions.GammaLowerRegularizedInv(a, y0);

//            Assert.IsTrue(double.IsNaN(result), "Result should be NaN when inputs contain NaN.");

//            a = 2.5;
//            y0 = double.NaN;
//            result = SpecialFunctions.GammaLowerRegularizedInv(a, y0);

//            Assert.IsTrue(double.IsNaN(result), "Result should be NaN when inputs contain NaN.");
//        }

//        [TestMethod]
//        public void GammaLowerRegularizedInv_BorderlineInputs_ShouldHandleProperly()
//        {
//            // Borderline cases near limits
//            double a = 0.0001;
//            double y0 = 0.9999;
//            double result = SpecialFunctions.GammaLowerRegularizedInv(a, y0);

//            Assert.IsTrue(result > 0, "Result should be positive for borderline inputs.");
//        }

//        [TestMethod]
//        public void GammaLowerRegularizedInv_LargeA_ShouldHandleProperly()
//        {
//            // Large a value
//            double a = 1e6;
//            double y0 = 0.5;
//            double result = SpecialFunctions.GammaLowerRegularizedInv(a, y0);

//            Assert.IsTrue(result > 0, "Result should be positive for large a values.");
//        }
//    }
//}
