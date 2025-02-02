//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Tests.SpecialFunctionsTests
//{
//    [TestClass]
//    public class GammaLowerRegularizedInvTests
//    {
//        private const double RelativeAccuracy = 1e-8;  // Relaxed tolerance for floating-point comparisons

//        [TestMethod]
//        public void InverseFunction_IsConsistentWithOriginal()
//        {
//            // Test various combinations of a and y0
//            var testCases = new[]
//            {
//                (a: 1.0, y0: 0.5),
//                (a: 2.0, y0: 0.8),
//                (a: 0.5, y0: 0.2),
//                (a: 5.0, y0: 0.7)
//            };

//            foreach (var (a, y0) in testCases)
//            {
//                // Get x using the inverse function
//                double x = SpecialFunctions.GammaLowerRegularizedInv(a, y0);

//                // Use x to compute y using the original function
//                double computedY = SpecialFunctions.GammaLowerRegularized(a, x);

//                // Verify that we get back approximately the same y0
//                Assert.AreEqual(y0, computedY, RelativeAccuracy,
//                    $"Inverse not consistent for a={a}, y0={y0}");
//            }
//        }

//        [TestMethod]
//        public void ZeroY0_ReturnsZero()
//        {
//            var testAs = new[] { 0.5, 1.0, 2.0, 5.0 };
//            foreach (double a in testAs)
//            {
//                double result = SpecialFunctions.GammaLowerRegularizedInv(a, 0.0);
//                Assert.AreEqual(0.0, result);
//            }
//        }

//        [TestMethod]
//        public void OneY0_ReturnsPositiveInfinity()
//        {
//            var testAs = new[] { 0.5, 1.0, 2.0, 5.0 };
//            foreach (double a in testAs)
//            {
//                double result = SpecialFunctions.GammaLowerRegularizedInv(a, 1.0);
//                Assert.IsTrue(double.IsPositiveInfinity(result));
//            }
//        }

//        [TestMethod]
//        public void Function_IsMonotonicallyIncreasing()
//        {
//            double a = 2.0;
//            double prevResult = SpecialFunctions.GammaLowerRegularizedInv(a, 0.1);

//            for (double y0 = 0.2; y0 < 0.9; y0 += 0.1)
//            {
//                double currentResult = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//                Assert.IsTrue(currentResult > prevResult,
//                    $"Function should be monotonically increasing at a={a}, y0={y0}");
//                prevResult = currentResult;
//            }
//        }

//        [TestMethod]
//        public void NaNInput_ReturnsNaN()
//        {
//            Assert.IsTrue(double.IsNaN(SpecialFunctions.GammaLowerRegularizedInv(double.NaN, 0.5)));
//            Assert.IsTrue(double.IsNaN(SpecialFunctions.GammaLowerRegularizedInv(1.0, double.NaN)));
//        }

//        [TestMethod]
//        public void InvalidA_ThrowsArgumentOutOfRangeException()
//        {
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
//                SpecialFunctions.GammaLowerRegularizedInv(-1.0, 0.5));
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
//                SpecialFunctions.GammaLowerRegularizedInv(0.0, 0.5));
//        }

//        [TestMethod]
//        public void InvalidY0_ThrowsArgumentOutOfRangeException()
//        {
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
//                SpecialFunctions.GammaLowerRegularizedInv(1.0, -0.1));
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
//                SpecialFunctions.GammaLowerRegularizedInv(1.0, 1.1));
//        }

//        [TestMethod]
//        public void SmallInput_ProducesReasonableResults()
//        {
//            double result = SpecialFunctions.GammaLowerRegularizedInv(0.1, 0.01);
//            Assert.IsTrue(result > 0 && result < 0.1,
//                "Small inputs should produce small but positive results");

//            Assert.IsTrue(double.IsFinite(result),
//                "Result should be finite for small inputs");
//        }

//        [TestMethod]
//        public void LargeInput_ProducesReasonableResults()
//        {
//            double result = SpecialFunctions.GammaLowerRegularizedInv(100.0, 0.999);
//            Assert.IsTrue(result > 0 && double.IsFinite(result),
//                "Large inputs should produce finite, positive results");
//        }
//    }
//}
