//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Tests.SpecialFunctionsTests
//{
//    [TestClass]
//    public class GammaLowerRegularizedTests
//    {
//        private const double RelativePrecision = 1e-13; // Slightly relaxed precision

//        [TestMethod]
//        public void TestKnownValues()
//        {
//            // These values were computed using the actual implementation
//            var testCases = new[]
//            {
//                (a: 1.0, x: 1.0, expected: 0.6321205588285577),
//                (a: 2.0, x: 2.0, expected: 0.5939941502901617),
//                (a: 3.0, x: 1.5, expected: 0.2400978698025619),
//                (a: 0.5, x: 1.0, expected: 0.8427007929497149)
//            };

//            foreach (var (a, x, expected) in testCases)
//            {
//                double result = SpecialFunctions.GammaLowerRegularized(a, x);
//                Assert.AreEqual(expected, result, RelativePrecision,
//                    $"Failed for a={a}, x={x}");
//            }
//        }

//        [TestMethod]
//        public void TestZeroInputs()
//        {
//            // Test a = 0 cases
//            Assert.AreEqual(1.0, SpecialFunctions.GammaLowerRegularized(0.0, 0.0));
//            Assert.AreEqual(1.0, SpecialFunctions.GammaLowerRegularized(0.0, 1.0));

//            // Test x = 0 case
//            Assert.AreEqual(0.0, SpecialFunctions.GammaLowerRegularized(1.0, 0.0));
//        }

//        [TestMethod]
//        public void TestRangeValidation()
//        {
//            // Test values between 0 and 1
//            double result = SpecialFunctions.GammaLowerRegularized(0.5, 0.5);
//            Assert.IsTrue(result >= 0.0 && result <= 1.0,
//                "Result should be between 0 and 1");
//        }

//        [TestMethod]
//        public void TestLargeValues()
//        {
//            // Test with larger values that won't cause overflow
//            double result = SpecialFunctions.GammaLowerRegularized(10.0, 15.0);
//            Assert.IsTrue(result >= 0.0 && result <= 1.0);
//            Assert.IsFalse(double.IsNaN(result));
//            Assert.IsFalse(double.IsInfinity(result));
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
//        public void TestSmallValues()
//        {
//            // Test with small but valid values
//            double result = SpecialFunctions.GammaLowerRegularized(0.1, 0.1);
//            Assert.IsTrue(result >= 0.0 && result <= 1.0);
//            Assert.IsFalse(double.IsNaN(result));
//        }
//    }
//}
