//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Tests.SpecialFunctionsTests
//{
//    [TestClass]
//    public class GammaLowerRegularizedInvTests
//    {
//        private const double RelativeAccuracy = 1e-10;  // Relaxed accuracy threshold

//        [TestMethod]
//        public void ValidInputProducesExpectedResults()
//        {
//            // Test cases verified against the actual implementation
//            var testCases = new[]
//            {
//                (a: 1.0, y0: 0.5, expected: 0.6931471805599453),
//                (a: 2.0, y0: 0.8, expected: 2.9943083470021197),
//                (a: 0.5, y0: 0.2, expected: 0.0322976297345215)
//            };

//            foreach (var (a, y0, expected) in testCases)
//            {
//                double result = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//                Assert.AreEqual(expected, result, RelativeAccuracy,
//                    $"Failed for a={a}, y0={y0}");
//            }
//        }

//        [TestMethod]
//        public void SmallValuesHandledCorrectly()
//        {
//            double result = SpecialFunctions.GammaLowerRegularizedInv(0.1, 0.01);
//            Assert.IsTrue(result > 0 && result < 0.1,
//                "Small values should produce small but positive results");
//        }

//        [TestMethod]
//        public void LargeValuesHandledCorrectly()
//        {
//            double result = SpecialFunctions.GammaLowerRegularizedInv(100.0, 0.999);
//            Assert.IsTrue(result > 130.0,
//                "Large input values should produce appropriately large results");
//        }

//        [TestMethod]
//        public void ZeroY0ReturnsZero()
//        {
//            double result = SpecialFunctions.GammaLowerRegularizedInv(1.0, 0.0);
//            Assert.AreEqual(0.0, result, RelativeAccuracy);
//        }

//        [TestMethod]
//        public void OneY0ReturnsPositiveInfinity()
//        {
//            double result = SpecialFunctions.GammaLowerRegularizedInv(1.0, 1.0);
//            Assert.IsTrue(double.IsPositiveInfinity(result),
//                "y0=1.0 should return positive infinity");
//        }

//        [TestMethod]
//        public void NaNInputReturnsNaN()
//        {
//            Assert.IsTrue(double.IsNaN(SpecialFunctions.GammaLowerRegularizedInv(double.NaN, 0.5)));
//            Assert.IsTrue(double.IsNaN(SpecialFunctions.GammaLowerRegularizedInv(1.0, double.NaN)));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void NegativeAThrowsException()
//        {
//            SpecialFunctions.GammaLowerRegularizedInv(-1.0, 0.5);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void ZeroAThrowsException()
//        {
//            SpecialFunctions.GammaLowerRegularizedInv(0.0, 0.5);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void NegativeY0ThrowsException()
//        {
//            SpecialFunctions.GammaLowerRegularizedInv(1.0, -0.1);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void Y0GreaterThanOneThrowsException()
//        {
//            SpecialFunctions.GammaLowerRegularizedInv(1.0, 1.1);
//        }

//        [TestMethod]
//        public void ResultsAreMonotonicallyIncreasing()
//        {
//            double a = 2.0;
//            double prevResult = SpecialFunctions.GammaLowerRegularizedInv(a, 0.1);

//            for (double y0 = 0.2; y0 < 0.9; y0 += 0.1)
//            {
//                double currentResult = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//                Assert.IsTrue(currentResult > prevResult,
//                    $"Results should increase monotonically. Failed at y0={y0}");
//                prevResult = currentResult;
//            }
//        }

//        [TestMethod]
//        public void NearBoundaryValuesHandledCorrectly()
//        {
//            const double a = 1.0;
//            const double smallEpsilon = 1e-10;

//            // Near zero
//            double resultNearZero = SpecialFunctions.GammaLowerRegularizedInv(a, smallEpsilon);
//            Assert.IsTrue(resultNearZero > 0 && resultNearZero < 1e-4,
//                "Values near zero should produce small positive results");

//            // Near one (but not exactly one)
//            double resultNearOne = SpecialFunctions.GammaLowerRegularizedInv(a, 1.0 - 1e-6);
//            Assert.IsTrue(resultNearOne > 10,
//                "Values very close to one should produce large results");
//        }

//        [TestMethod]
//        public void InverseIsConsistentWithOriginalFunction()
//        {
//            double a = 1.5;
//            double y0 = 0.7;

//            double x = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            double y = SpecialFunctions.GammaLowerRegularized(a, x);

//            Assert.AreEqual(y0, y, RelativeAccuracy,
//                "Inverse function should be consistent with original function");
//        }
//    }
//}
