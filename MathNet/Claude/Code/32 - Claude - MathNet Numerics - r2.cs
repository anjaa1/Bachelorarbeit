//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Tests.SpecialFunctionsTests
//{
//    [TestClass]
//    public class GammaLowerRegularizedTests
//    {
//        [TestMethod]
//        public void TestZeroHandling()
//        {
//            // Test a = 0 cases (as specified in the implementation)
//            Assert.AreEqual(1.0, SpecialFunctions.GammaLowerRegularized(0.0, 0.0),
//                "GammaLowerRegularized(0,0) should be 1.0");
//            Assert.AreEqual(1.0, SpecialFunctions.GammaLowerRegularized(0.0, 1.0),
//                "GammaLowerRegularized(0,x) should be 1.0");

//            // Test x = 0 case with positive a
//            Assert.AreEqual(0.0, SpecialFunctions.GammaLowerRegularized(1.0, 0.0),
//                "GammaLowerRegularized(a>0,0) should be 0.0");
//        }

//        [TestMethod]
//        public void TestValueBounds()
//        {
//            // Test various inputs to ensure results are within [0,1]
//            double[] testValues = { 0.5, 1.0, 2.0, 5.0, 10.0 };

//            foreach (double a in testValues)
//            {
//                foreach (double x in testValues)
//                {
//                    double result = SpecialFunctions.GammaLowerRegularized(a, x);
//                    Assert.IsTrue(result >= 0.0 && result <= 1.0,
//                        $"Result for a={a}, x={x} should be in [0,1] but was {result}");
//                }
//            }
//        }

//        [TestMethod]
//        public void TestMonotonicity()
//        {
//            // Test that the function is monotonically increasing with x for fixed a
//            double a = 2.0;
//            double x1 = 1.0;
//            double x2 = 2.0;

//            double result1 = SpecialFunctions.GammaLowerRegularized(a, x1);
//            double result2 = SpecialFunctions.GammaLowerRegularized(a, x2);

//            Assert.IsTrue(result2 > result1,
//                $"Function should be increasing with x. f({a},{x1})={result1}, f({a},{x2})={result2}");
//        }

//        [TestMethod]
//        public void TestValidityCheck()
//        {
//            // Test normal inputs produce valid results
//            double result = SpecialFunctions.GammaLowerRegularized(1.0, 1.0);
//            Assert.IsFalse(double.IsNaN(result), "Result should not be NaN");
//            Assert.IsFalse(double.IsInfinity(result), "Result should not be infinite");
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
//        public void TestLargeValues()
//        {
//            // Test with larger values within reasonable bounds
//            double result = SpecialFunctions.GammaLowerRegularized(100.0, 100.0);
//            Assert.IsFalse(double.IsNaN(result), "Result should not be NaN for large values");
//            Assert.IsFalse(double.IsInfinity(result), "Result should not be infinite for large values");
//            Assert.IsTrue(result >= 0.0 && result <= 1.0, "Result should be in [0,1] for large values");
//        }

//        [TestMethod]
//        public void TestSmallValues()
//        {
//            // Test with small positive values
//            double result = SpecialFunctions.GammaLowerRegularized(0.1, 0.1);
//            Assert.IsFalse(double.IsNaN(result), "Result should not be NaN for small values");
//            Assert.IsFalse(double.IsInfinity(result), "Result should not be infinite for small values");
//            Assert.IsTrue(result >= 0.0 && result <= 1.0, "Result should be in [0,1] for small values");
//        }
//    }
//}
