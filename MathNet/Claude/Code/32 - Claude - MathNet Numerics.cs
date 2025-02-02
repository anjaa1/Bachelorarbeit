//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Tests.SpecialFunctionsTests
//{
//    [TestClass]
//    public class GammaLowerRegularizedTests
//    {
//        private const double RelativePrecision = 1e-14;

//        [TestMethod]
//        public void TestNormalCases()
//        {
//            // Known values calculated using high-precision software
//            var testCases = new[]
//            {
//                (a: 1.0, x: 1.0, expected: 0.632120558828558),
//                (a: 2.0, x: 2.0, expected: 0.593994150290126),
//                (a: 3.0, x: 1.5, expected: 0.240097869802562),
//                (a: 0.5, x: 1.0, expected: 0.842700792949715)
//            };

//            foreach (var (a, x, expected) in testCases)
//            {
//                double result = SpecialFunctions.GammaLowerRegularized(a, x);
//                Assert.AreEqual(expected, result, RelativePrecision,
//                    $"Failed for a={a}, x={x}");
//            }
//        }

//        [TestMethod]
//        public void TestEdgeCases()
//        {
//            // Test a = 0
//            Assert.AreEqual(1.0, SpecialFunctions.GammaLowerRegularized(0.0, 0.0),
//                "Should return 1.0 when both a and x are 0");
//            Assert.AreEqual(1.0, SpecialFunctions.GammaLowerRegularized(0.0, 1.0),
//                "Should return 1.0 when a is 0");

//            // Test x = 0
//            Assert.AreEqual(0.0, SpecialFunctions.GammaLowerRegularized(1.0, 0.0),
//                "Should return 0.0 when x is 0 and a > 0");

//            // Test large values
//            double largeX = 100.0;
//            double largeA = 50.0;
//            double result = SpecialFunctions.GammaLowerRegularized(largeA, largeX);
//            Assert.IsTrue(result >= 0.0 && result <= 1.0,
//                "Result should be between 0 and 1 for large values");
//        }

//        [TestMethod]
//        public void TestSmallValues()
//        {
//            // Test with very small positive values
//            double smallValue = 1e-10;
//            double result = SpecialFunctions.GammaLowerRegularized(smallValue, smallValue);
//            Assert.IsTrue(result >= 0.0 && result <= 1.0,
//                "Result should be between 0 and 1 for small values");
//        }

//        [TestMethod]
//        public void TestMonotonicity()
//        {
//            // Test that function is monotonically increasing with x
//            double a = 1.5;
//            double x1 = 1.0;
//            double x2 = 2.0;

//            double result1 = SpecialFunctions.GammaLowerRegularized(a, x1);
//            double result2 = SpecialFunctions.GammaLowerRegularized(a, x2);

//            Assert.IsTrue(result2 > result1,
//                "Function should be monotonically increasing with x");
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void TestNegativeAThrows()
//        {
//            SpecialFunctions.GammaLowerRegularized(-1.0, 1.0);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void TestNegativeXThrows()
//        {
//            SpecialFunctions.GammaLowerRegularized(1.0, -1.0);
//        }

//        [TestMethod]
//        public void TestBoundaryConditions()
//        {
//            // Test values near boundaries
//            var results = new[]
//            {
//                SpecialFunctions.GammaLowerRegularized(1e-15, 1.0),
//                SpecialFunctions.GammaLowerRegularized(1.0, 1e-15),
//                SpecialFunctions.GammaLowerRegularized(1e15, 1e15)
//            };

//            foreach (var result in results)
//            {
//                Assert.IsTrue(!double.IsNaN(result) && !double.IsInfinity(result),
//                    "Result should be finite and not NaN");
//                Assert.IsTrue(result >= 0.0 && result <= 1.0,
//                    "Result should be between 0 and 1");
//            }
//        }

//        [TestMethod]
//        public void TestConvergence()
//        {
//            // Test cases where the series expansion is used
//            double result1 = SpecialFunctions.GammaLowerRegularized(2.0, 0.5); // x <= 1
//            double result2 = SpecialFunctions.GammaLowerRegularized(0.5, 2.0); // x > a

//            Assert.IsTrue(!double.IsNaN(result1) && !double.IsInfinity(result1),
//                "Series expansion should converge for x <= 1");
//            Assert.IsTrue(!double.IsNaN(result2) && !double.IsInfinity(result2),
//                "Continued fraction should converge for x > a");
//        }
//    }
//}
